using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThietBi
{
    class PhongP
    {
        private static PhongP Instance;
        public static PhongP GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new PhongP();
                }
                return Instance;
            }
        }
        private PhongP() { }
        Context db = new Context();
        public object GetPhong()
        {
            return db.Phong.Select(o => new { o.MaPhong, o.TenPhong }).ToList();
        }
        public string layTenPhong(string MaP)
        {
            return db.Phong.FirstOrDefault(gv => gv.MaPhong == MaP)?.TenPhong.ToString();
        }
        public object timPhongChuaTrangBi()
        {
            return db.Phong.Where(phong => !db.TB_Phong.Any(ptb => ptb.MaPhong == phong.MaPhong)).ToList();
        }
    }
}
