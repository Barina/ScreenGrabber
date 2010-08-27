namespace ScreenGrabber
{
    partial class SettingsPage
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Date Stamp");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Global settings", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Global Key & File path");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Grabber options");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsPage));
            this.globalGroupBox = new System.Windows.Forms.GroupBox();
            this.saveSnapsCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.detailsLabel = new System.Windows.Forms.Label();
            this.closeToTrayCheckBox = new System.Windows.Forms.CheckBox();
            this.startupCheckBox = new System.Windows.Forms.CheckBox();
            this.autoCaptureCheckBox = new System.Windows.Forms.CheckBox();
            this.shortCutButton = new System.Windows.Forms.Button();
            this.minimizedCheckBox = new System.Windows.Forms.CheckBox();
            this.stickyCheckBox = new System.Windows.Forms.CheckBox();
            this.saveDateCheckBox = new System.Windows.Forms.CheckBox();
            this.autoInitiaterCheckBox = new System.Windows.Forms.CheckBox();
            this.autoSaveCheckBox = new System.Windows.Forms.CheckBox();
            this.overwriteCheckBox = new System.Windows.Forms.CheckBox();
            this.globalKeyGroupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.hotKeyLabel = new System.Windows.Forms.Label();
            this.MODComboBox = new System.Windows.Forms.ComboBox();
            this.hotKeyTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pathKeyGroupBox = new System.Windows.Forms.GroupBox();
            this.openButton = new System.Windows.Forms.Button();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sumNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.secNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.minNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.grabberGroupBox = new System.Windows.Forms.GroupBox();
            this.tryDXCheckBox = new System.Windows.Forms.CheckBox();
            this.newSetterButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.positionLabel = new System.Windows.Forms.Label();
            this.customCheckBox = new System.Windows.Forms.CheckBox();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.setBoundsButton = new System.Windows.Forms.Button();
            this.mainTreeView = new System.Windows.Forms.TreeView();
            this.masterPanel = new System.Windows.Forms.Panel();
            this.dateStampGroupBox = new System.Windows.Forms.GroupBox();
            this.colorButton = new System.Windows.Forms.Button();
            this.opacityLabel = new System.Windows.Forms.Label();
            this.fontButton = new System.Windows.Forms.Button();
            this.dateStampPreviewPictureBox = new System.Windows.Forms.PictureBox();
            this.positionGroupBox = new System.Windows.Forms.GroupBox();
            this.bottomRightRadioButton = new System.Windows.Forms.RadioButton();
            this.upRightRadioButton = new System.Windows.Forms.RadioButton();
            this.bottomLeftRadioButton = new System.Windows.Forms.RadioButton();
            this.upLeftRadioButton = new System.Windows.Forms.RadioButton();
            this.opacityTrackBar = new System.Windows.Forms.TrackBar();
            this.cancelButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.globalGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.globalKeyGroupBox.SuspendLayout();
            this.pathKeyGroupBox.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sumNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNumericUpDown)).BeginInit();
            this.grabberGroupBox.SuspendLayout();
            this.masterPanel.SuspendLayout();
            this.dateStampGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateStampPreviewPictureBox)).BeginInit();
            this.positionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opacityTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // globalGroupBox
            // 
            this.globalGroupBox.Controls.Add(this.saveSnapsCheckBox);
            this.globalGroupBox.Controls.Add(this.groupBox2);
            this.globalGroupBox.Controls.Add(this.closeToTrayCheckBox);
            this.globalGroupBox.Controls.Add(this.startupCheckBox);
            this.globalGroupBox.Controls.Add(this.autoCaptureCheckBox);
            this.globalGroupBox.Controls.Add(this.shortCutButton);
            this.globalGroupBox.Controls.Add(this.minimizedCheckBox);
            this.globalGroupBox.Controls.Add(this.stickyCheckBox);
            this.globalGroupBox.Location = new System.Drawing.Point(158, 8);
            this.globalGroupBox.Name = "globalGroupBox";
            this.globalGroupBox.Size = new System.Drawing.Size(372, 219);
            this.globalGroupBox.TabIndex = 6;
            this.globalGroupBox.TabStop = false;
            this.globalGroupBox.Text = "Global Settings";
            // 
            // saveSnapsCheckBox
            // 
            this.saveSnapsCheckBox.AutoSize = true;
            this.saveSnapsCheckBox.Checked = true;
            this.saveSnapsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saveSnapsCheckBox.Location = new System.Drawing.Point(6, 19);
            this.saveSnapsCheckBox.Name = "saveSnapsCheckBox";
            this.saveSnapsCheckBox.Size = new System.Drawing.Size(168, 17);
            this.saveSnapsCheckBox.TabIndex = 34;
            this.saveSnapsCheckBox.Text = "Save every snap to database.";
            this.saveSnapsCheckBox.UseVisualStyleBackColor = true;
            this.saveSnapsCheckBox.MouseLeave += new System.EventHandler(this.CheckBox_MouseLeave);
            this.saveSnapsCheckBox.MouseEnter += new System.EventHandler(this.CheckBox_MouseEnter);
            this.saveSnapsCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.detailsLabel);
            this.groupBox2.Location = new System.Drawing.Point(6, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 96);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.Location = new System.Drawing.Point(6, 23);
            this.detailsLabel.MaximumSize = new System.Drawing.Size(345, 0);
            this.detailsLabel.MinimumSize = new System.Drawing.Size(345, 0);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(345, 13);
            this.detailsLabel.TabIndex = 32;
            this.detailsLabel.Text = "details";
            this.detailsLabel.Visible = false;
            // 
            // closeToTrayCheckBox
            // 
            this.closeToTrayCheckBox.AutoSize = true;
            this.closeToTrayCheckBox.Location = new System.Drawing.Point(180, 65);
            this.closeToTrayCheckBox.Name = "closeToTrayCheckBox";
            this.closeToTrayCheckBox.Size = new System.Drawing.Size(164, 17);
            this.closeToTrayCheckBox.TabIndex = 20;
            this.closeToTrayCheckBox.Text = "Close minimize to system tray.";
            this.closeToTrayCheckBox.UseVisualStyleBackColor = true;
            this.closeToTrayCheckBox.MouseLeave += new System.EventHandler(this.CheckBox_MouseLeave);
            this.closeToTrayCheckBox.MouseEnter += new System.EventHandler(this.CheckBox_MouseEnter);
            this.closeToTrayCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // startupCheckBox
            // 
            this.startupCheckBox.AutoSize = true;
            this.startupCheckBox.Location = new System.Drawing.Point(180, 19);
            this.startupCheckBox.Name = "startupCheckBox";
            this.startupCheckBox.Size = new System.Drawing.Size(100, 17);
            this.startupCheckBox.TabIndex = 19;
            this.startupCheckBox.Text = "Run at StartUp.";
            this.startupCheckBox.UseVisualStyleBackColor = true;
            this.startupCheckBox.MouseLeave += new System.EventHandler(this.CheckBox_MouseLeave);
            this.startupCheckBox.MouseEnter += new System.EventHandler(this.CheckBox_MouseEnter);
            this.startupCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // autoCaptureCheckBox
            // 
            this.autoCaptureCheckBox.AutoSize = true;
            this.autoCaptureCheckBox.Location = new System.Drawing.Point(6, 42);
            this.autoCaptureCheckBox.Name = "autoCaptureCheckBox";
            this.autoCaptureCheckBox.Size = new System.Drawing.Size(90, 17);
            this.autoCaptureCheckBox.TabIndex = 15;
            this.autoCaptureCheckBox.Text = "Auto capture.";
            this.autoCaptureCheckBox.UseVisualStyleBackColor = true;
            this.autoCaptureCheckBox.MouseLeave += new System.EventHandler(this.CheckBox_MouseLeave);
            this.autoCaptureCheckBox.MouseEnter += new System.EventHandler(this.CheckBox_MouseEnter);
            this.autoCaptureCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // shortCutButton
            // 
            this.shortCutButton.Location = new System.Drawing.Point(6, 88);
            this.shortCutButton.Name = "shortCutButton";
            this.shortCutButton.Size = new System.Drawing.Size(112, 23);
            this.shortCutButton.TabIndex = 31;
            this.shortCutButton.Text = "Mannage Shortcuts";
            this.shortCutButton.UseVisualStyleBackColor = true;
            this.shortCutButton.MouseLeave += new System.EventHandler(this.CheckBox_MouseLeave);
            this.shortCutButton.Click += new System.EventHandler(this.shortCutButton_Click);
            this.shortCutButton.MouseEnter += new System.EventHandler(this.CheckBox_MouseEnter);
            // 
            // minimizedCheckBox
            // 
            this.minimizedCheckBox.AutoSize = true;
            this.minimizedCheckBox.Location = new System.Drawing.Point(180, 42);
            this.minimizedCheckBox.Name = "minimizedCheckBox";
            this.minimizedCheckBox.Size = new System.Drawing.Size(99, 17);
            this.minimizedCheckBox.TabIndex = 16;
            this.minimizedCheckBox.Text = "Start minimized.";
            this.minimizedCheckBox.UseVisualStyleBackColor = true;
            this.minimizedCheckBox.MouseLeave += new System.EventHandler(this.CheckBox_MouseLeave);
            this.minimizedCheckBox.MouseEnter += new System.EventHandler(this.CheckBox_MouseEnter);
            this.minimizedCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // stickyCheckBox
            // 
            this.stickyCheckBox.AutoSize = true;
            this.stickyCheckBox.Checked = true;
            this.stickyCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.stickyCheckBox.Location = new System.Drawing.Point(6, 65);
            this.stickyCheckBox.Name = "stickyCheckBox";
            this.stickyCheckBox.Size = new System.Drawing.Size(97, 17);
            this.stickyCheckBox.TabIndex = 18;
            this.stickyCheckBox.Text = "Stick to edges.";
            this.stickyCheckBox.UseVisualStyleBackColor = true;
            this.stickyCheckBox.MouseLeave += new System.EventHandler(this.CheckBox_MouseLeave);
            this.stickyCheckBox.MouseEnter += new System.EventHandler(this.CheckBox_MouseEnter);
            this.stickyCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // saveDateCheckBox
            // 
            this.saveDateCheckBox.AutoSize = true;
            this.saveDateCheckBox.Location = new System.Drawing.Point(6, 19);
            this.saveDateCheckBox.Name = "saveDateCheckBox";
            this.saveDateCheckBox.Size = new System.Drawing.Size(124, 17);
            this.saveDateCheckBox.TabIndex = 35;
            this.saveDateCheckBox.Text = "Draw date on image.";
            this.saveDateCheckBox.UseVisualStyleBackColor = true;
            this.saveDateCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // autoInitiaterCheckBox
            // 
            this.autoInitiaterCheckBox.AutoSize = true;
            this.autoInitiaterCheckBox.Location = new System.Drawing.Point(6, 19);
            this.autoInitiaterCheckBox.Name = "autoInitiaterCheckBox";
            this.autoInitiaterCheckBox.Size = new System.Drawing.Size(173, 17);
            this.autoInitiaterCheckBox.TabIndex = 30;
            this.autoInitiaterCheckBox.Text = "Initiate auto grabber on startup.";
            this.autoInitiaterCheckBox.UseVisualStyleBackColor = true;
            this.autoInitiaterCheckBox.MouseLeave += new System.EventHandler(this.CheckBox_MouseLeave);
            this.autoInitiaterCheckBox.MouseEnter += new System.EventHandler(this.CheckBox_MouseEnter);
            this.autoInitiaterCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // autoSaveCheckBox
            // 
            this.autoSaveCheckBox.AutoSize = true;
            this.autoSaveCheckBox.Checked = true;
            this.autoSaveCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoSaveCheckBox.Location = new System.Drawing.Point(9, 59);
            this.autoSaveCheckBox.Name = "autoSaveCheckBox";
            this.autoSaveCheckBox.Size = new System.Drawing.Size(346, 17);
            this.autoSaveCheckBox.TabIndex = 14;
            this.autoSaveCheckBox.Text = "When using Global Hot-Key save the snap automatically to the disc.";
            this.autoSaveCheckBox.UseVisualStyleBackColor = true;
            this.autoSaveCheckBox.MouseLeave += new System.EventHandler(this.CheckBox_MouseLeave);
            this.autoSaveCheckBox.MouseEnter += new System.EventHandler(this.CheckBox_MouseEnter);
            this.autoSaveCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // overwriteCheckBox
            // 
            this.overwriteCheckBox.AutoSize = true;
            this.overwriteCheckBox.Location = new System.Drawing.Point(9, 82);
            this.overwriteCheckBox.Name = "overwriteCheckBox";
            this.overwriteCheckBox.Size = new System.Drawing.Size(127, 17);
            this.overwriteCheckBox.TabIndex = 17;
            this.overwriteCheckBox.Text = "Overwrite if file exists.";
            this.overwriteCheckBox.UseVisualStyleBackColor = true;
            this.overwriteCheckBox.MouseLeave += new System.EventHandler(this.CheckBox_MouseLeave);
            this.overwriteCheckBox.MouseEnter += new System.EventHandler(this.CheckBox_MouseEnter);
            this.overwriteCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // globalKeyGroupBox
            // 
            this.globalKeyGroupBox.Controls.Add(this.label5);
            this.globalKeyGroupBox.Controls.Add(this.hotKeyLabel);
            this.globalKeyGroupBox.Controls.Add(this.MODComboBox);
            this.globalKeyGroupBox.Controls.Add(this.hotKeyTextBox);
            this.globalKeyGroupBox.Controls.Add(this.label3);
            this.globalKeyGroupBox.Controls.Add(this.pathKeyGroupBox);
            this.globalKeyGroupBox.Controls.Add(this.autoSaveCheckBox);
            this.globalKeyGroupBox.Controls.Add(this.overwriteCheckBox);
            this.globalKeyGroupBox.Location = new System.Drawing.Point(386, 262);
            this.globalKeyGroupBox.Name = "globalKeyGroupBox";
            this.globalKeyGroupBox.Size = new System.Drawing.Size(372, 219);
            this.globalKeyGroupBox.TabIndex = 32;
            this.globalKeyGroupBox.TabStop = false;
            this.globalKeyGroupBox.Text = "Global HotKey";
            this.globalKeyGroupBox.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 102);
            this.label5.MaximumSize = new System.Drawing.Size(320, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(309, 26);
            this.label5.TabIndex = 36;
            this.label5.Text = "Using this HotKey outside of the program anywhere you want to snap your screen.";
            // 
            // hotKeyLabel
            // 
            this.hotKeyLabel.AutoSize = true;
            this.hotKeyLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.hotKeyLabel.Location = new System.Drawing.Point(6, 43);
            this.hotKeyLabel.Name = "hotKeyLabel";
            this.hotKeyLabel.Size = new System.Drawing.Size(39, 13);
            this.hotKeyLabel.TabIndex = 12;
            this.hotKeyLabel.Text = "hotkey";
            this.hotKeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hotKeyLabel.Visible = false;
            // 
            // MODComboBox
            // 
            this.MODComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MODComboBox.FormattingEnabled = true;
            this.MODComboBox.Items.AddRange(new object[] {
            "Alt",
            "Control",
            "Shift"});
            this.MODComboBox.Location = new System.Drawing.Point(6, 19);
            this.MODComboBox.Name = "MODComboBox";
            this.MODComboBox.Size = new System.Drawing.Size(83, 21);
            this.MODComboBox.TabIndex = 20;
            this.MODComboBox.SelectedIndexChanged += new System.EventHandler(this.hotKeyTextBox_TextChanged);
            // 
            // hotKeyTextBox
            // 
            this.hotKeyTextBox.Location = new System.Drawing.Point(114, 19);
            this.hotKeyTextBox.Name = "hotKeyTextBox";
            this.hotKeyTextBox.Size = new System.Drawing.Size(48, 20);
            this.hotKeyTextBox.TabIndex = 21;
            this.hotKeyTextBox.TextChanged += new System.EventHandler(this.hotKeyTextBox_TextChanged);
            this.hotKeyTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hotKeyTextBox_KeyDown);
            this.hotKeyTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.hotKeyTextBox_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "+";
            // 
            // pathKeyGroupBox
            // 
            this.pathKeyGroupBox.Controls.Add(this.openButton);
            this.pathKeyGroupBox.Controls.Add(this.pathTextBox);
            this.pathKeyGroupBox.Controls.Add(this.browseButton);
            this.pathKeyGroupBox.Location = new System.Drawing.Point(9, 136);
            this.pathKeyGroupBox.Name = "pathKeyGroupBox";
            this.pathKeyGroupBox.Size = new System.Drawing.Size(357, 77);
            this.pathKeyGroupBox.TabIndex = 33;
            this.pathKeyGroupBox.TabStop = false;
            this.pathKeyGroupBox.Text = "Save path:";
            // 
            // openButton
            // 
            this.openButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openButton.Location = new System.Drawing.Point(276, 43);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 13;
            this.openButton.Text = "Open Folder";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // pathTextBox
            // 
            this.pathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pathTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.pathTextBox.Location = new System.Drawing.Point(6, 19);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(345, 20);
            this.pathTextBox.TabIndex = 11;
            // 
            // browseButton
            // 
            this.browseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseButton.Location = new System.Drawing.Point(195, 43);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 12;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.autoInitiaterCheckBox);
            this.groupBox5.Controls.Add(this.sumNumericUpDown);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.secNumericUpDown);
            this.groupBox5.Controls.Add(this.minNumericUpDown);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(6, 94);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(360, 119);
            this.groupBox5.TabIndex = 34;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Auto Grabber";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 89);
            this.label2.MaximumSize = new System.Drawing.Size(320, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 26);
            this.label2.TabIndex = 30;
            this.label2.Text = "When clicking on \'Initiate Auto Grabber\' button it will thake snaps every period " +
                "of time you choose.";
            // 
            // sumNumericUpDown
            // 
            this.sumNumericUpDown.Location = new System.Drawing.Point(54, 63);
            this.sumNumericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.sumNumericUpDown.Name = "sumNumericUpDown";
            this.sumNumericUpDown.Size = new System.Drawing.Size(45, 20);
            this.sumNumericUpDown.TabIndex = 5;
            this.sumNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sumNumericUpDown.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Do that:                  Times. (0 = unlimited)";
            // 
            // secNumericUpDown
            // 
            this.secNumericUpDown.Location = new System.Drawing.Point(148, 37);
            this.secNumericUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.secNumericUpDown.Name = "secNumericUpDown";
            this.secNumericUpDown.Size = new System.Drawing.Size(33, 20);
            this.secNumericUpDown.TabIndex = 4;
            this.secNumericUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.secNumericUpDown.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // minNumericUpDown
            // 
            this.minNumericUpDown.Location = new System.Drawing.Point(87, 37);
            this.minNumericUpDown.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.minNumericUpDown.Name = "minNumericUpDown";
            this.minNumericUpDown.Size = new System.Drawing.Size(33, 20);
            this.minNumericUpDown.TabIndex = 3;
            this.minNumericUpDown.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Take picture in:              Min               Sec.";
            // 
            // grabberGroupBox
            // 
            this.grabberGroupBox.Controls.Add(this.tryDXCheckBox);
            this.grabberGroupBox.Controls.Add(this.newSetterButton);
            this.grabberGroupBox.Controls.Add(this.resetButton);
            this.grabberGroupBox.Controls.Add(this.positionLabel);
            this.grabberGroupBox.Controls.Add(this.customCheckBox);
            this.grabberGroupBox.Controls.Add(this.sizeLabel);
            this.grabberGroupBox.Controls.Add(this.groupBox5);
            this.grabberGroupBox.Controls.Add(this.setBoundsButton);
            this.grabberGroupBox.Location = new System.Drawing.Point(8, 262);
            this.grabberGroupBox.Name = "grabberGroupBox";
            this.grabberGroupBox.Size = new System.Drawing.Size(372, 219);
            this.grabberGroupBox.TabIndex = 35;
            this.grabberGroupBox.TabStop = false;
            this.grabberGroupBox.Text = "Grabber";
            this.grabberGroupBox.Visible = false;
            // 
            // tryDXCheckBox
            // 
            this.tryDXCheckBox.AutoSize = true;
            this.tryDXCheckBox.Location = new System.Drawing.Point(104, 45);
            this.tryDXCheckBox.Name = "tryDXCheckBox";
            this.tryDXCheckBox.Size = new System.Drawing.Size(129, 17);
            this.tryDXCheckBox.TabIndex = 37;
            this.tryDXCheckBox.Text = "Try using DirectX first.";
            this.toolTip.SetToolTip(this.tryDXCheckBox, "ATTENTION!: Will try to snap a DirectX game with default values. if failed will t" +
                    "ake a normal grab screen with user parameters. Not recomended. May also work on " +
                    "desktop. May retrieve black snaps.");
            this.tryDXCheckBox.UseVisualStyleBackColor = true;
            // 
            // newSetterButton
            // 
            this.newSetterButton.Location = new System.Drawing.Point(97, 68);
            this.newSetterButton.Name = "newSetterButton";
            this.newSetterButton.Size = new System.Drawing.Size(82, 20);
            this.newSetterButton.TabIndex = 36;
            this.newSetterButton.Text = "Bounds setter";
            this.toolTip.SetToolTip(this.newSetterButton, "The new bounds setter. ATTENTION: changes will automatically saved when you click" +
                    " OK.");
            this.newSetterButton.UseVisualStyleBackColor = true;
            this.newSetterButton.Click += new System.EventHandler(this.newSetterButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(185, 68);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(82, 20);
            this.resetButton.TabIndex = 35;
            this.resetButton.Text = "Reset";
            this.toolTip.SetToolTip(this.resetButton, "Will reset the ScreenGrabber custom bounds to defaults.");
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Location = new System.Drawing.Point(6, 16);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(82, 13);
            this.positionLabel.TabIndex = 22;
            this.positionLabel.Text = "grabber position";
            // 
            // customCheckBox
            // 
            this.customCheckBox.AutoSize = true;
            this.customCheckBox.Location = new System.Drawing.Point(9, 45);
            this.customCheckBox.Name = "customCheckBox";
            this.customCheckBox.Size = new System.Drawing.Size(89, 17);
            this.customCheckBox.TabIndex = 1;
            this.customCheckBox.Text = "Use Grabber.";
            this.customCheckBox.UseVisualStyleBackColor = true;
            this.customCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(6, 29);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(64, 13);
            this.sizeLabel.TabIndex = 23;
            this.sizeLabel.Text = "grabber size";
            // 
            // setBoundsButton
            // 
            this.setBoundsButton.Location = new System.Drawing.Point(9, 68);
            this.setBoundsButton.Name = "setBoundsButton";
            this.setBoundsButton.Size = new System.Drawing.Size(82, 20);
            this.setBoundsButton.TabIndex = 2;
            this.setBoundsButton.Text = "Set Bounds";
            this.toolTip.SetToolTip(this.setBoundsButton, "Old bounds setter.");
            this.setBoundsButton.UseVisualStyleBackColor = true;
            this.setBoundsButton.Click += new System.EventHandler(this.setBoundsButton_Click);
            // 
            // mainTreeView
            // 
            this.mainTreeView.BackColor = System.Drawing.SystemColors.Window;
            this.mainTreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainTreeView.ForeColor = System.Drawing.Color.Black;
            this.mainTreeView.Location = new System.Drawing.Point(8, 8);
            this.mainTreeView.Name = "mainTreeView";
            treeNode1.Name = "DateStampNode";
            treeNode1.Text = "Date Stamp";
            treeNode1.ToolTipText = "Edit date stamp shown on images.";
            treeNode2.Checked = true;
            treeNode2.Name = "GlobalNode";
            treeNode2.Text = "Global settings";
            treeNode3.Name = "KeyNode";
            treeNode3.Text = "Global Key & File path";
            treeNode4.Name = "GrabberNode";
            treeNode4.Text = "Grabber options";
            this.mainTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4});
            this.mainTreeView.Size = new System.Drawing.Size(144, 219);
            this.mainTreeView.TabIndex = 22;
            this.mainTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.mainTreeView_AfterSelect);
            // 
            // masterPanel
            // 
            this.masterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.masterPanel.BackColor = System.Drawing.SystemColors.Control;
            this.masterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.masterPanel.Controls.Add(this.dateStampGroupBox);
            this.masterPanel.Controls.Add(this.cancelButton);
            this.masterPanel.Controls.Add(this.applyButton);
            this.masterPanel.Controls.Add(this.saveButton);
            this.masterPanel.Controls.Add(this.mainTreeView);
            this.masterPanel.Controls.Add(this.globalKeyGroupBox);
            this.masterPanel.Controls.Add(this.globalGroupBox);
            this.masterPanel.Controls.Add(this.grabberGroupBox);
            this.masterPanel.Location = new System.Drawing.Point(4, 4);
            this.masterPanel.Name = "masterPanel";
            this.masterPanel.Size = new System.Drawing.Size(941, 488);
            this.masterPanel.TabIndex = 36;
            // 
            // dateStampGroupBox
            // 
            this.dateStampGroupBox.Controls.Add(this.colorButton);
            this.dateStampGroupBox.Controls.Add(this.opacityLabel);
            this.dateStampGroupBox.Controls.Add(this.fontButton);
            this.dateStampGroupBox.Controls.Add(this.dateStampPreviewPictureBox);
            this.dateStampGroupBox.Controls.Add(this.positionGroupBox);
            this.dateStampGroupBox.Controls.Add(this.saveDateCheckBox);
            this.dateStampGroupBox.Controls.Add(this.opacityTrackBar);
            this.dateStampGroupBox.Location = new System.Drawing.Point(557, 8);
            this.dateStampGroupBox.Name = "dateStampGroupBox";
            this.dateStampGroupBox.Size = new System.Drawing.Size(372, 219);
            this.dateStampGroupBox.TabIndex = 38;
            this.dateStampGroupBox.TabStop = false;
            this.dateStampGroupBox.Text = "Date Stamp";
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(90, 42);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(75, 23);
            this.colorButton.TabIndex = 37;
            this.colorButton.Text = "Bg color";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // opacityLabel
            // 
            this.opacityLabel.AutoSize = true;
            this.opacityLabel.Location = new System.Drawing.Point(6, 75);
            this.opacityLabel.Name = "opacityLabel";
            this.opacityLabel.Size = new System.Drawing.Size(105, 13);
            this.opacityLabel.TabIndex = 44;
            this.opacityLabel.Text = "Background opacity:";
            // 
            // fontButton
            // 
            this.fontButton.Location = new System.Drawing.Point(6, 42);
            this.fontButton.Name = "fontButton";
            this.fontButton.Size = new System.Drawing.Size(75, 23);
            this.fontButton.TabIndex = 41;
            this.fontButton.Text = "Font";
            this.fontButton.UseVisualStyleBackColor = true;
            this.fontButton.Click += new System.EventHandler(this.fontButton_Click);
            // 
            // dateStampPreviewPictureBox
            // 
            this.dateStampPreviewPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateStampPreviewPictureBox.Image = global::ScreenGrabber.Properties.Resources.dateStampPreviewBox;
            this.dateStampPreviewPictureBox.Location = new System.Drawing.Point(6, 117);
            this.dateStampPreviewPictureBox.Name = "dateStampPreviewPictureBox";
            this.dateStampPreviewPictureBox.Size = new System.Drawing.Size(360, 96);
            this.dateStampPreviewPictureBox.TabIndex = 42;
            this.dateStampPreviewPictureBox.TabStop = false;
            // 
            // positionGroupBox
            // 
            this.positionGroupBox.Controls.Add(this.bottomRightRadioButton);
            this.positionGroupBox.Controls.Add(this.upRightRadioButton);
            this.positionGroupBox.Controls.Add(this.bottomLeftRadioButton);
            this.positionGroupBox.Controls.Add(this.upLeftRadioButton);
            this.positionGroupBox.Location = new System.Drawing.Point(181, 19);
            this.positionGroupBox.Name = "positionGroupBox";
            this.positionGroupBox.Size = new System.Drawing.Size(185, 69);
            this.positionGroupBox.TabIndex = 40;
            this.positionGroupBox.TabStop = false;
            this.positionGroupBox.Text = "Position";
            // 
            // bottomRightRadioButton
            // 
            this.bottomRightRadioButton.AutoSize = true;
            this.bottomRightRadioButton.Location = new System.Drawing.Point(97, 42);
            this.bottomRightRadioButton.Name = "bottomRightRadioButton";
            this.bottomRightRadioButton.Size = new System.Drawing.Size(81, 17);
            this.bottomRightRadioButton.TabIndex = 42;
            this.bottomRightRadioButton.TabStop = true;
            this.bottomRightRadioButton.Text = "Bottom right";
            this.bottomRightRadioButton.UseVisualStyleBackColor = true;
            this.bottomRightRadioButton.CheckedChanged += new System.EventHandler(this.positionRadioButton_CheckedChanged);
            // 
            // upRightRadioButton
            // 
            this.upRightRadioButton.AutoSize = true;
            this.upRightRadioButton.Location = new System.Drawing.Point(97, 19);
            this.upRightRadioButton.Name = "upRightRadioButton";
            this.upRightRadioButton.Size = new System.Drawing.Size(77, 17);
            this.upRightRadioButton.TabIndex = 41;
            this.upRightRadioButton.TabStop = true;
            this.upRightRadioButton.Text = "Upper right";
            this.upRightRadioButton.UseVisualStyleBackColor = true;
            this.upRightRadioButton.CheckedChanged += new System.EventHandler(this.positionRadioButton_CheckedChanged);
            // 
            // bottomLeftRadioButton
            // 
            this.bottomLeftRadioButton.AutoSize = true;
            this.bottomLeftRadioButton.Location = new System.Drawing.Point(6, 42);
            this.bottomLeftRadioButton.Name = "bottomLeftRadioButton";
            this.bottomLeftRadioButton.Size = new System.Drawing.Size(75, 17);
            this.bottomLeftRadioButton.TabIndex = 40;
            this.bottomLeftRadioButton.TabStop = true;
            this.bottomLeftRadioButton.Text = "Bottom left";
            this.bottomLeftRadioButton.UseVisualStyleBackColor = true;
            this.bottomLeftRadioButton.CheckedChanged += new System.EventHandler(this.positionRadioButton_CheckedChanged);
            // 
            // upLeftRadioButton
            // 
            this.upLeftRadioButton.AutoSize = true;
            this.upLeftRadioButton.Location = new System.Drawing.Point(6, 19);
            this.upLeftRadioButton.Name = "upLeftRadioButton";
            this.upLeftRadioButton.Size = new System.Drawing.Size(71, 17);
            this.upLeftRadioButton.TabIndex = 39;
            this.upLeftRadioButton.TabStop = true;
            this.upLeftRadioButton.Text = "Upper left";
            this.upLeftRadioButton.UseVisualStyleBackColor = true;
            this.upLeftRadioButton.CheckedChanged += new System.EventHandler(this.positionRadioButton_CheckedChanged);
            // 
            // opacityTrackBar
            // 
            this.opacityTrackBar.Location = new System.Drawing.Point(6, 88);
            this.opacityTrackBar.Maximum = 255;
            this.opacityTrackBar.Name = "opacityTrackBar";
            this.opacityTrackBar.Size = new System.Drawing.Size(360, 45);
            this.opacityTrackBar.TabIndex = 37;
            this.opacityTrackBar.Value = 75;
            this.opacityTrackBar.Scroll += new System.EventHandler(this.opacityTrackBar_Scroll);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(8, 233);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 37;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Enabled = false;
            this.applyButton.Location = new System.Drawing.Point(374, 233);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 36;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveButton.Location = new System.Drawing.Point(455, 233);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 30;
            this.saveButton.Text = "OK";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "png";
            this.saveFileDialog.FileName = "Screen";
            this.saveFileDialog.Filter = "Bitmap Files(*.bmp)|*.bmp|JPEG Files(*.jpeg)|*.jpeg|JPG Files(*.jpg)|*.jpg|PNG Fi" +
                "les(*.png)|*.png";
            this.saveFileDialog.Title = "Choose where to save your Files.";
            // 
            // fontDialog
            // 
            this.fontDialog.ShowColor = true;
            // 
            // SettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(949, 496);
            this.Controls.Add(this.masterPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsPage";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsPage_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ScreenGrabberSettings_FormClosed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScreenGrabberSettings_FormClosing);
            this.globalGroupBox.ResumeLayout(false);
            this.globalGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.globalKeyGroupBox.ResumeLayout(false);
            this.globalKeyGroupBox.PerformLayout();
            this.pathKeyGroupBox.ResumeLayout(false);
            this.pathKeyGroupBox.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sumNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNumericUpDown)).EndInit();
            this.grabberGroupBox.ResumeLayout(false);
            this.grabberGroupBox.PerformLayout();
            this.masterPanel.ResumeLayout(false);
            this.dateStampGroupBox.ResumeLayout(false);
            this.dateStampGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateStampPreviewPictureBox)).EndInit();
            this.positionGroupBox.ResumeLayout(false);
            this.positionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opacityTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox globalGroupBox;
        private System.Windows.Forms.CheckBox closeToTrayCheckBox;
        private System.Windows.Forms.CheckBox autoSaveCheckBox;
        private System.Windows.Forms.CheckBox startupCheckBox;
        private System.Windows.Forms.CheckBox autoCaptureCheckBox;
        private System.Windows.Forms.CheckBox minimizedCheckBox;
        private System.Windows.Forms.CheckBox stickyCheckBox;
        public System.Windows.Forms.CheckBox overwriteCheckBox;
        private System.Windows.Forms.Button shortCutButton;
        private System.Windows.Forms.GroupBox globalKeyGroupBox;
        private System.Windows.Forms.Label hotKeyLabel;
        private System.Windows.Forms.ComboBox MODComboBox;
        private System.Windows.Forms.TextBox hotKeyTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox pathKeyGroupBox;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox autoInitiaterCheckBox;
        private System.Windows.Forms.NumericUpDown sumNumericUpDown;
        private System.Windows.Forms.NumericUpDown minNumericUpDown;
        private System.Windows.Forms.NumericUpDown secNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grabberGroupBox;
        public System.Windows.Forms.Label positionLabel;
        public System.Windows.Forms.CheckBox customCheckBox;
        public System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Button setBoundsButton;
        private System.Windows.Forms.TreeView mainTreeView;
        private System.Windows.Forms.Panel masterPanel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label detailsLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox saveSnapsCheckBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button newSetterButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.CheckBox saveDateCheckBox;
        private System.Windows.Forms.GroupBox dateStampGroupBox;
        private System.Windows.Forms.GroupBox positionGroupBox;
        private System.Windows.Forms.RadioButton bottomRightRadioButton;
        private System.Windows.Forms.RadioButton upRightRadioButton;
        private System.Windows.Forms.RadioButton bottomLeftRadioButton;
        private System.Windows.Forms.RadioButton upLeftRadioButton;
        private System.Windows.Forms.Button fontButton;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.PictureBox dateStampPreviewPictureBox;
        private System.Windows.Forms.Label opacityLabel;
        private System.Windows.Forms.TrackBar opacityTrackBar;
        private System.Windows.Forms.CheckBox tryDXCheckBox;
    }
}