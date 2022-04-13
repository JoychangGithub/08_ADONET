using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHW
{
    public partial class FrmOverview : Form
    {
        public FrmOverview()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Load table
            this.productsTableAdapter1.Fill(this.nwDataSet1.Products);
            this.dataGridView2.DataSource = this.nwDataSet1.Products;
            this.categoriesTableAdapter1.Fill(this.nwDataSet1.Categories);
            this.dataGridView3.DataSource = this.nwDataSet1.Categories;
            this.customersTableAdapter1.Fill(this.nwDataSet1.Customers);
            this.dataGridView4.DataSource = this.nwDataSet1.Customers;

            //==============================================================

            this.listBox1.Items.Clear();
            //Load tableName
            string t = "";
            for (int i = 0; i < this.nwDataSet1.Tables.Count; i++) 
            {
                DataTable table = this.nwDataSet1.Tables[i];
                t = "TableName" + table.TableName + ":";
                listBox1.Items.Add(table.TableName);

                //Load colomnName
                string s;
                for (int column = 0; column < table.Columns.Count; column++)
                {
                    s = " " + table.Columns[column].ColumnName + ": ";

                    listBox1.Items.Add(s);

                    //Load data
                    string data = "";
                    for (int row = 0; row < table.Rows.Count; row++)
                    {
                        data += table.Rows[row][column] + " ";
                    }
                    listBox1.Items.Add(data);
                    listBox1.Items.Add("============================");
                }              
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //take data:strong type
            MessageBox.Show(this.nwDataSet1.Products[0].ProductName.ToString());

            //take data:weak type
            //MessageBox.Show(this.nwDataSet1.Products.Rows[0]["ProductName"].ToString());
        }

        //Writexml
        private void button3_Click(object sender, EventArgs e)
        {
            this.nwDataSet1.Products.WriteXml("Product.xml", XmlWriteMode.WriteSchema);
        }

        //readxml
        private void button4_Click(object sender, EventArgs e)
        {
            this.nwDataSet1.Products.Clear();
            this.nwDataSet1.Products.ReadXml("Product.xml");
            this.dataGridView2.DataSource = this.nwDataSet1.Products;
        }

        //收容器
        private void button5_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel1Collapsed = !this.splitContainer2.Panel1Collapsed;
        }
    }
}
