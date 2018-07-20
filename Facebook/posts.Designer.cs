namespace Facebook
{
    partial class posts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(posts));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cry = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.Angry = new System.Windows.Forms.Button();
            this.Love = new System.Windows.Forms.Button();
            this.Haha = new System.Windows.Forms.Button();
            this.Like = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.textBox1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 280);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(497, 91);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 60);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBox1.Location = new System.Drawing.Point(83, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(388, 60);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "write a comment ...";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(6, 37);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(482, 139);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cry);
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.Angry);
            this.panel1.Controls.Add(this.Love);
            this.panel1.Controls.Add(this.Haha);
            this.panel1.Controls.Add(this.Like);
            this.panel1.Location = new System.Drawing.Point(7, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 43);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // cry
            // 
            this.cry.BackColor = System.Drawing.Color.Transparent;
            this.cry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cry.BackgroundImage")));
            this.cry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cry.Location = new System.Drawing.Point(185, -2);
            this.cry.Name = "cry";
            this.cry.Size = new System.Drawing.Size(50, 46);
            this.cry.TabIndex = 11;
            this.cry.UseVisualStyleBackColor = false;
            this.cry.Click += new System.EventHandler(this.Like_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(232, -1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(50, 46);
            this.close.TabIndex = 10;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Angry
            // 
            this.Angry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Angry.BackgroundImage")));
            this.Angry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Angry.Location = new System.Drawing.Point(139, -1);
            this.Angry.Name = "Angry";
            this.Angry.Size = new System.Drawing.Size(50, 46);
            this.Angry.TabIndex = 9;
            this.Angry.UseVisualStyleBackColor = true;
            this.Angry.Click += new System.EventHandler(this.Like_Click);
            // 
            // Love
            // 
            this.Love.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Love.BackgroundImage")));
            this.Love.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Love.Location = new System.Drawing.Point(92, -1);
            this.Love.Name = "Love";
            this.Love.Size = new System.Drawing.Size(50, 46);
            this.Love.TabIndex = 8;
            this.Love.UseVisualStyleBackColor = true;
            this.Love.Click += new System.EventHandler(this.Like_Click);
            // 
            // Haha
            // 
            this.Haha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Haha.BackgroundImage")));
            this.Haha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Haha.Location = new System.Drawing.Point(48, -1);
            this.Haha.Name = "Haha";
            this.Haha.Size = new System.Drawing.Size(50, 46);
            this.Haha.TabIndex = 7;
            this.Haha.UseVisualStyleBackColor = true;
            this.Haha.Click += new System.EventHandler(this.Like_Click);
            // 
            // Like
            // 
            this.Like.Image = ((System.Drawing.Image)(resources.GetObject("Like.Image")));
            this.Like.Location = new System.Drawing.Point(2, -1);
            this.Like.Name = "Like";
            this.Like.Size = new System.Drawing.Size(50, 46);
            this.Like.TabIndex = 6;
            this.Like.UseVisualStyleBackColor = true;
            this.Like.Click += new System.EventHandler(this.Like_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(3, 227);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(494, 47);
            this.panel2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(234, -9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(281, 71);
            this.button2.TabIndex = 1;
            this.button2.Text = "Comment";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Location = new System.Drawing.Point(0, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 16);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Location = new System.Drawing.Point(0, 346);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(497, 22);
            this.panel4.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Location = new System.Drawing.Point(490, 30);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 338);
            this.panel5.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel6.Location = new System.Drawing.Point(0, 30);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 338);
            this.panel6.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Like";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // posts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "posts";
            this.Size = new System.Drawing.Size(500, 371);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cry;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button Angry;
        private System.Windows.Forms.Button Love;
        private System.Windows.Forms.Button Haha;
        private System.Windows.Forms.Button Like;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button1;
    }
}
