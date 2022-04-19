using MyHW.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHW
{
    public partial class FrmTreeView : Form
    {
        public FrmTreeView()
        {
            InitializeComponent();

            CreateCountryTreeView();

        }


        private void CreateCountryTreeView()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    SqlCommand command = new SqlCommand();
                    command.Connection = conn;
                    command.CommandText = "select * from Customers order by Country";
                    conn.Open();

                    SqlDataReader dataReader = command.ExecuteReader();
                    TreeNode TNcountry=null;
                    TreeNode TNcity = null;
                    while (dataReader.Read())
                    {
                        
                        string country = dataReader["Country"].ToString();
                        string city = dataReader["City"].ToString();

                        //加入國家
                        if (treeView1.Nodes[country] == null)
                        {
                            TreeNode node = new TreeNode();
                            node.Text = country;
                            node.Name = country;
                            node.Tag = country;  //ID
                           
                            TNcountry = node;
                            this.treeView1.Nodes.Add(node);  //加入主item
                        }
                        else 
                        {
                            TNcountry = treeView1.Nodes[country];
                        }

                        //加入城市
                        if (TNcountry.Nodes[city] == null)
                        {
                            TreeNode node = new TreeNode();
                            node.Text = city;
                            node.Name = city;
                            TNcity = node;
                            TNcountry.Nodes.Add(node);  //加入次item
                        }
                        else
                        {
                            TNcity = TNcountry.Nodes[city];

                            //TreeNode node = new TreeNode();
                            //node.Text = city;
                            //node.Name = city;
                            //TNcity = node;
                            //TNcountry.Nodes.Add(node);  //加入次item

                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string city = treeView1.SelectedNode.Text;

            //DisConnected
            this.customersTableAdapter1.FillByCity(this.nwDataSet1.Customers, city);
            this.dataGridView1.DataSource = this.nwDataSet1.Customers;


        }




        //private void Node_Click(object sender, EventArgs e)
        //{
        //    //LinkLabel node = sender as LinkLabel;  //轉成原LinkLabel
        //    //if (x != null) 
        //    //{
        //    //    MessageBox.Show(x.Text);
        //    //}

        //    //DisConnected
        //    string country= node.Tag;

        //    this.customersTableAdapter1.FillByCountry(this.nwDataSet1.Customers, country);
        //    this.dataGridView1.DataSource = this.nwDataSet1.Customers;
        //}



    }
}
