using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IWshRuntimeLibrary;

namespace ScreenGrabber
{
    public partial class ShortCutPage : Form
    {
        // Constructor.
        public ShortCutPage()
        {
            InitializeComponent();
            folderBrowserDialog1.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        #region Events.
        private void ShortCutPage_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.ScreenGrabber;
            shortCutNameTextBox.Text = shortCutNameTextBox.Text;
            pathLabel.Text = folderBrowserDialog1.SelectedPath + "\\" + shortCutNameTextBox.Text + ".lnk";
        }

        private void regularRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(regularRadioButton.Checked)
                shortCutNameTextBox.Text = "Launch ScreenGrabber";
            else
                shortCutNameTextBox.Text = "Take a Snap!";

            pathLabel.Text = folderBrowserDialog1.SelectedPath + "\\" + shortCutNameTextBox.Text + ".lnk";
        }

        private void shortCutNameTextBox_TextChanged(object sender, EventArgs e)
        {
            pathLabel.Text = folderBrowserDialog1.SelectedPath + "\\" + shortCutNameTextBox.Text + ".lnk";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                WshShellClass WshShell = new WshShellClass();
                IWshRuntimeLibrary.IWshShortcut shortCut = default(IWshRuntimeLibrary.IWshShortcut);

                shortCut = (IWshRuntimeLibrary.IWshShortcut)WshShell.CreateShortcut(folderBrowserDialog1.SelectedPath + "\\" + shortCutNameTextBox.Text + ".lnk");

                // shortcut properties
                shortCut.TargetPath = Application.ExecutablePath;
                shortCut.WindowStyle = 1;
                if(snapRadioButton.Checked)
                {
                    shortCut.Description = "Grab a snap shot from current screen using ScreenGrabber.";
                    // the next line sets a new argument so the program will know next time
                    // that the user only want to grab the screen
                    // which will be read from the command line.
                    shortCut.Arguments = "snap";
                }
                else
                    shortCut.Description = "Launch ScreenGrabber.";
                shortCut.WorkingDirectory = folderBrowserDialog1.SelectedPath;
                // the next line gets the first Icon from the executing program
                shortCut.IconLocation = Application.ExecutablePath + ", 0";
                shortCut.Save();

                pathLabel.Text = "Shortcut saved successfuly at:" + Environment.NewLine + folderBrowserDialog1.SelectedPath + "\\" + shortCutNameTextBox.Text + ".lnk";
            }
            catch(Exception ex)
            {
                MessageBox.Show("There were a problem saving your Shortcut.\n\n"+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void folderButton_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() != DialogResult.OK)
                return;
            pathLabel.Text = folderBrowserDialog1.SelectedPath + "\\" + shortCutNameTextBox.Text + ".lnk";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}