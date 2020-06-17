using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanHang.Object
{
    class HoaDonObj
    {
        private String maHD;
        private String maKH;
        private String maNV;
        private String ngayLap;

        public String MaHD
        {
            get { return maHD; }
            set { maHD = value; }
        }

        public String MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }

        public String MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        public String NgayLap
        {
            get { return ngayLap; }
            set { ngayLap = value; }
        }

        public HoaDonObj() { }
        public HoaDonObj(String mahd,String makh,String manv,String ngaylap)
        {
            this.MaHD = mahd;
            this.MaKH = makh;
            this.MaNV = manv;
            this.NgayLap = ngaylap;
        }
    }
}
