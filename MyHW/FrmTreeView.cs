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

            CreateCountrylist(); //建立國家清單
            CreateTreeView();   //建立國家與城市TreeView

        }



        List<string> countrycountList = new List<string>();  //建立國家與城市數量清單
        List<string> countryList = new List<string>();  //建立國家清單
        private void CreateCountrylist()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    SqlCommand command = new SqlCommand();
                    command.Connection = conn;
                    command.CommandText = "select country, count(country) as number from Customers group by country order by Country";
                    conn.Open();

                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {                    
                        string country = dataReader["Country"].ToString();
                        string number = dataReader["number"].ToString();

                        string countrycount = country + "(" + number + ")";

                        countrycountList.Add(countrycount);
                        countryList.Add(country);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        TreeNode TNcountry = null;
        TreeNode TNcity = null;
        private void CreateTreeView()
        {
            for (int i = 0; i < countryList.Count; i++)
            {
                TreeNode node = new TreeNode();
                node.Text = countrycountList[i];
                node.Name = countrycountList[i];
                node.Tag = 1;  //ID
                string country = countryList[i];
                TNcountry = node;
                this.treeView1.Nodes.Add(node);  //加入主item

                try
                {
                    using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                    {
                        SqlCommand command = new SqlCommand();
                        command.Connection = conn;
                        command.CommandText = $"select distinct city from Customers where Country = '{country}'";
                        conn.Open();

                        SqlDataReader dataReader = command.ExecuteReader();
                        while (dataReader.Read())
                        {
                            string city = dataReader["city"].ToString();

                            TreeNode node2 = new TreeNode();
                            node2.Text = city;
                            node2.Name = city;
                            node2.Tag = 2;  //ID
                            TNcity = node2;
                            TNcountry.Nodes.Add(TNcity);  //加入次item
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //展開dataGridView
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string city = treeView1.SelectedNode.Text;
            int cityTag = (int) treeView1.SelectedNode.Tag;

            if (cityTag == 2)  //只有展開城市時才會顯示資訊在dataGridView
            {
                this.customersTableAdapter1.FillByCity(this.nwDataSet1.Customers, city);

                this.bindingSource1.DataSource = this.nwDataSet1.Customers;
                this.dataGridView2.DataSource = this.bindingSource1;
                int count = this.bindingSource1.Count;
                this.label1.Text = "共 " +　count.ToString() +"個  '"+ city +"' "+"Customers";
            }
        }
    }
}
