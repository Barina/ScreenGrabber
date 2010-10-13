using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using Microsoft.Win32;
using ScreenGrabber.Properties;
using Stoppers;

namespace ScreenGrabber
{
    [Serializable]
    public partial class ScreenGrabberMain : Form
    {
        #region global components
        Point space;
        public bool activated;
        decimal min, sec, sum;
        bool repeat;
        bool autoGrabberInitiated;
        private static int userBitmaps;
        public SnapsExplorer explorer;
        Stopper counter;
        #endregion

        #region global hot key components
        [DllImport("user32", SetLastError = true)]
        private static extern int RegisterHotKey(IntPtr hwnd, int id, int fsModifiers, int vk);
        [DllImport("user32", SetLastError = true)]
        private static extern int UnregisterHotKey(IntPtr hwnd, int id);
        [DllImport("kernel32", SetLastError = true)]
        private static extern short GlobalAddAtom(string lpString);
        [DllImport("kernel32", SetLastError = true)]
        private static extern short GlobalDeleteAtom(short nAtom);

        private const int MOD_ALT = 1;
        private const int MOD_CONTROL = 2;
        private const int MOD_SHIFT = 4;
        //private const int MOD_WIN = 8;

        // the id for the hotkey
        short hotkeyID;

        public int modifier;
        public string modifierName;
        public Keys key;

        // register a global hot key
        public void RegisterGlobalHotKey(Keys hotkey, int modifiers)
        {
            try
            {
                // use the GlobalAddAtom API to get a unique ID (as suggested by MSDN docs)
                string atomName = AppDomain.GetCurrentThreadId().ToString("X8") + this.Name;
                hotkeyID = GlobalAddAtom(atomName);
                if(hotkeyID == 0)
                    throw new Exception("Unable to generate unique hotkey ID. Error code: " + Marshal.GetLastWin32Error().ToString());

                // register the hotkey, throw if any error
                if(RegisterHotKey(this.Handle, hotkeyID, modifiers, (int)hotkey) == 0)
                    throw new Exception("Unable to register hotkey. Error code: " + Marshal.GetLastWin32Error().ToString());
            }
            catch
            {
                // clean up if hotkey registration failed
                UnregisterGlobalHotKey();
            }
        }

        // unregister a global hotkey
        public void UnregisterGlobalHotKey()
        {
            if(this.hotkeyID != 0)
            {
                UnregisterHotKey(this.Handle, hotkeyID);
                // clean up the atom list
                GlobalDeleteAtom(hotkeyID);
                hotkeyID = 0;
            }
        }

        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            // let the base class process the message
            base.WndProc(ref m);

            // if this is a WM_HOTKEY message, notify the parent object
            const int WM_HOTKEY = 0x312;
            if(m.Msg == WM_HOTKEY)
            {
                if(!autoGrabberInitiated)
                {
                    grabScreen();
                    if(Settings.Default.autoSave)
                        Program.saveToFile(Settings.Default.Path, Program.lastSnap);
                    else
                    {
                        Show();
                        activated = true;
                    }
                }
            }
        }
        #endregion

        /// <summary>
        /// Main screen.
        /// </summary>
        public ScreenGrabberMain()
        {
            InitializeComponent();

            #region fill all components
            activated = true;

            if(Settings.Default.Path == "none" || Settings.Default.Path == "")
                Settings.Default.Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ScreenGrabber\\Screen.png";
            modifier = Settings.Default.Modifier;
            key = Settings.Default.Key;
            customCheckBox.Checked = Settings.Default.CustomBounds;

            positionLabel.Text = "Grabber at:" + Program.grabberPosition.X + "," + Program.grabberPosition.Y;
            sizeLabel.Text = "Size:" + Program.grabberSize.Width + "x" + Program.grabberSize.Height;
            statusLabel.Text = updateStatus();
            #endregion
        }

