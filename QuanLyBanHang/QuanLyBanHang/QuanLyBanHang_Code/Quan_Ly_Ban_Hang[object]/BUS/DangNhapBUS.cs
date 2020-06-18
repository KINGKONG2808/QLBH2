using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_BanHang.DAL;
using System.Data;
using System.Data.SqlClient;
using QL_BanHang.DTO;

namespace QL_BanHang.BUS
{
    class DangNhapBUS
    {
        DataConnect da = new DataConnect();

        public bool getTKAdmin(AdminDTO ad)
        {
            string sql = "select * from Admin2 where TaiKhoan = '" + ad.TaiKhoan + "' and MatKhau = '" + ad.MatKhau + "' ";
            if (da.GetTaiKhoan(sql) == true)
                return true;
            return false;
        }

        public bool getTKNhanVien(NhanVienDTO nv)
        {
            string sql = "select * from NhanVien2 where TaiKhoan = '" + nv.TaiKhoan + "' and MatKhau = '" + nv.MatKhau + "' ";
            if (da.GetTaiKhoan(sql) == true)
                return true;
            return false;
        }

    }
}
