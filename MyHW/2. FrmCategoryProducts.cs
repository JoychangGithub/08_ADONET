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

            this.comboBox1.Items.AddRange(new object[] {
            "Beverages",
            "Condiments",
            "Confections",
            "Dairy Products",
            "Grains/Cereals",
            "Meat/Poultry",
            "Produce",
            "Seafood"});
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //step1: SqlConnection
            SqlConnection conn = null;  //宣告conn變數

            try
            {
                conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
                conn.Open();

                //step2: SqlCommand
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                if (conn != null) 
                {
                    conn.Close();
                }
            }
        }
    }
}
