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
    public partial class updateidea : Form
    {
        db fn=new db();
        public updateidea()
        {
            InitializeComponent();
        }

        private void updateidea_Load(object sender, EventArgs e)
        {
            string query = "select * from idea";
            DataSet dataSet = fn.getData(query);

            dataGridView1.DataSource= dataSet.Tables[0];

        }
    }
}
