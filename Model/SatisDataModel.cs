using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmBeyazEsya.Model
{
    public class SatisDataModel
    {
        public int SatisID { get; set; }
        public int UrunID { get; set; }
        public int MusteriID { get; set; }

        public string MusteriTC { get; set; }

        public string MusteriAd { get; set; }
        public string MusteriSoyad { get; set; }
        public string MusteriSehir { get; set; }
        public string UrunAdi { get; set; }
        public decimal Fiyat { get; set; }
        public int Adet { get; set; }
        public DateTime SatisTarihi { get; set; }

    }
}
