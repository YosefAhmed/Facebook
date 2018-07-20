using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Facebook
{
    class Account
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O1FM280\SQLEXPRESS;Initial Catalog=Users_Data;Integrated Security=True");
        SqlCommand cmd;


        public String First_name { get; set; }
        public String Second_name { get; set; }
        public String Full_Name { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String Gender { get; set; }
        public String birthday { get; set; }

       
        
        public String Insert_Data()//inserts data in database(returns a success msg)
        {
            String fullname;
            fullname = First_name + " " + Second_name;
            cmd = new SqlCommand("insert into Reg_DB(First_Name,Second_Name,Full_Name,UsernameOrEmail,Password,Gender,DateOfBirth) values('" +First_name+ "','" +Second_name + "','"+fullname+"','" + Username+ "','" + Password+ "','" + Gender + "','" + birthday+ "')", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                     return   "You have been registered successfully! Now you can sign in.";                 
        }

        public int Check_existing_data()//checks  if username or Email is allready existed or no !(returns integer)
        {
            string query = "Select * from Reg_DB where UsernameOrEmail='" + Username + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt2 = new DataTable();
            sda.Fill(dt2);
            return dt2.Rows.Count;
        }

        public int Check_account()//checks if the password and username are correct or no 
        {
            string query = "Select * from Reg_DB where UsernameOrEmail='" +Username+ "' and Password='" +Password+ "' ";
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O1FM280\SQLEXPRESS;Initial Catalog=Users_Data;Integrated Security=True");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            con.Close();
            DataTable dt1 = new DataTable();
            sda.Fill(dt1);
            return dt1.Rows.Count;
        }

        public string get_FullName()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select First_Name,Second_Name from Reg_DB where UsernameOrEmail='" + UserControl1.firstName + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                First_name = dr["First_Name"].ToString();
                Second_name = dr["Second_Name"].ToString();
                Full_Name = First_name + " " +Second_name;
                //con.Close();
                return Full_Name; 
            }
            catch (Exception ex)
            {  MessageBox.Show(ex.Message);
            return "ERROR";
            }

        }
        public string get_FirstName()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select First_Name,Second_Name from Reg_DB where UsernameOrEmail='" + UserControl1.firstName + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                First_name = dr["First_Name"].ToString();
                Second_name = dr["Second_Name"].ToString();
                Full_Name = First_name + " " + Second_name;
                return First_name;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "ERROR";
            }
        }

        //public string get_profileimg()
        //{
        //    try
        //    {
        //                   con.Open();

        //        // load profile image from database

        //        SqlCommand cmd2 = new SqlCommand("Select profileimg from Reg_DB where UsernameOrEmail='" + UserControl1.firstName + "'", con);
        //        string dr2 = (string)cmd2.ExecuteScalar();

        //        return dr2 ;
        //    }
        //    catch (Exception ex) { MessageBox.Show("You didn't Upload a Profile or a Cover Picture");  return "ERROR";}
        //    //con.Close();
        //}
        //public string get_coverimg()
        //{
        //    try
        //    {
        //        con.Open();
        //        // load cover image from database
        //        SqlCommand cmd3 = new SqlCommand("Select coverimg from Reg_DB where UsernameOrEmail='" + UserControl1.firstName + "'", con);
        //        string dr3 = (string)cmd3.ExecuteScalar();

        //        return dr3;
        //    }
        //    catch (Exception ex) { MessageBox.Show("You didn't Upload a Profile or a Cover Picture");  return "ERROR";}
        //    //con.Close();
        //    }

        }
    }
