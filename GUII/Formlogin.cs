using QLBH_Chauquoctoan.BALL;
using QLBH_Chauquoctoan.MODELL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH_Chauquoctoan.GUII
{
    public partial class Formlogin : Form
    {
        TaiKhoanBAL cusBAL = new TaiKhoanBAL();

        public Formlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<TaiKhoanBEL> lstCus = cusBAL.ReadTaiKhoan();
            bool loginSuccess = false;

            foreach (TaiKhoanBEL cus in lstCus)
            {
                if (cus.Username == tbId.Text && cus.Password == tbName.Text)
                {
                    loginSuccess = true;
                    break;
                }
            }

            if (loginSuccess)
            {
                this.Hide();
                var form2 = new FormMenu();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
                MessageBox.Show("Đăng nhập thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Formlogin_Load(object sender, EventArgs e)
        {
            // Đặt thuộc tính PasswordChar của TextBox thành '*' để ẩn mật khẩu
            tbName.PasswordChar = '*';
        }
    }
}
