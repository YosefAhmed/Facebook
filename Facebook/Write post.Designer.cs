namespace Facebook
{
    partial class Write_post
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.posttxt = new System.Windows.Forms.TextBox();
            this.privacybtn = new System.Windows.Forms.Button();
            this.tagbtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.postbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.posttxt, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.78481F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.21519F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(546, 158);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // posttxt
            // 
            this.posttxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.posttxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.posttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posttxt.ForeColor = System.Drawing.Color.Silver;
            this.posttxt.Location = new System.Drawing.Point(3, 3);
            this.posttxt.Multiline = true;
            this.posttxt.Name = "posttxt";
            this.posttxt.Size = new System.Drawing.Size(540, 109);
            this.posttxt.TabIndex = 2;
            this.posttxt.Text = "What\'s on your mind?";
            this.posttxt.TextChanged += new System.EventHandler(this.posttxt_TextChanged);
            this.posttxt.Enter += new System.EventHandler(this.posttxt_Enter);
            this.posttxt.Leave += new System.EventHandler(this.posttxt_Leave);
            // 
            // privacybtn
            // 
            this.privacybtn.BackColor = System.Drawing.Color.White;
            this.privacybtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.privacybtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.privacybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.privacybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privacybtn.ForeColor = System.Drawing.Color.Gray;
            this.privacybtn.Image = global::Facebook.Properties.Resources.publi;
            this.privacybtn.Location = new System.Drawing.Point(3, 3);
            this.privacybtn.Name = "privacybtn";
            this.privacybtn.Size = new System.Drawing.Size(75, 31);
            this.privacybtn.TabIndex = 4;
            this.privacybtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.privacybtn.UseVisualStyleBackColor = false;
            this.privacybtn.Click += new System.EventHandler(this.privacybtn_Click);
            // 
            // tagbtn
            // 
            this.tagbtn.BackColor = System.Drawing.Color.White;
            this.tagbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tagbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tagbtn.FlatAppearance.BorderSize = 0;
            this.tagbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tagbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagbtn.ForeColor = System.Drawing.Color.Gray;
            this.tagbtn.Image = global::Facebook.Properties.Resources.tag;
            this.tagbtn.Location = new System.Drawing.Point(84, 3);
            this.tagbtn.Name = "tagbtn";
            this.tagbtn.Size = new System.Drawing.Size(98, 31);
            this.tagbtn.TabIndex = 3;
            this.tagbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tagbtn.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel2.Controls.Add(this.button3, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.button2, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.postbtn, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.privacybtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tagbtn, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 118);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(540, 37);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // postbtn
            // 
            this.postbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.postbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.postbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postbtn.FlatAppearance.BorderSize = 0;
            this.postbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.postbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.postbtn.Location = new System.Drawing.Point(438, 3);
            this.postbtn.Name = "postbtn";
            this.postbtn.Size = new System.Drawing.Size(99, 31);
            this.postbtn.TabIndex = 5;
            this.postbtn.Text = "post";
            this.postbtn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::Facebook.Properties.Resources.camera_icon;
            this.button1.Location = new System.Drawing.Point(188, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 31);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = global::Facebook.Properties.Resources.video_camera_icon;
            this.button2.Location = new System.Drawing.Point(230, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 31);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Image = global::Facebook.Properties.Resources.Emotes_face_smile_icon;
            this.button3.Location = new System.Drawing.Point(272, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 31);
            this.button3.TabIndex = 8;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Write_post
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Write_post";
            this.Size = new System.Drawing.Size(546, 158);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox posttxt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button privacybtn;
        private System.Windows.Forms.Button tagbtn;
        private System.Windows.Forms.Button postbtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