        #region functions
        /// <summary>
        /// updating the pictureBox to show the user a preview of the custom bounds image.
        /// </summary>
        /// <param name="position">the starting point of the area selected by the user </param>
        /// <param name="size">the size of the area(representing the end point of the rectangle)</param>
        /// <returns>a bitmap generated from the parameters above</returns>
        public Bitmap updatePreview(Point position, Size size)
        {
            if(size.Width == 0 || size.Height == 0) // always false. but still its sure to be safe :)
                throw new ArgumentException("Empty Bitmap.");
            Bitmap previewBMP;
            Graphics G;
            previewBMP = new Bitmap(size.Width, size.Height);
            G = Graphics.FromImage(previewBMP);
            G.CopyFromScreen(position, new Point(0, 0), new Size(previewBMP.Width, previewBMP.Height));
            G.Dispose();
            previewPictureBox.Image = previewBMP;
            return previewBMP;
        }

        /// <summary>
        /// Refreshing the pictureBox. if last snap bmp == null then a string will appear otherwise the content of the bmp will appear.
        /// </summary>
        public void refreshPreview()
        {
            if(Program.lastSnap != null)//snap != null && Program.snap.BmpAsImage != null)
                previewPictureBox.Image = Program.lastSnap.BmpAsImage;
            else
                previewPictureBox.Image = Properties.Resources.imageEmpty;
        }

        public void minimizeToTray()
        {
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
            activated = false;
        }

        public void restoreFromTray()
        {
            if(Settings.Default.AutoCapture)
                if(Program.snap == null)
                    Program.grabScreen();

            ShowInTaskbar = true;
            activated = true;
            WindowState = FormWindowState.Normal;
            Show();
        }

        public void timeTakeButtonToolTipSetter()
        {
            string time = "";

            if (Settings.Default.Counter.Days > 0)
                time += Settings.Default.Counter.Days + (Settings.Default.Counter.Days == 1 ? " Day and " : " Days and ");
            if (Settings.Default.Counter.Hours < 10)
                time += "0";
            time += Settings.Default.Counter.Hours + ":";
            if (Settings.Default.Counter.Minutes < 10)
                time += "0";
            time += Settings.Default.Counter.Minutes + ":";
            if (Settings.Default.Counter.Seconds < 10)
                time += "0";
            time += Settings.Default.Counter.Seconds;

            if(Settings.Default.PictureSum == 0)
                toolTip.SetToolTip(timeTakeButton, "Will grab a snapshot of your screen in " + time + " over and over until you click here again.");
            else
                toolTip.SetToolTip(timeTakeButton, "Will grab a snapshot of your screen in " + time + ". click to initiate.");
        }

        /// <summary>
        /// Simply adds date to the filepath.
        /// </summary>
        /// <param name="filePath">File path to be modified.</param>
        /// <returns>A new file path with current date attached to it.</returns>
        string addDateToPath(string filePath)
        {
            string ext = Path.GetExtension(filePath);
            string pathNoExt = Path.GetDirectoryName(filePath) + "\\" + Path.GetFileNameWithoutExtension(filePath);
            return pathNoExt + " [" + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + "]" + ext;
        }

        /// <summary>
        /// Checking if the window is within screen bounds.
        /// </summary>
        /// <param name="stickGap">The gap between screen edges and the windows(for the sticky options in the settings page).</param>
        /// <returns>New location wittin screen bounds.</returns>
        Point checkPosition(int stickGap)
        {
            Point newPos = new Point();
            newPos.X = MousePosition.X - space.X;
            newPos.Y = MousePosition.Y - space.Y;

            if(newPos.X <= stickGap)
                newPos.X = 0;
            if(newPos.X + Width >= Screen.PrimaryScreen.Bounds.Width - stickGap)
                newPos.X = Screen.PrimaryScreen.Bounds.Width - Width;
            if(newPos.Y <= stickGap)
                newPos.Y = 0;
            if(newPos.Y + Height >= Screen.PrimaryScreen.WorkingArea.Height - stickGap)
                newPos.Y = Screen.PrimaryScreen.WorkingArea.Height - Height;

            return newPos;
        }

        /// <summary>
        /// Checking if the window is within screen bounds.
        /// </summary>
        /// <returns>New location wittin screen bounds.</returns>
        Point checkPosition()
        {
            Point newPos = new Point();
            newPos.X = MousePosition.X - space.X;
            newPos.Y = MousePosition.Y - space.Y;
            if(newPos.X < 0)
                newPos.X = 0;
            if(newPos.X + Width > Screen.PrimaryScreen.Bounds.Width)
                newPos.X = Screen.PrimaryScreen.Bounds.Width - Width;
            if(newPos.Y < 0)
                newPos.Y = 0;
            if(newPos.Y + Height > Screen.PrimaryScreen.WorkingArea.Height)
                newPos.Y = Screen.PrimaryScreen.WorkingArea.Height - Height;

            return newPos;
        }

