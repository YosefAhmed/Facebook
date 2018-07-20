using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facebook.UserControls
{
    public partial class other_profile : Form
    {
        public other_profile()
        {
            InitializeComponent();
        }

        public void aperancemax()//for maximize 
        {
            WindowState = FormWindowState.Maximized;
            // this.bunifuElipse1.ElipseRadius = 0;
            maxmizebtn.Left = 1293;
            minimizebtn.Left = 1260;
            Exitbtn.Left = 1329;
            friendsbtn.Left = 935;
            messagesbtn.Left = 985;
            notificationbtn.Left = 1025;
            settingsbtn.Left = 1075;
            searchtxt.Left = 250;
            this.searchtxt.Size = new Size(435, 20);
            searchbtn.Left = 657;
            homebtn.Location = new Point(845, 11);
            profilepicpanel.Location = new Point(735, 11);
            this.other_cover_profile1.Size = new Size(915, 281);
        }
        public void aperancenormal()//for normalize
        {
            WindowState = FormWindowState.Normal;
            this.titlepar.Size = new Size(800, 45);
            maxmizebtn.Location = new Point(726, 2);
            minimizebtn.Location = new Point(692, 2);
            Exitbtn.Location = new Point(764, 2);
            friendsbtn.Location = new Point(663, 3);
            messagesbtn.Location = new Point(708, 3);
            notificationbtn.Location = new Point(747, 3);
            settingsbtn.Location = new Point(822, 3);
            searchtxt.Location = new Point(83, 8);
            this.searchtxt.Size = new Size(317, 27);
            searchbtn.Location = new Point(371, 11);
            homebtn.Location = new Point(553, 11);
            profilepicpanel.Location = new Point(447, 11);
        }
        private void Exitbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void maxmizebtn_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {

                aperancemax();
            }
            else
            {
                aperancenormal();
            }
        }

        private void minimizebtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void profilebtn_Click(object sender, EventArgs e)
        {
            profilepage F = new profilepage();
            F.Show();
            this.Close();
        }

        private void Profilpic_Click(object sender, EventArgs e)
        {
            profilepage F = new profilepage();
            F.Show();
            this.Close();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Homepage H = new Homepage();
            H.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Homepage H = new Homepage();
            H.Show();
            this.Close();
        }
    }
}
