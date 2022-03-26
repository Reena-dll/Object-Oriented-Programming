using EntityLayer;
using FacadeLayer;
using System.Collections.Generic;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace BusinessLogicLayer
{
    public class BLLOgrenci
    {
        public static int Ekle(EntityOgrenci deger)
        {
            if (deger.Ad !=null && deger.Soyad != null && deger.Fotograf != null && deger.Fotograf != null && deger.KulupID > 0 && deger.KulupID>0 && deger.Fotograf.Length>1)
            {
                return FacadeOgrenci.Ekle(deger);
            }
            return -1;
        }

        public static bool Guncelle(EntityOgrenci deger)
        {
            if (deger.Ad != null && deger.Soyad != null && deger.Fotograf != null && deger.Fotograf != null && deger.KulupID > 0 && deger.KulupID > 0 && deger.ID > 0)
            {
                return FacadeOgrenci.Guncelle(deger);
            }
            return false;
        }
        
        public static bool Sil(int deger)
        {
            if (deger != null && deger >= 1)
            {
                return FacadeOgrenci.Sil(deger);
            }
            return false;
        }

        public static List<EntityOgrenci> Listele()
        {
            return FacadeOgrenci.OgrenciListesi();
        }
    }
}
