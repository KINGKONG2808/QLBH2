using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanHang.DTO
{
    class NhaCungCapDTO
    {
        private string maNCC;
        private string tenNCC;
        private string sdt;
        private string diaChi;

        public string MaNCC
        {
            get { return maNCC; }
            set { maNCC = value; }
        }

        public string TenNCC
        {
            get { return tenNCC; }
            set { tenNCC = value; }
        }

        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public NhaCungCapDTO() { }
        public NhaCungCapDTO(string mancc, string tenncc, string sdt, string diachi)
        {
            MaNCC = mancc;
            TenNCC = tenncc;
            SDT = sdt;
            DiaChi = diachi;
        }
    }
}
