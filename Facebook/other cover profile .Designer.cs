namespace Facebook
{
    partial class other_cover_profile
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
            this.profilepic = new System.Windows.Forms.PictureBox();
            this.coverimage = new System.Windows.Forms.PictureBox();
            this.AddFriend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profilepic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverimage)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(178, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "(Username)";
            // 
            // profilepic
            // 
            this.profilepic.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.profilepic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profilepic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profilepic.Image = global::Facebook.Properties.Resources.man_icon;
            this.profilepic.Location = new System.Drawing.Point(22, 127);
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
            this.coverimage.Size = new System.Drawing.Size(632, 240);
            this.coverimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coverimage.TabIndex = 27;
            this.coverimage.TabStop = false;
            // 
            // AddFriend
            // 
            this.AddFriend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddFriend.BackColor = System.Drawing.Color.Gainsboro;
            this.AddFriend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFriend.Location = new System.Drawing.Point(465, 205);
            this.AddFriend.Name = "AddFriend";
            this.AddFriend.Size = new System.Drawing.Size(84, 28);
            this.AddFriend.TabIndex = 31;
            this.AddFriend.Text = "Add Friend";
            this.AddFriend.UseVisualStyleBackColor = false;
            // 
            // other_cover_profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddFriend);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.profilepic);
            this.Controls.Add(this.coverimage);
            this.Name = "other_cover_profile";
            this.Size = new System.Drawing.Size(632, 281);
            ((System.ComponentModel.ISupportInitialize)(this.profilepic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox profilepic;
        private System.Windows.Forms.PictureBox coverimage;
        private System.Windows.Forms.Button AddFriend;
    }
}
