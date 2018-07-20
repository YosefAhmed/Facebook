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

namespace Facebook
{
    public partial class Search_friend : UserControl
    {
        public Search_friend()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=MEDO-GAD\SQLEXPRESS;Initial Catalog=Users_Data;Integrated Security=True");

        public string fname2;
        public string sname2;
        public string allname2;
        List<String> names = new List<string>();
        public static string previous;
        public static int c=0;
        public static int namesco;

        private void Search_friend_Load(object sender, EventArgs e)
        {
          
            //friend_name.Text = profilepage.search_for_friend;
            SqlCommand cmd = new SqlCommand("Select First_Name,Second_Name from Reg_DB where First_Name='" + profilepage.search_for_friend + "'", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                fname2 = dr["First_Name"].ToString();
                sname2 = dr["Second_Name"].ToString();
                while (fname2 == null || sname2 == null)
                {
                    break;
                }
                allname2 = fname2 + " " + sname2;
                names.Add(allname2);
            }
            dr.Close();
            con.Close();
            namesco = names.Count;
            for (int i = c; i < names.Count; i++)
            {
                if (previous == names[i])
                { break; }
                friend_name.Text = names[i];
                c++;
                
            }
            previous = friend_name.Text;
        }
    }
}
