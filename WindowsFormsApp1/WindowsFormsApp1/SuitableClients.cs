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
    public partial class SuitableClients : Form
    {
        db fn=new db();
        string id="";
        public SuitableClients()
        {
            InitializeComponent();
        }
        public SuitableClients(string cid)
        {
            id = cid;
            InitializeComponent();
            
        }

        private void SuitableClients_Load(object sender, EventArgs e)
        {
            // getting the ideas by product
            string query2= "select productname from idea where iid='" + id + "' ";
            DataSet dataSet1 = fn.getData(query2);

            string ideaProduct = dataSet1.Tables[0].Rows[0]["productname"].ToString();


            string query = "select cid,clientSummary from client";
            DataSet dataSet = fn.getData(query);
            List<string> products = new List<string>();
            List<int> cid = new List<int>();

            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                string cid1 = dataSet.Tables[0].Rows[i]["cid"].ToString();
                
                string product = dataSet.Tables[0].Rows[i]["clientsummary"].ToString();
                string[] p= product.Split(',');
                for(int k=0; k<p.Length; k++)
                {
                    if (p[k] == ideaProduct)
                    {
                        
                        cid.Add(Int32.Parse(cid1));
                       
                    }
                    products.Add(p[k]);
                }
               
            }

            string qui= "select * from client where cid IN (" + string.Join(",", (List<int>)cid) + ")";
            DataSet dssss=fn.getData(qui);
            MessageBox.Show(dssss.Tables[0].Rows.Count.ToString());

            dataGridView1.DataSource= dssss.Tables[0];  
        }
    }
}
