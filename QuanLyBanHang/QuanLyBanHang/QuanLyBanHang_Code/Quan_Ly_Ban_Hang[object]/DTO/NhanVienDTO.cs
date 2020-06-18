using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanHang.DTO
{
    class NhanVienDTO
    {
        private string maNV;
        private string tenNV;
        private string gioiTinh;
        private string diaChi;
        private string sdt;
        private string rank;
        private string taiKhoan;
        private string matKhau;

        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        public string TenNV
        {
            get { return tenNV; }
            set { tenNV = value; }
        }

        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }

        public string Rank
        {
            get { return rank; }
            set { rank = value; }
        }

        public string TaiKhoan
        {
            get { return taiKhoan; }
            set { taiKhoan = value; }
        }

        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }

        public NhanVienDTO() { }
        public NhanVienDTO(string manv, string tennv, string gioiTinh, string diaChi, string sdt, string rank, string taikhoan, string matkhau)
        {
            MaNV = manv;
            TenNV = tennv;
            GioiTinh = gioiTinh;
            SDT = sdt;
            DiaChi = diaChi;
            Rank = rank;
            TaiKhoan = taikhoan;
            MatKhau = matkhau;
        }

        public NhanVienDTO(string taikhoan, string matkhau)
        {
            TaiKhoan = taikhoan;
            MatKhau = matkhau;
        }
    }
}
