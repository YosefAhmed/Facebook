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
            this.emojy = new System.Windows.Forms.Button();
            this.uploadvideo = new System.Windows.Forms.Button();
            this.uploadphoto = new System.Windows.Forms.Button();
            this.postbtn = new System.Windows.Forms.Button();
            this.privacybtn = new System.Windows.Forms.Button();
            this.tagbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.posttxt, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.78481F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.21519F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
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
            this.posttxt.Enter += new System.EventHandler(this.posttxt_Enter);
            this.posttxt.Leave += new System.EventHandler(this.posttxt_Leave);
            // 
            // emojy
            // 
            this.emojy.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.emojy.BackColor = System.Drawing.Color.Transparent;
            this.emojy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emojy.FlatAppearance.BorderSize = 0;
            this.emojy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emojy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emojy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emojy.Image = global::Facebook.Properties.Resources.Emotes_face_smile_icon;
            this.emojy.Location = new System.Drawing.Point(271, 0);
            this.emojy.Name = "emojy";
            this.emojy.Size = new System.Drawing.Size(36, 37);
            this.emojy.TabIndex = 8;
            this.emojy.UseVisualStyleBackColor = false;
            // 
            // uploadvideo
            // 
            this.uploadvideo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.uploadvideo.BackColor = System.Drawing.Color.Transparent;
            this.uploadvideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uploadvideo.FlatAppearance.BorderSize = 0;
            this.uploadvideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadvideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadvideo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uploadvideo.Image = global::Facebook.Properties.Resources.video_camera_icon;
            this.uploadvideo.Location = new System.Drawing.Point(229, 0);
            this.uploadvideo.Name = "uploadvideo";
            this.uploadvideo.Size = new System.Drawing.Size(36, 37);
            this.uploadvideo.TabIndex = 7;
            this.uploadvideo.UseVisualStyleBackColor = false;
            // 
            // uploadphoto
            // 
            this.uploadphoto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.uploadphoto.BackColor = System.Drawing.Color.Transparent;
            this.uploadphoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uploadphoto.FlatAppearance.BorderSize = 0;
            this.uploadphoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadphoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadphoto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uploadphoto.Image = global::Facebook.Properties.Resources.camera_icon;
            this.uploadphoto.Location = new System.Drawing.Point(187, 0);
            this.uploadphoto.Name = "uploadphoto";
            this.uploadphoto.Size = new System.Drawing.Size(36, 37);
            this.uploadphoto.TabIndex = 6;
            this.uploadphoto.UseVisualStyleBackColor = false;
            // 
            // postbtn
            // 
            this.postbtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.postbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.postbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.postbtn.FlatAppearance.BorderSize = 0;
            this.postbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.postbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.postbtn.Location = new System.Drawing.Point(441, 0);
            this.postbtn.Name = "postbtn";
            this.postbtn.Size = new System.Drawing.Size(99, 37);
            this.postbtn.TabIndex = 5;
            this.postbtn.Text = "post";
            this.postbtn.UseVisualStyleBackColor = false;
            // 
            // privacybtn
            // 
            this.privacybtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.privacybtn.BackColor = System.Drawing.Color.White;
            this.privacybtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.privacybtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.privacybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.privacybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privacybtn.ForeColor = System.Drawing.Color.Gray;
            this.privacybtn.Image = global::Facebook.Properties.Resources.publi;
            this.privacybtn.Location = new System.Drawing.Point(0, 0);
            this.privacybtn.Name = "privacybtn";
            this.privacybtn.Size = new System.Drawing.Size(75, 37);
            this.privacybtn.TabIndex = 4;
            this.privacybtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.privacybtn.UseVisualStyleBackColor = false;
            // 
            // tagbtn
            // 
            this.tagbtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tagbtn.BackColor = System.Drawing.Color.White;
            this.tagbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tagbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tagbtn.FlatAppearance.BorderSize = 0;
            this.tagbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tagbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagbtn.ForeColor = System.Drawing.Color.Gray;
            this.tagbtn.Image = global::Facebook.Properties.Resources.tag;
            this.tagbtn.Location = new System.Drawing.Point(82, 0);
            this.tagbtn.Name = "tagbtn";
            this.tagbtn.Size = new System.Drawing.Size(98, 37);
            this.tagbtn.TabIndex = 3;
            this.tagbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tagbtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.emojy);
            this.panel1.Controls.Add(this.tagbtn);
            this.panel1.Controls.Add(this.postbtn);
            this.panel1.Controls.Add(this.uploadvideo);
            this.panel1.Controls.Add(this.privacybtn);
            this.panel1.Controls.Add(this.uploadphoto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 37);
            this.panel1.TabIndex = 3;
            // 
            // Write_post
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Write_post";
            this.Size = new System.Drawing.Size(546, 158);
            this.Load += new System.EventHandler(this.Write_post_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox posttxt;
        private System.Windows.Forms.Button privacybtn;
        private System.Windows.Forms.Button tagbtn;
        private System.Windows.Forms.Button postbtn;
        private System.Windows.Forms.Button emojy;
        private System.Windows.Forms.Button uploadvideo;
        private System.Windows.Forms.Button uploadphoto;
        private System.Windows.Forms.Panel panel1;
    }
}
