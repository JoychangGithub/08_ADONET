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
            ShowCityLink();  //顯示城市
            this.flowLayoutPanel2.AllowDrop = true;  //允許拖曳照片至flowLayoutPanel2
            this.flowLayoutPanel2.DragEnter += FlowLayoutPanel_DragEnter;
            this.flowLayoutPanel2.DragDrop += FlowLayoutPanel_DragDrop;
        }

        private void FlowLayoutPanel_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            for (int i = 0; i < files.Length; i++) 
            {
                PictureBox pic = new PictureBox();
                pic.Image = Image.FromFile(files[i]);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                //pic.Width = 120;
                //pic.Height = 80;
                pic.Click += Pic_Click;

                this.flowLayoutPanel2.Controls.Add(pic);
            }
        }

        private void FlowLayoutPanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void ShowCityLink()
        {
            //動態顯示城市Linklabel
            //MessageBox.Show(this.myCityTableAdapter.Connection.ConnectionString);

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
                //x.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom);

                //x.LinkArea = new LinkArea(0, 50);
                x.Left = 20;
                x.Top = 50 * (i + 1);
                x.Tag = i;  //ID

                x.Click += X_Click;//每個Click都指向同一方法X_Click

                this.splitContainer5.Panel1.Controls.Add(x);
                //this.flowLayoutPanel3.Controls.Add(x);

                //==================================
                comboBox1.Items.Add(city);
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


        private void ShowImage(int cityid)
        {
            //用離線寫

            //Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\myADONET\作業\0414\08_張宜潔\MyHW\MyAlbumDatabase.mdf; Integrated Security = True
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"(LocalDB)\MSSQLLocalDB";
            builder.AttachDBFilename = Application.StartupPath + @"\MyAlbumDatabase.mdf";
            builder.IntegratedSecurity = true;

            //MessageBox.Show(builder.ConnectionString);

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
                            pic.Width = 200;
                            pic.Height = 150;
                            pic.Padding = new Padding(8);
                            pic.BorderStyle = BorderStyle.Fixed3D;

                            pic.Click += Pic_Click;  //註冊方法  //點選圖片放大
                            pic.MouseEnter += Pic_MouseEnter;  //註冊方法  //點選圖片邊框為紅色
                            pic.MouseLeave += Pic_MouseLeave;  //離開圖片邊框恢復無色

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

        private void Pic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BorderStyle = BorderStyle.Fixed3D;
            pb.BackColor = Color.Transparent;
        }

        private void Pic_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BorderStyle = BorderStyle.None;
            pb.BackColor = Color.Pink;
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.BackgroundImage = ((PictureBox)sender).Image;
            f.BackgroundImageLayout = ImageLayout.Stretch;
            f.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"(LocalDB)\MSSQLLocalDB";
            builder.AttachDBFilename = Application.StartupPath + @"\MyAlbumDatabase.mdf";
            builder.IntegratedSecurity = true;

            //MessageBox.Show(builder.ConnectionString);

            try
            {
                SqlConnection conn = null;
                //語法糖(syntax sugar):using
                using (conn = new SqlConnection(builder.ConnectionString))
                {
                    //MessageBox.Show(conn.State.ToString()); //確認連接狀態

                    SqlCommand command = new SqlCommand();
                    command.CommandText = $"Select Picture from MyPicture  as p join MyCity as c on p.CityID = c.CityId where CityName='{comboBox1.Text}'";
                    command.Connection = conn;
                    conn.Open();

                    SqlDataReader dataReader = command.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        this.flowLayoutPanel2.Controls.Clear();
                        while (dataReader.Read())
                        {

                            byte[] bytes = (byte[])dataReader["Picture"];  //讀取Picture的二進位資料
                            System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes); //建立MemoryStream ms

                            PictureBox pic = new PictureBox();
                            pic.Image = Image.FromStream(ms);
                            pic.SizeMode = PictureBoxSizeMode.StretchImage;
                            pic.Width = 200;
                            pic.Height = 150;
                            pic.Padding = new Padding(8);
                            pic.BorderStyle = BorderStyle.Fixed3D;

                            pic.MouseEnter += Pic_MouseEnter;  //註冊方法  //點選圖片邊框為紅色
                            pic.MouseLeave += Pic_MouseLeave;  //離開圖片邊框恢復無色

                            this.flowLayoutPanel2.Controls.Add(pic);
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
                this.pictureBox2.Image = this.pictureBox2.ErrorImage;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Show the FolderBrowserDialog.
            //DialogResult result = folderBrowserDialog1.ShowDialog();
            // if (result == DialogResult.OK)
            // {
            //    folderName = folderBrowserDialog1.SelectedPath;
            //    if (!fileOpened)
            //    {
            //        // No file is opened, bring up openFileDialog in selected path.
            //        openFileDialog1.InitialDirectory = folderName;
            //        openFileDialog1.FileName = null;
            //        openMenuItem.PerformClick();
            //    }
            //}

            // Show the FolderBrowserDialog.
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            //this.txtPath.Text = path.SelectedPath;


        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            this.comboBox1.SelectedIndex = 0;  //Lisbon為預設值
        }
    }
}

