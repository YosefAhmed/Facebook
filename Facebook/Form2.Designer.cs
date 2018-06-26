namespace Facebook
{
    partial class profilepage
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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profilepage));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.profilepic = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.profilepicpanel = new System.Windows.Forms.Panel();
            this.profilebtn = new System.Windows.Forms.Label();
            this.Profilpic = new System.Windows.Forms.PictureBox();
            this.friendsbtn = new System.Windows.Forms.Button();
            this.homebtn = new System.Windows.Forms.Button();
            this.settingsbtn = new System.Windows.Forms.Button();
            this.notificationbtn = new System.Windows.Forms.Button();
            this.messagesbtn = new System.Windows.Forms.Button();
            this.searchbtn = new System.Windows.Forms.Button();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titlepar = new System.Windows.Forms.Panel();
            this.minimizebtn = new System.Windows.Forms.Button();
            this.maxmizebtn = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.coverimage = new System.Windows.Forms.PictureBox();
            this.postpanle = new System.Windows.Forms.Panel();
            this.tagbtn = new System.Windows.Forms.Button();
            this.postbtn = new System.Windows.Forms.Button();
            this.privacybtn = new System.Windows.Forms.Button();
            this.posttxt = new System.Windows.Forms.TextBox();
            this.chat1 = new Facebook.UserControls.chat();
            ((System.ComponentModel.ISupportInitialize)(this.profilepic)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.profilepicpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Profilpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.titlepar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverimage)).BeginInit();
            this.postpanle.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this.profilepic;
            // 
            // profilepic
            // 
            this.profilepic.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.profilepic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.profilepic, BunifuAnimatorNS.DecorationType.None);
            this.profilepic.Image = global::Facebook.Properties.Resources.man_icon;
            this.profilepic.Location = new System.Drawing.Point(79, 197);
            this.profilepic.Name = "profilepic";
            this.profilepic.Size = new System.Drawing.Size(101, 101);
            this.profilepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilepic.TabIndex = 5;
            this.profilepic.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(153)))));
            this.bunifuTransition1.SetDecoration(this.button5, BunifuAnimatorNS.DecorationType.None);
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(6, 269);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(175, 36);
            this.button5.TabIndex = 7;
            this.button5.Text = "Chating";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.button5);
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(725, 243);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(181, 308);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuTransition1.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.panel4.Location = new System.Drawing.Point(756, 157);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(96, 80);
            this.panel4.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(188, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "(Username)";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.bunifuTransition1.SetDecoration(this.groupBox1, BunifuAnimatorNS.DecorationType.None);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(153)))));
            this.groupBox1.Location = new System.Drawing.Point(57, 304);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 138);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label8, BunifuAnimatorNS.DecorationType.None);
            this.label8.Location = new System.Drawing.Point(5, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Support : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.label7.Location = new System.Drawing.Point(5, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Social status : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.Location = new System.Drawing.Point(6, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Faculity : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Study : ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.panel2.Controls.Add(this.profilepicpanel);
            this.panel2.Controls.Add(this.friendsbtn);
            this.panel2.Controls.Add(this.homebtn);
            this.panel2.Controls.Add(this.settingsbtn);
            this.panel2.Controls.Add(this.notificationbtn);
            this.panel2.Controls.Add(this.messagesbtn);
            this.panel2.Controls.Add(this.searchbtn);
            this.panel2.Controls.Add(this.searchtxt);
            this.panel2.Controls.Add(this.pictureBox1);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(902, 45);
            this.panel2.TabIndex = 20;
            // 
            // profilepicpanel
            // 
            this.profilepicpanel.Controls.Add(this.profilebtn);
            this.profilepicpanel.Controls.Add(this.Profilpic);
            this.bunifuTransition1.SetDecoration(this.profilepicpanel, BunifuAnimatorNS.DecorationType.None);
            this.profilepicpanel.Location = new System.Drawing.Point(444, 11);
            this.profilepicpanel.Name = "profilepicpanel";
            this.profilepicpanel.Size = new System.Drawing.Size(91, 27);
            this.profilepicpanel.TabIndex = 16;
            // 
            // profilebtn
            // 
            this.profilebtn.AutoSize = true;
            this.profilebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.profilebtn, BunifuAnimatorNS.DecorationType.None);
            this.profilebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.profilebtn.ForeColor = System.Drawing.Color.White;
            this.profilebtn.Location = new System.Drawing.Point(38, 7);
            this.profilebtn.Name = "profilebtn";
            this.profilebtn.Size = new System.Drawing.Size(49, 15);
            this.profilebtn.TabIndex = 17;
            this.profilebtn.Text = "Profile";
            this.profilebtn.Click += new System.EventHandler(this.profilebtn_Click);
            // 
            // Profilpic
            // 
            this.Profilpic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.Profilpic, BunifuAnimatorNS.DecorationType.None);
            this.Profilpic.Image = global::Facebook.Properties.Resources.man_2_icon;
            this.Profilpic.Location = new System.Drawing.Point(3, -4);
            this.Profilpic.Name = "Profilpic";
            this.Profilpic.Size = new System.Drawing.Size(30, 32);
            this.Profilpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Profilpic.TabIndex = 16;
            this.Profilpic.TabStop = false;
            this.Profilpic.Click += new System.EventHandler(this.Profilpic_Click);
            // 
            // friendsbtn
            // 
            this.friendsbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.friendsbtn.BackColor = System.Drawing.Color.Transparent;
            this.friendsbtn.BackgroundImage = global::Facebook.Properties.Resources.frinds1;
            this.friendsbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.friendsbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.friendsbtn, BunifuAnimatorNS.DecorationType.None);
            this.friendsbtn.FlatAppearance.BorderSize = 0;
            this.friendsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.friendsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friendsbtn.Location = new System.Drawing.Point(663, 3);
            this.friendsbtn.Name = "friendsbtn";
            this.friendsbtn.Size = new System.Drawing.Size(29, 40);
            this.friendsbtn.TabIndex = 12;
            this.friendsbtn.UseVisualStyleBackColor = false;
            // 
            // homebtn
            // 
            this.homebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.homebtn.BackColor = System.Drawing.Color.Transparent;
            this.homebtn.BackgroundImage = global::Facebook.Properties.Resources.Home_2_icon;
            this.homebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.homebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.homebtn, BunifuAnimatorNS.DecorationType.None);
            this.homebtn.FlatAppearance.BorderSize = 0;
            this.homebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.homebtn.Location = new System.Drawing.Point(553, 11);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(73, 27);
            this.homebtn.TabIndex = 14;
            this.homebtn.Text = "Home";
            this.homebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.homebtn.UseVisualStyleBackColor = false;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // settingsbtn
            // 
            this.settingsbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsbtn.BackColor = System.Drawing.Color.Transparent;
            this.settingsbtn.BackgroundImage = global::Facebook.Properties.Resources.settings1;
            this.settingsbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.settingsbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.settingsbtn, BunifuAnimatorNS.DecorationType.None);
            this.settingsbtn.FlatAppearance.BorderSize = 0;
            this.settingsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsbtn.Location = new System.Drawing.Point(822, 3);
            this.settingsbtn.Name = "settingsbtn";
            this.settingsbtn.Size = new System.Drawing.Size(29, 40);
            this.settingsbtn.TabIndex = 13;
            this.settingsbtn.UseVisualStyleBackColor = false;
            // 
            // notificationbtn
            // 
            this.notificationbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.notificationbtn.BackColor = System.Drawing.Color.Transparent;
            this.notificationbtn.BackgroundImage = global::Facebook.Properties.Resources.notifecations1;
            this.notificationbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.notificationbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.notificationbtn, BunifuAnimatorNS.DecorationType.None);
            this.notificationbtn.FlatAppearance.BorderSize = 0;
            this.notificationbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notificationbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationbtn.Location = new System.Drawing.Point(747, 3);
            this.notificationbtn.Name = "notificationbtn";
            this.notificationbtn.Size = new System.Drawing.Size(29, 40);
            this.notificationbtn.TabIndex = 11;
            this.notificationbtn.UseVisualStyleBackColor = false;
            // 
            // messagesbtn
            // 
            this.messagesbtn.BackColor = System.Drawing.Color.Transparent;
            this.messagesbtn.BackgroundImage = global::Facebook.Properties.Resources.messages1;
            this.messagesbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.messagesbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.messagesbtn, BunifuAnimatorNS.DecorationType.None);
            this.messagesbtn.FlatAppearance.BorderSize = 0;
            this.messagesbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.messagesbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messagesbtn.Location = new System.Drawing.Point(708, 3);
            this.messagesbtn.Name = "messagesbtn";
            this.messagesbtn.Size = new System.Drawing.Size(29, 40);
            this.messagesbtn.TabIndex = 10;
            this.messagesbtn.UseVisualStyleBackColor = false;
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.White;
            this.searchbtn.BackgroundImage = global::Facebook.Properties.Resources.search;
            this.searchbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.searchbtn, BunifuAnimatorNS.DecorationType.None);
            this.searchbtn.FlatAppearance.BorderSize = 0;
            this.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbtn.Location = new System.Drawing.Point(371, 11);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(26, 21);
            this.searchbtn.TabIndex = 8;
            this.searchbtn.UseVisualStyleBackColor = false;
            // 
            // searchtxt
            // 
            this.bunifuTransition1.SetDecoration(this.searchtxt, BunifuAnimatorNS.DecorationType.None);
            this.searchtxt.Font = new System.Drawing.Font("Microsoft NeoGothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtxt.ForeColor = System.Drawing.Color.Silver;
            this.searchtxt.Location = new System.Drawing.Point(83, 8);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(317, 27);
            this.searchtxt.TabIndex = 9;
            this.searchtxt.Text = "Search";
            this.searchtxt.Enter += new System.EventHandler(this.searchtxt_Enter);
            this.searchtxt.Leave += new System.EventHandler(this.searchtxt_Leave);
            // 
            // pictureBox1
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(45, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // titlepar
            // 
            this.titlepar.AutoSize = true;
            this.titlepar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(153)))));
            this.titlepar.Controls.Add(this.minimizebtn);
            this.titlepar.Controls.Add(this.maxmizebtn);
            this.titlepar.Controls.Add(this.Exitbtn);
            this.titlepar.Controls.Add(this.pictureBox2);
            this.titlepar.Controls.Add(this.label1);
            this.bunifuTransition1.SetDecoration(this.titlepar, BunifuAnimatorNS.DecorationType.None);
            this.titlepar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlepar.Location = new System.Drawing.Point(0, 0);
            this.titlepar.Name = "titlepar";
            this.titlepar.Size = new System.Drawing.Size(902, 27);
            this.titlepar.TabIndex = 19;
            this.titlepar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlepar_MouseDown_2);
            this.titlepar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titlepar_MouseMove_2);
            this.titlepar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titlepar_MouseUp_1);
            // 
            // minimizebtn
            // 
            this.minimizebtn.BackColor = System.Drawing.Color.Transparent;
            this.minimizebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuTransition1.SetDecoration(this.minimizebtn, BunifuAnimatorNS.DecorationType.None);
            this.minimizebtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizebtn.FlatAppearance.BorderSize = 0;
            this.minimizebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.minimizebtn.ForeColor = System.Drawing.Color.White;
            this.minimizebtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.minimizebtn.Location = new System.Drawing.Point(821, 0);
            this.minimizebtn.Name = "minimizebtn";
            this.minimizebtn.Size = new System.Drawing.Size(27, 27);
            this.minimizebtn.TabIndex = 9;
            this.minimizebtn.Text = "-";
            this.minimizebtn.UseVisualStyleBackColor = false;
            this.minimizebtn.Click += new System.EventHandler(this.minimizebtn_Click);
            // 
            // maxmizebtn
            // 
            this.maxmizebtn.BackColor = System.Drawing.Color.Transparent;
            this.maxmizebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuTransition1.SetDecoration(this.maxmizebtn, BunifuAnimatorNS.DecorationType.None);
            this.maxmizebtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.maxmizebtn.FlatAppearance.BorderSize = 0;
            this.maxmizebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxmizebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.maxmizebtn.ForeColor = System.Drawing.Color.White;
            this.maxmizebtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.maxmizebtn.Location = new System.Drawing.Point(848, 0);
            this.maxmizebtn.Name = "maxmizebtn";
            this.maxmizebtn.Size = new System.Drawing.Size(27, 27);
            this.maxmizebtn.TabIndex = 8;
            this.maxmizebtn.Text = "+";
            this.maxmizebtn.UseVisualStyleBackColor = false;
            this.maxmizebtn.Click += new System.EventHandler(this.maximizbtn_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.BackColor = System.Drawing.Color.Transparent;
            this.Exitbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuTransition1.SetDecoration(this.Exitbtn, BunifuAnimatorNS.DecorationType.None);
            this.Exitbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Exitbtn.FlatAppearance.BorderSize = 0;
            this.Exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Exitbtn.Image = ((System.Drawing.Image)(resources.GetObject("Exitbtn.Image")));
            this.Exitbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Exitbtn.Location = new System.Drawing.Point(875, 0);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(27, 27);
            this.Exitbtn.TabIndex = 7;
            this.Exitbtn.UseVisualStyleBackColor = false;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click_1);
            // 
            // pictureBox2
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(16, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(19, 19);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(41, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Facebook - Your Distinct Way To Connect the World!";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::Facebook.Properties.Resources.up_icon;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.button3, BunifuAnimatorNS.DecorationType.None);
            this.button3.Location = new System.Drawing.Point(664, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 23);
            this.button3.TabIndex = 21;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.SystemColors.Window;
            this.bunifuTransition1.SetDecoration(this.pictureBox12, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox12.Image = global::Facebook.Properties.Resources.Emotes_face_smile_icon;
            this.pictureBox12.Location = new System.Drawing.Point(81, 101);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(33, 34);
            this.pictureBox12.TabIndex = 18;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.SystemColors.Window;
            this.bunifuTransition1.SetDecoration(this.pictureBox11, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox11.Image = global::Facebook.Properties.Resources.video_camera_icon;
            this.pictureBox11.Location = new System.Drawing.Point(42, 101);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(33, 34);
            this.pictureBox11.TabIndex = 17;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.SystemColors.Window;
            this.bunifuTransition1.SetDecoration(this.pictureBox10, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox10.Image = global::Facebook.Properties.Resources.camera_icon;
            this.pictureBox10.Location = new System.Drawing.Point(3, 101);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(33, 34);
            this.pictureBox10.TabIndex = 16;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuTransition1.SetDecoration(this.pictureBox9, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox9.Image = global::Facebook.Properties.Resources.scroll_down_icon;
            this.pictureBox9.Location = new System.Drawing.Point(790, 219);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(30, 18);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 10;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::Facebook.Properties.Resources.up_icon;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.button4, BunifuAnimatorNS.DecorationType.None);
            this.button4.Location = new System.Drawing.Point(159, 280);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(23, 18);
            this.button4.TabIndex = 6;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // coverimage
            // 
            this.coverimage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.coverimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.coverimage, BunifuAnimatorNS.DecorationType.None);
            this.coverimage.Location = new System.Drawing.Point(57, 81);
            this.coverimage.Name = "coverimage";
            this.coverimage.Size = new System.Drawing.Size(632, 185);
            this.coverimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coverimage.TabIndex = 3;
            this.coverimage.TabStop = false;
            // 
            // postpanle
            // 
            this.postpanle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.postpanle.Controls.Add(this.tagbtn);
            this.postpanle.Controls.Add(this.postbtn);
            this.postpanle.Controls.Add(this.privacybtn);
            this.postpanle.Controls.Add(this.posttxt);
            this.postpanle.Controls.Add(this.pictureBox12);
            this.postpanle.Controls.Add(this.pictureBox11);
            this.postpanle.Controls.Add(this.pictureBox10);
            this.bunifuTransition1.SetDecoration(this.postpanle, BunifuAnimatorNS.DecorationType.None);
            this.postpanle.Location = new System.Drawing.Point(256, 304);
            this.postpanle.Name = "postpanle";
            this.postpanle.Size = new System.Drawing.Size(433, 138);
            this.postpanle.TabIndex = 22;
            // 
            // tagbtn
            // 
            this.tagbtn.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.tagbtn, BunifuAnimatorNS.DecorationType.None);
            this.tagbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tagbtn.FlatAppearance.BorderSize = 0;
            this.tagbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tagbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagbtn.ForeColor = System.Drawing.Color.Gray;
            this.tagbtn.Image = global::Facebook.Properties.Resources.tag;
            this.tagbtn.Location = new System.Drawing.Point(207, 104);
            this.tagbtn.Name = "tagbtn";
            this.tagbtn.Size = new System.Drawing.Size(101, 27);
            this.tagbtn.TabIndex = 1;
            this.tagbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tagbtn.UseVisualStyleBackColor = false;
            // 
            // postbtn
            // 
            this.postbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.bunifuTransition1.SetDecoration(this.postbtn, BunifuAnimatorNS.DecorationType.None);
            this.postbtn.FlatAppearance.BorderSize = 0;
            this.postbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.postbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.postbtn.Location = new System.Drawing.Point(337, 103);
            this.postbtn.Name = "postbtn";
            this.postbtn.Size = new System.Drawing.Size(94, 27);
            this.postbtn.TabIndex = 1;
            this.postbtn.Text = "post";
            this.postbtn.UseVisualStyleBackColor = false;
            // 
            // privacybtn
            // 
            this.privacybtn.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.privacybtn, BunifuAnimatorNS.DecorationType.None);
            this.privacybtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.privacybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.privacybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privacybtn.ForeColor = System.Drawing.Color.Gray;
            this.privacybtn.Image = global::Facebook.Properties.Resources.publi;
            this.privacybtn.Location = new System.Drawing.Point(126, 104);
            this.privacybtn.Name = "privacybtn";
            this.privacybtn.Size = new System.Drawing.Size(75, 28);
            this.privacybtn.TabIndex = 1;
            this.privacybtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.privacybtn.UseVisualStyleBackColor = false;
            // 
            // posttxt
            // 
            this.posttxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTransition1.SetDecoration(this.posttxt, BunifuAnimatorNS.DecorationType.None);
            this.posttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posttxt.ForeColor = System.Drawing.Color.Silver;
            this.posttxt.Location = new System.Drawing.Point(0, 0);
            this.posttxt.Multiline = true;
            this.posttxt.Name = "posttxt";
            this.posttxt.Size = new System.Drawing.Size(431, 98);
            this.posttxt.TabIndex = 0;
            this.posttxt.Text = "What\'s on your mind?";
            this.posttxt.Enter += new System.EventHandler(this.posttxt_Enter);
            this.posttxt.Leave += new System.EventHandler(this.posttxt_Leave);
            // 
            // chat1
            // 
            this.chat1.BackColor = System.Drawing.Color.LightGray;
            this.chat1.Button5 = null;
            this.bunifuTransition1.SetDecoration(this.chat1, BunifuAnimatorNS.DecorationType.None);
            this.chat1.Location = new System.Drawing.Point(725, 243);
            this.chat1.Name = "chat1";
            this.chat1.Size = new System.Drawing.Size(178, 298);
            this.chat1.TabIndex = 8;
            // 
            // profilepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(902, 542);
            this.Controls.Add(this.postpanle);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.titlepar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.chat1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.profilepic);
            this.Controls.Add(this.coverimage);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "profilepage";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.profilepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilepic)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.profilepicpanel.ResumeLayout(false);
            this.profilepicpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Profilpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.titlepar.ResumeLayout(false);
            this.titlepar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverimage)).EndInit();
            this.postpanle.ResumeLayout(false);
            this.postpanle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox coverimage;
        private System.Windows.Forms.PictureBox profilepic;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private UserControls.chat chat1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button friendsbtn;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.Button settingsbtn;
        private System.Windows.Forms.Button notificationbtn;
        private System.Windows.Forms.Button messagesbtn;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel titlepar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button tagbtn;
        private System.Windows.Forms.Panel postpanle;
        private System.Windows.Forms.Button postbtn;
        private System.Windows.Forms.TextBox posttxt;
        private System.Windows.Forms.Button privacybtn;
        private System.Windows.Forms.Panel profilepicpanel;
        private System.Windows.Forms.Label profilebtn;
        private System.Windows.Forms.PictureBox Profilpic;
        private System.Windows.Forms.Button minimizebtn;
        private System.Windows.Forms.Button maxmizebtn;
        private System.Windows.Forms.Button Exitbtn;

        public bool Win { get; set; }
    }
}