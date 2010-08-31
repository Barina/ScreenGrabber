using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using mshtml;
using SlimDX.Direct3D9;
using ScreenGrabber.Properties;
using SHDocVw;

namespace ScreenGrabber
{
    static class Program
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr SetActiveWindow(IntPtr hWnd);
        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        public static ScreenGrabberMain main;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// <param name="args">An array of command line commands. currently program support only 'snap' command</param>
        [STAThread]
        static void Main(string[] args)
        {
            //try
            //{
                Application.SetCompatibleTextRenderingDefault(false);

                try
                {
                    // ----------------> database connection <-----------------------//
                    tableAdapterManager = new ScreenGrabber.SnapsDatabaseDataSetTableAdapters.TableAdapterManager();
                    tableAdapterManager.AccountsTableAdapter = new ScreenGrabber.SnapsDatabaseDataSetTableAdapters.AccountsTableAdapter();
                    tableAdapterManager.SnapsTableAdapter = new ScreenGrabber.SnapsDatabaseDataSetTableAdapters.SnapsTableAdapter();
                    // ----------------
                }
                catch { }

                if(Settings.Default.AccountID == -1)
                    if(!checkAccountID())
                        return;

                #region Filling basic parameters.
                bmp = null;
                grabberPosition = Settings.Default.grabberPosition;
                tempOperation = false; // true if the program starts with the 'snap' commandline argument

                if(Settings.Default.grabberSize == new Size(0, 0))// its a struct then using the parameters insted of reference
                    grabberSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                else
                    grabberSize = Settings.Default.grabberSize;
                busyTimer = new System.Timers.Timer(900);
                busyTimer.Elapsed += new System.Timers.ElapsedEventHandler(busyTimer_Elapsed);
                #endregion

                bool createdNew = true;
                using(Mutex mutex = new Mutex(true, "ScreenGrabber", out createdNew))   // checking if there is another instance of ScreenGrabber already runing
                {
                    if(args.Length > 0 && (args.Contains("snap")))
                    {
                        tempOperation = true;
                        grabScreen();
                        if(Settings.Default.Path == "none" || Settings.Default.Path == "")
                        {
                            Settings.Default.Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ScreenGrabber\\Screen.png";
                            Settings.Default.Save();
                        }
                        saveToFile(Settings.Default.Path, snap);
                        return;
                    }

                    if(createdNew)
                    {
                        main = new ScreenGrabberMain();
                        Application.EnableVisualStyles();
                        Application.Run(main);
                    }
                    else
                    {   // getting here means there are already instance of ScreenGrabber runing
                        Process current = Process.GetCurrentProcess();
                        foreach(Process process in Process.GetProcessesByName(current.ProcessName))
                            if(process.Id == current.Id)
                            {
                                if(!ShowWindow(process.Handle, 9))// 9 is for restore
                                    SetActiveWindow(process.Handle);
                                MessageBox.Show("ScreenGrabber is already runing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                    }
                }
            //}
            //catch(Exception exc)
            //{
            //    MessageBox.Show("Exception message:\n" + exc.Message + "\n\nException StackTrace:\n" + exc.StackTrace + "\n\nException Data:\n" +
            //        exc.Data + "\n\nExption Source:\n" + exc.Source + "\n\nException Inner Exception:\n" + exc.InnerException + "\n\nHelp Links:\n"
            //        + exc.HelpLink + "\n\nMore details:\n" + exc, "Exception details");
            //}
            //finally
            //{
            //    if(tableAdapterManager != null)
            //    {
            //        tableAdapterManager.Connection.Close();
            //        tableAdapterManager.Dispose();
            //    }
            //}
        }

        static void busyTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            busyTimer.Stop();
        }

        #region components
        static bool tempOperation;
        private static Image bmp;
        public static Point grabberPosition;
        public static Size grabberSize;
        public static SnapsDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public static Snap snap;
        public static Snap lastSnap;
        public static object SnapLocker = new object();
        public static object DatabaseLocker = new object();
        public static System.Timers.Timer busyTimer;
        #endregion

        /// <summary>
        /// Checks if there is already account with the user name. if there isn't it will be created.
        /// </summary>
        /// <returns>If database now have accountID base on user name. false to close application.</returns>
        static public bool checkAccountID()
        {
            while(true)
            {
                try //Trying to get account id from database.
                {
                    Settings.Default.AccountID = (int)tableAdapterManager.AccountsTableAdapter.GetIDByAccountName(Environment.UserName);
                    return true; //Success.
                }
                catch(System.IO.FileNotFoundException) // in case using 3rd party installer and framework not installed.
                {
                    Process.Start(@"http://blogs.msdn.com/b/stevelasker/archive/2008/08/07/sql-server-compact-3-5-sp1-released.aspx");
                    Process.Start(@"http://www.microsoft.com/downloads/details.aspx?FamilyID=dc614aee-7e1c-4881-9c32-3a6ce53384d9&displaylang=en#filelist");
                    MessageBox.Show(@"To run ScreenGrabber your system must have the folowing components:
Microsoft .NET Framework 3.5.
Get it here:
http://blogs.msdn.com/b/stevelasker/archive/2008/08/07/sql-server-compact-3-5-sp1-released.aspx

Microsoft SQL Server Compact 3.5 Service Pack 1.
Get it here:
http://www.microsoft.com/downloads/details.aspx?FamilyID=dc614aee-7e1c-4881-9c32-3a6ce53384d9&displaylang=en#filelist

Sorry about the inconvenience.", "ScreenGrabber requirements:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                catch //If there isn't any account with user name.
                {
                    try //Creating new user.
                    {
                        tableAdapterManager.AccountsTableAdapter.InsertAccount(Environment.UserName);
                        tableAdapterManager.UpdateAll(new SnapsDatabaseDataSet());
                        MessageBox.Show("Welcome to ScreenGrabber " + Environment.UserName + "!\nNow you can save your snaps below your name.\nHave fun!",
                            "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch(Exception ex) //If somthing went wrong.
                    {
                        if(MessageBox.Show("Do you want ScreenGrabber to retry creating?\nPress NO to close ScreenGrabber.\n\nError message:\n" + ex.Message,
                           "Error creating new user", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
                        {
                            tableAdapterManager.Connection.Close();
                            tableAdapterManager.Dispose();
                            return false;//Faild.. close the application.
                        }// Clicking YES meaning to stay in the loop and try again.
                    }
                }
            }
        }

        /// <summary>
        /// Save the screen to a Image reference as image
        /// </summary>
        /// <returns>If success.</returns>
        public static bool grabScreen()
        {
            if(busyTimer.Enabled)
                return false;

            lock(SnapLocker)
            {
                busyTimer.Start();

                if(bmp != null)
                {
                    bmp.Dispose();
                    bmp = null;
                }

                short Width, Height;
                Width = (short)Screen.PrimaryScreen.Bounds.Width;
                Height = (short)Screen.PrimaryScreen.Bounds.Height;

                Graphics G;
                Point Pt = new Point(0, 0);

                if(!Settings.Default.CustomBounds)
                    bmp = new Bitmap(Width, Height);
                else
                {
                    if(grabberSize.Width <= 0)
                        grabberSize.Width = Width;
                    if(grabberSize.Height <= 0)
                        grabberSize.Height = Height;
                    bmp = new Bitmap(grabberSize.Width, grabberSize.Height);
                    Pt = grabberPosition;
                }

                G = Graphics.FromImage(bmp);
                G.CompositingQuality = CompositingQuality.HighQuality;
                G.CompositingMode = CompositingMode.SourceCopy;
                G.InterpolationMode = InterpolationMode.HighQualityBilinear;
                G.CopyFromScreen(Pt.X, Pt.Y, 0, 0, new Size(bmp.Width, bmp.Height));

                snap = new Snap(bmp, GetExt(Settings.Default.Path), DateTime.Now, Settings.Default.AccountID);

                G.Dispose();
                bmp.Dispose();

                if(tempOperation)
                {
                    try
                    {
                        if(Settings.Default.SaveSnaps)
                            tableAdapterManager.SnapsTableAdapter.InsertSnap(snap.BmpAsByteArray, snap.Date, snap.AccountID);
                    }
                    catch { }
                }                    
            }
            return true;
        }

        /// <summary>
        /// Grab a snap from DirectX frontBuffer content.
        /// </summary>
        /// <returns>If succeed.</returns>
        public static bool grabDX()//can throw exception!
        {
            if(busyTimer.Enabled)
                return false;
            lock(SnapLocker)
            {
                busyTimer.Start();

                if(bmp != null)
                {
                    bmp.Dispose();
                    bmp = null;
                }

                Direct3D direct3d = new SlimDX.Direct3D9.Direct3D();
                AdapterInformation adapter = direct3d.Adapters.DefaultAdapter;

                PresentParameters parameters = new SlimDX.Direct3D9.PresentParameters();
                parameters.BackBufferFormat = adapter.CurrentDisplayMode.Format;
                parameters.BackBufferHeight = adapter.CurrentDisplayMode.Height;
                parameters.BackBufferWidth = adapter.CurrentDisplayMode.Width;
                parameters.Multisample = SlimDX.Direct3D9.MultisampleType.None;
                parameters.SwapEffect = SlimDX.Direct3D9.SwapEffect.Discard;
                parameters.PresentationInterval = SlimDX.Direct3D9.PresentInterval.Default;
                parameters.FullScreenRefreshRateInHertz = 0;

                Device device = new Device(direct3d, adapter.Adapter, DeviceType.Hardware, parameters.DeviceWindowHandle, CreateFlags.SoftwareVertexProcessing, parameters);

                Surface surface = Surface.CreateOffscreenPlain(device, adapter.CurrentDisplayMode.Width, adapter.CurrentDisplayMode.Height, Format.A8R8G8B8, Pool.SystemMemory);

                device.GetFrontBufferData(0, surface);

                Rectangle region = new Rectangle(0, 0, adapter.CurrentDisplayMode.Width, adapter.CurrentDisplayMode.Height);

                bmp = new Bitmap(Surface.ToStream(surface, ImageFileFormat.Bmp, new Rectangle(region.Left, region.Top, region.Width, region.Height)));

                using(Graphics g = Graphics.FromImage(bmp)){
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    GraphicsPath gp = new GraphicsPath();
                    System.Drawing.Font font = new System.Drawing.Font(FontFamily.GenericSansSerif,18);                    
                    gp.AddString("Rendered using DirectX.",font.FontFamily,(int)font.Style,font.Size,new Point(10,10),StringFormat.GenericDefault);
                    g.DrawPath(new Pen(Brushes.Black,5),gp);
                    g.FillPath(Brushes.White,gp);
                }

                snap = new Snap(bmp, GetExt(Settings.Default.Path), DateTime.Now, Settings.Default.AccountID);

                bmp.Dispose();

                return true;
            }
        }

        #region Grab web content
        #region components.
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr FindWindowEx(IntPtr parent /*HWND*/, IntPtr next /*HWND*/, string sClassName, IntPtr sWindowTitle);

        [DllImport("user32.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
        public static extern IntPtr GetWindow(IntPtr hWnd, int uCmd);

        [DllImport("user32.Dll")]
        public static extern void GetClassName(int h, StringBuilder s, int nMaxCount);

        [DllImport("user32.dll")]
        private static extern bool PrintWindow(IntPtr hwnd, IntPtr hdcBlt, uint nFlags);

        public const int GW_CHILD = 5;
        public const int GW_HWNDNEXT = 2;
        #endregion

        /// <summary>
        /// Saves IE web page full content to Image reference.
        /// </summary>
        public static void grabWeb()
        {
            try
            {
                lock(SnapLocker)
                {
                    SHDocVw.WebBrowser m_browser = null;
                    SHDocVw.ShellWindows shellWindows = new SHDocVw.ShellWindowsClass();

                    //Find first availble browser window.
                    //Application can easily be modified to loop through and capture all open windows.
                    string filename;
                    foreach(SHDocVw.WebBrowser ie in shellWindows)
                    {
                        filename = Path.GetFileNameWithoutExtension(ie.FullName).ToLower();

                        if(filename.Equals("iexplore"))
                        {
                            m_browser = ie;
                            break;
                        }
                    }
                    if(m_browser == null)
                    {
                        MessageBox.Show("No IE Browser Open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if(bmp != null)
                    {
                        bmp.Dispose();
                        bmp = null;
                    }

                    //Assign Browser Document
                    mshtml.IHTMLDocument2 myDoc = (mshtml.IHTMLDocument2)m_browser.Document;
                    mshtml.IHTMLDocument3 doc3 = (mshtml.IHTMLDocument3)myDoc;

                    //URL Location
                    string myLocalLink = myDoc.url;
                    int URLExtraHeight = 0;
                    int URLExtraLeft = 0;

                    //TrimHeight and TrimLeft trims off some captured IE graphics.
                    int trimHeight = 3;
                    int trimLeft = 3;

                    //Use UrlExtra height to carry trimHeight.
                    URLExtraHeight = URLExtraHeight - trimHeight;
                    URLExtraLeft = URLExtraLeft - trimLeft;

                    setAttribute("scroll", 1, myDoc, doc3);

                    //Get Browser Window Height
                    int heightsize = getAttribute("scrollHeight", myDoc, doc3);
                    int widthsize = getAttribute("scrollWidth", myDoc, doc3);

                    //Get Screen Height
                    int screenHeight = getAttribute("clientHeight", myDoc, doc3);
                    int screenWidth = getAttribute("clientWidth", myDoc, doc3);

                    //Get bitmap to hold screen fragment.
                    Bitmap bm = new Bitmap(screenWidth, screenHeight);//, System.Drawing.Imaging.PixelFormat.Format16bppRgb555);

                    //Create a target bitmap to draw into.
                    Bitmap bm2 = new Bitmap(widthsize + URLExtraLeft, heightsize + URLExtraHeight - trimHeight);//, System.Drawing.Imaging.PixelFormat.Format16bppRgb555);
                    Graphics g2 = Graphics.FromImage(bm2);

                    Graphics g = null;
                    IntPtr hdc;
                    Image screenfrag = null;
                    int brwTop = 0;
                    int brwLeft = 0;
                    int myPage = 0;
                    IntPtr myIntptr = (IntPtr)m_browser.HWND;
                    //Get inner browser window.
                    int hwndInt = myIntptr.ToInt32();
                    IntPtr hwnd = myIntptr;
                    hwnd = GetWindow(hwnd, GW_CHILD);
                    StringBuilder sbc = new StringBuilder(256);
                    //Get Browser "Document" Handle
                    while(hwndInt != 0)
                    {
                        hwndInt = hwnd.ToInt32();
                        GetClassName(hwndInt, sbc, 256);
                        if(sbc.ToString().IndexOf("Shell DocObject View", 0) > -1) //IE6
                        {
                            hwnd = FindWindowEx(hwnd, IntPtr.Zero, "Internet Explorer_Server", IntPtr.Zero);
                            break;
                        }
                        if(sbc.ToString().IndexOf("TabWindowClass", 0) > -1) //IE7
                        {
                            hwnd = FindWindowEx(hwnd, IntPtr.Zero, "Shell DocObject View", IntPtr.Zero);
                            hwnd = FindWindowEx(hwnd, IntPtr.Zero, "Internet Explorer_Server", IntPtr.Zero);
                            break;
                        }
                        if(sbc.ToString().IndexOf("Frame Tab", 0) > -1) // IE8
                        {
                            hwnd = FindWindowEx(hwnd, IntPtr.Zero, "TabWindowClass", IntPtr.Zero);
                            hwnd = FindWindowEx(hwnd, IntPtr.Zero, "Shell DocObject View", IntPtr.Zero);
                            hwnd = FindWindowEx(hwnd, IntPtr.Zero, "Internet Explorer_Server", IntPtr.Zero);
                            break;
                        }

                        hwnd = GetWindow(hwnd, GW_HWNDNEXT);
                    }

                    //Get Screen Height (for bottom up screen drawing)
                    while((myPage * screenHeight) < heightsize)
                    {
                        setAttribute("scrollTop", (screenHeight - 5) * myPage, myDoc, doc3);
                        ++myPage;
                    }
                    //Rollback the page count by one
                    --myPage;

                    int myPageWidth = 0;

                    while((myPageWidth * screenWidth) < widthsize)
                    {
                        setAttribute("scrollLeft", (screenWidth - 5) * myPageWidth, myDoc, doc3);
                        brwLeft = getAttribute("scrollLeft", myDoc, doc3);
                        for(int i = myPage ; i >= 0 ; --i)
                        {
                            //Shoot visible window
                            g = Graphics.FromImage(bm);
                            hdc = g.GetHdc();
                            setAttribute("scrollTop", (screenHeight - 5) * i, myDoc, doc3);
                            brwTop = getAttribute("scrollTop", myDoc, doc3);
                            PrintWindow(hwnd, hdc, 0);
                            g.ReleaseHdc(hdc);
                            g.Flush();
                            screenfrag = Image.FromHbitmap(bm.GetHbitmap());
                            g2.DrawImage(screenfrag, brwLeft + URLExtraLeft, brwTop + URLExtraHeight);
                        }
                        ++myPageWidth;
                    }

                    snap = new Snap(bm2, GetExt(Settings.Default.Path), DateTime.Now, Settings.Default.AccountID);
                    lastSnap = snap;
                    main.refreshPreview();
                    if(Settings.Default.SaveSnaps)
                        SnapToDB(snap);
                        //insertSnapToDB.RunWorkerAsync(snap);
                    main.updateStatus();
                    bm.Dispose();
                    bm2.Dispose();
                    screenfrag.Dispose();
                    g.Dispose();
                    g2.Dispose();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Couldn't grab web page content.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static bool IsDTDDocument(object document)
        {
            bool retVal = false;
            IHTMLDocument5 doc5 = (IHTMLDocument5)document;
            IHTMLDocument3 doc3 = (IHTMLDocument3)document;
            //compatibility mode affects how height is computed
            if((doc3.documentElement != null) && (!doc5.compatMode.Equals("BackCompat")))
                retVal = true;            
            return retVal;
        }

        public static void setAttribute(string attribute, int value, mshtml.IHTMLDocument2 myDoc, mshtml.IHTMLDocument3 doc3)
        {
            if(!IsDTDDocument(myDoc))
                myDoc.body.setAttribute(attribute, value, 0);
            else
                doc3.documentElement.setAttribute(attribute, value, 0);
        }

        public static int getAttribute(string attribute, mshtml.IHTMLDocument2 myDoc, mshtml.IHTMLDocument3 doc3)
        {
            int retVal = 0;
            if(!IsDTDDocument(myDoc))
                retVal = (int)myDoc.body.getAttribute(attribute, 0);
            else
                retVal = (int)doc3.documentElement.getAttribute(attribute, 0);
            return retVal;
        }
        #endregion

        public static void SnapToDB(object Argument)
        {
            Snap snap;
            if(Snap.tryConvert(Argument, out snap))
            {
                if(snap != null)
                    lock(DatabaseLocker)
                    {
                        try
                        {
                            tableAdapterManager.SnapsTableAdapter.InsertSnap(snap.BmpAsByteArray, snap.Date, snap.AccountID);
                        }
                        catch(Exception Ex)
                        {
                            MessageBox.Show("There were a problem inserting Snaps to database.\n'" + Ex.Message + "'.\n\n" + Ex.StackTrace,
                                "Error adding snaps to database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
            }
        }

        /// <summary>
        /// One step before saving to a file, checking if the file is already exists
        /// </summary>
        /// <param name="filePath">Full file path to be checked if exists</param>
        /// <returns>Returns the path that was used to save the image, or 'failed' message</returns>
        static public string saveToFile(string filePath, Snap currentSnap)
        {
            if(currentSnap == null)
            {
                MessageBox.Show("Please press 'Grab screen' button.", "Nothing to save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            if(!isLegalExt(filePath))
            {
                MessageBox.Show("Currently supporting only '.png', '.bmp' or '.jpeg'.");
                return null;
            }

            if(!Directory.GetParent(filePath).Exists)
                Directory.CreateDirectory(Directory.GetParent(filePath).FullName);
            if(Settings.Default.Overwrite || !System.IO.File.Exists(filePath)) //If file does not exist - it will be saved normally            
                if(performSave(filePath, currentSnap))
                    return filePath;

            else //Otherwise if does exist - it will be save with additional of [number] symbol to the filename
            {
                if(System.IO.File.Exists(filePath)) //just another check if the file is exist to be sure
                {
                    int num = 2;
                    string fullFilePath = Path.GetDirectoryName(filePath) + "\\" + Path.GetFileNameWithoutExtension(filePath);
                    string ext = Path.GetExtension(filePath);
                    string tempPath = "";
                    while(true) //A method for adding/changing number to the real filename
                    {
                        tempPath = fullFilePath + " [" + num + "]" + ext;
                        num++;
                        if(!File.Exists(tempPath)) // checking if the new filename path is exist
                        {
                            if(performSave(tempPath, currentSnap))
                                return tempPath;
                            break;
                        }
                    }
                }
            }
            //if nothing goes wrong this is an unreachable code..
            return null;
        }

        /// <summary>
        /// Saving the Bitmap to a file
        /// </summary>
        /// <param name="filePath">A path where you want to save the file</param>
        /// <returns>True If the operation was seccessful, else return false</returns>
        static public bool performSave(string filePath, Snap currentSnap)
        {
            if(currentSnap == null)
                return false;

            Image img;

            if(Settings.Default.SaveDate)
                img = DrawDateOnImage(currentSnap.BmpAsImage, currentSnap.Date);
            else
                img = currentSnap.BmpAsImage;

            string ext = Path.GetExtension(filePath);
            switch(ext.ToUpper())
            {
                case ".PNG":
                    img.Save(filePath, ImageFormat.Png);
                    break;
                case ".BMP":
                    img.Save(filePath, ImageFormat.Bmp);
                    break;
                case ".JPG":
                case ".JPEG":
                    img.Save(filePath, ImageFormat.Jpeg);
                    break;
                default:
                    img.Dispose();
                    return false;
            }
            img.Dispose();
            return true;
        }

        /// <summary>
        /// Checks if the extension is compatible.
        /// </summary>
        /// <param name="path">Desire full Path.</param>
        /// <returns>If the extension is compatible.</returns>
        static public bool isLegalExt(string path)
        {
            switch(Path.GetExtension(path).ToUpper())
            {
                case ".PNG":
                case ".BMP":
                case ".JPG":
                case ".JPEG":
                    return true;
                default:
                    return false;
            }
        }

        /// <summary>
        /// Get imageFormat from a path string.
        /// </summary>
        /// <param name="path">Full path.</param>
        /// <returns>ImageFormat based on full path.</returns>
        static public ImageFormat GetExt(string path)
        {
            switch(Path.GetExtension(path).ToUpper())
            {
                case ".PNG":
                    return ImageFormat.Png;
                case ".BMP":
                    return ImageFormat.Bmp;
                case ".JPG":
                case ".JPEG":
                    return ImageFormat.Jpeg;
                default:
                    return null;
            }
        }

        /// <summary>
        /// Draws the snaps date on the image.
        /// </summary>
        /// <param name="img">The image you want to stamp the date on it.</param>
        /// <param name="date">The date to be stamped.</param>
        /// <returns>A new image stamped with its date.</returns>
        static public Image DrawDateOnImage(Image img, DateTime date)
        {
            using(Graphics G = Graphics.FromImage(img))
            {
                SolidBrush brush = new SolidBrush(Color.FromArgb(Settings.Default.DateBackgroundTransparency, Settings.Default.DateBackgroundColor));
                string formattedDate = date.ToString("dd.MM.yyyy - HH:mm:ss");
                PointF bgPosition = new PointF();
                GraphicsPath GP = new GraphicsPath();

                GP.AddString(formattedDate, Settings.Default.DateFont.FontFamily, (int)Settings.Default.DateFont.Style, Settings.Default.DateFont.Size,
                    new PointF(0, 0), StringFormat.GenericDefault);

                RectangleF textRect = GP.GetBounds();

                Corner position = (Corner)Settings.Default.DatePosition;

                switch(position)
                {
                    case Corner.UpLeft:
                        bgPosition = new PointF(10, 10);
                        break;
                    case Corner.UpRight:
                        bgPosition = new PointF(img.Width - textRect.Width - 20, 10);
                        break;
                    case Corner.BottomLeft:
                        bgPosition = new PointF(10, img.Height - textRect.Height - 20);
                        break;
                    case Corner.BottomRight:
                        bgPosition = new PointF(img.Width - textRect.Width - 20, img.Height - textRect.Height - 20);
                        break;
                }

                var data = GP.PathData;

                GraphicsPath shadow = new GraphicsPath();

                GP.Reset();
                GP.AddString(formattedDate, Settings.Default.DateFont.FontFamily, (int)Settings.Default.DateFont.Style, Settings.Default.DateFont.Size,
                    new PointF(bgPosition.X, bgPosition.Y), StringFormat.GenericDefault);
                shadow.AddString(formattedDate, Settings.Default.DateFont.FontFamily, (int)Settings.Default.DateFont.Style, Settings.Default.DateFont.Size,
                    new PointF(bgPosition.X+3, bgPosition.Y+2), StringFormat.GenericDefault);

                G.SmoothingMode = SmoothingMode.None;

                G.DrawRectangle(new Pen(brush), bgPosition.X, bgPosition.Y, textRect.Width + 9, textRect.Height+10);
                G.DrawRectangle(new Pen(brush), bgPosition.X, bgPosition.Y, textRect.Width + 9, textRect.Height+10);
                G.FillRectangle(brush, bgPosition.X, bgPosition.Y, textRect.Width+10, textRect.Height+10);
                
                G.SmoothingMode = SmoothingMode.HighQuality;
                G.FillPath(new SolidBrush(Color.FromArgb(100, Color.Black)), shadow);
                G.DrawPath(new Pen(Brushes.Black, 2), GP);
                G.FillPath(new SolidBrush(Settings.Default.DateColor), GP);
                
                GP.Dispose();
                shadow.Dispose();
            }
            return img;
        }
    }
}