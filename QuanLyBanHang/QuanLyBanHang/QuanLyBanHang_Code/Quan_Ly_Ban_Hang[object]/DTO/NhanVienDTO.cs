using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanHang.Object
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
        
        public String MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        public String TenNV
        {
            get { return tenNV; }
            set { tenNV = value; }
        }

        public String GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        public String DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public String SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }

        public String Rank
        {
            get { return rank; }
            set { rank = value; }
        }

        public String TaiKhoan
        {
            get { return taiKhoan; }
            set { taiKhoan = value; }
        }

        public String MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }

        public NhanVienDTO() { }
        public NhanVienDTO(String manv,String tennv,String gioiTinh,String diaChi,String sdt,String rank,String taikhoan,String matkhau)
        {
            this.MaNV = manv;
            this.TenNV = tennv;
            this.GioiTinh = gioiTinh;
            this.SDT = sdt;
            this.DiaChi = diaChi;
            this.Rank = rank;
            this.TaiKhoan = taikhoan;
            this.MatKhau = matkhau;
        }

        public NhanVienDTO(String taikhoan, String matkhau)
        {
            this.TaiKhoan = taikhoan;
            this.MatKhau = matkhau;
        }
    }
}
