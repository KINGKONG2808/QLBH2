using QL_BanHang.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_BanHang.DTO;
using System.Data.SqlClient;

namespace QL_BanHang.BUS
{
    class ChiTietHoaDonBUS
    {

        DataConnect data = new DataConnect();

        public DataTable ShowChiTietHD()
        {
            string sql = "select * from ChiTietHoaDonView";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }

        public void InsertChiTietHD(ChiTietHoaDonDTO ct)
        {
            string sql = "Insert into ChiTietHoaDon2 values('" + ct.MaHD + "','" + ct.MaHH + "','" + ct.SoLuong + "')";
            data.ExcuteNonQuery(sql);
        }

        public void UpdateChiTietHD(ChiTietHoaDonDTO ct)
        {
            string sql = "Update ChiTietHoaDon2 set SoLuong = " + Int32.Parse(ct.SoLuong) + " where MaHDCT = '" + ct.MaHD + "' and MaHH = '" + ct.MaHH + "'" ;
            data.ExcuteNonQuery(sql);
        }

        public void DeleteChiTietHD(string mahd, string mahh)
        {
            string sql = "Delete from ChiTietHoaDon2 where MaHDCT = '" + mahd + "' and MaHH='" + mahh + "'";
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

        public int findPrice(String maHH)
        {
            int result = 0;
            string sqlQuery = "select * from Hang2 h where h.MaHH = '" + maHH + "'";

            SqlConnection con = data.getConnect();
            con.Open();
            SqlCommand command = new SqlCommand(sqlQuery, con);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    result = reader.GetInt32(4);
                }
            }
            con.Close();
            return result;
        }
    }
}
