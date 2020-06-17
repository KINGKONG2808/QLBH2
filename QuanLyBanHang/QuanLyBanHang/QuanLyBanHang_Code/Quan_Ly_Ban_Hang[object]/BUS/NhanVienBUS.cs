using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_BanHang.DAL;
using System.Data;
using QL_BanHang.Object;

namespace QL_BanHang.BLL
{
    class NhanVienBLL
    {
        DataConnect data = new DataConnect();

        public DataTable ShowNhanVien()
        {
            string sql = "select * from NhanVien2";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }

        public void InsertNhanVien(NhanVienObj nv)
        {
            String gt;
            if (nv.GioiTinh.Equals("Nam"))
                gt = "True";
            else
                gt = "False";
            nv.GioiTinh = gt;
            String luong;
            if (nv.Rank.Equals("Rank A"))
                luong = "8000000";
            else
            {
                if (nv.Rank.Equals("Rank B"))
                    luong = "5000000";
                else
                    luong = "3000000";
            }
            nv.Rank = luong;
            string sql = "Insert into NhanVien values('" + nv.MaNV + "',N'" + nv.TenNV + "','" + nv.GioiTinh + "',N'" + nv.DiaChi + "','" + nv.SDT + "','" + nv.Rank + "','" + nv.TaiKhoan + "','" + nv.MatKhau + "')";
            data.ExcuteNonQuery(sql);
        }

        public void UpdateNhanVien(NhanVienObj nv)
        {
            String gt;
            if (nv.GioiTinh.Equals("Nam"))
                gt = "True";
            else
                gt = "False";
            nv.GioiTinh = gt;
            String luong;
            if (nv.Rank.Equals("Rank A"))
                luong = "8000000";
            else
            {
                if (nv.Rank.Equals("Rank B"))
                    luong = "5000000";
                else
                    luong = "3000000";
            }
            nv.Rank = luong;
            string sql = "Update NhanVien set TenNV=N'" + nv.TenNV + "',GioiTinh='" + nv.GioiTinh + "',DiaChi=N'" + nv.DiaChi + "',SDT='" + nv.SDT + "',RankNV='" + nv.Rank + "',TaiKhoan='" + nv.TaiKhoan + "',MatKhau='" + nv.MatKhau + "' where MaNV='" + nv.MaNV + "'";
            data.ExcuteNonQuery(sql);
        }

        public void DeleteNhanVien(String manv)
        {
            string sql = "Delete NhanVien where MaNV = '" + manv + "'";
            data.ExcuteNonQuery(sql);
        }
    }
}
