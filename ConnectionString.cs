using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmBeyazEsya
{
    public class ConnectionString
    {

        public string ConString { get; set; }
        public SqlConnection Conn { get; set; }
        public ConnectionString()
        {
            ConString = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString.ToString();
        }
        public void BaglantiAc()
        {
            Conn = new SqlConnection(ConString);
            Conn.Open();

        }
        public void BaglantiKapat()
        {

            Conn.Close();
        }

    }
}
