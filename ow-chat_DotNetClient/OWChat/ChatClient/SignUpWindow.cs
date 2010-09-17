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
        public frmSignUpWindow()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (tbUserName.Text.Trim()=="") || (!tbPassword.Text.Equals(tbConfPassword.Text) || (tbConfPassword.Text.Trim()=="") ||
        }
    }
}
