using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanHang.Object
{
    class LoaiHangObj
    {
        private String maLoai;
        private String tenLoai;
        private String ghiChu;

        public string MaLoai { get => maLoai; set => maLoai = value; }
        public string TenLoai { get => tenLoai; set => tenLoai = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }

        public LoaiHangObj() { }

        public LoaiHangObj(String maLoai, String tenLoai, String ghiChu)
        {
            this.maLoai = maLoai;
            this.tenLoai = tenLoai;
            this.ghiChu = ghiChu;
        }
    }
}
