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
            timer1.Enabled = !timer1.Enabled;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //int position = bindingSource1.Position;
            //int length = this.dataGridView1.Rows.Count - 1;

            if (timer1.Enabled)
            {
                if (bindingSource1.Position < bindingSource1.Count - 1)
                {
                    //bindingSource1.Position = position + 1;
                    bindingSource1.MoveNext();
                }
                else //if (bindingSource1.Position == bindingSource1.Count - 1)
                {
                    bindingSource1.MoveFirst();
                    //position = 0;
                }

                //if (bindingSource1.Position == bindingSource1.Count - 1) { bindingSource1.MoveFirst(); }
                //else { bindingSource1.MoveNext(); }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar1.Minimum = 367;
            trackBar1.Maximum = 600;

            pictureBox1.Width = trackBar1.Value;
            pictureBox1.Height = trackBar1.Value;
        }
    }
}
