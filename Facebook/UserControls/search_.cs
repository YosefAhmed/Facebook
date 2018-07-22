using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Facebook.UserControls
{
    public partial class search_friend : UserControl
    {
        public search_friend()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-99I30T0\SQLEXPRESSS;Initial Catalog=Users_Data;Integrated Security=True");
        public string add = "Request";
        public int countmutual=0;
        private void search_friend_Load(object sender, EventArgs e)
        {

        }
        
        public void loadsearch(string name)
        {
            friend_name.Text = name;
            UserControl1.userNameforfriend=name;
            //MessageBox.Show(senttome(USerNameforfriend).ToString());
            //if (countmutual > 0)
            //{ linkLabel1.Text = countmutual + "Mutual Friends"; }
            if (senttome(USerNameforfriend))
            { button1.Text = "Respond"; }
            else if (senttohim(USerNameforfriend))
            {
                button1.Text = "Request sent";
            }
            
        }
        public void loadpic(string path)
        {
            
            if (path !="")
            {
                friendpic.Image = Image.FromFile(path);
            }
        }

        public string USerNameforfriend;
        private bool senttome(string USerNameforfriend ) {
            con.Open();
           
            SqlCommand cmd = new SqlCommand("select count(*) from Friends where User_1='" + USerNameforfriend + "'and User_2='"+UserControl1.userName+"' and Relation='"+add+"'", con);
            int cnt = (int)cmd.ExecuteScalar();
            con.Close();
            if (cnt>0)
                return true;
            else 
                return false;
           
        }
        private bool senttohim(string USerNameforfriend)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("select count(*) from Friends where User_2='" + USerNameforfriend + "'and User_1='" + UserControl1.userName + "' and Relation='" + add + "'", con);
            int cnt = (int)cmd.ExecuteScalar();
            con.Close();
            if (cnt > 0)
                return true;
            else
                return false;

        }
        private void button1_Click(object sender, EventArgs e)
        { 
            con.Open();
            if (button1.Text == "Add Friend")
            {
                SqlCommand cmd = new SqlCommand("insert into Friends(User_1,User_2,Relation)values('" + UserControl1.userName + "','" + USerNameforfriend + "','" + add + "')", con);
                cmd.ExecuteNonQuery();
                button1.Text = "Request sent";
            }
            else if (button1.Text == "Respond")
            {
                SqlCommand cmd = new SqlCommand("Update Friends set Relation='Accepted'where User_2='" + USerNameforfriend + "'and User_1='" + UserControl1.userName + "'", con);
                cmd.ExecuteNonQuery();
                button1.Text = "Friends";
            }
            else if (button1.Text == "Request sent")
            {
                SqlCommand cmd = new SqlCommand("Delete from Friends where User_2='" + USerNameforfriend + "'and User_1='" + UserControl1.userName + "'", con);
                cmd.ExecuteNonQuery();
                button1.Text = "Add Friend";
            }
           
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserControl1.userNameforfriend = USerNameforfriend;
            profilepage pro = new profilepage();
            pro.Show();
        }
    }
}
