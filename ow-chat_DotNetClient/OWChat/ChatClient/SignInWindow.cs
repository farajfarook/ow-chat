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
    public partial class frmSignInWindow : Form
    {
        public frmSignInWindow()
        {
            InitializeComponent();
        }

        private void signInFrm_Load(object sender, EventArgs e)
        {
            //new frmMessageWindow("temp").Show();      // for testing
            bool val;
            //GlobalConfig.ChatService.resetChatServer(out val, out val);
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
                        GlobalConfig.DisplayName = tbUserID.Text;
                        GlobalConfig.mainWindow.Enabled = true;
                        this.Dispose();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sign In Error : " + ex.Message);
                }

            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            frmSignUpWindow signUp = new frmSignUpWindow();
            signUp.Show();
            this.Dispose();
        }

        private void tbPassword_MouseDown(object sender, MouseEventArgs e)
        {
     
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Return)
                signInBtn_Click(null, null);

        }


        
    }
}
