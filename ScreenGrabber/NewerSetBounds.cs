using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using ScreenGrabber.Properties;

namespace ScreenGrabber
{
    public partial class NewerSetBounds : Form
    {
        #region Components.
        Point space;
        Point topLeft;
        Point bottomRight;
        bool previewGenerated;
        #endregion

        // Constructor.
        public NewerSetBounds()
        {
            InitializeComponent();
            Location = new Point(0, 0);
            Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        }

        #region Events.
        private void NewerSetBounds_Load(object sender, EventArgs e)
        {
            if(Settings.Default.grabberSize.Width != 0 && Settings.Default.grabberSize.Height != 0)
            {
                topLeft = Settings.Default.grabberPosition;
                bottomRight = new Point(Settings.Default.grabberPosition.X + Settings.Default.grabberSize.Width, Settings.Default.grabberPosition.Y + Settings.Default.grabberSize.Height);
                this.Paint += ScreenGrabberSetBoundsSnapshot_Paint;
                setSnapPreview();
            }
            else
            {
                this.Paint += ScreenGrabberSetBoundsHover_Paint;
                mouseHoverTimer.Start();
            }
            if(Settings.Default.TryDXFirst)
                if(MessageBox.Show("DirectX mode is on.\nFor taking custom bounds snaps you need to disable DirectX mode.\nDo you want to disable DirectX now?", "Please confirm.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Settings.Default.TryDXFirst = false;
                    Settings.Default.Save();
                }
        }

        #region Mouse events.
        private void ScreenGrabberSetBounds_MouseDown(object sender, MouseEventArgs e)
        {
            previewGenerated = false;
            this.Paint += ScreenGrabberSetBoundsHover_Paint;
            this.Paint += ScreenGrabberSetBounds_Paint;
            this.Paint -= ScreenGrabberSetBoundsSnapshot_Paint;
            Opacity = 0.8;
            shadowPanel.Visible = false;
            controlsPanel.Visible = false;
            topLeft = new Point();
            topLeft.X = MousePosition.X;
            topLeft.Y = MousePosition.Y;
            paintTimer.Start();
        }

        private void ScreenGrabberSetBounds_MouseUp(object sender, MouseEventArgs e)
        {
            this.Paint -= ScreenGrabberSetBoundsHover_Paint;
            this.Paint -= ScreenGrabberSetBounds_Paint;
            this.Paint += ScreenGrabberSetBoundsSnapshot_Paint;
            mouseHoverTimer.Stop();
            bottomRight = new Point();
            bottomRight.X = MousePosition.X;
            bottomRight.Y = MousePosition.Y;
            paintTimer.Stop();
            setSnapPreview();
        }

        private void controlsPanel_MouseDown(object sender, MouseEventArgs e)
        {
            space.X = MousePosition.X - controlsPanel.Location.X;
            space.Y = MousePosition.Y - controlsPanel.Location.Y;
            panelLocationTimer.Start();
        }

        private void controlsPanel_MouseUp(object sender, MouseEventArgs e)
        {
            panelLocationTimer.Stop();
        }
        #endregion

        #region Form events.
        private void ScreenGrabberSetBounds_Paint(object sender, PaintEventArgs e)
        {
            Graphics G = e.Graphics;
            var pen = new Pen(Brushes.RoyalBlue, 2);
            pen.DashStyle = DashStyle.Dash;
            pen.DashPattern = new float[] { 10, 5 };
            pen.Alignment = PenAlignment.Outset;
            if(!topLeft.IsEmpty && !bottomRight.IsEmpty)
            {
                G.DrawString("Size: "+Math.Abs(bottomRight.X - topLeft.X) + "x" + Math.Abs(bottomRight.Y - topLeft.Y), label1.Font, Brushes.Black, new PointF(topLeft.X + 2, topLeft.Y + 2));
                G.DrawLines(pen, new Point[] { topLeft, new Point(topLeft.X, bottomRight.Y), bottomRight, new Point(bottomRight.X, topLeft.Y), topLeft });
            }
        }

        private void ScreenGrabberSetBoundsHover_Paint(object sender, PaintEventArgs e)
        {
            Graphics G = e.Graphics;
            var pen = new Pen(Brushes.Black, 1);
            pen.DashStyle = DashStyle.Dash;
            pen.DashPattern = new float[] { 5, 10 };
            G.DrawLine(pen, 0, MousePosition.Y, Size.Width, MousePosition.Y);
            G.DrawLine(pen, MousePosition.X, 0, MousePosition.X, Size.Height);
            G.DrawString(MousePosition.X + "x" + MousePosition.Y, label1.Font, Brushes.Black, new PointF(MousePosition.X + 2, MousePosition.Y + 2));
        }

        private void ScreenGrabberSetBoundsSnapshot_Paint(object sender, PaintEventArgs e)
        {
            Graphics G = e.Graphics;
            var pen = new Pen(Brushes.White, 40);
            G.Clear(Color.DimGray);
            G.SmoothingMode = SmoothingMode.None;
            pen.Alignment = PenAlignment.Outset;
            if(!topLeft.IsEmpty && !bottomRight.IsEmpty)
            {
                drawShadow(topLeft, bottomRight);
                G.DrawLines(pen, new Point[] { topLeft, new Point(topLeft.X, bottomRight.Y), bottomRight, new Point(bottomRight.X, topLeft.Y), topLeft, new Point(topLeft.X, bottomRight.Y) });
            }
            G.FillRectangle(Brushes.GreenYellow, topLeft.X, topLeft.Y, bottomRight.X - topLeft.X, bottomRight.Y - topLeft.Y);
            this.TransparencyKey = Color.GreenYellow;
            checkPreview();
        }
        
        private void ScreenGrabberSetBounds_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
        #endregion

        #region Controls events.
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Size newSize = new Size(bottomRight.X - topLeft.X, bottomRight.Y - topLeft.Y);
            if(newSize.Width == 0)
            {
                MessageBox.Show("Zero points width is not acceptable. please grow your selection.", "Wrong arguments", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(newSize.Height == 0)
            {
                MessageBox.Show("Zero points height is not acceptable. please grow your selection.", "Wrong arguments", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Program.grabberPosition = topLeft;
            Program.grabberSize = newSize;
            Settings.Default.grabberPosition = topLeft;
            Settings.Default.grabberSize = newSize;
            Settings.Default.Save();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.Paint += ScreenGrabberSetBoundsHover_Paint;
            this.Paint -= ScreenGrabberSetBounds_Paint;
            this.Paint -= ScreenGrabberSetBoundsSnapshot_Paint;
            mouseHoverTimer.Start();
            shadowPanel.Visible = false;
            controlsPanel.Visible = false;
            topLeft = new Point();
            bottomRight = new Point();
            Opacity = 0.8;
            Invalidate();
        }

        private void ScreenGrabberSetBounds_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Escape)
                cancelButton.PerformClick();
            else
                if(e.KeyData == Keys.Enter)
                    okButton.PerformClick();
        }
        #endregion

        #region Timers events.
        private void paintTimer_Tick(object sender, EventArgs e)
        {
            bottomRight = new Point();
            bottomRight.X = MousePosition.X;
            bottomRight.Y = MousePosition.Y;
            Invalidate();
        }

        private void panelLocationTimer_Tick(object sender, EventArgs e)
        {
            Point newPos = new Point();
            newPos.X = MousePosition.X - space.X;
            newPos.Y = MousePosition.Y - space.Y;
            if(newPos.X < 0)
                newPos.X = 0;
            if(newPos.X + controlsPanel.Size.Width - 1 > Screen.PrimaryScreen.Bounds.Width)
                newPos.X = Screen.PrimaryScreen.Bounds.Width - controlsPanel.Size.Width - 1;
            if(newPos.Y < 0)
                newPos.Y = 0;
            if(newPos.Y + controlsPanel.Size.Height - 1 > Screen.PrimaryScreen.Bounds.Height)
                newPos.Y = Screen.PrimaryScreen.Bounds.Height - controlsPanel.Size.Height - 1;
            controlsPanel.Location = newPos;
        }

        private void mouseHoverTimer_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }
        #endregion
        #endregion

        #region Functions.
        /// <summary>
        /// Checking if theres already preview generated and create a new one if there isn't.
        /// </summary>
        void checkPreview()
        {
            if(!previewGenerated)
            {
                try
                {
                    detailsLabel.ForeColor = Color.Black;
                    okButton.Enabled = true;
                    Program.main.updatePreview(topLeft, new Size(bottomRight.X - topLeft.X, bottomRight.Y - topLeft.Y));
                }
                catch(ArgumentException)
                {
                    detailsLabel.ForeColor = Color.Red;
                    okButton.Enabled = false;
                }
                previewGenerated = true;
            }
        }

        /// <summary>
        /// Generate the new snap preview.
        /// </summary>
        private void setSnapPreview()
        {
            Point[] p = getAbsolute(topLeft, bottomRight);
            topLeft = p[0];
            bottomRight = p[1];
            TransparencyKey = Color.GreenYellow;
            controlsPanel.Location = setPanelLocation(new Point(bottomRight.X - controlsPanel.Size.Width + 20, bottomRight.Y + 30), controlsPanel.Size);
            detailsLabel.Text = "Location: " + topLeft.X + "x" + topLeft.Y + ". Size: " + (bottomRight.X - topLeft.X) + "x" + (bottomRight.Y - topLeft.Y) + ".";
            controlsPanel.Visible = true;
            Opacity = 0.95;
            Invalidate();
        }

        /// <summary>
        /// Draws a shadow arround the snapped preview.
        /// </summary>
        /// <param name="topLeft">Top left point.</param>
        /// <param name="bottomRight">Botom right point.</param>
        public void drawShadow(Point topLeft, Point bottomRight)
        {
            Point newPanelLocation = new Point();
            newPanelLocation.X = topLeft.X - 95;
            newPanelLocation.Y = topLeft.Y - 95;

            Size newPanelSize = new Size();
            newPanelSize.Width = bottomRight.X - topLeft.X + 190;
            newPanelSize.Height = bottomRight.Y - topLeft.Y + 190;

            shadowPanel.Location = newPanelLocation;
            shadowPanel.Size = newPanelSize;
            shadowPanel.Visible = true;
        }

        /// <summary>
        /// Keep the panel inside the screen bounds
        /// </summary>
        /// <param name="location">The location of the panel</param>
        /// <param name="size">The size of the panel</param>
        /// <returns>New panel location inside screen bounds</returns>
        Point setPanelLocation(Point location, Size size)
        {
            var result = new Point();
            if(location.X + size.Width > Screen.PrimaryScreen.Bounds.Width)
                result.X = Screen.PrimaryScreen.Bounds.Width - size.Width;
            else
                if(location.X < 0)
                    result.X = 0;
                else
                    result.X = location.X;
            if(location.Y + size.Height > Screen.PrimaryScreen.Bounds.Height)
                result.Y = Screen.PrimaryScreen.Bounds.Height - size.Height;
            else
                result.Y = location.Y;
            return result;
        }

        /// <summary>
        /// Regenerate topLaft and bottomRight points
        /// </summary>
        /// <param name="topLeft">Non-sync topLeft point</param>
        /// <param name="bottomRight">Non-sync bottomRight point</param>
        /// <returns>The absolute topLeft and bottomRight points as array</returns>
        Point[] getAbsolute(Point topLeft, Point bottomRight)
        {
            Point lowers = new Point();
            lowers.X = topLeft.X < bottomRight.X ? topLeft.X : bottomRight.X;
            lowers.Y = topLeft.Y < bottomRight.Y ? topLeft.Y : bottomRight.Y;
            Point highers = new Point();
            highers.X = topLeft.X > bottomRight.X ? topLeft.X : bottomRight.X;
            highers.Y = topLeft.Y > bottomRight.Y ? topLeft.Y : bottomRight.Y;
            return new Point[] { lowers, highers };
        }
        #endregion
    }
}