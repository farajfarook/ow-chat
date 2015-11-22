namespace ChatClient
{
    partial class frmMessageWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessageWindow));
            this.messageRtb = new System.Windows.Forms.RichTextBox();
            this.sendMsgRtb = new System.Windows.Forms.RichTextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.panelEmoticons = new System.Windows.Forms.Panel();
            this.btnX = new System.Windows.Forms.Button();
            this.btnClock = new System.Windows.Forms.Button();
            this.btnWave = new System.Windows.Forms.Button();
            this.btnTon = new System.Windows.Forms.Button();
            this.btnCry = new System.Windows.Forms.Button();
            this.btnWink = new System.Windows.Forms.Button();
            this.btnSad = new System.Windows.Forms.Button();
            this.btnSmile = new System.Windows.Forms.Button();
            this.btnEmo = new System.Windows.Forms.Button();
            this.btnFormat = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Profile = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.bgwSender = new System.ComponentModel.BackgroundWorker();
            this.panelEmoticons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // messageRtb
            // 
            this.messageRtb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.messageRtb.BackColor = System.Drawing.SystemColors.Window;
            this.messageRtb.Location = new System.Drawing.Point(11, 12);
            this.messageRtb.Name = "messageRtb";
            this.messageRtb.ReadOnly = true;
            this.messageRtb.Size = new System.Drawing.Size(605, 228);
            this.messageRtb.TabIndex = 0;
            this.messageRtb.TabStop = false;
            this.messageRtb.Text = "";
            this.messageRtb.TextChanged += new System.EventHandler(this.messageRtb_TextChanged);
            // 
            // sendMsgRtb
            // 
            this.sendMsgRtb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sendMsgRtb.Location = new System.Drawing.Point(12, 307);
            this.sendMsgRtb.Multiline = false;
            this.sendMsgRtb.Name = "sendMsgRtb";
            this.sendMsgRtb.Size = new System.Drawing.Size(415, 31);
            this.sendMsgRtb.TabIndex = 1;
            this.sendMsgRtb.Text = "";
            this.sendMsgRtb.WordWrap = false;
            this.sendMsgRtb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sendMsgRtb_KeyDown);
            // 
            // sendBtn
            // 
            this.sendBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendBtn.Location = new System.Drawing.Point(433, 307);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(59, 31);
            this.sendBtn.TabIndex = 2;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // panelEmoticons
            // 
            this.panelEmoticons.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panelEmoticons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEmoticons.Controls.Add(this.btnX);
            this.panelEmoticons.Controls.Add(this.btnClock);
            this.panelEmoticons.Controls.Add(this.btnWave);
            this.panelEmoticons.Controls.Add(this.btnTon);
            this.panelEmoticons.Controls.Add(this.btnCry);
            this.panelEmoticons.Controls.Add(this.btnWink);
            this.panelEmoticons.Controls.Add(this.btnSad);
            this.panelEmoticons.Controls.Add(this.btnSmile);
            this.panelEmoticons.Location = new System.Drawing.Point(13, 212);
            this.panelEmoticons.Name = "panelEmoticons";
            this.panelEmoticons.Size = new System.Drawing.Size(115, 63);
            this.panelEmoticons.TabIndex = 10;
            // 
            // btnX
            // 
            this.btnX.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnX.BackgroundImage")));
            this.btnX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnX.Location = new System.Drawing.Point(83, 26);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(31, 28);
            this.btnX.TabIndex = 12;
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnClock
            // 
            this.btnClock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClock.BackgroundImage")));
            this.btnClock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClock.Location = new System.Drawing.Point(83, -1);
            this.btnClock.Name = "btnClock";
            this.btnClock.Size = new System.Drawing.Size(31, 28);
            this.btnClock.TabIndex = 18;
            this.btnClock.UseVisualStyleBackColor = true;
            this.btnClock.Click += new System.EventHandler(this.btnClock_Click);
            // 
            // btnWave
            // 
            this.btnWave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWave.BackgroundImage")));
            this.btnWave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnWave.Location = new System.Drawing.Point(55, 26);
            this.btnWave.Name = "btnWave";
            this.btnWave.Size = new System.Drawing.Size(31, 28);
            this.btnWave.TabIndex = 17;
            this.btnWave.UseVisualStyleBackColor = true;
            this.btnWave.Click += new System.EventHandler(this.btnWave_Click);
            // 
            // btnTon
            // 
            this.btnTon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTon.BackgroundImage")));
            this.btnTon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTon.Location = new System.Drawing.Point(55, -1);
            this.btnTon.Name = "btnTon";
            this.btnTon.Size = new System.Drawing.Size(31, 28);
            this.btnTon.TabIndex = 16;
            this.btnTon.UseVisualStyleBackColor = true;
            this.btnTon.Click += new System.EventHandler(this.btnTon_Click);
            // 
            // btnCry
            // 
            this.btnCry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCry.BackgroundImage")));
            this.btnCry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCry.Location = new System.Drawing.Point(27, 26);
            this.btnCry.Name = "btnCry";
            this.btnCry.Size = new System.Drawing.Size(31, 28);
            this.btnCry.TabIndex = 15;
            this.btnCry.UseVisualStyleBackColor = true;
            this.btnCry.Click += new System.EventHandler(this.btnCry_Click);
            // 
            // btnWink
            // 
            this.btnWink.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWink.BackgroundImage")));
            this.btnWink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnWink.Location = new System.Drawing.Point(-1, 26);
            this.btnWink.Name = "btnWink";
            this.btnWink.Size = new System.Drawing.Size(31, 28);
            this.btnWink.TabIndex = 14;
            this.btnWink.UseVisualStyleBackColor = true;
            this.btnWink.Click += new System.EventHandler(this.btnWink_Click);
            // 
            // btnSad
            // 
            this.btnSad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSad.BackgroundImage")));
            this.btnSad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSad.Location = new System.Drawing.Point(27, -1);
            this.btnSad.Name = "btnSad";
            this.btnSad.Size = new System.Drawing.Size(31, 28);
            this.btnSad.TabIndex = 13;
            this.btnSad.UseVisualStyleBackColor = true;
            this.btnSad.Click += new System.EventHandler(this.btnSad_Click_1);
            // 
            // btnSmile
            // 
            this.btnSmile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSmile.BackgroundImage")));
            this.btnSmile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSmile.Location = new System.Drawing.Point(-1, -1);
            this.btnSmile.Name = "btnSmile";
            this.btnSmile.Size = new System.Drawing.Size(31, 28);
            this.btnSmile.TabIndex = 12;
            this.btnSmile.UseVisualStyleBackColor = true;
            this.btnSmile.Click += new System.EventHandler(this.btnSmile_Click_1);
            // 
            // btnEmo
            // 
            this.btnEmo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEmo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmo.BackgroundImage")));
            this.btnEmo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEmo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmo.Location = new System.Drawing.Point(13, 273);
            this.btnEmo.Name = "btnEmo";
            this.btnEmo.Size = new System.Drawing.Size(31, 28);
            this.btnEmo.TabIndex = 11;
            this.btnEmo.UseVisualStyleBackColor = true;
            this.btnEmo.Click += new System.EventHandler(this.btnEmo_Click);
            // 
            // btnFormat
            // 
            this.btnFormat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFormat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFormat.BackgroundImage")));
            this.btnFormat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFormat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFormat.Location = new System.Drawing.Point(50, 273);
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(31, 28);
            this.btnFormat.TabIndex = 12;
            this.btnFormat.UseVisualStyleBackColor = true;
            this.btnFormat.Click += new System.EventHandler(this.btnFormat_Click);
            // 
            // btnColor
            // 
            this.btnColor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnColor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnColor.BackgroundImage")));
            this.btnColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColor.Location = new System.Drawing.Point(87, 273);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(30, 29);
            this.btnColor.TabIndex = 13;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(498, 246);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Profile
            // 
            this.Profile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Profile.BackgroundImage")));
            this.Profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Profile.Location = new System.Drawing.Point(124, 273);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(33, 29);
            this.Profile.TabIndex = 15;
            this.Profile.UseVisualStyleBackColor = true;
            this.Profile.Visible = false;
            this.Profile.Click += new System.EventHandler(this.Imvironment_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "imv_fish.gif");
            this.imageList1.Images.SetKeyName(1, "vista-iconsms.png");
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(163, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 28);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bgwSender
            // 
            this.bgwSender.WorkerSupportsCancellation = true;
            this.bgwSender.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwSender_DoWork);
            // 
            // frmMessageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 349);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Profile);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnFormat);
            this.Controls.Add(this.btnEmo);
            this.Controls.Add(this.panelEmoticons);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.sendMsgRtb);
            this.Controls.Add(this.messageRtb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMessageWindow";
            this.Text = "Conversation";
            this.Load += new System.EventHandler(this.MessageFrm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMessageWindow_FormClosed);
            this.panelEmoticons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox messageRtb;
        private System.Windows.Forms.RichTextBox sendMsgRtb;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Panel panelEmoticons;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnClock;
        private System.Windows.Forms.Button btnWave;
        private System.Windows.Forms.Button btnTon;
        private System.Windows.Forms.Button btnCry;
        private System.Windows.Forms.Button btnWink;
        private System.Windows.Forms.Button btnSad;
        private System.Windows.Forms.Button btnSmile;
        private System.Windows.Forms.Button btnEmo;
        private System.Windows.Forms.Button btnFormat;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Profile;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker bgwSender;
    }
}