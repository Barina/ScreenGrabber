using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ScreenGrabber.Properties;
using System.Threading;

namespace ScreenGrabber
{
    public partial class SnapsExplorer : Form
    {
        //#region Components.
        //private Size clientSize;
        //private Point clientLocation;
        //#endregion
        /// <summary>
        /// Open snaps explorer.
        /// </summary>
        public SnapsExplorer()
        {
            InitializeComponent();
            this.Icon = Resources.ScreenGrabber;
            //previewOpen = false;
            Size = ExplorerSettings.Default.Size;
           
            madeByToolStripMenuItem.Checked = ExplorerSettings.Default.MadeByColumn;
            dateToolStripMenuItem.Checked = ExplorerSettings.Default.DateColumn;
            snapToolStripMenuItem.Checked = ExplorerSettings.Default.SnapColumn;
            viewSplitContainer.SplitterDistance = ExplorerSettings.Default.SplitterDistance;
            viewSplitContainer.Panel2Collapsed = ExplorerSettings.Default.PreviewCollapsed;
        }

        #region Background workers.
        #region snap\s deletion operation
        private void snapDeletionBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                int value = snapsDataGridView.SelectedRows.Count;
                for(int a = 0 ; a < value ; a++)
                {
                    snapsTableAdapter.DeleteSnap((int)snapsDataGridView.SelectedRows[a].Cells[0].Value);
                    snapDeletionBackgroundWorker.ReportProgress(((a + 1) * 100 / value), "Deleteing snap ID: " + ((int)snapsDataGridView.SelectedRows[a].Cells[0].Value) + " ...");
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("Unable to delete. '" + exc.Message + "'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void snapDeletionBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            showMessage(e.UserState as string, ProgressBarStyle.Blocks);
            messageToolStripProgressBar.Value = e.ProgressPercentage;
        }

        private void snapDeletionBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            showMessage("Refreshing...", ProgressBarStyle.Marquee);
            bindingNavigatorRefresh.PerformClick();
            hideMessage();
            Program.main.updateStatus();
        }
        #endregion

        #region saving snaps to disc
        private void snapSavingBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                int value = snapsDataGridView.SelectedRows.Count;
                for(int a = 0 ; a < value ; a++)
                {
                    int snapID = (int)snapsDataGridView.SelectedRows[a].Cells[0].Value;
                    snapSavingBackgroundWorker.ReportProgress(((a + 1) * 100 / value), "Saving snap ID: " + snapID + " to '" + Settings.Default.Path + "' ...");
                    Image snap = Snap.byteArrayToImage((byte[])snapsTableAdapter.GetSnap(snapID));
                    DateTime date = (DateTime)snapsTableAdapter.GetDateBySnapID(snapID);
                    Program.saveToFile(Settings.Default.Path, new Snap(snap, Program.GetExt(Settings.Default.Path), date, snapID));
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("Unable to save. '" + exc.Message + "'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void snapSavingBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            showMessage(e.UserState as string, ProgressBarStyle.Blocks);
            messageToolStripProgressBar.Value = e.ProgressPercentage;
        }

        private void snapSavingBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            hideMessage();
            Program.main.updateStatus();
            Program.main.notifySuccessSave(Settings.Default.Path);
        }
        #endregion

        #region Saving all snaps
        private void savingAllBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                int value = snapsDataGridView.Rows.Count;

                for(int a = 0 ; a < value ; a++)
                {
                    var snaps = from snap in snapsTableAdapter.GetData()
                                where snap.ID == (int)snapsDataGridView.Rows[a].Cells[0].Value
                                select snap;

                    foreach(var snap in snaps)
                    {
                        savingAllBackgroundWorker.ReportProgress(((a + 1) * 100 / value), "Saving snap ID: " + snap.ID + " to '" + Settings.Default.Path + "' ...");
                        Program.saveToFile(Settings.Default.Path, new Snap(Snap.byteArrayToImage(snap.Snap), Program.GetExt(Settings.Default.Path), snap.DateTime, snap.AccountID));// Snap.byteArrayToImage((byte[])snapsTableAdapter.GetSnap(snap.ID)));
                    }
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("Unable to save. '" + exc.Message + "'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void snapsDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            bindingNavigatorPreview.PerformClick();
        }
        #endregion

        #region enlarging the bmp to a 100% sized bmp
        private void openPreviewBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var snaps = from snap in snapsTableAdapter.GetData()
                            where snap.ID == (int)snapsDataGridView.CurrentRow.Cells[0].Value
                            select snap;
                foreach(var snap in snaps)
                {
                    openPreviewBackgroundWorker.ReportProgress(0, "Done.");
                    e.Result = snap;
                    break;
                }
            }
            catch { }
        }

