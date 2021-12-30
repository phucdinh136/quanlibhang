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
    public partial class frmDangNhap : Form
    {
        //string tentaikhoan = " Admin";
        // string matkhau = "admin";

        List<TaiKhoan> listTaiKhoan = DanhSachTaiKhoan.Instance.ListTaiKhoan;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (KiemTraDangNhap(txbTaiKhoan.Text, txbMatKhau.Text))
            {
                frmMain f = new frmMain();
                f.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai Ten Tai Khoan Hoac Mat Khau", "Loi");
                txbTaiKhoan.Focus();
            }

        }
        bool KiemTraDangNhap (string tentailkhoan, string matkhau)
        {
            for (int i = 0;i < listTaiKhoan.Count;i++)
            {
                if (tentailkhoan == listTaiKhoan[i].TenTaiKhoan && matkhau == listTaiKhoan[i].MatKhau)
                    return true;
            }
            //if (tentaikhoan == this.tentaikhoan && matkhau == this.matkhau)
            //{ return true; }
            return false;
        }
    }
}
