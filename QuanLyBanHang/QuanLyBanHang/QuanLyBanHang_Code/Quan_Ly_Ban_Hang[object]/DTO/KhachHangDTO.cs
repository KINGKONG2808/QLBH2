using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanHang.DTO
{
    class KhachHangDTO
    {
        private string maKH;
        private string tenKH;
        private string sdt;
        private string gioiTinh;
        private string diaChi;
        private int soDiem;
        private string maNV;

        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }

        public string TenKH
        {
            get { return tenKH; }
            set { tenKH = value; }
        }

        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
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

        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        public int SoDiem
        {
            get { return soDiem; }
            set { soDiem = value; }
        }

        public KhachHangDTO() { }
        public KhachHangDTO(string makh, string tenkh, string sdt, string gioitinh, string diachi, string manv, int sodiem)
        {
            sodiem = 5;
            MaKH = makh;
            TenKH = tenkh;
            SDT = sdt;
            GioiTinh = gioitinh;
            DiaChi = diachi;
            MaNV = manv;
            SoDiem = sodiem;
        }
    }
}
