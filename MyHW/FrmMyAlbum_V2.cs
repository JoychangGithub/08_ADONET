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

            int cityid = Convert.ToInt32(x.Tag) + 1;

            ShowImage(cityid);
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
                
            }
            else
            {
                MessageBox.Show("Cancel");
            }
        }

        private void ShowImage(int cityid) 
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
                using (conn = new SqlConnection(builder.ConnectionString))
                {
                    //MessageBox.Show(conn.State.ToString()); //確認連接狀態

                    SqlCommand command = new SqlCommand();
                    command.CommandText = $"Select Picture from MyPicture where Cityid='{cityid}'";
                    command.Connection = conn;
                    conn.Open();

                    SqlDataReader dataReader = command.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        this.flowLayoutPanel1.Controls.Clear();
                        while (dataReader.Read()) 
                        {

                            byte[] bytes = (byte[])dataReader["Picture"];  //讀取Picture的二進位資料
                            System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes); //建立MemoryStream ms

                            PictureBox pic = new PictureBox();
                            pic.Image = Image.FromStream(ms);
                            pic.SizeMode = PictureBoxSizeMode.StretchImage;
                            pic.Width = 150;
                            pic.Height = 100;
                            pic.Click += Pic_Click;  //註冊方法  //點選圖片放大
                            this.flowLayoutPanel1.Controls.Add(pic);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Record");
                    }
                }
            }
            catch 
            {
                this.pictureBox1.Image = this.pictureBox1.ErrorImage;
            }
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.BackgroundImage = ((PictureBox)sender).Image;
            f.BackgroundImageLayout = ImageLayout.Stretch;
            f.Show();
        }


    }
}

