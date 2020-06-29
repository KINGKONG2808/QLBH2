using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanHang.DTO
{
    class HoaDonDTO
    {
        private string maHD;
        private string maKH;
        private string maNV;
        private string ngayLap;

        public string MaHD
        {
            get { return maHD; }
            set { maHD = value; }
        }

        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }

        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        public string NgayLap
        {
            get { return ngayLap; }
            set { ngayLap = value; }
        }

        public HoaDonDTO() { }
        public HoaDonDTO(string mahd, string makh, string manv, string ngaylap)
        {
            MaHD = mahd;
            MaKH = makh;
            MaNV = manv;
            NgayLap = ngaylap;
        }
    }
}
