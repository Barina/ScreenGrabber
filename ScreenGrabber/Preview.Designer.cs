namespace ScreenGrabber
{
    partial class Preview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preview));
            this.mainContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msgPanel = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.locationTimer = new System.Windows.Forms.Timer(this.components);
            this.preparingImageBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.previewPictureBox = new System.Windows.Forms.PictureBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.mainContextMenuStrip.SuspendLayout();
            this.msgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContextMenuStrip
            // 
            this.mainContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.mainContextMenuStrip.Name = "mainContextMenuStrip";
            this.mainContextMenuStrip.Size = new System.Drawing.Size(104, 26);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // msgPanel
            // 
            this.msgPanel.BackColor = System.Drawing.SystemColors.Control;
            this.msgPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msgPanel.Controls.Add(this.cancelButton);
            this.msgPanel.Controls.Add(this.progressBar1);
            this.msgPanel.Controls.Add(this.label1);
            this.msgPanel.Location = new System.Drawing.Point(155, 112);
            this.msgPanel.Name = "msgPanel";
            this.msgPanel.Size = new System.Drawing.Size(200, 73);
            this.msgPanel.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(3, 21);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(192, 18);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please wait...";
            // 
            // locationTimer
            // 
            this.locationTimer.Interval = 10;
            this.locationTimer.Tick += new System.EventHandler(this.locationTimer_Tick);
            // 
            // preparingImageBackgroundWorker
            // 
            this.preparingImageBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.preparingImageBackgroundWorker_DoWork);
            this.preparingImageBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.preparingImageBackgroundWorker_RunWorkerCompleted);
            // 
            // previewPictureBox
            // 
            this.previewPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.previewPictureBox.Location = new System.Drawing.Point(1, 1);
            this.previewPictureBox.Name = "previewPictureBox";
            this.previewPictureBox.Size = new System.Drawing.Size(508, 293);
            this.previewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previewPictureBox.TabIndex = 1;
            this.previewPictureBox.TabStop = false;
            this.previewPictureBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Preview_MouseDoubleClick);
            this.previewPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Preview_MouseDown);
            this.previewPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Preview_MouseUp);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(62, 45);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // Preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(510, 295);
            this.ContextMenuStrip = this.mainContextMenuStrip;
            this.Controls.Add(this.msgPanel);
            this.Controls.Add(this.previewPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Preview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preview";
            this.TopMost = true;
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Preview_MouseUp);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Preview_MouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Preview_MouseDown);
            this.mainContextMenuStrip.ResumeLayout(false);
            this.msgPanel.ResumeLayout(false);
            this.msgPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer locationTimer;
        private System.Windows.Forms.ContextMenuStrip mainContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker preparingImageBackgroundWorker;
        private System.Windows.Forms.Panel msgPanel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox previewPictureBox;
        private System.Windows.Forms.Button cancelButton;
    }
}