using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChatClient
{
    public partial class frmAddFriendWindow : Form
    {
        public frmAddFriendWindow()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Height = 310;
            MessageBox.Show("User searching not yet implemented");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbFriendName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter your friends name.", "ow-chat", MessageBoxButtons.OK);
                tbFriendName.Focus();
            }
            else
            {
                this.Text = this.Text + " : Please wait...";
                this.Enabled = false;
                bool result,gotRes;
                try
                {
                    GlobalConfig.ChatService.addAsFriend(tbFriendName.Text, GlobalConfig.SessionKey, out result, out gotRes);
                    if (result)
                    {
                        MessageBox.Show("Ow-chat user " + tbFriendName.Text + " added as a friend of you.", "ow-chat");
                        GlobalConfig.mainWindow.userLoggedIn();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Error adding friend. please try again.", "ow-chat");
                        this.Dispose();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Add Friend Error : "  + ex.Message, "ow-chat");
                    this.Dispose();
                }
                


            }
        }
    }
}
