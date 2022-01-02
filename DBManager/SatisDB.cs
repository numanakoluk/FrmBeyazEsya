using FrmBeyazEsya.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmBeyazEsya.DBManager
{
    public class SatisDB
    {
        private SqlConnection _conn = new SqlConnection(@"Data Source=DESKTOP-DPB315I;Initial Catalog=DbNetworkProject;Integrated Security=True");
        private MusteriDB musteriDB = new MusteriDB();
        private UrunDB urunDB = new UrunDB();

        public List<SatisGridViewModel> SatisGetir()
        {
            _conn.Open();
            SqlCommand command = new SqlCommand("SELECT  SatisID, Musteri.MusteriAd, Musteri.MusteriSoyad, Musteri.MusteriSehir, Satis.Fiyat, Satis.Adet, Satis.SatisTarihi, Urun.UrunAd, Urun.Stok FROM Musteri INNER JOIN  Satis ON Musteri.MusteriID = Satis.MusteriID INNER JOIN Urun ON Satis.UrunID = Urun.UrunID", _conn);
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

            _conn.Close();
            return vms;
        }

        public void SatisEkle(SatisDataModel view) //Satiş Eklemek İçin DataModel Kullaınımı.
        {
            _conn.Open();

            SqlCommand command = new SqlCommand("INSERT INTO Satis (UrunID,MusteriID,Fiyat,Adet,SatisTarihi) " +
                "values(@UrunID,@MusteriID,@Fiyat,@Adet,@SatisTarihi) ", _conn);

            command.Parameters.AddWithValue("@UrunID", view.UrunID);
            command.Parameters.AddWithValue("@MusteriID", view.MusteriID);
            command.Parameters.AddWithValue("@Fiyat", view.Fiyat);
            command.Parameters.AddWithValue("@Adet", view.Adet);
            command.Parameters.AddWithValue("@SatisTarihi", view.SatisTarihi);
            command.ExecuteNonQuery();
            _conn.Close();
        }
        public List<SatisDataModel> FiyatAralik()
        {

            _conn.Open();
            SqlCommand command = new SqlCommand("sp_FiyatAralik", _conn); 

            SqlDataReader dr = command.ExecuteReader();
            List<SatisDataModel> urunler = new List<SatisDataModel>();
            command.CommandType = CommandType.StoredProcedure;
            while (dr.Read())
            {
                SatisDataModel urun = new SatisDataModel()
                {

                    //UrunID = Convert.ToInt32(dr["UrunID"]),
                    UrunAdi = dr["UrunAd"].ToString(),
                    Fiyat = Convert.ToDecimal(dr["Fiyat"]),

                };
                urunler.Add(urun);
            }

            _conn.Close();
            return urunler;
        }
    }
}
