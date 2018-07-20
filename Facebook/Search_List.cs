using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Facebook
{
    public partial class Search_List : Form
    {
        public Search_List()
        {
            InitializeComponent();
        }
        int positionY;

        public Facebook.Search_friend NewUC2()
        {
            Facebook.Search_friend UC2 = new Search_friend();
            UC2.Top = positionY;
            UC2.Left = flowLayoutPanel1.Location.X;
            positionY = (UC2.Size.Height) + 5;
            return UC2;
        }
        private void Exitbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        
        private void Search_List_Load(object sender, EventArgs e)
        {
            
                flowLayoutPanel1.Controls.Add(NewUC2());
        
        }
    }
}
