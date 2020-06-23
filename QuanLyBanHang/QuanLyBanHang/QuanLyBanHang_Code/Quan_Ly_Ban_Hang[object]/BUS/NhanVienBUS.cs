using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_BanHang.DAL;
using System.Data;
using QL_BanHang.DTO;

namespace QL_BanHang.BUS
{
    class NhanVienBUS
    {
        DataConnect data = new DataConnect();

        public DataTable ShowNhanVien()
        {
            string sql = "select * from NhanVien2";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }

        public void InsertNhanVien(NhanVienDTO nv)
        {
            string gt;
            if (nv.GioiTinh.Equals("Nam"))
                gt = "True";
            else
                gt = "False";
            nv.GioiTinh = gt;
            string sql = "Insert into NhanVien2 values(N'" + nv.MaNV + "', N'" + nv.TenNV + "', '" + nv.GioiTinh + "', N'" + nv.DiaChi + "' , N'" + nv.Sdt + "', N'" + nv.MaTrinhDo + "', '" + nv.TaiKhoan + "', '" + nv.MatKhau + "')";
            data.ExcuteNonQuery(sql);
        }

        public void UpdateNhanVien(NhanVienDTO nv)
        {
            string gt;
            if (nv.GioiTinh.Equals("Nam"))
                gt = "True";
            else
                gt = "False";
            nv.GioiTinh = gt;
            string sql = "Update NhanVien2 set TenNV = N'" + nv.TenNV + "', GioiTinh = N'" + nv.GioiTinh + "', DiaChi = N'" + nv.DiaChi + "', SDT = N'" + nv.Sdt + "', MaTrinhDo = N'" + nv.MaTrinhDo + "', TaiKhoan = '" + nv.TaiKhoan + "', MatKhau = '" + nv.MatKhau + "' where MaNV='" + nv.MaNV + "'";
            data.ExcuteNonQuery(sql);
        }

        public void DeleteNhanVien(string manv)
        {
            string sql = "Delete from NhanVien2 where MaNV = '" + manv + "'";
            data.ExcuteNonQuery(sql);
        }

        public DataTable ShowNhanVientk(string tk)
        {
            string sql = "select * from NhanVien2 where MaNV like '%" + tk + "%'";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
    }
}
