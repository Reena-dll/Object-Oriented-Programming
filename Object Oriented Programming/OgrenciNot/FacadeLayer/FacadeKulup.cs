using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;
using System.Data;

namespace FacadeLayer
{
    public class FacadeKulup
    {
        public static int Ekle(EntityKulup deger)
        {
            SqlCommand komut = new SqlCommand("KulupEkle", SqlBaglantisi.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("KulupAd", deger.KulupAd);
            return komut.ExecuteNonQuery();
        }

        public static bool Sil(int deger)
        {
            SqlCommand komut = new SqlCommand("KulupSil", SqlBaglantisi.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("KulupID", deger);
            return komut.ExecuteNonQuery() > 0;
        }

        public static bool Guncelle(EntityKulup deger)
        {
            SqlCommand komut = new SqlCommand("KulupGuncelle", SqlBaglantisi.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("KulupAd", deger.KulupAd);
            komut.Parameters.AddWithValue("KulupID", deger.KulupID);
            return komut.ExecuteNonQuery() > 0;

        }

        public static List<EntityKulup> KulupListesi()
        {
            List<EntityKulup> degerler = new List<EntityKulup>();
            SqlCommand komut = new SqlCommand("KulupListesi", SqlBaglantisi.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityKulup ent = new EntityKulup();
                ent.KulupID = Convert.ToInt16(dr["KulupID"]);
                ent.KulupAd = dr["KulupAd"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
            
    }
}
