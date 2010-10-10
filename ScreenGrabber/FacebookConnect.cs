using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ScreenGrabber.Properties;
using Facebook;
using Facebook.Components;
using Facebook.Exceptions;
using Facebook.Entity;
using System.IO;
using System.Drawing.Imaging;

namespace ScreenGrabber
{
    public partial class FacebookUploader : Form
    {
        #region Components.
        int[] images; // The IDs of selected images.
        FileInfo[] files; // Paths of working temp files.
        DirectoryInfo directoryPath; // Working temp directory.
        #endregion

        // Properties.
        public bool isWorking { get; set; }

        public FacebookUploader(Image img, int[] imageIDs)
        {
            InitializeComponent();
            imagePictureBox.Image = img;
            directoryPath = Directory.CreateDirectory(Application.StartupPath + "\\Temp\\");
            images = imageIDs;
            detailsLabel.Text = (images.Length > 1 ? images.Length+" images" : "One image") + " selected to upload to Facebook.";
            files = new FileInfo[images.Length];
        }
        
        #region Events.
        private void uploadButton_Click(object sender, EventArgs e)
        {
            uploadButton.Enabled = false;
            statusLabel.Visible = true;
            progressBar.Value = 0;
            if ((progressBar.Maximum = images.Length) == 1)
                progressBar.Style = ProgressBarStyle.Marquee;
            else
                progressBar.Style = ProgressBarStyle.Blocks;
            progressBar.Visible = true;
            isWorking = true;
            uploadBackgroundWorker.RunWorkerAsync();
        }

        private void uploadBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                SnapsDatabaseDataSetTableAdapters.SnapsTableAdapter snaps = new SnapsDatabaseDataSetTableAdapters.SnapsTableAdapter();
                FacebookService service = Settings.Default.FacebookService;
                User user = Settings.Default.FacebookUser;
                Dictionary<string, object> userState = new Dictionary<string, object>();
                Image img;

                #region Saving image list to disk.
                userState["BlocksStyle"] = true;
                for (int i = 0; i < images.Length; i++)
                {
                    img = Snap.byteArrayToImage((byte[])snaps.GetSnap(images[i]));
                    files[i] = new FileInfo(Program.saveToFile(directoryPath.FullName + "tempimg.jpg",
                        new Snap(img, ImageFormat.Jpeg, (DateTime)snaps.GetDateBySnapID(images[i]), Settings.Default.AccountID, null)));
                    
                    userState["Image"] = img;
                    userState["Message"] = "Preparing image '"+files[i].Name+"'. "+"("+(i+1)+"/"+files.Length+")";
                    uploadBackgroundWorker.ReportProgress(i + 1, userState);
                }
                #endregion

                #region Uploading the images to Facebook.
                userState["BlocksStyle"] = false;
                for (int i = 0; i < files.Length; i++)
                {
                    img = Snap.byteArrayToImage((byte[])snaps.GetSnap(images[i]));
                    userState["Image"] = img;
                    userState["Message"] = "Uploading image '" + files[i].Name + "'. " + "(" + (i + 1) + "/" + files.Length + ")";
                    uploadBackgroundWorker.ReportProgress(i + 1, userState);
                    service.UploadPhoto("ScreenGrabber Screenshots", files[i]);
                }
                #endregion

                #region Clean up everything.
                img = null;
                userState["Image"] = Resources.imageEmpty;
                userState["BlocksStyle"] = true;
                for (int i = 0; i < files.Length; i++)
                {
                    userState["Message"] = "Cleaning up.. delete '" + files[i].Name + "'. " + "(" + (i + 1) + "/" + files.Length + ")";
                    files[i].Delete();
                }

                deleteFolder(directoryPath.FullName);
                #endregion

                e.Result = true;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace, "Error");
                e.Result = false;
            }
        }

        private void uploadBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Dictionary<string, object> userState = e.UserState as Dictionary<string, object>;

            if ((bool)userState["BlocksStyle"])
                progressBar.Style = ProgressBarStyle.Blocks;
            else
                progressBar.Style = ProgressBarStyle.Marquee;

            imagePictureBox.Image = (Image)userState["Image"];
            statusLabel.Text = (string)userState["Message"];
            progressBar.Value = e.ProgressPercentage;
        }

        private void uploadBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            isWorking = false;
            if ((bool)e.Result)
                Close();
            uploadButton.Enabled = true;
            statusLabel.Visible = false;
            progressBar.Visible = false;
        }

        private void FacebookUploader_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isWorking)
                if (e.Cancel = !(MessageBox.Show("There are still images to upload.\nConfirm cancelation?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == System.Windows.Forms.DialogResult.Yes))
                    deleteFolder(directoryPath.FullName);
        }
        #endregion

        // Functions.
        private static void deleteFolder(string path)
        {
            try
            {
                foreach (var item in Directory.GetFiles(path))
                    File.Delete(item);
                Directory.Delete(path);
            }
            catch (DirectoryNotFoundException) { }
        }
    }
}