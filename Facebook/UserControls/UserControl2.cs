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

namespace Facebook.Resources
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O1FM280\SQLEXPRESS;Initial Catalog=Users_Data;Integrated Security=True");
        string gender, full_date;

        private void signupbtn_Click(object sender, EventArgs e)
        {
            Account user = new Account();//creating object from account class

            //if one or more of data is Empty throw an Error msg
            if (username_up.Text == "Email" || pass_up.Text == "New Password" || firstname_up.Text == "Full Name" || day.Text == "Day" || month.Text == "Month" || year.Text == "Year" || (male.Checked == false && female.Checked == false)||SecondNametxt.Text=="Second Name" )
            {
                MessageBox.Show("Please enter all information", "Error to Sign up", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (male.Checked)
                    gender = "Male";
                else if (female.Checked)
                    gender = "Female";
         /*-------------------------------------------------------------------------------*/
                if (month.Text == "January")
                    full_date = day.Text + "/" + 1 + "/" + year.Text;
                else if (month.Text == "February")
                    full_date = day.Text + "/" + 2 + "/" + year.Text;
                else if (month.Text == "March")
                    full_date = day.Text + "/" + 3 + "/" + year.Text;
                else if (month.Text == "April")
                    full_date = day.Text + "/" + 4 + "/" + year.Text;
                else if (month.Text == "May")
                    full_date = day.Text + "/" + 5 + "/" + year.Text;
                else if (month.Text == "June")
                    full_date = day.Text + "/" + 6 + "/" + year.Text;
                else if (month.Text == "July")
                    full_date = day.Text + "/" + 7 + "/" + year.Text;
                else if (month.Text == "August")
                    full_date = day.Text + "/" + 8 + "/" + year.Text;
                else if (month.Text == "September")
                    full_date = day.Text + "/" + 9 + "/" + year.Text;
                else if (month.Text == "October")
                    full_date = day.Text + "/" + 10 + "/" + year.Text;
                else if (month.Text == "November")
                    full_date = day.Text + "/" + 11 + "/" + year.Text;
                else if (month.Text == "December")
                    full_date = day.Text + "/" + 12 + "/" + year.Text;
//*-------------------------------------------------------------------------------------------------------------------
                /*==========Fill user (object) data===========*/

                user.First_name = firstname_up.Text;
                user.Second_Name = SecondNametxt.Text;
                user.Username = username_up.Text.Trim();
                user.Password = pass_up.Text.Trim();
                user.Gender = gender;
                user.birthday = full_date;

 //----------------------------------------------------------------------------------------
                int count = user.Check_existing_data();
                if (count == 1)      //if username or email is already existed (count is the return of "Check_existing_data" method in Account class)
                {
                    MessageBox.Show("Username or Email already existed! Please enter another one.", "Username or Email is existed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else        //if username or email is not existed 
                {
                    try     //what i wont to do
                    {
                        user.First_name = firstname_up.Text;
                        user.Second_Name = SecondNametxt.Text;
                        user.Username = username_up.Text.Trim();
                        user.Password = pass_up.Text.Trim();
                        user.Gender = gender;
                        user.birthday = full_date;

                        string msg = user.Insert_Data();//msg is a success message (the return of "Insert_Data" method
                       DialogResult result = MessageBox.Show(msg, "Registration succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       if (result == DialogResult.OK)
                       {
                           this.Hide();    //hide UserControl2

                           //fullname_up.ForeColor = Color.Silver;
                           //fullname_up.Text = "Full Name";
                           //username_up.ForeColor = Color.Silver;
                           //username_up.Text = "Username or Email";
                           //pass_up.ForeColor = Color.Silver;
                           //pass_up.Text = "New Password";
                           //pass_up.PasswordChar = '*';
                           //day.ForeColor = Color.Silver;
                           //label4.Show();
                           //label5.Show();
                           //label6.Show();
                           //month.ForeColor = Color.Silver;
                           //year.ForeColor = Color.Silver;
                           //male.Checked = false;
                           //female.Checked = false;
                       }
                        
                    }
                    catch(Exception ex)       //what will happen if there is a run time error,instade of stopping the application
                    {
                        MessageBox.Show("Error occured! Please fill your data accurately "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally    //what will happen after "try" or "catch"
                    {
                        con.Close();
                    }
                }
            }
        }
                            //Full Name textbox
        private void alphaBlendTextBox3_Enter(object sender, EventArgs e)
        {
            firstname_up.ForeColor = Color.Black;
            if (firstname_up.Text == "First Name")
                firstname_up.Text = "";
        }
                            //Full Name textbox
        private void alphaBlendTextBox3_Leave(object sender, EventArgs e)
        {
            if (firstname_up.Text == "")
            {
                firstname_up.ForeColor = Color.Silver;
                firstname_up.Text = "First Name";
            }
        }
                            //Username or email textbox
        private void alphaBlendTextBox1_Enter(object sender, EventArgs e)
        {
            username_up.ForeColor = Color.Black;
            if (username_up.Text == "Username or Email")
                username_up.Text = "";
        }
                            //Username or email textbox
        private void alphaBlendTextBox1_Leave(object sender, EventArgs e)
        {

            if (username_up.Text == "")
            {
                username_up.ForeColor = Color.Silver;
                username_up.Text = "Username or Email";
            }
        }
                            //Password textbox
        private void alphaBlendTextBox2_Enter(object sender, EventArgs e)
        {

            pass_up.PasswordChar = '*';
            pass_up.ForeColor = Color.Black;
            if (pass_up.Text == "New Password")
                pass_up.Text = "";
        }
        

        int c = 0;         //Password textbox
        private void alphaBlendTextBox2_Leave(object sender, EventArgs e)
        {
            while (c <= 1)
            {
                if (pass_up.Text == "")
                {
                    pass_up.ForeColor = Color.Silver;
                    pass_up.UseSystemPasswordChar = true;
                    pass_up.Text = "New Password";
                }
                c++;
            }
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            day.ForeColor = Color.Black;
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (day.Text=="Day")
            {
                day.ForeColor = Color.Silver;
                day.Text = "Day";
            }
        }

        private void comboBox2_Enter(object sender, EventArgs e)
        {
            month.ForeColor = Color.Black;
        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            if (month.Text == "Mon")
            {
                month.ForeColor = Color.Silver;
                month.Text = "Mon";
            }
        }

        private void comboBox3_Enter(object sender, EventArgs e)
        {
            year.ForeColor = Color.Black;
        }

        private void comboBox3_Leave(object sender, EventArgs e)
        {
            if (year.Text == "Year")
            {
                year.ForeColor = Color.Silver;
                year.Text = "Year";
            }
        }

        private void day_DropDown(object sender, EventArgs e)
        {
            label4.Hide();
        }

        private void month_DropDown(object sender, EventArgs e)
        {
            label5.Hide();
        }

        private void year_DropDown(object sender, EventArgs e)
        {
            label6.Hide();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }

        private void fullname_up_TextChanged(object sender, EventArgs e)
        {

        }

        private void alphaBlendTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SecondNametxt_Enter(object sender, EventArgs e)
        {
            SecondNametxt.ForeColor = Color.Black;
            if (SecondNametxt.Text == "Second Name")
            {
                SecondNametxt.Text = "";
               
            }
        }

        private void SecondNametxt_Leave(object sender, EventArgs e)
        {
            if (SecondNametxt.Text == "")
            {
                SecondNametxt.ForeColor = Color.Silver;
                SecondNametxt.Text = "Second Name";
            }
        }


    }
}
