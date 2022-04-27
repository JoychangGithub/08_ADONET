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
            homeWorkform.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(homeWorkform);//將子窗體載入panel                                           
            homeWorkform.Show();
        }

        private void btn_FrmCategoryProducts_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            FrmCategoryProducts CategoryProductsform = new FrmCategoryProducts();
            CategoryProductsform.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(CategoryProductsform);//將子窗體載入panel                                           
            CategoryProductsform.Show();
        }

        private void btn_FrmProducts_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            FrmProducts Productsform = new FrmProducts();
            Productsform.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(Productsform);//將子窗體載入panel                                           
            Productsform.Show();
        }

        private void btn_FrmOverview_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            FrmOverview OverviewForm = new FrmOverview();
            OverviewForm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(OverviewForm);//將子窗體載入panel                                
            OverviewForm.Show();
        }

        private void btn_FrmAdventureWorks_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            FrmAdventureWorks AdventureWorksForm = new FrmAdventureWorks();
            AdventureWorksForm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(AdventureWorksForm);//將子窗體載入panel                        
            AdventureWorksForm.Show();
        }

        private void btn_FrmMyAlbum_V1_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            FrmMyAlbum_V1 MyAlbumForm = new FrmMyAlbum_V1();
            MyAlbumForm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(MyAlbumForm);//將子窗體載入panel                                
            MyAlbumForm.Show();
        }

        private void btn_FrmCustomers_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            FrmCustomers CustomersForm = new FrmCustomers();
            CustomersForm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(CustomersForm);//將子窗體載入panel                        
            CustomersForm.Show();
        }

        private void btn_FrmLogon_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            FrmLogon LogonForm = new FrmLogon();
            LogonForm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(LogonForm);//將子窗體載入panel  
            LogonForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            FrmTreeView TreeviewForm = new FrmTreeView();
            TreeviewForm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(TreeviewForm);//將子窗體載入panel            
            TreeviewForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            FrmMyAlbum_V2 MyAlbum_V2 = new FrmMyAlbum_V2();
            MyAlbum_V2.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(MyAlbum_V2);//將子窗體載入panel            
            MyAlbum_V2.Show();
            
        }
    }
}
