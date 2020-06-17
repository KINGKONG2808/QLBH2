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
    class NhaCungCapBLL
    {
        DataConnect data = new DataConnect();

        public DataTable ShowNhaCungCap()
        {
            string sql = "select * from NhaCungCap";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }

        public void InsertNhaCungCap(NhaCungCapObj ncc)
        {
            string sql = "Insert into NhaCungCap values('" + ncc.MaNCC + "',N'" + ncc.TenNCC + "','" + ncc.SDT + "',N'" + ncc.DiaChi + "')";
            data.ExcuteNonQuery(sql);
        }

        public void UpdateNhaCungCap(NhaCungCapObj ncc)
        {
            string sql = "Update NhaCungCap set TenNCC=N'" + ncc.TenNCC + "',SDT='" + ncc.SDT + "',DiaChi=N'" + ncc.DiaChi + "' where MaNCC='" + ncc.MaNCC + "'";
            data.ExcuteNonQuery(sql);
        }

        public void DeleteNhaCungCap(String mancc)
        {
            string sql = "Delete NhaCungCap where MaNCC = '" + mancc + "'";
            data.ExcuteNonQuery(sql);
        }
    }
}
