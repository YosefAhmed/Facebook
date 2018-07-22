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
    public partial class comments : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-99I30T0\SQLEXPRESSS;Initial Catalog=Users_Data;Integrated Security=True");
        public comments()
        {
            InitializeComponent();
        }

        public int commentID, id;
        public void commentlbl(string text)
        {
            con.Open();
            SqlCommand cmd3 = new SqlCommand("insert into comments (userName , postID , text) values ('" + UserControl1.userName + "','" + id.ToString() + "','" + text + "')", con);
            cmd3.ExecuteNonQuery();
            SqlCommand cmd2 = new SqlCommand("select MAX(commentID) from comments", con);
            commentID = (int)cmd2.ExecuteScalar();
            con.Close();
            label2.Text = text;
        }
        public void commentlbl_upload(string text /*, int postID , int comID*/)
        {
            label2.Text = text;
            //id = postID;
            //commentID = comID;
        }

    }
}
