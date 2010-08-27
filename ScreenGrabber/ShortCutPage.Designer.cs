namespace ScreenGrabber
{
    partial class ShortCutPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShortCutPage));
            this.masterPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.folderButton = new System.Windows.Forms.Button();
            this.snapRadioButton = new System.Windows.Forms.RadioButton();
            this.regularRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.shortCutNameTextBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.masterPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // masterPanel
            // 
            this.masterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.masterPanel.BackColor = System.Drawing.SystemColors.Control;
            this.masterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.masterPanel.Controls.Add(this.cancelButton);
            this.masterPanel.Controls.Add(this.folderButton);
            this.masterPanel.Controls.Add(this.snapRadioButton);
            this.masterPanel.Controls.Add(this.regularRadioButton);
            this.masterPanel.Controls.Add(this.groupBox1);
            this.masterPanel.Controls.Add(this.label2);
            this.masterPanel.Controls.Add(this.shortCutNameTextBox);
            this.masterPanel.Controls.Add(this.createButton);
            this.masterPanel.Location = new System.Drawing.Point(4, 4);
            this.masterPanel.Name = "masterPanel";
            this.masterPanel.Size = new System.Drawing.Size(271, 181);
            this.masterPanel.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(3, 153);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // folderButton
            // 
            this.folderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.folderButton.Location = new System.Drawing.Point(110, 153);
            this.folderButton.Name = "folderButton";
            this.folderButton.Size = new System.Drawing.Size(75, 23);
            this.folderButton.TabIndex = 7;
            this.folderButton.Text = "Browse";
            this.folderButton.UseVisualStyleBackColor = true;
            this.folderButton.Click += new System.EventHandler(this.folderButton_Click);
            // 
            // snapRadioButton
            // 
            this.snapRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.snapRadioButton.AutoSize = true;
            this.snapRadioButton.Location = new System.Drawing.Point(15, 128);
            this.snapRadioButton.Name = "snapRadioButton";
            this.snapRadioButton.Size = new System.Drawing.Size(182, 17);
            this.snapRadioButton.TabIndex = 6;
            this.snapRadioButton.Text = "Shortcut for snapping the screen.";
            this.snapRadioButton.UseVisualStyleBackColor = true;
            this.snapRadioButton.CheckedChanged += new System.EventHandler(this.regularRadioButton_CheckedChanged);
            // 
            // regularRadioButton
            // 
            this.regularRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.regularRadioButton.AutoSize = true;
            this.regularRadioButton.Checked = true;
            this.regularRadioButton.Location = new System.Drawing.Point(15, 105);
            this.regularRadioButton.Name = "regularRadioButton";
            this.regularRadioButton.Size = new System.Drawing.Size(194, 17);
            this.regularRadioButton.TabIndex = 5;
            this.regularRadioButton.TabStop = true;
            this.regularRadioButton.Text = "Shortcut to Launch ScreenGrabber.";
            this.regularRadioButton.UseVisualStyleBackColor = true;
            this.regularRadioButton.CheckedChanged += new System.EventHandler(this.regularRadioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pathLabel);
            this.groupBox1.Location = new System.Drawing.Point(6, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 70);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shortcut Path:";
            // 
            // pathLabel
            // 
            this.pathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(6, 16);
            this.pathLabel.MaximumSize = new System.Drawing.Size(240, 46);
            this.pathLabel.MinimumSize = new System.Drawing.Size(240, 46);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(240, 46);
            this.pathLabel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Shortcut Name:";
            // 
            // shortCutNameTextBox
            // 
            this.shortCutNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.shortCutNameTextBox.Location = new System.Drawing.Point(96, 3);
            this.shortCutNameTextBox.Name = "shortCutNameTextBox";
            this.shortCutNameTextBox.Size = new System.Drawing.Size(168, 20);
            this.shortCutNameTextBox.TabIndex = 2;
            this.shortCutNameTextBox.Text = "Launch ScreenGrabber";
            this.shortCutNameTextBox.TextChanged += new System.EventHandler(this.shortCutNameTextBox_TextChanged);
            // 
            // createButton
            // 
            this.createButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.createButton.Location = new System.Drawing.Point(191, 153);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 0;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShortCutPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(279, 189);
            this.Controls.Add(this.masterPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShortCutPage";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Making ShortCut";
            this.Load += new System.EventHandler(this.ShortCutPage_Load);
            this.masterPanel.ResumeLayout(false);
            this.masterPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel masterPanel;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox shortCutNameTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton snapRadioButton;
        private System.Windows.Forms.RadioButton regularRadioButton;
        private System.Windows.Forms.Button folderButton;
        private System.Windows.Forms.Button cancelButton;
    }
}