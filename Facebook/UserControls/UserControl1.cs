using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
            if (alphaBlendTextBox1.Text == "Username")
            {
                alphaBlendTextBox1.Clear();
                alphaBlendTextBox1.ForeColor = Color.Black;
            }
        }

        private void alphaBlendTextBox1_Leave(object sender, EventArgs e)
        {
            if (alphaBlendTextBox1.Text == "")
            {
                alphaBlendTextBox1.ForeColor = Color.Silver;
                alphaBlendTextBox1.Text = "Username";
            }
        }

        private void alphaBlendTextBox2_Enter(object sender, EventArgs e)
        {
            if (alphaBlendTextBox2.Text == "Password")
            {
                alphaBlendTextBox2.Text = "";
                alphaBlendTextBox2.ForeColor = Color.Black;
                //  alphaBlendTextBox2.UseSystemPasswordChar = true;
            }
        }


        private void alphaBlendTextBox2_Leave_1(object sender, EventArgs e)
        {
            if (alphaBlendTextBox2.Text == "")
            {
                //  alphaBlendTextBox2.UseSystemPasswordChar = false;
                alphaBlendTextBox2.ForeColor = Color.Silver;
                alphaBlendTextBox2.Text = "Password";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Homepage H = new Homepage();
            H.Show();
            this.Parent.Parent.Parent.Visible = false;
        }
    }
}
