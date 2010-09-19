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

namespace ChatClient
{
    public partial class frmMainWindow : Form
    {

        static private frmMessageWindow[] chatWindows;
        private String[] friends;
        private bool[] friendStatus;
        private Thread messageListenerThread;

        private delegate void sendMessageDelegate(int fNo, String msg);

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
                    this.friendStatus[i] = Boolean.Parse(values[1]);
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

                if (messageListenerThread==null)
                {
                    messageListenerThread = new Thread(new ThreadStart(runMessageListener));
                    messageListenerThread.IsBackground = true;
                    messageListenerThread.Start();
                }
                this.Text = "Ow-Chat ~ [" + GlobalConfig.DisplayName + "]";
            }
        }

        private void frmMainWindow_Load(object sender, EventArgs e)
        {
            this.Enabled = false;
            OWChatSoundPlayer.loadSoundResources();
        }


        private void runMessageListener()
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
                    incommingMsgs = GlobalConfig.ChatService.receiveMessages(GlobalConfig.SessionKey);
                    if (incommingMsgs != null)
                    {
                        for (int i = 0; i < incommingMsgs.Length; i++)
                        {
                            for (int j = 0; j < friends.Length; j++)
                            {
                                if (friends[j] == incommingMsgs[i].from)
                                {
                                    sendMessageCallback sndMsg = new sendMessageCallback(sendMessageToChatWindow);
                                    Object[] values = new Object[2];
                                    values[0] = j;
                                    values[1] = incommingMsgs[i].body;
                                    this.Invoke(sndMsg, values);
                                    break;
                                }
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Receiving Error : " + ex.Message, "ow-chat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                System.Threading.Thread.Sleep(500);
            }
        }

        private void bgwMessageListener_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private delegate void sendMessageCallback(int windowNo, String msg);

        private void sendMessageToChatWindow(int windowNo, String msgBody)
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
            if (chatWindows[windowNo].Visible == false)
            {
                chatWindows[windowNo].Show();
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
            GlobalConfig.UserSignedIn = false;
            GlobalConfig.mainWindow.lvFriends.Clear();
            GlobalConfig.mainWindow.Text = "Ow-Chat";
            GlobalConfig.mainWindow.Enabled = false;
            new frmSignInWindow().Show();

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
                Thread closeThread = new Thread(new ThreadStart(userSignOut));
                closeThread.Start();
                closeThread.Join(2000);
            }
        }

        private void userSignOut()
        {
            try
            {
                bool result;
                GlobalConfig.ChatService.signOut(GlobalConfig.SessionKey, out result, out result);
                messageListenerThread.Suspend();
                messageListenerThread = null;
            }
            catch ( Exception ex)
            {
                MessageBox.Show("SignOut Error : " + ex.Message, "ow-chat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private String[] splitUserInformation(String text)
        {
            return text.Split(new char[] { ' ' });
        }

        private void lvFriends_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvFriends.SelectedIndices.Count==0)
            {
                return;
            }

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

         private void removeFriendToolStripMenuItem_Click(object sender, EventArgs e)
         {
             DialogResult result = MessageBox.Show("Are you sure you want to remove " + lvFriends.SelectedItems[0].Text + " from your friends list?", "ow-chat", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
             if (result==DialogResult.Yes)
             {
                 bool res,gotRes;
                 GlobalConfig.ChatService.removeFromFriends(friends[lvFriends.SelectedIndices[0]], GlobalConfig.SessionKey, out res, out gotRes);
                 if (res)
                 {
                     MessageBox.Show("Friend Removed","ow-chat",MessageBoxButtons.OK,MessageBoxIcon.Information);
                     loadFriendsList(); 
                 }

             }
         }
    }

}
