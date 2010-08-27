namespace ScreenGrabber
{
    partial class BoundsSetter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoundsSetter));
            this.locationMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.heightMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.widthMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.stickyCheckBox = new System.Windows.Forms.CheckBox();
            this.positionTimer = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.closeButton = new System.Windows.Forms.Button();
            this.startUpTimer = new System.Windows.Forms.Timer(this.components);
            this.resizeTimer = new System.Windows.Forms.Timer(this.components);
            this.bottomPictureBox = new System.Windows.Forms.PictureBox();
            this.bottomRightPictureBox = new System.Windows.Forms.PictureBox();
            this.bottomLeftPictureBox = new System.Windows.Forms.PictureBox();
            this.rightPictureBox = new System.Windows.Forms.PictureBox();
            this.setButton = new System.Windows.Forms.Button();
            this.leftPictureBox = new System.Windows.Forms.PictureBox();
            this.rightTopPictureBox = new System.Windows.Forms.PictureBox();
            this.leftTopPictureBox = new System.Windows.Forms.PictureBox();
            this.topRightPictureBox = new System.Windows.Forms.PictureBox();
            this.topPictureBox = new System.Windows.Forms.PictureBox();
            this.topLeftPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.resizePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomRightPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomLeftPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightTopPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftTopPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topRightPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topLeftPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resizePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // locationMaskedTextBox
            // 
            this.locationMaskedTextBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.locationMaskedTextBox.ForeColor = System.Drawing.Color.White;
            this.locationMaskedTextBox.Location = new System.Drawing.Point(6, 25);
            this.locationMaskedTextBox.Mask = "9990,9990";
            this.locationMaskedTextBox.Name = "locationMaskedTextBox";
            this.locationMaskedTextBox.Size = new System.Drawing.Size(60, 20);
            this.locationMaskedTextBox.TabIndex = 4;
            this.locationMaskedTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.heightMaskedTextBox_KeyUp);
            // 
            // heightMaskedTextBox
            // 
            this.heightMaskedTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.heightMaskedTextBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.heightMaskedTextBox.ForeColor = System.Drawing.Color.White;
            this.heightMaskedTextBox.Location = new System.Drawing.Point(88, 99);
            this.heightMaskedTextBox.Mask = "9990";
            this.heightMaskedTextBox.Name = "heightMaskedTextBox";
            this.heightMaskedTextBox.Size = new System.Drawing.Size(33, 20);
            this.heightMaskedTextBox.TabIndex = 1;
            this.heightMaskedTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.heightMaskedTextBox_KeyUp);
            // 
            // widthMaskedTextBox
            // 
            this.widthMaskedTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.widthMaskedTextBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.widthMaskedTextBox.ForeColor = System.Drawing.Color.White;
            this.widthMaskedTextBox.Location = new System.Drawing.Point(166, 51);
            this.widthMaskedTextBox.Mask = "9990";
            this.widthMaskedTextBox.Name = "widthMaskedTextBox";
            this.widthMaskedTextBox.Size = new System.Drawing.Size(33, 20);
            this.widthMaskedTextBox.TabIndex = 1;
            this.widthMaskedTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.heightMaskedTextBox_KeyUp);
            // 
            // stickyCheckBox
            // 
            this.stickyCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stickyCheckBox.AutoSize = true;
            this.stickyCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.stickyCheckBox.Checked = true;
            this.stickyCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.stickyCheckBox.ForeColor = System.Drawing.Color.White;
            this.stickyCheckBox.Location = new System.Drawing.Point(54, 77);
            this.stickyCheckBox.Name = "stickyCheckBox";
            this.stickyCheckBox.Size = new System.Drawing.Size(97, 17);
            this.stickyCheckBox.TabIndex = 0;
            this.stickyCheckBox.TabStop = false;
            this.stickyCheckBox.Text = "Stick to edges.";
            this.stickyCheckBox.UseVisualStyleBackColor = false;
            this.stickyCheckBox.CheckedChanged += new System.EventHandler(this.stickyCheckBox_CheckedChanged);
            // 
            // positionTimer
            // 
            this.positionTimer.Interval = 10;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.BackgroundImage = global::ScreenGrabber.Properties.Resources.btnClose;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.closeButton.Location = new System.Drawing.Point(175, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(24, 21);
            this.closeButton.TabIndex = 2;
            this.closeButton.TabStop = false;
            this.toolTip1.SetToolTip(this.closeButton, "Cancel operation and closes this window.");
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            this.closeButton.Click += new System.EventHandler(this.button1_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            // 
            // startUpTimer
            // 
            this.startUpTimer.Enabled = true;
            this.startUpTimer.Interval = 2700;
            this.startUpTimer.Tick += new System.EventHandler(this.startUpTimer_Tick);
            // 
            // resizeTimer
            // 
            this.resizeTimer.Interval = 10;
            this.resizeTimer.Tick += new System.EventHandler(this.resizeTimer_Tick);
            // 
            // bottomPictureBox
            // 
            this.bottomPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bottomPictureBox.BackgroundImage = global::ScreenGrabber.Properties.Resources.bottom;
            this.bottomPictureBox.Location = new System.Drawing.Point(6, 119);
            this.bottomPictureBox.Name = "bottomPictureBox";
            this.bottomPictureBox.Size = new System.Drawing.Size(193, 6);
            this.bottomPictureBox.TabIndex = 13;
            this.bottomPictureBox.TabStop = false;
            // 
            // bottomRightPictureBox
            // 
            this.bottomRightPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bottomRightPictureBox.Image = global::ScreenGrabber.Properties.Resources.bottomRight;
            this.bottomRightPictureBox.Location = new System.Drawing.Point(199, 119);
            this.bottomRightPictureBox.Name = "bottomRightPictureBox";
            this.bottomRightPictureBox.Size = new System.Drawing.Size(6, 6);
            this.bottomRightPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bottomRightPictureBox.TabIndex = 12;
            this.bottomRightPictureBox.TabStop = false;
            this.bottomRightPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resizeButton_MouseDown);
            this.bottomRightPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.resizeButton_MouseUp);
            // 
            // bottomLeftPictureBox
            // 
            this.bottomLeftPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bottomLeftPictureBox.Image = global::ScreenGrabber.Properties.Resources.bottomLeft;
            this.bottomLeftPictureBox.Location = new System.Drawing.Point(0, 119);
            this.bottomLeftPictureBox.Name = "bottomLeftPictureBox";
            this.bottomLeftPictureBox.Size = new System.Drawing.Size(6, 6);
            this.bottomLeftPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bottomLeftPictureBox.TabIndex = 11;
            this.bottomLeftPictureBox.TabStop = false;
            this.bottomLeftPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resizeButton_MouseDown);
            this.bottomLeftPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.resizeButton_MouseUp);
            // 
            // rightPictureBox
            // 
            this.rightPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rightPictureBox.BackgroundImage = global::ScreenGrabber.Properties.Resources.sides;
            this.rightPictureBox.Location = new System.Drawing.Point(199, 39);
            this.rightPictureBox.Name = "rightPictureBox";
            this.rightPictureBox.Size = new System.Drawing.Size(6, 80);
            this.rightPictureBox.TabIndex = 10;
            this.rightPictureBox.TabStop = false;
            this.rightPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resizeButton_MouseDown);
            this.rightPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.resizeButton_MouseUp);
            // 
            // setButton
            // 
            this.setButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.setButton.BackColor = System.Drawing.Color.Transparent;
            this.setButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.setButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.setButton.FlatAppearance.BorderSize = 0;
            this.setButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.setButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.setButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setButton.Image = global::ScreenGrabber.Properties.Resources.btnSet;
            this.setButton.Location = new System.Drawing.Point(51, 46);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(100, 25);
            this.setButton.TabIndex = 1;
            this.setButton.TabStop = false;
            this.setButton.UseVisualStyleBackColor = false;
            this.setButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            this.setButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            // 
            // leftPictureBox
            // 
            this.leftPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.leftPictureBox.BackgroundImage = global::ScreenGrabber.Properties.Resources.sides;
            this.leftPictureBox.Location = new System.Drawing.Point(0, 39);
            this.leftPictureBox.Name = "leftPictureBox";
            this.leftPictureBox.Size = new System.Drawing.Size(6, 80);
            this.leftPictureBox.TabIndex = 10;
            this.leftPictureBox.TabStop = false;
            this.leftPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resizeButton_MouseDown);
            this.leftPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.resizeButton_MouseUp);
            // 
            // rightTopPictureBox
            // 
            this.rightTopPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rightTopPictureBox.Image = global::ScreenGrabber.Properties.Resources.sidesTop;
            this.rightTopPictureBox.Location = new System.Drawing.Point(199, 25);
            this.rightTopPictureBox.Name = "rightTopPictureBox";
            this.rightTopPictureBox.Size = new System.Drawing.Size(6, 14);
            this.rightTopPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rightTopPictureBox.TabIndex = 9;
            this.rightTopPictureBox.TabStop = false;
            this.rightTopPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resizeButton_MouseDown);
            this.rightTopPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.resizeButton_MouseUp);
            // 
            // leftTopPictureBox
            // 
            this.leftTopPictureBox.Image = global::ScreenGrabber.Properties.Resources.sidesTop;
            this.leftTopPictureBox.Location = new System.Drawing.Point(0, 25);
            this.leftTopPictureBox.Name = "leftTopPictureBox";
            this.leftTopPictureBox.Size = new System.Drawing.Size(6, 14);
            this.leftTopPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.leftTopPictureBox.TabIndex = 9;
            this.leftTopPictureBox.TabStop = false;
            this.leftTopPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resizeButton_MouseDown);
            this.leftTopPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.resizeButton_MouseUp);
            // 
            // topRightPictureBox
            // 
            this.topRightPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.topRightPictureBox.Image = global::ScreenGrabber.Properties.Resources.topRight;
            this.topRightPictureBox.Location = new System.Drawing.Point(199, 0);
            this.topRightPictureBox.Name = "topRightPictureBox";
            this.topRightPictureBox.Size = new System.Drawing.Size(6, 25);
            this.topRightPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.topRightPictureBox.TabIndex = 8;
            this.topRightPictureBox.TabStop = false;
            this.topRightPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resizeButton_MouseDown);
            this.topRightPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.resizeButton_MouseUp);
            // 
            // topPictureBox
            // 
            this.topPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.topPictureBox.BackgroundImage = global::ScreenGrabber.Properties.Resources.top;
            this.topPictureBox.Location = new System.Drawing.Point(183, 0);
            this.topPictureBox.Name = "topPictureBox";
            this.topPictureBox.Size = new System.Drawing.Size(16, 25);
            this.topPictureBox.TabIndex = 7;
            this.topPictureBox.TabStop = false;
            this.topPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resizeButton_MouseDown);
            this.topPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.resizeButton_MouseUp);
            // 
            // topLeftPictureBox
            // 
            this.topLeftPictureBox.Image = global::ScreenGrabber.Properties.Resources.topLeft;
            this.topLeftPictureBox.Location = new System.Drawing.Point(0, 0);
            this.topLeftPictureBox.Name = "topLeftPictureBox";
            this.topLeftPictureBox.Size = new System.Drawing.Size(6, 25);
            this.topLeftPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.topLeftPictureBox.TabIndex = 6;
            this.topLeftPictureBox.TabStop = false;
            this.topLeftPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resizeButton_MouseDown);
            this.topLeftPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.resizeButton_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ScreenGrabber.Properties.Resources.topHeader;
            this.pictureBox1.Location = new System.Drawing.Point(6, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resizeButton_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.resizeButton_MouseUp);
            // 
            // resizePictureBox
            // 
            this.resizePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resizePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.resizePictureBox.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.resizePictureBox.Image = global::ScreenGrabber.Properties.Resources.btnResize;
            this.resizePictureBox.ImageLocation = "";
            this.resizePictureBox.Location = new System.Drawing.Point(168, 90);
            this.resizePictureBox.Name = "resizePictureBox";
            this.resizePictureBox.Size = new System.Drawing.Size(31, 29);
            this.resizePictureBox.TabIndex = 15;
            this.resizePictureBox.TabStop = false;
            this.resizePictureBox.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            this.resizePictureBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.resizePictureBox_MouseDoubleClick);
            this.resizePictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resizeButton_MouseDown);
            this.resizePictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.resizeButton_MouseUp);
            this.resizePictureBox.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            // 
            // BoundsSetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(205, 125);
            this.ControlBox = false;
            this.Controls.Add(this.resizePictureBox);
            this.Controls.Add(this.heightMaskedTextBox);
            this.Controls.Add(this.locationMaskedTextBox);
            this.Controls.Add(this.widthMaskedTextBox);
            this.Controls.Add(this.bottomPictureBox);
            this.Controls.Add(this.bottomRightPictureBox);
            this.Controls.Add(this.bottomLeftPictureBox);
            this.Controls.Add(this.rightPictureBox);
            this.Controls.Add(this.setButton);
            this.Controls.Add(this.leftPictureBox);
            this.Controls.Add(this.rightTopPictureBox);
            this.Controls.Add(this.leftTopPictureBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.topRightPictureBox);
            this.Controls.Add(this.topPictureBox);
            this.Controls.Add(this.topLeftPictureBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.stickyCheckBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(156, 99);
            this.Name = "BoundsSetter";
            this.Text = "Bounds Setter";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.InactiveCaptionText;
            this.Load += new System.EventHandler(this.BoundsSetter_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.resizeButton_MouseUp);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.BoundsSetter_Paint);
            this.Activated += new System.EventHandler(this.BoundsSetter_Activated);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resizeButton_MouseDown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BoundsSetter_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bottomPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomRightPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomLeftPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightTopPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftTopPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topRightPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topLeftPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resizePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.Timer positionTimer;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer startUpTimer;
        private System.Windows.Forms.Timer resizeTimer;
        private System.Windows.Forms.CheckBox stickyCheckBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.MaskedTextBox widthMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox heightMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox locationMaskedTextBox;
        private System.Windows.Forms.PictureBox topLeftPictureBox;
        private System.Windows.Forms.PictureBox topPictureBox;
        private System.Windows.Forms.PictureBox topRightPictureBox;
        private System.Windows.Forms.PictureBox leftTopPictureBox;
        private System.Windows.Forms.PictureBox rightTopPictureBox;
        private System.Windows.Forms.PictureBox leftPictureBox;
        private System.Windows.Forms.PictureBox rightPictureBox;
        private System.Windows.Forms.PictureBox bottomLeftPictureBox;
        private System.Windows.Forms.PictureBox bottomRightPictureBox;
        private System.Windows.Forms.PictureBox bottomPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox resizePictureBox;
    }
}