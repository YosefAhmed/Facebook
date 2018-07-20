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
using System.IO;
namespace Facebook
{
    public partial class cover_profile_photo : UserControl
    {
        public cover_profile_photo()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O1FM280\SQLEXPRESS;Initial Catalog=Users_Data;Integrated Security=True");
        String imagelocation = ""; string imagelocation1 = "";
       
        private void uploadcoverbtn_Click(object sender, EventArgs e)
        {
            con.Open();

            try
            {
                OpenFileDialog dialog2 = new OpenFileDialog();
                dialog2.Filter = "jpg files(*.jpg)|*.jpg | PNG files(*.png)|*.png|All files(*.*)|*.*";
                if (dialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    imagelocation1 = dialog2.FileName;

                coverimage.ImageLocation = imagelocation1;
            }
            catch (Exception)
            {
                MessageBox.Show("An Error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                SqlCommand cmd = new SqlCommand("update Reg_DB set coverimg='" + imagelocation1 + "' where UsernameOrEmail='" + UserControl1.firstName + "'", con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show(N.ToString() + "Image saved successfully..!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        private void uploadprofilebtn_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                OpenFileDialog dialog2 = new OpenFileDialog();
                dialog2.Filter = "jpg files(*.jpg)|*.jpg | PNG files(*.png)|*.png|All files(*.*)|*.*";
                if (dialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    imagelocation = dialog2.FileName;

                profilepic.ImageLocation = imagelocation;
            }
            catch (Exception)
            {
                MessageBox.Show("An Error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                SqlCommand cmd = new SqlCommand("update Reg_DB set profileimg='" + imagelocation + "' where UsernameOrEmail='" + UserControl1.firstName + "'", con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show(N.ToString() + "Image saved successfully..!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        Account user = new Account();
        //string fname,sname,allname;
        public static string fullName;
        private void cover_profile_photo_Load(object sender, EventArgs e)
        {
            con.Open();

            try
            {               
                fullName = user.get_FullName();
                label4.Text = fullName;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }




            try
            {
                // load profile image from database

                SqlCommand cmd2 = new SqlCommand("Select profileimg from Reg_DB where UsernameOrEmail='" + UserControl1.firstName + "'", con);
                string dr2 = (string)cmd2.ExecuteScalar();
                profilepic.Image = Image.FromFile(dr2);
                // load cover image from database

                SqlCommand cmd3 = new SqlCommand("Select coverimg from Reg_DB where UsernameOrEmail='" + UserControl1.firstName + "'", con);
                string dr3 = (string)cmd3.ExecuteScalar();
                coverimage.Image = Image.FromFile(dr3);
            }
            catch (Exception ex) { MessageBox.Show("You didn't Upload a Profile or a Cover Picture"); }
            con.Close();
        }
    }
}

