using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GecTakipHesapOtomasyonu
{
    public partial class frmOgrenci : Form
    {
        public Ogrenci OgrenciNesnesi { get; set; }

        public frmOgrenci()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(txtSoyad.Text))
            {
                MessageBox.Show("Öğrenci adı ya da soyadı boş geçilemez.");
                return;
            }

            this.OgrenciNesnesi = new Ogrenci();
            this.OgrenciNesnesi.Ad = txtAd.Text;
            this.OgrenciNesnesi.Soyad = txtSoyad.Text;
            this.OgrenciNesnesi.EPosta = txtEPosta.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
