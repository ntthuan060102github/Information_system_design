using INFSYS_Design.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFSYS_Design.controllers
{
    public class GhiNhanHuHai
    {
        public int ma;
        public string thietBiHuHai;
        public string moTaTinhTrang;
        public int chiPhiDenBu;
        public int maCheckout;

        public GhiNhanHuHai(Dictionary<string, object> kwargs)
        {
            object data;
            if (kwargs.TryGetValue("MA", out data))
            {
                this.ma = int.Parse(data.ToString());
            }
            if (kwargs.TryGetValue("THIETBIHUHAI", out data))
            {
                this.thietBiHuHai = data.ToString();
            }
            if (kwargs.TryGetValue("MOTATINHTRANG", out data))
            {
                this.moTaTinhTrang = data.ToString();
            }
            if (kwargs.TryGetValue("CHIPHIDENBU", out data))
            {
                this.chiPhiDenBu = int.Parse(data.ToString());
            }
            if (kwargs.TryGetValue("MACHECKOUT", out data))
            {
                this.maCheckout = int.Parse(data.ToString());
            }
        }

        public static bool themGhiNhanHuHai(GhiNhanHuHai hh)
        {
            return DB_GhiNhanHuHai.themGhiNhanHuHai(hh) == 1;
        }
    }
}
