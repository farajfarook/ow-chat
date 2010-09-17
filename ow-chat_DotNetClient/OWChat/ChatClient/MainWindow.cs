using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using System.Threading;


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

        static private frmMessageWindow[] chatWindows;
        private String[] friends;
        private bool[] friendStatus;

        public frmMainWindow()
        {
            InitializeComponent(); 
        }

        public void loadFriendsList()
        {
            lvFriends.Items.Clear();

            String[] friendsList = GlobalConfig.ChatService.getAllFriends(GlobalConfig.SessionKey);
            if (friendsList != null)
            {
                this.friends = new string[friendsList.Length];
                this.friendStatus = new bool[friendsList.Length];

                for (int i = 0; i < friendsList.Length; i++)
                {
                    string[] values = splitUserInformation(friendsList[i]);
                    this.friends[i] = values[0];
                    this.friendStatus[i] = Boolean.Parse(values[3]);
                }
            }

            for (int i = 0; i < friends.Length; i++)
            {
                
                if (friendStatus[i])
                {
                    lvFriends.Items.Add(friends[i]);
                    lvFriends.Items[lvFriends.Items.Count - 1].ImageIndex = 3;
                }
                else
                {
                    lvFriends.Items.Add(friends[i] + " - offline");
                    lvFriends.Items[lvFriends.Items.Count - 1].ImageIndex = 4;
                }
                
            }

            chatWindows = new frmMessageWindow[friends.Length];

            if (!bgwMessageListener.IsBusy)
            {
                bgwMessageListener.RunWorkerAsync();
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Enabled = false;
            
            //GlobalConfig.DisplayName = "CurrentUser";  //****** once the user logged in, assign his name to DisplayName

            //timer1.Enabled = true;
            //bool registerResult;
            //chatService.registerUser("Hero", "123",out registerResult,out registerResult);
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
            OWChatService.message[] incommingMsgs = null;
            while (true)
            {
                if (!GlobalConfig.UserSignedIn)
                {
                    break;
                }
                try
                {
                    //System.Console.Beep();
                    incommingMsgs = GlobalConfig.ChatService.receiveMessages(GlobalConfig.SessionKey);
                    if (incommingMsgs != null)
                    {
                        for (int i = 0; i < incommingMsgs.Length; i++)
                        {
                            for (int j = 0; j < friends.Length; j++)
                            {
                                if (friends[j] == incommingMsgs[i].from)
                                {
                                    sendMessageToChatWindow(j, incommingMsgs[i].body);
                                    //ThreadStart tStart = delegate { sendMessageToChatWindow(j, incommingMsgs[0].body); };
                                    //Thread newThread = new Thread(tStart);
                                    //newThread.Start();
                                    break;
                                }
                            }
                        }
                        //for (int j = 0; j < friends.Length; j++)
                        //{
                        //    if (friends[j] == incommingMsgs[0].from)
                        //    {
                        //        //ThreadStart tStart = delegate { sendMessageToChatWindow(j, incommingMsgs[0].body); }; 
                        //        //Thread newThread = new Thread(tStart);
                        //        //newThread.Start();
                        //        MessageBox.Show("Received : " + incommingMsgs[0].body);
                        //        sendMessageToChatWindow(j, incommingMsgs[0].body);
                        //        break;
                        //    }
                        //}

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Receiving Error : " + ex.Message);
                    throw;
                }
                System.Threading.Thread.Sleep(2000);
            }
        }

        private void sendMessageToChatWindow(int windowNo,String msgBody)
        {
            String friendName = friends[windowNo];
            if (chatWindows[windowNo] == null)
            {
                chatWindows[windowNo] = new frmMessageWindow(friendName);
            }
            else
            {
                if (chatWindows[windowNo].IsDisposed)
                    chatWindows[windowNo] = new frmMessageWindow(friendName);
            }
            if (chatWindows[windowNo].Visible==false)
            {
                chatWindows[windowNo].ShowDialog();
            }
            chatWindows[windowNo].receiveMessage(msgBody);
            chatWindows[windowNo].Refresh();
            chatWindows[windowNo].BringToFront();
            chatWindows[windowNo].Focus();
        }

        private void frmMainWindow_Shown(object sender, EventArgs e)
        {
            frmSignInWindow signInWindow = new frmSignInWindow();
            signInWindow.Show();
            signInWindow.BringToFront();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            userSignOut();
            GlobalConfig.mainWindow.Enabled = false;
            new frmSignInWindow().Show();         

        }

        private bool userSignOut()
        {
            bool result, gotRes;
            try
            {
                GlobalConfig.ChatService.signOut(GlobalConfig.SessionKey, out result, out gotRes);
                if (result)
                {
                    GlobalConfig.UserSignedIn = false;
                    return result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SignOut Error : " + ex.Message);
            }
            return false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new frmAddFriendWindow().Show();
        }

        private void addFriendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAdd_Click(null, null);
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSignOut_Click(null, null);
        }

        private void frmMainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Text = this.Text + " : Signing out..";
            if (GlobalConfig.UserSignedIn)
            {
                userSignOut();
            }
        }

        private String[] splitUserInformation(String text)
        {
            return text.Split(new char[] { ' ' });
        }

        private void lvFriends_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int offest = lvFriends.SelectedIndices[0];

            if (!friendStatus[offest])
            {
                //return // temp disabled
            }

            if (chatWindows[offest] == null)
            {
                chatWindows[offest] = new frmMessageWindow(friends[offest]);
            }
            else
            {
                if (chatWindows[offest].IsDisposed)
                    chatWindows[offest] = new frmMessageWindow(friends[offest]);
            }
            chatWindows[offest].Show();
            chatWindows[offest].BringToFront();
            chatWindows[offest].Focus();
            
        }

        private void lvFriends_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(runT));
            t.IsBackground = true;
            t.Start();
            
        }

        private void runT()
        {
            new frmMessageWindow().ShowDialog();
            //Thread.CurrentThread.Join();
        }


     }


}
