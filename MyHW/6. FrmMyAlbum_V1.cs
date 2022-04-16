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

            this.label2.Text = "由此插入照片";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.Font = new System.Drawing.Font("Chiller", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));

            this.label3.Text = "相簿中的照片";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.Font = new System.Drawing.Font("Chiller", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));

            //用離線寫

            //Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\myADONET\作業\0414\08_張宜潔\MyHW\MyAlbumDatabase.mdf; Integrated Security = True
            //SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            //builder.DataSource = @"(LocalDB)\MSSQLLocalDB";
            //builder.AttachDBFilename = Application.StartupPath + @"\MyAlbumDatabase.mdf";
            //builder.IntegratedSecurity = true;

            //MessageBox.Show(builder.ConnectionString);

            //try
            //{
            //    SqlConnection conn = null;
            //    //語法糖(syntax sugar):using
            //    using (conn = new SqlConnection(builder.ConnectionString))//連線與自動關閉連線 //需using System.Data.SqlClient
            //    {
            //        conn.Open();
            //        MessageBox.Show(conn.State.ToString()); //確認連接狀態

            //        //step2: sqlCommand
            //        SqlCommand command = new SqlCommand("select * from MyCity", conn);
            //        SqlDataReader dataReader = command.ExecuteReader();  //一開始讀取資料的最上方(無資料)

            //        List<string> cityList = new List<string>();
            //        while (dataReader.Read())   //dataReader.Read()回傳布林值，為true繼續讀下一筆資料
            //        {
            //            LinkLabel x = new LinkLabel();
            //            string s = $"{dataReader["CityName"]}";
            //            cityList.Add(s);

            //            //this.listBox1.Items.Add(s);  //test
            //        }

            //        for (int i = 0; i < cityList.Count; i++)
            //        {
            //            LinkLabel x = new LinkLabel();
            //            x.Text = cityList[i] + "-" + i;
            //            //x.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            //            x.Left = 20;
            //            x.Top = 80 * (i + 1);
            //            x.Tag = i;  //ID

            //            x.Click += X_Click;   //每個Click都指向同一方法X_Click
            //            this.splitContainer1.Panel1.Controls.Add(x);
            //        }

            //        //[DataBinding]
            //        //this.pictureBox1.DataBindings.Add("Image", dataReader, "Picture");

            //    }
            //    MessageBox.Show(conn.State.ToString()); //確認連接狀態
            //}//Auto conn.Close();

            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            this.myCityTableAdapter1.Fill(this.myAlbumDataSet1.MyCity);
            this.bindingSource1.DataSource = this.myAlbumDataSet1.MyCity;
            //this.dataGridView1.DataSource = this.myAlbumDataSet1.MyCity; //test
            DataTable table = this.myAlbumDataSet1.MyCity;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string city = table.Rows[i]["CityName"].ToString();

                LinkLabel x = new LinkLabel();
                x.Text = city;
                x.Size = new System.Drawing.Size(100, 50);
                x.Font = new System.Drawing.Font("Chiller", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
                x.LinkColor = System.Drawing.Color.Salmon;
                x.VisitedLinkColor = System.Drawing.Color.Black;
                x.LinkBehavior = LinkBehavior.AlwaysUnderline;
                //x.LinkArea = new LinkArea(0, 50);
                x.Left = 20;
                x.Top = 50 * (i+1);
                x.Tag = i;  //ID

                x.Click += X_Click;//每個Click都指向同一方法X_Click

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

                //DisConnected
                this.myPictureTableAdapter1.Fill(this.myAlbumDataSet1.MyPicture);
                this.bindingSource1.DataSource = this.myAlbumDataSet1.MyPicture;
                this.dataGridView1.DataSource = this.bindingSource1.DataSource;

            }

        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Frm_Pic fp = new Frm_Pic();
            fp.Show();

        }
    }
}
