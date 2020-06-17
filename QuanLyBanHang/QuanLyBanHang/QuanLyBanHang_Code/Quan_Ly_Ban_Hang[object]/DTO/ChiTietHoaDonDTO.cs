using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanHang.Object
{
    class ChiTietHoaDonObj
    {
        private String maHD;
        private String maHH;
        private String donGia;
        private String soLuong;

        public String MaHD
        {
            get { return maHD; }
            set { maHD = value; }
        }

        public String MaHH
        {
            get { return maHH; }
            set { maHH = value; }
        }

        public String DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }

        public String SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        public ChiTietHoaDonObj() { }
        public ChiTietHoaDonObj(String mahd,String mahh,String dongia,String soluong)
        {
            this.MaHD = mahd;
            this.maHH = mahh;
            this.DonGia = dongia;
            this.SoLuong = soluong;
        }
    }
}
