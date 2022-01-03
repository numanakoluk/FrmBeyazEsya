using FrmBeyazEsya.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace FrmBeyazEsya.DBManager
{
    public class SatisDB
    {
        private ConnectionString _conn = new ConnectionString();
        //private MusteriDB musteriDB = new MusteriDB();
        //private UrunDB urunDB = new UrunDB();

        public List<SatisGridViewModel> SatisGetir() //Satış Listelemek için Model kullanımı
        {
            _conn.BaglantiAc();
            //Inner Join ile Sorgu çekme
            SqlCommand command = new SqlCommand("SELECT  SatisID, Musteri.MusteriAd, Musteri.MusteriSoyad, Musteri.MusteriSehir, Satis.Fiyat, Satis.Adet, Satis.SatisTarihi, Urun.UrunAd, Urun.Stok FROM Musteri INNER JOIN  Satis ON Musteri.MusteriID = Satis.MusteriID INNER JOIN Urun ON Satis.UrunID = Urun.UrunID", _conn.Conn);
            SqlDataReader dr = command.ExecuteReader();
            List<SatisGridViewModel> vms = new List<SatisGridViewModel>();
            while (dr.Read())
            {
                SatisGridViewModel vm = new SatisGridViewModel()
                {
                    MusteriAd = dr["MusteriAd"].ToString(),
                    MusteriSoyad = dr["MusteriSoyad"].ToString(),
                    MusteriSehir = dr["MusteriSehir"].ToString(),
                    Fiyat = Convert.ToInt32(dr["Fiyat"]),
                    Adet = Convert.ToInt32(dr["Adet"]),
                    UrunAdi = dr["UrunAd"].ToString(),
                    SatisTarihi = Convert.ToDateTime(dr["SatisTarihi"]),
                    Toplam = Convert.ToDecimal(dr["Fiyat"]) * Convert.ToInt32(dr["Adet"])
                };
                vms.Add(vm);
            }

            _conn.BaglantiKapat();
            return vms;
        }

        public void SatisEkle(SatisDataModel view) //Satiş Eklemek İçin DataModel Kullaınımı.
        {
            _conn.BaglantiAc();

            SqlCommand command = new SqlCommand("INSERT INTO Satis (UrunID,MusteriID,Fiyat,Adet,SatisTarihi) " +
                "values(@UrunID,@MusteriID,@Fiyat,@Adet,@SatisTarihi) ", _conn.Conn);

            command.Parameters.AddWithValue("@UrunID", view.UrunID);
            command.Parameters.AddWithValue("@MusteriID", view.MusteriID);
            command.Parameters.AddWithValue("@Fiyat", view.Fiyat);
            command.Parameters.AddWithValue("@Adet", view.Adet);
            command.Parameters.AddWithValue("@SatisTarihi", view.SatisTarihi);
            command.ExecuteNonQuery();
            _conn.BaglantiKapat();
        }

        public List<SatisDataModel> FiyatAralik()
        {
            _conn.BaglantiAc();
            SqlCommand command = new SqlCommand("sp_FiyatAralik", _conn.Conn); //Fiyatı 500 ile 1000 arasında olan ürünlerden kaç adet satılmış?

            SqlDataReader dr = command.ExecuteReader();
            List<SatisDataModel> urunler = new List<SatisDataModel>();
            command.CommandType = CommandType.StoredProcedure;
            while (dr.Read())
            {
                SatisDataModel urun = new SatisDataModel()
                {
                    UrunAdi = dr["UrunAd"].ToString(),
                    Fiyat = Convert.ToDecimal(dr["Fiyat"]),
                    Adet = Convert.ToInt32(dr["Adet"]),
                    //SatisTarihi = Convert.ToDateTime(dr["SatisTarihi"]),
                };
                urunler.Add(urun);
            }

            _conn.BaglantiKapat();
            return urunler;
        }
    }
}