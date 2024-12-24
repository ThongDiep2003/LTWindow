using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace QLThietBi
{
    class TB_PhongP
    {
        private static TB_PhongP Instance;
        public static TB_PhongP GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new TB_PhongP();
                }
                return Instance;
            }
        }
        private TB_PhongP() { }
        Context db = new Context();
        public object GetTB_Phong()
        {
            return db.TB_Phong.Select(o => new { o.MaPhong, o.MaThietBi, o.Ngay, o.SoLuong }).ToList();
        }
        public void themTB_Phong(TB_Phong c)
        {
            using (var context = new Context())
            {
                var tb_p = new TB_Phong { MaPhong = c.MaPhong, MaThietBi = c.MaThietBi, Ngay = c.Ngay, SoLuong = c.SoLuong };
                context.TB_Phong.Add(tb_p);
                context.SaveChanges();
            }
        }
        public void suaTB_Phong(TB_Phong c)
        {
            using (var context = new Context())
            {
                var qr = context.TB_Phong;
                if (qr.Any())
                {
                    var TB_P = qr.First(o => o.MaPhong == c.MaPhong && o.MaThietBi == c.MaThietBi);
                    TB_P.Ngay = c.Ngay;
                    TB_P.SoLuong = c.SoLuong;
                    context.SaveChanges();
                }
                context.SaveChanges();
            }
        }
        public void xoaTB_Phong(string MaPhong, string MaTB)
        {
            using (var context = new Context())
            {
                var x = context.TB_Phong.Find(MaPhong, MaTB);
                if (x != null)
                {
                    context.TB_Phong.Remove(x);
                    context.SaveChanges();
                }
            }
        }
        public object timTheoPhong(string MaPhong)
        {
            return db.TB_Phong.Select(o => new { o.MaPhong, o.MaThietBi, o.Ngay, o.SoLuong })
                               .Where(o => o.MaPhong == MaPhong).ToList();
        }
        public object timTBlapMax()
        {
            var x = db.TB_Phong
                .GroupBy(ptb => ptb.MaThietBi)
                .OrderByDescending(group => group.Sum(ptb => ptb.SoLuong))
                .Select(group => group.Key)
                .FirstOrDefault().ToString();
            return ThietBiP.GetInstance.layTenTB(x);
        }
    }
}
