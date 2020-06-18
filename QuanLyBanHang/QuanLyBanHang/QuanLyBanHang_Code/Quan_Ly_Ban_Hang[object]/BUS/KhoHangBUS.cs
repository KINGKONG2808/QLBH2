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
            string sql = "select * from Hang2";
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
