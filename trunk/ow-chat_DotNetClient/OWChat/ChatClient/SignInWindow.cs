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
            
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            String userId = tbUserID.Text.ToLower();
            String password = tbPassword.Text.ToLower();
            if (tbUserID.Text.Trim() == "" || tbPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please enter your user id and the password", "Sign In Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else {
                String sessionKey = "";
                this.Text += " : Signing in...";
                this.Enabled = false;
                try
                {
                    sessionKey = GlobalConfig.ChatService.signIn(userId, password);
                    if (sessionKey == null)
                    {
                        MessageBox.Show("Incorrect UserID or Password", "Ow-chat", MessageBoxButtons.OK);
                        tbUserID.Text = "";
                        tbPassword.Text = "";
                        tbUserID.Focus();
                        this.Text = "OW-Chat";
                        this.Enabled = true;
                    }
                    else
                    {
                        GlobalConfig.SessionKey = sessionKey;
                        GlobalConfig.DisplayName = tbUserID.Text;
                        GlobalConfig.UserSignedIn = true;
                        GlobalConfig.mainWindow.Enabled = true;
                        GlobalConfig.mainWindow.initializeMainChatWindow();
                        this.Dispose();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sign In Error : " + ex.Message,"ow-chat",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    tbUserID.Text = "";
                    tbPassword.Text = "";
                    
                    tbUserID.SelectAll();
                    tbUserID.Focus();
                    this.Text = "OW-Chat";
                    this.Enabled = true;
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                bool val;
                GlobalConfig.ChatService.resetChatServer(out val, out val);
                if (val)
                    MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

        }

        private void frmSignInWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!GlobalConfig.UserSignedIn)
            {
                Application.Exit();
            }

        }
               
    }
}
