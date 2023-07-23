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
    public partial class Form1 : Form
    {
        db fn =new db();    
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        // this is the login button , each rm will login here to do further operations
        // because i have given level to rms and clients so that specific rm can only see specifc clients
        // silver rm can see silver client
        private void button1_Click(object sender, EventArgs e)
        {
            // getting the data from the gui 
            string username = txtusername.Text;
            string password = txtpassword.Text;
            // comparing the gui data with the database data
            string query = "select level from rms where username='" + username + "' and password='" + password + "'";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count > 0)
            {
                RMHomeScreen ad = new RMHomeScreen();
                

                ad.BringToFront();
                ad.Show();
            }
            else
            {
                MessageBox.Show("invalid credentials");
            }
        }
    }
}
