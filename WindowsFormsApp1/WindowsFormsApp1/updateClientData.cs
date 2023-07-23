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
    public partial class updateClientData : Form
    {
        db fn = new db();
        string id;
        public updateClientData()
        {
            InitializeComponent();
        }
        public updateClientData(string id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void updateClientData_Load(object sender, EventArgs e)
        {
            string query1 = "select * from client where cid='" + id + "'";
            DataSet ds=fn.getData(query1);

            txtname.Text = ds.Tables[0].Rows[0][1].ToString();
            txtemail.Text = ds.Tables[0].Rows[0][2].ToString();
            string[] country = { "india", "china", "singapore", "taiwan", "america" };
            comboBox2.DataSource = country;
            string[] level = { "silver", "gold", "diamond" };
            comboBox1.DataSource = level;
            comboBox2.DataSource = country;
            string query = "select name from product";
            DataSet dataSet = fn.getData(query);
            List<string> list = new List<string>();
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                string name = dataSet.Tables[0].Rows[i]["name"].ToString();
                list.Add(name);
            }

            checkedListBox1.DataSource = list;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string email = txtemail.Text;
            string level = comboBox1.SelectedItem.ToString();
            string country = comboBox2.SelectedItem.ToString();
            string product = "";
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                product = product + checkedListBox1.Items[i].ToString() + ",";
            }

            string query = "update client set name='" + name + "',email='" + email + "',level='" + level + "',clientsummary='" + product + "',country='" + country + "' where cid='"+id+"'";
            fn.setData(query, "client record updated");
        }
    }
}
