using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class addproduct : Form
    {
        db fn =new db();
        public addproduct()
        {
            InitializeComponent();
        }

        private void addproduct_Load(object sender, EventArgs e)
        {
            string[] country = { "india", "china", "singapore", "taiwan", "america" };
            comboBox2.DataSource = country;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string desc = txtemail.Text;
            string price=textBox1.Text;    
            string country = comboBox2.SelectedItem.ToString();
           
            string query = "insert into product (name,description,price,region) values('" + name + "','" + desc + "','" + price + "','" + country + "')";
            fn.setData(query, "data added to product table");
        }
    }
}
