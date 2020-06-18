using QL_BanHang.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanHang.BUS
{
    class TimKiemBUS
    {
        DataConnect data = new DataConnect();

        public DataTable searchHoaDonById(String maHD)
        {
            string sql = "select * from HoaDonView hdv where hdv.MaHD = " + maHD;
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
    }
}
