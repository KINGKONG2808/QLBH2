using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_BanHang.DAL;
using System.Data;

namespace QL_BanHang.BUS
{
    class LuongVaThuongBUS
    {
        DataConnect data = new DataConnect();

        public DataTable ShowTiepThi()
        {
            string sql = "select KhachHang2.MaNV , NhanVien2.TenNV , COUNT(*)as'TiepThi' from KhachHang2 inner join NhanVien2 on KhachHang2.MaNV = NhanVien2.MaNV GROUP BY KhachHang2.MaNV , NhanVien2.TenNV";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }

        public DataTable ShowLapHD()
        {
            string sql = "select NhanVien2.MaNV ,NhanVien2.TenNV , COUNT(*)as'So luot lap hoa don' from ChiTietHoaDon2 inner join HoaDon2 on ChiTietHoaDon2.MaHD = HoaDon2.MaHD inner join NhanVien2 on HoaDon2.MaNV = NhanVien2.MaNV group by NhanVien2.MaNV ,NhanVien2.TenNV";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }

        public DataTable ShowBangLuong()
        {
            string sql = "select * from BangLuong2";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }

        public DataTable ShowTongLuong()
        {
            string sql = "select BangLuong2.[Luong cung] as 'Tong luong' from BangLuong2";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
    }
}
