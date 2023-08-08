using QLBH_Chauquoctoan.BALL;
using QLBH_Chauquoctoan.MODELL;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QLBH_Chauquoctoan.GUII
{
    public partial class gd : Form
    {
        string nameimg;
     

        PictureBox pb = new PictureBox();
        SanPhamBAL cusBAL1 = new SanPhamBAL();

        public gd()
        {
            InitializeComponent();
            DataGridViewImageColumn colImage = new DataGridViewImageColumn();

            dgvsp.CellClick += dgvsp_CellClick;
        }
        string img;
        private void ResetInputFields()
        {
            tbMa.Text = string.Empty;
            tbName.Text = string.Empty;
            txtGia.Text = string.Empty;
            tbSL.Text = string.Empty;
            nameimg = string.Empty;
            //pictureBox.Image = null;

        }
        private void CheckDataAvailability()
        {
            bool dataAvailable = dgvsp.Rows.Count > 0;

            // Disable or hide the buttons based on data availability
            btNew.Enabled = dataAvailable;
            btDelete.Enabled = dataAvailable;
            btEdit.Enabled = dataAvailable;
        }
        private void dgvsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dgvsp.Rows[e.RowIndex];

                // Check if the clicked cell is empty (null or empty string)
                if (selectedRow.Cells[e.ColumnIndex].Value == null || string.IsNullOrEmpty(selectedRow.Cells[e.ColumnIndex].Value.ToString()))
                {
                    // The cell is empty, so reset the input fields
                    ResetInputFields();
                }
                else
                {
                    // Extract data from the selected row
                    int productId = Convert.ToInt32(selectedRow.Cells["colProductID"].Value);
                    string name = selectedRow.Cells["colName"].Value.ToString();
                    int price = Convert.ToInt32(selectedRow.Cells["colPrice"].Value);
                    int quantityInStock = Convert.ToInt32(selectedRow.Cells["colQuantityInStock"].Value);
                    string image = selectedRow.Cells["colImage"].Value.ToString();

                    // Display the data in the input fields
                    tbMa.Text = productId.ToString();
                    tbName.Text = name;
                    txtGia.Text = price.ToString();
                    tbSL.Text = quantityInStock.ToString();
                    if (image != null)
                    {
                        img = image;
                    }

                    if (File.Exists(@"D:\chauquoctoan_2121110360\img\" + img))
                    {
                        // Hiển thị hình ảnh trong PictureBox
                        pictureBox.Image = new Bitmap(@"D:\chauquoctoan_2121110360\img\" + img);
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    else
                    {
                        pictureBox.Image = null;
                    }
                }
            }
            else
            {
                // Reset input fields when no valid row is clicked
                ResetInputFields();
            }
        }






        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btRead_Click(object sender, EventArgs e)
        {
            List<SanPhamBEL> lstCus = cusBAL1.ReadSanPham();
            foreach (SanPhamBEL cus in lstCus)
            {
                dgvsp.Rows.Add(cus.product_id, cus.name, cus.price, cus.quantity_in_stock, cus.Image);
                
            }
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            // Check if all required fields are filled
            if (string.IsNullOrEmpty(tbMa.Text) || string.IsNullOrEmpty(tbName.Text) || string.IsNullOrEmpty(txtGia.Text) || string.IsNullOrEmpty(tbSL.Text) || string.IsNullOrEmpty(nameimg))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if any required field is missing
            }

            // If all required fields are filled, proceed with adding the product
            SanPhamBEL cus = new SanPhamBEL();
            cus.product_id = int.Parse(tbMa.Text);
            cus.name = tbName.Text;
            cus.price = int.Parse(txtGia.Text);
            cus.quantity_in_stock = int.Parse(tbSL.Text);
            cus.Image = nameimg;
            cusBAL1.AddSanPham(cus);
            dgvsp.Rows.Add(cus.product_id, cus.name, cus.price, cus.quantity_in_stock, cus.Image);
            MessageBox.Show("Sản phẩm đã được thêm thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset input fields to their default values
            ResetInputFields();
        }


        private void btDelete_Click(object sender, EventArgs e)
        {

            if (dgvsp.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xóa!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SanPhamBEL cus = new SanPhamBEL();
            cus.product_id = int.Parse(tbMa.Text);
            cusBAL1.DeleteSanPham(cus);
            int idx = dgvsp.CurrentCell.RowIndex;
            dgvsp.Rows.RemoveAt(idx);
            MessageBox.Show("Sản phẩm đã được xóa thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }







        private void btEdit_Click(object sender, EventArgs e)
        {
            // Create a new SanPhamBEL object with the updated data
            SanPhamBEL cus = new SanPhamBEL();
            cus.product_id = int.Parse(tbMa.Text);
            cus.name = tbName.Text;
            cus.price = int.Parse(txtGia.Text);
            cus.quantity_in_stock = int.Parse(tbSL.Text);
            cus.Image = nameimg;

            // Call the EditSanPham method to update the database
            cusBAL1.EditSanPham(cus);

            // Get the index of the currently selected row in the DataGridView
            int rowIndex = dgvsp.CurrentCell.RowIndex;

            // Update the row in the DataGridView with the edited data
            dgvsp.Rows[rowIndex].Cells["colProductID"].Value = cus.product_id;
            dgvsp.Rows[rowIndex].Cells["colName"].Value = cus.name;
            dgvsp.Rows[rowIndex].Cells["colPrice"].Value = cus.price;
            dgvsp.Rows[rowIndex].Cells["colQuantityInStock"].Value = cus.quantity_in_stock;
            dgvsp.Rows[rowIndex].Cells["colImage"].Value = nameimg;
            MessageBox.Show("Sản Phâm đã được cập nhật!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset input fields to their default values
            ResetInputFields();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp|All files (*.*)|*.*";
            openFileDialog.Multiselect = false; // Chỉ cho phép chọn một tệp tin

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn của hình ảnh đã chọn
                string imagePath = openFileDialog.FileName;
                string selectedImagePath = openFileDialog.FileName;

                // Lưu ảnh vào thư mục chỉ định
                string targetDirectory = @"D:\chauquoctoan_2121110360\img\"; // Thay đổi đường dẫn tới thư mục mong muốn
                string targetFileName = Path.Combine(targetDirectory, Path.GetFileName(selectedImagePath));

                nameimg = Path.GetFileName(selectedImagePath);


                File.Copy(selectedImagePath, targetFileName, true);
                // Load ảnh từ đường dẫn và thêm vào DataGridViewImageColumn

                pictureBox.Image = new Bitmap(openFileDialog.FileName);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Image = new Bitmap(openFileDialog.FileName);
            }

        }

        private void btExit_Click(object sender, EventArgs e)
        {

        }

        private void dgvsp_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            // Check if a valid row (not a header row) is clicked
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dgvsp.Rows[e.RowIndex];

                // Extract data from the selected row
                int productId = Convert.ToInt32(selectedRow.Cells["colProductID"].Value);
                string name = selectedRow.Cells["colName"].Value.ToString();
                int price = Convert.ToInt32(selectedRow.Cells["colPrice"].Value);
                int quantityInStock = Convert.ToInt32(selectedRow.Cells["colQuantityInStock"].Value);
                string Image = selectedRow.Cells["colImage"].Value.ToString();

                // Display the data in the input fields
                tbMa.Text = productId.ToString();
                tbName.Text = name;
                txtGia.Text = price.ToString();
                tbSL.Text = quantityInStock.ToString();
                if (Image != null)
                {
                    img = selectedRow.Cells["colImage"].Value.ToString();
                }

                if (File.Exists(@"D:\chauquoctoan_2121110360\img\" + img))
                {

                    // Hiển thị hình ảnh trong PictureBox
                    pictureBox.Image = new Bitmap(@"D:\chauquoctoan_2121110360\img\" + img);
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    pictureBox.Image = null;
                }



            }
        }

        private void cbArea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

