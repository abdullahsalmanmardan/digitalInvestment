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
    public partial class updateproductdata : Form
    {
        db fn=new db();
        string id;
        public updateproductdata()
        {
            InitializeComponent();
        }
        public updateproductdata(string id)
        {
            this.id= id;
            InitializeComponent();
        }

        private void updateproductdata_Load(object sender, EventArgs e)
        {
            string query1 = "select * from product where pid='" + id + "'";
            DataSet ds = fn.getData(query1);
            txtname.Text = ds.Tables[0].Rows[0][1].ToString();
            txtemail.Text = ds.Tables[0].Rows[0][2].ToString();
            textBox1.Text = ds.Tables[0].Rows[0][3].ToString();
            string[] country = { "india", "china", "singapore", "taiwan", "america" };
            comboBox2.DataSource = country;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string desc = txtemail.Text;
            string price = textBox1.Text;
            string country = comboBox2.SelectedItem.ToString();
            
            string query = "update product set name='" + name + "',description='" + desc + "',price='" + price + "',region='" + country + "' where pid='" + id + "'";
            fn.setData(query, "product record updated");
        }
    }
}
