using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using ScreenshotInterface;
using ScreenshotInject;
using EasyHook;
using System.Runtime.Remoting.Channels.Ipc;
using System.Runtime.Remoting;
using System.Runtime.InteropServices;

namespace ScreenGrabber
{
    public class DXGrabber
    {
        private String ChannelName = null;
        private IpcServerChannel ScreenshotServer;
        public DateTime start;
        public DateTime end;
        public bool AutoGAC;
        public string ProccessName;
        private ProgressBar progressBar1;
        private Image image;

        public DXGrabber()
        {
            progressBar1 = new ProgressBar();
        }

        public void Inject()
        {
            if (AutoGAC)
                try
                {
                    // Must be running as Administrator to allow dynamic registration in GAC
                    Config.Register("ScreenshotInjector",
                        "ScreenshotInject.dll");
                }
                catch (ApplicationException) { }            

            AttachProcess();
        }

        int processId = 0;

        private void AttachProcess()
        {
            if (ProccessName == null || ProccessName == "")
                return;

            bool newInstanceFound = false;

            while (!newInstanceFound)
            {
                Process[] processes = Process.GetProcessesByName(ProccessName);
                foreach (Process process in processes)
                {
                    // Simply attach to the first one found.

                    // If the process doesn't have a mainwindowhandle yet, skip it (we need to be able to get the hwnd to set foreground etc)
                    if (process.MainWindowHandle == IntPtr.Zero)
                    {
                        continue;
                    }

                    // Keep track of hooked processes in case more than one need to be hooked
                    HookManager.AddHookedProcess(process.Id);
                    processId = process.Id;

                    // Inject DLL into target process
                    RemoteHooking.Inject(
                        process.Id,
                        InjectionOptions.Default,
                        "ScreenshotInject.dll", // 32-bit version (the same because AnyCPU) could use different assembly that links to 32-bit C++ helper dll
                        "ScreenshotInject.dll", // 64-bit version (the same because AnyCPU) could use different assembly that links to 64-bit C++ helper dll
                        // the optional parameter list...
                        ChannelName // The name of the IPC channel for the injected assembly to connect to
                        );

                    // Ensure the target process is in the foreground,
                    // this prevents issues where the target app appears to be in 
                    // the foreground but does not receive any user inputs.
                    // Note: the first Alt+Tab out of the target application after injection
                    //       may still be an issue - switching between windowed and 
                    //       fullscreen fixes the issue however (see ScreenshotInjection.cs for another option)
                    BringProcessWindowToFront(process);

                    newInstanceFound = true;
                    break;
                }
                Thread.Sleep(10);

            }
        }

        /// <summary>
        /// Bring the target window to the front and wait for it to be visible
        /// </summary>
        /// <remarks>If the window does not come to the front within approx. 30 seconds an exception is raised</remarks>
        private void BringProcessWindowToFront(Process process)
        {
            IntPtr handle = process.MainWindowHandle;
            int i = 0;
            
            while (!NativeMethods.IsWindowInForeground(handle))
            {
                if (i == 0)
                {
                    // Initial sleep if target window is not in foreground - just to let things settle
                    Thread.Sleep(250);
                }

                if (NativeMethods.IsIconic(handle))
                {
                    // Minimized so send restore
                    NativeMethods.ShowWindow(handle, NativeMethods.WindowShowStyle.Restore);
                }
                else
                {
                    // Already Maximized or Restored so just bring to front
                    NativeMethods.SetForegroundWindow(handle);
                }
                Thread.Sleep(250);

                // Check if the target process main window is now in the foreground
                if (NativeMethods.IsWindowInForeground(handle))
                {
                    // Leave enough time for screen to redraw
                    Thread.Sleep(1000);
                    return;
                }

                // Prevent an infinite loop
                if (i > 120) // about 30secs
                {
                    throw new Exception("Could not set process window to the foreground");
                }
                i++;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialise the IPC server
            ScreenshotServer = RemoteHooking.IpcCreateServer<ScreenshotInterface.ScreenshotInterface>(
                ref ChannelName,
                WellKnownObjectMode.Singleton);

            //ScreenshotManager.OnScreenshotDebugMessage += new ScreenshotDebugMessage(ScreenshotManager_OnScreenshotDebugMessage);
        }

        //void ScreenshotManager_OnScreenshotDebugMessage(int clientPID, string message)
        //{
        //    txtDebugLog.Invoke(new MethodInvoker(delegate()
        //    {
        //        txtDebugLog.Text = String.Format("Client PID: {0}\r\n{1}\r\n", clientPID, message);
        //    })
        //    );
        //}

        void Callback(Int32 clientPID, ResponseStatus status, ScreenshotResponse screenshotResponse)
        {
            try
            {
                if (screenshotResponse != null && screenshotResponse.CapturedBitmap != null)
                {
                    //pictureBox1.Invoke(new MethodInvoker(delegate()
                    //{
                    //    if (pictureBox1.Image != null)
                    //    {
                    //        pictureBox1.Image.Dispose();
                    //    }
                    //    pictureBox1.Image = screenshotResponse.CapturedBitmapAsImage;
                    //})
                    //);
                    progressBar1.Invoke(new MethodInvoker(delegate()
                    {
                        image = screenshotResponse.CapturedBitmapAsImage;
                    })
                    );
                }

                Thread t = new Thread(new ThreadStart(DoRequest));
                t.Start();
            }
            catch
            {
            }
        }

        /// <summary>
        /// Create the screen shot request
        /// </summary>
        public void DoRequest()
        {
            progressBar1.Invoke(new MethodInvoker(delegate()
            {
                if (progressBar1.Value < progressBar1.Maximum)
                {
                    progressBar1.PerformStep();
                    // Add a request to the screenshot manager - the ScreenshotInterface will pass this on to the injected assembly
                    ScreenshotManager.AddScreenshotRequest(processId, new ScreenshotRequest(new Rectangle(0, 0, 0, 0)), Callback);
                }
                else
                {
                    end = DateTime.Now;
                    MessageBox.Show((end - start).ToString());
                }
            })
            );
        }

        public Image TakeScreenshot()
        {
            DoRequest();
            return image;
        }
    }
}
