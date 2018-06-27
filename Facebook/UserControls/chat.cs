using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facebook.UserControls
{
    public partial class chat : UserControl
    {
       
       
        public chat()
        {
            InitializeComponent();
        }
        private void chatbtn_Click(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(panel3);
            bunifuTransition2.HideSync(panel4);
        }
        private void closechatbtn_Click(object sender, EventArgs e)
        {
            bunifuTransition2.ShowSync(panel4);
            bunifuTransition2.ShowSync(panel3);
        }

    }
}
