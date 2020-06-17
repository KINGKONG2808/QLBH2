using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanHang.Object
{
    class AdminObj
    {
        private String taiKhoan;
        private String matKhau;

        public String TaiKhoan
        {
            get { return taiKhoan; }
            set { taiKhoan = value; }
        }

        public String MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }

        public AdminObj() { }
        public AdminObj(String taikhoan,String matkhau)
        {
            this.TaiKhoan = taikhoan;
            this.MatKhau = matkhau;
        }
    }
}
