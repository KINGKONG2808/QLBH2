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
    class NhaCungCapBUS
    {
        DataConnect data = new DataConnect();

        public DataTable ShowNhaCungCap()
        {
            string sql = "select * from NhaCungCap2";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
        public DataTable ShowNhaCungCaptk(string tk)
        {
            string sql = "select * from NhaCungCap2 where MaNCC like '%" + tk + "%'";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }

        public void InsertNhaCungCap(NhaCungCapDTO ncc)
        {
            string sql = "Insert into NhaCungCap2 values('" + ncc.MaNCC + "',N'" + ncc.TenNCC + "','" + ncc.SDT + "',N'" + ncc.DiaChi + "')";
            data.ExcuteNonQuery(sql);
        }

        public void UpdateNhaCungCap(NhaCungCapDTO ncc)
        {
            string sql = "Update NhaCungCap2 set TenNCC=N'" + ncc.TenNCC + "',SDT='" + ncc.SDT + "',DiaChi=N'" + ncc.DiaChi + "' where MaNCC='" + ncc.MaNCC + "'";
            data.ExcuteNonQuery(sql);
        }

        public void DeleteNhaCungCap(string mancc)
        {
            string sql = "Delete NhaCungCap2 where MaNCC = '" + mancc + "'";
            data.ExcuteNonQuery(sql);
        }
    }
}
