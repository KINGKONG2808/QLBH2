using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_BanHang.Object;
using QL_BanHang.DAL;
using System.Data;
using System.Data.SqlClient;

namespace QL_BanHang.BLL
{
    class DangNhapBLL
    {
        DataConnect da = new DataConnect();

        public bool getTKAdmin(AdminObj ad)
        {
            String sql = "select * from Admin where TaiKhoan = '" + ad.TaiKhoan + "' and MatKhau = '" + ad.MatKhau + "' ";
            if (da.GetTaiKhoan(sql) == true)
                return true;
            return false;
        }

        public bool getTKNhanVien(NhanVienObj nv)
        {
            String sql = "select * from NhanVien where TaiKhoan = '" + nv.TaiKhoan + "' and MatKhau = '" + nv.MatKhau + "' ";
            if (da.GetTaiKhoan(sql) == true)
                return true;
            return false;
        }

    }
}
