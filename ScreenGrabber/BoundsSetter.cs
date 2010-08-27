using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ScreenGrabber.Properties;

namespace ScreenGrabber
{
    public partial class BoundsSetter : Form
    {
        #region Components.
        Point space;
        Point mousePos;
        int tip = 0;
        bool fullScreen;
        Size lastSize;
        Point lastLocation;
        #endregion

        // Constructor.
        public BoundsSetter()
        {
            InitializeComponent();
        }

        #region Events.
        private void BoundsSetter_Load(object sender, EventArgs e)
        {
            Size = Program.grabberSize;
            Location = Program.grabberPosition;
            widthMaskedTextBox.Text = Size.Width.ToString();
            heightMaskedTextBox.Text = Size.Height.ToString();
            if(stickyCheckBox.Checked)
            {
                positionTimer.Tick -= positionTimer_Tick;
                SizeChanged -= BoundsSetter_SizeChanged;
                positionTimer.Tick += stickyPositionTimer_Tick;
                SizeChanged += stickyBoundsSetter_SizeChanged;
            }
            else
            {
                positionTimer.Tick -= stickyPositionTimer_Tick;
                SizeChanged -= stickyBoundsSetter_SizeChanged;
                positionTimer.Tick += positionTimer_Tick;
                SizeChanged += BoundsSetter_SizeChanged;
            }
            checkBounds();
            Program.main.updatePreview(this.Location, this.Size);
            if(Location == new Point(0, 0))
                if(Size == new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height))
                {
                    fullScreen = true;
                    lastSize = new Size(240, 180);
                    lastLocation = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - lastSize.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 - lastSize.Height / 2);
                }
        }

        private void BoundsSetter_Activated(object sender, EventArgs e)
        {
            Program.main.activated = false;
        }

        private void BoundsSetter_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(ScreenGrabber.Properties.Resources.center, 
                (Size.Width / 2) - (ScreenGrabber.Properties.Resources.center.Width / 2) - 18, 
                (Size.Height / 2) - (ScreenGrabber.Properties.Resources.center.Height / 2));
        }

        private void resizeButton_MouseDown(object sender, MouseEventArgs e)
        {
            mousePos = MousePosition;
            Control ctrl = sender as Control;
            switch(ctrl.Name)
            {
                case "resizePictureBox":
                    space.X = Location.X + Width - MousePosition.X;
                    space.Y = Location.Y + Height - MousePosition.Y;
                    resizeTimer.Start();
                    break;
                default:
                    space.X = MousePosition.X - Location.X;
                    space.Y = MousePosition.Y - Location.Y;
                    positionTimer.Start();
                    break;
            }
        }

        private void resizeButton_MouseUp(object sender, MouseEventArgs e)
        {
            resizeTimer.Stop();
            positionTimer.Stop();
        }

        private void heightMaskedTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            MaskedTextBox mtb = sender as MaskedTextBox;

            if(e.KeyData == Keys.Enter)
            {
                if(mtb.Name == "heightMaskedTextBox")
                {
                    int height = 0;
                    if(int.TryParse(heightMaskedTextBox.Text, out height))
                    {
                        Size newSize = new Size();
                        if(height < 0)
                            newSize.Height = 0;
                        else
                            if(height > Screen.PrimaryScreen.Bounds.Height)
                                newSize.Height = Screen.PrimaryScreen.Bounds.Height;
                            else
                                newSize.Height = height;
                        newSize.Width = Width;
                        Size = newSize;
                    }
                    else { heightMaskedTextBox.Text = "0"; }
                }
                else
                    if(mtb.Name == "widthMaskedTextBox")
                    {
                        int width = 0;
                        if(int.TryParse(widthMaskedTextBox.Text, out width))
                        {
                            Size newSize = new Size();
                            if(width < 0)
                                newSize.Width = 0;
                            else
                                if(width > Screen.PrimaryScreen.Bounds.Width)
                                    newSize.Width = Screen.PrimaryScreen.Bounds.Width;
                                else
                                    newSize.Width = width;
                            newSize.Height = Height;
                            Size = newSize;
                        }
                        else { widthMaskedTextBox.Text = "0"; }
                    }
                    else
                        if(mtb.Name == "locationMaskedTextBox")
                        {
                            string[] XY = locationMaskedTextBox.Text.Split(',');
                            int X = 0, Y = 0;
                            Point newLocation = new Point() { X = Location.X, Y = Location.Y };

                            if(int.TryParse(XY[0], out X))
                            {
                                if(X < 0)
                                    newLocation.X = 0;
                                else
                                    if(X + Size.Width > Screen.PrimaryScreen.Bounds.Width)
                                        newLocation.X = Screen.PrimaryScreen.Bounds.Width - Size.Width;
                                    else
                                        newLocation.X = X;
                            }
                            if(int.TryParse(XY[1], out Y))
                            {
                                if(Y < 0)
                                    newLocation.Y = 0;
                                else
                                    if(Y + Size.Height > Screen.PrimaryScreen.Bounds.Height)
                                        newLocation.Y = Screen.PrimaryScreen.Bounds.Height - Size.Height;
                                    else
                                        newLocation.Y = Y;
                            }

                            Location = newLocation;
                        }
                Invalidate();
            }
        }

        private void positionTimer_Tick(object sender, EventArgs e)
        {
            Point newLocation = new Point();
            newLocation.X = MousePosition.X - space.X;
            newLocation.Y = MousePosition.Y - space.Y;

            if(newLocation.X < 0)
                newLocation.X = 0;
            if(newLocation.X + Width > Screen.PrimaryScreen.Bounds.Width)
                newLocation.X = Screen.PrimaryScreen.Bounds.Width - Width;
            if(newLocation.Y < 0)
                newLocation.Y = 0;
            if(newLocation.Y + Height > Screen.PrimaryScreen.Bounds.Height)
                newLocation.Y = Screen.PrimaryScreen.Bounds.Height - Height;
            
            Location = newLocation;
            locationMaskedTextBox.Text = Location.X + "," + Location.Y;
            checkBounds();
            Program.main.updatePreview(this.Location, this.Size);
        }

        private void stickyPositionTimer_Tick(object sender, EventArgs e)
        {
            Point newLocation = new Point();
            newLocation.X = MousePosition.X - space.X;
            newLocation.Y = MousePosition.Y - space.Y;

            if(newLocation.X <= 25)
                newLocation.X = 0;
            if(newLocation.X + Width >= Screen.PrimaryScreen.Bounds.Width - 25)
                newLocation.X = Screen.PrimaryScreen.Bounds.Width - Width;
            if(newLocation.Y <= 25)
                newLocation.Y = 0;
            if(newLocation.Y + Height >= Screen.PrimaryScreen.Bounds.Height - 25)
                newLocation.Y = Screen.PrimaryScreen.Bounds.Height - Height;

            Location = newLocation;
            locationMaskedTextBox.Text = Location.X + "," + Location.Y;
            checkBounds();
            Program.main.updatePreview(this.Location, this.Size);
        }

        private void resizeTimer_Tick(object sender, EventArgs e)
        {
            mousePos = MousePosition;
            Size newSize = new Size();
            if(Location.X + (newSize.Width = PointToClient(mousePos).X + space.X) >= Screen.PrimaryScreen.Bounds.Width - 25)
                if(stickyCheckBox.Checked || Location.X + newSize.Width > Screen.PrimaryScreen.Bounds.Width)
                    newSize.Width = Screen.PrimaryScreen.Bounds.Width - Location.X;
            if(Location.Y + (newSize.Height = PointToClient(mousePos).Y + space.Y) >= Screen.PrimaryScreen.Bounds.Height - 25)
                if(stickyCheckBox.Checked || Location.Y + newSize.Height > Screen.PrimaryScreen.Bounds.Height)
                    newSize.Height = Screen.PrimaryScreen.Bounds.Height - Location.Y;
            Size = newSize;
            Invalidate();
            checkBounds();
        }

        private void startUpTimer_Tick(object sender, EventArgs e)
        {
            switch(tip)
            {
                case 0:
                    toolTip1.Show("Put me where you want to snap the screen.", this, Size.Width / 2, Size.Height / 2 - 45, 2500);
                    tip++;
                    break;
                case 1:
                    toolTip1.Show("Then resize me to the size you want the snap would be.", this, Size.Width / 2, Size.Height / 2 - 45, 3000);
                    tip++;
                    break;
                case 2:
                    toolTip1.Show("Finaly click here to set the new size\\position.", setButton, setButton.Size.Width / 2, setButton.Size.Height / 2 - 45, 2500);
                    tip++;
                    break;
                case 3:
                    toolTip1.SetToolTip(this, "Put or Resize this windows to set the new bounds.");
                    toolTip1.SetToolTip(setButton, "Set the new size and position.");
                    tip = 0;
                    startUpTimer.Stop();
                    break;
            }
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            Program.grabberSize = Size;
            Program.grabberPosition = Location;
            Program.main.positionLabel.Text = "Grabber at:" + Location.X + "," + Location.Y;
            Program.main.sizeLabel.Text = "Size:" + Size.Width + "x" + Size.Height;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void resizePictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(fullScreen)
            {
                Location = lastLocation;
                Size = lastSize;
                fullScreen = false;
            }
            else
            {
                lastLocation = Location;
                lastSize = Size;
                Location = new Point(0, 0);
                Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                fullScreen = true;
            }
        }

        private void BoundsSetter_SizeChanged(object sender, EventArgs e)
        {
            Point newLocation = new Point(Location.X,Location.Y);

            if(newLocation.X < 0)
                newLocation.X = 0;
            if(newLocation.X + Width > Screen.PrimaryScreen.Bounds.Width)
                newLocation.X = Screen.PrimaryScreen.Bounds.Width - Width;
            if(newLocation.Y < 0)
                newLocation.Y = 0;
            if(newLocation.Y + Height > Screen.PrimaryScreen.Bounds.Height)
                newLocation.Y = Screen.PrimaryScreen.Bounds.Height - Height;

            Location = newLocation;
            checkBounds();
            Program.main.updatePreview(this.Location, this.Size);
        }

        private void stickyBoundsSetter_SizeChanged(object sender, EventArgs e)
        {
            Point newLocation = new Point(Location.X, Location.Y);

            if(newLocation.X <= 25)
                newLocation.X = 0;
            if(newLocation.X + Width >= Screen.PrimaryScreen.Bounds.Width - 25)
                newLocation.X = Screen.PrimaryScreen.Bounds.Width - Width;
            if(newLocation.Y <= 25)
                newLocation.Y = 0;
            if(newLocation.Y + Height >= Screen.PrimaryScreen.Bounds.Height - 25)
                newLocation.Y = Screen.PrimaryScreen.Bounds.Height - Height;

            Location = newLocation;
            checkBounds();
            Program.main.updatePreview(this.Location, this.Size);
        }

        private void stickyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(stickyCheckBox.Checked)
            {
                positionTimer.Tick -= positionTimer_Tick;
                positionTimer.Tick += stickyPositionTimer_Tick;
                SizeChanged -= BoundsSetter_SizeChanged;
                SizeChanged += stickyBoundsSetter_SizeChanged;
            }
            else
            {
                positionTimer.Tick -= stickyPositionTimer_Tick;
                positionTimer.Tick += positionTimer_Tick;
                SizeChanged -= stickyBoundsSetter_SizeChanged;
                SizeChanged += BoundsSetter_SizeChanged;
            }
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            Control ctrl = sender as Control;
            switch(ctrl.Name)
            {
                case "closeButton":
                    closeButton.BackgroundImage = Properties.Resources.btnCloseHover;
                    break;
                case "resizePictureBox":
                    resizePictureBox.Image = Properties.Resources.btnResizeHover;
                    break;
                case "setButton":
                    setButton.Image = Properties.Resources.btnSetHover;
                    break;
            }
            Invalidate();
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            Control ctrl = sender as Control;
            switch(ctrl.Name)
            {
                case "closeButton":
                    closeButton.BackgroundImage = Properties.Resources.btnClose;
                    break;
                case "resizePictureBox":
                    resizePictureBox.Image = Properties.Resources.btnResize;
                    break;
                case "setButton":
                    setButton.Image = Properties.Resources.btnSet;
                    break;
            }
            Invalidate();
        }

        private void BoundsSetter_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.main.Opacity = 1.0;
            Program.main.Focus();
            Program.main.Activate();
            Program.main.Show();
            Program.main.activated = true;
        }
        #endregion

        /// <summary>
        /// Controling the components to show labels by user parameters.
        /// </summary>
        void checkBounds()
        {
            if(Size.Width > 278 || Size.Height > 140)
                locationMaskedTextBox.Visible = true;
            if(Size.Width < 222)
                widthMaskedTextBox.Visible = false;
            else
            {
                widthMaskedTextBox.Visible = true;
                widthMaskedTextBox.Text = Size.Width.ToString();
            }

            if(Size.Height < 140)
            {
                heightMaskedTextBox.Visible = false;
                if(Size.Width < 278)
                    locationMaskedTextBox.Visible = false;
            }
            else
            {
                heightMaskedTextBox.Visible = true;
                heightMaskedTextBox.Text = Size.Height.ToString();
            }
            string width = Location.X.ToString();
            string height = Location.Y.ToString();
            while(width.Length < 4)
                width = "0" + width;
            while(height.Length < 4)
                height = "0" + height;
            locationMaskedTextBox.Text = width + "," + height;
        }
    }
}