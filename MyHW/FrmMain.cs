using MyHomeWork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace MyHW
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btn_標準練習_Click(object sender, EventArgs e)
        {
            FrmHomeWork homeWorkform = new FrmHomeWork();
            homeWorkform.Show();
        }

        private void btn_FrmCategoryProducts_Click(object sender, EventArgs e)
        {
            FrmCategoryProducts CategoryProductsform = new FrmCategoryProducts();
            CategoryProductsform.Show();
        }

        private void btn_FrmProducts_Click(object sender, EventArgs e)
        {
            FrmProducts Productsform = new FrmProducts();
            Productsform.Show();
        }

        private void btn_FrmOverview_Click(object sender, EventArgs e)
        {
            FrmOverview OverviewForm = new FrmOverview();
            OverviewForm.Show();
        }

        private void btn_FrmAdventureWorks_Click(object sender, EventArgs e)
        {
            FrmAdventureWorks AdventureWorksForm = new FrmAdventureWorks();
            AdventureWorksForm.Show();
        }

        private void btn_FrmMyAlbum_V1_Click(object sender, EventArgs e)
        {
            FrmMyAlbum_V1 MyAlbumForm = new FrmMyAlbum_V1();
            MyAlbumForm.Show();
        }

        private void btn_FrmCustomers_Click(object sender, EventArgs e)
        {
            FrmCustomers CustomersForm = new FrmCustomers();
            CustomersForm.Show();
        }

        private void btn_FrmLogon_Click(object sender, EventArgs e)
        {
            FrmLogon LogonForm = new FrmLogon();
            LogonForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmTreeView TreeviewForm = new FrmTreeView();
            TreeviewForm.Show();
        }
    }
}
