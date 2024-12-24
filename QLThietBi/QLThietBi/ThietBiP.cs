using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThietBi
{
    class ThietBiP
    {
        private static ThietBiP Instance;
        public static ThietBiP GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new ThietBiP();
                }
                return Instance;
            }
        }
        private ThietBiP() { }
        Context db = new Context();
        public object GetTB()
        {
            return db.ThietBi.Select(o => new {o.MaThietBi, o.TenThietBi, o.SoLuong }).ToList();
        }
        public string layTenTB(string MaTB)
        {
            return db.ThietBi.FirstOrDefault(gv => gv.MaThietBi == MaTB)?.TenThietBi.ToString();
        }
    }
}
