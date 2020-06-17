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
    class LuongVaThuongBLL
    {
        DataConnect data = new DataConnect();

        public DataTable ShowTiepThi()
        {
            string sql = "select KhachHang.MaNV , NhanVien.TenNV , COUNT(*)as'TiepThi' from KhachHang inner join NhanVien on KhachHang.MaNV = NhanVien.MaNV GROUP BY KhachHang.MaNV , NhanVien.TenNV";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }

        public DataTable ShowLapHD()
        {
            string sql = "select NhanVien.MaNV ,NhanVien.TenNV , COUNT(*)as'So luot lap hoa don' from ChiTietHoaDon inner join HoaDon on ChiTietHoaDon.MaHD = HoaDon.MaHD inner join NhanVien on HoaDon.MaNV = NhanVien.MaNV group by NhanVien.MaNV ,NhanVien.TenNV";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }

        public DataTable ShowBangLuong()
        {
            string sql = "select * from BangLuong";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }

        public DataTable ShowTongLuong()
        {
            string sql = "select (BangLuong.[Luong cung]+BangLuong.[Hoa hong])as 'Tong luong' from BangLuong";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
    }
}
