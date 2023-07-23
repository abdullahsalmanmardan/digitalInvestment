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
            List<string> cid = new List<string>();

            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                string cid1 = dataSet.Tables[0].Rows[i]["cid"].ToString();
                string product = dataSet.Tables[0].Rows[i]["clientsummary"].ToString();
                string[] p= product.Split(',');
                for(int k=0; k<p.Length; k++)
                {
                    if (p[k] == ideaProduct)
                    {
                        cid.Add(cid1);
                        MessageBox.Show(cid1.ToString());
                    }
                    products.Add(p[k]);
                }
               
               
                
            }
        }
    }
}
