using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winTodoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList veriler = new ArrayList();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // txtGorev içinde hiç karakter yoksa uyarı ver ve işlem iptal..
            if (string.IsNullOrEmpty(txtGorev.Text.Trim()))
            {
                // Text, title, buttons, icon, defaultbutton
                MessageBox.Show("Görev tanımı boş geçilemez..",
                    "Uyarı !",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Exclamation,
                      MessageBoxDefaultButton.Button1);

                // MessageBox'dan geriye tıklanılan butonu elde etme..
                // ========================================================================
                //DialogResult secim = MessageBox.Show("Gören tanımı boş geçilemez..",
                //    "Uyarı !",
                //     MessageBoxButtons.YesNoCancel,
                //     MessageBoxIcon.Exclamation,
                //      MessageBoxDefaultButton.Button2);

                //if(secim == DialogResult.Cancel)
                //{

                //}

                return;
            }

            bool yapildimi = false; // yapılacak anlamında olur.

            if (rdbYapildi.Checked)
            {
                yapildimi = true;   // yapıldı anlamında olur..
            }

            // Yeni görev nesnesi oluşturulur..
            Gorev gorev = new Gorev();
            gorev.GorevTanimi = txtGorev.Text;
            gorev.YapildiMi = yapildimi;

            veriler.Add(gorev);

            // CTRL + .
            Listele();
            Temizle();
        }

        private void Listele()
        {
            lstGorevler.Items.Clear();

            foreach (Gorev grv in veriler)
            {
                string gorevDurumu = "";

                // Uzun if bloğu..
                //if (grv.YapildiMi == true)
                //{
                //    gorevDurumu = "(Yapıldı)";
                //}
                //else
                //{
                //    gorevDurumu = "(Yapılacak)";
                //}

                // Tek satırda if bloğu..
                gorevDurumu = (grv.YapildiMi == true) ? "(Yapıldı)" : "(Yapılacak)";

                lstGorevler.Items.Add(grv.GorevTanimi + " " + gorevDurumu);

                if(veriler.Count > 0)
                {
                    mnuKaydet.Enabled = true;
                }
                else
                {
                    mnuKaydet.Enabled = false;
                }
            }
        }

        private void lstGorevler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstGorevler.SelectedIndex == -1)
            {
                Temizle();
                return;
            }

            // Seçili görev index'i bul..
            int index = lstGorevler.SelectedIndex;

            // ArrayList'den Gorev nesnesini elde et.
            Gorev grv = (Gorev)veriler[index];

            // Değerleri ekrana getir.
            txtGorev.Text = grv.GorevTanimi;
            rdbYapildi.Checked = grv.YapildiMi;
            rdbYapilacak.Checked = !grv.YapildiMi;

            //if(grv.YapildiMi)
            //{
            //    rdbYapildi.Checked = true;
            //}
        }

        private void Temizle()
        {
            txtGorev.Clear();
            rdbYapilacak.Checked = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstGorevler.SelectedIndex == -1)
            {
                // Text, title, buttons, icon, defaultbutton
                MessageBox.Show("Lütfen bir görev seçiniz.",
                    "Uyarı !",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Exclamation,
                      MessageBoxDefaultButton.Button1);
                return;
            }

            if (string.IsNullOrEmpty(txtGorev.Text.Trim()))
            {
                // Text, title, buttons, icon, defaultbutton
                MessageBox.Show("Görev tanımı boş geçilemez..",
                    "Uyarı !",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Exclamation,
                      MessageBoxDefaultButton.Button1);
                return;
            }

            // Seçili görev index'i bul..
            int index = lstGorevler.SelectedIndex;

            // ArrayList'den Gorev nesnesini elde et.
            Gorev grv = (Gorev)veriler[index];

            grv.GorevTanimi = txtGorev.Text;
            grv.YapildiMi = rdbYapildi.Checked;

            Listele();
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstGorevler.SelectedIndex == -1)
            {
                // Text, title, buttons, icon, defaultbutton
                MessageBox.Show("Lütfen bir görev seçiniz.",
                    "Uyarı !",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Exclamation,
                      MessageBoxDefaultButton.Button1);
                return;
            }

            // Seçili görev index'i bul..
            int index = lstGorevler.SelectedIndex;

            Gorev grv = (Gorev)veriler[index];

            DialogResult secim =
                MessageBox.Show(grv.GorevTanimi + " görevini silmek istediğinizden emin misiniz?", "Görev Silme",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            switch (secim)
            {
                case DialogResult.Cancel:
                    return;
                case DialogResult.Yes:

                    // ArrayList'den Gorev nesnesini elde et.
                    veriler.RemoveAt(index);

                    Listele();
                    Temizle();

                    break;
                case DialogResult.No:
                    return;
                default:
                    break;
            }

            
        }

        private void mnuCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuKaydet_Click(object sender, EventArgs e)
        {
            string[] yazilacakVeriler = new string[veriler.Count];
            int sayac = 0;

            foreach (Gorev grv in veriler)
            {
                string deger = grv.GorevTanimi + "|" + grv.YapildiMi;
                yazilacakVeriler[sayac] = deger;

                sayac++;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Görevleri Kaydetme";
            sfd.FileName = "gorevler.txt";
            sfd.Filter = "Metin Dosyası(*.txt)|*.txt";
            sfd.FilterIndex = 1;

            DialogResult secim = sfd.ShowDialog();

            if(secim == DialogResult.OK)
            {
                System.IO.File.WriteAllLines(sfd.FileName, yazilacakVeriler);

                MessageBox.Show("Veriler kaydedilmiştir.");
            }
            
        }

        private void mnuAc_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Görevler Açma";
            ofd.FileName = "gorevler.txt";
            ofd.Filter = "Metin Dosyası(*.txt)|*.txt";
            ofd.FilterIndex = 1;

            DialogResult secim = ofd.ShowDialog();

            if(secim == DialogResult.OK)
            {
                // Dosyadan veriler okunur..
                string[] okunanVeriler = System.IO.File.ReadAllLines(ofd.FileName);

                // ArrayList temizlenir..
                veriler.Clear();

                // Dosyadan okunan verilerde dönülür..
                foreach (string deger in okunanVeriler)
                {
                    // asssss|True örnek.
                    string[] degerler = deger.Split('|');

                    // Her satır için bir görev nesnesi oluşturuşur.
                    Gorev grv = new Gorev();
                    grv.GorevTanimi = degerler[0];
                    grv.YapildiMi = bool.Parse(degerler[1]);

                    // Gorev nesnesi ArrayList'e eklenir.
                    veriler.Add(grv);
                }

                Listele();
                Temizle();
            }
        }

        // Kapanmadan önce çalışan metot.
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult secim =
                MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Çıkış",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if(secim != DialogResult.Yes)
            {
                // Kapanma akışına girmiş olan uygulamanın kapanmasını iptal eder.
                e.Cancel = true;
            }
        }
    }
}
