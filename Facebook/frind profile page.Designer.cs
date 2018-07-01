namespace Facebook
{
    partial class frind_profile_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frind_profile_page));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Profilpic = new System.Windows.Forms.PictureBox();
            this.friendsbtn = new System.Windows.Forms.Button();
            this.homebtn = new System.Windows.Forms.Button();
            this.settingsbtn = new System.Windows.Forms.Button();
            this.notificationbtn = new System.Windows.Forms.Button();
            this.searchbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.messagesbtn = new System.Windows.Forms.Button();
            this.chat2 = new Facebook.UserControls.chat();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.profilepicpanel = new System.Windows.Forms.Panel();
            this.profilebtn = new System.Windows.Forms.Label();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.titlepar = new System.Windows.Forms.Panel();
            this.minimizebtn = new System.Windows.Forms.Button();
            this.maxmizebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.frind_cover_profile_photo1 = new Facebook.UserControls.frind_cover_profile_photo();
            ((System.ComponentModel.ISupportInitialize)(this.Profilpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.profilepicpanel.SuspendLayout();
            this.titlepar.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
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
            // 
            // friendsbtn
            // 
            this.friendsbtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.friendsbtn.BackColor = System.Drawing.Color.Transparent;
            this.friendsbtn.BackgroundImage = global::Facebook.Properties.Resources.frinds1;
            this.friendsbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.friendsbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.friendsbtn, BunifuAnimatorNS.DecorationType.None);
            this.friendsbtn.FlatAppearance.BorderSize = 0;
            this.friendsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.friendsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friendsbtn.Location = new System.Drawing.Point(739, 3);
            this.friendsbtn.Name = "friendsbtn";
            this.friendsbtn.Size = new System.Drawing.Size(29, 40);
            this.friendsbtn.TabIndex = 12;
            this.friendsbtn.UseVisualStyleBackColor = false;
            // 
            // homebtn
            // 
            this.homebtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.homebtn.BackColor = System.Drawing.Color.Transparent;
            this.homebtn.BackgroundImage = global::Facebook.Properties.Resources.Home_2_icon;
            this.homebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.homebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.homebtn, BunifuAnimatorNS.DecorationType.None);
            this.homebtn.FlatAppearance.BorderSize = 0;
            this.homebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.homebtn.Location = new System.Drawing.Point(595, 11);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(73, 27);
            this.homebtn.TabIndex = 14;
            this.homebtn.Text = "Home";
            this.homebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.homebtn.UseVisualStyleBackColor = false;
            // 
            // settingsbtn
            // 
            this.settingsbtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.settingsbtn.BackColor = System.Drawing.Color.Transparent;
            this.settingsbtn.BackgroundImage = global::Facebook.Properties.Resources.settings1;
            this.settingsbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.settingsbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.settingsbtn, BunifuAnimatorNS.DecorationType.None);
            this.settingsbtn.FlatAppearance.BorderSize = 0;
            this.settingsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsbtn.Location = new System.Drawing.Point(898, 3);
            this.settingsbtn.Name = "settingsbtn";
            this.settingsbtn.Size = new System.Drawing.Size(29, 40);
            this.settingsbtn.TabIndex = 13;
            this.settingsbtn.UseVisualStyleBackColor = false;
            // 
            // notificationbtn
            // 
            this.notificationbtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.notificationbtn.BackColor = System.Drawing.Color.Transparent;
            this.notificationbtn.BackgroundImage = global::Facebook.Properties.Resources.notifecations1;
            this.notificationbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.notificationbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.notificationbtn, BunifuAnimatorNS.DecorationType.None);
            this.notificationbtn.FlatAppearance.BorderSize = 0;
            this.notificationbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notificationbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationbtn.Location = new System.Drawing.Point(823, 3);
            this.notificationbtn.Name = "notificationbtn";
            this.notificationbtn.Size = new System.Drawing.Size(29, 40);
            this.notificationbtn.TabIndex = 11;
            this.notificationbtn.UseVisualStyleBackColor = false;
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
            this.Exitbtn.Location = new System.Drawing.Point(927, 0);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(27, 27);
            this.Exitbtn.TabIndex = 7;
            this.Exitbtn.UseVisualStyleBackColor = false;
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
            // messagesbtn
            // 
            this.messagesbtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.messagesbtn.BackColor = System.Drawing.Color.Transparent;
            this.messagesbtn.BackgroundImage = global::Facebook.Properties.Resources.messages1;
            this.messagesbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.messagesbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.messagesbtn, BunifuAnimatorNS.DecorationType.None);
            this.messagesbtn.FlatAppearance.BorderSize = 0;
            this.messagesbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.messagesbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messagesbtn.Location = new System.Drawing.Point(782, 3);
            this.messagesbtn.Name = "messagesbtn";
            this.messagesbtn.Size = new System.Drawing.Size(29, 40);
            this.messagesbtn.TabIndex = 10;
            this.messagesbtn.UseVisualStyleBackColor = false;
            // 
            // chat2
            // 
            this.chat2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chat2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.bunifuTransition1.SetDecoration(this.chat2, BunifuAnimatorNS.DecorationType.None);
            this.chat2.Location = new System.Drawing.Point(770, 158);
            this.chat2.Name = "chat2";
            this.chat2.Size = new System.Drawing.Size(181, 386);
            this.chat2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.bunifuTransition1.SetDecoration(this.tableLayoutPanel1, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 534F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(960, 629);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.titlepar);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 70);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.panel2.Controls.Add(this.tableLayoutPanel3);
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
            this.panel2.Size = new System.Drawing.Size(954, 45);
            this.panel2.TabIndex = 20;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bunifuTransition1.SetDecoration(this.tableLayoutPanel3, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(57, 54);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(662, 355);
            this.tableLayoutPanel3.TabIndex = 17;
            // 
            // profilepicpanel
            // 
            this.profilepicpanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.profilepicpanel.Controls.Add(this.profilebtn);
            this.profilepicpanel.Controls.Add(this.Profilpic);
            this.bunifuTransition1.SetDecoration(this.profilepicpanel, BunifuAnimatorNS.DecorationType.None);
            this.profilepicpanel.Location = new System.Drawing.Point(478, 11);
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
            this.titlepar.Size = new System.Drawing.Size(954, 27);
            this.titlepar.TabIndex = 19;
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
            this.minimizebtn.Location = new System.Drawing.Point(873, 0);
            this.minimizebtn.Name = "minimizebtn";
            this.minimizebtn.Size = new System.Drawing.Size(27, 27);
            this.minimizebtn.TabIndex = 9;
            this.minimizebtn.Text = "-";
            this.minimizebtn.UseVisualStyleBackColor = false;
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
            this.maxmizebtn.Location = new System.Drawing.Point(900, 0);
            this.maxmizebtn.Name = "maxmizebtn";
            this.maxmizebtn.Size = new System.Drawing.Size(27, 27);
            this.maxmizebtn.TabIndex = 8;
            this.maxmizebtn.Text = "+";
            this.maxmizebtn.UseVisualStyleBackColor = false;
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.878151F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.12185F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 201F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.chat2, 2, 0);
            this.bunifuTransition1.SetDecoration(this.tableLayoutPanel2, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 79);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(954, 547);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.frind_cover_profile_photo1, 0, 0);
            this.bunifuTransition1.SetDecoration(this.tableLayoutPanel4, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(62, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 229F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(687, 541);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 517F));
            this.tableLayoutPanel5.Controls.Add(this.groupBox1, 0, 0);
            this.bunifuTransition1.SetDecoration(this.tableLayoutPanel5, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 232);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(681, 306);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.bunifuTransition1.SetDecoration(this.groupBox1, BunifuAnimatorNS.DecorationType.None);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(153)))));
            this.groupBox1.Location = new System.Drawing.Point(3, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 148);
            this.groupBox1.TabIndex = 17;
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
            // frind_cover_profile_photo1
            // 
            this.bunifuTransition1.SetDecoration(this.frind_cover_profile_photo1, BunifuAnimatorNS.DecorationType.None);
            this.frind_cover_profile_photo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frind_cover_profile_photo1.Location = new System.Drawing.Point(3, 3);
            this.frind_cover_profile_photo1.Name = "frind_cover_profile_photo1";
            this.frind_cover_profile_photo1.Size = new System.Drawing.Size(681, 223);
            this.frind_cover_profile_photo1.TabIndex = 2;
            // 
            // frind_profile_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 629);
            this.Controls.Add(this.tableLayoutPanel1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frind_profile_page";
            this.Text = "frind_profile_page";
            ((System.ComponentModel.ISupportInitialize)(this.Profilpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.profilepicpanel.ResumeLayout(false);
            this.profilepicpanel.PerformLayout();
            this.titlepar.ResumeLayout(false);
            this.titlepar.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel profilepicpanel;
        private System.Windows.Forms.Label profilebtn;
        private System.Windows.Forms.PictureBox Profilpic;
        private System.Windows.Forms.Button friendsbtn;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.Button settingsbtn;
        private System.Windows.Forms.Button notificationbtn;
        private System.Windows.Forms.Button messagesbtn;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel titlepar;
        private System.Windows.Forms.Button minimizebtn;
        private System.Windows.Forms.Button maxmizebtn;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private UserControls.chat chat2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private UserControls.frind_cover_profile_photo frind_cover_profile_photo1;


    }
}