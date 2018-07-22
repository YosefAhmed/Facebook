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
using Facebook.UserControls;
using System.IO;

namespace Facebook
{
    public partial class searching : Form
    {
        public searching()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O1FM280\SQLEXPRESS;Initial Catalog=Users_Data;Integrated Security=True");
        
        int positionY;
        public Point mouslocation;
       
        private void titlepar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point Mousepose = Control.MousePosition;
                Mousepose.Offset(mouslocation.X, mouslocation.Y);
                Location = Mousepose;
            }
        }

        private void titlepar_MouseDown(object sender, MouseEventArgs e)
        {
            {
                mouslocation = new Point(-e.X, -e.Y);
            }
        }

        private void titlepar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        
        public string elsearchfriend;
        private void searchbtn_Click(object sender, EventArgs e)
        {
            
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Reg_DB where Full_Name like '%" + searchtxt.Text + "%'", con);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    search_friend ss = new search_friend();
                    ss.USerNameforfriend = rdr["UsernameOrEmail"].ToString();
                    ss.loadsearch(rdr["Full_Name"].ToString());
                    ss.loadpic(rdr["profileimg"].ToString());
                   flowLayoutPanel1.Controls.Add(ss);
                }
     
            con.Close();
        }
       
        private void searching_Load(object sender, EventArgs e)
        {
            searchtxt.Text = profilepage.searchfor;
        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
        }
    }
}
//SqlCommand cmd2 = new SqlCommand("select User_2 from Friends where User_1='" + rdr["UsernameOrEmail"].ToString() + "'", con);
//rdr.Close();
//                SqlDataReader rdr2 = cmd.ExecuteReader();
                
//                while (rdr2.Read())
//                {
//                 elsearchfriend= rdr2["UsernameOrEmail"].ToString();
//SqlCommand cmd3 = new SqlCommand("select User_1 from Friends where User_2='" + rdr2["UsernameOrEmail"].ToString() + "'", con);
//rdr2.Close();
//                    SqlDataReader rdr3 = cmd.ExecuteReader();
//                    while (rdr3.Read())
//                    {
//                        if (rdr3["UsernameOrEmail"].ToString() == UserControl1.userName)
//                        {
//                            ss.countmutual++;
//                        }
                        
//                    }
//                    rdr3.Close();
//                }