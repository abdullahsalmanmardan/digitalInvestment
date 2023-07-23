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
    public partial class updateclient : Form
    {
        db fn =new db();
        public updateclient()
        {
            InitializeComponent();
        }

        private void updateclient_Load(object sender, EventArgs e)
        {
            string query = "select * from client";
            DataSet ds = fn.getData(query);
           

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            if(name.Length> 0 ) {

                string query = @"select * from client where name = '"+name+"'";
                DataSet ds=fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string cid = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            
            textBox2.Text = cid;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cid=textBox2.Text;

            if(cid.Length> 0 )
            {
                updateClientData ad = new updateClientData(cid);
               

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
