
namespace MyHW
{
    partial class Frm_Pic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label pictureIDLabel1;
            System.Windows.Forms.Label pictureLabel1;
            System.Windows.Forms.Label cityidLabel1;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label pictureNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Pic));
            this.myAlbumDataSet = new MyHW.MyAlbumDataSet();
            this.myPictureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myPictureTableAdapter = new MyHW.MyAlbumDataSetTableAdapters.MyPictureTableAdapter();
            this.tableAdapterManager = new MyHW.MyAlbumDataSetTableAdapters.TableAdapterManager();
            this.myPictureBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.myPictureBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureIDLabel2 = new System.Windows.Forms.Label();
            this.picturePictureBox1 = new System.Windows.Forms.PictureBox();
            this.cityidLabel2 = new System.Windows.Forms.Label();
            this.descriptionLabel1 = new System.Windows.Forms.Label();
            this.pictureNameLabel1 = new System.Windows.Forms.Label();
            this.myPictureDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pictureIDLabel1 = new System.Windows.Forms.Label();
            pictureLabel1 = new System.Windows.Forms.Label();
            cityidLabel1 = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            pictureNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myAlbumDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBindingNavigator)).BeginInit();
            this.myPictureBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureIDLabel1
            // 
            pictureIDLabel1.AutoSize = true;
            pictureIDLabel1.Location = new System.Drawing.Point(498, 57);
            pictureIDLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            pictureIDLabel1.Name = "pictureIDLabel1";
            pictureIDLabel1.Size = new System.Drawing.Size(55, 12);
            pictureIDLabel1.TabIndex = 9;
            pictureIDLabel1.Text = "Picture ID:";
            // 
            // pictureLabel1
            // 
            pictureLabel1.AutoSize = true;
            pictureLabel1.Location = new System.Drawing.Point(498, 74);
            pictureLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            pictureLabel1.Name = "pictureLabel1";
            pictureLabel1.Size = new System.Drawing.Size(40, 12);
            pictureLabel1.TabIndex = 11;
            pictureLabel1.Text = "Picture:";
            // 
            // cityidLabel1
            // 
            cityidLabel1.AutoSize = true;
            cityidLabel1.Location = new System.Drawing.Point(493, 303);
            cityidLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            cityidLabel1.Name = "cityidLabel1";
            cityidLabel1.Size = new System.Drawing.Size(37, 12);
            cityidLabel1.TabIndex = 13;
            cityidLabel1.Text = "Cityid:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(493, 318);
            descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(61, 12);
            descriptionLabel.TabIndex = 15;
            descriptionLabel.Text = "Description:";
            // 
            // pictureNameLabel
            // 
            pictureNameLabel.AutoSize = true;
            pictureNameLabel.Location = new System.Drawing.Point(493, 333);
            pictureNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            pictureNameLabel.Name = "pictureNameLabel";
            pictureNameLabel.Size = new System.Drawing.Size(70, 12);
            pictureNameLabel.TabIndex = 17;
            pictureNameLabel.Text = "Picture Name:";
            // 
            // myAlbumDataSet
            // 
            this.myAlbumDataSet.DataSetName = "MyAlbumDataSet";
            this.myAlbumDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // myPictureBindingSource
            // 
            this.myPictureBindingSource.DataMember = "MyPicture";
            this.myPictureBindingSource.DataSource = this.myAlbumDataSet;
            // 
            // myPictureTableAdapter
            // 
            this.myPictureTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MyCityTableAdapter = null;
            this.tableAdapterManager.MyPictureTableAdapter = this.myPictureTableAdapter;
            this.tableAdapterManager.UpdateOrder = MyHW.MyAlbumDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // myPictureBindingNavigator
            // 
            this.myPictureBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.myPictureBindingNavigator.BindingSource = this.myPictureBindingSource;
            this.myPictureBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.myPictureBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.myPictureBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.myPictureBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.myPictureBindingNavigatorSaveItem});
            this.myPictureBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.myPictureBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.myPictureBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.myPictureBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.myPictureBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.myPictureBindingNavigator.Name = "myPictureBindingNavigator";
            this.myPictureBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.myPictureBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.myPictureBindingNavigator.Size = new System.Drawing.Size(805, 31);
            this.myPictureBindingNavigator.TabIndex = 0;
            this.myPictureBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorAddNewItem.Text = "加入新的";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(27, 28);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // myPictureBindingNavigatorSaveItem
            // 
            this.myPictureBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.myPictureBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("myPictureBindingNavigatorSaveItem.Image")));
            this.myPictureBindingNavigatorSaveItem.Name = "myPictureBindingNavigatorSaveItem";
            this.myPictureBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.myPictureBindingNavigatorSaveItem.Text = "儲存資料";
            this.myPictureBindingNavigatorSaveItem.Click += new System.EventHandler(this.myPictureBindingNavigatorSaveItem_Click);
            // 
            // btnBrowser
            // 
            this.btnBrowser.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowser.Location = new System.Drawing.Point(27, 345);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(90, 35);
            this.btnBrowser.TabIndex = 8;
            this.btnBrowser.Text = "Browser...";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureIDLabel2
            // 
            this.pictureIDLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.myPictureBindingSource, "PictureID", true));
            this.pictureIDLabel2.Location = new System.Drawing.Point(574, 57);
            this.pictureIDLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pictureIDLabel2.Name = "pictureIDLabel2";
            this.pictureIDLabel2.Size = new System.Drawing.Size(67, 15);
            this.pictureIDLabel2.TabIndex = 10;
            this.pictureIDLabel2.Text = "label1";
            // 
            // picturePictureBox1
            // 
            this.picturePictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.myPictureBindingSource, "Picture", true));
            this.picturePictureBox1.Location = new System.Drawing.Point(553, 74);
            this.picturePictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picturePictureBox1.Name = "picturePictureBox1";
            this.picturePictureBox1.Size = new System.Drawing.Size(239, 210);
            this.picturePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePictureBox1.TabIndex = 12;
            this.picturePictureBox1.TabStop = false;
            // 
            // cityidLabel2
            // 
            this.cityidLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.myPictureBindingSource, "Cityid", true));
            this.cityidLabel2.Location = new System.Drawing.Point(569, 303);
            this.cityidLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cityidLabel2.Name = "cityidLabel2";
            this.cityidLabel2.Size = new System.Drawing.Size(67, 15);
            this.cityidLabel2.TabIndex = 14;
            this.cityidLabel2.Text = "label1";
            // 
            // descriptionLabel1
            // 
            this.descriptionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.myPictureBindingSource, "Description", true));
            this.descriptionLabel1.Location = new System.Drawing.Point(569, 318);
            this.descriptionLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descriptionLabel1.Name = "descriptionLabel1";
            this.descriptionLabel1.Size = new System.Drawing.Size(67, 15);
            this.descriptionLabel1.TabIndex = 16;
            this.descriptionLabel1.Text = "label1";
            // 
            // pictureNameLabel1
            // 
            this.pictureNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.myPictureBindingSource, "PictureName", true));
            this.pictureNameLabel1.Location = new System.Drawing.Point(569, 333);
            this.pictureNameLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pictureNameLabel1.Name = "pictureNameLabel1";
            this.pictureNameLabel1.Size = new System.Drawing.Size(67, 15);
            this.pictureNameLabel1.TabIndex = 18;
            this.pictureNameLabel1.Text = "label1";
            // 
            // myPictureDataGridView
            // 
            this.myPictureDataGridView.AutoGenerateColumns = false;
            this.myPictureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myPictureDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.myPictureDataGridView.DataSource = this.myPictureBindingSource;
            this.myPictureDataGridView.Location = new System.Drawing.Point(17, 43);
            this.myPictureDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.myPictureDataGridView.Name = "myPictureDataGridView";
            this.myPictureDataGridView.RowHeadersWidth = 62;
            this.myPictureDataGridView.RowTemplate.Height = 31;
            this.myPictureDataGridView.Size = new System.Drawing.Size(440, 291);
            this.myPictureDataGridView.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PictureID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PictureID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Picture";
            this.dataGridViewImageColumn1.HeaderText = "Picture";
            this.dataGridViewImageColumn1.MinimumWidth = 8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cityid";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cityid";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PictureName";
            this.dataGridViewTextBoxColumn4.HeaderText = "PictureName";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // Frm_Pic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.myPictureDataGridView);
            this.Controls.Add(pictureIDLabel1);
            this.Controls.Add(this.pictureIDLabel2);
            this.Controls.Add(pictureLabel1);
            this.Controls.Add(this.picturePictureBox1);
            this.Controls.Add(cityidLabel1);
            this.Controls.Add(this.cityidLabel2);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionLabel1);
            this.Controls.Add(pictureNameLabel);
            this.Controls.Add(this.pictureNameLabel1);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.myPictureBindingNavigator);
            this.Name = "Frm_Pic";
            this.Text = "Frm_Pic";
            this.Load += new System.EventHandler(this.Frm_Pic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myAlbumDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBindingNavigator)).EndInit();
            this.myPictureBindingNavigator.ResumeLayout(false);
            this.myPictureBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyAlbumDataSet myAlbumDataSet;
        private System.Windows.Forms.BindingSource myPictureBindingSource;
        private MyAlbumDataSetTableAdapters.MyPictureTableAdapter myPictureTableAdapter;
        private MyAlbumDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator myPictureBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton myPictureBindingNavigatorSaveItem;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label pictureIDLabel2;
        private System.Windows.Forms.PictureBox picturePictureBox1;
        private System.Windows.Forms.Label cityidLabel2;
        private System.Windows.Forms.Label descriptionLabel1;
        private System.Windows.Forms.Label pictureNameLabel1;
        private System.Windows.Forms.DataGridView myPictureDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}