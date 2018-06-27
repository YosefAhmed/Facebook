using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facebook
{
    public partial class cover_profile_photo : UserControl
    {
        public cover_profile_photo()
        {
            InitializeComponent();
        }

        private void uploadcoverbtn_Click(object sender, EventArgs e)
        {
            string imagelocation1 = "";

            try
            {
                OpenFileDialog dialog2 = new OpenFileDialog();
                dialog2.Filter = "jpg files(*.jpg)|*.jpg | PNG files(*.png)|*.png|All files(*.*)|*.*";
                if (dialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    imagelocation1 = dialog2.FileName;

                coverimage.ImageLocation = imagelocation1;
            }
            catch (Exception)
            {
                MessageBox.Show("An Error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void uploadprofilebtn_Click(object sender, EventArgs e)
        {
            string imagelocation2 = "";

            try
            {
                OpenFileDialog dialog2 = new OpenFileDialog();
                dialog2.Filter = "jpg files(*.jpg)|*.jpg | PNG files(*.png)|*.png|All files(*.*)|*.*";
                if (dialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    imagelocation2 = dialog2.FileName;

                profilepic.ImageLocation = imagelocation2;
            }
            catch (Exception)
            {
                MessageBox.Show("An Error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
