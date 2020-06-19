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
        private long luongCung;

        public string MaTrinhDo { get => maTrinhDo; set => maTrinhDo = value; }
        public string TenTrinhDo { get => tenTrinhDo; set => tenTrinhDo = value; }
        public long LuongCung { get => luongCung; set => luongCung = value; }

        public TrinhDoDTO(string maTrinhDo, string tenTrinhDo, long luongCung)
        {
            MaTrinhDo = maTrinhDo;
            TenTrinhDo = tenTrinhDo;
            LuongCung = luongCung;
        }

        public TrinhDoDTO()
        {
        }
    }
}
