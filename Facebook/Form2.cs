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
    public partial class profilepage : Form
    {
        int mvalx;
        int mvaly;
        int togmove;
        public profilepage()
        {
            InitializeComponent();
            
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O1FM280\SQLEXPRESS;Initial Catalog=Users_Data;Integrated Security=True");

        public static string search_for_friend;

        
        
        
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
        int x,y;
        public int fny()
        {
            y = panel3.Size.Height + panel3.Location.Y;
            return y;
        }
        public int fnx()
        {
            x = panel3.Location.X;
            return x;
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
            tableLayoutPanel5.Top = 500;
            //posts_place.Top = 500;
            //posts_place.Size = new Size(500, 500);
            //panel3.Size = new Size(1500,150);
            //textBox1.Size = new Size(1500, 150);
            //panel4.Size = new Size(1500, 32);
            //posts_place.Size = new Size(1,);
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
            profilebtn.Text = cover_profile_photo.fullName;
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

        private void postbtn_Click(object sender, EventArgs e)
        {
            //posts_place.Controls.Add(NewUC(textBox1.Text));
            //MessageBox.Show(" X: " + Convert.ToString(posts_place.Location.X) + " Y: " + Convert.ToString(posts_place.Location.Y));
        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {
            //System.Windows.Forms.FlowLayoutPanel FL = new System.Windows.Forms.FlowLayoutPanel();
            //tableLayoutPanel5.Controls.Add(FL);
        }

        private void minimizebtn_Click(object sender, EventArgs e)
       {
           WindowState = FormWindowState.Minimized;
       }
        int positionY = 0;
        public Facebook.post NewUC(string text)
        {
            Facebook.post UC = new Facebook.post();
            UC.labeling(text);
            //UC.sizing(UC.Y_loc());
            //this.Controls.Add(UC);
            UC.Top = panel3.Location.Y + panel3.Size.Height;
            UC.Left = panel3.Location.X;
            if(positionY == 0)
            {
                positionY += UC.Top;
            }
            positionY = (UC.Size.Height);
            return UC;
        }

       private void homebtn_Click(object sender, EventArgs e)
       {
           Homepage H = new Homepage();
           H.Show();
           this.Close();
       }

       private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
       {

       }
       //public string fname2;
       //public string sname2;
       //public string allname2;
       //List<String> names = new List<string>(); 

       private void searchbtn_Click(object sender, EventArgs e)
       {
           Search_List search = new Search_List();
           
           search_for_friend = searchtxt.Text;
           

           //try
           //{
           //SqlCommand cmd = new SqlCommand("Select First_Name,Second_Name from Reg_DB where First_Name='" + searchtxt.Text + "'", con);
           //con.Open();
           //SqlDataReader dr = cmd.ExecuteReader();

           //while (dr.Read())
           //{
           //    fname2 = dr["First_Name"].ToString();
           //    sname2 = dr["Second_Name"].ToString();
           //    while (fname2 == null || sname2 == null)
           //    {
           //        break;
           //    }
           //    allname2 = fname2 + " " + sname2;
           //    names.Add(allname2);
           //    search_for_friend = allname2;

           //}
           //dr.Close();
           //con.Close();


            search.Show();
           //catch (Exception ex)
           //{ MessageBox.Show(ex.Message); }
           
             
           
       }

       private void cover_profile_photo1_Load(object sender, EventArgs e)
       {

       }



    }
}
