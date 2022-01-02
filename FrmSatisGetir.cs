using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmBeyazEsya
{
    public partial class FrmSatisGetir : Form
    {
        public FrmSatisGetir()
        {
            InitializeComponent();
        }
        DBManager.SatisDB _satis = new DBManager.SatisDB();
        private void FrmSatisGetir_Load(object sender, EventArgs e)
        {
            dgwSatisGetir.DataSource = _satis.SatisGetir();
        }
    }
}
