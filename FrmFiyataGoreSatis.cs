using FrmBeyazEsya.DBManager;
using FrmBeyazEsya.Model;
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
    public partial class FrmFiyataGoreSatis : Form
    {
        public FrmFiyataGoreSatis()
        {
            InitializeComponent();
        }
        SatisDB _satisDB = new SatisDB();
        private void FiyataGoreSatis_Load(object sender, EventArgs e)
        {
            dgwFiyataGoreSatis.DataSource = _satisDB.FiyatAralik();
            GereksizGizle(); //Bu şekilde yapmasam model oluşturmak zorunda kalacaktım.
        }

        private void GereksizGizle()
        {
            dgwFiyataGoreSatis.Columns["SatisID"].Visible = false;
            dgwFiyataGoreSatis.Columns["UrunID"].Visible = false;
            dgwFiyataGoreSatis.Columns["MusteriID"].Visible = false;
            dgwFiyataGoreSatis.Columns["MusteriAd"].Visible = false;
            dgwFiyataGoreSatis.Columns["MusteriSoyad"].Visible = false;
            dgwFiyataGoreSatis.Columns["MusteriSehir"].Visible = false;
           
        }
    }
}
