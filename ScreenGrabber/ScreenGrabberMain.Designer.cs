namespace ScreenGrabber
{
    partial class ScreenGrabberMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenGrabberMain));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boundsSetterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.saveButton = new System.Windows.Forms.Button();
            this.timeTakeButton = new System.Windows.Forms.Button();
            this.setBoundsButton = new System.Windows.Forms.Button();
            this.hideButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.previewPictureBox = new System.Windows.Forms.PictureBox();
            this.previewContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enlargeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeButton = new System.Windows.Forms.Button();
            this.customCheckBox = new System.Windows.Forms.CheckBox();
            this.grabWebButton = new System.Windows.Forms.Button();
            this.positionTimer = new System.Windows.Forms.Timer(this.components);
            this.onLoadBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.snapsDatabaseDataSet = new ScreenGrabber.SnapsDatabaseDataSet();
            this.accountsTableAdapter = new ScreenGrabber.SnapsDatabaseDataSetTableAdapters.AccountsTableAdapter();
            this.snapsTableAdapter = new ScreenGrabber.SnapsDatabaseDataSetTableAdapters.SnapsTableAdapter();
            this.shortCutButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.mySnapsButton = new System.Windows.Forms.Button();
            this.newSetterButton = new System.Windows.Forms.Button();
            this.positionLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.hotKeyLabel = new System.Windows.Forms.Label();
            this.pathLabel = new System.Windows.Forms.Label();
            this.timeTakeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gradientBackgroundPainter = new ProgressODoom.GradientBackgroundPainter();
            this.autoGrabberProgressBarEx = new ProgressODoom.ProgressBarEx();
            this.plainBorderPainter = new ProgressODoom.PlainBorderPainter();
            this.stripedProgressPainter = new ProgressODoom.StripedProgressPainter();
            this.gradientGlossPainter = new ProgressODoom.GradientGlossPainter();
            this.notifyContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).BeginInit();
            this.previewContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.snapsDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.notifyContextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Screen Grabber";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // notifyContextMenuStrip
            // 
            this.notifyContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.notifyContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showWindowToolStripMenuItem,
            this.boundsSetterToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.notifyContextMenuStrip.Name = "contextMenuStrip1";
            this.notifyContextMenuStrip.ShowImageMargin = false;
            this.notifyContextMenuStrip.Size = new System.Drawing.Size(123, 98);
            // 
            // showWindowToolStripMenuItem
            // 
            this.showWindowToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showWindowToolStripMenuItem.Name = "showWindowToolStripMenuItem";
            this.showWindowToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.showWindowToolStripMenuItem.Text = "Show/Hide";
            this.showWindowToolStripMenuItem.Click += new System.EventHandler(this.showWindowToolStripMenuItem_Click);
            // 
            // boundsSetterToolStripMenuItem
            // 
            this.boundsSetterToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.boundsSetterToolStripMenuItem.Name = "boundsSetterToolStripMenuItem";
            this.boundsSetterToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.boundsSetterToolStripMenuItem.Text = "Bounds Setter";
            this.boundsSetterToolStripMenuItem.Click += new System.EventHandler(this.boundsSetterToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(119, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Transparent;
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(450, 111);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(179, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save to Disc";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.saveButton, "Save the screen to your chosen file and hide this window.");
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // timeTakeButton
            // 
            this.timeTakeButton.BackColor = System.Drawing.Color.Transparent;
            this.timeTakeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.timeTakeButton.FlatAppearance.BorderSize = 0;
            this.timeTakeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.timeTakeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timeTakeButton.ForeColor = System.Drawing.Color.White;
            this.timeTakeButton.Location = new System.Drawing.Point(450, 140);
            this.timeTakeButton.Name = "timeTakeButton";
            this.timeTakeButton.Size = new System.Drawing.Size(179, 23);
            this.timeTakeButton.TabIndex = 6;
            this.timeTakeButton.Text = "Initiate AutoGrabber";
            this.timeTakeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.timeTakeButton, "Grab a snap in 20 seconds. Make sure \'Overwrite\' is unchecked.");
            this.timeTakeButton.UseVisualStyleBackColor = false;
            this.timeTakeButton.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // setBoundsButton
            // 
            this.setBoundsButton.BackColor = System.Drawing.Color.Transparent;
            this.setBoundsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.setBoundsButton.FlatAppearance.BorderSize = 0;
            this.setBoundsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.setBoundsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setBoundsButton.ForeColor = System.Drawing.Color.White;
            this.setBoundsButton.Location = new System.Drawing.Point(19, 140);
            this.setBoundsButton.Name = "setBoundsButton";
            this.setBoundsButton.Size = new System.Drawing.Size(179, 23);
            this.setBoundsButton.TabIndex = 2;
            this.setBoundsButton.Text = "Set Custom Bounds";
            this.setBoundsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.setBoundsButton, "Raise a rectangle to set area you want to snap.");
            this.setBoundsButton.UseVisualStyleBackColor = false;
            this.setBoundsButton.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // hideButton
            // 
            this.hideButton.BackColor = System.Drawing.Color.Transparent;
            this.hideButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hideButton.FlatAppearance.BorderSize = 0;
            this.hideButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hideButton.ForeColor = System.Drawing.Color.White;
            this.hideButton.Location = new System.Drawing.Point(19, 233);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(179, 23);
            this.hideButton.TabIndex = 9;
            this.hideButton.Text = "Minimize to tray.";
            this.hideButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.hideButton, "Hide or Minimize to tray this Window.");
            this.hideButton.UseVisualStyleBackColor = false;
            this.hideButton.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.BackgroundImage = global::ScreenGrabber.Properties.Resources.btnMinimize;
            this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.minimizeButton.ForeColor = System.Drawing.Color.Black;
            this.minimizeButton.Location = new System.Drawing.Point(561, 33);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(24, 21);
            this.minimizeButton.TabIndex = 13;
            this.minimizeButton.TabStop = false;
            this.toolTip.SetToolTip(this.minimizeButton, "Minimize this Window.");
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.Buttons_Click);
            this.minimizeButton.MouseEnter += new System.EventHandler(this.minimizeButton_MouseEnter);
            this.minimizeButton.MouseLeave += new System.EventHandler(this.minimizeButton_MouseLeave);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.BackgroundImage = global::ScreenGrabber.Properties.Resources.btnClose;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.closeButton.ForeColor = System.Drawing.Color.Black;
            this.closeButton.Location = new System.Drawing.Point(591, 33);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(24, 21);
            this.closeButton.TabIndex = 17;
            this.closeButton.TabStop = false;
            this.toolTip.SetToolTip(this.closeButton, "Close the program.");
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.Buttons_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // previewPictureBox
            // 
            this.previewPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.previewPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.previewPictureBox.ContextMenuStrip = this.previewContextMenuStrip;
            this.previewPictureBox.Image = global::ScreenGrabber.Properties.Resources.imageEmpty;
            this.previewPictureBox.Location = new System.Drawing.Point(205, 77);
            this.previewPictureBox.MaximumSize = new System.Drawing.Size(238, 178);
            this.previewPictureBox.MinimumSize = new System.Drawing.Size(238, 178);
            this.previewPictureBox.Name = "previewPictureBox";
            this.previewPictureBox.Size = new System.Drawing.Size(238, 178);
            this.previewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previewPictureBox.TabIndex = 33;
            this.previewPictureBox.TabStop = false;
            this.toolTip.SetToolTip(this.previewPictureBox, "a Preview of the screen shot.");
            this.previewPictureBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDoubleClick);
            this.previewPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.masterPanel_MouseDown);
            this.previewPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.masterPanel_MouseUp);
            // 
            // previewContextMenuStrip
            // 
            this.previewContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.enlargeToolStripMenuItem});
            this.previewContextMenuStrip.Name = "previewContextMenuStrip";
            this.previewContextMenuStrip.Size = new System.Drawing.Size(114, 48);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // enlargeToolStripMenuItem
            // 
            this.enlargeToolStripMenuItem.Name = "enlargeToolStripMenuItem";
            this.enlargeToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.enlargeToolStripMenuItem.Text = "Enlarge";
            this.enlargeToolStripMenuItem.Click += new System.EventHandler(this.enlargeToolStripMenuItem_Click);
            // 
            // takeButton
            // 
            this.takeButton.BackColor = System.Drawing.Color.Transparent;
            this.takeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.takeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.takeButton.FlatAppearance.BorderSize = 0;
            this.takeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.takeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.takeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.takeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.takeButton.ForeColor = System.Drawing.Color.White;
            this.takeButton.Location = new System.Drawing.Point(450, 76);
            this.takeButton.Name = "takeButton";
            this.takeButton.Size = new System.Drawing.Size(179, 29);
            this.takeButton.TabIndex = 7;
            this.takeButton.Text = "Grab Screen";
            this.takeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.takeButton, "Grab your current screen.");
            this.takeButton.UseVisualStyleBackColor = false;
            this.takeButton.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // customCheckBox
            // 
            this.customCheckBox.AutoSize = true;
            this.customCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.customCheckBox.Checked = global::ScreenGrabber.Properties.Settings.Default.CustomBounds;
            this.customCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ScreenGrabber.Properties.Settings.Default, "CustomBounds", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.customCheckBox.ForeColor = System.Drawing.Color.White;
            this.customCheckBox.Location = new System.Drawing.Point(458, 205);
            this.customCheckBox.Name = "customCheckBox";
            this.customCheckBox.Size = new System.Drawing.Size(165, 17);
            this.customCheckBox.TabIndex = 1;
            this.customCheckBox.Text = "Use Custom bounds Grabber.";
            this.toolTip.SetToolTip(this.customCheckBox, "Use your custom area that you set earlier. if not will use default(p0,0 full size" +
                    "). press \"Set Custom Bounds\" to set a new work area.");
            this.customCheckBox.UseVisualStyleBackColor = false;
            this.customCheckBox.CheckedChanged += new System.EventHandler(this.customCheckBox_CheckedChanged);
            // 
            // grabWebButton
            // 
            this.grabWebButton.BackColor = System.Drawing.Color.Transparent;
            this.grabWebButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grabWebButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.grabWebButton.FlatAppearance.BorderSize = 0;
            this.grabWebButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.grabWebButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.grabWebButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grabWebButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.grabWebButton.ForeColor = System.Drawing.Color.White;
            this.grabWebButton.Location = new System.Drawing.Point(19, 76);
            this.grabWebButton.Name = "grabWebButton";
            this.grabWebButton.Size = new System.Drawing.Size(179, 29);
            this.grabWebButton.TabIndex = 7;
            this.grabWebButton.Text = "Grab Web";
            this.grabWebButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.grabWebButton, "Grab a web page full content.");
            this.grabWebButton.UseVisualStyleBackColor = false;
            this.grabWebButton.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // positionTimer
            // 
            this.positionTimer.Interval = 10;
            this.positionTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // onLoadBackgroundWorker
            // 
            this.onLoadBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // snapsDatabaseDataSet
            // 
            this.snapsDatabaseDataSet.DataSetName = "SnapsDatabaseDataSet";
            this.snapsDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountsTableAdapter
            // 
            this.accountsTableAdapter.ClearBeforeFill = true;
            // 
            // snapsTableAdapter
            // 
            this.snapsTableAdapter.ClearBeforeFill = true;
            // 
            // shortCutButton
            // 
            this.shortCutButton.BackColor = System.Drawing.Color.Transparent;
            this.shortCutButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.shortCutButton.FlatAppearance.BorderSize = 0;
            this.shortCutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.shortCutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shortCutButton.ForeColor = System.Drawing.Color.White;
            this.shortCutButton.Location = new System.Drawing.Point(19, 111);
            this.shortCutButton.Name = "shortCutButton";
            this.shortCutButton.Size = new System.Drawing.Size(179, 23);
            this.shortCutButton.TabIndex = 31;
            this.shortCutButton.Text = "Create Shortcuts";
            this.shortCutButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.shortCutButton.UseVisualStyleBackColor = false;
            this.shortCutButton.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.Transparent;
            this.settingsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.settingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.Location = new System.Drawing.Point(450, 169);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(179, 23);
            this.settingsButton.TabIndex = 35;
            this.settingsButton.Text = "Settings";
            this.settingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.BackColor = System.Drawing.Color.Transparent;
            this.aboutButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.aboutButton.FlatAppearance.BorderSize = 0;
            this.aboutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.ForeColor = System.Drawing.Color.White;
            this.aboutButton.Location = new System.Drawing.Point(450, 233);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(179, 23);
            this.aboutButton.TabIndex = 34;
            this.aboutButton.TabStop = false;
            this.aboutButton.Text = "About";
            this.aboutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutButton.UseVisualStyleBackColor = false;
            this.aboutButton.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.sizeLabel.ForeColor = System.Drawing.Color.White;
            this.sizeLabel.Location = new System.Drawing.Point(447, 295);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(64, 13);
            this.sizeLabel.TabIndex = 23;
            this.sizeLabel.Text = "grabber size";
            this.sizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sizeLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.masterPanel_MouseDown);
            this.sizeLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.masterPanel_MouseUp);
            // 
            // mySnapsButton
            // 
            this.mySnapsButton.BackColor = System.Drawing.Color.Transparent;
            this.mySnapsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.mySnapsButton.FlatAppearance.BorderSize = 0;
            this.mySnapsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mySnapsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mySnapsButton.ForeColor = System.Drawing.Color.White;
            this.mySnapsButton.Location = new System.Drawing.Point(19, 175);
            this.mySnapsButton.Name = "mySnapsButton";
            this.mySnapsButton.Size = new System.Drawing.Size(179, 23);
            this.mySnapsButton.TabIndex = 1;
            this.mySnapsButton.Text = "My Snaps";
            this.mySnapsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mySnapsButton.UseVisualStyleBackColor = false;
            this.mySnapsButton.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // newSetterButton
            // 
            this.newSetterButton.BackColor = System.Drawing.Color.Transparent;
            this.newSetterButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.newSetterButton.FlatAppearance.BorderSize = 0;
            this.newSetterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newSetterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newSetterButton.ForeColor = System.Drawing.Color.White;
            this.newSetterButton.Location = new System.Drawing.Point(19, 204);
            this.newSetterButton.Name = "newSetterButton";
            this.newSetterButton.Size = new System.Drawing.Size(179, 23);
            this.newSetterButton.TabIndex = 37;
            this.newSetterButton.Text = "New Bounds Setter";
            this.newSetterButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.newSetterButton.UseVisualStyleBackColor = false;
            this.newSetterButton.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.BackColor = System.Drawing.Color.Transparent;
            this.positionLabel.ForeColor = System.Drawing.Color.White;
            this.positionLabel.Location = new System.Drawing.Point(447, 282);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(82, 13);
            this.positionLabel.TabIndex = 22;
            this.positionLabel.Text = "grabber position";
            this.positionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.positionLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.masterPanel_MouseDown);
            this.positionLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.masterPanel_MouseUp);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.ForeColor = System.Drawing.Color.White;
            this.statusLabel.Location = new System.Drawing.Point(35, 308);
            this.statusLabel.MaximumSize = new System.Drawing.Size(590, 45);
            this.statusLabel.MinimumSize = new System.Drawing.Size(590, 45);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(590, 45);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "status";
            this.statusLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.masterPanel_MouseDown);
            this.statusLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.masterPanel_MouseUp);
            // 
            // hotKeyLabel
            // 
            this.hotKeyLabel.AutoSize = true;
            this.hotKeyLabel.BackColor = System.Drawing.Color.Transparent;
            this.hotKeyLabel.ForeColor = System.Drawing.Color.White;
            this.hotKeyLabel.Location = new System.Drawing.Point(35, 295);
            this.hotKeyLabel.Name = "hotKeyLabel";
            this.hotKeyLabel.Size = new System.Drawing.Size(45, 13);
            this.hotKeyLabel.TabIndex = 12;
            this.hotKeyLabel.Text = "hotkey: ";
            this.hotKeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hotKeyLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.masterPanel_MouseDown);
            this.hotKeyLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.masterPanel_MouseUp);
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.BackColor = System.Drawing.Color.Transparent;
            this.pathLabel.ForeColor = System.Drawing.Color.White;
            this.pathLabel.Location = new System.Drawing.Point(35, 282);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(31, 13);
            this.pathLabel.TabIndex = 36;
            this.pathLabel.Text = "path:";
            this.pathLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.masterPanel_MouseDown);
            this.pathLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.masterPanel_MouseUp);
            // 
            // timeTakeLabel
            // 
            this.timeTakeLabel.AutoSize = true;
            this.timeTakeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeTakeLabel.ForeColor = System.Drawing.Color.White;
            this.timeTakeLabel.Location = new System.Drawing.Point(26, 352);
            this.timeTakeLabel.Name = "timeTakeLabel";
            this.timeTakeLabel.Size = new System.Drawing.Size(108, 13);
            this.timeTakeLabel.TabIndex = 29;
            this.timeTakeLabel.Text = "Auto grabber interval.";
            this.timeTakeLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.masterPanel_MouseDown);
            this.timeTakeLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.masterPanel_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Screen Grabber";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.masterPanel_MouseDown);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.masterPanel_MouseUp);
            // 
            // gradientBackgroundPainter
            // 
            this.gradientBackgroundPainter.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gradientBackgroundPainter.GlossPainter = null;
            this.gradientBackgroundPainter.TopColor = System.Drawing.Color.Gray;
            // 
            // autoGrabberProgressBarEx
            // 
            this.autoGrabberProgressBarEx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.autoGrabberProgressBarEx.BackgroundPainter = this.gradientBackgroundPainter;
            this.autoGrabberProgressBarEx.BorderPainter = this.plainBorderPainter;
            this.autoGrabberProgressBarEx.ForeColor = System.Drawing.Color.White;
            this.autoGrabberProgressBarEx.Location = new System.Drawing.Point(19, 368);
            this.autoGrabberProgressBarEx.MarqueePercentage = 25;
            this.autoGrabberProgressBarEx.MarqueeSpeed = 30;
            this.autoGrabberProgressBarEx.MarqueeStep = 1;
            this.autoGrabberProgressBarEx.Maximum = 100;
            this.autoGrabberProgressBarEx.Minimum = 0;
            this.autoGrabberProgressBarEx.Name = "autoGrabberProgressBarEx";
            this.autoGrabberProgressBarEx.ProgressPadding = 0;
            this.autoGrabberProgressBarEx.ProgressPainter = this.stripedProgressPainter;
            this.autoGrabberProgressBarEx.ProgressType = ProgressODoom.ProgressType.Smooth;
            this.autoGrabberProgressBarEx.ShowPercentage = true;
            this.autoGrabberProgressBarEx.Size = new System.Drawing.Size(610, 15);
            this.autoGrabberProgressBarEx.TabIndex = 38;
            this.autoGrabberProgressBarEx.TabStop = false;
            this.autoGrabberProgressBarEx.Value = 0;
            // 
            // plainBorderPainter
            // 
            this.plainBorderPainter.Color = System.Drawing.Color.DimGray;
            this.plainBorderPainter.RoundedCorners = true;
            this.plainBorderPainter.Style = ProgressODoom.PlainBorderPainter.PlainBorderStyle.Flat;
            // 
            // stripedProgressPainter
            // 
            this.stripedProgressPainter.Animating = false;
            this.stripedProgressPainter.AnimationSpeed = 10;
            this.stripedProgressPainter.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.stripedProgressPainter.GlossPainter = this.gradientGlossPainter;
            this.stripedProgressPainter.ProgressBorderPainter = null;
            this.stripedProgressPainter.StripeColor = System.Drawing.Color.Navy;
            this.stripedProgressPainter.StripeSpacing = 5;
            // 
            // gradientGlossPainter
            // 
            this.gradientGlossPainter.AlphaHigh = 120;
            this.gradientGlossPainter.AlphaLow = 0;
            this.gradientGlossPainter.Angle = 90F;
            this.gradientGlossPainter.Color = System.Drawing.Color.White;
            this.gradientGlossPainter.PercentageCovered = 80;
            this.gradientGlossPainter.Style = ProgressODoom.GlossStyle.Top;
            this.gradientGlossPainter.Successor = null;
            // 
            // ScreenGrabberMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(648, 404);
            this.ContextMenuStrip = this.notifyContextMenuStrip;
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeTakeLabel);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.hotKeyLabel);
            this.Controls.Add(this.newSetterButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.autoGrabberProgressBarEx);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.mySnapsButton);
            this.Controls.Add(this.timeTakeButton);
            this.Controls.Add(this.setBoundsButton);
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.shortCutButton);
            this.Controls.Add(this.takeButton);
            this.Controls.Add(this.hideButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.grabWebButton);
            this.Controls.Add(this.previewPictureBox);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.customCheckBox);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::ScreenGrabber.Properties.Settings.Default, "Location", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = global::ScreenGrabber.Properties.Settings.Default.Location;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScreenGrabberMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScreenGrabber";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScreenGrabberMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.masterPanel_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.masterPanel_MouseUp);
            this.notifyContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).EndInit();
            this.previewContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.snapsDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip notifyContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker onLoadBackgroundWorker;
        private System.Windows.Forms.ContextMenuStrip previewContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enlargeToolStripMenuItem;
        public System.Windows.Forms.ToolTip toolTip;
        public System.Windows.Forms.NotifyIcon notifyIcon;
        public System.Windows.Forms.Timer positionTimer;
        private SnapsDatabaseDataSet snapsDatabaseDataSet;
        private ScreenGrabber.SnapsDatabaseDataSetTableAdapters.AccountsTableAdapter accountsTableAdapter;
        private ScreenGrabber.SnapsDatabaseDataSetTableAdapters.SnapsTableAdapter snapsTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boundsSetterToolStripMenuItem;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button timeTakeButton;
        private System.Windows.Forms.Button setBoundsButton;
        private System.Windows.Forms.Button shortCutButton;
        private System.Windows.Forms.Button hideButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button closeButton;
        public System.Windows.Forms.PictureBox previewPictureBox;
        private System.Windows.Forms.Button takeButton;
        public System.Windows.Forms.CheckBox customCheckBox;
        public System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Button mySnapsButton;
        private System.Windows.Forms.Button newSetterButton;
        public System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.Label statusLabel;
        public System.Windows.Forms.Label hotKeyLabel;
        public System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Label timeTakeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button grabWebButton;
        private ProgressODoom.GradientBackgroundPainter gradientBackgroundPainter;
        private ProgressODoom.ProgressBarEx autoGrabberProgressBarEx;
        private ProgressODoom.PlainBorderPainter plainBorderPainter;
        private ProgressODoom.StripedProgressPainter stripedProgressPainter;
        private ProgressODoom.GradientGlossPainter gradientGlossPainter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}