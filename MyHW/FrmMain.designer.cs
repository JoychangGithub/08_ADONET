
namespace MyHW
{
    partial class FrmMain
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_FrmLogon = new System.Windows.Forms.Button();
            this.btn_FrmCustomers = new System.Windows.Forms.Button();
            this.btn_FrmMyAlbum_V1 = new System.Windows.Forms.Button();
            this.btn_FrmAdventureWorks = new System.Windows.Forms.Button();
            this.btn_FrmOverview = new System.Windows.Forms.Button();
            this.btn_FrmProducts = new System.Windows.Forms.Button();
            this.btn_FrmCategoryProducts = new System.Windows.Forms.Button();
            this.btn_標準練習 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = global::MyHW.Properties.Resources.桌布3;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1022, 615);
            this.splitContainer1.SplitterDistance = 112;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackgroundImage = global::MyHW.Properties.Resources.桌布1;
            this.splitContainer2.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer2.Panel1.Controls.Add(this.button2);
            this.splitContainer2.Panel1.Controls.Add(this.button1);
            this.splitContainer2.Panel1.Controls.Add(this.btn_FrmLogon);
            this.splitContainer2.Panel1.Controls.Add(this.btn_FrmCustomers);
            this.splitContainer2.Panel1.Controls.Add(this.btn_FrmMyAlbum_V1);
            this.splitContainer2.Panel1.Controls.Add(this.btn_FrmAdventureWorks);
            this.splitContainer2.Panel1.Controls.Add(this.btn_FrmOverview);
            this.splitContainer2.Panel1.Controls.Add(this.btn_FrmProducts);
            this.splitContainer2.Panel1.Controls.Add(this.btn_FrmCategoryProducts);
            this.splitContainer2.Panel1.Controls.Add(this.btn_標準練習);
            this.splitContainer2.Size = new System.Drawing.Size(1022, 500);
            this.splitContainer2.SplitterDistance = 274;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::MyHW.Properties.Resources.quiz2;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(11, 298);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Quiz - TreeView";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_FrmLogon
            // 
            this.btn_FrmLogon.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_FrmLogon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_FrmLogon.Location = new System.Drawing.Point(11, 234);
            this.btn_FrmLogon.Margin = new System.Windows.Forms.Padding(2);
            this.btn_FrmLogon.Name = "btn_FrmLogon";
            this.btn_FrmLogon.Size = new System.Drawing.Size(191, 28);
            this.btn_FrmLogon.TabIndex = 7;
            this.btn_FrmLogon.Text = "7. FrmLogon";
            this.btn_FrmLogon.UseVisualStyleBackColor = true;
            this.btn_FrmLogon.Click += new System.EventHandler(this.btn_FrmLogon_Click);
            // 
            // btn_FrmCustomers
            // 
            this.btn_FrmCustomers.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_FrmCustomers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_FrmCustomers.Location = new System.Drawing.Point(11, 202);
            this.btn_FrmCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.btn_FrmCustomers.Name = "btn_FrmCustomers";
            this.btn_FrmCustomers.Size = new System.Drawing.Size(191, 28);
            this.btn_FrmCustomers.TabIndex = 6;
            this.btn_FrmCustomers.Text = "7. FrmCustomers";
            this.btn_FrmCustomers.UseVisualStyleBackColor = true;
            this.btn_FrmCustomers.Click += new System.EventHandler(this.btn_FrmCustomers_Click);
            // 
            // btn_FrmMyAlbum_V1
            // 
            this.btn_FrmMyAlbum_V1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_FrmMyAlbum_V1.Location = new System.Drawing.Point(11, 170);
            this.btn_FrmMyAlbum_V1.Margin = new System.Windows.Forms.Padding(2);
            this.btn_FrmMyAlbum_V1.Name = "btn_FrmMyAlbum_V1";
            this.btn_FrmMyAlbum_V1.Size = new System.Drawing.Size(191, 28);
            this.btn_FrmMyAlbum_V1.TabIndex = 5;
            this.btn_FrmMyAlbum_V1.Text = "6. FrmMyAlbum_V1";
            this.btn_FrmMyAlbum_V1.UseVisualStyleBackColor = true;
            this.btn_FrmMyAlbum_V1.Click += new System.EventHandler(this.btn_FrmMyAlbum_V1_Click);
            // 
            // btn_FrmAdventureWorks
            // 
            this.btn_FrmAdventureWorks.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_FrmAdventureWorks.Location = new System.Drawing.Point(11, 138);
            this.btn_FrmAdventureWorks.Margin = new System.Windows.Forms.Padding(2);
            this.btn_FrmAdventureWorks.Name = "btn_FrmAdventureWorks";
            this.btn_FrmAdventureWorks.Size = new System.Drawing.Size(191, 28);
            this.btn_FrmAdventureWorks.TabIndex = 4;
            this.btn_FrmAdventureWorks.Text = "5. FrmAdventureWorks";
            this.btn_FrmAdventureWorks.UseVisualStyleBackColor = true;
            this.btn_FrmAdventureWorks.Click += new System.EventHandler(this.btn_FrmAdventureWorks_Click);
            // 
            // btn_FrmOverview
            // 
            this.btn_FrmOverview.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_FrmOverview.Location = new System.Drawing.Point(11, 106);
            this.btn_FrmOverview.Margin = new System.Windows.Forms.Padding(2);
            this.btn_FrmOverview.Name = "btn_FrmOverview";
            this.btn_FrmOverview.Size = new System.Drawing.Size(191, 28);
            this.btn_FrmOverview.TabIndex = 3;
            this.btn_FrmOverview.Text = "4. FrmOverview";
            this.btn_FrmOverview.UseVisualStyleBackColor = true;
            this.btn_FrmOverview.Click += new System.EventHandler(this.btn_FrmOverview_Click);
            // 
            // btn_FrmProducts
            // 
            this.btn_FrmProducts.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_FrmProducts.Location = new System.Drawing.Point(11, 74);
            this.btn_FrmProducts.Margin = new System.Windows.Forms.Padding(2);
            this.btn_FrmProducts.Name = "btn_FrmProducts";
            this.btn_FrmProducts.Size = new System.Drawing.Size(191, 28);
            this.btn_FrmProducts.TabIndex = 2;
            this.btn_FrmProducts.Text = "3. FrmProducts";
            this.btn_FrmProducts.UseVisualStyleBackColor = true;
            this.btn_FrmProducts.Click += new System.EventHandler(this.btn_FrmProducts_Click);
            // 
            // btn_FrmCategoryProducts
            // 
            this.btn_FrmCategoryProducts.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_FrmCategoryProducts.Location = new System.Drawing.Point(11, 42);
            this.btn_FrmCategoryProducts.Margin = new System.Windows.Forms.Padding(2);
            this.btn_FrmCategoryProducts.Name = "btn_FrmCategoryProducts";
            this.btn_FrmCategoryProducts.Size = new System.Drawing.Size(191, 28);
            this.btn_FrmCategoryProducts.TabIndex = 1;
            this.btn_FrmCategoryProducts.Text = "2. FrmCategoryProducts";
            this.btn_FrmCategoryProducts.UseVisualStyleBackColor = true;
            this.btn_FrmCategoryProducts.Click += new System.EventHandler(this.btn_FrmCategoryProducts_Click);
            // 
            // btn_標準練習
            // 
            this.btn_標準練習.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_標準練習.Location = new System.Drawing.Point(11, 10);
            this.btn_標準練習.Margin = new System.Windows.Forms.Padding(2);
            this.btn_標準練習.Name = "btn_標準練習";
            this.btn_標準練習.Size = new System.Drawing.Size(191, 28);
            this.btn_標準練習.TabIndex = 0;
            this.btn_標準練習.Text = "1. Frm標準練習";
            this.btn_標準練習.UseVisualStyleBackColor = true;
            this.btn_標準練習.Click += new System.EventHandler(this.btn_標準練習_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(11, 266);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 28);
            this.button2.TabIndex = 9;
            this.button2.Text = "8. FrmMyAlbum_V2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 615);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btn_FrmOverview;
        private System.Windows.Forms.Button btn_FrmProducts;
        private System.Windows.Forms.Button btn_FrmCategoryProducts;
        private System.Windows.Forms.Button btn_標準練習;
        private System.Windows.Forms.Button btn_FrmCustomers;
        private System.Windows.Forms.Button btn_FrmMyAlbum_V1;
        private System.Windows.Forms.Button btn_FrmAdventureWorks;
        private System.Windows.Forms.Button btn_FrmLogon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}