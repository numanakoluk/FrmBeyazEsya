using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmBeyazEsya
{
    class ConnectionApp
    {
        public string ConnString { get; set; }
        public SqlConnection Conn { get; set; }

        public ConnectionApp()
        {
            ConnString = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
        }

        public void BaglantiAc()
        {
            Conn = new SqlConnection(ConnString);
            Conn.Open();
        }
        public void BaglantiKapat()
        {
            Conn = new SqlConnection(ConnString);
            Conn.Close();
        }


    }
   
}