        /// <summary>
        /// A method to update the status messages.
        /// </summary>
        /// <returns>The generated main status message.</returns>
        public string updateStatus()
        {
            userBitmaps = 0;
            string result = "";
            DateTime date = new DateTime();

            positionLabel.Text = "Grabber at:" + Program.grabberPosition.X + "," + Program.grabberPosition.Y;
            sizeLabel.Text = "Size:" + Program.grabberSize.Width + "x" + Program.grabberSize.Height;

            var snaps = from snap in snapsTableAdapter.GetData()
                        select snap;

            foreach(var snap in snaps)
                if(snap.AccountID == Settings.Default.AccountID)
                {
                    userBitmaps++;
                    date = snap.DateTime;
                }

            result = userBitmaps + " snaps in total.\n";

            if(userBitmaps > 0)
                result += "Last snap taked on " + date + ".";

            statusLabel.Text = result;

            return result;
        }

        /// <summary>
        /// Calling main grabber method then inserting the new snap to DB using new thread.
        /// </summary>
        public void grabScreen()
        {
            bool success = false;
            try
            {
                if(Settings.Default.TryDXFirst)
                    success = Program.grabDX();
                else
                    throw new Exception();
            }
            catch
            {
                success = Program.grabScreen();
            }
            finally
            {
                if(success)
                {
                    if (Settings.Default.CommentEditorPopUp && (counter == null || !counter.Enabled))
                    {
                        string newComment = Program.GetComment(Program.lastSnap.BmpAsImage);
                        if (newComment != Program.snap.Comment)
                            Program.snap.Comment = newComment;
                    }
                    Program.lastSnap = Program.snap;
                    if(Settings.Default.SaveSnaps)
                        if(Program.snap != null)
                        {
                            new Thread(Program.SnapToDB).Start(Program.snap);
                            Program.snap = null;
                        }
                    refreshPreview();
                    updateStatus();
                    if(explorer != null)
                        explorer.refreshList();
                }
            }
        }

        /// <summary>
        /// Just throwing a message in the tray if save operation was suceesful.
        /// </summary>
        /// <param name="path">Path were the snap saved to.</param>
        public void notifySuccessSave(string path)
        {
            notifyIcon.ShowBalloonTip(1250, "Succeded", "Screen saved successfuly at '" + path + "'.", ToolTipIcon.Info);
            notifyIcon.BalloonTipClicked += new EventHandler(notifyIcon_BalloonTipClicked);
        }
        #endregion

