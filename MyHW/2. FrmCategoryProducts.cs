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

namespace MyHomeWork
{
    public partial class FrmCategoryProducts : Form
    {
        public FrmCategoryProducts()
        {
            InitializeComponent();

            tabControl1.SelectedIndex = 0; //預設connected為最上頁

            //自己手動加comboBox1的item的方法
            //this.comboBox1.Items.AddRange(new object[] {
            //"Beverages",
            //"Condiments",
            //"Confections",
            //"Dairy Products",
            //"Grains/Cereals",
            //"Meat/Poultry",
            //"Produce",
            //"Seafood"});
        }

        SqlConnection conn = null;  //宣告conn變數
        private void FrmCategoryProducts_Load(object sender, EventArgs e)
        {
            //Connected
            try
            {
                conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
                conn.Open();

                //MessageBox.Show("Successfully");

                string commandText = "select CategoryName from Categories";
                SqlCommand command = new SqlCommand(commandText, conn);

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    string s = $"{dataReader["CategoryName"]}";
                    comboBox1.Items.Add(s);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Connected
            //step2: SqlCommand
            conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
            conn.Open();

            string commandText = $"select ProductName from Products as p join Categories as c on p.CategoryID = c.CategoryID where CategoryName = '{comboBox1.Text}'";
            SqlCommand command = new SqlCommand(commandText, conn);

            //step3: SqlDataReader
            SqlDataReader dataReader = command.ExecuteReader();

            this.listBox1.Items.Clear();
            while (dataReader.Read())
            {
                string s = $"{dataReader["ProductName"]}";
                this.listBox1.Items.Add(s);
            }

            conn.Close();
        }


        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            //DisConnected - SqlDataAdapter

            conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter("Select CategoryName from Categories", conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            //this.dataGridView1.DataSource = ds.Tables[0];  //測試用

            DataTable dt;
            dt = ds.Tables[0];
            comboBox2.Items.Clear();  //避免每點tabPage一次就會重複增加CategoryName
            comboBox3.Items.Clear();  //避免每點tabPage一次就會重複增加CategoryName
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                comboBox2.Items.Add(dt.Rows[i]["CategoryName"].ToString());
                comboBox3.Items.Add(dt.Rows[i]["CategoryName"].ToString());
            }
        }
        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //DisConnected - SqlDataAdapter
            conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter($"select ProductName from Products as p join Categories as c on p.CategoryID = c.CategoryID where CategoryName = '{comboBox2.Text}'", conn);

            DataSet ds = new DataSet();
            adapter.Fill(ds);
            //this.dataGridView1.DataSource = ds.Tables[0]; //以dataGridView1顯示(視窗目前無dataGridView)

            DataTable dt;
            dt = ds.Tables[0];
            this.listBox2.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                listBox2.Items.Add(dt.Rows[i]["ProductName"].ToString());
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DisConnected - TableAdapter
            //Add to dataGridView1
            this.productsTableAdapter1.FillByCategoryName(this.nwDataSet1.Products, comboBox3.Text);
            this.dataGridView1.DataSource = this.nwDataSet1.Products;

            this.listBox3.Items.Clear();
            //Add to listBox3
            for (int i = 0; i < this.nwDataSet1.Products.Rows.Count; i++) 
            {
                this.listBox3.Items.Add(this.nwDataSet1.Products[i]["ProductName"]);
            }


        }
    }
}
