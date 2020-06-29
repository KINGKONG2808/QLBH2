using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using QL_BanHang.DAL;
using System.Data;
using QL_BanHang.DTO;

namespace QL_BanHang.BUS
{
    class LoaiHangBUS
    {
        DataConnect data = new DataConnect();

        public DataTable ShowLoaiHang()
        {
            string sql = "select * from LoaiHang2";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }

        
        public DataTable ShowLoaiHangtk(string a)
        {
            string sql = "select * from LoaiHang2 where MaLoai = '" + a + "' ";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
        public void addLoaiHang(LoaiHangDTO lh)
        {
            string sql = "Insert into LoaiHang2 values(N'" + lh.MaLoai + "',N'" + lh.TenLoai + "',N'" + lh.GhiChu + "')";
            data.ExcuteNonQuery(sql);
        }

        public void UpdateLoaiHang(LoaiHangDTO lh)
        {
            string sql = "Update LoaiHang2 set TenLoai = N'" + lh.TenLoai + "',GhiChu = N'" + lh.GhiChu + "' where MaLoai ='" + lh.MaLoai + "'";
            data.ExcuteNonQuery(sql);
        }

        public void DeleteLoaiHang(string ml)
        {
            string sql = "Delete LoaiHang2 where MaLoai = '" + ml + "'";
            data.ExcuteNonQuery(sql);
        }
    }
}
