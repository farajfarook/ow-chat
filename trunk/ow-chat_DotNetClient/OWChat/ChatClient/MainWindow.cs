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
 *          invoke the GlobalConfig.ChatService.SignIn() method with 
 *          proper parameters
 *          If the return type is null,invalid password or username
 *          If you sucessfully received a String, then assign it to GlobalConfig.SessionKey
 *          After the loging process, save the user ID in GlobalConfig.DisplayName
 *      4. Load the main window and dispose the login window
 *      5. Get the friends list from the server and initialize friends[]
 *      6. Display the list in the window
 *      7. An array of Windwos references is created below. 
 *          initialize it with the correct number of objects ( chatWindows = new Form[noOfFriends]; )
 *      8. Important**
 *          1. I've Added a background worker for you :P bgwMessageListener
 *          2. Check its DoWork method
 *          3. receiveMessage web method will return OWChatService.message[]
 *          4. get them to an array and check the senders name (you may get more than one message,dats why)
 *          5. Each MessageWindow contains a function called ReceiveMessage(String message)
 *          6. Now you have a list of friends, and a list of chat windows.
 *          7. get the offest of friends array by the sender name of the received message
 *          8. check whether chatWindows[obtained offest] is null or not
 *          9. If it is null, create a MessageWindow object and assing to it
 *          10. make that window visible
 *          11. call that window's receiveMessage function and send the message you got
 *          12. If that perticular MessageWindow is not null, just call the receiveMessage function
 * 
 */

namespace ChatClient
{
    public partial class frmMainWindow : Form
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

        public frmMainWindow()
        {
            InitializeComponent(); 
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //GlobalConfig.DisplayName = "CurrentUser";  //****** once the user logged in, assign his name to DisplayName

            timer1.Enabled = true;
            bool registerResult;
            //chatService.registerUser("Hero", "123",out registerResult,out registerResult);
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
