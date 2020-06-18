using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;


namespace QL_BanHang.DTO
{
    class HangDTO
    {
        string mahang, tenhang, maloai, nhacungcap, donvitinh;
        int dongia, soluongco;

        public string Mahang { get => mahang; set => mahang = value; }
        public string Tenhang { get => tenhang; set => tenhang = value; }
        public string Maloai { get => maloai; set => maloai = value; }
        public string Nhacungcap { get => nhacungcap; set => nhacungcap = value; }
        public string Donvitinh { get => donvitinh; set => donvitinh = value; }
        public int Dongia { get => dongia; set => dongia = value; }
        public int Soluongco { get => soluongco; set => soluongco = value; }

        public HangDTO() { }
        public HangDTO(string mh, string th, string ml, string mncc, string dvt, int dg, int slc)
        {
            Mahang = mh;
            Tenhang = th;
            Maloai = ml;
            Nhacungcap = mncc;
            Donvitinh = dvt;
            Dongia = dg;
            soluongco = slc;
        }
    }
}