        #region events
        private void Form1_Load(object sender, EventArgs e)
        {
            if(Settings.Default.Location.X != -1 && Settings.Default.Location.Y != -1)
                Location = Settings.Default.Location;
            onLoadBackgroundWorker.RunWorkerAsync();
            // register the hot key
            RegisterGlobalHotKey(key, modifier);

            switch(modifier)
            {
                case 1:
                    modifierName = "Alt";
                    break;
                case 2:
                    modifierName = "CTRL";
                    break;
                case 4:
                    modifierName = "Shift";
                    break;
                default:
                    modifierName = "Please select modifier";
                    break;
            }

            pathLabel.Text = "Saving to: " + Settings.Default.Path;
            hotKeyLabel.Text = "Global hot key: " + modifierName + "+" + key;

            notifyIcon.ShowBalloonTip(500, "Screen Grabber", "Screen Grabber is on! click " + modifierName + " + " + key + " to take a screenshot.", ToolTipIcon.Info);
            notifyIcon.Text = "Click " + modifierName + "+" + key + " to grab a screenshot!";
            MinimumSize = Size;
            MaximumSize = Size;
            if(Location.X < 0 || Location.Y < 0 || Location.X + Size.Width > Screen.PrimaryScreen.Bounds.Width || Location.Y + Size.Height > Screen.PrimaryScreen.Bounds.Height)
                Location = Settings.Default.Sticky ? checkPosition(25) : checkPosition();
            userBitmaps = 0;

            #region generate welcome message
            {
                string result = "Welcome back " + Environment.UserName + "! ";
                string welcomeMsg = updateStatus();

                if(userBitmaps == 0)
                    result += "You dont have any snaps in the database. press the Grab key to take your new snap.";
                else
                    result += "You currently have " + (userBitmaps < 2 ? userBitmaps + " snap" : userBitmaps + " snaps") + " in the database.";

                statusLabel.Text = result + welcomeMsg;
            }
            #endregion

            if (Settings.Default.AutoInitiater) // if AutoInitiater is on there is no need for taking a snap on load
                timeTakeButton.PerformClick();
            else
            {
                try
                {
                    var snapRow = (from snap in snapsTableAdapter.GetData()
                                   where snap.AccountID == Settings.Default.AccountID
                                   orderby snap.ID descending
                                   select snap).First();
                    if (snapRow != null)
                    {
                        Program.lastSnap = new Snap(Snap.byteArrayToImage(snapRow.Snap), ImageFormat.Png, snapRow.DateTime, snapRow.AccountID, null);
                        refreshPreview();
                        return;
                    }
                }
                catch { /* Sequence can contains no elements. AKA no snaps. Thats ok... */ }
                grabScreen(); // if snapRows are null OR empty
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            //restoreFromTray();
            updateStatus();
            refreshPreview();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(Settings.Default.Minimized)
                minimizeToTray();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.BackgroundImage = Properties.Resources.btnCloseHover;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.BackgroundImage = Properties.Resources.btnClose;
        }

        private void minimizeButton_MouseEnter(object sender, EventArgs e)
        {
            minimizeButton.BackgroundImage = Resources.btnMinimizeHover;
        }

        private void minimizeButton_MouseLeave(object sender, EventArgs e)
        {
            minimizeButton.BackgroundImage = Resources.btnMinimize;
        }

        private void Buttons_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;

            switch(btn.Name)
            {
                default:
                    MessageBox.Show("Not set", "Error");
                    break;

                case "saveButton": //Saving the image
                    try
                    {
                        string tempPath = "";
                        if((tempPath = Program.saveToFile(Settings.Default.Path, Program.lastSnap)) == null)
                            return;

                        notifySuccessSave(tempPath);
                    }
                    catch
                    {
                        MessageBox.Show("No data to save. Click " + modifierName + "+" + key + " to grab a screenshot!", "Error");
                    }
                    break;

                case "takeButton": //simply grab a snap of the screen
                    if(!autoGrabberInitiated)
                        grabScreen();
                    break;

                case "grabWebButton": //grab a full content of the first open web browser.
                    Program.grabWeb();
                    break;

                case "timeTakeButton": // initiate auto grabber 
                    if (counter == null || !counter.Enabled)
                    {
                        if (!Program.isLegalExt(addDateToPath(Settings.Default.Path)))
                        {
                            MessageBox.Show("Currently supporting only '.png', '.bmp' or '.jpg'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        hideButton.PerformClick();
                        activated = false;
                        Settings.Default.SaveDate = true;
                        if (repeat = Settings.Default.PictureSum == 0)
                        {
                            autoGrabberProgressBarEx.ProgressType = ProgressODoom.ProgressType.MarqueeBounce;
                            autoGrabberProgressBarEx.MarqueeStart();
                        }
                        else
                            autoGrabberProgressBarEx.Maximum = 1 + (int)Settings.Default.PictureSum;

                        sum = Settings.Default.PictureSum;

                        autoGrabberInitiated = true;
                        takeButton.Enabled = false;
                        grabWebButton.Enabled = false;

                        counter = new Stopper(Settings.Default.Counter,500);
                        counter.Tick += new EventHandler(counter_Tick);
                        counter.StopperDone += new EventHandler(counter_StopperDone);
                        counter.Stopped += new EventHandler(counter_Stopped);
                        counter.Start();
                    }
                    else
                    {
                        counter.Stop();
                        autoGrabberInitiated = false;
                        takeButton.Enabled = true;
                        grabWebButton.Enabled = true;
                        Settings.Default.SaveDate = false;
                        notifyIcon.ShowBalloonTip(1250, "Operation done.", "All snapshots saved successfuly at '" + Directory.GetParent(Settings.Default.Path) + "'." +
                            Environment.NewLine + "Click to open.", ToolTipIcon.Info);
                        notifyIcon.BalloonTipClicked += new EventHandler(notifyIcon_BalloonTipClicked);
                        timeTakeButton.Text = "Initiate AutoGrabber!";
                        timeTakeLabel.Text = "Auto grabber interval.";
                        toolTip.SetToolTip(timeTakeButton, "Grab a snap in " + Stopper.ToString(Settings.Default.Counter) + ".");
                        if (autoGrabberProgressBarEx.ProgressType == ProgressODoom.ProgressType.MarqueeBounce)
                            autoGrabberProgressBarEx.MarqueeStop();
                        autoGrabberProgressBarEx.ProgressType = ProgressODoom.ProgressType.Smooth;
                        autoGrabberProgressBarEx.Value = 0;
                    }
                    break;

                case "setBoundsButton": // starting bounds setter.
                    new BoundsSetter().Show();
                    break;
                case "minimizeButton": // minimize the form.
                    WindowState = FormWindowState.Minimized;
                    activated = false;
                    break;
                case "aboutButton": // show the about form.
                    new AboutBox().ShowDialog();
                    break;
                case "settingsButton": // opens the settings page.
                    if(new SettingsPage().ShowDialog() == DialogResult.OK)
                        updateStatus();
                    break;
                case "shortCutButton": // openint the short cuts tool.
                    new ShortCutPage().ShowDialog();
                    break;
                case "newSetterButton": // starting the new bounds setter
                    if(new NewerSetBounds().ShowDialog() == DialogResult.OK)
                    {
                        if(Settings.Default.TryDXFirst)
                        {
                            MessageBox.Show("Cannot use custom bounds when DirectX mode on.", "Please notify.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            customCheckBox.Checked = false;
                        }
                        else
                            customCheckBox.Checked = true;
                        grabScreen();
                    }
                    break;
                case "closeButton": // close the form / minimize the form
                    if(Settings.Default.CloseToTray)
                        minimizeToTray();
                    else
                        Close();
                    break;
                case "hideButton": // minimizing form to system tray
                    minimizeToTray();
                    break;
                case "mySnapsButton": // launching snaps explorer
                    if(explorer == null)
                    {
                        explorer = new SnapsExplorer();
                        explorer.Show();
                    }
                    else
                    {
                        if(explorer.WindowState == FormWindowState.Minimized)
                            explorer.WindowState = FormWindowState.Normal;
                        explorer.Focus();
                    }
                    break;
            }
        }

        void notifyIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Directory.GetParent(Settings.Default.Path).FullName);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void showWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(activated)
                minimizeToTray();
            else
                restoreFromTray();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.snap = null;
            Program.lastSnap = null;
            refreshPreview();
        }

        private void enlargeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            positionTimer.Stop();// Even when the user released the button it still held.. which means positionTimer is still runing. *
            // therefore we have to stop it at this point.
            if(Program.lastSnap != null)
                new Preview(Program.lastSnap.BmpAsImage, Program.lastSnap.Date).Show();
            else
                MessageBox.Show("Nothing to enlarge...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // * At this point.
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            enlargeToolStripMenuItem.PerformClick();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            showWindowToolStripMenuItem.PerformClick();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingsButton.PerformClick();
        }

        private void boundsSetterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newSetterButton.PerformClick();
        }

