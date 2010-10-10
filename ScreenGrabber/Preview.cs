using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ScreenGrabber.Properties;

namespace ScreenGrabber
{
    public partial class Preview : Form
    {
        #region Components.
        Image img;
        Point space;
        #endregion

        /// <summary>
        /// Show a 100% image preview.
        /// </summary>
        /// <param name="img">The image to be shown.</param>
        /// <param name="date">Image snapped date.</param>
        public Preview(Image img, DateTime date)
        {
            InitializeComponent();
            Snap snap = new Snap(img, Program.GetExt(Settings.Default.Path), date, Settings.Default.AccountID, null);
            preparingImageBackgroundWorker.RunWorkerAsync(snap);
        }

        /// <summary>
        /// Show a 100% image preview.
        /// </summary>
        /// <param name="img">The image to be shown.</param>
        /// <param name="date">Image snapped date.</param>
        public Preview(Snap snap)
        {
            InitializeComponent();
            preparingImageBackgroundWorker.RunWorkerAsync(snap);
        }

        #region Events.
        private void Preview_MouseDown(object sender, MouseEventArgs e)
        {
            space.X = MousePosition.X - Location.X;
            space.Y = MousePosition.Y - Location.Y;
            locationTimer.Start();
        }

        private void Preview_MouseUp(object sender, MouseEventArgs e)
        {
            locationTimer.Stop();
        }

        private void locationTimer_Tick(object sender, EventArgs e)
        {
            Point newLocation = new Point();
            newLocation.X = MousePosition.X - space.X;
            newLocation.Y = MousePosition.Y - space.Y;
            Location = newLocation;
        }

        #region Getting new image preview with date.
        private void preparingImageBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Snap img = e.Argument as Snap;
                e.Result = Program.DrawDateOnImage((Bitmap)img.BmpAsImage, img.Date);
            }
            catch(Exception ex) { MessageBox.Show(ex.Message,"Cannot generate preview",MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void preparingImageBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                img = e.Result as Image;
                Size = new Size(img.Width + 2, img.Height + 2);
                Rectangle screenRect = Screen.GetBounds(Bounds);
                Location = new Point(screenRect.Width / 2 - ClientSize.Width / 2, screenRect.Height / 2 - ClientSize.Height / 2);
                previewPictureBox.Image = img;
                msgPanel.Visible = false;
            }
            catch(Exception ex) { MessageBox.Show(ex.Message+"\n\n"+ex.StackTrace,"Error"); }
        }
        #endregion

        private void Preview_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}