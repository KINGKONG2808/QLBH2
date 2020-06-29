using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_BanHang.DAL;
using QL_BanHang.DTO;

namespace QL_BanHang.BUS
{
    class HoaDonBUS
    {
        DataConnect data = new DataConnect();

        //Lấy thông tin
        public DataTable onLoadHoaDon()
        {
            string sql = "select * from HoaDon2";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }

        public DataTable ShowHoaDon()
        {
            string sql = "select * from HoaDonView order by HoaDonView.NgayLap desc";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }

        public void InsertHoaDon(HoaDonDTO hd)
        {
            string sql = "Insert into HoaDon2 values('" + hd.MaHD + "','" + hd.MaKH + "','" + hd.MaNV + "','" + hd.NgayLap + "')";
            data.ExcuteNonQuery(sql);
        }

        public void UpdateHoaDon(HoaDonDTO hd)
        {
            string sql = "Update HoaDon2 set MaKH='" + hd.MaKH + "',MaNV='" + hd.MaNV + "',NgayLap='" + hd.NgayLap + "' where MaHD='" + hd.MaHD + "'";
            data.ExcuteNonQuery(sql);
        }

        public void DeleteHoaDon(string mahd)
        {
            string sql = "Delete from HoaDon2 where MaHD = '" + mahd + "'";
            data.ExcuteNonQuery(sql);
        }

        public string onChangeCboBox(String variable, bool checkType)
        {
            string result = "";
            string sqlQuery = checkType ? ("select * from NhanVien2 nv where nv.MaNV = '" + variable + "'") : ("select * from KhachHang2 kh where kh.MaKH = '" + variable + "'");
            
            SqlConnection con = data.getConnect();
            con.Open();
            SqlCommand command = new SqlCommand(sqlQuery, con);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    result = reader.GetString(1);

                }
            }
            con.Close();
            return result;
        }
    }
}
