using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanHang.DTO
{
    class TrinhDoDTO
    {
        private String maTrinhDo;
        private String tenTrinhDo;

        public string MaTrinhDo { get => maTrinhDo; set => maTrinhDo = value; }
        public string TenTrinhDo { get => tenTrinhDo; set => tenTrinhDo = value; }

        public TrinhDoDTO()
        {
        }

        public TrinhDoDTO(string maTrinhDo, string tenTrinhDo)
        {
            this.maTrinhDo = maTrinhDo;
            this.tenTrinhDo = tenTrinhDo;
        }
    }
}
