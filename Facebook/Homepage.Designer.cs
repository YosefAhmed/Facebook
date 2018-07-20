namespace Facebook
{
    partial class Homepage
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.profilepicpanel = new System.Windows.Forms.Panel();
            this.profilebtn = new System.Windows.Forms.Label();
            this.profilepic = new System.Windows.Forms.PictureBox();
            this.homebtn = new System.Windows.Forms.Button();
            this.settingsbtn = new System.Windows.Forms.Button();
            this.friendsbtn = new System.Windows.Forms.Button();
            this.notificationbtn = new System.Windows.Forms.Button();
            this.messagesbtn = new System.Windows.Forms.Button();
            this.searchbtn = new System.Windows.Forms.Button();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.newspanle = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.write_post1 = new Facebook.Write_post();
            this.chat1 = new Facebook.UserControls.chat();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.profilepicpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilepic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 1F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
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
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuTransition1.SetDecoration(this.button4, BunifuAnimatorNS.DecorationType.None);
            this.button4.Dock = System.Windows.Forms.DockStyle.Right;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button4.Location = new System.Drawing.Point(850, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(27, 27);
            this.button4.TabIndex = 6;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.maxmizebtn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuTransition1.SetDecoration(this.button3, BunifuAnimatorNS.DecorationType.None);
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(823, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 27);
            this.button3.TabIndex = 6;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.minimizebtn_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(153)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 27);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlepar_MouseDown_1);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titlepar_MouseMove_1);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titlepar_MouseUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuTransition1.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(877, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 27);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Exitbtn_Click_1);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.panel2.Controls.Add(this.profilepicpanel);
            this.panel2.Controls.Add(this.homebtn);
            this.panel2.Controls.Add(this.settingsbtn);
            this.panel2.Controls.Add(this.friendsbtn);
            this.panel2.Controls.Add(this.notificationbtn);
            this.panel2.Controls.Add(this.messagesbtn);
            this.panel2.Controls.Add(this.searchbtn);
            this.panel2.Controls.Add(this.searchtxt);
            this.panel2.Controls.Add(this.pictureBox1);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(904, 45);
            this.panel2.TabIndex = 6;
            // 
            // profilepicpanel
            // 
            this.profilepicpanel.Controls.Add(this.profilebtn);
            this.profilepicpanel.Controls.Add(this.profilepic);
            this.bunifuTransition1.SetDecoration(this.profilepicpanel, BunifuAnimatorNS.DecorationType.None);
            this.profilepicpanel.Location = new System.Drawing.Point(447, 11);
            this.profilepicpanel.Name = "profilepicpanel";
            this.profilepicpanel.Size = new System.Drawing.Size(91, 27);
            this.profilepicpanel.TabIndex = 15;
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
            // profilepic
            // 
            this.profilepic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.profilepic, BunifuAnimatorNS.DecorationType.None);
            this.profilepic.Image = global::Facebook.Properties.Resources.man_2_icon;
            this.profilepic.Location = new System.Drawing.Point(3, -4);
            this.profilepic.Name = "profilepic";
            this.profilepic.Size = new System.Drawing.Size(30, 32);
            this.profilepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.profilepic.TabIndex = 16;
            this.profilepic.TabStop = false;
            this.profilepic.Click += new System.EventHandler(this.profilepic_Click);
            // 
            // homebtn
            // 
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
            // friendsbtn
            // 
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
            // notificationbtn
            // 
            this.notificationbtn.AutoSize = true;
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
            this.searchtxt.Enter += new System.EventHandler(this.searchtxt_Enter_2);
            this.searchtxt.Leave += new System.EventHandler(this.searchtxt_Leave_2);
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
            this.pictureBox1.Click += new System.EventHandler(this.facebookicon_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.3567F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.6433F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.bunifuTransition1.SetDecoration(this.tableLayoutPanel1, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(80, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 460F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(821, 494);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.Controls.Add(this.newspanle, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.bunifuTransition1.SetDecoration(this.tableLayoutPanel2, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.65934F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.34066F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(571, 488);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // newspanle
            // 
            this.newspanle.AutoScroll = true;
            this.newspanle.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.newspanle, BunifuAnimatorNS.DecorationType.None);
            this.newspanle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newspanle.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.newspanle.Location = new System.Drawing.Point(3, 201);
            this.newspanle.Name = "newspanle";
            this.newspanle.Size = new System.Drawing.Size(557, 284);
            this.newspanle.TabIndex = 4;
            this.newspanle.WrapContents = false;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.write_post1, 0, 0);
            this.bunifuTransition1.SetDecoration(this.tableLayoutPanel6, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.13483F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.865169F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(557, 192);
            this.tableLayoutPanel6.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.chat1, 0, 1);
            this.bunifuTransition1.SetDecoration(this.tableLayoutPanel3, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(580, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.31718F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.68282F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(238, 488);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.203991F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.panel3, 0, 0);
            this.bunifuTransition1.SetDecoration(this.tableLayoutPanel4, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.91513F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.08487F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(910, 580);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.59375F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.40625F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.bunifuTransition1.SetDecoration(this.tableLayoutPanel5, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 77);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 466F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(904, 500);
            this.tableLayoutPanel5.TabIndex = 0;
            this.tableLayoutPanel5.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel5_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(904, 68);
            this.panel3.TabIndex = 1;
            // 
            // write_post1
            // 
            this.write_post1.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.write_post1, BunifuAnimatorNS.DecorationType.None);
            this.write_post1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.write_post1.Location = new System.Drawing.Point(3, 3);
            this.write_post1.Name = "write_post1";
            this.write_post1.Size = new System.Drawing.Size(551, 170);
            this.write_post1.TabIndex = 0;
            // 
            // chat1
            // 
            this.chat1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chat1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.bunifuTransition1.SetDecoration(this.chat1, BunifuAnimatorNS.DecorationType.None);
            this.chat1.Location = new System.Drawing.Point(54, 102);
            this.chat1.Name = "chat1";
            this.chat1.Size = new System.Drawing.Size(181, 383);
            this.chat1.TabIndex = 0;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(910, 580);
            this.Controls.Add(this.tableLayoutPanel4);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.profilepicpanel.ResumeLayout(false);
            this.profilepicpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilepic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.Button settingsbtn;
        private System.Windows.Forms.Button friendsbtn;
        private System.Windows.Forms.Button notificationbtn;
        private System.Windows.Forms.Button messagesbtn;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel profilepicpanel;
        private System.Windows.Forms.PictureBox profilepic;
        private System.Windows.Forms.Label profilebtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel newspanle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private Write_post write_post1;
        private System.Windows.Forms.Panel panel3;
        private UserControls.chat chat1;
    }
}