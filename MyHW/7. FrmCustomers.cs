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
    public partial class FrmCustomers : Form
    {
        public FrmCustomers()
        {
            InitializeComponent();

            //divide and conquer
            //初始化
            this.listView1.View = View.Details; //顯示所有資料
            CreateListViewColumns();  //載入表格schema到dataGridView1 & 建立ListView
            LoadCountryToComboBox();  //載入表格的國家到comboBox
        }

        //載入表格的國家到comboBox
        private void LoadCountryToComboBox()
        {
            //Connected
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    SqlCommand command = new SqlCommand("select distinct country from Customers", conn);

                    conn.Open();

                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        this.comboBox1.Items.Add(dataReader["Country"]);
                    }
                    this.comboBox1.Items.Add("All Country");

                    this.comboBox1.SelectedIndex = comboBox1.Items.Count - 1;  //All Coutry為預設值
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //載入表格schema到dataGridView1 & 建立ListView
        private void CreateListViewColumns()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {                   
                    SqlCommand command = new SqlCommand("select * from Customers", conn);

                    conn.Open();
                    
                    SqlDataReader dataReader = command.ExecuteReader();

                    DataTable table = dataReader.GetSchemaTable();

                    this.dataGridView1.DataSource = table;  //載入表格schema到dataGridView1

                    //================================================
                    for (int i = 0; i < table.Rows.Count; i++) 
                    {
                        string columnName = table.Rows[i][0].ToString();
                        listView1.Columns.Add(columnName); //加入schema的coloumnName到ListView的欄位
                    }
                    this.listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize); //調整格式大小

                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //選擇全部國家時顯示全部國家的資料
            if (comboBox1.Text == "All Country")
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                    {
                        SqlCommand command = new SqlCommand("select * from Customers", conn);

                        conn.Open();

                        SqlDataReader dataReader = command.ExecuteReader();

                        this.listView1.Items.Clear();  //消除listView中的Item
                                                       //this.listView1.Columns.Clear();  //消除listView中的Columns
                                                       //this.listView1.Clear();        //消除listView中的Columns和Item

                        Random r = new Random();  //隨機取Icon

                        while (dataReader.Read())
                        {
                            ListViewItem lvi = this.listView1.Items.Add(dataReader[0].ToString()); //加入主item

                            //加格式
                            lvi.ImageIndex = r.Next(0, this.ImageList1.Images.Count); //加Icon

                            if (lvi.Index % 2 == 0)  //加顏色
                            {
                                lvi.BackColor = Color.LightSalmon;
                            }
                            else 
                            {
                                lvi.BackColor = Color.LightCyan;
                            }

                            //若為空值，則加上"空值"
                            for (int i = 1; i < dataReader.FieldCount; i++)
                            {
                                if (dataReader.IsDBNull(i)) //如果資料為空值，則加上"空值"
                                {
                                    lvi.SubItems.Add("空值");
                                }
                                else 
                                {
                                    lvi.SubItems.Add(dataReader[i].ToString());//加入次item
                                }
                            }                              
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else 
            {
                //選擇某國家時顯示某國家的資料
                try
                {
                    using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                    {
                        SqlCommand command = new SqlCommand($"select * from Customers where country = '{comboBox1.Text}'", conn);
                        conn.Open();
                        SqlDataReader dataReader = command.ExecuteReader();

                        this.listView1.Items.Clear();  //消除listView中的Item
                        //this.listView1.Columns.Clear();  //消除listView中的Columns
                        //this.listView1.Clear();        //消除listView中的Columns和Item
                        
                        Random r = new Random();  //隨機取Icon

                        while (dataReader.Read())
                        {
                            ListViewItem lvi = this.listView1.Items.Add(dataReader[0].ToString()); //加入主item //dataReader[0]資料第一欄
                            //lvi為ListView的控制項項目

                            //加格式
                            lvi.ImageIndex = r.Next(0, this.ImageList1.Images.Count); //加Icon

                            if (lvi.Index % 2 == 0)  //加顏色
                            {
                                lvi.BackColor = Color.LightSalmon;
                            }
                            else
                            {
                                lvi.BackColor = Color.LightCyan;
                            }

                            //若為空值，則加上"空值"
                            for (int i = 1; i < dataReader.FieldCount; i++) //dataReader.FieldCount取得資料欄的數量
                            {
                                if (dataReader.IsDBNull(i)) //如果資料為空值，則加上"空值"
                                {
                                    lvi.SubItems.Add("空值");
                                }
                                else
                                {
                                    lvi.SubItems.Add(dataReader[i].ToString()); //加入次item 
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            
                        
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.Details;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.LargeIcon;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.SmallIcon;
        }



        //TODO HW

        //1. All Country


        //================================
        //2. ContextMenuStrip2
        //選擇性作業
        //Groups
        //USA (100) 
        //UK (20)

        //this.listview1.visible = false;
        //ListViewItem lvi = this.listView1.Items.Add(dataReader[0].ToString());

        //if (this.listView1.Groups["USA"] == null)
        //{                       {
        //    ListViewGroup group = this.listView1.Groups.Add("USA", "USA"); //Add(string key, string headerText);
        //    group.Tag = 0;
        //    lvi.Group = group; 
        //}
        //else
        //{
        //    ListViewGroup group = this.listView1.Groups["USA"]; 
        //    lvi.Group = group;
        //}

        //this.listView1.Groups["USA"].Tag = 
        //this.listView1.Groups["USA"].Header = 
    }
}
                                 
