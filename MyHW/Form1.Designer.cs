
namespace MyHW
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label pictureIDLabel;
            System.Windows.Forms.Label pictureLabel;
            System.Windows.Forms.Label cityidLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label pictureNameLabel;
            this.myAlbumDataSet = new MyHW.MyAlbumDataSet();
            this.myPictureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myPictureTableAdapter = new MyHW.MyAlbumDataSetTableAdapters.MyPictureTableAdapter();
            this.tableAdapterManager = new MyHW.MyAlbumDataSetTableAdapters.TableAdapterManager();
            this.myPictureBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.myPictureDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.myPictureBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pictureIDTextBox = new System.Windows.Forms.TextBox();
            this.picturePictureBox = new System.Windows.Forms.PictureBox();
            this.cityidTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.pictureNameTextBox = new System.Windows.Forms.TextBox();
            pictureIDLabel = new System.Windows.Forms.Label();
            pictureLabel = new System.Windows.Forms.Label();
            cityidLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            pictureNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myAlbumDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBindingNavigator)).BeginInit();
            this.myPictureBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).BeginInit();
            this.SuspendLayout();
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
            this.myPictureBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.myPictureBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.myPictureBindingNavigator.TabIndex = 0;
            this.myPictureBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(27, 22);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.myPictureDataGridView.Location = new System.Drawing.Point(422, 147);
            this.myPictureDataGridView.Name = "myPictureDataGridView";
            this.myPictureDataGridView.RowTemplate.Height = 24;
            this.myPictureDataGridView.Size = new System.Drawing.Size(300, 220);
            this.myPictureDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PictureID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PictureID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Picture";
            this.dataGridViewImageColumn1.HeaderText = "Picture";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cityid";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cityid";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PictureName";
            this.dataGridViewTextBoxColumn4.HeaderText = "PictureName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "加入新的";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // myPictureBindingNavigatorSaveItem
            // 
            this.myPictureBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.myPictureBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("myPictureBindingNavigatorSaveItem.Image")));
            this.myPictureBindingNavigatorSaveItem.Name = "myPictureBindingNavigatorSaveItem";
            this.myPictureBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.myPictureBindingNavigatorSaveItem.Text = "儲存資料";
            this.myPictureBindingNavigatorSaveItem.Click += new System.EventHandler(this.myPictureBindingNavigatorSaveItem_Click);
            // 
            // pictureIDLabel
            // 
            pictureIDLabel.AutoSize = true;
            pictureIDLabel.Location = new System.Drawing.Point(183, 169);
            pictureIDLabel.Name = "pictureIDLabel";
            pictureIDLabel.Size = new System.Drawing.Size(55, 12);
            pictureIDLabel.TabIndex = 2;
            pictureIDLabel.Text = "Picture ID:";
            // 
            // pictureIDTextBox
            // 
            this.pictureIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.myPictureBindingSource, "PictureID", true));
            this.pictureIDTextBox.Location = new System.Drawing.Point(259, 166);
            this.pictureIDTextBox.Name = "pictureIDTextBox";
            this.pictureIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.pictureIDTextBox.TabIndex = 3;
            // 
            // pictureLabel
            // 
            pictureLabel.AutoSize = true;
            pictureLabel.Location = new System.Drawing.Point(183, 194);
            pictureLabel.Name = "pictureLabel";
            pictureLabel.Size = new System.Drawing.Size(40, 12);
            pictureLabel.TabIndex = 4;
            pictureLabel.Text = "Picture:";
            // 
            // picturePictureBox
            // 
            this.picturePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.myPictureBindingSource, "Picture", true));
            this.picturePictureBox.Location = new System.Drawing.Point(259, 194);
            this.picturePictureBox.Name = "picturePictureBox";
            this.picturePictureBox.Size = new System.Drawing.Size(100, 50);
            this.picturePictureBox.TabIndex = 5;
            this.picturePictureBox.TabStop = false;
            // 
            // cityidLabel
            // 
            cityidLabel.AutoSize = true;
            cityidLabel.Location = new System.Drawing.Point(183, 253);
            cityidLabel.Name = "cityidLabel";
            cityidLabel.Size = new System.Drawing.Size(37, 12);
            cityidLabel.TabIndex = 6;
            cityidLabel.Text = "Cityid:";
            // 
            // cityidTextBox
            // 
            this.cityidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.myPictureBindingSource, "Cityid", true));
            this.cityidTextBox.Location = new System.Drawing.Point(259, 250);
            this.cityidTextBox.Name = "cityidTextBox";
            this.cityidTextBox.Size = new System.Drawing.Size(100, 22);
            this.cityidTextBox.TabIndex = 7;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(183, 281);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(61, 12);
            descriptionLabel.TabIndex = 8;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.myPictureBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(259, 278);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 22);
            this.descriptionTextBox.TabIndex = 9;
            // 
            // pictureNameLabel
            // 
            pictureNameLabel.AutoSize = true;
            pictureNameLabel.Location = new System.Drawing.Point(183, 309);
            pictureNameLabel.Name = "pictureNameLabel";
            pictureNameLabel.Size = new System.Drawing.Size(70, 12);
            pictureNameLabel.TabIndex = 10;
            pictureNameLabel.Text = "Picture Name:";
            // 
            // pictureNameTextBox
            // 
            this.pictureNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.myPictureBindingSource, "PictureName", true));
            this.pictureNameTextBox.Location = new System.Drawing.Point(259, 306);
            this.pictureNameTextBox.Name = "pictureNameTextBox";
            this.pictureNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.pictureNameTextBox.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(pictureIDLabel);
            this.Controls.Add(this.pictureIDTextBox);
            this.Controls.Add(pictureLabel);
            this.Controls.Add(this.picturePictureBox);
            this.Controls.Add(cityidLabel);
            this.Controls.Add(this.cityidTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(pictureNameLabel);
            this.Controls.Add(this.pictureNameTextBox);
            this.Controls.Add(this.myPictureDataGridView);
            this.Controls.Add(this.myPictureBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myAlbumDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBindingNavigator)).EndInit();
            this.myPictureBindingNavigator.ResumeLayout(false);
            this.myPictureBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).EndInit();
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
        private System.Windows.Forms.DataGridView myPictureDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox pictureIDTextBox;
        private System.Windows.Forms.PictureBox picturePictureBox;
        private System.Windows.Forms.TextBox cityidTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox pictureNameTextBox;
    }
}