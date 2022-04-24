using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHW
{
    public partial class FrmPicViewer : Form
    {
        public FrmPicViewer()
        {
            InitializeComponent();
        }

        private void myPictureBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.myPictureBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myAlbumDataSet);

        }

        private void FrmPicViewer_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'myAlbumDataSet.MyPicture' 資料表。您可以視需要進行移動或移除。
            this.myPictureTableAdapter.Fill(this.myAlbumDataSet.MyPicture);

        }
        //下一頁
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            bindingSource1.Position += 1;
        }

        //上一頁
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            bindingSource1.Position -= 1;
        }

        //實際大小
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (pictureBox1.SizeMode == PictureBoxSizeMode.StretchImage)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            int position = bindingSource1.Position;
            int length = this.dataGridView1.Rows.Count - 1;
            MessageBox.Show(length.ToString());
            //bool Flag = true;

            for (int k=1; k > 0; k++)
            {

                if (position < length)
                {
                    for (int i = position; i < length; i++)
                    {
                        bindingSource1.Position = i;
                        Application.DoEvents();
                        Thread.Sleep(700);
                    }
                    k++;
                }
                if (bindingSource1.Position == length - 1)
                {

                    bindingSource1.Position = 0;
                    position = 0;
                    //Application.DoEvents();
                    //Thread.Sleep(700);
                    k++;
                }
                //if (this.Close() == true) 
                //{

                //}
                
            }

                        
        }
    }
}
