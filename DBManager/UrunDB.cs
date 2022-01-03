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
        ConnectionString _conn = new ConnectionString();

        public List<Urun> TumUrunleriGetir()
        {

            _conn.BaglantiAc();
            SqlCommand command = new SqlCommand("Select * From Urun", _conn.Conn);
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

            _conn.BaglantiKapat();
            return urunler;
        }
        public List<Urun> StokDurumu()
        {

            _conn.BaglantiAc();
            SqlCommand command = new SqlCommand("sp_StokDurumu", _conn.Conn); //Ürün 10 un Altındaysa İlgili Yeri Göster.

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

            _conn.BaglantiKapat();
            return urunler;
        }
        

        public void UrunEkle(Urun urun)
        {
            _conn.BaglantiAc();
            SqlCommand command = new SqlCommand("INSERT INTO Urun VALUES (@UrunAd,@Stok)", _conn.Conn);
            command.Parameters.AddWithValue("@UrunAd", urun.UrunAd);
            command.Parameters.AddWithValue("@Stok", urun.Stok);
            command.ExecuteNonQuery();
            _conn.BaglantiKapat();

        }
        public void UrunSil(Urun urun)
        {
            _conn.BaglantiAc();
            SqlCommand command = new SqlCommand("Delete From Urun  WHERE UrunID=@UrunID", _conn.Conn);
            command.Parameters.AddWithValue("@UrunID", urun.UrunID);
            command.ExecuteNonQuery();
            _conn.BaglantiKapat();


        }
        public Urun UrunAra(string urunAd)
        {
            Urun urun = new Urun();
            _conn.BaglantiAc();
            SqlCommand command = new SqlCommand("SELECT * FROM Urun WHERE UrunAd=@urunAd ", _conn.Conn);

            command.Parameters.AddWithValue("@urunAd", urunAd);

            SqlDataReader dr = command.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                urun.UrunID = dr.GetInt32(0);
                urun.UrunAd = dr[1].ToString();
                urun.Stok = Convert.ToInt32(dr[2]);
                
            }
            else
                urun.UrunID = -1;

            _conn.BaglantiKapat();
            return urun;
        }
        public void UrunGuncelle(Urun urun)
        {
            _conn.BaglantiAc();
            SqlCommand command = new SqlCommand("UPDATE Urun SET UrunAd=@UrunAd, Stok=@Stok WHERE UrunID=@UrunID", _conn.Conn);
            command.Parameters.AddWithValue("@UrunAd", urun.UrunAd);
            command.Parameters.AddWithValue("@Stok", urun.Stok);
            command.Parameters.AddWithValue("@UrunID", urun.UrunID);
            command.ExecuteNonQuery();
            _conn.BaglantiKapat();
        }
        public void UrunStokAzalt(int urunID, int kalanStok)
        {
            _conn.BaglantiAc();
            SqlCommand command = new SqlCommand("UPDATE Urun SET Stok=@kalanStok WHERE UrunID=@urunID", _conn.Conn);
            command.Parameters.AddWithValue("@kalanStok", kalanStok);
            command.Parameters.AddWithValue("@urunID", urunID);
            command.ExecuteNonQuery();
            _conn.BaglantiKapat();
        }
        public Urun UrunSatisGetir(string urunAd)
        {
            _conn.BaglantiAc();
            //Select MusteriID From dbo.Musteri where MusteriAd='Samed' and MusteriSoyad='Sargın' and MusteriSehir='Malatya'
            SqlCommand command = new SqlCommand("Select * From Urun WHERE UrunAd=@urunAd", _conn.Conn);
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
            _conn.BaglantiKapat();
            return urun;
        }
    }
}
