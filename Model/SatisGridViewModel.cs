using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmBeyazEsya.Model
{
    public class SatisGridViewModel
    {
        public string MusteriAd { get; set; }
        public string MusteriSoyad { get; set; }
        public string MusteriSehir { get; set; }
        public string UrunAdi { get; set; }
        public decimal Fiyat { get; set; }
        public int Adet { get; set; }
        public decimal Toplam { get; set; }
        public DateTime SatisTarihi { get; set; }
    }
}
