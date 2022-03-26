using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using EntityLayer;

namespace FacadeLayer
{
    public class FacadeNotlar
    {
        public static bool Guncelle(EntityNotlar deger)
        {
            SqlCommand komut = new SqlCommand("NotGuncelle", SqlBaglantisi.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("Sinav1", deger.Sinav1);
            komut.Parameters.AddWithValue("Sinav2", deger.Sinav2);
            komut.Parameters.AddWithValue("Sinav3", deger.Sinav3);
            komut.Parameters.AddWithValue("Proje", deger.Proje);
            komut.Parameters.AddWithValue("Ortalama", deger.Ortalama);
            komut.Parameters.AddWithValue("Durum", deger.Durum);
            komut.Parameters.AddWithValue("OgrID", deger.OgrID);
            return komut.ExecuteNonQuery()>0;
        }

        public static List<EntityNotlar> NotListesi()
        {
            List<EntityNotlar> degerler = new List<EntityNotlar>();
            SqlCommand komut = new SqlCommand("NotListesi", SqlBaglantisi.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityNotlar ent = new EntityNotlar();
                ent.OgrID = Convert.ToInt16(dr["OgrID"]);
                ent.Ad = dr["Ad"].ToString();
                ent.Soyad = dr["Soyad"].ToString();
                ent.Sinav1 = Convert.ToInt16(dr["Sinav1"]);
                ent.Sinav2 = Convert.ToInt16(dr["Sinav2"]);
                ent.Sinav3 = Convert.ToInt16(dr["Sinav3"]);
                ent.Proje = Convert.ToInt16(dr["Proje"]);
                ent.Ortalama = Convert.ToDouble(dr["Ortalama"]);
                ent.Durum = dr["Durum"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
    }
}
