namespace ChatClient
{
    partial class MessageFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageFrm));
            this.messageRtb = new System.Windows.Forms.RichTextBox();
            this.sendMsgRtb = new System.Windows.Forms.RichTextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // messageRtb
            // 
            this.messageRtb.Location = new System.Drawing.Point(1, 1);
            this.messageRtb.Name = "messageRtb";
            this.messageRtb.Size = new System.Drawing.Size(604, 252);
            this.messageRtb.TabIndex = 0;
            this.messageRtb.Text = "";
            // 
            // sendMsgRtb
            // 
            this.sendMsgRtb.Location = new System.Drawing.Point(1, 287);
            this.sendMsgRtb.Name = "sendMsgRtb";
            this.sendMsgRtb.Size = new System.Drawing.Size(505, 50);
            this.sendMsgRtb.TabIndex = 1;
            this.sendMsgRtb.Text = "";
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(504, 287);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(101, 50);
            this.sendBtn.TabIndex = 2;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnX);
            this.panel1.Controls.Add(this.btnClock);
            this.panel1.Controls.Add(this.btnWave);
            this.panel1.Controls.Add(this.btnTon);
            this.panel1.Controls.Add(this.btnCry);
            this.panel1.Controls.Add(this.btnWink);
            this.panel1.Controls.Add(this.btnSad);
            this.panel1.Controls.Add(this.btnSmile);
            this.panel1.Location = new System.Drawing.Point(23, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 55);
            this.panel1.TabIndex = 10;
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
            this.btnEmo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmo.BackgroundImage")));
            this.btnEmo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEmo.Location = new System.Drawing.Point(13, 253);
            this.btnEmo.Name = "btnEmo";
            this.btnEmo.Size = new System.Drawing.Size(31, 28);
            this.btnEmo.TabIndex = 11;
            this.btnEmo.UseVisualStyleBackColor = true;
            // 
            // btnFormat
            // 
            this.btnFormat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFormat.BackgroundImage")));
            this.btnFormat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFormat.Location = new System.Drawing.Point(50, 253);
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(31, 28);
            this.btnFormat.TabIndex = 12;
            this.btnFormat.UseVisualStyleBackColor = true;
            this.btnFormat.Click += new System.EventHandler(this.btnFormat_Click);
            // 
            // btnColor
            // 
            this.btnColor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnColor.BackgroundImage")));
            this.btnColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnColor.Location = new System.Drawing.Point(88, 253);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(30, 29);
            this.btnColor.TabIndex = 13;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // MessageFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 338);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnFormat);
            this.Controls.Add(this.btnEmo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.sendMsgRtb);
            this.Controls.Add(this.messageRtb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MessageFrm";
            this.Text = "Message Window";
            this.Load += new System.EventHandler(this.MessageFrm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox messageRtb;
        private System.Windows.Forms.RichTextBox sendMsgRtb;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
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
    }
}