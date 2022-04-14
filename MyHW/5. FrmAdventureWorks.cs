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
    public partial class FrmAdventureWorks : Form
    {
        public FrmAdventureWorks()
        {
            InitializeComponent();

            //Load combobox年份資料
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=AdventureWorks2019;Integrated Security=True");
            SqlDataAdapter adpter = new SqlDataAdapter("SELECT DATEPART(year, ModifiedDate) AS 'Year', COUNT(*) AS Expr1 FROM Production.ProductPhoto GROUP BY DATEPART(year, ModifiedDate)", conn);
            DataSet ds = new DataSet();
            adpter.Fill(ds);

            //TODO
            //this.productPhotoTableAdapter1.FillByYear(this.awDataSet11.ProductPhoto);
            //this.dataGridView2.DataSource = this.awDataSet11.ProductPhoto;

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string year = ds.Tables[0].Rows[i]["Year"].ToString();
                comboBox1.Items.Add(year);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime starttime = dateTimePicker1.Value;
            DateTime endtime = dateTimePicker2.Value;

            //顯示某區間資料
            this.productPhotoTableAdapter1.FillByModifieddate(this.awDataSet11.ProductPhoto, starttime, endtime);
            //增加position屬性
            this.bindingSource1.DataSource = this.awDataSet11.ProductPhoto; 
            this.dataGridView1.DataSource = this.bindingSource1;

            //bindingNavigator
            this.bindingNavigator1.BindingSource = this.bindingSource1;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.bindingSource1.Position += 1;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.bindingSource1.Position = this.bindingSource1.Count - 1;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.bindingSource1.Position -= 1;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.bindingSource1.Position = 0;
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            label4.Text = $"{ this.bindingSource1.Position + 1} / {this.bindingSource1.Count}";
        }

        //年份篩選
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal year = decimal.Parse(comboBox1.Text);
            this.productPhotoTableAdapter1.FillBySelectYear(this.awDataSet11.ProductPhoto, year);
            //增加position屬性
            this.bindingSource1.DataSource = this.awDataSet11.ProductPhoto;
            this.dataGridView1.DataSource = this.bindingSource1;

            //bindingNavigator
            this.bindingNavigator1.BindingSource = this.bindingSource1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //排序
            this.dataGridView1.Sort(dataGridView1.Columns[5], ListSortDirection.Ascending);
        }
    }
}
