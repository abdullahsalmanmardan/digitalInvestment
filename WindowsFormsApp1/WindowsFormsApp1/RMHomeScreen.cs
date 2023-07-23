using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RMHomeScreen : Form
    {
        db fn=new db();
        public RMHomeScreen()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void RMHomeScreen_Load(object sender, EventArgs e)
        {
            addclient ad = new addclient();
            ad.TopLevel = false;
            panel2.Controls.Add(ad);
           
            ad.BringToFront();
            ad.Show();
        }
    }
}
