using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wissen.SC501.Common.Tools;

namespace GecTakipHesapOtomasyonu
{
    /*
    http://www.ahmetcancicek.com/post/entity-framework-code-first-migration/
    */

    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private GecTakipHesapOtoDbContext db = new GecTakipHesapOtoDbContext();

        private void Saatler_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan girisTime = dtpGirisSaati.Value.TimeOfDay;
            TimeSpan gelisTime = dtpGelisSaati.Value.TimeOfDay;

            double minutes = GetMinutes(girisTime, gelisTime);

            decimal tutar = Math.Ceiling((decimal)minutes / 5);

            if (tutar > 10)
                tutar = 10m;

            txtTutar.Text = tutar.ToString();
        }

        private double GetMinutes(TimeSpan time1, TimeSpan time2)
        {
            TimeSpan fark = time2 - time1;
            double minutes = Math.Floor(fark.TotalMinutes);

            return minutes;
        }

        private void OgrencileriListele()
        {
            cmbOgrenciler.DataSource = db.Ogrenciler.ToList();
            cmbBaskan.DataSource = db.Ogrenciler.ToList();
        }

        private void GecikmeOdemeIsleme(bool odendimi)
        {
            if (dgvGecikmeler.CurrentRow != null)
            {
                Gecikme seciliGecikme = dgvGecikmeler.CurrentRow.DataBoundItem as Gecikme;

                seciliGecikme.OdendiMi = odendimi;

                if (db.SaveChanges() > 0)
                {
                    if (odendimi == false)
                    {
                        EMailGonder(seciliGecikme);
                    }

                    OgrenciGecikmeVerisiYukle();
                }

            }
        }

        private void BaskanOdemeIsleme(bool odendimi)
        {
            if (dgvBaskanOdemeleri.CurrentRow != null)
            {
                BaskanOdeme seciliOdeme =
                    dgvBaskanOdemeleri.CurrentRow.DataBoundItem as BaskanOdeme;

                seciliOdeme.OdendiMi = odendimi;

                if (db.SaveChanges() > 0)
                {
                    if (odendimi == false)
                    {
                        EMailGonder(seciliOdeme);
                    }

                    OgrenciBaskanOdemeVerisiYukle();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Varsayılan değerler
            dtpGirisSaati.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 9, 0, 0);
            dtpGelisSaati.Value = DateTime.Now;

            OgrencileriListele();
        }

        private void btnEkleGecikme_Click(object sender, EventArgs e)
        {
            if (cmbOgrenciler.SelectedIndex > -1)
            {
                Ogrenci secili = cmbOgrenciler.SelectedItem as Ogrenci;

                Gecikme gecikme = new Gecikme();
                gecikme.Tarih = dtpTarih.Value.Date;
                gecikme.GirisSaati = dtpGirisSaati.Value.TimeOfDay;
                gecikme.GelisSaati = dtpGelisSaati.Value.TimeOfDay;
                gecikme.Aciklama = txtAciklama.Text;
                gecikme.OdendiMi = chkOdendiMi.Checked;
                gecikme.Tutar = decimal.Parse(txtTutar.Text);

                gecikme.GirisSaati =
                    gecikme.GirisSaati.Add(new TimeSpan(0, 0, -1 * gecikme.GirisSaati.Seconds));

                gecikme.GelisSaati =
                    gecikme.GelisSaati.Add(new TimeSpan(0, 0, -1 * gecikme.GelisSaati.Seconds));

                gecikme.Ogrencisi = secili;
                gecikme.Ogrencisi.SonGecikmeTarihi = dtpTarih.Value.Date;

                db.Gecikmeler.Add(gecikme);

                if (db.SaveChanges() > 0)
                {
                    if (gecikme.OdendiMi == false)
                    {
                        EMailGonder(gecikme);
                    }

                    OgrenciGecikmeVerisiYukle();
                }

            }
        }

        private void EMailGonder(Gecikme gecikme)
        {
            string konu = "Gecikme Ceza Bildirimi";
            string format = "{0} tarihinde {1} dakika geç kaldığınız için {2} ₺ ceza ödemeniz gerekmektedir... \n\nCeza Bilgileri : \n\nAd : {3} \nSoyad : {4} \nAçıklama : {5} \nDers başlama saati : {6} \nGiriş saati : {7} \n\nTahsilata bekleriz..\nSaygılarımızla..\n\nWissen-SC-501";

            string mesaj =
                string.Format(format,
                    gecikme.Tarih.ToShortDateString(),
                    GetMinutes(gecikme.GirisSaati, gecikme.GelisSaati).ToString(),
                    gecikme.Tutar.ToString(),
                    gecikme.Ogrencisi.Ad,
                    gecikme.Ogrencisi.Soyad,
                    gecikme.Aciklama,
                    gecikme.GirisSaati.ToString(),
                    gecikme.GelisSaati.ToString());

            EMail mail = new EMail();
            mail.SendEMail(gecikme.Ogrencisi.EPosta, konu, mesaj, isBodyHtml: false);
        }

        private void EMailGonder(BaskanOdeme odeme)
        {
            string konu = "Haftalık Başkanlık Bedeli Ödemeniz";
            string format = "{0} isimli başkana görevinden dolayı {1} ₺ ödemeniz gerekmektedir... \n\n Bilgiler : \n\nAd : {2} \nSoyad : {3} \nBaşkan Adı : {4} \nBaşkan Soyadı : {5} \nTutar : {6} \n\nTahsilata bekleriz..\nSaygılarımızla..\n\nWissen-SC-501";

            string mesaj =
                string.Format(format,
                    odeme.Baskan.Ad + " " + odeme.Baskan.Soyad,
                    odeme.Tutar.ToString(),
                    odeme.Odeyen.Ad,
                    odeme.Odeyen.Soyad,
                    odeme.Baskan.Ad,
                    odeme.Baskan.Soyad,
                    odeme.Tutar.ToString());

            EMail mail = new EMail();
            mail.SendEMail(odeme.Odeyen.EPosta, konu, mesaj, isBodyHtml: false);
        }

        private void btnSilGecikme_Click(object sender, EventArgs e)
        {
            if (dgvGecikmeler.CurrentRow != null)
            {
                Gecikme seciliGecikme = dgvGecikmeler.CurrentRow.DataBoundItem as Gecikme;

                db.Gecikmeler.Remove(seciliGecikme);
                db.SaveChanges();

                OgrenciGecikmeVerisiYukle();
            }
        }

        private void cmbOgrenciler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOgrenciler.SelectedIndex > -1)
            {
                OgrenciGecikmeVerisiYukle();
                OgrenciBaskanOdemeVerisiYukle();
            }
            else
            {
                dgvGecikmeler.DataSource = null;
            }
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            frmOgrenci frm = new frmOgrenci();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                Ogrenci ogrenci = frm.OgrenciNesnesi;

                db.Ogrenciler.Add(ogrenci);
                db.SaveChanges();
            }

            OgrencileriListele();
        }

        private void btnOgrenciSil_Click(object sender, EventArgs e)
        {
            if (cmbOgrenciler.SelectedIndex > -1)
            {
                Ogrenci seciliOgr = cmbOgrenciler.SelectedItem as Ogrenci;

                // Öğrencinin gecikmeleri silinir.
                foreach (Gecikme gec in seciliOgr.Gecikmeleri.ToList())
                {
                    db.Gecikmeler.Remove(gec);
                }

                // Öğrenci silinir..
                db.Ogrenciler.Remove(seciliOgr);
                db.SaveChanges();   // İşlemler database'de uygulanır.

                OgrencileriListele();
            }
        }

        private void btnBaskanIcinOdemeEkle_Click(object sender, EventArgs e)
        {
            if (cmbBaskan.SelectedIndex > -1 && cmbOgrenciler.SelectedIndex > -1)
            {
                Ogrenci baskan = cmbBaskan.SelectedItem as Ogrenci;
                Ogrenci ogrenci = cmbOgrenciler.SelectedItem as Ogrenci;

                BaskanOdeme odeme = new BaskanOdeme()
                {
                    Baskan = baskan,
                    Odeyen = ogrenci,
                    Tutar = 5,
                    OdendiMi = false
                };

                db.BaskanOdemeler.Add(odeme);

                if (db.SaveChanges() > 0)
                {
                    EMailGonder(odeme);
                    OgrenciBaskanOdemeVerisiYukle();
                }

            }
        }

        private void OgrenciGecikmeVerisiYukle()
        {
            Ogrenci secili = cmbOgrenciler.SelectedItem as Ogrenci;

            dgvGecikmeler.DataSource =
                db.Gecikmeler.Where(x => x.Ogrencisi.Id == secili.Id).ToList();
        }

        private void OgrenciBaskanOdemeVerisiYukle()
        {
            Ogrenci secili = cmbOgrenciler.SelectedItem as Ogrenci;

            dgvBaskanOdemeleri.DataSource =
                db.BaskanOdemeler.Where(x => x.Odeyen.Id == secili.Id).ToList();
        }

        private void btnBaskanIcinOdemeSil_Click(object sender, EventArgs e)
        {
            if (dgvBaskanOdemeleri.CurrentRow != null)
            {
                BaskanOdeme seciliOdeme =
                    dgvBaskanOdemeleri.CurrentRow.DataBoundItem as BaskanOdeme;

                db.BaskanOdemeler.Remove(seciliOdeme);
                db.SaveChanges();

                OgrenciBaskanOdemeVerisiYukle();
            }
        }

        private void btnGecikmeOdendi_Click(object sender, EventArgs e)
        {
            GecikmeOdemeIsleme(true);
        }

        private void btnGecikmeOdenmedi_Click(object sender, EventArgs e)
        {
            GecikmeOdemeIsleme(false);
        }

        private void btnBaskanaOdendi_Click(object sender, EventArgs e)
        {
            BaskanOdemeIsleme(true);
        }

        private void btnBaskanaOdenmedi_Click(object sender, EventArgs e)
        {
            BaskanOdemeIsleme(false);
        }
    }
}
