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
        int id;
        public List<int> indices;
        List<string> comment;
        List<int> commentID;
        public profilepage()
        {
            InitializeComponent();
            upload();
            try
            {
                if (UserControl1.userName == UserControl1.userNameforfriend)
                {
                    upload();
                }
                else
                {
                    posts_place.Controls.Clear();
                    upload_friend();
                }
            }
            catch (Exception ex)
            {

            }

        }

        public void upload()
        {
            comment = new List<string>();
            commentID = new List<int>();
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O1FM280\SQLEXPRESS;Initial Catalog=Users_Data;Integrated Security=True");
                con.Open();
                SqlCommand cmd3 = new SqlCommand("select MAX(postID) from posts where userId ='" + UserControl1.userName + "'", con);
                id = (int)cmd3.ExecuteScalar();
                con.Close();
                string react;
                for (int i = 1; i <= id; i++)
                {
                    con.Open();
                    SqlCommand cmd2 = new SqlCommand("select text from posts where postID =" + i + "AND userId = '" + UserControl1.userName + "'", con);
                    string query = (string)cmd2.ExecuteScalar();
                    //indices.Add(i);
                   if(query != null)
                    {
                        try
                        {
                            SqlCommand cmd4 = new SqlCommand("select react from reacts where postID = '" + i.ToString() + "'" + "AND userName = '" + UserControl1.userName + "'", con);
                            react = (string)cmd4.ExecuteScalar();
                        }
                        catch (Exception ex)
                        {
                            react = "None";
                        }
                        try
                        {
                            //MessageBox.Show(ch.ToString());
                            SqlCommand cmd7 = new SqlCommand("select COUNT (text) from comments where userName = '" + UserControl1.userName + "' AND postID = '" + i.ToString() + "'", con);
                            int count = (int)cmd7.ExecuteScalar();
                            if (count > 0)
                            {
                                SqlCommand cmd5 = new SqlCommand("select * from comments where userName = '" + UserControl1.userName + "' AND postID = '" + i.ToString() + "'", con);
                                SqlDataReader reader = cmd5.ExecuteReader();
                                commentID.Clear();
                                comment.Clear();
                                int j = 0;
                                while (reader.Read())
                                {
                                    j++;
                                    int comID = (int)reader[0];
                                    string text = (string)reader[3];
                                    comment.Add(text);
                                    commentID.Add(comID);
                                    //MessageBox.Show(ch.ToString());
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString() + "  \n comments ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        posts_place.Controls.Add(NewUC_upload(query, react, i));
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "  \n posts", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void upload_friend()
        {
            comment = new List<string>();
            commentID = new List<int>();
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O1FM280\SQLEXPRESS;Initial Catalog=Users_Data;Integrated Security=True");
                con.Open();
                SqlCommand cmd3 = new SqlCommand("select MAX(postID) from posts where userId ='" + UserControl1.userNameforfriend + "'", con);
                id = (int)cmd3.ExecuteScalar();
                con.Close();
                string react;
                for (int i = 1; i <= id; i++)
                {
                    con.Open();
                    SqlCommand cmd2 = new SqlCommand("select text from posts where postID =" + i + "AND userId = '" + UserControl1.userNameforfriend + "'", con);
                    string query = (string)cmd2.ExecuteScalar();
                    if(query != null)
                    {
                        //indices.Add(i);
                        try
                        {
                            SqlCommand cmd4 = new SqlCommand("select react from reacts where postID = '" + i.ToString() + "'" + "AND userName = '" + UserControl1.userNameforfriend + "'", con);
                            react = (string)cmd4.ExecuteScalar();
                        }
                        catch (Exception ex)
                        {
                            react = "None";
                        }
                        try
                        {
                            //MessageBox.Show(ch.ToString());
                            SqlCommand cmd7 = new SqlCommand("select COUNT (text) from comments where userName = '" + UserControl1.userNameforfriend + "' AND postID = '" + i.ToString() + "'", con);
                            int count = (int)cmd7.ExecuteScalar();
                            if (count > 0)
                            {
                                SqlCommand cmd5 = new SqlCommand("select * from comments where userName = '" + UserControl1.userNameforfriend + "' AND postID = '" + i.ToString() + "'", con);
                                SqlDataReader reader = cmd5.ExecuteReader();
                                commentID.Clear();
                                comment.Clear();
                                int j = 0;
                                while (reader.Read())
                                {
                                    j++;
                                    int comID = (int)reader[0];
                                    string text = (string)reader[3];
                                    comment.Add(text);
                                    commentID.Add(comID);
                                    //MessageBox.Show(ch.ToString());
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString() + "  \n comments ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        posts_place.Controls.Add(NewUC_upload(query, react, i));
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "  \n posts", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            posts_place.Size = new Size(520, 1500);
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
       private void minimizebtn_Click(object sender, EventArgs e)
       {
           WindowState = FormWindowState.Minimized;
       }

        private void postbtn_Click(object sender, EventArgs e)
        {
            posts_place.Controls.Add(NewUC(posttxt.Text));
        }

        private void cover_profile_photo1_Load(object sender, EventArgs e)
        {
         
        }
        public static string searchfor;
        private void searchbtn_Click(object sender, EventArgs e)
        {
            searchfor = searchtxt.Text;
            searching s = new searching();
            s.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabel1.Text == "Edit")
            {
                textBox1.ReadOnly = false;
                textBox1.Enabled = true;
                linkLabel1.Text = "Done";
            }
            else
            {
                textBox1.ReadOnly = true;
                textBox1.Enabled = false;
                linkLabel1.Text = "Edit";
            }
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void posttxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void posttxt_Enter(object sender, EventArgs e)
        {
            posttxt.Text = "";
            posttxt.ForeColor = Color.Black;
        }

        private void posttxt_Leave(object sender, EventArgs e)
        {
            if (posttxt.Text == "")
            {
                posttxt.ForeColor = Color.Silver;
                posttxt.Text = "What's on your mind ?";
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void homebtn_Click(object sender, EventArgs e)
       {
           Homepage H = new Homepage();
           H.Show();
           this.Close();
       }


        public Facebook.posts NewUC_upload(string text, string reaction, int IDpost)
        {
            Facebook.posts UC = new Facebook.posts();
            UC.id = IDpost;
            UC.labeling_upload(text);
            if (reaction != "None")
            {
                UC.reacting(reaction);
            }
            else if (reaction == "None")
            {
                reaction = "Like";
                UC.reacting(reaction);
            }
            try
            {
                for (int k = 0; k < comment.Count; k++)
                {
                    UC.flowLayoutPanel1.Controls.Add(UC.com_upload(comment[k], commentID[k], IDpost));
                }
            }
            catch
            {

            }
            if (positionY == 0)
            {
                // MessageBox.Show(Convert.ToString(positionY));
                positionY = panel4.Location.Y + 32 + 5;
            }
            UC.Top = positionY;
            UC.Left = panel4.Location.X;
            positionY = (UC.Size.Height) + 5;
            return UC;
        }

        int positionY = 0;
        public Facebook.posts NewUC(string text)
        {
            Facebook.posts UC = new Facebook.posts();
            UC.labeling(text);
            if (positionY == 0)
            {
                // MessageBox.Show(Convert.ToString(positionY));
                positionY = panel4.Location.Y + 32 + 5;
            }
            UC.Top = positionY;
            UC.Left = panel4.Location.X;
            positionY = (UC.Size.Height) + 5;
            return UC;
        }


    }
}
