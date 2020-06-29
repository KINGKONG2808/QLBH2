using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanHang.DTO
{
    class AdminDTO
    {
        private string taiKhoan;
        private string matKhau;

        public string TaiKhoan
        {
            get { return taiKhoan; }
            set { taiKhoan = value; }
        }

        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }

        public AdminDTO() { }
        public AdminDTO(string taikhoan, string matkhau)
        {
            TaiKhoan = taikhoan;
            MatKhau = matkhau;
        }
    }
}
