using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanHang.Object
{
    class KhachHangObj
    {
        private String maKH;
        private String tenKH;
        private String sdt;
        private String gioiTinh;
        private String diaChi;
        private int soDiem;
        private String maNV;

        public String MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }

        public String TenKH
        {
            get { return tenKH; }
            set { tenKH = value; }
        }

        public String SDT
        {
            get { return sdt; }
            set { sdt = value; }
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

        public String MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        public int SoDiem
        {
            get { return soDiem; }
            set { soDiem = value; }
        }

        public KhachHangObj() { }
        public KhachHangObj(String makh,String tenkh,String sdt,String gioitinh,String diachi,String manv,int sodiem)
        {
            sodiem = 5;
            this.MaKH = makh;
            this.TenKH = tenkh;
            this.SDT = sdt;
            this.GioiTinh = gioitinh;
            this.DiaChi = diachi;
            this.MaNV = manv;
            this.SoDiem = sodiem;
        }
    }
}
