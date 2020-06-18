using QL_BanHang.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_BanHang.DTO;

namespace QL_BanHang.BUS
{
    class ChiTietHoaDonBUS
    {

        DataConnect data = new DataConnect();

        public DataTable ShowChiTietHD()
        {
            string sql = "select * from ChiTietHoaDon2";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }

        public void InsertChiTietHD(ChiTietHoaDonDTO ct)
        {
            string sql = "Insert into ChiTietHoaDon2 values('" + ct.MaHD + "','" + ct.MaHH + "','" + ct.DonGia + "','" + ct.SoLuong + "')";
            data.ExcuteNonQuery(sql);
        }

        public void UpdateChiTietHD(ChiTietHoaDonDTO ct)
        {
            string sql = "Update ChiTietHoaDon2 set MaHH='" + ct.MaHH + "',DonGia='" + ct.DonGia + "',SoLuong='" + ct.SoLuong + "' where MaHD='" + ct.MaHD + "'";
            data.ExcuteNonQuery(sql);
        }

        public void DeleteChiTietHD(string mahd)
        {
            string sql = "Delete ChiTietHoaDon2 where MaHD = '" + mahd + "'";
            data.ExcuteNonQuery(sql);
        }

        public int SoLuongNhap()
        {
            int x;
            string sql = "select SoLuong From Hang2 where MaHH = '" + QL_HoaDon.fmHD.cboMaHH.Text + "'";
            x = data.ExecuteScalar(sql);
            return x;
        }

        public int GiaNhap()
        {
            int x;
            string sql = "select DonGia From Hang2 where MaHH = '" + QL_HoaDon.fmHD.cboMaHH.Text + "'";
            x = data.ExecuteScalar(sql);
            return x;
        }
    }
}
