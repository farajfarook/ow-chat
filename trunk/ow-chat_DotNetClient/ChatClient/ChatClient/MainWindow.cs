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
    public partial class Form1 : Form
    {
        //string line;
        ////get the current user list
        //string[] users = { "Anya", "Madhu" };
        static public string Me = string.Empty;
        static public string Mess = string.Empty;

        OWChatService.OWChatService chatService;      // ************

        


        public Form1()
        {
            InitializeComponent();
            chatService = new ChatClient.OWChatService.OWChatService(); //*****************
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            bool registerResult;
            chatService.registerUser("Hero", "123",out registerResult,out registerResult);
        }

        private void userListView_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    updateUserList();
        //    //MessageBox.Show(line);
        //}

        //private void updateUserList()
        //{
        //    string[] lines = System.IO.File.ReadAllLines(@"D:\SLIIT\2nd Semester\EAD\Assignment3\ChatClient\ChatClient\bin\Debug\userList.txt");
        //    int iUserCnt = 0;
        //    iUserCnt = String.Compare(lines, users);
        //    if (iUserCnt != 0)
        //    {
        //        foreach (string l in lines)
        //        {

        //        }
        //    }
        

        private void signToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

     }
}
