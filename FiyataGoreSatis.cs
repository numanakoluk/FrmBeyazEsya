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
    public partial class FiyataGoreSatis : Form
    {
        public FiyataGoreSatis()
        {
            InitializeComponent();
        }
        SatisDB _satisDB = new SatisDB();
        private void FiyataGoreSatis_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _satisDB.FiyatAralik();
            GereksizGizle(); //Bu şekilde yapmasam model oluşturmak zorunda kalacaktım.
        }

        private void GereksizGizle()
        {
            dataGridView1.Columns["SatisID"].Visible = false;
            dataGridView1.Columns["UrunID"].Visible = false;
            dataGridView1.Columns["MusteriID"].Visible = false;
            dataGridView1.Columns["MusteriAd"].Visible = false;
            dataGridView1.Columns["MusteriSoyad"].Visible = false;
            dataGridView1.Columns["MusteriSehir"].Visible = false;
            dataGridView1.Columns["Adet"].Visible = false;
        }
    }
}
