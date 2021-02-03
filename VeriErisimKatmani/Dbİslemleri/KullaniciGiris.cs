using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriErisimKatmani.Dbİslemleri
{
   public class KullaniciGiris
    {
        AdminEntities db = new AdminEntities();

        public bool GirisYap (string kullanici, string sifre)
        {
            return db.KullaniciGirisiDb.Any(x => x.KullaniciAdi == kullanici && x.KullaniciSifre == sifre);
        }
    }
}
