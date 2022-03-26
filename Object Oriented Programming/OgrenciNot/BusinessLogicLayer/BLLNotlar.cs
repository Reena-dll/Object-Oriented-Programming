using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using FacadeLayer;

namespace BusinessLogicLayer
{
    public class BLLNotlar
    {
        public static bool Guncelle(EntityNotlar deger)
        {
            if (deger.OgrID != null && deger.OgrID>0 && deger.Ortalama != null && deger.Ortalama>=0 && deger.Ortalama <= 100 && deger.Sinav1 !=null && deger.Sinav1>=0 && deger.Sinav1<=100 && deger.Sinav2 != null && deger.Sinav2 >= 0 && deger.Sinav2 <= 100 && deger.Sinav3 != null && deger.Sinav3 >= 0 && deger.Sinav3 <= 100 && deger.Proje != null && deger.Proje >= 0 && deger.Proje <= 100 && deger.Durum != null)
            {
                return FacadeNotlar.Guncelle(deger);
            }
            return false;
        }

        public static List<EntityNotlar> Listele()
        {
            return FacadeNotlar.NotListesi();
        }
    }
}
