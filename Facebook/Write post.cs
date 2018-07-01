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
    public partial class Write_post : UserControl
    {
        public Write_post()
        {
            InitializeComponent();
        }

        private void posttxt_Enter(object sender, EventArgs e)
        {
            if (posttxt.Text == "What's on your mind?")
            {
                posttxt.Clear();
                posttxt.Font = new Font(posttxt.Font.FontFamily, 10.0f);
                posttxt.ForeColor = Color.Black;
            }
        }

        private void posttxt_Leave(object sender, EventArgs e)
        {
            if (posttxt.Text == "")
            {
                posttxt.ForeColor = Color.Silver;
                posttxt.Font = new Font(posttxt.Font.FontFamily, 14.0f, FontStyle.Bold);
                posttxt.Text = "What's on your mind?";
            }
        }

        private void Write_post_Load(object sender, EventArgs e)
        {

        }
    }
}
