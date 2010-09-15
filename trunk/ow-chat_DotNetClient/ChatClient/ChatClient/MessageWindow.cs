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
        public MessageFrm()
        {
            InitializeComponent();
        }
        OWChatServiceReference chat = new OWChatServiceReference(new URL("http://localhost:8081/OwChat/OWChatService?wsdl"));
        //ow-chat chat = new ow-chat();
        private string user;
        private Font font;

        private void sendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (sendMsgRtb.Text.Trim().Length > 0 || sendMsgRtb.Rtf.Trim().Length > 130)
                {
                    chat.sendMessage(Form1.Me,sendMsgRtb.Rtf,user);
                    messageRtb.SelectedText=Form1.Me+": ";
                    messageRtb.SelectedRtf=sendMsgRtb.Rtf;
                    messageRtb.ScrollToCaret();
                    sendMsgRtb.Clear();
                    sendMsgRtb.Focus();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Server is down.Tty again");
            }
         }

        private void MessageFrm_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            Text = user;
            panel1.Visible = false;
            //chat.Url = "http://" + Form1.strServiceIP + "/ChatService.asmx";
            sendMsgRtb.Focus();
        }

       

        
        private void btnSmile_Click_1(object sender, EventArgs e)
        {
        Bitmap img = new Bitmap(btnSmile.BackgroundImage);
            Clipboard.Clear();
            Clipboard.SetDataObject(img);
            DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);
            sendMsgRtb.Paste(myFormat);             
            panel1.Visible = false;
            img.Dispose();
        }

        private void btnSad_Click_1(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(btnSad.BackgroundImage);
            Clipboard.Clear();
            Clipboard.SetDataObject(img);
            DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);
            sendMsgRtb.Paste(myFormat);            
            panel1.Visible = false;
            img.Dispose();
        }

        private void btnWink_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(btnWink.BackgroundImage);
            Clipboard.Clear();
            Clipboard.SetDataObject(img);
            DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);
            sendMsgRtb.Paste(myFormat);
            panel1.Visible = false;
            img.Dispose();
        }

        private void btnCry_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(btnCry.BackgroundImage);
            Clipboard.Clear();
            Clipboard.SetDataObject(img);
            DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);
            sendMsgRtb.Paste(myFormat);
            panel1.Visible = false;
            img.Dispose();
        }

        private void btnTon_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(btnTon.BackgroundImage);
            Clipboard.Clear();
            Clipboard.SetDataObject(img);
            DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);
            sendMsgRtb.Paste(myFormat);
            panel1.Visible = false;
            img.Dispose();
        }

        private void btnWave_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(btnWave.BackgroundImage);
            Clipboard.Clear();
            Clipboard.SetDataObject(img);
            DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);
            sendMsgRtb.Paste(myFormat);
            panel1.Visible = false;
            img.Dispose();
        }

        private void btnClock_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(btnClock.BackgroundImage);
            Clipboard.Clear();
            Clipboard.SetDataObject(img);
            DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);
            sendMsgRtb.Paste(myFormat);
            panel1.Visible = false;
            img.Dispose();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(btnX.BackgroundImage);
            Clipboard.Clear();
            Clipboard.SetDataObject(img);
            DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);
            sendMsgRtb.Paste(myFormat);
            panel1.Visible = false;
            img.Dispose();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            sendMsgRtb.ForeColor = colorDialog1.Color;
            sendMsgRtb.Focus();
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            font = new Font(fontDialog1.Font.Name, fontDialog1.Font.Size, fontDialog1.Font.Style);
            sendMsgRtb.Font = font;
            sendMsgRtb.Focus();
            font.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        try
            {
                if (Form1.Mess.Trim().Length > 0)
                {
                    string[] strU = Form1.Mess.Split(':');
                    string strM = string.Empty;
                    if (strU[0] == user)
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
            catch (Exception e)
            {
                MessageBox.Show("Error in connecting to the chat server.");
            }
        }

        

        

            
    }
}
