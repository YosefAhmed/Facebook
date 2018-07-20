namespace Facebook
{
    partial class cover_profile_photo
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
            this.uploadcoverbtn = new System.Windows.Forms.Button();
            this.uploadprofilebtn = new System.Windows.Forms.Button();
            this.profilepic = new System.Windows.Forms.PictureBox();
            this.coverimage = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profilepic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverimage)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(131, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "(Username)";
            // 
            // uploadcoverbtn
            // 
            this.uploadcoverbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uploadcoverbtn.BackColor = System.Drawing.Color.Transparent;
            this.uploadcoverbtn.BackgroundImage = global::Facebook.Properties.Resources.up_icon;
            this.uploadcoverbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uploadcoverbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uploadcoverbtn.Location = new System.Drawing.Point(603, 158);
            this.uploadcoverbtn.Name = "uploadcoverbtn";
            this.uploadcoverbtn.Size = new System.Drawing.Size(25, 23);
            this.uploadcoverbtn.TabIndex = 26;
            this.uploadcoverbtn.UseVisualStyleBackColor = false;
            this.uploadcoverbtn.Click += new System.EventHandler(this.uploadcoverbtn_Click);
            // 
            // uploadprofilebtn
            // 
            this.uploadprofilebtn.BackColor = System.Drawing.Color.Transparent;
            this.uploadprofilebtn.BackgroundImage = global::Facebook.Properties.Resources.up_icon;
            this.uploadprofilebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uploadprofilebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uploadprofilebtn.Location = new System.Drawing.Point(102, 199);
            this.uploadprofilebtn.Name = "uploadprofilebtn";
            this.uploadprofilebtn.Size = new System.Drawing.Size(23, 18);
            this.uploadprofilebtn.TabIndex = 24;
            this.uploadprofilebtn.UseVisualStyleBackColor = false;
            this.uploadprofilebtn.Click += new System.EventHandler(this.uploadprofilebtn_Click);
            // 
            // profilepic
            // 
            this.profilepic.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.profilepic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profilepic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profilepic.Image = global::Facebook.Properties.Resources.man_icon;
            this.profilepic.Location = new System.Drawing.Point(22, 116);
            this.profilepic.Name = "profilepic";
            this.profilepic.Size = new System.Drawing.Size(101, 101);
            this.profilepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilepic.TabIndex = 23;
            this.profilepic.TabStop = false;
            this.profilepic.Click += new System.EventHandler(this.profilepic_Click);
            // 
            // coverimage
            // 
            this.coverimage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.coverimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coverimage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.coverimage.Dock = System.Windows.Forms.DockStyle.Top;
            this.coverimage.Location = new System.Drawing.Point(0, 0);
            this.coverimage.Name = "coverimage";
            this.coverimage.Size = new System.Drawing.Size(632, 185);
            this.coverimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coverimage.TabIndex = 22;
            this.coverimage.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(473, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Save changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cover_profile_photo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uploadcoverbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uploadprofilebtn);
            this.Controls.Add(this.profilepic);
            this.Controls.Add(this.coverimage);
            this.Name = "cover_profile_photo";
            this.Size = new System.Drawing.Size(632, 217);
            this.Load += new System.EventHandler(this.cover_profile_photo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilepic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uploadcoverbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button uploadprofilebtn;
        private System.Windows.Forms.PictureBox profilepic;
        private System.Windows.Forms.PictureBox coverimage;
        private System.Windows.Forms.Button button1;
    }
}
