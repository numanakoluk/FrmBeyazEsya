using FrmBeyazEsya.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace FrmBeyazEsya.DBManager
{
    public class MusteriDB
    {
        private SqlConnection _conn = new SqlConnection(@"Data Source=DESKTOP-DPB315I;Initial Catalog=DbNetworkProject;Integrated Security=True");

        public List<Musteri> MusteriGetir()
        {
            _conn.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Musteri", _conn);
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
                };
                musteriler.Add(musteri);
            }

            _conn.Close();
            return musteriler;
        }

        public void MusteriEkle(Musteri musteri)
        {
            _conn.Open();
            SqlCommand command = new SqlCommand("INSERT INTO Musteri values(@MusteriAd,@MusteriSoyad,@MusteriSehir)", _conn); //parametreleri productstan aldı
            command.Parameters.AddWithValue("@MusteriAd", musteri.MusteriAd);
            command.Parameters.AddWithValue("@MusteriSoyad", musteri.MusteriSoyad);
            command.Parameters.AddWithValue("@MusteriSehir", musteri.MusteriSehir);
            command.ExecuteNonQuery();
            _conn.Close();
        }

        public void MusteriGuncelle(Musteri musteri)
        {
            _conn.Open();
            SqlCommand command = new SqlCommand("UPDATE Musteri SET MusteriAd=@MusteriAd, MusteriSoyad=@MusteriSoyad, MusteriSehir=@MusteriSehir WHERE MusteriID=@MusteriID", _conn);
            command.Parameters.AddWithValue("@MusteriAd", musteri.MusteriAd);
            command.Parameters.AddWithValue("@MusteriSoyad", musteri.MusteriSoyad);
            command.Parameters.AddWithValue("@MusteriSehir", musteri.MusteriSehir);
            command.Parameters.AddWithValue("@MusteriID", musteri.MusteriID);
            command.ExecuteNonQuery();
            _conn.Close();
        }

        public void MusteriSil(Musteri musteri)
        {
            _conn.Open();
            SqlCommand command = new SqlCommand("Delete From Musteri WHERE MusteriID=@MusteriID", _conn);
            command.Parameters.AddWithValue("@MusteriID", musteri.MusteriID);
            command.ExecuteNonQuery();
            _conn.Close();
        }

        public Musteri MusteriAra(int musteriID)
        {
            Musteri musteri = new Musteri();

            SqlCommand command = new SqlCommand("SELECT * FROM Musteri WHERE MusteriID=@musteriID ", _conn);
            _conn.Open();
            command.Parameters.AddWithValue("@musteriID", musteriID);

            SqlDataReader dr = command.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                musteri.MusteriID = dr.GetInt32(0);
                musteri.MusteriAd = dr[1].ToString();
                musteri.MusteriSoyad = dr[2].ToString();
                musteri.MusteriSehir = dr[3].ToString();
            }
            else
                musteri.MusteriID = -1;

            _conn.Close();
            return musteri;
        }

        public Musteri SatisMusteriGetir(string musteriAd, string musteriSoyad, string musteriSehir)
        {
            _conn.Open();
            //Select MusteriID From dbo.Musteri where MusteriAd='Samed' and MusteriSoyad='Sargın' and MusteriSehir='Malatya'
            SqlCommand command = new SqlCommand("Select * From Musteri WHERE MusteriAd=@musteriAd AND MusteriSoyad=@musteriSoyad AND MusteriSehir=@musteriSehir", _conn);
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
                musteri.MusteriAd = dr["MusteriAd"].ToString();
                musteri.MusteriSoyad = dr["MusteriSoyad"].ToString();
                musteri.MusteriSehir = dr["MusteriSehir"].ToString();
            }

            _conn.Close();
            return musteri;
        }
    }
}