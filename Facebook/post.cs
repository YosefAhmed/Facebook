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
    public partial class post : UserControl
    {
        public post()
        {
            InitializeComponent();
        }
        SqlConnection con = Account.con;
        int id;
        public void labeling (string text)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into posts (userId,text) values('" + UserControl1.userName + "','" + text + "')", con);
            cmd.ExecuteNonQuery();
            SqlCommand cmd2 = new SqlCommand("select MAX(postID) from posts", con);
            id = (int)cmd2.ExecuteScalar();
            con.Close();
            label1.Text = text;
        }

        private void Like_Click(object sender, EventArgs e)
        {
            //Button b = (Button)sender;
            Button b = (Button)sender;
            b.BackColor = Color.Transparent;
            string react = b.Name;
            button1.Text = react;
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into reacts (userName,postID,react) values('" + UserControl1.userName + "','" + id.ToString() + "','" + react + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            panel1.Hide();

        }

        private void close_Click(object sender, EventArgs e)
        {
            close.BackColor = Color.Transparent;
            panel1.Hide();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Gray;
            panel1.Show();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Gray;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Transparent;
        }
    }
}
