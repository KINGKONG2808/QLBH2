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
    class KhachHangBUS
    {
        DataConnect data = new DataConnect();

        public DataTable ShowKhachHang()
        {
            string sql = "select * from KhachHang2";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
        public DataTable ShowKhachHangtk(string tk)
        {
            string sql = "select * from KhachHang2 where MaKH ='" + tk + "'";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
        public void InsertKhachHang(KhachHangDTO kh)
        {
            string gt;
            if (kh.GioiTinh.Equals("Nam"))
                gt = "True";
            else
                gt = "False";
            kh.GioiTinh = gt;
            string sql = "Insert into KhachHang2 values('" + kh.MaKH + "',N'" + kh.TenKH + "','" + kh.SDT + "','" + kh.GioiTinh + "',N'" + kh.DiaChi + "','" + kh.MaNV + "')";
            data.ExcuteNonQuery(sql);
        }

        public void UpdateKhachHang(KhachHangDTO kh)
        {
            string gt;
            if (kh.GioiTinh.Equals("Nam"))
                gt = "True";
            else
                gt = "False";
            kh.GioiTinh = gt;
            string sql = "Update KhachHang2 set TenKH=N'" + kh.TenKH + "',SDT='" + kh.SDT + "',GioiTinh='" + kh.GioiTinh + "',DiaChi=N'" + kh.DiaChi + "',MaNV='" + kh.MaNV + "' where MaKH='" + kh.MaKH + "'";
            data.ExcuteNonQuery(sql);
        }

        public void DeleteKhachHang(string makh)
        {
            string sql = "Delete KhachHang2 where MaKH = '" + makh + "'";
            data.ExcuteNonQuery(sql);
        }
    }
}
