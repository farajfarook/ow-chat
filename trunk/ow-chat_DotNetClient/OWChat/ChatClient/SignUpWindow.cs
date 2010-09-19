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
    public partial class frmSignUpWindow : Form
    {
        bool signUpDone = false;

        public frmSignUpWindow()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if ( (tbUserName.Text.Trim()=="") || 
                (tbConfPassword.Text.Trim()=="") || 
                (tbPassword.Text.Trim()=="") )
            {
                MessageBox.Show("User name or password cannot be empty.");
                tbConfPassword.Text = "";
                tbPassword.Text = "";
                tbUserName.SelectAll();
                tbUserName.Focus();
                return;
            }

            if ((!tbPassword.Text.Equals(tbConfPassword.Text)))
            {
                MessageBox.Show("Password confirmation failed.");
                tbPassword.Text = "";
                tbConfPassword.Text = "";
                tbPassword.Focus();
                return;
            }

            this.Text = this.Text + " : Please wait...";
            this.Enabled = false;
            bool result,gotRes;
            try
            {
                GlobalConfig.ChatService.registerUser(tbUserName.Text.ToLower(), tbConfPassword.Text.ToLower(), out result, out gotRes);
                //MessageBox.Show("@Return : " + result);
                //MessageBox.Show("GotRes : " + gotRes);
                if (!result)
                {
                    MessageBox.Show("User already registered.");
                    this.Enabled = true;
                    tbPassword.Text = "";
                    tbConfPassword.Text = "";
                    tbUserName.SelectAll();
                }
                else
                {
                    signUpDone = true;
                    String key = GlobalConfig.ChatService.signIn(tbUserName.Text.ToLower(), tbConfPassword.Text.ToLower());
                    if (key == null)
                    {
                        MessageBox.Show("Failed to SignIn. Please Try again");
                        new frmSignInWindow().Show();
                        this.Dispose();
                    }
                    else
                    {
                        GlobalConfig.SessionKey = key;
                        GlobalConfig.DisplayName = tbUserName.Text;
                        GlobalConfig.UserSignedIn = true;
                        GlobalConfig.mainWindow.Enabled = true;
                        GlobalConfig.mainWindow.Focus();
                        GlobalConfig.mainWindow.initializeMainChatWindow();
                        this.Dispose();
                    }

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("SignUp Error : " + ex.Message, "ow-chat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Enabled = true;
                tbPassword.Text = "";
                tbConfPassword.Text = "";
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            signUpDone = false;
            this.Close();
        }

        private void tbConfPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btnSignup_Click(null, null);
        }

        private void frmSignUpWindow_Load(object sender, EventArgs e)
        {

        }

        private void frmSignUpWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!signUpDone)
            {
                new frmSignInWindow().Show();
            }
        }


    }
}
