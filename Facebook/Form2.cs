using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facebook
{
    public partial class profilepage : Form
    {
        int mvalx;
        int mvaly;
        int togmove;
        public profilepage()
        {
            InitializeComponent();
            
        }

        
        



 


        private void titlepar_MouseDown(object sender, MouseEventArgs e)
        {
            togmove = 1;
            mvalx = e.X;
            mvaly = e.Y;
        }

        private void titlepar_MouseUp(object sender, MouseEventArgs e)
        {
            togmove = 0;
        }

        private void titlepar_MouseMove(object sender, MouseEventArgs e)
        {
            if (togmove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mvalx, MousePosition.Y - mvaly);
            }
        }


       


        private void searchtxt_Enter(object sender, EventArgs e)
        {
            if (searchtxt.Text == "Search")
            {
                searchtxt.Clear();
                searchtxt.ForeColor = Color.Black;
            }
        }
        private void searchtxt_Leave(object sender, EventArgs e)
        {
            if (searchtxt.Text == "")
            {
                searchtxt.ForeColor = Color.Silver;
                searchtxt.Text = "Search";
            }
        }

        int togmover, mvx, mvy;
        private void titlepar_MouseDown_2(object sender, MouseEventArgs e)
        {
            togmover = 1;
            mvx = e.X;
            mvy = e.Y;
        }
        private void titlepar_MouseMove_2(object sender, MouseEventArgs e)
        {
            if (togmover == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mvx, MousePosition.Y - mvy);
            }
        }
        private void titlepar_MouseUp_1(object sender, MouseEventArgs e)
        {
            togmover = 0;
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


        private void profilepage_Load(object sender, EventArgs e)
        {
            //WinAPI.AnimateWindow(this.Handle, 500, WinAPI.BLEND);
            aperancemax();
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

        private void Exitbtn_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
        }
       private void maximizbtn_Click(object sender, EventArgs e)
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

       private void homebtn_Click(object sender, EventArgs e)
       {
           Homepage H = new Homepage();
           H.Show();
           this.Close();
       }



    }
}
