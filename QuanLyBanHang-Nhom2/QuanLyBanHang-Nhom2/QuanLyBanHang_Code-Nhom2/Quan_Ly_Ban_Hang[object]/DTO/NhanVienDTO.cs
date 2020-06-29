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
        private string maTrinhDo;
        private string taiKhoan;
        private string matKhau;

        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string MaTrinhDo { get => maTrinhDo; set => maTrinhDo = value; }
        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }

        public NhanVienDTO() { }

        public NhanVienDTO(string maNV, string tenNV, string gioiTinh, string diaChi, string sdt, string maTrinhDo, string taiKhoan, string matKhau) : this(maNV, tenNV)
        {
            this.GioiTinh = gioiTinh;
            this.DiaChi = diaChi;
            this.Sdt = sdt;
            this.MaTrinhDo = maTrinhDo;
            this.TaiKhoan = taiKhoan;
            this.MatKhau = matKhau;
        }

        public NhanVienDTO(string taikhoan, string matkhau)
        {
            TaiKhoan = taikhoan;
            MatKhau = matkhau;
        }
    }
}
