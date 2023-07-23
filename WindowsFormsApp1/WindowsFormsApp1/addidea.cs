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
    public partial class addidea : Form
    {
        db fn =new db();
        public addidea()
        {
            InitializeComponent();
        }

        private void addidea_Load(object sender, EventArgs e)
        {
            string query = "select name from product";
            DataSet dataSet = fn.getData(query);
            List<string> list = new List<string>();
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                string name = dataSet.Tables[0].Rows[i]["name"].ToString();
                list.Add(name);
            }
            comboBox2.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string desc = txtemail.Text;
            string pname = comboBox2.SelectedItem.ToString();
           
            string query = "insert into idea (name,description,productname) values('" + name + "','" + desc + "','" + pname + "')";
            fn.setData(query, "ideas data added to the table");
        }
    }
}
