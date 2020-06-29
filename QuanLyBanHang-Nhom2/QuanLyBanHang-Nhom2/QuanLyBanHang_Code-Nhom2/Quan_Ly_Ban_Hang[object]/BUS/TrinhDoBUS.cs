using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_BanHang.DAL;
using System.Data;
using QL_BanHang.DTO;
using System.Data.SqlClient;

namespace QL_BanHang.BUS
{
    class TrinhDoBUS
    {
        DataConnect data = new DataConnect();
        TrinhDoDTO trinhDoDTO = new TrinhDoDTO();
        public DataTable ShowTrinhDo()
        {
            string sql = "select * from TrinhDo2";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }

        public void EditTrinhDo(TrinhDoDTO trinhDoDTO)
        {
            string sql = "Update TrinhDo2 set TenTrinhDo = N'" + trinhDoDTO.TenTrinhDo+ "', LuongCung = '"+ trinhDoDTO.LuongCung+"' where MaTrinhDo = " + trinhDoDTO.MaTrinhDo;
            data.ExcuteNonQuery(sql);
        }
        public void AddTrinhDo(TrinhDoDTO trinhDoDTO)
        {
            string sql = "insert into TrinhDo2 values( N'" + trinhDoDTO.MaTrinhDo + "', N'" + trinhDoDTO.TenTrinhDo + "','" + trinhDoDTO.LuongCung + "')";
            data.ExcuteNonQuery(sql);
        }

        public void DeleteTrinhDo(String maTrinhDo)
        {
            string sql = "delete TrinhDo2 where MaTrinhDo = " + maTrinhDo;
            data.ExcuteNonQuery(sql);
        }

        public DataTable searchTrinhDo(String keyword)
        {
            string sql = "select * from TrinhDo2 td where td.MaTrinhDo like N'%" + keyword + "%' Or td.TenTrinhDo like N'%" + keyword + "%'";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }

        public string onChangeCboBox(String variable)
        {
            string result = "";
            string sqlQuery = "select * from TrinhDo2 td where td.MaTrinhDo = '" + variable + "'";

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
