using FrmBeyazEsya.DBManager;
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
    public partial class FrmStokBilgiGetir : Form
    {
        UrunDB _urunDB = new UrunDB();
        public FrmStokBilgiGetir()
        {
            InitializeComponent();
        }

        private void FrmStokBilgiGetir_Load(object sender, EventArgs e)
        {
            dgwStokBilgi.DataSource = _urunDB.StokDurumu();
        }

    }
}
