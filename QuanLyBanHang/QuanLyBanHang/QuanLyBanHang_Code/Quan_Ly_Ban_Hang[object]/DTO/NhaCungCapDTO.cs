using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanHang.Object
{
    class NhaCungCapObj
    {
        private String maNCC;
        private String tenNCC;
        private String sdt;
        private String diaChi;

        public String MaNCC
        {
            get { return maNCC; }
            set { maNCC = value; }
        }

        public String TenNCC
        {
            get { return tenNCC; }
            set { tenNCC = value; }
        }

        public String SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }

        public String DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public NhaCungCapObj() { }
        public NhaCungCapObj(String mancc,String tenncc,String sdt,String diachi)
        {
            this.MaNCC = mancc;
            this.TenNCC = tenncc;
            this.SDT = sdt;
            this.DiaChi = diachi;
        }
    }
}
