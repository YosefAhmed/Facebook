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
        byte[] imagess;
        public cover_profile_photo()
        {
            
            InitializeComponent();
        }
        public static string fullName;

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O1FM280\SQLEXPRESS;Initial Catalog=Users_Data;Integrated Security=True");
        String imagelocation = ""; string imagelocation1 = "";
        private void uploadcoverbtn_Click(object sender, EventArgs e)
        {
            

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
        }
        private void uploadprofilebtn_Click(object sender, EventArgs e)
        {
           

            try
            {
                OpenFileDialog dialog3 = new OpenFileDialog();
                dialog3.Filter = "jpg files(*.jpg)|*.jpg | PNG files(*.png)|*.png|All files(*.*)|*.*";
                if (dialog3.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    imagelocation= dialog3.FileName;

                profilepic.ImageLocation = imagelocation;
            }
            catch (Exception)
            {
                MessageBox.Show("An Error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        string fname; string sname; string allname;
        private void cover_profile_photo_Load(object sender, EventArgs e)
        {
            con.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("Select First_Name,Second_Name from Reg_DB where UsernameOrEmail='" + UserControl1.userName + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                fname = dr["First_Name"].ToString();
                sname = dr["Second_Name"].ToString();
                allname = fname + " " + sname;
                label4.Text = allname;
                fullName = dr["First_Name"].ToString();
                dr.Close();
               
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }


            //try
            //{
            //   // load images from database

            //        SqlCommand cmd2 = new SqlCommand("Select profileimg from Reg_DB where UsernameOrEmail='" + UserControl1.userName + "'", con);
            //        SqlDataReader dr2 = cmd2.ExecuteReader();
            //        dr2.Read();
            //        if (dr2.HasRows)
            //        {
            //            imagess = ((byte[])dr2["profileimg"]);

            //            if (imagess == null)
            //            {
            //                profilepic.Image = null;
            //            }
            //            else if(imagess!=null)
            //            {
            //                MemoryStream mystream = new MemoryStream(imagess);
            //                profilepic.Image =System.Drawing.Image.FromStream(mystream);
            //            }
            //        }
            //        else { MessageBox.Show("This Data Not Available..!"); }
            //        dr2.Close();

            //    }
            //    catch (Exception ex) { MessageBox.Show(ex.Message); }

                con.Close();

            }        
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            //for save the profile image into database
            try
            {
                byte[] images = null;
                FileStream Stream = new FileStream(imagelocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(Stream);
                images = brs.ReadBytes((int)Stream.Length);
                String sqlQuery = "Update Reg_DB Set profileimg='" + @images + "'Where UsernameOrEmail='" + UserControl1.userName + "'";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                cmd.Parameters.Add(new SqlParameter("@images", images));
                int N = cmd.ExecuteNonQuery();
                //MessageBox.Show(N.ToString() + "Image saved successfully..!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            //for save the cover image into database  

            try
            {

                byte[] images1 = null;
                FileStream Stream = new FileStream(imagelocation1, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(Stream);
                images1 = brs.ReadBytes((int)Stream.Length);
                String sqlQuery = "Update Reg_DB Set coverimg='" + @images1 + "'Where UsernameOrEmail='" + UserControl1.userName + "'";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                cmd.Parameters.Add(new SqlParameter("@images1", images1));
                int N2 = cmd.ExecuteNonQuery();
                //MessageBox.Show(N2.ToString() + "Data Saves successfully..!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            MessageBox.Show("Done :)", "Updateing", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void profilepic_Click(object sender, EventArgs e)
        {

        }
    }
}
