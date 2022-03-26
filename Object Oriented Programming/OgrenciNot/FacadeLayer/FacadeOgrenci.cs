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
    public class FacadeOgrenci
    {
        public static int Ekle(EntityOgrenci deger)
        {
            SqlCommand komut = new SqlCommand("OgrenciEkle", SqlBaglantisi.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("ad", deger.Ad);
            komut.Parameters.AddWithValue("soyad", deger.Soyad);
            komut.Parameters.AddWithValue("Fotograf", deger.Fotograf);
            komut.Parameters.AddWithValue("KulupID", deger.KulupID);
            return komut.ExecuteNonQuery();
        }

        public static bool Sil(int deger)
        {
            SqlCommand komut = new SqlCommand("OgrenciSil", SqlBaglantisi.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("ID", deger);
            return komut.ExecuteNonQuery() > 0;
        }

        public static bool Guncelle(EntityOgrenci deger)
        {
            SqlCommand komut = new SqlCommand("OgrenciGuncelle", SqlBaglantisi.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("Ad", deger.Ad);
            komut.Parameters.AddWithValue("Soyad", deger.Soyad);
            komut.Parameters.AddWithValue("Fotograf", deger.Fotograf);
            komut.Parameters.AddWithValue("KulupID", deger.KulupID);
            komut.Parameters.AddWithValue("ID", deger.ID);
            return komut.ExecuteNonQuery() > 0;
        }

        public static List<EntityOgrenci> OgrenciListesi()
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut = new SqlCommand("OgrenciListesi", SqlBaglantisi.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ogr = new EntityOgrenci();
                ogr.Ad = dr["Ad"].ToString();
                ogr.Soyad = dr["Soyad"].ToString();
                ogr.Fotograf = dr["Fotograf"].ToString();
                ogr.KulupID = Convert.ToInt16(dr["KulupID"]);
                ogr.ID = Convert.ToInt16(dr["ID"]);
                degerler.Add(ogr);
            }
            dr.Close();
            return degerler;
        }
    }
}
