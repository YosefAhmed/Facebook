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
        public static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O1FM280\SQLEXPRESS;Initial Catalog=Users_Data;Integrated Security=True");
        SqlCommand cmd;

        public String First_name { get; set; }
        public String Second_Name { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String Gender { get; set; }
        public String birthday { get; set; }


        public String Insert_Data()//inserts data in database(returns a success msg)
        {
            cmd = new SqlCommand("insert into Reg_DB(First_Name,Second_Name,UsernameOrEmail,Password,Gender,DateOfBirth) values('" + First_name + "','" + Second_Name + "','" + Username + "','" + Password + "','" + Gender + "','" + birthday + "')", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

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
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt1 = new DataTable();
            sda.Fill(dt1);
            return dt1.Rows.Count;
        }


    }
}
