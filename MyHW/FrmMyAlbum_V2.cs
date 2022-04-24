using MyHW.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
            ShowCityLink();  //顯示城市linklabel
            ShowCityphotos();  //顯示城市dataGridView
            this.flowLayoutPanel2.AllowDrop = true;  //允許拖曳照片至flowLayoutPanel2
            this.flowLayoutPanel2.DragEnter += FlowLayoutPanel_DragEnter;
            this.flowLayoutPanel2.DragDrop += FlowLayoutPanel_DragDrop;
            
        }

        private void ShowCityphotos()
        {           
            this.myPictureTableAdapter1.FillByShowCityName(this.myAlbumDataSet1.MyPicture);//join 2個table，使可以顯示城市名稱
            this.bindingSource1.DataSource = this.myAlbumDataSet1.MyPicture;
            this.dataGridView1.DataSource = this.bindingSource1;

            this.textBox1.DataBindings.Add("Text", this.bindingSource1, "PictureID");
            this.textBox2.DataBindings.Add("Text", this.bindingSource1, "CityID");
            this.textBox4.DataBindings.Add("Text", this.bindingSource1, "PictureName");
            this.textBox5.DataBindings.Add("Text", this.bindingSource1, "Description");
            this.pictureBox3.DataBindings.Add("Image", this.bindingSource1, "Picture", true);
            this.comboBox2.DataBindings.Add("Text", this.bindingSource1, "CityName") ;
            this.dateTimePicker1.DataBindings.Add("Value", this.bindingSource1, "Date");

            this.bindingNavigator1.BindingSource = this.bindingSource1;
            
        }

        Dictionary<string, int> dicCity = new Dictionary<string, int>();
        private void InsertPicture(PictureBox pic)
        {
            //Insert Image into Table

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"(LocalDB)\MSSQLLocalDB";
            builder.AttachDBFilename = Application.StartupPath + @"\MyAlbumDatabase.mdf";
            builder.IntegratedSecurity = true;

            //MessageBox.Show(builder.ConnectionString);
           
            try
            {
                SqlConnection conn = null;
                using (conn = new SqlConnection(builder.ConnectionString))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = $"Insert into MyPicture (Picture, Cityid) values (@Picture, @Cityid)";
                    command.Connection = conn;

                    string cityname = comboBox1.Text;

                    int cityid = dicCity[cityname];
                    

                    byte[] bytes;  //宣告變數bytes

                    System.IO.MemoryStream ms = new System.IO.MemoryStream(); //建立MemoryStream ms
                    pic.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    bytes = ms.GetBuffer();   //回傳bytes陣列

                    command.Parameters.Add("@Picture", SqlDbType.Image).Value = bytes;
                    command.Parameters.Add("@Cityid", SqlDbType.Int).Value = cityid;

                    conn.Open(); 

                    command.ExecuteNonQuery();
                    //MessageBox.Show("Insert Picture Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FlowLayoutPanel_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            for (int i = 0; i < files.Length; i++)
            {
                PictureBox pic = new PictureBox();
                pic.Image = Image.FromFile(files[i]);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Width = 200;
                pic.Height = 150;
                pic.Padding = new Padding(8);     //需先設定邊框格式，下面才會被變更
                pic.BorderStyle = BorderStyle.Fixed3D;
                
                pic.MouseEnter += Pic_MouseEnter;  //註冊方法  //點選圖片邊框為紅色
                pic.MouseLeave += Pic_MouseLeave;  //離開圖片邊框恢復無色
                
                this.flowLayoutPanel2.Controls.Add(pic);

                InsertPicture(pic);               
            }
        }

        private void FlowLayoutPanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void ShowCityLink()
        {
            //動態顯示城市Linklabel
            //MessageBox.Show(this.myCityTableAdapter1.Connection.ConnectionString); //確定連線的資料庫

            this.myCityTableAdapter1.Fill(this.myAlbumDataSet1.MyCity);

            DataTable table = this.myAlbumDataSet1.MyCity;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string city = table.Rows[i]["CityName"].ToString();

                LinkLabel x = new LinkLabel();
                x.Text = city;
                x.Size = new System.Drawing.Size(100, 50);
                x.Font = new System.Drawing.Font("Segoe Script", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold))), System.Drawing.GraphicsUnit.Point, ((byte)(20)));
                x.LinkColor = System.Drawing.Color.WhiteSmoke;
                x.VisitedLinkColor = System.Drawing.Color.LightPink;
                x.LinkBehavior = LinkBehavior.AlwaysUnderline;

                x.Left = 20;
                x.Top = 50 * (i + 1);
                x.Tag = i;  //ID

                x.Click += X_Click;//每個Click都指向同一方法X_Click

                this.splitContainer5.Panel1.Controls.Add(x);
                //this.flowLayoutPanel3.Controls.Add(x);

                //==================================
                comboBox1.Items.Add(city);
                comboBox2.Items.Add(city);
                dicCity.Add(city, i+1);   //CityId=x.Tag +１  //將城市名稱與CityId加入dicPic字典
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
            //MessageBox.Show("cityid:" + cityid);
            ShowImage(cityid);
        }

        int ID = 0;
        Dictionary<int, int> dicCityID = new Dictionary<int, int>();  //ID, cityID
        Dictionary<int, int> dicPicID = new Dictionary<int, int>();  //ID, pictureID
        Dictionary<int, int> dicPosition = new Dictionary<int, int>();  //ID, Position
        //List<int> listPic = new List<int>(); //tag清單
        //List<int> listPicCount = new List<int>(); //tag清單
        private void ShowImage(int cityid)
        {
            this.myPictureTableAdapter1.FillByCityid(this.myAlbumDataSet1.MyPicture, cityid);
            this.bindingSource1.DataSource = this.myAlbumDataSet1.MyPicture;
            this.dataGridView2.DataSource = this.bindingSource1;
            
            DataTable table = this.myAlbumDataSet1.MyPicture;

            this.flowLayoutPanel1.Controls.Clear();
           
            for (int i = 0; i<table.Rows.Count; i++)
            {
                byte[] bytes = (byte[])table.Rows[i]["Picture"];  //讀取Picture的二進位資料
                System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes); //建立MemoryStream ms

                PictureBox pic = new PictureBox();

                pic.Image = Image.FromStream(ms);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Width = 200;
                pic.Height = 150;
                pic.Padding = new Padding(8);
                pic.BorderStyle = BorderStyle.Fixed3D;
                pic.Tag = ID;
                
                //listPic.Add(i);
                //listPicCount.Add(table.Rows.Count-1);                

                int PictureID = Convert.ToInt32(table.Rows[i]["PictureID"].ToString());
                dicPicID.Add(ID, PictureID);

                int CityID = Convert.ToInt32(table.Rows[i]["CityID"].ToString());
                dicCityID.Add(ID, CityID);

                dicPosition.Add(ID, i);

                //dicPicCount.Add(CityID, table.Rows.Count - 1);

                pic.Click += Pic_Click;  //註冊方法  //點選圖片放大
                pic.MouseEnter += Pic_MouseEnter;  //註冊方法  //點選圖片邊框為紅色
                pic.MouseLeave += Pic_MouseLeave;  //離開圖片邊框恢復無色

                this.flowLayoutPanel1.Controls.Add(pic);
                ID = ID + 1;
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
            //將f.pictureBox1, f.bindingNavigator1的modifier改為internal

            PictureBox pic = (PictureBox)sender;
            FrmPicViewer f = new FrmPicViewer();
            f.Show();
            f.pictureBox1.Image = pic.Image;
            f.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            int id = Convert.ToInt32(pic.Tag);
            int pictureid = dicPicID[id];
            int cityid = dicCityID[id];
            int position = dicPosition[id];
            MessageBox.Show("id:  " + id + "  pictureid:  " + pictureid + "  cityid:  " + cityid + "position"+ position);
            this.myPictureTableAdapter1.FillByCityid(this.myAlbumDataSet1.MyPicture, cityid);
            //f.dataGridView1.DataSource = this.myAlbumDataSet1.MyPicture;
            f.bindingSource1.DataSource = this.myAlbumDataSet1.MyPicture;
            f.dataGridView1.DataSource = f.bindingSource1;
            f.bindingSource1.Position = position;
            f.pictureBox1.DataBindings.Add("Image", f.bindingSource1, "Picture", true);

            f.bindingNavigator1.BindingSource = f.bindingSource1;                    
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"(LocalDB)\MSSQLLocalDB";
            builder.AttachDBFilename = Application.StartupPath + @"\MyAlbumDatabase.mdf";
            builder.IntegratedSecurity = true;

            try
            {
                SqlConnection conn = null;
                //語法糖(syntax sugar):using
                using (conn = new SqlConnection(builder.ConnectionString))
                {
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
                            pic.MouseDown += Pic_MouseDown;
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
            try
            {
                FolderBrowserDialog dlgFolder = new FolderBrowserDialog();

                dlgFolder.Description = "Batch files all image files from this folder.";

                if (dlgFolder.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(dlgFolder.SelectedPath.ToString());

                    FileInfo[] ImageFiles = dirInfo.GetFiles("*.jpg").Concat(dirInfo.GetFiles("*.jepg")).Concat(dirInfo.GetFiles("*.png")).ToArray();

                    for (int i = 0; i < ImageFiles.Length; ++i)
                    {
                        FileInfo ImageFile = ImageFiles[i];

                        PictureBox pic = new PictureBox();
                        pic.Image = Image.FromFile(ImageFile.FullName);
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        pic.Width = 200;
                        pic.Height = 150;
                        pic.Padding = new Padding(8);     //需先設定邊框格式，下面才會被變更
                        pic.BorderStyle = BorderStyle.Fixed3D;

                        pic.MouseEnter += Pic_MouseEnter;  //註冊方法  //點選圖片邊框為紅色
                        pic.MouseLeave += Pic_MouseLeave;  //離開圖片邊框恢復無色
                        this.flowLayoutPanel2.Controls.Add(pic);

                        InsertPicture(pic);
                    }
                    //MessageBox.Show("Image Files Process Completed", "Process Completed", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            this.comboBox1.SelectedIndex = 0;  //Lisbon為預設值
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = this.openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.pictureBox3.Image = Image.FromFile(this.openFileDialog1.FileName);
            }
            else 
            {
                MessageBox.Show("Cancel");
            }
        }

        private void myCityBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.myCityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myAlbumDataSet1);

        }



        private void DeletePicture(Image img)
        {
            //delete Image from Table

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"(LocalDB)\MSSQLLocalDB";
            builder.AttachDBFilename = Application.StartupPath + @"\MyAlbumDatabase.mdf";
            builder.IntegratedSecurity = true;
            //MessageBox.Show(builder.ConnectionString);
            try
            {
                SqlConnection conn = null;
                using (conn = new SqlConnection(builder.ConnectionString))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "select * FROM MyPicture where PictureID = '1'";
                    command.Connection = conn;

                    conn.Open();

                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read()) 
                    {
                        string Picture = dataReader["Picture"].ToString();
                        listBox1.Items.Add(Picture);
                    }
                    //string PictureID = dataReader["PictureID"].ToString();
                    //string Picture = dataReader["Picture"].ToString();
                    //listBox1.Items.Add(PictureID);
                    //listBox1.Items.Add(Picture);
                    ////string cityname = comboBox1.Text;
                    ////int cityid = dicPic[cityname];


                    ////byte[] bytes;  //宣告變數bytes

                    //System.IO.MemoryStream ms = new System.IO.MemoryStream(); //建立MemoryStream ms
                    //pic.Image.S
                    //bytes = ms.GetBuffer();   //回傳bytes陣列

                    //////command.Parameters.Add("@Picture", SqlDbType.Image).Value = bytes;
                    //command.Parameters.Add("@Picture", SqlDbType.Image).Value = bytes;                 

                    //command.ExecuteNonQuery();  //執行command
                    //MessageBox.Show("Delete Picture Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Pic_MouseDown(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left)
            {
                //MessageBox.Show("按下滑鼠左鍵");//Debug用 
            }

            if (e.Button == MouseButtons.Right)
            {
                PictureBox pic = (PictureBox)sender;
                pic.BorderStyle = BorderStyle.None;
                pic.BackColor = Color.Yellow;

                DialogResult result = MessageBox.Show("刪除此照片?", "刪除", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    pic.BorderStyle = BorderStyle.None;
                    pic.BackColor = Color.Yellow;
                    MessageBox.Show("刪除");
                    Image img = pic.Image;

                    if (img != null)
                    {
                       
                        MessageBox.Show("目前有圖片");
                        //img.Dispose();
                        


                    }

                    //DeletePicture(img);
                }
                else 
                {
                    MessageBox.Show("取消刪除");
                }
                
            }          
        }
        private void 刪除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PictureBox pic = (PictureBox)sender;
            //pic.Dispose();
            //Image img = pic.Image;
            //DeletePicture(img);
        }
        private void myCityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.myCityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myAlbumDataSet1);

        }

        private void FrmMyAlbum_V2_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'myAlbumDataSet.MyCity' 資料表。您可以視需要進行移動或移除。
            this.myCityTableAdapter1.Fill(this.myAlbumDataSet1.MyCity);

        }
    }
    //    class Photo 
    //    {
    //        internal int cityID;
    //        internal int pictureID;
    //        internal int Tag;
    //        internal int count;
    //    }
}


