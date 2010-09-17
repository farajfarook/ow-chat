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
    public partial class MessageFrm : Form
    {

        private String sFriendName;     // name of the friend
        
        //** chat service reference is  at GlobalConfig.ChatService 
        // eg: to call sendMessage method use GlobalConfig.ChatService.sendMessage()

        private Font selectedFont;
        public bool frn, msg;    
        // Constructor is modified******
        // When creating an instance from this class, it is a must to give a name of the person
        // at the other end
        public MessageFrm(String friendName)
        {
            InitializeComponent();
            
            this.sFriendName = friendName;
        }


        private void sendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (sendMsgRtb.Text.Trim().Length > 0 || sendMsgRtb.Rtf.Trim().Length > 130)
                {
                   
                    //chat.sendMessage(Form1.Me,sendMsgRtb.Rtf,user);
                    //GlobalConfig.ChatService.sendMessage(sFriendName, sendMsgRtb.Rtf,Form1.Me, out frn, out msg);
                    messageRtb.SelectedText= GlobalConfig.DisplayName +": ";  //Set DisplayName in the main window
                    messageRtb.SelectedRtf=sendMsgRtb.Rtf;
                    messageRtb.ScrollToCaret();
                    sendMsgRtb.Clear();
                    sendMsgRtb.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
         }

        private void MessageFrm_Load(object sender, EventArgs e)
        {
            //timer1.Enabled = true;    Enable this if its not for receiving mesgs
            panelEmoticons.Visible = false;
            //chat.Url = "http://" + Form1.strServiceIP + "/ChatService.asmx";
            sendMsgRtb.Focus();
        }

       



#region Emoticons Section

		private void btnSmile_Click_1(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(btnSmile.BackgroundImage);
            Clipboard.Clear();
            Clipboard.SetDataObject(img);
            DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);
            sendMsgRtb.Paste(myFormat);             
            panelEmoticons.Visible = false;
            img.Dispose();
        }

        private void btnSad_Click_1(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(btnSad.BackgroundImage);
            Clipboard.Clear();
            Clipboard.SetDataObject(img);
            DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);
            sendMsgRtb.Paste(myFormat);            
            panelEmoticons.Visible = false;
            img.Dispose();
        }

        private void btnWink_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(btnWink.BackgroundImage);
            Clipboard.Clear();
            Clipboard.SetDataObject(img);
            DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);
            sendMsgRtb.Paste(myFormat);
            panelEmoticons.Visible = false;
            img.Dispose();
        }

        private void btnCry_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(btnCry.BackgroundImage);
            Clipboard.Clear();
            Clipboard.SetDataObject(img);
            DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);
            sendMsgRtb.Paste(myFormat);
            panelEmoticons.Visible = false;
            img.Dispose();
        }

        private void btnTon_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(btnTon.BackgroundImage);
            Clipboard.Clear();
            Clipboard.SetDataObject(img);
            DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);
            sendMsgRtb.Paste(myFormat);
            panelEmoticons.Visible = false;
            img.Dispose();
        }

        private void btnWave_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(btnWave.BackgroundImage);
            Clipboard.Clear();
            Clipboard.SetDataObject(img);
            DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);
            sendMsgRtb.Paste(myFormat);
            panelEmoticons.Visible = false;
            img.Dispose();
        }

        private void btnClock_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(btnClock.BackgroundImage);
            Clipboard.Clear();
            Clipboard.SetDataObject(img);
            DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);
            sendMsgRtb.Paste(myFormat);
            panelEmoticons.Visible = false;
            img.Dispose();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(btnX.BackgroundImage);
            Clipboard.Clear();
            Clipboard.SetDataObject(img);
            DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);
            sendMsgRtb.Paste(myFormat);
            panelEmoticons.Visible = false;
            img.Dispose();
        } 
#endregion


        private void btnColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            sendMsgRtb.ForeColor = colorDialog1.Color;
            sendMsgRtb.Focus();
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            selectedFont = new Font(fontDialog1.Font.Name, fontDialog1.Font.Size, fontDialog1.Font.Style);
            sendMsgRtb.Font = selectedFont;
            sendMsgRtb.Focus();
            selectedFont.Dispose();
        }



        // if the time is for receiving msgs, u dont have to use it here. 
        // Main window will call this method once it has a message for this chat window

        public void receiveMessage(String message)
        {
            //you got a chat message from the other end..
            //display it in the window as appropriate
           
            
        }

               

        private void timer1_Tick(object sender, EventArgs e)
        {
        try
            {
                if (Form1.Mess.Trim().Length > 0)
                {
                    string[] strU = Form1.Mess.Split(':');
                    string strM = string.Empty;
                    if (strU[0] == sFriendName)
                    {
                        for (int i = 1; i < strU.Length; i++)
                        {
                            strM = strM + strU[i];
                        }
                        messageRtb.SelectedText = strU[0] + ": ";
                        messageRtb.SelectedRtf = strM;
                        Form1.Mess = "";
                        messageRtb.ScrollToCaret();
                        
                    }
                }
        }
            catch (Exception exx)
            {
                MessageBox.Show("Error in connecting to the chat server.");
            }
        }

        private void btnEmo_Click(object sender, EventArgs e)
        {
            panelEmoticons.Visible = true;

        }

        

        private void sendMsgRtb_KeyDown(object sender, KeyEventArgs e)
        {
            if (sendMsgRtb.Text.Trim()=="")
                return;
            if (e.KeyCode == Keys.Return)
                sendBtn_Click(null,null);

        }

        private void messageRtb_TextChanged(object sender, EventArgs e)
        {
           // messageRtb.Rtf = GlobalConfig.RecieveMsg();
        }

        
       

        private void Imvironment_Click(object sender, EventArgs e)
        {

               
      OpenFileDialog dlg = new OpenFileDialog();
  
      dlg.Title = "Open bitmap or jpeg.";
  
      //dlg.Filter = "jpg files (*.jpg);*.jpg;*.* | bmp files (*.bmp); *.bmp";
 
       
 
      if (dlg.ShowDialog() == DialogResult.OK)

      {
   
      this.pictureBox1.Image= new Bitmap(dlg.OpenFile());

      }
 
      dlg.Dispose();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                System.Console.Beep();

                messageRtb.SelectionFont = new Font("Verdana", 12, FontStyle.Bold);
                messageRtb.SelectionColor = Color.Red;
                messageRtb.SelectedText = "BEEP!!!" + Environment.NewLine;
                messageRtb.SelectionFont = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
                messageRtb.SelectionColor = Color.Black;
                //messageRtb.ForeColor = System.Drawing.Color.Red;
                //messageRtb.Font.Size=16;
            
          }

            
    }
}
