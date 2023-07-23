using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class updateproduct : Form
    {
        db fn=new db();
        public updateproduct()
        {
            InitializeComponent();
        }

        private void updateproduct_Load(object sender, EventArgs e)
        {
            string query = "select * from product";
            DataSet ds = fn.getData(query);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string pid = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            textBox2.Text = pid;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cid = textBox2.Text;

            if (cid.Length > 0)
            {
                updateproductdata ad = new updateproductdata(cid);


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