        private void openPreviewBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            showMessage(e.UserState as string, ProgressBarStyle.Blocks);
        }

        private void openPreviewBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            SnapsDatabaseDataSet.SnapsRow snap = (SnapsDatabaseDataSet.SnapsRow)e.Result;
            new Preview(Snap.byteArrayToImage(snap.Snap), snap.DateTime).Show();
            hideMessage();
        }
        #endregion
        #endregion

        #region Functions.
        /// <summary>
        /// Refreshes the PreviewBox
        /// </summary>
        public void RefreshPreview()
        {
            if(!viewSplitContainer.Panel2Collapsed && snapsDataGridView.CurrentRow != null)
                try
                {
                    previewPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    previewPictureBox.Image = Snap.byteArrayToImage((byte[])snapsTableAdapter.GetSnap((int)snapsDataGridView.CurrentRow.Cells[0].Value));
                    return;
                }
                catch { }

            previewPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            previewPictureBox.Image = Properties.Resources.imageEmpty;
        }

        /// <summary>
        /// Refreshing the list with new parameters from Database.
        /// </summary>
        public void refreshList()
        {
            try
            {
                lock(Program.DatabaseLocker)
                {
                    showMessage("Fill adapters with data...", ProgressBarStyle.Marquee);
                    this.fullTableTableAdapter.Fill(this.snapsDatabaseDataSet.FullTable);
                    this.snapsTableAdapter.Fill(this.snapsDatabaseDataSet.Snaps);
                    this.accountsTableAdapter.Fill(this.snapsDatabaseDataSet.Accounts);

                    if(snapsDataGridView.Rows.Count > 0)
                        snapsDataGridView.Rows[0].Selected = true;
                    else
                        RefreshPreview();
                }
                bindingNavigator.BindingSource = fullTableBindingSource;

                hideMessage();
                Program.main.updateStatus();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        /// <summary>
        /// Checks if the list is empty and sets cnotrols Enable property as well.
        /// </summary>
        private void checkList()
        {
            if(snapsDataGridView.RowCount == 0)
            {
                bindingNavigatorSaveSnap.Enabled = false;
                bindingNavigatorDeleteSnap.Enabled = false;
                bindingNavigatorSaveAllSnaps.Enabled = false;
                bindingNavigatorDeleteAllSnaps.Enabled = false;
                bindingNavigatorPreview.Enabled = false;
                RefreshPreview();
                previewContextMenuStrip.Enabled = false;
                previewContextMenuStrip.Items["saveToDiscPreviewToolStripMenuItem"].Enabled = false;
                previewContextMenuStrip.Items["deleteFromDBPreviewToolStripMenuItem"].Enabled = false;
                previewContextMenuStrip.Items["enlargePreviewToolStripMenuItem"].Enabled = false;
            }
            else
            {
                bindingNavigatorSaveSnap.Enabled = true;
                bindingNavigatorDeleteSnap.Enabled = true;
                bindingNavigatorSaveAllSnaps.Enabled = true;
                bindingNavigatorDeleteAllSnaps.Enabled = true;
                bindingNavigatorPreview.Enabled = true;
                if(snapsDataGridView.SelectedRows.Count > 0)
                {
                    previewContextMenuStrip.Enabled = true;
                    previewContextMenuStrip.Items["saveToDiscPreviewToolStripMenuItem"].Enabled = true;
                    previewContextMenuStrip.Items["deleteFromDBPreviewToolStripMenuItem"].Enabled = true;
                    previewContextMenuStrip.Items["enlargePreviewToolStripMenuItem"].Enabled = true;
                }
            }
            RefreshPreview();
        }

        #region Status message controls.
        void showMessage(string msg, ProgressBarStyle style)
        {
            messageToolStripProgressBar.Style = style;
            messageToolStripStatusLabel.Text = msg;
            messageToolStripProgressBar.Visible = true;
            messageToolStripStatusLabel.Visible = true;
        }
        void hideMessage()
        {
            messageToolStripProgressBar.Visible = false;
            messageToolStripStatusLabel.Visible = false;
            messageToolStripProgressBar.Style = ProgressBarStyle.Marquee;
            messageToolStripProgressBar.Value = 0;
        }
        #endregion
        #endregion

        #region Events.
        private void SnapsExplorer_Load(object sender, EventArgs e)
        {
            showMessage("Loading...", ProgressBarStyle.Marquee);
            if(ExplorerSettings.Default.Location == new Point(-1, -1))
                ExplorerSettings.Default.Location = Location;
            else
            Location = ExplorerSettings.Default.Location;
            this.LocationChanged += SnapsExplorer_LocationChanged;

            if(ExplorerSettings.Default.WindowState != FormWindowState.Normal)
                WindowState = ExplorerSettings.Default.WindowState;
            
            if(verticalViewPreviewBoxOnTheSideToolStripMenuItem.Checked = ExplorerSettings.Default.VerticalView)
                viewSplitContainer.Orientation = Orientation.Vertical;
            else
                viewSplitContainer.Orientation = Orientation.Horizontal;
            //accountNameToolStripLabel.Text = accountsTableAdapter.GetNameByAccountID(Settings.Default.AccountID) + "'s snaps. ";
            accountToolStripComboBox.ComboBox.DataSource = accountsTableAdapter.GetData();
            accountToolStripComboBox.ComboBox.ValueMember = "AccountID";
            accountToolStripComboBox.ComboBox.DisplayMember = "AccountName";
            accountToolStripComboBox.ComboBox.SelectedValue = Settings.Default.AccountID;
            accountToolStripComboBox.ComboBox.SelectedIndexChanged += accountToolStripComboBox_SelectedIndexChanged;
            checkList();
            refreshList();
            bindingNavigatorRefresh.PerformClick();
        }

        private void snapsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            checkList();

            if(snapsDataGridView.SelectedRows.Count > 0)
                snapsCounterToolStripStatusLabel.Text = snapsDataGridView.SelectedRows.Count + (snapsDataGridView.SelectedRows.Count == 1 ? " selected snap." : " selected snaps.");
            else
                snapsCounterToolStripStatusLabel.Text = "";
            RefreshPreview();
        }

        private void accountToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fullTableBindingSource.Filter = accountToolStripComboBox.ComboBox.SelectedValue + " = AccountID";
        }
        
        private void snapIDToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = sender as ToolStripMenuItem;
            switch(tsmi.Name)
            {
                case "madeByToolStripMenuItem":
                    snapsDataGridView.Columns["accountNameDataGridViewTextBoxColumn"].Visible = tsmi.Checked;
                    break;
                case "dateToolStripMenuItem":
                    snapsDataGridView.Columns["dataGridViewTextBoxColumn1"].Visible = tsmi.Checked;
                    break;
                case "snapToolStripMenuItem":
                    snapsDataGridView.Columns["snapDataGridViewImageColumn"].Visible = tsmi.Checked;
                    break;
                case "verticalViewPreviewBoxOnTheSideToolStripMenuItem":
                    if(verticalViewPreviewBoxOnTheSideToolStripMenuItem.Checked)
                        viewSplitContainer.Orientation = Orientation.Vertical;
                    else
                        viewSplitContainer.Orientation = Orientation.Horizontal;
                    break;
            }
            snapsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        #region On every Size or Location changed event saving the new values to settings.
        private void SnapsExplorer_SizeChanged(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)// 
                ExplorerSettings.Default.Size = this.Size;
        }

        private void SnapsExplorer_LocationChanged(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
                ExplorerSettings.Default.Location = this.Location;
        }
        #endregion

        private void previewPictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            enlargePreviewToolStripMenuItem.PerformClick();
        }

        private void bindingNavigatorDeleteAllSnaps_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to erase all your snaps?", "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    snapsTableAdapter.DeleteAllByAccountID(Settings.Default.AccountID);
                }
                catch
                {
                    MessageBox.Show("There were a problem deleting some snaps.\nPlease try again.", "Error",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                bindingNavigatorRefresh.PerformClick();
                Program.main.updateStatus();
                RefreshPreview();
            }
        }

        private void bindingNavigatorSaveAllSnaps_Click(object sender, EventArgs e)
        {
            if(!savingAllBackgroundWorker.IsBusy)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to save all your snaps to:\n'" + Settings.Default.Path +
                    "'?\n(Press 'YES' to continue or 'NO' to choose another destination.)",
                    "Saving Snaps", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if(dr == DialogResult.No)
                {
                    DialogResult dr2 = saveFileDialog.ShowDialog();
                    if(dr2 == DialogResult.OK)
                        Settings.Default.Path = saveFileDialog.FileName;
                    else
                        if(dr2 == DialogResult.Abort || dr2 == DialogResult.Cancel)
                            return;
                }
                else
                    if(dr == DialogResult.Cancel)
                        return;

                showMessage("Saving...", ProgressBarStyle.Blocks);
                savingAllBackgroundWorker.RunWorkerAsync();
            }
            else
                MessageBox.Show("Operation is in process..", "Please wait", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void bindingNavigatorRefresh_Click(object sender, EventArgs e)
        {
            showMessage("Refreshing list...", ProgressBarStyle.Marquee);
            refreshList();
        }

        private void bindingNavigatorPreview_Click(object sender, EventArgs e)
        {
            viewSplitContainer.Panel2Collapsed = !viewSplitContainer.Panel2Collapsed;
            RefreshPreview();
        }

        private void closeToolStripButton_Click(object sender, EventArgs e)
        {
            Program.main.updateStatus();
            Close();
        }

        private void bindingNavigatorSaveSnap_Click(object sender, EventArgs e)
        {
            if(!snapSavingBackgroundWorker.IsBusy)
            {
                if(snapsDataGridView.SelectedRows.Count > 1)
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to save " + snapsDataGridView.SelectedRows.Count + " selected snaps to:\n'" +
                        Settings.Default.Path + "'?\n(Press 'YES' to continue or 'NO' to choose another destination.)", "Confirm saving",
                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if(dr == DialogResult.No)
                    {
                        DialogResult dr2 = saveFileDialog.ShowDialog();
                        if(dr2 == DialogResult.OK)
                            Settings.Default.Path = saveFileDialog.FileName;
                        else
                            if(dr2 == DialogResult.Abort || dr2 == DialogResult.Cancel)
                                return;
                    }
                    else
                        if(dr == DialogResult.Cancel)
                            return;
                }
                showMessage("Saving...", ProgressBarStyle.Blocks);
                snapSavingBackgroundWorker.RunWorkerAsync();
            }
            else
                MessageBox.Show("Operation is in process..", "Please wait", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void bindingNavigatorDeleteSnap_Click(object sender, EventArgs e)
        {
            if(!snapDeletionBackgroundWorker.IsBusy)
            {
                string msg = "Are you sure you want to erase " + snapsDataGridView.SelectedRows.Count + " selected snaps?";
                if(snapsDataGridView.SelectedRows.Count > 1)
                    if(MessageBox.Show(msg, "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                showMessage("Deleting...", ProgressBarStyle.Blocks);
                snapDeletionBackgroundWorker.RunWorkerAsync();
            }
            else
                MessageBox.Show("Operation is in process..", "Please wait", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void enlargePreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                lock(Program.DatabaseLocker)
                    new Preview(Snap.byteArrayToImage((byte[])snapsTableAdapter.GetSnap((int)snapsDataGridView.CurrentRow.Cells[0].Value)),
                        snapsTableAdapter.GetDateBySnapID((int)snapsDataGridView.CurrentRow.Cells[0].Value).Value).Show();
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message + "\nPlease try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void rowsContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            checkList();
        }

        private void SnapsExplorer_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if((ExplorerSettings.Default.WindowState = WindowState) == FormWindowState.Normal)
                {// Apllying windowState to settings and checks if it set to Normal. if so saving window size and location.
                    ExplorerSettings.Default.Size = Size;
                    ExplorerSettings.Default.Location = this.Location;
                }
                else// Else checking if it set to Minimized.
                    if(WindowState == FormWindowState.Minimized)// if so saving it as Normal.
                        ExplorerSettings.Default.WindowState = FormWindowState.Normal;

                ExplorerSettings.Default.MadeByColumn = madeByToolStripMenuItem.Checked;
                ExplorerSettings.Default.DateColumn = dateToolStripMenuItem.Checked;
                ExplorerSettings.Default.SnapColumn = snapToolStripMenuItem.Checked;
                ExplorerSettings.Default.VerticalView = verticalViewPreviewBoxOnTheSideToolStripMenuItem.Checked;
                ExplorerSettings.Default.SplitterDistance = viewSplitContainer.SplitterDistance;
                ExplorerSettings.Default.PreviewCollapsed = viewSplitContainer.Panel2Collapsed;
                ExplorerSettings.Default.Save();
            }
            catch(Exception ex)
            {
                ExplorerSettings.Default.Reload();
                e.Cancel = true;
                MessageBox.Show(ex.Message + "\nPlease try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void SnapsExplorer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.main.explorer = null;
        }
        #endregion
    }
}