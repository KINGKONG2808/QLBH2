using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanHang.DTO
{
    class LoaiHangDTO
    {
        private string maLoai;
        private string tenLoai;
        private string ghiChu;

        public string MaLoai { get => maLoai; set => maLoai = value; }
        public string TenLoai { get => tenLoai; set => tenLoai = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }

        public LoaiHangDTO() { }

        public LoaiHangDTO(string maLoai, string tenLoai, string ghiChu)
        {
            this.maLoai = maLoai;
            this.tenLoai = tenLoai;
            this.ghiChu = ghiChu;
        }
    }
}
