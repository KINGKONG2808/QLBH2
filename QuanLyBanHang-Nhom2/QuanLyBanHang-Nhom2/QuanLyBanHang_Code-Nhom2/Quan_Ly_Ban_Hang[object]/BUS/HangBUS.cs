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
    class HangBUS
    {
        DataConnect data = new DataConnect();

        public DataTable ShowHang()
        {
            string sql = "select * from Hang2";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }



        public DataTable ShowHangloaihang()
        {
            string sql = "select * from LoaiHang2";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }

        public DataTable ShowHangnhacungcap()
        {
            string sql = "select * from NhaCungCap2";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }

        public void InsertHangHoa(HangDTO h)
        {
            string sql = "Insert into Hang2 values('" + h.Mahang + "',N'" + h.Tenhang + "','" + h.Donvitinh + "','" + h.Dongia + "','" + h.Maloai + "','" + h.Nhacungcap + "','" + h.Soluongco + "')";
            data.ExcuteNonQuery(sql);
        }

        public void UpdateHangHoa(HangDTO h)
        {
            string sql = "Update Hang2 set TenHang=N'" + h.Tenhang + "',DonViTinh='" + h.Donvitinh + "',DonGia='" + h.Dongia + "',MaLoai='" + h.Maloai + "',MaNCC='" + h.Nhacungcap + "',SoLuong='" + h.Soluongco + "' where MaHH='" + h.Mahang + "'";
            data.ExcuteNonQuery(sql);
        }

        public void DeleteHangHoa(string mahh)
        {
            string sql = "Delete Hang2 where MaHH = '" + mahh + "'";
            data.ExcuteNonQuery(sql);
        }

        public DataTable ShowHangtk(string tk)
        {
            string sql = "select * from Hang2 where MaHH like '%" + tk + "%'";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
    }
}
