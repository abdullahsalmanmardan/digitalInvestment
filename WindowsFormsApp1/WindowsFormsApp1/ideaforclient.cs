using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ideaforclient : Form
    {
        db fn=new db();
        public ideaforclient()
        {
            InitializeComponent();
        }

        private void ideaforclient_Load(object sender, EventArgs e)
        {
            string query = "select * from idea";
            DataSet dataSet = fn.getData(query);

            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string cid = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            textBox2.Text = cid;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = textBox2.Text;
            if (id.Length > 0)
            {
                SuitableClients ad = new SuitableClients(id);
                ad.BringToFront();
                ad.Show();
            }
            else
            {
                MessageBox.Show("no id presnet to update the data");
            }


        }
    }
}
