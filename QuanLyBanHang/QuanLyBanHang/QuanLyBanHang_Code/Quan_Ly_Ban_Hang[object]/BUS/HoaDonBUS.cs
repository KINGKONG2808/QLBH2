using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_BanHang.DAL;
using QL_BanHang.Object;

namespace QL_BanHang.BLL
{
    class HoaDonBLL
    {
        DataConnect data = new DataConnect();

        //Lấy thông tin
        public DataTable ShowHoaDon()
        {
            string sql = "select * from HoaDon";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }

        public void InsertHoaDon(HoaDonObj hd)
        {
            string sql = "Insert into HoaDon values('" + hd.MaHD + "','" + hd.MaKH + "','" + hd.MaNV + "','" + hd.NgayLap + "')";
            data.ExcuteNonQuery(sql);
        }

        public void UpdateHoaDon(HoaDonObj hd)
        {
            string sql = "Update HoaDon set MaKH='" + hd.MaKH + "',MaNV='" + hd.MaNV + "',NgayLap='" + hd.NgayLap + "' where MaHD='" + hd.MaHD + "'";
            data.ExcuteNonQuery(sql);
        }

        public void DeleteHoaDon(string mahd)
        {
            string sql = "Delete HoaDon where MaHD = '" + mahd + "'";
            data.ExcuteNonQuery(sql);
        }
    }
}
