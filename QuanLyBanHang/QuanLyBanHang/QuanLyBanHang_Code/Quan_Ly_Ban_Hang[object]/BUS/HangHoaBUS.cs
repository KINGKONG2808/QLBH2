using QL_BanHang.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_BanHang.Object;

namespace QL_BanHang.BLL
{
    class HangHoaBLL
    {
        DataConnect data = new DataConnect();

        public DataTable ShowHangHoa()
        {
            string sql = "select * from Hang2";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }

        public void InsertHangHoa(HangHoaObj hh)
        {
            string sql = "Insert into Hang2 values('" + hh.MaHH + "',N'" + hh.TenHH + "','" + hh.MaNCC + "','" + hh.DonGia + "','" + hh.SoLuong + "','" + hh.HoaHong + "')";
            data.ExcuteNonQuery(sql);
        }

        public void UpdateHangHoa(HangHoaObj hh)
        {
            string sql = "Update Hang2 set TenHang=N'" + hh.TenHH + "',MaNCC='" + hh.MaNCC + "',DonGia='" + hh.DonGia + "',SoLuong='" + hh.SoLuong + "',HoaHong='" + hh.HoaHong + "' where MaHH='" + hh.MaHH + "'";
            data.ExcuteNonQuery(sql);
        }

        public void DeleteHangHoa(string mahh)
        {
            string sql = "Delete Hang2 where MaHH = '" + mahh + "'";
            data.ExcuteNonQuery(sql);
        }
    }
}
