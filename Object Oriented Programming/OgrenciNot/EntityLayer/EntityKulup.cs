using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityKulup
    {
        int _KulupID;
        string _KulupAd;

        public int KulupID { get => _KulupID; set => _KulupID = value; }
        public string KulupAd { get => _KulupAd; set => _KulupAd = value; }
    }
}
