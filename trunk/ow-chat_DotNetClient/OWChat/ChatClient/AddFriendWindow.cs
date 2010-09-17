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
            if (tbFriendName.Text.Trim() == "")
                return;
            if (tbFriendName.Text.TrimEnd().ToLower() == GlobalConfig.DisplayName.ToLower())
                return;
            this.Height = 340;
            btnCancel.Location = new Point(200, 276);
            btnAdd.Location = new Point(119, 276);
            btnSearch.Location = new Point(200, 52);
            try
            {
                String[] users = GlobalConfig.ChatService.searchUser(tbFriendName.Text);
                foreach (String name in users)
                {
                    lbUsers.Items.Add(name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search Error : " + ex.Message,"ow-chat",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Dispose();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbFriendName.Text.TrimEnd().ToLower() == GlobalConfig.DisplayName.ToLower())
            {
                MessageBox.Show("You cannot add your self as a friend.","ow-chat", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                tbFriendName.SelectAll();
                return;
            }

            if (tbFriendName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter your friends name.", "ow-chat", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
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
                        GlobalConfig.mainWindow.loadFriendsList();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Error adding friend. please try again.", "ow-chat",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        this.Dispose();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Add Friend Error : " + ex.Message, "ow-chat",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    this.Dispose();
                }
                


            }
        }

        private void lbUsers_MouseDown(object sender, MouseEventArgs e)
        {
            tbFriendName.Text = lbUsers.Items[lbUsers.SelectedIndex].ToString();
        }
    }
}
