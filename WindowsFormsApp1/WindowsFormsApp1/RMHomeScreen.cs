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
        string level = "";
        db fn=new db();
        public RMHomeScreen()
        {
            InitializeComponent();
        }

        public RMHomeScreen(string level)
        {
            InitializeComponent();
            this.level = level;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            updateclient ad = new updateclient();
            ad.TopLevel = false;
            panel2.Controls.Add(ad);

            ad.BringToFront();
            ad.Show();
        }

        private void RMHomeScreen_Load(object sender, EventArgs e)
        {
            addclient ad = new addclient();
            ad.TopLevel = false;
            panel2.Controls.Add(ad);
           
            ad.BringToFront();
            ad.Show();
        }

        private void btnaddclient_Click(object sender, EventArgs e)
        {
            addclient ad = new addclient();
            ad.TopLevel = false;
            panel2.Controls.Add(ad);

            ad.BringToFront();
            ad.Show();
        }

        private void btnupdateclient_Click(object sender, EventArgs e)
        {
            updateclient ad = new updateclient();
            ad.TopLevel = false;
            panel2.Controls.Add(ad);

            ad.BringToFront();
            ad.Show();
        }

        private void btnaddproduct_Click(object sender, EventArgs e)
        {
            addproduct ad = new addproduct();
            ad.TopLevel = false;
            panel2.Controls.Add(ad);

            ad.BringToFront();
            ad.Show();
        }

        private void btnaddidea_Click(object sender, EventArgs e)
        {
            addidea ad = new addidea();
            ad.TopLevel = false;
            panel2.Controls.Add(ad);

            ad.BringToFront();
            ad.Show();
        }

        private void btnupdateidea_Click(object sender, EventArgs e)
        {
            updateidea ad = new updateidea();
            ad.TopLevel = false;
            panel2.Controls.Add(ad);

            ad.BringToFront();
            ad.Show();
        }

        private void btninvestmentidea_Click(object sender, EventArgs e)
        {
            investmentideas ad = new investmentideas();
            ad.TopLevel = false;
            panel2.Controls.Add(ad);

            ad.BringToFront();
            ad.Show();
        }

        private void btnideaforclient_Click(object sender, EventArgs e)
        {
            ideaforclient ad = new ideaforclient ();
            ad.TopLevel = false;
            panel2.Controls.Add(ad);

            ad.BringToFront();
            ad.Show();
        }
    }
}
