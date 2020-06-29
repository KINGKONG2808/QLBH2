using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanHang.DTO
{
    class ChiTietHoaDonDTO
    {
        private string maHD;
        private string maHH;
        private string soLuong;

        public string MaHD
        {
            get { return maHD; }
            set { maHD = value; }
        }

        public string MaHH
        {
            get { return maHH; }
            set { maHH = value; }
        }

        public string SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        public ChiTietHoaDonDTO() { }
        public ChiTietHoaDonDTO(string mahd, string mahh, string soluong)
        {
            MaHD = mahd;
            maHH = mahh;
            SoLuong = soluong;
        }
    }
}
