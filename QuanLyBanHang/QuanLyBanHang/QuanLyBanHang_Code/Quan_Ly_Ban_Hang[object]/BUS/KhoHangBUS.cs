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
    class KhoHangBUS
    {
        DataConnect data = new DataConnect();

        public DataTable ShowHangBan()
        {
<<<<<<< HEAD
            string sql = "select * from Hang2";
=======
            string sql = "select * from HangBan2";
>>>>>>> bf1d8d3475cb48832f4be5f09d1baa34d5fb0852
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }

        public DataTable ShowHangTon()
        {
            string sql = "select * from HangTon2";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
    }
}
