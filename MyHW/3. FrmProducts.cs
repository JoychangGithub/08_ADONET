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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter1.FillByProductName(this.nwDataSet1.Products, textBox3.Text);
            this.dataGridView1.DataSource = this.nwDataSet1.Products;

        }
    }
}
