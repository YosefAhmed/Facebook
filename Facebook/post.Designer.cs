namespace Facebook
{
    partial class post
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(post));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cry = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.Angry = new System.Windows.Forms.Button();
            this.Love = new System.Windows.Forms.Button();
            this.Haha = new System.Windows.Forms.Button();
            this.Like = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.textBox1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(558, 364);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(546, 176);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.cry);
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.Angry);
            this.panel1.Controls.Add(this.Love);
            this.panel1.Controls.Add(this.Haha);
            this.panel1.Controls.Add(this.Like);
            this.panel1.Location = new System.Drawing.Point(3, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 48);
            this.panel1.TabIndex = 8;
            this.panel1.Visible = false;
            // 
            // cry
            // 
            this.cry.BackColor = System.Drawing.Color.Transparent;
            this.cry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cry.BackgroundImage")));
            this.cry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cry.Location = new System.Drawing.Point(182, -1);
            this.cry.Name = "cry";
            this.cry.Size = new System.Drawing.Size(50, 46);
            this.cry.TabIndex = 5;
            this.cry.UseVisualStyleBackColor = false;
            this.cry.Click += new System.EventHandler(this.Like_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(230, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(50, 46);
            this.close.TabIndex = 4;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Angry
            // 
            this.Angry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Angry.BackgroundImage")));
            this.Angry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Angry.Location = new System.Drawing.Point(136, 0);
            this.Angry.Name = "Angry";
            this.Angry.Size = new System.Drawing.Size(50, 46);
            this.Angry.TabIndex = 3;
            this.Angry.UseVisualStyleBackColor = true;
            this.Angry.Click += new System.EventHandler(this.Like_Click);
            // 
            // Love
            // 
            this.Love.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Love.BackgroundImage")));
            this.Love.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Love.Location = new System.Drawing.Point(89, 0);
            this.Love.Name = "Love";
            this.Love.Size = new System.Drawing.Size(50, 46);
            this.Love.TabIndex = 2;
            this.Love.UseVisualStyleBackColor = true;
            this.Love.Click += new System.EventHandler(this.Like_Click);
            // 
            // Haha
            // 
            this.Haha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Haha.BackgroundImage")));
            this.Haha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Haha.Location = new System.Drawing.Point(45, 0);
            this.Haha.Name = "Haha";
            this.Haha.Size = new System.Drawing.Size(50, 46);
            this.Haha.TabIndex = 1;
            this.Haha.UseVisualStyleBackColor = true;
            this.Haha.Click += new System.EventHandler(this.Like_Click);
            // 
            // Like
            // 
            this.Like.Image = ((System.Drawing.Image)(resources.GetObject("Like.Image")));
            this.Like.Location = new System.Drawing.Point(-1, 0);
            this.Like.Name = "Like";
            this.Like.Size = new System.Drawing.Size(50, 46);
            this.Like.TabIndex = 0;
            this.Like.UseVisualStyleBackColor = true;
            this.Like.Click += new System.EventHandler(this.Like_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(3, 239);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(546, 44);
            this.panel2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(-3, -8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "Like";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(257, -8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(289, 65);
            this.button2.TabIndex = 1;
            this.button2.Text = "Comment";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(60, 289);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(448, 55);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "write a comment ....";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Location = new System.Drawing.Point(3, 289);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 56);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // post
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "post";
            this.Size = new System.Drawing.Size(558, 371);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cry;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button Angry;
        private System.Windows.Forms.Button Love;
        private System.Windows.Forms.Button Haha;
        private System.Windows.Forms.Button Like;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
