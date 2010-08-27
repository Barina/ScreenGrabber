namespace ScreenGrabber
{
    partial class NewerSetBounds
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewerSetBounds));
            this.paintTimer = new System.Windows.Forms.Timer(this.components);
            this.detailsLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.detailsPanel = new System.Windows.Forms.Panel();
            this.panelLocationTimer = new System.Windows.Forms.Timer(this.components);
            this.shadowPanel = new System.Windows.Forms.Panel();
            this.shadowPictureBox = new System.Windows.Forms.PictureBox();
            this.shadowRightPictureBox = new System.Windows.Forms.PictureBox();
            this.shadowLeftPictureBox = new System.Windows.Forms.PictureBox();
            this.shadowTopPictureBox = new System.Windows.Forms.PictureBox();
            this.shadowBottomRightPictureBox = new System.Windows.Forms.PictureBox();
            this.shadowBottomLeftPictureBox = new System.Windows.Forms.PictureBox();
            this.shadowTopRightPictureBox = new System.Windows.Forms.PictureBox();
            this.shadowTopLeftPictureBox = new System.Windows.Forms.PictureBox();
            this.mouseHoverTimer = new System.Windows.Forms.Timer(this.components);
            this.controlsPanel.SuspendLayout();
            this.detailsPanel.SuspendLayout();
            this.shadowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shadowPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shadowRightPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shadowLeftPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shadowTopPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shadowBottomRightPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shadowBottomLeftPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shadowTopRightPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shadowTopLeftPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // paintTimer
            // 
            this.paintTimer.Interval = 10;
            this.paintTimer.Tick += new System.EventHandler(this.paintTimer_Tick);
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.Location = new System.Drawing.Point(3, 7);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(37, 13);
            this.detailsLabel.TabIndex = 0;
            this.detailsLabel.Text = "details";
            this.detailsLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlsPanel_MouseDown);
            this.detailsLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlsPanel_MouseUp);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(166, 28);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(85, 28);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.clearButton.Location = new System.Drawing.Point(4, 28);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // controlsPanel
            // 
            this.controlsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.controlsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.controlsPanel.Controls.Add(this.clearButton);
            this.controlsPanel.Controls.Add(this.cancelButton);
            this.controlsPanel.Controls.Add(this.okButton);
            this.controlsPanel.Controls.Add(this.detailsLabel);
            this.controlsPanel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.controlsPanel.Location = new System.Drawing.Point(12, 37);
            this.controlsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(246, 56);
            this.controlsPanel.TabIndex = 0;
            this.controlsPanel.Visible = false;
            this.controlsPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlsPanel_MouseDown);
            this.controlsPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlsPanel_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please select the area you want to snap.";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ScreenGrabberSetBounds_MouseDown);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ScreenGrabberSetBounds_MouseUp);
            // 
            // detailsPanel
            // 
            this.detailsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.detailsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailsPanel.Controls.Add(this.label1);
            this.detailsPanel.Location = new System.Drawing.Point(12, 12);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(204, 22);
            this.detailsPanel.TabIndex = 4;
            this.detailsPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ScreenGrabberSetBounds_MouseDown);
            this.detailsPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ScreenGrabberSetBounds_MouseUp);
            // 
            // panelLocationTimer
            // 
            this.panelLocationTimer.Interval = 10;
            this.panelLocationTimer.Tick += new System.EventHandler(this.panelLocationTimer_Tick);
            // 
            // shadowPanel
            // 
            this.shadowPanel.BackColor = System.Drawing.Color.Transparent;
            this.shadowPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.shadowPanel.Controls.Add(this.shadowPictureBox);
            this.shadowPanel.Controls.Add(this.shadowRightPictureBox);
            this.shadowPanel.Controls.Add(this.shadowLeftPictureBox);
            this.shadowPanel.Controls.Add(this.shadowTopPictureBox);
            this.shadowPanel.Controls.Add(this.shadowBottomRightPictureBox);
            this.shadowPanel.Controls.Add(this.shadowBottomLeftPictureBox);
            this.shadowPanel.Controls.Add(this.shadowTopRightPictureBox);
            this.shadowPanel.Controls.Add(this.shadowTopLeftPictureBox);
            this.shadowPanel.Location = new System.Drawing.Point(12, 96);
            this.shadowPanel.MinimumSize = new System.Drawing.Size(140, 140);
            this.shadowPanel.Name = "shadowPanel";
            this.shadowPanel.Size = new System.Drawing.Size(246, 164);
            this.shadowPanel.TabIndex = 5;
            this.shadowPanel.Visible = false;
            this.shadowPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ScreenGrabberSetBounds_MouseDown);
            this.shadowPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ScreenGrabberSetBounds_MouseUp);
            // 
            // shadowPictureBox
            // 
            this.shadowPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.shadowPictureBox.BackgroundImage = global::ScreenGrabber.Properties.Resources.shadowBottom;
            this.shadowPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.shadowPictureBox.Location = new System.Drawing.Point(70, 94);
            this.shadowPictureBox.Name = "shadowPictureBox";
            this.shadowPictureBox.Size = new System.Drawing.Size(106, 70);
            this.shadowPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shadowPictureBox.TabIndex = 7;
            this.shadowPictureBox.TabStop = false;
            this.shadowPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ScreenGrabberSetBounds_MouseDown);
            this.shadowPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ScreenGrabberSetBounds_MouseUp);
            // 
            // shadowRightPictureBox
            // 
            this.shadowRightPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.shadowRightPictureBox.BackgroundImage = global::ScreenGrabber.Properties.Resources.shadowRight;
            this.shadowRightPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.shadowRightPictureBox.Location = new System.Drawing.Point(176, 70);
            this.shadowRightPictureBox.Name = "shadowRightPictureBox";
            this.shadowRightPictureBox.Size = new System.Drawing.Size(70, 24);
            this.shadowRightPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shadowRightPictureBox.TabIndex = 6;
            this.shadowRightPictureBox.TabStop = false;
            this.shadowRightPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ScreenGrabberSetBounds_MouseDown);
            this.shadowRightPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ScreenGrabberSetBounds_MouseUp);
            // 
            // shadowLeftPictureBox
            // 
            this.shadowLeftPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.shadowLeftPictureBox.BackgroundImage = global::ScreenGrabber.Properties.Resources.shadowLeft;
            this.shadowLeftPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.shadowLeftPictureBox.Location = new System.Drawing.Point(0, 70);
            this.shadowLeftPictureBox.Name = "shadowLeftPictureBox";
            this.shadowLeftPictureBox.Size = new System.Drawing.Size(70, 24);
            this.shadowLeftPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shadowLeftPictureBox.TabIndex = 5;
            this.shadowLeftPictureBox.TabStop = false;
            this.shadowLeftPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ScreenGrabberSetBounds_MouseDown);
            this.shadowLeftPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ScreenGrabberSetBounds_MouseUp);
            // 
            // shadowTopPictureBox
            // 
            this.shadowTopPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.shadowTopPictureBox.BackgroundImage = global::ScreenGrabber.Properties.Resources.shadowTop;
            this.shadowTopPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.shadowTopPictureBox.Location = new System.Drawing.Point(70, 0);
            this.shadowTopPictureBox.Name = "shadowTopPictureBox";
            this.shadowTopPictureBox.Size = new System.Drawing.Size(106, 70);
            this.shadowTopPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shadowTopPictureBox.TabIndex = 4;
            this.shadowTopPictureBox.TabStop = false;
            this.shadowTopPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ScreenGrabberSetBounds_MouseDown);
            this.shadowTopPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ScreenGrabberSetBounds_MouseUp);
            // 
            // shadowBottomRightPictureBox
            // 
            this.shadowBottomRightPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.shadowBottomRightPictureBox.Image = global::ScreenGrabber.Properties.Resources.shadowBottomRight;
            this.shadowBottomRightPictureBox.Location = new System.Drawing.Point(176, 94);
            this.shadowBottomRightPictureBox.Name = "shadowBottomRightPictureBox";
            this.shadowBottomRightPictureBox.Size = new System.Drawing.Size(70, 70);
            this.shadowBottomRightPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.shadowBottomRightPictureBox.TabIndex = 3;
            this.shadowBottomRightPictureBox.TabStop = false;
            this.shadowBottomRightPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ScreenGrabberSetBounds_MouseDown);
            this.shadowBottomRightPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ScreenGrabberSetBounds_MouseUp);
            // 
            // shadowBottomLeftPictureBox
            // 
            this.shadowBottomLeftPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.shadowBottomLeftPictureBox.Image = global::ScreenGrabber.Properties.Resources.shadowBottomLeft;
            this.shadowBottomLeftPictureBox.Location = new System.Drawing.Point(0, 94);
            this.shadowBottomLeftPictureBox.Name = "shadowBottomLeftPictureBox";
            this.shadowBottomLeftPictureBox.Size = new System.Drawing.Size(70, 70);
            this.shadowBottomLeftPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.shadowBottomLeftPictureBox.TabIndex = 2;
            this.shadowBottomLeftPictureBox.TabStop = false;
            this.shadowBottomLeftPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ScreenGrabberSetBounds_MouseDown);
            this.shadowBottomLeftPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ScreenGrabberSetBounds_MouseUp);
            // 
            // shadowTopRightPictureBox
            // 
            this.shadowTopRightPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.shadowTopRightPictureBox.Image = global::ScreenGrabber.Properties.Resources.shadowTopRight;
            this.shadowTopRightPictureBox.Location = new System.Drawing.Point(176, 0);
            this.shadowTopRightPictureBox.Name = "shadowTopRightPictureBox";
            this.shadowTopRightPictureBox.Size = new System.Drawing.Size(70, 70);
            this.shadowTopRightPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.shadowTopRightPictureBox.TabIndex = 1;
            this.shadowTopRightPictureBox.TabStop = false;
            this.shadowTopRightPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ScreenGrabberSetBounds_MouseDown);
            this.shadowTopRightPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ScreenGrabberSetBounds_MouseUp);
            // 
            // shadowTopLeftPictureBox
            // 
            this.shadowTopLeftPictureBox.Image = global::ScreenGrabber.Properties.Resources.shadowTopLeft;
            this.shadowTopLeftPictureBox.Location = new System.Drawing.Point(0, 0);
            this.shadowTopLeftPictureBox.Name = "shadowTopLeftPictureBox";
            this.shadowTopLeftPictureBox.Size = new System.Drawing.Size(70, 70);
            this.shadowTopLeftPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.shadowTopLeftPictureBox.TabIndex = 0;
            this.shadowTopLeftPictureBox.TabStop = false;
            this.shadowTopLeftPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ScreenGrabberSetBounds_MouseDown);
            this.shadowTopLeftPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ScreenGrabberSetBounds_MouseUp);
            // 
            // mouseHoverTimer
            // 
            this.mouseHoverTimer.Interval = 10;
            this.mouseHoverTimer.Tick += new System.EventHandler(this.mouseHoverTimer_Tick);
            // 
            // NewerSetBounds
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(272, 275);
            this.Controls.Add(this.controlsPanel);
            this.Controls.Add(this.detailsPanel);
            this.Controls.Add(this.shadowPanel);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewerSetBounds";
            this.Opacity = 0.8;
            this.ShowInTaskbar = false;
            this.Text = "Area selection";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.GreenYellow;
            this.Load += new System.EventHandler(this.NewerSetBounds_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ScreenGrabberSetBounds_MouseUp);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ScreenGrabberSetBounds_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ScreenGrabberSetBounds_MouseDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ScreenGrabberSetBounds_KeyUp);
            this.Resize += new System.EventHandler(this.ScreenGrabberSetBounds_Resize);
            this.controlsPanel.ResumeLayout(false);
            this.controlsPanel.PerformLayout();
            this.detailsPanel.ResumeLayout(false);
            this.detailsPanel.PerformLayout();
            this.shadowPanel.ResumeLayout(false);
            this.shadowPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shadowPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shadowRightPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shadowLeftPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shadowTopPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shadowBottomRightPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shadowBottomLeftPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shadowTopRightPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shadowTopLeftPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer paintTimer;
        private System.Windows.Forms.Label detailsLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Panel controlsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel detailsPanel;
        private System.Windows.Forms.Timer panelLocationTimer;
        private System.Windows.Forms.Panel shadowPanel;
        private System.Windows.Forms.PictureBox shadowTopPictureBox;
        private System.Windows.Forms.PictureBox shadowBottomRightPictureBox;
        private System.Windows.Forms.PictureBox shadowBottomLeftPictureBox;
        private System.Windows.Forms.PictureBox shadowTopRightPictureBox;
        private System.Windows.Forms.PictureBox shadowTopLeftPictureBox;
        private System.Windows.Forms.PictureBox shadowPictureBox;
        private System.Windows.Forms.PictureBox shadowRightPictureBox;
        private System.Windows.Forms.PictureBox shadowLeftPictureBox;
        private System.Windows.Forms.Timer mouseHoverTimer;
    }
}