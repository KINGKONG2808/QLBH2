using QL_BanHang.DAL;
using QL_BanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanHang.BUS
{
    class LichSuGiaBUS
    {
        DataConnect data = new DataConnect();

        public DataTable ShowLichSuGia()
        {
            string sql = "select ls.MaHH, ls.NgayBatDau, ls.NgayKetThuc, ls.DonGia, ls.NgayCapNhat , h.TenHang from LichSuGia2 ls , Hang2 h where ls.MaHH = h.MaHH";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
        public DataTable ShowComboBox()
        {
            string sql = "select h.MaHH, h.TenHang from Hang2 h";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }

        public DataTable ShowLichSuGia(string a)
        {
            string sql = "select * from LichSuGia2 where MaHH = '" + a + "'" ;
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
        public void addLichSuGia(LichSuGiaDTO lh)
        {
            string sql = "Insert into LichSuGia2 values(N'" + lh.MaHang + "','" + lh.NgayBatDau + "','" + lh.NgayKetThuc + "', " + lh.DonGia + ",'" + lh.NgayCapNhat + "')";
            data.ExcuteNonQuery(sql);
        }

        public void UpdateLichSuGia(LichSuGiaDTO lh)
        {
            string sql = "Update LichSuGia2 set NgayBatDau = '" + lh.NgayBatDau + "',NgayKetThuc = '" + lh.NgayKetThuc + "', DonGia = " + lh.DonGia + ", NgayCapNhat = '" + lh.NgayCapNhat + "' where MaHH = '" + lh.MaHang + "'";
            data.ExcuteNonQuery(sql);
        }

        public void DeleteLichSuGia(string ml, string b)
        {
            string sql = "Delete LichSuGia2 where MaHH = '" + ml + "' and NgayBatDau = '" + b + "'";
            data.ExcuteNonQuery(sql);
        }
    }
}
