using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;


namespace QL_BanHang.Object
{
    class HangHoaObj
    {
        private String maHH;
        private String tenHH;
        private String maNCC;
        private String donGia;
        private String soLuong;
        private int hoaHong;
       

        public String MaHH  
        {
            get { return maHH; }
            set { maHH = value; }
        }

        public String TenHH
        {
            get { return tenHH; }
            set { tenHH = value; }
        }

        public String MaNCC
        {
            get { return maNCC; }
            set { maNCC = value; }
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

        public int HoaHong
        {
            get { return hoaHong; }
            set { hoaHong = value; }
        }


        public HangHoaObj() { }
        public HangHoaObj(String mahh,String tenhh,String mancc,String dongia,String soluong,int hoahong)
        {
            hoahong = 20000;
            this.MaHH = maHH;
            this.TenHH = tenhh;
            this.MaNCC = mancc;
            this.DonGia = dongia;
            this.SoLuong = soluong;
            this.HoaHong = hoahong;
        }
    }
}
