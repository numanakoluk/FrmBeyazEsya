using FrmBeyazEsya.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace FrmBeyazEsya.DBManager
{
    public class MusteriDB
    {
        ConnectionString _conn = new ConnectionString();

        public List<Musteri> MusteriGetir()
        {
            _conn.BaglantiAc();
            SqlCommand command = new SqlCommand("SELECT * FROM Musteri", _conn.Conn);
            SqlDataReader dr = command.ExecuteReader();
            List<Musteri> musteriler = new List<Musteri>();
            while (dr.Read())
            {
                Musteri musteri = new Musteri()
                {
                    MusteriID = Convert.ToInt32(dr["MusteriId"]),
                    MusteriAd = dr["MusteriAd"].ToString(),
                    MusteriSoyad = dr["MusteriSoyad"].ToString(),
                    MusteriSehir = dr["MusteriSehir"].ToString(),
                    MusteriTC = dr["MusteriTC"].ToString()
                };
                musteriler.Add(musteri);
            }

            _conn.BaglantiKapat();
            return musteriler;
        }
        public List<Musteri> SehirGetir()
        {
            _conn.BaglantiAc();
            SqlCommand command = new SqlCommand("SELECT * FROM Musteri", _conn.Conn);
            SqlDataReader dr = command.ExecuteReader();
            List<Musteri> musteriler = new List<Musteri>();
            while (dr.Read())
            {
                Musteri musteri = new Musteri()
                {
                    MusteriID = Convert.ToInt32(dr["MusteriId"]),
                    MusteriSehir = dr["MusteriSehir"].ToString(),

                };
                musteriler.Add(musteri);
            }

            _conn.BaglantiKapat();
            return musteriler;
        }

        public void MusteriEkle(Musteri musteri)
        {
            _conn.BaglantiAc();
            SqlCommand command = new SqlCommand("INSERT INTO Musteri values(@MusteriAd,@MusteriSoyad,@MusteriSehir,@MusteriTC)", _conn.Conn); //parametreleri productstan aldı
            command.Parameters.AddWithValue("@MusteriAd", musteri.MusteriAd);
            command.Parameters.AddWithValue("@MusteriSoyad", musteri.MusteriSoyad);
            command.Parameters.AddWithValue("@MusteriSehir", musteri.MusteriSehir);
            command.Parameters.AddWithValue("@MusteriTC", musteri.MusteriTC);
            command.ExecuteNonQuery();
            _conn.BaglantiKapat();
        }

        public void MusteriGuncelle(Musteri musteri)
        {
            _conn.BaglantiAc();
            SqlCommand command = new SqlCommand("UPDATE Musteri SET MusteriTC=@MusteriTC, MusteriAd=@MusteriAd, MusteriSoyad=@MusteriSoyad, MusteriSehir=@MusteriSehir WHERE MusteriID=@MusteriID", _conn.Conn);
            command.Parameters.AddWithValue("@MusteriTC", musteri.MusteriTC);
            command.Parameters.AddWithValue("@MusteriAd", musteri.MusteriAd);
            command.Parameters.AddWithValue("@MusteriSoyad", musteri.MusteriSoyad);
            command.Parameters.AddWithValue("@MusteriSehir", musteri.MusteriSehir);           
            command.Parameters.AddWithValue("@MusteriID", musteri.MusteriID);
            command.ExecuteNonQuery();
            _conn.BaglantiKapat();
        }

        public void MusteriSil(Musteri musteri)
        {
            _conn.BaglantiAc();
            SqlCommand command = new SqlCommand("Delete From Musteri WHERE MusteriID=@MusteriID", _conn.Conn);
            command.Parameters.AddWithValue("@MusteriID", musteri.MusteriID);
            command.ExecuteNonQuery();
            _conn.BaglantiKapat();
        }

        public Musteri MusteriAra(string musteriTC)
        {
            Musteri musteri = new Musteri();
            _conn.BaglantiAc();
            SqlCommand command = new SqlCommand("SELECT * FROM Musteri WHERE MusteriTC=@musteriTC ", _conn.Conn);
            
            command.Parameters.AddWithValue("@musteriTC", musteriTC);

            SqlDataReader dr = command.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                musteri.MusteriID = dr.GetInt32(0);
                musteri.MusteriAd = dr[1].ToString();
                musteri.MusteriSoyad = dr[2].ToString();
                musteri.MusteriSehir = dr[3].ToString();
                musteri.MusteriTC = dr[4].ToString();
            }
            else
                musteri.MusteriID = -1;

            _conn.BaglantiKapat();
            return musteri;
        }

        public Musteri SatisMusteriGetir(string musteriTC,string musteriAd, string musteriSoyad, string musteriSehir)
        {
            _conn.BaglantiAc();
            //Select MusteriID From dbo.Musteri where MusteriAd='Samed' and MusteriSoyad='Sargın' and MusteriSehir='Malatya'
            SqlCommand command = new SqlCommand("Select * From Musteri WHERE MusteriTC=@musteriTC AND MusteriAd=@musteriAd AND MusteriSoyad=@musteriSoyad AND MusteriSehir=@musteriSehir", _conn.Conn);
            command.Parameters.AddWithValue("@musteriTC", musteriTC);
            command.Parameters.AddWithValue("@musteriAd", musteriAd);
            command.Parameters.AddWithValue("@musteriSoyad", musteriSoyad);
            command.Parameters.AddWithValue("@musteriSehir", musteriSehir);
            
            command.ExecuteNonQuery();
            SqlDataReader dr = command.ExecuteReader();
            dr.Read();
            Musteri musteri = new Musteri();

            if (dr.HasRows)
            {

                musteri.MusteriID = Convert.ToInt32(dr["MusteriId"]);
                musteri.MusteriTC = dr["MusteriTC"].ToString();
                musteri.MusteriAd = dr["MusteriAd"].ToString();
                musteri.MusteriSoyad = dr["MusteriSoyad"].ToString();
                musteri.MusteriSehir = dr["MusteriSehir"].ToString();
            }

            _conn.BaglantiKapat();
            return musteri;
        }
    }
}