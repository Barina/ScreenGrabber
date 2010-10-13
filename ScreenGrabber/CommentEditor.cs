using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScreenGrabber
{
    public partial class CommentEditor : Form
    {
        public string Comment
        {
            get;
            set;
        }
        private bool noComment;
        public CommentEditor(Image snap, string comment)
        {
            InitializeComponent();
            previewPictureBox.Image = snap;
            CommentTextBox.Text = comment;
            if (noComment = (comment == "" || comment == null))
            {
                CommentTextBox.Text = "Write your comment here.";
                CommentTextBox.ForeColor = Color.Gray;
            }
        }
        public CommentEditor(Image snap) : this(snap, "") { }

        private void CommentTextBox_Enter(object sender, EventArgs e)
        {
            if (noComment)
            {
                CommentTextBox.Text = "";
                CommentTextBox.ForeColor = Color.Black;
                noComment = false;
            }
        }

        private void CommentTextBox_Leave(object sender, EventArgs e)
        {
            if (noComment = CommentTextBox.Text == "")
            {
                CommentTextBox.Text = "Write your comment here.";
                CommentTextBox.ForeColor = Color.Gray;
            }
        }

        private void CommentEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (noComment)
                Comment = "";
            else
                Comment = CommentTextBox.Text;
        }

        private void CommentTextBox_TextChanged(object sender, EventArgs e)
        {
            if (noComment || CommentTextBox.Text.Length==0)
                detailsLabel.Text = "Here you can set a comment to your snap, or leve empty.";
            else
                detailsLabel.Text = CommentTextBox.Text.Length+"/"+CommentTextBox.MaxLength+" Charecters allowed.";
        }

        private void deleteCommentButton_Click(object sender, EventArgs e)
        {
            noComment = true;
            Close();
        }

        private void CommentTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                okButton.PerformClick();
        }
    }
}
