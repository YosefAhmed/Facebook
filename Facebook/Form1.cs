using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facebook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 1000, WinAPI.BLEND);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
           bunifuTransition1.ShowSync(userControl21);
           bunifuTransition1.ShowSync(button4);
        }

        private void button2_Click(object sender, EventArgs e)
        {          
           bunifuTransition1.ShowSync(userControl11);
           bunifuTransition1.ShowSync(button4);
        }

        private void userControl21_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(userControl11);
            bunifuTransition1.HideSync(userControl21);
            bunifuTransition1.HideSync(button4);

        }
        public Point mouslocation;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouslocation = new Point(-e.X, -e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point Mousepose = Control.MousePosition;
                Mousepose.Offset(mouslocation.X, mouslocation.Y);
                Location = Mousepose;
            }
        }

        private void userControl21_Load_1(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }






    }
}
