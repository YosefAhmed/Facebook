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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void alphaBlendTextBox1_Enter(object sender, EventArgs e)
        {
            user_in.ForeColor = Color.Black;
            if (user_in.Text == "Username")
                user_in.Text = "";
        }

        private void alphaBlendTextBox1_Leave(object sender, EventArgs e)
        {
            if (user_in.Text == "")
            {
                user_in.ForeColor = Color.Silver;
                user_in.Text = "Username";
            }
        }

        private void alphaBlendTextBox2_Enter(object sender, EventArgs e)
        {
            pass_in.PasswordChar = '*';
            pass_in.ForeColor = Color.Black;
            if (pass_in.Text == "Password")
                pass_in.Text = "";
        }

        private void alphaBlendTextBox2_Leave(object sender, EventArgs e)
        {
            if (pass_in.Text == "")
            {
                pass_in.ForeColor = Color.Silver;
                pass_in.UseSystemPasswordChar = true;
                pass_in.Text = "Password";
            }
        }
        public static string userName;
        private void button1_Click(object sender, EventArgs e)
        {
            Account user=new Account();

            if (user_in.Text == "Username" || pass_in.Text == "Password")
            {
                MessageBox.Show("Please enter all information", "Error to Sign in", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                user.Username = user_in.Text.Trim();
                user.Password = pass_in.Text.Trim();

                int count =user.Check_account();
                if (count == 1)     //if username or email and password are correct (count is the return of "Check_account" method in Account class)
                {
                    Homepage f2 = new Homepage();
                    userName = user_in.Text;
                    f2.Show();
                    f2.WindowState = FormWindowState.Normal;
                    ParentForm.Hide();
                }
                else
                {
                    MessageBox.Show("Your username or password is incorrect", "Incorrect username or password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
