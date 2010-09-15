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
            String userId = "";
            String password = "";
            if (userIdTxt.Text == "" || passwordTxt.Text == "")
            {
                MessageBox.Show("Please enter your user id and the password", "Sign In Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else {
                userId = userIdTxt.Text;
                password = passwordTxt.Text;
                //connect to the server and varify the userid and the password
                //if correct go to the main window
                Form1 child = new Form1(); //create new isntance of form
                child.FormClosed += new FormClosedEventHandler(child_FormClosed); //add handler to catch when child form is closed
                child.Show(); //show child
                this.Hide(); //hide parent
            }
        }
        void child_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
