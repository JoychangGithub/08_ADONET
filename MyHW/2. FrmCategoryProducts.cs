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

            conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
            conn.Open();

            MessageBox.Show("Successfully");

            string commandText = "select CategoryName from Categories";
            SqlCommand command = new SqlCommand(commandText, conn);

            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                string s = $"{dataReader["CategoryName"]}";
                comboBox1.Items.Add(s);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
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
        }
    }
}
