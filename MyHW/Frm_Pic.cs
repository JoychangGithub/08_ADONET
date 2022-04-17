using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHW
{
    public partial class Frm_Pic : Form
    {
        public Frm_Pic()
        {
            InitializeComponent();
        }

        private void myPictureBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.myPictureBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myAlbumDataSet);

        }

        private void Frm_Pic_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'myAlbumDataSet.MyPicture' 資料表。您可以視需要進行移動或移除。
            this.myPictureTableAdapter.Fill(this.myAlbumDataSet.MyPicture);

        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            DialogResult result = this.openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show("OK " + openFileDialog1.FileName);    //顯示圖片openFileDialog1.FileName路徑
                this.picturePictureBox1.Image = Image.FromFile(this.openFileDialog1.FileName);  //從openFileDialog1.FileName路徑建立image
            }
            else
            {
                MessageBox.Show("Cancel");
            }
        }
    }
}
