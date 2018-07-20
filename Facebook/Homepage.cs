using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Facebook
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.BLEND);
            aperancemax();
        }
      
        public void aperancemax()//for maximize 
        {
            WindowState = FormWindowState.Maximized;
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
        public void aperancenormal()//for normal
        {
            WindowState = FormWindowState.Normal;
            this.panel1.Size = new Size(800, 45);
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



        SqlConnection con = new SqlConnection(@"Data Source=MEDO-GAD\SQLEXPRESS;Initial Catalog=FBaccount;Integrated Security=True");
        //private void postbtn_Click_1(object sender, EventArgs e)
        //{
        //    //  flowLayoutPanel1.Controls.Add(p);
        //    con.Open();
        //    //SqlCommand cmd = new SqlCommand("select PID from Posts where ",con);
        //    //int x = (int)cmd.ExecuteScalar();
        //    //String quiry = "INSERT INTO Posts(posts) VALUES('"+posttxt.Text+"')";
        //    SqlCommand cmd = new SqlCommand(quiry, con);
        //    cmd.ExecuteNonQuery();
        //    con.Close();
        //}

        //private void posttxt_Enter_1(object sender, EventArgs e)
        //{
        //    if (posttxt.Text == "What's on your mind?")
        //    {
        //        posttxt.Clear();
        //        posttxt.Font = new Font(posttxt.Font.FontFamily, 10.0f);
        //        posttxt.ForeColor = Color.Black;
        //    }
        //}
        //private void posttxt_Leave_1(object sender, EventArgs e)
        //{
        //    if (posttxt.Text == "")
        //    {
        //        posttxt.ForeColor = Color.Silver;
        //        posttxt.Font = new Font(posttxt.Font.FontFamily, 14.0f,FontStyle.Bold);
        //        posttxt.Text = "What's on your mind?";
        //    }
        //}

        int togmover, mvx, mvy;
        private void titlepar_MouseDown_1(object sender, MouseEventArgs e)
        {
            togmover = 1;
            mvx = e.X;
            mvy = e.Y;
        }
        private void titlepar_MouseUp(object sender, MouseEventArgs e)
        {
            togmover = 0;
        }
        private void titlepar_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (togmover == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mvx, MousePosition.Y - mvy);
            }
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
        private void Exitbtn_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void searchtxt_Enter_2(object sender, EventArgs e)
        {
            if (searchtxt.Text == "Search")
            {
                searchtxt.Clear();
                searchtxt.ForeColor = Color.Black;
            }
        }
        private void searchtxt_Leave_2(object sender, EventArgs e)
        {
            if (searchtxt.Text == "")
            {
                searchtxt.ForeColor = Color.Silver;
                searchtxt.Text = "Search";
            }
        }


        private void profilebtn_Click(object sender, EventArgs e)
        {
            profilepage F = new profilepage();
            F.Show();
            this.Close();
        }
        private void profilepic_Click(object sender, EventArgs e)
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
        private void facebookicon_Click(object sender, EventArgs e)
        {
            Homepage H = new Homepage();
            H.Show();
            this.Close();
        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
