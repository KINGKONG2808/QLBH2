using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanHang.DTO
{
    class LichSuGiaDTO
    {
        private String maHang;
        private String ngayBatDau;
        private String ngayKetThuc;
        private int donGia;
        private String ngayCapNhat;

        public LichSuGiaDTO()
        {
        }

        public LichSuGiaDTO(string maHang, string ngayBatDau, string ngayKetThuc, int donGia, string ngayCapNhat)
        {
            this.MaHang = maHang;
            this.NgayBatDau = ngayBatDau;
            this.NgayKetThuc = ngayKetThuc;
            this.DonGia = donGia;
            this.NgayCapNhat = ngayCapNhat;
        }

        public string MaHang { get => maHang; set => maHang = value; }
        public string NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public string NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
        public int DonGia { get => donGia; set => donGia = value; }
        public string NgayCapNhat { get => ngayCapNhat; set => ngayCapNhat = value; }
    }
}
