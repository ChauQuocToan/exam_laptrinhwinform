namespace QLBH_Chauquoctoan.GUII
{
    partial class gd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gd));
            this.tbMa = new System.Windows.Forms.TextBox();
            this.lbma = new System.Windows.Forms.Label();
            this.lbten = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbquantity_in_stock = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.btRead = new System.Windows.Forms.Button();
            this.btNew = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.dgvsp = new System.Windows.Forms.DataGridView();
            this.colProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantityInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColKC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbSL = new System.Windows.Forms.TextBox();
            this.btFile = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.cbKC = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbTK = new System.Windows.Forms.Label();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMa
            // 
            this.tbMa.Location = new System.Drawing.Point(117, 243);
            this.tbMa.Name = "tbMa";
            this.tbMa.Size = new System.Drawing.Size(232, 22);
            this.tbMa.TabIndex = 5;
            this.tbMa.TextChanged += new System.EventHandler(this.tbMa_TextChanged);
            // 
            // lbma
            // 
            this.lbma.AutoSize = true;
            this.lbma.Location = new System.Drawing.Point(34, 243);
            this.lbma.Name = "lbma";
            this.lbma.Size = new System.Drawing.Size(26, 16);
            this.lbma.TabIndex = 8;
            this.lbma.Text = "Mã";
            // 
            // lbten
            // 
            this.lbten.AutoSize = true;
            this.lbten.Location = new System.Drawing.Point(34, 294);
            this.lbten.Name = "lbten";
            this.lbten.Size = new System.Drawing.Size(31, 16);
            this.lbten.TabIndex = 9;
            this.lbten.Text = "Tên";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(117, 294);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(232, 22);
            this.tbName.TabIndex = 10;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(34, 347);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(28, 16);
            this.lbPrice.TabIndex = 15;
            this.lbPrice.Text = "Giá";
            // 
            // lbquantity_in_stock
            // 
            this.lbquantity_in_stock.AutoSize = true;
            this.lbquantity_in_stock.Location = new System.Drawing.Point(31, 397);
            this.lbquantity_in_stock.Name = "lbquantity_in_stock";
            this.lbquantity_in_stock.Size = new System.Drawing.Size(60, 16);
            this.lbquantity_in_stock.TabIndex = 16;
            this.lbquantity_in_stock.Text = "Số lượng";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(117, 347);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(232, 22);
            this.txtGia.TabIndex = 17;
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(64, 552);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(120, 37);
            this.btRead.TabIndex = 19;
            this.btRead.Text = "đọc ";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(254, 552);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(108, 37);
            this.btNew.TabIndex = 20;
            this.btNew.Text = "Thêm";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(400, 552);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(108, 37);
            this.btDelete.TabIndex = 21;
            this.btDelete.Text = "Xoá";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(578, 557);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(108, 37);
            this.btEdit.TabIndex = 22;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(710, 557);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(108, 37);
            this.btExit.TabIndex = 23;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // dgvsp
            // 
            this.dgvsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductID,
            this.colName,
            this.colPrice,
            this.colQuantityInStock,
            this.colImage,
            this.ColKC});
            this.dgvsp.Location = new System.Drawing.Point(12, 3);
            this.dgvsp.Name = "dgvsp";
            this.dgvsp.RowHeadersWidth = 51;
            this.dgvsp.RowTemplate.Height = 24;
            this.dgvsp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvsp.Size = new System.Drawing.Size(880, 206);
            this.dgvsp.TabIndex = 24;
            this.dgvsp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsp_CellContentClick_1);
            // 
            // colProductID
            // 
            this.colProductID.HeaderText = "Mã";
            this.colProductID.MinimumWidth = 6;
            this.colProductID.Name = "colProductID";
            this.colProductID.Width = 125;
            // 
            // colName
            // 
            this.colName.HeaderText = "Tên";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.Width = 125;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Giá";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.Width = 125;
            // 
            // colQuantityInStock
            // 
            this.colQuantityInStock.HeaderText = "Số lượng";
            this.colQuantityInStock.MinimumWidth = 6;
            this.colQuantityInStock.Name = "colQuantityInStock";
            this.colQuantityInStock.Width = 125;
            // 
            // colImage
            // 
            this.colImage.HeaderText = "Image";
            this.colImage.MinimumWidth = 6;
            this.colImage.Name = "colImage";
            this.colImage.Width = 125;
            // 
            // ColKC
            // 
            this.ColKC.HeaderText = "Kích Cỡ";
            this.ColKC.MinimumWidth = 6;
            this.ColKC.Name = "ColKC";
            this.ColKC.Width = 125;
            // 
            // tbSL
            // 
            this.tbSL.Location = new System.Drawing.Point(117, 392);
            this.tbSL.Name = "tbSL";
            this.tbSL.Size = new System.Drawing.Size(232, 22);
            this.tbSL.TabIndex = 25;
            // 
            // btFile
            // 
            this.btFile.Location = new System.Drawing.Point(822, 294);
            this.btFile.Name = "btFile";
            this.btFile.Size = new System.Drawing.Size(88, 33);
            this.btFile.TabIndex = 27;
            this.btFile.Text = "chọn ảnh";
            this.btFile.UseVisualStyleBackColor = true;
            this.btFile.Click += new System.EventHandler(this.btFile_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(478, 229);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(220, 159);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 28;
            this.pictureBox.TabStop = false;
            // 
            // cbKC
            // 
            this.cbKC.FormattingEnabled = true;
            this.cbKC.Items.AddRange(new object[] {
            "X",
            "S",
            "M",
            "Xl"});
            this.cbKC.Location = new System.Drawing.Point(117, 443);
            this.cbKC.Name = "cbKC";
            this.cbKC.Size = new System.Drawing.Size(121, 24);
            this.cbKC.TabIndex = 29;
            this.cbKC.SelectedIndexChanged += new System.EventHandler(this.cbArea_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Kích Cỡ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 32);
            this.button1.TabIndex = 35;
            this.button1.Text = "Xuất Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbTK
            // 
            this.lbTK.AutoSize = true;
            this.lbTK.Location = new System.Drawing.Point(12, 500);
            this.lbTK.Name = "lbTK";
            this.lbTK.Size = new System.Drawing.Size(127, 16);
            this.lbTK.TabIndex = 36;
            this.lbTK.Text = "Tìm Kiếm Sản phẩm";
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(157, 494);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(463, 22);
            this.txtTK.TabIndex = 37;
            this.txtTK.TextChanged += new System.EventHandler(this.txtTK_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(710, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 32);
            this.button2.TabIndex = 38;
            this.button2.Text = "Xuất PDF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(4, 636);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(888, 150);
            this.dataGridView1.TabIndex = 39;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Giá";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Số lượng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Image";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Kích Cỡ";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(874, 557);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 37);
            this.button3.TabIndex = 40;
            this.button3.Text = "Tổng Kết Đơn Hàng";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // gd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1080, 803);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.lbTK);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbKC);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btFile);
            this.Controls.Add(this.tbSL);
            this.Controls.Add(this.dgvsp);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.btRead);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.lbquantity_in_stock);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbten);
            this.Controls.Add(this.lbma);
            this.Controls.Add(this.tbMa);
            this.Name = "gd";
            this.Text = "gd";
            this.Load += new System.EventHandler(this.gd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dgvsp_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
           
        }

        #endregion

        private System.Windows.Forms.TextBox tbMa;
        private System.Windows.Forms.Label lbma;
        private System.Windows.Forms.Label lbten;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbquantity_in_stock;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.DataGridView dgvsp;
        private System.Windows.Forms.TextBox tbSL;
        private System.Windows.Forms.Button btFile;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox cbKC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantityInStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColKC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbTK;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button button3;
    }
}