using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang
{
    internal class NguoiDung
    {
        private string hoten, email, sodienthoai, taikhoan, matkhau;
        public NguoiDung()
        {
            hoten = email = sodienthoai = taikhoan = matkhau = "";

        }
        public NguoiDung (string ten, string mail, string dienthoai, string tk, string mk )
        {
            hoten = ten;
            email = mail;
            sodienthoai   = dienthoai;
            taikhoan  = tk;
            matkhau = mk;
        }
        public bool KiemTraDinhDangMatKhau()// tối thiểu 7 kĩ tụ có cả chũ và số 
        {
         
            if (matkhau.Length <7 )
            {
                return false;
            }
            
                bool KiemTraChu = false;
                bool KiemTraSo = false;
                for (int i = 0; i < matkhau.Length; i++)
                {
                    if (KiemTraChu == true && KiemTraSo == true)
                    {
                        break;
                    }
                    if ((matkhau[i] >= 'A' && matkhau[i] <= 'Z') || (matkhau[i] >= 'a' && matkhau[i] <= 'z'))
                    {
                        KiemTraChu = true;

                    }
                    if (matkhau[i] >= '0' && matkhau[i] <= '9')
                    {
                        KiemTraSo = true;
                    }
                }
                if (KiemTraSo == false || KiemTraChu == false)
                {
                    return false ;//Ko  hop le
                }
 
            return true ;//  hop le 
        }
    }
}
