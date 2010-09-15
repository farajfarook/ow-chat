using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


        // PLEASE USE DESCRIPTIVE NAMES FOR VARIABLES

        /*     Things to do **********
         *      1. Make a nice user interface
         *      2. Create a new form for user login
         *      3. in that form, when the user presses the login button
         *          invoke the GlobalConfig.ChatServer.SignIn() method with 
         *          proper parameters
         *          If the return type is null,invalid password or username
         *          If you sucessfully received a String, then assign it to GlobalConfig.SessionKey
         *      4. Load the main window and dispose the login window
         *      5. Get the friends list from the server and initialize friends[]
         *      6. Display the list in the window
         *      7. An array of Windwos references is created below
         *      8. initialize it with the correct number of objects ( chatWindows = new Form[noOfFriends]; )
         *      9. 
         *      5. Important**
         *          1. You have to add a background 
         * 
         * 
         */

namespace ChatClient
{
    public partial class Form1 : Form
    {
        //string line;
        ////get the current user list
        //string[] users = { "Anya", "Madhu" };
        static public string Me = string.Empty;
        static public string Mess = string.Empty;

        // ****** want to access the web service? use GlobalConfig.ChatServer  ************
        // eg: registerUser function - GlobalConfig.ChatServer.registerUser();

        private Form[] chatWindows;
        private String[] friends;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            GlobalConfig.DisplayName = "CurrentUser";  //****** once the user logged in, assign his name to DisplayName

            timer1.Enabled = true;
            bool registerResult;
            //chatService.registerUser("Hero", "123",out registerResult,out registerResult);
            MessageFrm msg = new MessageFrm("Her");
            msg.Show();
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

        private void bgwMessageListener_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                //wait for incomming messages
                //receive messages
                //dispatch them to the correct chat window
                //repeat
            }
        }

     }
}
