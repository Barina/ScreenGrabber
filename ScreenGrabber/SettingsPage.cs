﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using ScreenGrabber.Properties;
using Facebook;
using Facebook.Components;
using Facebook.Exceptions;
using Facebook.Entity;
using System.Windows.Media.Imaging;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace ScreenGrabber
{
    public partial class SettingsPage : Form
    {
        #region Components.
        RegistryKey rkApp;
        bool saveAll;
        Point tempLocation;
        Size tempSize;
        Corner datePosition;
        FacebookService service;
        User me;
        #endregion

        /// <summary>
        /// Settings section.
        /// </summary>
        public SettingsPage()
        {
            InitializeComponent();
            MinimumSize = new Size(554, 300);
            MaximumSize = MinimumSize;
            Icon = Properties.Resources.ScreenGrabber;
            saveAll = false;

            rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            startupCheckBox.Checked = rkApp.GetValue("ScreenGrabber") != null;

            autoCaptureCheckBox.Checked = Settings.Default.AutoCapture;
            autoSaveCheckBox.Checked = Settings.Default.autoSave;
            overwriteCheckBox.Checked = Settings.Default.Overwrite;
            minimizedCheckBox.Checked = Settings.Default.Minimized;
            commentPopUpCheckBox.Checked = Settings.Default.CommentEditorPopUp;

            sumNumericUpDown.Value = Settings.Default.PictureSum;
            hoursNumericUpDown.Value = Settings.Default.Counter.Hours + (Settings.Default.Counter.Days * 24);
            minNumericUpDown.Value = Settings.Default.Counter.Minutes;
            secNumericUpDown.Value = Settings.Default.Counter.Seconds;

            sumNumericUpDown.ValueChanged += NumericUpDown_ValueChanged;
            hoursNumericUpDown.ValueChanged += NumericUpDown_ValueChanged;
            minNumericUpDown.ValueChanged += NumericUpDown_ValueChanged;
            secNumericUpDown.ValueChanged += NumericUpDown_ValueChanged;

            autoInitiaterCheckBox.Checked = Settings.Default.AutoInitiater;
            closeToTrayCheckBox.Checked = Settings.Default.CloseToTray;
            stickyCheckBox.Checked = Settings.Default.Sticky;
            customCheckBox.Checked = Settings.Default.CustomBounds;
            pathTextBox.Text = Settings.Default.Path;
            saveSnapsCheckBox.Checked = Settings.Default.SaveSnaps;
            tryDXCheckBox.Checked = Settings.Default.TryDXFirst;
            tryDXCheckBox.CheckedChanged += CheckBox_CheckedChanged;

            if (saveDateCheckBox.Checked = Settings.Default.SaveDate)
            {
                opacityTrackBar.Enabled = true;
                positionGroupBox.Enabled = true;
                fontButton.Enabled = true;
                colorButton.Enabled = true;
            }
            datePosition = (Corner)Settings.Default.DatePosition;
            colorDialog.Color = Settings.Default.DateBackgroundColor;
            fontDialog.Font = Settings.Default.DateFont;
            fontDialog.Color = Settings.Default.DateColor;
            opacityTrackBar.Value = Settings.Default.DateBackgroundTransparency;
            opacityLabel.Text = "Background opacity: " + Settings.Default.DateBackgroundTransparency + " (" + (opacityTrackBar.Value * 100 / 255) + "%)";
            timeLabel.Text = "(" + Stoppers.Stopper.ToString(Settings.Default.Counter) + ")";

            tempLocation = Settings.Default.grabberPosition;
            tempSize = Settings.Default.grabberSize;

            switch (Program.main.modifier)
            {
                case 1:
                    MODComboBox.Text = "Alt";
                    break;
                case 2:
                    MODComboBox.Text = "Control";
                    break;
                case 4:
                    MODComboBox.Text = "Shift";
                    break;
            }

            switch (datePosition)
            {
                case Corner.UpLeft:
                    upLeftRadioButton.Checked = true;
                    break;
                case Corner.UpRight:
                    upRightRadioButton.Checked = true;
                    break;
                case Corner.BottomLeft:
                    bottomLeftRadioButton.Checked = true;
                    break;
                case Corner.BottomRight:
                    bottomRightRadioButton.Checked = true;
                    break;
            }
            try
            {
                hotKeyTextBox.Text = Program.main.key.ToString();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            positionLabel.Text = "Location: X=" + Program.grabberPosition.X + ",Y=" + Program.grabberPosition.Y;
            sizeLabel.Text = "Size: " + Program.grabberSize.Width + "x" + Program.grabberSize.Height;

            dateStampPreviewPictureBox.Image = Program.DrawDateOnImage(Resources.dateStampPreviewBox, DateTime.Now);

            mainTreeView.ExpandAll();

            globalGroupBox.Location = new Point(158, 8);
            dateStampGroupBox.Location = globalGroupBox.Location;
            globalKeyGroupBox.Location = globalGroupBox.Location;
            grabberGroupBox.Location = globalGroupBox.Location;
            facebookGroupBox.Location = globalGroupBox.Location;
            directXGroupBox.Location = globalGroupBox.Location;
        }

        #region Events.
        private void SettingsPage_Load(object sender, EventArgs e)
        {
            Settings.Default.PropertyChanged += new PropertyChangedEventHandler(Default_PropertyChanged);
            pathTextBox.TextChanged += pathTextBox_TextChanged;
            processNameComboBox.DataSource = GetProcesseList();
            try
            {
                //if (Settings.Default.FacebookService != null)
                //{
                service = Settings.Default.FacebookService;
                    if (Settings.Default.FacebookUser != null)
                    {
                        me = Settings.Default.FacebookUser;
                        userNameTextBox.Text = me.Name;
                        ProfilePictureBox.Image = me.Picture;
                        ProfilePictureBox.BorderStyle = BorderStyle.FixedSingle;
                        statusLabel.Text = "Authorized.";
                        statusLabel.Visible = true;
                    }
               // }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message+"\n\n"+ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public List<string> GetProcesseList()
        {
            List<string> result = new List<string>();
            foreach (Process process in Process.GetProcesses())
                result.Add(process.ProcessName);
            return result;
        }

        private void mainTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            selectChange();
        }

        private void shortCutButton_Click(object sender, EventArgs e)
        {
            new ShortCutPage().ShowDialog();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (!Directory.GetParent(pathTextBox.Text).Exists)
            {
                if (!(MessageBox.Show("No such File or Directory '" + Directory.GetParent(pathTextBox.Text).FullName + "'.\nDo you want to create it?", "Path not exist.",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK))
                    return;
                Directory.CreateDirectory(Directory.GetParent(pathTextBox.Text).ToString());
            }
            System.Diagnostics.Process.Start(Directory.GetParent(pathTextBox.Text).FullName);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveAll = true;
            applySettings();
            Close();
        }

        private void setBoundsButton_Click(object sender, EventArgs e)
        {
            if (new BoundsSetter().ShowDialog() == DialogResult.OK)
            {
                customCheckBox.Checked = true;
                positionLabel.Text = "Location: X=" + Program.grabberPosition.X + ",Y=" + Program.grabberPosition.Y;
                sizeLabel.Text = "Size: " + Program.grabberSize.Width + "x" + Program.grabberSize.Height;
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Settings.Default.Path = saveFileDialog.FileName;
                Settings.Default.Save();
                Program.main.pathLabel.Text = "Saving to: " + Settings.Default.Path;
                pathTextBox.Text = saveFileDialog.FileName;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reset custom bounds?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Program.grabberPosition = new Point(0, 0);
                Program.grabberSize = Screen.PrimaryScreen.Bounds.Size;
                Program.main.updateStatus();
                customCheckBox.Checked = false;
                positionLabel.Text = "Location: X=" + Program.grabberPosition.X + ",Y=" + Program.grabberPosition.Y;
                sizeLabel.Text = "Size: " + Program.grabberSize.Width + "x" + Program.grabberSize.Height;
                applyButton.Enabled = true;
            }
        }

        private void newSetterButton_Click(object sender, EventArgs e)
        {
            if (new NewerSetBounds().ShowDialog() == DialogResult.OK)
            {
                customCheckBox.Checked = true;
                Program.main.updatePreview(tempLocation, tempSize);
                positionLabel.Text = "Location: X=" + tempLocation.X + ",Y=" + tempLocation.Y;
                sizeLabel.Text = "Size: " + tempSize.Width + "x" + tempSize.Height;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Settings.Default.Reload();
            Close();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            applySettings();
        }

        private void fontButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    Settings.Default.DateFont = fontDialog.Font;
                    Settings.Default.DateColor = fontDialog.Color;
                    dateStampPreviewPictureBox.Image = Program.DrawDateOnImage(Resources.dateStampPreviewBox, DateTime.Now);
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Settings.Default.DateBackgroundColor = colorDialog.Color;
                dateStampPreviewPictureBox.Image = Program.DrawDateOnImage(Resources.dateStampPreviewBox, DateTime.Now);
            }
        }

        private void pathTextBox_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.Path = pathTextBox.Text;
            applyButton.Enabled = true;
        }

        private void hotKeyTextBox_TextChanged(object sender, EventArgs e)
        {
            updateGlobalKey();
        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (hoursNumericUpDown.Value == 0 && minNumericUpDown.Value == 0 && secNumericUpDown.Value < 1)
            {
                secNumericUpDown.Value = 1;
                return;
            }

            Settings.Default.PictureSum = sumNumericUpDown.Value;
            Settings.Default.Counter = new TimeSpan((int)hoursNumericUpDown.Value, (int)minNumericUpDown.Value, (int)secNumericUpDown.Value);
            timeLabel.Text = "(" + Stoppers.Stopper.ToString(Settings.Default.Counter) + ")";

            string tip = "Set time to take picture to " + timeLabel.Text + ".";
            toolTip.SetToolTip(secNumericUpDown, minNumericUpDown.Value != 0 && hoursNumericUpDown.Value != 0 ? tip : (secNumericUpDown.Value + " second"
                + (secNumericUpDown.Value == 1 ? "." : "s.")));
            toolTip.SetToolTip(minNumericUpDown, minNumericUpDown.Value != 0 && hoursNumericUpDown.Value != 0 ? tip : "Represents minutes.");
            toolTip.SetToolTip(hoursNumericUpDown, minNumericUpDown.Value != 0 && hoursNumericUpDown.Value != 0 ? tip : "48 hours means 2 days.");

            Program.main.timeTakeButtonToolTipSetter();
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            switch (cb.Name)
            {
                case "startupCheckBox":
                    if (startupCheckBox.Checked)
                    {
                        if (rkApp.GetValue("ScreenGrabber") == null)
                            if (MessageBox.Show("That will add '" + Application.ExecutablePath + "' to Registry.", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                try
                                {
                                    rkApp.SetValue("ScreenGrabber", Application.ExecutablePath.ToString());
                                    MessageBox.Show("Value added successfuly.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                catch
                                {
                                    MessageBox.Show("There was a problem adding Value to the Registry. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                                startupCheckBox.Checked = false;
                    }
                    else
                        try
                        {
                            rkApp.DeleteValue("ScreenGrabber", false);
                            MessageBox.Show("Value removed successfuly.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show("There was a problem removing Value from the Registry. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    Settings.Default.StartUp = startupCheckBox.Checked;
                    break;

                case "stickyCheckBox":
                    Settings.Default.Sticky = cb.Checked;
                    break;

                case "tryDXCheckBox":
                    if (tryDXCheckBox.Checked)
                        if (MessageBox.Show("In this mode ScreenGrabber will try to snap using DirectX with default values.\nIf failed will take a normal grab screen with user parameters." +
                            "\nNot recomended. May also work on desktop. May retrieve black snaps.\nAre you sure you want to use DirectX?", "Are you sure?",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                            tryDXCheckBox.Checked = false;
                    Settings.Default.TryDXFirst = tryDXCheckBox.Checked;
                    break;

                case "saveSnapsCheckBox":
                    Settings.Default.SaveSnaps = saveSnapsCheckBox.Checked;
                    break;

                case "autoCaptureCheckBox":
                    Settings.Default.AutoCapture = autoCaptureCheckBox.Checked;
                    break;

                case "minimizedCheckBox":
                    Settings.Default.Minimized = minimizedCheckBox.Checked;
                    break;

                case "closeToTrayCheckBox":
                    Settings.Default.CloseToTray = closeToTrayCheckBox.Checked;
                    break;

                case "customCheckBox":
                    Settings.Default.CustomBounds = customCheckBox.Checked;
                    break;

                case "autoInitiaterCheckBox":
                    Settings.Default.AutoInitiater = autoInitiaterCheckBox.Checked;
                    break;

                case "saveDateCheckBox":
                    Settings.Default.SaveDate = saveDateCheckBox.Checked;
                    break;

                case "autoSaveCheckBox":
                    Settings.Default.autoSave = autoSaveCheckBox.Checked;
                    break;

                case "overwriteCheckBox":
                    Settings.Default.Overwrite = overwriteCheckBox.Checked;
                    break;

                case "commentPopUpCheckBox":
                    Settings.Default.CommentEditorPopUp = commentPopUpCheckBox.Checked;
                    break;
            }
            CheckBoxLabelChanged(cb);
        }

        private void positionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (upLeftRadioButton.Checked)
                datePosition = Corner.UpLeft;
            if (upRightRadioButton.Checked)
                datePosition = Corner.UpRight;
            if (bottomLeftRadioButton.Checked)
                datePosition = Corner.BottomLeft;
            if (bottomRightRadioButton.Checked)
                datePosition = Corner.BottomRight;
            Settings.Default.DatePosition = (byte)datePosition;
            dateStampPreviewPictureBox.Image = Program.DrawDateOnImage(Resources.dateStampPreviewBox, DateTime.Now);
        }

        void Default_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            applyButton.Enabled = true;
        }

        private void hotKeyTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                hotKeyTextBox.Text = Program.main.key.ToString();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void hotKeyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            Program.main.key = (Keys)e.KeyValue;
        }

        private void CheckBox_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                Button btn = sender as Button;
                if (btn.Name == "shortCutButton")
                {
                    detailsLabel.Text = "Create short cuts on Desktop(or any other place you want) for grabbing the screen or launch the program.";
                    detailsLabel.Visible = true;
                }
            }
            catch
            {
                CheckBoxLabelChanged(sender as CheckBox);
            }
        }

        private void CheckBox_MouseLeave(object sender, EventArgs e)
        {
            detailsLabel.Visible = false;
        }

        private void opacityTrackBar_Scroll(object sender, EventArgs e)
        {
            opacityLabel.Text = "Background opacity: " + (Settings.Default.DateBackgroundTransparency = (byte)opacityTrackBar.Value) + " (" + (opacityTrackBar.Value * 100 / 255) + "%)";
            dateStampPreviewPictureBox.Image = Program.DrawDateOnImage(Resources.dateStampPreviewBox, DateTime.Now);
        }

        private void ScreenGrabberSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!applySettings())
                e.Cancel = true;
        }

        private void ScreenGrabberSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (saveAll)
                Settings.Default.Save();
            else
                Settings.Default.Reload();
        }
        #endregion

        #region Functions.
        /// <summary>
        /// Changing groupBox appearing based on mainTreeView.
        /// </summary>
        void selectChange()
        {
            switch (mainTreeView.SelectedNode.Name)
            {
                case "GlobalNode":
                    globalGroupBox.Visible = true;
                    globalKeyGroupBox.Visible = false;
                    grabberGroupBox.Visible = false;
                    dateStampGroupBox.Visible = false;
                    facebookGroupBox.Visible = false;
                    directXGroupBox.Visible = false;
                    break;
                case "DateStampNode":
                    dateStampGroupBox.Visible = true;
                    globalGroupBox.Visible = false;
                    globalKeyGroupBox.Visible = false;
                    grabberGroupBox.Visible = false;
                    facebookGroupBox.Visible = false;
                    directXGroupBox.Visible = false;
                    break;
                case "KeyNode":
                    globalGroupBox.Visible = false;
                    globalKeyGroupBox.Visible = true;
                    grabberGroupBox.Visible = false;
                    dateStampGroupBox.Visible = false;
                    facebookGroupBox.Visible = false;
                    directXGroupBox.Visible = false;
                    break;
                case "GrabberNode":
                    globalGroupBox.Visible = false;
                    globalKeyGroupBox.Visible = false;
                    grabberGroupBox.Visible = true;
                    dateStampGroupBox.Visible = false;
                    facebookGroupBox.Visible = false;
                    directXGroupBox.Visible = false;
                    break;
                case "FacebookNode":
                    globalGroupBox.Visible = false;
                    globalKeyGroupBox.Visible = false;
                    grabberGroupBox.Visible = false;
                    dateStampGroupBox.Visible = false;
                    facebookGroupBox.Visible = true;
                    directXGroupBox.Visible = false;
                    break;
                case "DirectXNode":                    
                    globalGroupBox.Visible = false;
                    globalKeyGroupBox.Visible = false;
                    grabberGroupBox.Visible = false;
                    dateStampGroupBox.Visible = false;
                    facebookGroupBox.Visible = false;
                    directXGroupBox.Visible = true;
                    break;
            }
        }

        /// <summary>
        /// Setting a new global Hot-Key.
        /// </summary>
        public void updateGlobalKey()
        {
            try
            {
                Program.main.hotKeyLabel.Text = "Global hot key: ";
                Program.main.hotKeyLabel.Visible = false;
                if (MODComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Please select modifier.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    hotKeyLabel.Visible = false;
                    return;
                }
                if (Program.main.key == Keys.None)
                {
                    MessageBox.Show("Please select a key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    hotKeyLabel.Visible = false;
                    return;
                }

                Program.main.UnregisterGlobalHotKey();

                if (MODComboBox.SelectedItem.ToString() == "Alt")
                {
                    hotKeyLabel.Text = "Alt + ";
                    Program.main.modifier = 1;
                }
                else
                    if (MODComboBox.SelectedItem.ToString() == "Control")
                    {
                        hotKeyLabel.Text = "CTRL + ";
                        Program.main.modifier = 2;
                    }
                    else
                        if (MODComboBox.SelectedItem.ToString() == "Shift")
                        {
                            hotKeyLabel.Text = "Shift + ";
                            Program.main.modifier = 4;
                        }

                Program.main.RegisterGlobalHotKey(Program.main.key, Program.main.modifier);
                hotKeyLabel.Text += Program.main.key.ToString();
                Program.main.hotKeyLabel.Text += hotKeyLabel.Text;
                hotKeyLabel.Visible = true;
                Program.main.hotKeyLabel.Visible = true;
                Program.main.notifyIcon.Text = "Click " + MODComboBox.SelectedItem + "+" + Program.main.key.ToString() + " to grab a screenshot!";
                Settings.Default.Modifier = Program.main.modifier;
                Settings.Default.Key = Program.main.key;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        /// <summary>
        /// Displaying a short description when a checkbox checkd change.
        /// </summary>
        /// <param name="cb">The changed checkbox.</param>
        void CheckBoxLabelChanged(CheckBox cb)
        {
            switch (cb.Name)
            {
                case "autoCaptureCheckBox":
                    if (autoCaptureCheckBox.Checked)
                        detailsLabel.Text = "Everytime the program gain focus, it wil grab a snap.";
                    else
                        detailsLabel.Text = "A silent load of the program.(saves resources)";
                    break;
                case "stickyCheckBox":
                    if (stickyCheckBox.Checked)
                        detailsLabel.Text = "Main windows get sticked to the edges of the screen.";
                    else
                        detailsLabel.Text = "Check this if you want the main screen to sticked to screen edges.";
                    break;
                case "startupCheckBox":
                    if (startupCheckBox.Checked)
                        detailsLabel.Text = "The program will start with Windows.";
                    else
                        detailsLabel.Text = "Check this if you want ScreenGrabber to load with Windows.";
                    break;
                case "minimizedCheckBox":
                    if (minimizedCheckBox.Checked)
                        detailsLabel.Text = "The program will start minimized.";
                    else
                        detailsLabel.Text = "The program will start regullary.";
                    break;
                case "closeToTrayCheckBox":
                    if (closeToTrayCheckBox.Checked)
                        detailsLabel.Text = "The X button in the top right corner will minimize the program to the system tray.";
                    else
                        detailsLabel.Text = "The X button in the top right corner will shut down ScreenGrabber.";
                    break;
                case "saveSnapsCheckBox":
                    if (saveSnapsCheckBox.Checked)
                        detailsLabel.Text = "Every snap will saved in the database.";
                    else
                        detailsLabel.Text = "Only snaps you save in the disk will saved in the database.";
                    break;
                case "commentPopUpCheckBox":
                    if(commentPopUpCheckBox.Checked)
                        detailsLabel.Text = "After every snap the comment editor PopUp will appear.";
                    else
                        detailsLabel.Text = "Comment editor PopUp is off.";
                    break;
                default:
                    detailsLabel.Visible = false;
                    return;
            }
            detailsLabel.Visible = true;
        }

        /// <summary>
        /// Applying all settings.
        /// </summary>
        /// <returns>If operation success.</returns>
        bool applySettings()
        {
            try
            {
                Settings.Default.Sticky = stickyCheckBox.Checked;
                Settings.Default.CommentEditorPopUp = commentPopUpCheckBox.Checked;
                Settings.Default.PictureSum = sumNumericUpDown.Value;
                Settings.Default.grabberPosition = tempLocation;
                Settings.Default.grabberSize = tempSize;
                Settings.Default.FacebookService = service;
                Settings.Default.FacebookUser = me;
                Settings.Default.Save();
                Program.main.pathLabel.Text = "Saving to: " + pathTextBox.Text;
                Program.main.customCheckBox.Checked = customCheckBox.Checked;
                applyButton.Enabled = false;
                return true;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Couldn't save!\n\n" + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion

        private void authorizeButton_Click(object sender, EventArgs e)
        {
            userNameTextBox.Enabled = false;
            authorizeButton.Enabled = false;
            facebookProgressBarEx.MarqueeStart();
            facebookProgressBarEx.Visible = true;

            try
            {
                //if (service == null)
                //{
                    service = new FacebookService();
                    service.IsDesktopApplication = true;
                    service.ApplicationKey = "00d36cfe480479a5982206e2c5b1cfb7";
                    service.Secret = "d9a50c892615569bf5e24d3aeeef38d5";
                //}
                me = service.GetUserInfo();
                //if (me != null)
                //{
                
                    Settings.Default.FacebookService = service;
                    Settings.Default.FacebookUser = me;
                    userNameTextBox.Text = me.Name;
                    ProfilePictureBox.Image = me.Picture;
                    ProfilePictureBox.BorderStyle = BorderStyle.FixedSingle;
                    statusLabel.Text = "Authorized.";
                    statusLabel.Visible = true;
                    saveAll = true;
                //}
                //else
                //{
                //    statusLabel.Text = "Authorization faild.. please try again.";
                //    statusLabel.Visible = true;
                //    Settings.Default.FacebookUser = null;
                //    Settings.Default.FacebookService = null;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                statusLabel.Text = "Authorization faild.. please try again.";
                statusLabel.Visible = true;
                Settings.Default.FacebookUser = null;
                Settings.Default.FacebookService = null;
            }

            facebookProgressBarEx.MarqueeStop();
            facebookProgressBarEx.Visible = false;
            userNameTextBox.Enabled = true;
            authorizeButton.Enabled = true;
        }

        private void authorizeButton_MouseEnter(object sender, EventArgs e)
        {
            authorizeButton.BackgroundImage = Resources.FacebookAuthenticationButtonHighlighted;
        }

        private void authorizeButton_MouseLeave(object sender, EventArgs e)
        {
            authorizeButton.BackgroundImage = Resources.FacebookAuthenticationButton;
        }

        private void injectButton_Click(object sender, EventArgs e)
        {
            Program.dxGrabber.ProccessName = processNameComboBox.Text;
            Program.dxGrabber.AutoGAC = cbAutoGAC.Checked;
            try
            {
                Program.dxGrabber.Inject();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message+"\n\n"+ex.StackTrace,"Can't inject."); }
        }

        private void processNameComboBox_DropDown(object sender, EventArgs e)
        {
            processNameComboBox.DataSource = GetProcesseList();
        }
    }

    enum Corner { UpLeft = 0, UpRight = 1, BottomLeft = 2, BottomRight = 3 }
}