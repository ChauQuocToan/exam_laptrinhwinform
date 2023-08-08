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
            this.tbSL = new System.Windows.Forms.TextBox();
            this.btFile = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMa
            // 
            this.tbMa.Location = new System.Drawing.Point(117, 243);
            this.tbMa.Name = "tbMa";
            this.tbMa.Size = new System.Drawing.Size(232, 22);
            this.tbMa.TabIndex = 5;
            // 
            // lbma
            // 
            this.lbma.AutoSize = true;
            this.lbma.Location = new System.Drawing.Point(34, 243);
            this.lbma.Name = "lbma";
            this.lbma.Size = new System.Drawing.Size(27, 17);
            this.lbma.TabIndex = 8;
            this.lbma.Text = "Mã";
            // 
            // lbten
            // 
            this.lbten.AutoSize = true;
            this.lbten.Location = new System.Drawing.Point(34, 294);
            this.lbten.Name = "lbten";
            this.lbten.Size = new System.Drawing.Size(33, 17);
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
            this.lbPrice.Size = new System.Drawing.Size(30, 17);
            this.lbPrice.TabIndex = 15;
            this.lbPrice.Text = "Giá";
            // 
            // lbquantity_in_stock
            // 
            this.lbquantity_in_stock.AutoSize = true;
            this.lbquantity_in_stock.Location = new System.Drawing.Point(31, 397);
            this.lbquantity_in_stock.Name = "lbquantity_in_stock";
            this.lbquantity_in_stock.Size = new System.Drawing.Size(64, 17);
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
            this.btRead.Location = new System.Drawing.Point(279, 481);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(120, 37);
            this.btRead.TabIndex = 19;
            this.btRead.Text = "đọc ";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(405, 481);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(108, 37);
            this.btNew.TabIndex = 20;
            this.btNew.Text = "Thêm";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(519, 481);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(108, 37);
            this.btDelete.TabIndex = 21;
            this.btDelete.Text = "Xoá";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(642, 481);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(108, 37);
            this.btEdit.TabIndex = 22;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(768, 481);
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
            this.colImage});
            this.dgvsp.Location = new System.Drawing.Point(34, 12);
            this.dgvsp.Name = "dgvsp";
            this.dgvsp.RowTemplate.Height = 24;
            this.dgvsp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvsp.Size = new System.Drawing.Size(822, 207);
            this.dgvsp.TabIndex = 24;
            this.dgvsp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsp_CellContentClick_1);
            // 
            // colProductID
            // 
            this.colProductID.HeaderText = "Mã";
            this.colProductID.Name = "colProductID";
            // 
            // colName
            // 
            this.colName.HeaderText = "Tên";
            this.colName.Name = "colName";
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Giá";
            this.colPrice.Name = "colPrice";
            // 
            // colQuantityInStock
            // 
            this.colQuantityInStock.HeaderText = "Số lượng";
            this.colQuantityInStock.Name = "colQuantityInStock";
            // 
            // colImage
            // 
            this.colImage.HeaderText = "Image";
            this.colImage.Name = "colImage";
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
            this.btFile.Location = new System.Drawing.Point(802, 408);
            this.btFile.Name = "btFile";
            this.btFile.Size = new System.Drawing.Size(88, 33);
            this.btFile.TabIndex = 27;
            this.btFile.Text = "chọn ảnh";
            this.btFile.UseVisualStyleBackColor = true;
            this.btFile.Click += new System.EventHandler(this.btFile_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(576, 282);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(220, 159);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 28;
            this.pictureBox.TabStop = false;
            // 
            // cbArea
            // 
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Location = new System.Drawing.Point(117, 443);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(121, 24);
            this.cbArea.TabIndex = 29;
            this.cbArea.SelectedIndexChanged += new System.EventHandler(this.cbArea_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Danh Mục ";
            // 
            // gd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 550);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbArea);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvsp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantityInStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImage;
        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.Label label1;
    }
}