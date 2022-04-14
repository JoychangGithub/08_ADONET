using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHW
{
    public partial class FrmMyAlbum_V1 : Form
    {
        public FrmMyAlbum_V1()
        {
            InitializeComponent();

            string[] cityArray = new string[4] { "台北", "巴黎", "東京","里斯本"};
            for (int i = 0; i < 4; i++) 
            {
                LinkLabel x = new LinkLabel();
                x.Text = cityArray[i] +"-" +  i;
                //x.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
                x.Left = 20;
                x.Top = 80  * ( i+1);
                x.Tag = i;  //ID

                x.Click += X_Click;   //每個Click都指向同一方法X_Click
                this.splitContainer1.Panel1.Controls.Add(x);

            }
        }
        private void X_Click(object sender, EventArgs e) 
        {
            //MessageBox.Show(((LinkLabel)sender).Text+"-"+((LinkLabel)sender).Tag);

            LinkLabel x = sender as LinkLabel;  //轉成原LinkLabel
            if (x != null) 
            {
                MessageBox.Show(x.Text);
                //[Connected]
                //相對路徑 SqlConnectionStringBuilder
                //SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                ////Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\myADONET\作業\0414\08_張宜潔\MyHW\MyAlbumDatabase.mdf; Integrated Security = True
                //builder.DataSource = @"(LocalDB)\MSSQLLocalDB";
                //builder.AttachDBFilename = Application.StartupPath + @"\MyAlbumDatabase.mdf";
                //builder.IntegratedSecurity = true;
                //MessageBox.Show(builder.ConnectionString);   //測試build是否正確

                //try
                //{
                //    SqlConnection conn = null;
                //    using (conn = new SqlConnection(builder.ConnectionString))
                //    {
                //        conn.Open();
                //        MessageBox.Show(conn.State.ToString());  //測試連線狀態
                //        SqlCommand command = new SqlCommand("Select * from MyCity", conn);
                //        this.listBox1.Items.Clear();
                //        SqlDataReader dataReader = command.ExecuteReader();

                //        while (dataReader.Read())
                //        {
                //            //string s = $"{dataReader["CityName"]}";
                //            string s = $"{dataReader}";
                //            this.listBox1.Items.Add(s);
                //        }
                //    }
                //    MessageBox.Show(conn.State.ToString());  //測試連線狀態
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);

                //}


                //ConfigurationManager
                //string connString = ConfigurationManager.ConnectionStrings["MyHW.Properties.Settings.MyAlbumDatabaseConnectionString"].ConnectionString;


                //Sql server Local DB-相對路徑-SqlConnectionStringBuilder

                //DisConnected
                this.myPictureTableAdapter1.Fill(this.myAlbumDataSet1.MyPicture);
                this.bindingSource1.DataSource = this.myAlbumDataSet1.MyPicture;
                this.dataGridView1.DataSource = this.bindingSource1.DataSource;

                this.bindingNavigator1.BindingSource = this.bindingSource1;




            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = this.openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show("OK " + openFileDialog1.FileName);    //顯示圖片openFileDialog1.FileName路徑
                this.pictureBox1.Image = Image.FromFile(this.openFileDialog1.FileName);  //從openFileDialog1.FileName路徑建立image
            }
            else
            {
                MessageBox.Show("Cancel");
            }
        }
    }
}
