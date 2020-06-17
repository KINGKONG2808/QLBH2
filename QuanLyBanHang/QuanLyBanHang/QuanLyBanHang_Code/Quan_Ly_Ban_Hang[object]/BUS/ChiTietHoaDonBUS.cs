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
    class ChiTietHoaDonBLL
    {
        
        DataConnect data = new DataConnect();

        public DataTable ShowChiTietHD()
        {
            string sql = "select * from ChiTietHoaDon";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }

        public void InsertChiTietHD(ChiTietHoaDonObj ct)
        {
            string sql = "Insert into ChiTietHoaDon values('" + ct.MaHD + "','" + ct.MaHH + "','" + ct.DonGia + "','" + ct.SoLuong + "')";
            data.ExcuteNonQuery(sql);
        }

        public void UpdateChiTietHD(ChiTietHoaDonObj ct)
        {
            string sql = "Update ChiTietHoaDon set MaHH='" + ct.MaHH + "',DonGia='" + ct.DonGia + "',SoLuong='" + ct.SoLuong + "' where MaHD='" + ct.MaHD + "'";
            data.ExcuteNonQuery(sql);
        }

        public void DeleteChiTietHD(string mahd)
        {
            string sql = "Delete ChiTietHoaDon where MaHD = '" + mahd + "'";
            data.ExcuteNonQuery(sql);
        }

        public int SoLuongNhap()
        {
            int x;
            string sql = "select SoLuong From HangHoa where MaHH = '" +QL_HoaDon.fmHD.cboMaHH.Text + "'";
            x = data.ExecuteScalar(sql);
            return x;
        }

        public int GiaNhap()
        {
            int x;
            string sql = "select DonGia From HangHoa where MaHH = '" +QL_HoaDon.fmHD.cboMaHH.Text + "'";
            x = data.ExecuteScalar(sql);
            return x;
        }
    }
}
