namespace ChatClient
{
    partial class frmMainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainWindow));
            this.lvFriends = new System.Windows.Forms.ListView();
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.tmrReceiver = new System.Windows.Forms.Timer(this.components);
            this.bgwMessageListener = new System.ComponentModel.BackgroundWorker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.owchatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.friendsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFriendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvFriends
            // 
            this.lvFriends.LargeImageList = this.imageListSmall;
            this.lvFriends.Location = new System.Drawing.Point(9, 103);
            this.lvFriends.Margin = new System.Windows.Forms.Padding(0);
            this.lvFriends.MultiSelect = false;
            this.lvFriends.Name = "lvFriends";
            this.lvFriends.ShowGroups = false;
            this.lvFriends.Size = new System.Drawing.Size(189, 297);
            this.lvFriends.SmallImageList = this.imageListSmall;
            this.lvFriends.StateImageList = this.imageListSmall;
            this.lvFriends.TabIndex = 1;
            this.lvFriends.UseCompatibleStateImageBehavior = false;
            this.lvFriends.View = System.Windows.Forms.View.List;
            this.lvFriends.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvFriends_MouseDoubleClick);
            this.lvFriends.SelectedIndexChanged += new System.EventHandler(this.lvFriends_SelectedIndexChanged);
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "1.gif");
            this.imageListSmall.Images.SetKeyName(1, "Add-icon.png");
            this.imageListSmall.Images.SetKeyName(2, "out.JPG");
            this.imageListSmall.Images.SetKeyName(3, "buddy.JPG");
            this.imageListSmall.Images.SetKeyName(4, "buddy_offline.jpg");
            // 
            // tmrReceiver
            // 
            this.tmrReceiver.Interval = 2000;
            this.tmrReceiver.Tick += new System.EventHandler(this.tmrReceiver_Tick);
            // 
            // bgwMessageListener
            // 
            this.bgwMessageListener.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwMessageListener_DoWork);
            // 
            // btnAdd
            // 
            this.btnAdd.ImageIndex = 1;
            this.btnAdd.ImageList = this.imageListSmall;
            this.btnAdd.Location = new System.Drawing.Point(12, 40);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(51, 45);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.ImageKey = "out.JPG";
            this.btnSignOut.ImageList = this.imageListSmall;
            this.btnSignOut.Location = new System.Drawing.Point(140, 40);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(51, 45);
            this.btnSignOut.TabIndex = 3;
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.owchatToolStripMenuItem,
            this.friendsToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(207, 24);
            this.menuStripMain.TabIndex = 4;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // owchatToolStripMenuItem
            // 
            this.owchatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signOutToolStripMenuItem});
            this.owchatToolStripMenuItem.Name = "owchatToolStripMenuItem";
            this.owchatToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.owchatToolStripMenuItem.Text = "ow-chat";
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.signOutToolStripMenuItem.Text = "&Sign out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // friendsToolStripMenuItem
            // 
            this.friendsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFriendToolStripMenuItem});
            this.friendsToolStripMenuItem.Name = "friendsToolStripMenuItem";
            this.friendsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.friendsToolStripMenuItem.Text = "Friends";
            // 
            // addFriendToolStripMenuItem
            // 
            this.addFriendToolStripMenuItem.Name = "addFriendToolStripMenuItem";
            this.addFriendToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.addFriendToolStripMenuItem.Text = "Add Friend";
            this.addFriendToolStripMenuItem.Click += new System.EventHandler(this.addFriendToolStripMenuItem_Click);
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 409);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lvFriends);
            this.Controls.Add(this.menuStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMainWindow";
            this.Text = "Ow-Chat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.frmMainWindow_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainWindow_FormClosing);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvFriends;
        private System.Windows.Forms.Timer tmrReceiver;
        private System.ComponentModel.BackgroundWorker bgwMessageListener;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.ImageList imageListSmall;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem owchatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem friendsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFriendToolStripMenuItem;
    }
}

