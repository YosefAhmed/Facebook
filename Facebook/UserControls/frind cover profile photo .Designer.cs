namespace Facebook.UserControls
{
    partial class frind_cover_profile_photo
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
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.profilepic = new System.Windows.Forms.PictureBox();
            this.coverimage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.profilepic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverimage)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(178, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "(Username)";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Location = new System.Drawing.Point(668, 211);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(31, 27);
            this.button3.TabIndex = 33;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Location = new System.Drawing.Point(577, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 27);
            this.button2.TabIndex = 32;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.BackgroundImage = global::Facebook.Properties.Resources.Add_frind;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(466, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 27);
            this.button1.TabIndex = 31;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // profilepic
            // 
            this.profilepic.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.profilepic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profilepic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profilepic.Image = global::Facebook.Properties.Resources.man_icon;
            this.profilepic.Location = new System.Drawing.Point(22, 126);
            this.profilepic.Name = "profilepic";
            this.profilepic.Size = new System.Drawing.Size(150, 150);
            this.profilepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilepic.TabIndex = 28;
            this.profilepic.TabStop = false;
            // 
            // coverimage
            // 
            this.coverimage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.coverimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coverimage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.coverimage.Dock = System.Windows.Forms.DockStyle.Top;
            this.coverimage.Location = new System.Drawing.Point(0, 0);
            this.coverimage.Name = "coverimage";
            this.coverimage.Size = new System.Drawing.Size(717, 248);
            this.coverimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coverimage.TabIndex = 27;
            this.coverimage.TabStop = false;
            // 
            // frind_cover_profile_photo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.profilepic);
            this.Controls.Add(this.coverimage);
            this.Name = "frind_cover_profile_photo";
            this.Size = new System.Drawing.Size(717, 281);
            ((System.ComponentModel.ISupportInitialize)(this.profilepic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox profilepic;
        private System.Windows.Forms.PictureBox coverimage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