        private void masterPanel_MouseDown(object sender, MouseEventArgs e)
        {
            space.X = MousePosition.X - Location.X;
            space.Y = MousePosition.Y - Location.Y;
            positionTimer.Start();
        }

        private void masterPanel_MouseUp(object sender, MouseEventArgs e)
        {
            positionTimer.Stop();
        }

        private void customCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.CustomBounds = customCheckBox.Checked;
        }

        void counter_Tick(object sender, EventArgs e)
        {
            timeTakeButton.Text = counter.TimeLeftString;
            toolTip.SetToolTip(timeTakeButton, timeTakeButton.Text + " - Click to stop.");

            timeTakeLabel.Text = "Time left until next snap: " + counter.TimeLeftString + ".";

            if (!repeat)
            {
                TimeSpan ts = new TimeSpan((int)(Settings.Default.Counter.Days * sum + counter.DaysLeft), (int)(Settings.Default.Counter.Hours * sum+counter.HoursLeft),
                    (int)(Settings.Default.Counter.Minutes * sum+counter.MinutesLeft), (int)(Settings.Default.Counter.Seconds * sum+counter.SecondsLeft));
                timeTakeLabel.Text = "Snaps left: " + sum + ". " + timeTakeLabel.Text + " Time left: " + Stopper.ToString(ts)+".";
            }
        }

        void counter_StopperDone(object sender, EventArgs e)
        {
            if (sum > 0 || repeat)
            {
                if (sum >= 0)
                    sum--;

                if (autoGrabberProgressBarEx.ProgressType == ProgressODoom.ProgressType.Smooth)
                    autoGrabberProgressBarEx.Value++;

                grabScreen();
                Program.saveToFile(addDateToPath(Settings.Default.Path), Program.lastSnap);

                counter = new Stopper(Settings.Default.Counter,500);
                counter.Tick += counter_Tick;
                counter.StopperDone += counter_StopperDone;
                counter.Stopped += counter_Stopped;
                counter.Start();
            }
            else
            {
                autoGrabberInitiated = false;
                takeButton.Enabled = true;
                grabWebButton.Enabled = true;
                timeTakeButton.Text = "Initiate AutoGrabber!";
                timeTakeLabel.Text = "Auto grabber interval.";
                toolTip.SetToolTip(timeTakeButton, "Grab a snap in " +Stopper.ToString(Settings.Default.Counter)+ ".");
                autoGrabberProgressBarEx.MarqueeStop();
                autoGrabberProgressBarEx.ProgressType = ProgressODoom.ProgressType.Smooth;
                autoGrabberProgressBarEx.Value = 0;
                notifyIcon.ShowBalloonTip(1250, "Operation done.", "All snapshots saved successfuly at '" +
                    Directory.GetParent(Settings.Default.Path) + "'." + Environment.NewLine + "Click to open.", ToolTipIcon.Info);
                notifyIcon.BalloonTipClicked += new EventHandler(notifyIcon_BalloonTipClicked);
                restoreFromTray();
            }
        }

        void counter_Stopped(object sender, EventArgs e)
        {
            autoGrabberInitiated = false;
            takeButton.Enabled = true;
            grabWebButton.Enabled = true;
            timeTakeButton.Text = "Initiate AutoGrabber!";
            timeTakeLabel.Text = "Auto grabber interval.";
            toolTip.SetToolTip(timeTakeButton, "Grab a snap in " + Stopper.ToString(Settings.Default.Counter) + ".");
            autoGrabberProgressBarEx.MarqueeStop();
            autoGrabberProgressBarEx.ProgressType = ProgressODoom.ProgressType.Smooth;
            autoGrabberProgressBarEx.Value = 0;
            notifyIcon.ShowBalloonTip(1250, "Operation cancelled.", "All snapshots(if any) saved successfuly at '" +
                Directory.GetParent(Settings.Default.Path) + "'." + Environment.NewLine + "Click to open.", ToolTipIcon.Info);
            notifyIcon.BalloonTipClicked += new EventHandler(notifyIcon_BalloonTipClicked);
            restoreFromTray();
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            Location = Settings.Default.Sticky ? checkPosition(25) : checkPosition();
        }

        private void ScreenGrabberMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Settings.Default.AutoInitiater)
            {
                DialogResult dr = MessageBox.Show("Next time you launch ScreenGrabber it will take " +
                    (Settings.Default.PictureSum == 0 ? "snaps continuously" : Settings.Default.PictureSum + " snaps") +
                    " every " +Stopper.ToString(Settings.Default.Counter)+ ".\nIs that okay?",
                    "Please confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if(e.Cancel = dr == DialogResult.Cancel)
                    return;
                if(!(Settings.Default.AutoInitiater = !(dr == DialogResult.No)))
                    Settings.Default.Minimized = true;
            }
            Settings.Default.Location = Location;
            statusLabel.Text = "Updating database. Please wait...";
            Program.SnapToDB(Program.snap);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.grabberPosition = Program.grabberPosition;
            Settings.Default.grabberSize = Program.grabberSize;
            Settings.Default.AccountID = -1;
            Settings.Default.Save();
            // unregister the hotkey (NEVER FORGET THIS!)
            UnregisterGlobalHotKey();//<---Very important!
        }
        #endregion
    }
}