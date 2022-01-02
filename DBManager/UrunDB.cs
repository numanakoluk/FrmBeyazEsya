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
    public class UrunDB
    {
        SqlConnection _conn = new SqlConnection(@"Data Source=DESKTOP-DPB315I;Initial Catalog=DbNetworkProject;Integrated Security=True");

        public List<Urun> TumUrunleriGetir()
        {

            _conn.Open();
            SqlCommand command = new SqlCommand("Select * From Urun", _conn);
            SqlDataReader dr = command.ExecuteReader();
            List<Urun> urunler = new List<Urun>();
            while (dr.Read())
            {
                Urun urun = new Urun()
                {

                    UrunID = Convert.ToInt32(dr["UrunID"]),
                    UrunAd = dr["UrunAd"].ToString(),
                    Stok = Convert.ToInt32(dr["Stok"]),

                };
                urunler.Add(urun);
            }

            _conn.Close();
            return urunler;
        }
        public List<Urun> StokDurumu()
        {

            _conn.Open();
            SqlCommand command = new SqlCommand("sp_StokDurumu", _conn); //Ürün 5 in Altındaysa İlgili Yeri Göster.

            SqlDataReader dr = command.ExecuteReader();
            List<Urun> urunler = new List<Urun>();
            command.CommandType = CommandType.StoredProcedure;
            while (dr.Read())
            {
                Urun urun = new Urun()
                {

                    UrunID = Convert.ToInt32(dr["UrunID"]),
                    UrunAd = dr["UrunAd"].ToString(),
                    Stok = Convert.ToInt32(dr["Stok"]),

                };
                urunler.Add(urun);
            }

            _conn.Close();
            return urunler;
        }
        

        public void UrunEkle(Urun urun)
        {
            _conn.Open();
            SqlCommand command = new SqlCommand("INSERT INTO Urun VALUES (@UrunAd,@Stok)", _conn);
            command.Parameters.AddWithValue("@UrunAd", urun.UrunAd);
            command.Parameters.AddWithValue("@Stok", urun.Stok);
            command.ExecuteNonQuery();
            _conn.Close();

        }
        public void UrunSil(Urun urun)
        {
            _conn.Open();
            SqlCommand command = new SqlCommand("Delete From Urun  WHERE UrunID=@UrunID", _conn);
            command.Parameters.AddWithValue("@UrunID", urun.UrunID);
            command.ExecuteNonQuery();
            _conn.Close();


        }
        public void UrunGuncelle(Urun urun)
        {
            _conn.Open();
            SqlCommand command = new SqlCommand("UPDATE Urun SET UrunAd=@UrunAd, Stok=@Stok WHERE UrunID=@UrunID", _conn);
            command.Parameters.AddWithValue("@UrunAd", urun.UrunAd);
            command.Parameters.AddWithValue("@Stok", urun.Stok);
            command.Parameters.AddWithValue("@UrunID", urun.UrunID);
            command.ExecuteNonQuery();
            _conn.Close();
        }
        public void UrunStokAzalt(int urunID, int kalanStok)
        {
            _conn.Open();
            SqlCommand command = new SqlCommand("UPDATE Urun SET Stok=@kalanStok WHERE UrunID=@urunID", _conn);
            command.Parameters.AddWithValue("@kalanStok", kalanStok);
            command.Parameters.AddWithValue("@urunID", urunID);
            command.ExecuteNonQuery();
            _conn.Close();
        }
        public Urun UrunSatisGetir(string urunAd)
        {
            _conn.Open();
            //Select MusteriID From dbo.Musteri where MusteriAd='Samed' and MusteriSoyad='Sargın' and MusteriSehir='Malatya'
            SqlCommand command = new SqlCommand("Select * From Urun WHERE UrunAd=@urunAd", _conn);
            command.Parameters.AddWithValue("@urunAd", urunAd);
            command.ExecuteNonQuery();
            SqlDataReader dr = command.ExecuteReader();
            Urun urun = new Urun();
            dr.Read();
            if (dr.HasRows)
            {
                urun = new Urun()
                {

                    UrunID = Convert.ToInt32(dr["UrunID"]),
                    UrunAd = dr["UrunAd"].ToString(),
                    Stok = Convert.ToInt32(dr["Stok"]),
                };
            }
            _conn.Close();
            return urun;
        }
    }
}
