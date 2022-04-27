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
            ShowCityLink();
        }

        private void ShowCityLink()
        {
            //MessageBox.Show(this.myCityTableAdapter1.Connection.ConnectionString);//確定連線的資料庫
            //動態顯示城市Linklabel
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
                x.Font = new System.Drawing.Font("Chiller", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
                x.LinkColor = System.Drawing.Color.DarkSeaGreen;
                x.VisitedLinkColor = System.Drawing.Color.Black;
                x.LinkBehavior = LinkBehavior.AlwaysUnderline;
                //x.LinkArea = new LinkArea(0, 50);
                x.Left = 20;
                x.Top = 50 * (i + 1);
                x.Tag = i;  //ID

                x.Click += X_Click;//每個Click都指向同一方法X_Click

                this.splitContainer1.Panel1.Controls.Add(x);
            }
        }

        private void X_Click(object sender, EventArgs e) 
        {
            //MessageBox.Show(((LinkLabel)sender).Text+"-"+((LinkLabel)sender).Tag);

            LinkLabel x = sender as LinkLabel;  //轉成原LinkLabel
            //if (x != null) 
            //{
            //    MessageBox.Show(x.Text);
            //}

            //DisConnected
            int cityid = Convert.ToInt32(x.Tag) + 1;

            this.myPictureTableAdapter1.FillByCityid(this.myAlbumDataSet1.MyPicture, cityid);
        }


        //更新照片資訊
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Frm_Pic fp = new Frm_Pic();
            fp.Show();

        }

        private void btnNextpage_Click(object sender, EventArgs e)
        {
            this.bindingSource2.Position += 1;
        }
    }
}
