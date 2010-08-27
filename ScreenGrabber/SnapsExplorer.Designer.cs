namespace ScreenGrabber
{
    partial class SnapsExplorer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SnapsExplorer));
            this.snapsDataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snapDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.columnsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.madeByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.snapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.verticalViewPreviewBoxOnTheSideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.snapsDatabaseDataSet = new ScreenGrabber.SnapsDatabaseDataSet();
            this.rowsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveToDiscToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllToDiscToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteFromDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enlargeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewPictureBox = new System.Windows.Forms.PictureBox();
            this.previewContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveToDiscPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteFromDBPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.enlargePreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.snapDeletionBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.snapSavingBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.savingAllBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.openPreviewBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.messageToolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.messageToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.snapsCounterToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.accountNameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.accountToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSaveSnap = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSaveAllSnaps = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteSnap = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteAllSnaps = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorRefresh = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPreview = new System.Windows.Forms.ToolStripButton();
            this.closeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.viewSplitContainer = new System.Windows.Forms.SplitContainer();
            this.accountsTableAdapter = new ScreenGrabber.SnapsDatabaseDataSetTableAdapters.AccountsTableAdapter();
            this.snapsTableAdapter = new ScreenGrabber.SnapsDatabaseDataSetTableAdapters.SnapsTableAdapter();
            this.fullTableTableAdapter = new ScreenGrabber.SnapsDatabaseDataSetTableAdapters.FullTableTableAdapter();
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.snapsDataGridView)).BeginInit();
            this.columnsContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fullTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snapsDatabaseDataSet)).BeginInit();
            this.rowsContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).BeginInit();
            this.previewContextMenuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            this.bindingNavigator.SuspendLayout();
            this.viewSplitContainer.Panel1.SuspendLayout();
            this.viewSplitContainer.Panel2.SuspendLayout();
            this.viewSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // snapsDataGridView
            // 
            this.snapsDataGridView.AllowUserToAddRows = false;
            this.snapsDataGridView.AllowUserToDeleteRows = false;
            this.snapsDataGridView.AllowUserToOrderColumns = true;
            this.snapsDataGridView.AutoGenerateColumns = false;
            this.snapsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.snapsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.snapsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.snapsDataGridView.ColumnHeadersHeight = 21;
            this.snapsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.snapsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.ownerIDDataGridViewTextBoxColumn,
            this.accountIDDataGridViewTextBoxColumn,
            this.accountNameDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.snapDataGridViewImageColumn});
            this.snapsDataGridView.ContextMenuStrip = this.columnsContextMenuStrip;
            this.snapsDataGridView.DataSource = this.fullTableBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.snapsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.snapsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.snapsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.snapsDataGridView.Name = "snapsDataGridView";
            this.snapsDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.snapsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.snapsDataGridView.RowHeadersWidth = 21;
            this.snapsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.snapsDataGridView.RowTemplate.ContextMenuStrip = this.rowsContextMenuStrip;
            this.snapsDataGridView.RowTemplate.Height = 180;
            this.snapsDataGridView.RowTemplate.ReadOnly = true;
            this.snapsDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.snapsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.snapsDataGridView.Size = new System.Drawing.Size(740, 260);
            this.snapsDataGridView.TabIndex = 6;
            this.snapsDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.snapsDataGridView_CellMouseDoubleClick);
            this.snapsDataGridView.SelectionChanged += new System.EventHandler(this.snapsDataGridView_SelectionChanged);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.FillWeight = 5.868913F;
            this.iDDataGridViewTextBoxColumn.HeaderText = "Snap ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ownerIDDataGridViewTextBoxColumn
            // 
            this.ownerIDDataGridViewTextBoxColumn.DataPropertyName = "OwnerID";
            this.ownerIDDataGridViewTextBoxColumn.HeaderText = "OwnerID";
            this.ownerIDDataGridViewTextBoxColumn.Name = "ownerIDDataGridViewTextBoxColumn";
            this.ownerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ownerIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // accountIDDataGridViewTextBoxColumn
            // 
            this.accountIDDataGridViewTextBoxColumn.DataPropertyName = "AccountID";
            this.accountIDDataGridViewTextBoxColumn.HeaderText = "AccountID";
            this.accountIDDataGridViewTextBoxColumn.Name = "accountIDDataGridViewTextBoxColumn";
            this.accountIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.accountIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // accountNameDataGridViewTextBoxColumn
            // 
            this.accountNameDataGridViewTextBoxColumn.DataPropertyName = "AccountName";
            this.accountNameDataGridViewTextBoxColumn.FillWeight = 7.27464F;
            this.accountNameDataGridViewTextBoxColumn.HeaderText = "Made By";
            this.accountNameDataGridViewTextBoxColumn.Name = "accountNameDataGridViewTextBoxColumn";
            this.accountNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DateTime";
            this.dataGridViewTextBoxColumn1.FillWeight = 17.3133F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Date";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // snapDataGridViewImageColumn
            // 
            this.snapDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.snapDataGridViewImageColumn.DataPropertyName = "Snap";
            this.snapDataGridViewImageColumn.FillWeight = 369.5432F;
            this.snapDataGridViewImageColumn.HeaderText = "Snap";
            this.snapDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.snapDataGridViewImageColumn.Name = "snapDataGridViewImageColumn";
            this.snapDataGridViewImageColumn.ReadOnly = true;
            this.snapDataGridViewImageColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.snapDataGridViewImageColumn.Width = 240;
            // 
            // columnsContextMenuStrip
            // 
            this.columnsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.madeByToolStripMenuItem,
            this.dateToolStripMenuItem,
            this.snapToolStripMenuItem,
            this.toolStripSeparator6,
            this.verticalViewPreviewBoxOnTheSideToolStripMenuItem});
            this.columnsContextMenuStrip.Name = "columnsContextMenuStrip";
            this.columnsContextMenuStrip.Size = new System.Drawing.Size(277, 98);
            // 
            // madeByToolStripMenuItem
            // 
            this.madeByToolStripMenuItem.Checked = true;
            this.madeByToolStripMenuItem.CheckOnClick = true;
            this.madeByToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.madeByToolStripMenuItem.Name = "madeByToolStripMenuItem";
            this.madeByToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.madeByToolStripMenuItem.Text = "Made By";
            this.madeByToolStripMenuItem.CheckedChanged += new System.EventHandler(this.snapIDToolStripMenuItem_CheckedChanged);
            // 
            // dateToolStripMenuItem
            // 
            this.dateToolStripMenuItem.Checked = true;
            this.dateToolStripMenuItem.CheckOnClick = true;
            this.dateToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dateToolStripMenuItem.Name = "dateToolStripMenuItem";
            this.dateToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.dateToolStripMenuItem.Text = "Date";
            this.dateToolStripMenuItem.CheckedChanged += new System.EventHandler(this.snapIDToolStripMenuItem_CheckedChanged);
            // 
            // snapToolStripMenuItem
            // 
            this.snapToolStripMenuItem.Checked = true;
            this.snapToolStripMenuItem.CheckOnClick = true;
            this.snapToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.snapToolStripMenuItem.Name = "snapToolStripMenuItem";
            this.snapToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.snapToolStripMenuItem.Text = "Snap (Not recomended)";
            this.snapToolStripMenuItem.CheckedChanged += new System.EventHandler(this.snapIDToolStripMenuItem_CheckedChanged);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(273, 6);
            // 
            // verticalViewPreviewBoxOnTheSideToolStripMenuItem
            // 
            this.verticalViewPreviewBoxOnTheSideToolStripMenuItem.CheckOnClick = true;
            this.verticalViewPreviewBoxOnTheSideToolStripMenuItem.Name = "verticalViewPreviewBoxOnTheSideToolStripMenuItem";
            this.verticalViewPreviewBoxOnTheSideToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.verticalViewPreviewBoxOnTheSideToolStripMenuItem.Text = "Vertical View (Preview box on the side)";
            this.verticalViewPreviewBoxOnTheSideToolStripMenuItem.CheckedChanged += new System.EventHandler(this.snapIDToolStripMenuItem_CheckedChanged);
            // 
            // fullTableBindingSource
            // 
            this.fullTableBindingSource.DataMember = "FullTable";
            this.fullTableBindingSource.DataSource = this.snapsDatabaseDataSet;
            this.fullTableBindingSource.Filter = "";
            // 
            // snapsDatabaseDataSet
            // 
            this.snapsDatabaseDataSet.DataSetName = "SnapsDatabaseDataSet";
            this.snapsDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rowsContextMenuStrip
            // 
            this.rowsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToDiscToolStripMenuItem,
            this.saveAllToDiscToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteFromDatabaseToolStripMenuItem,
            this.deleteAllToolStripMenuItem,
            this.toolStripSeparator2,
            this.refreshToolStripMenuItem,
            this.enlargeToolStripMenuItem});
            this.rowsContextMenuStrip.Name = "rowsContextMenuStrip";
            this.rowsContextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.rowsContextMenuStrip.ShowImageMargin = false;
            this.rowsContextMenuStrip.Size = new System.Drawing.Size(177, 148);
            this.rowsContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.rowsContextMenuStrip_Opening);
            // 
            // saveToDiscToolStripMenuItem
            // 
            this.saveToDiscToolStripMenuItem.Name = "saveToDiscToolStripMenuItem";
            this.saveToDiscToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.saveToDiscToolStripMenuItem.Text = "Save to Disc";
            this.saveToDiscToolStripMenuItem.ToolTipText = "Saving selected snap\\s to disc using stored file path.";
            this.saveToDiscToolStripMenuItem.Click += new System.EventHandler(this.bindingNavigatorSaveSnap_Click);
            // 
            // saveAllToDiscToolStripMenuItem
            // 
            this.saveAllToDiscToolStripMenuItem.Name = "saveAllToDiscToolStripMenuItem";
            this.saveAllToDiscToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.saveAllToDiscToolStripMenuItem.Text = "Save all to Disc";
            this.saveAllToDiscToolStripMenuItem.ToolTipText = "Saves all snaps to disc using stored file path.";
            this.saveAllToDiscToolStripMenuItem.Click += new System.EventHandler(this.bindingNavigatorSaveAllSnaps_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(173, 6);
            // 
            // deleteFromDatabaseToolStripMenuItem
            // 
            this.deleteFromDatabaseToolStripMenuItem.Name = "deleteFromDatabaseToolStripMenuItem";
            this.deleteFromDatabaseToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.deleteFromDatabaseToolStripMenuItem.Text = "Delete from database";
            this.deleteFromDatabaseToolStripMenuItem.ToolTipText = "Delete selected snap\\s from database.";
            this.deleteFromDatabaseToolStripMenuItem.Click += new System.EventHandler(this.bindingNavigatorDeleteSnap_Click);
            // 
            // deleteAllToolStripMenuItem
            // 
            this.deleteAllToolStripMenuItem.Name = "deleteAllToolStripMenuItem";
            this.deleteAllToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.deleteAllToolStripMenuItem.Text = "Delete all from database";
            this.deleteAllToolStripMenuItem.ToolTipText = "Delete all snaps from the database.";
            this.deleteAllToolStripMenuItem.Click += new System.EventHandler(this.bindingNavigatorDeleteAllSnaps_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(173, 6);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.ToolTipText = "Reloading the list.";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.bindingNavigatorRefresh_Click);
            // 
            // enlargeToolStripMenuItem
            // 
            this.enlargeToolStripMenuItem.Name = "enlargeToolStripMenuItem";
            this.enlargeToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.enlargeToolStripMenuItem.Text = "Enlarge";
            this.enlargeToolStripMenuItem.ToolTipText = "Opens preview if close, than opens a Big version preview.";
            this.enlargeToolStripMenuItem.Click += new System.EventHandler(this.enlargePreviewToolStripMenuItem_Click);
            // 
            // previewPictureBox
            // 
            this.previewPictureBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.previewPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previewPictureBox.ContextMenuStrip = this.previewContextMenuStrip;
            this.previewPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewPictureBox.Location = new System.Drawing.Point(0, 0);
            this.previewPictureBox.Name = "previewPictureBox";
            this.previewPictureBox.Size = new System.Drawing.Size(740, 232);
            this.previewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previewPictureBox.TabIndex = 4;
            this.previewPictureBox.TabStop = false;
            this.toolTip.SetToolTip(this.previewPictureBox, "Selected snap preview. Double click to enlarge.");
            this.previewPictureBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.previewPictureBox_MouseDoubleClick);
            // 
            // previewContextMenuStrip
            // 
            this.previewContextMenuStrip.Enabled = false;
            this.previewContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToDiscPreviewToolStripMenuItem,
            this.deleteFromDBPreviewToolStripMenuItem,
            this.toolStripSeparator7,
            this.enlargePreviewToolStripMenuItem});
            this.previewContextMenuStrip.Name = "rowsContextMenuStrip";
            this.previewContextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.previewContextMenuStrip.ShowImageMargin = false;
            this.previewContextMenuStrip.Size = new System.Drawing.Size(162, 76);
            this.previewContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.rowsContextMenuStrip_Opening);
            // 
            // saveToDiscPreviewToolStripMenuItem
            // 
            this.saveToDiscPreviewToolStripMenuItem.Enabled = false;
            this.saveToDiscPreviewToolStripMenuItem.Name = "saveToDiscPreviewToolStripMenuItem";
            this.saveToDiscPreviewToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.saveToDiscPreviewToolStripMenuItem.Text = "Save to Disc";
            this.saveToDiscPreviewToolStripMenuItem.ToolTipText = "Saving selected snap\\s to disc using stored file path.";
            this.saveToDiscPreviewToolStripMenuItem.Click += new System.EventHandler(this.bindingNavigatorSaveSnap_Click);
            // 
            // deleteFromDBPreviewToolStripMenuItem
            // 
            this.deleteFromDBPreviewToolStripMenuItem.Enabled = false;
            this.deleteFromDBPreviewToolStripMenuItem.Name = "deleteFromDBPreviewToolStripMenuItem";
            this.deleteFromDBPreviewToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.deleteFromDBPreviewToolStripMenuItem.Text = "Delete from database";
            this.deleteFromDBPreviewToolStripMenuItem.ToolTipText = "Delete selected snap\\s from database.";
            this.deleteFromDBPreviewToolStripMenuItem.Click += new System.EventHandler(this.bindingNavigatorDeleteSnap_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(158, 6);
            // 
            // enlargePreviewToolStripMenuItem
            // 
            this.enlargePreviewToolStripMenuItem.Enabled = false;
            this.enlargePreviewToolStripMenuItem.Name = "enlargePreviewToolStripMenuItem";
            this.enlargePreviewToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.enlargePreviewToolStripMenuItem.Text = "Enlarge";
            this.enlargePreviewToolStripMenuItem.ToolTipText = "Opens preview if close, than opens a Big version preview.";
            this.enlargePreviewToolStripMenuItem.Click += new System.EventHandler(this.enlargePreviewToolStripMenuItem_Click);
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            // 
            // snapDeletionBackgroundWorker
            // 
            this.snapDeletionBackgroundWorker.WorkerReportsProgress = true;
            this.snapDeletionBackgroundWorker.WorkerSupportsCancellation = true;
            this.snapDeletionBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.snapDeletionBackgroundWorker_DoWork);
            this.snapDeletionBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.snapDeletionBackgroundWorker_RunWorkerCompleted);
            this.snapDeletionBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.snapDeletionBackgroundWorker_ProgressChanged);
            // 
            // snapSavingBackgroundWorker
            // 
            this.snapSavingBackgroundWorker.WorkerReportsProgress = true;
            this.snapSavingBackgroundWorker.WorkerSupportsCancellation = true;
            this.snapSavingBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.snapSavingBackgroundWorker_DoWork);
            this.snapSavingBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.snapSavingBackgroundWorker_RunWorkerCompleted);
            this.snapSavingBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.snapSavingBackgroundWorker_ProgressChanged);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "png";
            this.saveFileDialog.FileName = "Screen";
            this.saveFileDialog.Filter = "Bitmap Files(*.bmp)|*.bmp|JPEG Files(*.jpeg)|*.jpeg|JPG Files(*.jpg)|*.jpg|PNG Fi" +
                "les(*.png)|*.png";
            this.saveFileDialog.Title = "Choose where to save your Files.";
            // 
            // savingAllBackgroundWorker
            // 
            this.savingAllBackgroundWorker.WorkerReportsProgress = true;
            this.savingAllBackgroundWorker.WorkerSupportsCancellation = true;
            this.savingAllBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.savingAllBackgroundWorker_DoWork);
            this.savingAllBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.snapSavingBackgroundWorker_RunWorkerCompleted);
            this.savingAllBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.snapSavingBackgroundWorker_ProgressChanged);
            // 
            // openPreviewBackgroundWorker
            // 
            this.openPreviewBackgroundWorker.WorkerReportsProgress = true;
            this.openPreviewBackgroundWorker.WorkerSupportsCancellation = true;
            this.openPreviewBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.openPreviewBackgroundWorker_DoWork);
            this.openPreviewBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.openPreviewBackgroundWorker_RunWorkerCompleted);
            this.openPreviewBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.openPreviewBackgroundWorker_ProgressChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.messageToolStripProgressBar,
            this.messageToolStripStatusLabel,
            this.snapsCounterToolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 527);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip.Size = new System.Drawing.Size(740, 22);
            this.statusStrip.TabIndex = 9;
            this.statusStrip.Text = "statusStrip";
            // 
            // messageToolStripProgressBar
            // 
            this.messageToolStripProgressBar.Name = "messageToolStripProgressBar";
            this.messageToolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            this.messageToolStripProgressBar.Visible = false;
            // 
            // messageToolStripStatusLabel
            // 
            this.messageToolStripStatusLabel.Name = "messageToolStripStatusLabel";
            this.messageToolStripStatusLabel.Size = new System.Drawing.Size(362, 17);
            this.messageToolStripStatusLabel.Spring = true;
            this.messageToolStripStatusLabel.Text = "status";
            this.messageToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.messageToolStripStatusLabel.Visible = false;
            // 
            // snapsCounterToolStripStatusLabel
            // 
            this.snapsCounterToolStripStatusLabel.Name = "snapsCounterToolStripStatusLabel";
            this.snapsCounterToolStripStatusLabel.Size = new System.Drawing.Size(725, 17);
            this.snapsCounterToolStripStatusLabel.Spring = true;
            this.snapsCounterToolStripStatusLabel.Text = "counter";
            this.snapsCounterToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bindingNavigator
            // 
            this.bindingNavigator.AddNewItem = null;
            this.bindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator.DeleteItem = null;
            this.bindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountNameToolStripLabel,
            this.accountToolStripComboBox,
            this.toolStripSeparator5,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorSaveSnap,
            this.bindingNavigatorSaveAllSnaps,
            this.toolStripSeparator4,
            this.bindingNavigatorDeleteSnap,
            this.bindingNavigatorDeleteAllSnaps,
            this.toolStripSeparator3,
            this.bindingNavigatorRefresh,
            this.bindingNavigatorPreview,
            this.closeToolStripButton});
            this.bindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator.MoveFirstItem = null;
            this.bindingNavigator.MoveLastItem = null;
            this.bindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator.Name = "bindingNavigator";
            this.bindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bindingNavigator.Size = new System.Drawing.Size(740, 31);
            this.bindingNavigator.TabIndex = 14;
            this.bindingNavigator.Text = "bindingNavigator";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // accountNameToolStripLabel
            // 
            this.accountNameToolStripLabel.Name = "accountNameToolStripLabel";
            this.accountNameToolStripLabel.Size = new System.Drawing.Size(104, 28);
            this.accountNameToolStripLabel.Text = "Show snaps from: ";
            // 
            // accountToolStripComboBox
            // 
            this.accountToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accountToolStripComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.accountToolStripComboBox.Name = "accountToolStripComboBox";
            this.accountToolStripComboBox.Size = new System.Drawing.Size(121, 31);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorSaveSnap
            // 
            this.bindingNavigatorSaveSnap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorSaveSnap.Enabled = false;
            this.bindingNavigatorSaveSnap.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorSaveSnap.Image")));
            this.bindingNavigatorSaveSnap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorSaveSnap.Name = "bindingNavigatorSaveSnap";
            this.bindingNavigatorSaveSnap.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorSaveSnap.Text = "Save to Disc";
            this.bindingNavigatorSaveSnap.Click += new System.EventHandler(this.bindingNavigatorSaveSnap_Click);
            // 
            // bindingNavigatorSaveAllSnaps
            // 
            this.bindingNavigatorSaveAllSnaps.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorSaveAllSnaps.Enabled = false;
            this.bindingNavigatorSaveAllSnaps.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorSaveAllSnaps.Image")));
            this.bindingNavigatorSaveAllSnaps.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorSaveAllSnaps.Name = "bindingNavigatorSaveAllSnaps";
            this.bindingNavigatorSaveAllSnaps.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorSaveAllSnaps.Text = "Save all to Disc";
            this.bindingNavigatorSaveAllSnaps.Click += new System.EventHandler(this.bindingNavigatorSaveAllSnaps_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorDeleteSnap
            // 
            this.bindingNavigatorDeleteSnap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteSnap.Enabled = false;
            this.bindingNavigatorDeleteSnap.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteSnap.Image")));
            this.bindingNavigatorDeleteSnap.Name = "bindingNavigatorDeleteSnap";
            this.bindingNavigatorDeleteSnap.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteSnap.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteSnap.Text = "Delete";
            this.bindingNavigatorDeleteSnap.Click += new System.EventHandler(this.bindingNavigatorDeleteSnap_Click);
            // 
            // bindingNavigatorDeleteAllSnaps
            // 
            this.bindingNavigatorDeleteAllSnaps.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteAllSnaps.Enabled = false;
            this.bindingNavigatorDeleteAllSnaps.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteAllSnaps.Image")));
            this.bindingNavigatorDeleteAllSnaps.Name = "bindingNavigatorDeleteAllSnaps";
            this.bindingNavigatorDeleteAllSnaps.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteAllSnaps.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteAllSnaps.Text = "Delete All";
            this.bindingNavigatorDeleteAllSnaps.Click += new System.EventHandler(this.bindingNavigatorDeleteAllSnaps_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorRefresh
            // 
            this.bindingNavigatorRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorRefresh.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorRefresh.Image")));
            this.bindingNavigatorRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorRefresh.Name = "bindingNavigatorRefresh";
            this.bindingNavigatorRefresh.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorRefresh.Text = "Refresh";
            this.bindingNavigatorRefresh.Click += new System.EventHandler(this.bindingNavigatorRefresh_Click);
            // 
            // bindingNavigatorPreview
            // 
            this.bindingNavigatorPreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorPreview.Enabled = false;
            this.bindingNavigatorPreview.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorPreview.Image")));
            this.bindingNavigatorPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorPreview.Name = "bindingNavigatorPreview";
            this.bindingNavigatorPreview.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorPreview.Text = "Preview";
            this.bindingNavigatorPreview.ToolTipText = "Open\\Close Preview Box.";
            this.bindingNavigatorPreview.Click += new System.EventHandler(this.bindingNavigatorPreview_Click);
            // 
            // closeToolStripButton
            // 
            this.closeToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.closeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.closeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("closeToolStripButton.Image")));
            this.closeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeToolStripButton.Name = "closeToolStripButton";
            this.closeToolStripButton.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.closeToolStripButton.Size = new System.Drawing.Size(40, 28);
            this.closeToolStripButton.Text = "Close";
            this.closeToolStripButton.ToolTipText = "Close explorer.";
            this.closeToolStripButton.Click += new System.EventHandler(this.closeToolStripButton_Click);
            // 
            // viewSplitContainer
            // 
            this.viewSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.viewSplitContainer.Location = new System.Drawing.Point(0, 31);
            this.viewSplitContainer.Name = "viewSplitContainer";
            this.viewSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // viewSplitContainer.Panel1
            // 
            this.viewSplitContainer.Panel1.Controls.Add(this.snapsDataGridView);
            // 
            // viewSplitContainer.Panel2
            // 
            this.viewSplitContainer.Panel2.Controls.Add(this.previewPictureBox);
            this.viewSplitContainer.Size = new System.Drawing.Size(740, 496);
            this.viewSplitContainer.SplitterDistance = 260;
            this.viewSplitContainer.TabIndex = 15;
            // 
            // accountsTableAdapter
            // 
            this.accountsTableAdapter.ClearBeforeFill = true;
            // 
            // snapsTableAdapter
            // 
            this.snapsTableAdapter.ClearBeforeFill = true;
            // 
            // fullTableTableAdapter
            // 
            this.fullTableTableAdapter.ClearBeforeFill = true;
            // 
            // accountsBindingSource
            // 
            this.accountsBindingSource.DataMember = "Accounts";
            this.accountsBindingSource.DataSource = this.snapsDatabaseDataSet;
            // 
            // SnapsExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 549);
            this.Controls.Add(this.viewSplitContainer);
            this.Controls.Add(this.bindingNavigator);
            this.Controls.Add(this.statusStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 339);
            this.Name = "SnapsExplorer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snaps Explorer";
            this.Load += new System.EventHandler(this.SnapsExplorer_Load);
            this.SizeChanged += new System.EventHandler(this.SnapsExplorer_SizeChanged);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SnapsExplorer_FormClosed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SnapsExplorer_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.snapsDataGridView)).EndInit();
            this.columnsContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fullTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snapsDatabaseDataSet)).EndInit();
            this.rowsContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).EndInit();
            this.previewContextMenuStrip.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
            this.bindingNavigator.ResumeLayout(false);
            this.bindingNavigator.PerformLayout();
            this.viewSplitContainer.Panel1.ResumeLayout(false);
            this.viewSplitContainer.Panel2.ResumeLayout(false);
            this.viewSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView snapsDataGridView;
        private System.Windows.Forms.PictureBox previewPictureBox;
        private SnapsDatabaseDataSet snapsDatabaseDataSet;
        private ScreenGrabber.SnapsDatabaseDataSetTableAdapters.AccountsTableAdapter accountsTableAdapter;
        private ScreenGrabber.SnapsDatabaseDataSetTableAdapters.SnapsTableAdapter snapsTableAdapter;
        private ScreenGrabber.SnapsDatabaseDataSetTableAdapters.FullTableTableAdapter fullTableTableAdapter;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ContextMenuStrip rowsContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteFromDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToDiscToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker snapDeletionBackgroundWorker;
        private System.ComponentModel.BackgroundWorker snapSavingBackgroundWorker;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.ComponentModel.BackgroundWorker savingAllBackgroundWorker;
        private System.Windows.Forms.ToolStripMenuItem enlargeToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker openPreviewBackgroundWorker;
        private System.Windows.Forms.ToolStripMenuItem saveAllToDiscToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar messageToolStripProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel messageToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel snapsCounterToolStripStatusLabel;
        private System.Windows.Forms.BindingNavigator bindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteSnap;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteAllSnaps;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSaveSnap;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSaveAllSnaps;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorPreview;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel accountNameToolStripLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.BindingSource fullTableBindingSource;
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private System.Windows.Forms.ToolStripButton closeToolStripButton;
        public System.Windows.Forms.ToolStripButton bindingNavigatorRefresh;
        private System.Windows.Forms.SplitContainer viewSplitContainer;
        private System.Windows.Forms.ContextMenuStrip previewContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem saveToDiscPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteFromDBPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem enlargePreviewToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip columnsContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem madeByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem snapToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem verticalViewPreviewBoxOnTheSideToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn snapDataGridViewImageColumn;
        private System.Windows.Forms.ToolStripComboBox accountToolStripComboBox;
    }
}