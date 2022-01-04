using FrmBeyazEsya.DBManager;
using FrmBeyazEsya.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FrmBeyazEsya
{
    public partial class FrmBeyazEsya : Form
    {
        public FrmBeyazEsya()
        {
            InitializeComponent();
        }

        private SatisDB _satisDB = new SatisDB();
        private MusteriDB _musteriDB = new MusteriDB();
        private UrunDB _urunDB = new UrunDB();

        private void btnMusteriGetir_Click(object sender, EventArgs e)
        {
            dgwMusteriGetir.DataSource = _musteriDB.MusteriGetir();
            btnMusteriGuncelle.Enabled = true;
            btnMusteriSil.Enabled = true;
            //btnMusAra.Enabled = true;
        }

        
        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMusteriAd.Text)  || string.IsNullOrEmpty(txtMusteriSoyad.Text)  || string.IsNullOrEmpty(txtMusteriSehir.Text) || string.IsNullOrEmpty(mskAraMusteriTC.Text))
            {
                MessageBox.Show(Error.BoşAlanHata);
                
                
            }
            else
            {
                //MessageBox.Show(txtMusteriAd.Text);
                _musteriDB.MusteriEkle(new Model.Musteri
                {
                    
                    MusteriAd = txtMusteriAd.Text,
                    MusteriSoyad = txtMusteriSoyad.Text,
                    MusteriSehir = txtMusteriSehir.Text,
                    //MusteriTC = mskListeleMusteriTC.Text

                });
                MessageBox.Show("Müsteri Eklendi");
                dgwMusteriGetir.DataSource = _musteriDB.MusteriGetir();




            }
        }
        private void dgwUrunGetir_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Click gelince oluşacak eventler.
            txtGuncelleUrun.Text = dgwUrunGetir.CurrentRow.Cells[1].Value.ToString();
            txtGuncelleStok.Text = dgwUrunGetir.CurrentRow.Cells[2].Value.ToString();
            //        
            txtSatisUrunAdi.Text = dgwUrunGetir.CurrentRow.Cells[1].Value.ToString();
            //Urun Görünürlüğü
            txtGuncelleUrun.Enabled = true;
            txtGuncelleStok.Enabled = true;
            btnUrunGuncelle.Enabled = true;
            btnUrunSil.Enabled = true;
            txtUrunAd.Enabled = false;
            txtUrunStok.Enabled = false;
            btnUrunEkle.Enabled = false;

        }
        private void dgwMusteriGetir_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMusteriAdGuncelle.Text = dgwMusteriGetir.CurrentRow.Cells[1].Value.ToString();
            txtMusteriSoyadGuncelle.Text = dgwMusteriGetir.CurrentRow.Cells[2].Value.ToString();
            txtMusteriSehirGuncelle.Text = dgwMusteriGetir.CurrentRow.Cells[3].Value.ToString();
            mskMusteriTCGuncelle.Text = dgwMusteriGetir.CurrentRow.Cells[4].Value.ToString();
            ///
            txtSatisMusteriAd.Text = dgwMusteriGetir.CurrentRow.Cells[1].Value.ToString();
            txtSatisSoyad.Text = dgwMusteriGetir.CurrentRow.Cells[2].Value.ToString();
            txtSatisSehir.Text = dgwMusteriGetir.CurrentRow.Cells[3].Value.ToString();
            mskSatisMusteriTC.Text = dgwMusteriGetir.CurrentRow.Cells[4].Value.ToString();

            //CELCLİCK EVENT GERÇEKLEŞTİĞİNDE
            txtMusteriAdGuncelle.Enabled = true;
            txtMusteriSoyadGuncelle.Enabled = true;
            txtMusteriSehirGuncelle.Enabled = true;
            mskMusteriTCGuncelle.Enabled = true;
            btnMusteriGuncelle.Enabled = true;
            btnMusteriSil.Enabled = true;

            txtMusteriAd.Enabled = false;
            txtMusteriSoyad.Enabled = false;
            txtMusteriSehir.Enabled = false;
            mskListeleMusteriTC.Enabled = false;
            btnMusteriEkle.Enabled = false;

        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri
            {
                MusteriID = Convert.ToInt32(dgwMusteriGetir.CurrentRow.Cells[0].Value),
                
                MusteriAd = txtMusteriAdGuncelle.Text,
                MusteriSoyad = txtMusteriSoyadGuncelle.Text,
                MusteriSehir = txtMusteriSehirGuncelle.Text,
                MusteriTC = mskMusteriTCGuncelle.Text,

            };
            _musteriDB.MusteriGuncelle(musteri);
            dgwMusteriGetir.DataSource = _musteriDB.MusteriGetir();
            MessageBox.Show("Müşteri Güncellendi.");
        }

        private void btnMusteriAra_Click(object sender, EventArgs e)
        {
            Musteri musteri = _musteriDB.MusteriAra(mskAraMusteriTC.Text);

            if (musteri.MusteriID != -1)
            {
                MessageBox.Show("Müsteri ID:" + musteri.MusteriID + " " + "Musteri Bilgileri:" + musteri.MusteriAd + " " + musteri.MusteriSoyad + " " + musteri.MusteriSehir + "  " + " " + musteri.MusteriTC,"BİLGİ");
             
            }
            else
            {
                MessageBox.Show("Müşteri Bulunamadı");
            }
        }

        private void btnMusteriSil_Click_1(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri
            {
                MusteriID = Convert.ToInt32(dgwMusteriGetir.CurrentRow.Cells[0].Value),
            };
            _musteriDB.MusteriSil(musteri);

            dgwMusteriGetir.DataSource = _musteriDB.MusteriGetir();
            MessageBox.Show("Müsteri Silindi");
        }

        private void btnUrunGetir_Click(object sender, EventArgs e)
        {
            dgwUrunGetir.DataSource = _urunDB.TumUrunleriGetir();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUrunAd.Text) || string.IsNullOrEmpty(txtUrunStok.Text))

                MessageBox.Show(Error.BoşAlanHata);
            else
            {
                {


                    _urunDB.UrunEkle(new Model.Urun
                    {

                        UrunAd = txtUrunAd.Text,
                        Stok = Convert.ToInt32(txtUrunStok.Text)
                    });
                    MessageBox.Show("Urun Eklendi");
                    dgwUrunGetir.DataSource = _urunDB.TumUrunleriGetir();
                }
            }
           

        }

        

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun
            {
                UrunID = Convert.ToInt32(dgwUrunGetir.CurrentRow.Cells[0].Value),
            };
            _urunDB.UrunSil(urun);

            dgwUrunGetir.DataSource = _urunDB.TumUrunleriGetir();
            MessageBox.Show("Ürün Silindi");
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun
            {
                UrunID = Convert.ToInt32(dgwUrunGetir.CurrentRow.Cells[0].Value),
                UrunAd = txtGuncelleUrun.Text,
                Stok = Convert.ToInt32(txtGuncelleStok.Text)
            };
            _urunDB.UrunGuncelle(urun);
            dgwUrunGetir.DataSource = _urunDB.TumUrunleriGetir();
            MessageBox.Show("Ürün Güncellendi.");
        }
        private void btnUrunAra_Click(object sender, EventArgs e)
        {
            Urun urun = _urunDB.UrunAra(txtUrunAdiAra.Text);

            if (urun.UrunID != -1)
            {
                MessageBox.Show("Urun ID:" + urun.UrunID + " " + "Ürün Bilgileri:" + urun.UrunAd + " " + urun.Stok + "BİLGİ");
            }
            else
            {
                MessageBox.Show("Ürün Bulunamadı");
            }
        }


        private void btnStokUyarı_Click(object sender, EventArgs e)
        {
            FrmStokBilgiGetir frmStok = new FrmStokBilgiGetir();
            frmStok.Show();
        }

        private void btnSatisListele_Click(object sender, EventArgs e)
        {
            FrmSatisGetir fr = new FrmSatisGetir();
            fr.Show();
        }

        private void btnSatisEkle_Click(object sender, EventArgs e)
        {
            SatisDataModel model = new SatisDataModel();
            model.MusteriTC = mskSatisMusteriTC.Text;
            model.MusteriAd = txtSatisMusteriAd.Text;
            model.MusteriSoyad = txtSatisSoyad.Text;
            model.MusteriSehir = txtSatisSehir.Text;
            model.UrunAdi = txtSatisUrunAdi.Text;
            model.Fiyat = Convert.ToDecimal(txstSatısFiyat.Text);
            model.Adet = Convert.ToInt32(txtSatisAdet.Text);
            model.SatisTarihi = DateTime.Now;//Convert.ToDateTime(maskedTextBox1.Text);

            Musteri musteri = _musteriDB.SatisMusteriGetir(mskSatisMusteriTC.Text, txtSatisMusteriAd.Text, txtSatisSoyad.Text, txtSatisSehir.Text);
            if (musteri.MusteriID == 0)//Kayıt bulamazsa id default 0 geliyor
            {
                MessageBox.Show("Musteri Bulunamadı");
                return;
            }

            Urun urun = _urunDB.UrunSatisGetir(txtSatisUrunAdi.Text);
            if (urun.UrunID == 0)//Kayıt bulamazsa id default 0 geliyor
            {
                MessageBox.Show("Ürün Bulunamadı");
                return;
            }

            model.UrunID = urun.UrunID;

            model.MusteriID = musteri.MusteriID;

            if (urun.Stok < model.Adet) //Stok Konrol,
            {
                MessageBox.Show("Urun yeterli miktarda değil.");
                return;
            }
            else
            {
                _satisDB.SatisEkle(model);
                _urunDB.UrunStokAzalt(model.UrunID, urun.Stok - model.Adet);
                MessageBox.Show("Satış Yapıldı.");
            }
        }

        private void FrmBeyazEsya_Load(object sender, EventArgs e)
        {
            

            dgwUrunGetir.DataSource = _urunDB.TumUrunleriGetir();
            dgwMusteriGetir.DataSource = _musteriDB.MusteriGetir();


            //Form Load olduğunda  Musteri İçin.
            txtMusteriAdGuncelle.Enabled = false;
            txtMusteriSoyadGuncelle.Enabled = false;
            txtMusteriSehirGuncelle.Enabled = false;
            mskMusteriTCGuncelle.Enabled = false;
            btnMusteriGuncelle.Enabled = false;
            btnMusteriSil.Enabled = false;

            //Form Load olduğunda Ürün için.
            txtGuncelleUrun.Enabled = false;
            txtGuncelleStok.Enabled = false;
            btnUrunGuncelle.Enabled = false;
            btnUrunSil.Enabled = false;

        }

        private void btnFiyataGoreSatis_Click(object sender, EventArgs e)
        {
            FrmFiyataGoreSatis frmFiyat = new FrmFiyataGoreSatis();
            frmFiyat.Show();

        }

        
    }
}