using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ChatClient
{
    public partial class signInFrm : Form
    {
        public signInFrm()
        {
            InitializeComponent();
        }

        private void signInFrm_Load(object sender, EventArgs e)
        {

        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            String userId = tbUserID.Text;
            String password = tbPassword.Text;
            if (tbUserID.Text.Trim() == "" || tbPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please enter your user id and the password", "Sign In Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else {
                //Form1 child = new Form1(); //create new isntance of form
                //child.FormClosed += new FormClosedEventHandler(child_FormClosed); //add handler to catch when child form is closed
                //child.Show(); //show child
                //this.Hide(); //hide parent
                String sessionKey = "";
                try
                {
                    sessionKey = GlobalConfig.ChatService.signIn(userId, password);
                    if (sessionKey == null)
                    {
                        MessageBox.Show("Incorrect UserID or Password", "Ow-chat", MessageBoxButtons.OK);
                        tbUserID.Text = "";
                        tbPassword.Text = "";
                        tbUserID.Focus();
                    }
                    else
                    {
                        GlobalConfig.SessionKey = sessionKey;
                        new frmMainWindow().Show();
                        this.Dispose();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sign In Error : " + ex.StackTrace);
                }

            }
        }

        
    }
}
