using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHomeWork
{
    public partial class FrmProducts : Form
    {
        public FrmProducts()
        {
            InitializeComponent();
            this.bindingNavigator1.BindingSource = this.bindingSource1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter1.FillByProductName(this.nwDataSet1.Products, textBox3.Text);  //模糊查詢
            //this.dataGridView1.DataSource = this.nwDataSet1.Products;
            this.bindingSource1.DataSource = this.nwDataSet1.Products;  //bindingSource有position屬性
            this.dataGridView1.DataSource = this.bindingSource1;

            this.lblResult.Text = $"結果 {this.bindingSource1.Count} 筆";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal price1 = decimal.Parse(textBox1.Text);
            decimal price2 = decimal.Parse(textBox2.Text);

            this.productsTableAdapter1.FillByUnitPrice(this.nwDataSet1.Products, price1, price2);
            //this.dataGridView1.DataSource = this.nwDataSet1.Products;
            this.bindingSource1.DataSource = this.nwDataSet1.Products;  //bindingSource有position屬性
            this.dataGridView1.DataSource = this.bindingSource1;

            this.lblResult.Text = $"結果 {this.bindingSource1.Count} 筆";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.bindingSource1.Position += 1;
         }

        private void button14_Click(object sender, EventArgs e)
        {
            this.bindingSource1.Position = this.bindingSource1.Count - 1;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.bindingSource1.Position -= 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.bindingSource1.Position = 0;
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            label2.Text = $"{ this.bindingSource1.Position+1 } / { this.bindingSource1.Count}";
        }
    }
}
