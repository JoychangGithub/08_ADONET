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
    public partial class FrmMyAlbum_V2 : Form
    {
        public FrmMyAlbum_V2()
        {
            InitializeComponent();

            ShowCityLink();
        }
        private void ShowCityLink()
        {
            //動態顯示城市Linklabel
            MessageBox.Show(this.myCityTableAdapter.Connection.ConnectionString);

            this.myCityTableAdapter.Fill(this.myAlbumDataSet.MyCity);
            this.bindingSource1.DataSource = this.myAlbumDataSet.MyCity;
            //this.dataGridView1.DataSource = this.myAlbumDataSet1.MyCity; //test
            DataTable table = this.myAlbumDataSet.MyCity;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string city = table.Rows[i]["CityName"].ToString();

                LinkLabel x = new LinkLabel();
                x.Text = city;
                x.Size = new System.Drawing.Size(100, 50);
                x.Font = new System.Drawing.Font("Consolas", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
                x.LinkColor = System.Drawing.Color.DarkSeaGreen;
                x.VisitedLinkColor = System.Drawing.Color.Black;
                x.LinkBehavior = LinkBehavior.AlwaysUnderline;
                //x.LinkArea = new LinkArea(0, 50);
                x.Left = 20;
                x.Top = 50 * (i + 1);
                x.Tag = i;  //ID

                x.Click += X_Click;//每個Click都指向同一方法X_Click

                this.splitContainer5.Panel1.Controls.Add(x);
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

            this.myPictureTableAdapter1.FillByCityID(this.myAlbumDataSet.MyPicture, cityid);
            this.bindingSource1.DataSource = this.myAlbumDataSet.MyPicture;
            this.dataGridView1.DataSource = this.bindingSource1;
            this.pictureBox1.DataBindings.Add("Image", this.bindingSource1, "Picture", true);

            //string[] files = (string[]) e.Data.GetData(DataFormats.FileDrop);


            //放到建構子方法出問題?System.ArgumentException: '無法繫結至 DataSource 上的屬性或欄位 Description
            //this.pictureBox1.DataBindings.Add("Image", this.bindingSource2, "Picture", true);
            //this.textBox1.DataBindings.Add("Text", this.bindingSource2, "Description");

            //listBox1.Items.Clear();
            //for (int i = 0; i < this.myAlbumDataSet1.MyPicture.Count; i++)
            //{
            //    string picName = this.myAlbumDataSet1.MyPicture.Rows[i]["PictureName"].ToString();
            //    listBox1.Items.Add(picName);
            //}
        }

        private void myCityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.myCityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myAlbumDataSet);

        }

        private void FrmMyAlbum_V2_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'myAlbumDataSet.MyCity' 資料表。您可以視需要進行移動或移除。
            this.myCityTableAdapter.Fill(this.myAlbumDataSet.MyCity);

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

        private void button2_Click(object sender, EventArgs e)
        {
            //用離線寫

            //Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\myADONET\作業\0414\08_張宜潔\MyHW\MyAlbumDatabase.mdf; Integrated Security = True
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"(LocalDB)\MSSQLLocalDB";
            builder.AttachDBFilename = Application.StartupPath + @"\MyAlbumDatabase.mdf";
            builder.IntegratedSecurity = true;

            MessageBox.Show(builder.ConnectionString);

            try
            {
                SqlConnection conn = null;
                //語法糖(syntax sugar):using
                using (conn = new SqlConnection(builder.ConnectionString))//連線與自動關閉連線 //需using System.Data.SqlClient
                {
                    //MessageBox.Show(conn.State.ToString()); //確認連接狀態

                    SqlCommand command = new SqlCommand();
                    command.CommandText = $"Insert into MyPicture (PictureName, Image) values (@PictureName, @Image)";
                    command.Connection = conn;

                    byte[] bytes;  //宣告變數bytes

                    System.IO.MemoryStream ms = new System.IO.MemoryStream(); //建立MemoryStream ms
                    this.pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    bytes = ms.GetBuffer();   //回傳bytes陣列

                    command.Parameters.Add("@Description", SqlDbType.Text).Value = this.textBox1.Text;
                    command.Parameters.Add("@Image", SqlDbType.Image).Value = bytes;

                    conn.Open();  //執行command前在open即可

                    command.ExecuteNonQuery();  //執行command
                    MessageBox.Show("Insert PictureName and Image Successfully");


                }


            }

            //////string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            //for (int i = 0; i < files.Length; i++)
            //{
            //    PictureBox pic = new PictureBox();  //建立PictureBoxg實體pic
            //    pic.Image = Image.FromFile(files[i]);
            //    pic.SizeMode = PictureBoxSizeMode.StretchImage;
            //    pic.Width = 120;
            //    pic.Height = 80;

            //    //=================================
            //    //點選圖片放大
            //    //pic.Click += Pic_Click;  //註冊方法

            //    this.flowLayoutPanel1.Controls.Add(pic);
            //}






            //        //System.IO.MemoryStream ms = new System.IO.MemoryStream(); //建立MemoryStream ms
            //        //this.pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            //        //bytes = ms.GetBuffer();   //回傳bytes陣列

            //        //command.Parameters.Add("@PictureName", SqlDbType.Text).Value = this.textBox1.Text;
            //        //command.Parameters.Add ("@Picture", SqlDbType.Image).Value = bytes;

            //        //conn.Open();  //執行command前在open即可

            //        //command.ExecuteNonQuery();  //執行command
            //        //MessageBox.Show("Insert Description and Image Successfully");

            //    }
            ////Auto conn.Close();

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


    }
}

