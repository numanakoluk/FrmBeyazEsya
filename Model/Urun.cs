using FrmBeyazEsya.DBManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmBeyazEsya.Model
{
    public class Urun
    {
        public int UrunID { get; set; }
        public string UrunAd { get; set; }
        public int Stok { get; set; }
    }
}