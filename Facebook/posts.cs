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
    public partial class posts : UserControl
    {
        public posts()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O1FM280\SQLEXPRESS;Initial Catalog=Users_Data;Integrated Security=True");
        public int id;
        public void labeling(string text)
        {
            try
            {
                con.Open();
            }
            finally
            {
                SqlCommand cmd = new SqlCommand("insert into posts (userId,text) values('" + UserControl1.userName + "','" + text + "')", con);
                cmd.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("select MAX(postID) from posts", con);
                id = (int)cmd2.ExecuteScalar();
                con.Close();
            }
            label1.Text = text;
        }

        public void labeling_upload(string text)
        {
            try
            {
                label1.Text = text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex), "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void reacting(string text)
        {
            button1.Text = text;
        }

        private void Like_Click(object sender, EventArgs e)
        {
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
            panel1.Hide();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Silver;
            panel1.Show();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Silver;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void posts_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Add(com(cmnttxt.Text));
        }

        public Facebook.comments com_upload(string text, int comID, int postID)
        {
            Facebook.comments com2 = new Facebook.comments();
            if (positionYC == 0)
            {
                positionYC += cmnttxt.Location.Y + cmnttxt.Size.Width;
            }
            com2.id = postID;
            com2.commentID = comID;
            com2.Top = positionYC;
            com2.Left = cmnttxt.Location.X;
            positionYC += com2.Size.Height + 5;
            com2.commentlbl_upload(text /*, postID , comID*/);
            //flowLayoutPanel1.Controls.Add(com2);
            return com2;
        }

        int positionYC = 0;
        public Facebook.comments com(string text)
        {
            Facebook.comments com2 = new Facebook.comments();
            if (positionYC == 0)
            {
                positionYC += cmnttxt.Location.Y + cmnttxt.Size.Width;
            }
            com2.id = id;
            com2.Top = positionYC;
            com2.Left = cmnttxt.Location.X;
            positionYC += com2.Size.Height + 5;
            com2.commentlbl(text);
            return com2;
        }

    }
}
