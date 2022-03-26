using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityNotlar
    {
        int _OgrID;
        int _Sinav1;
        int _Sinav2;
        int _Sinav3;
        int _Proje;
        double _Ortalama;
        string _Durum;

        public int OgrID { get => _OgrID; set => _OgrID = value; }
        public int Sinav1 { get => _Sinav1; set => _Sinav1 = value; }
        public int Sinav2 { get => _Sinav2; set => _Sinav2 = value; }
        public int Sinav3 { get => _Sinav3; set => _Sinav3 = value; }
        public int Proje { get => _Proje; set => _Proje = value; }
        public double Ortalama { get => _Ortalama; set => _Ortalama = value; }
        public string Durum { get => _Durum; set => _Durum = value; }
        public string Ad { get => _Ad; set => _Ad = value; }
        public string Soyad { get => _Soyad; set => _Soyad = value; }

        private string _Ad;
        private string _Soyad;
    }
}
