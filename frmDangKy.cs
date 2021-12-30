using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Vào Họ Tên ");
                txtHoTen.Focus();// dua con tro chuot ve lai

            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Vào Email ");
                txtEmail.Focus();
            }
            else if (txtSDT.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Vào SDT ");
                txtSDT.Focus();
            }
            else if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Vào Mat Khau ");
                txtMatKhau.Focus();
            }
            else if (txtXacNhanMK.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Vào Xac Nhan Mat Khau ");
                txtXacNhanMK.Focus();
            }
            else if (txtMatKhau.Text != txtXacNhanMK.Text)
            {
                MessageBox.Show("Mat Khau va Xac Nhan Mat Khau Phai Giong Nhau ");
                txtXacNhanMK.Focus();
                txtXacNhanMK.SelectAll();
            }
            //KtraMK 
            else
            {
            NguoiDung nd = new NguoiDung(txtHoTen.Text, txtEmail.Text, txtSDT.Text, txtTaiKhoan.Text, txtMatKhau.Text);
                if (nd.KiemTraDinhDangMatKhau()==true)
                {
                    MessageBox.Show("Đăng Ký Thành Công " + "\n\nTên: " + txtHoTen.Text +"\nEmail: "+ txtEmail.Text + "\nSDT: " + txtSDT.Text + "\nTên tài khoản: " + txtTaiKhoan.Text);
                }
                else
                {
                    MessageBox.Show("Mật Khẩu Sai Định Dạng");
                    txtMatKhau.Focus();
                    txtMatKhau.SelectAll();
                }
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)///sdt chỉ cho phép nhập chữ 
        {
            if (! Char.IsDigit(e.KeyChar) && (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
