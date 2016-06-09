namespace GecTakipHesapOtomasyonu
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmnuOgrenci = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnEkleOgrenci = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSilOgrenci = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEkleGecikme = new MetroFramework.Controls.MetroButton();
            this.txtAciklama = new MetroFramework.Controls.MetroTextBox();
            this.dtpGelisSaati = new MetroFramework.Controls.MetroDateTime();
            this.label3 = new MetroFramework.Controls.MetroLabel();
            this.dtpGirisSaati = new MetroFramework.Controls.MetroDateTime();
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.dtpTarih = new MetroFramework.Controls.MetroDateTime();
            this.label5 = new MetroFramework.Controls.MetroLabel();
            this.label4 = new MetroFramework.Controls.MetroLabel();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.cmnuGecikme = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnSilGecikme = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGecikmeOdendi = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGecikmeOdenmedi = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbOgrenciler = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dgvGecikmeler = new MetroFramework.Controls.MetroGrid();
            this.btnOgrenciEkle = new MetroFramework.Controls.MetroButton();
            this.btnOgrenciSil = new MetroFramework.Controls.MetroButton();
            this.chkOdendiMi = new MetroFramework.Controls.MetroCheckBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.btnBaskanIcinOdemeSil = new MetroFramework.Controls.MetroButton();
            this.btnBaskanIcinOdemeEkle = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cmbBaskan = new MetroFramework.Controls.MetroComboBox();
            this.dgvBaskanOdemeleri = new MetroFramework.Controls.MetroGrid();
            this.txtTutar = new MetroFramework.Controls.MetroTextBox();
            this.cmnuBaskanOdeme = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBaskanaOdendi = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBaskanaOdenmedi = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuOgrenci.SuspendLayout();
            this.cmnuGecikme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGecikmeler)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaskanOdemeleri)).BeginInit();
            this.cmnuBaskanOdeme.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmnuOgrenci
            // 
            this.cmnuOgrenci.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEkleOgrenci,
            this.btnSilOgrenci});
            this.cmnuOgrenci.Name = "cmnuOgrenci";
            this.cmnuOgrenci.Size = new System.Drawing.Size(141, 48);
            // 
            // btnEkleOgrenci
            // 
            this.btnEkleOgrenci.Name = "btnEkleOgrenci";
            this.btnEkleOgrenci.Size = new System.Drawing.Size(140, 22);
            this.btnEkleOgrenci.Text = "Öğrenci Ekle";
            this.btnEkleOgrenci.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // btnSilOgrenci
            // 
            this.btnSilOgrenci.Name = "btnSilOgrenci";
            this.btnSilOgrenci.Size = new System.Drawing.Size(140, 22);
            this.btnSilOgrenci.Text = "Öğrenci Sil";
            this.btnSilOgrenci.Click += new System.EventHandler(this.btnOgrenciSil_Click);
            // 
            // btnEkleGecikme
            // 
            this.btnEkleGecikme.Location = new System.Drawing.Point(384, 256);
            this.btnEkleGecikme.Name = "btnEkleGecikme";
            this.btnEkleGecikme.Size = new System.Drawing.Size(75, 23);
            this.btnEkleGecikme.TabIndex = 4;
            this.btnEkleGecikme.Text = "Ekle";
            this.btnEkleGecikme.UseSelectable = true;
            this.btnEkleGecikme.Click += new System.EventHandler(this.btnEkleGecikme_Click);
            // 
            // txtAciklama
            // 
            // 
            // 
            // 
            this.txtAciklama.CustomButton.Image = null;
            this.txtAciklama.CustomButton.Location = new System.Drawing.Point(308, 1);
            this.txtAciklama.CustomButton.Name = "";
            this.txtAciklama.CustomButton.Size = new System.Drawing.Size(43, 43);
            this.txtAciklama.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAciklama.CustomButton.TabIndex = 1;
            this.txtAciklama.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAciklama.CustomButton.UseSelectable = true;
            this.txtAciklama.CustomButton.Visible = false;
            this.txtAciklama.Lines = new string[0];
            this.txtAciklama.Location = new System.Drawing.Point(107, 205);
            this.txtAciklama.MaxLength = 32767;
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.PasswordChar = '\0';
            this.txtAciklama.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAciklama.SelectedText = "";
            this.txtAciklama.SelectionLength = 0;
            this.txtAciklama.SelectionStart = 0;
            this.txtAciklama.Size = new System.Drawing.Size(352, 45);
            this.txtAciklama.TabIndex = 3;
            this.txtAciklama.UseSelectable = true;
            this.txtAciklama.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAciklama.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dtpGelisSaati
            // 
            this.dtpGelisSaati.CustomFormat = "HH:mm";
            this.dtpGelisSaati.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGelisSaati.Location = new System.Drawing.Point(349, 170);
            this.dtpGelisSaati.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpGelisSaati.Name = "dtpGelisSaati";
            this.dtpGelisSaati.Size = new System.Drawing.Size(110, 29);
            this.dtpGelisSaati.TabIndex = 1;
            this.dtpGelisSaati.ValueChanged += new System.EventHandler(this.Saatler_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Geliş Saati :";
            // 
            // dtpGirisSaati
            // 
            this.dtpGirisSaati.CustomFormat = "HH:mm";
            this.dtpGirisSaati.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGirisSaati.Location = new System.Drawing.Point(349, 135);
            this.dtpGirisSaati.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpGirisSaati.Name = "dtpGirisSaati";
            this.dtpGirisSaati.Size = new System.Drawing.Size(110, 29);
            this.dtpGirisSaati.TabIndex = 1;
            this.dtpGirisSaati.ValueChanged += new System.EventHandler(this.Saatler_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giriş Saati :";
            // 
            // dtpTarih
            // 
            this.dtpTarih.CustomFormat = "dd.MM.yyyy";
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTarih.Location = new System.Drawing.Point(107, 135);
            this.dtpTarih.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(119, 29);
            this.dtpTarih.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Açıklama :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tutar :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarih :";
            // 
            // cmnuGecikme
            // 
            this.cmnuGecikme.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSilGecikme,
            this.ödemeToolStripMenuItem});
            this.cmnuGecikme.Name = "cmnuGecikme";
            this.cmnuGecikme.Size = new System.Drawing.Size(114, 48);
            // 
            // btnSilGecikme
            // 
            this.btnSilGecikme.Name = "btnSilGecikme";
            this.btnSilGecikme.Size = new System.Drawing.Size(113, 22);
            this.btnSilGecikme.Text = "Sil";
            this.btnSilGecikme.Click += new System.EventHandler(this.btnSilGecikme_Click);
            // 
            // ödemeToolStripMenuItem
            // 
            this.ödemeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGecikmeOdendi,
            this.btnGecikmeOdenmedi});
            this.ödemeToolStripMenuItem.Name = "ödemeToolStripMenuItem";
            this.ödemeToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.ödemeToolStripMenuItem.Text = "Ödeme";
            // 
            // btnGecikmeOdendi
            // 
            this.btnGecikmeOdendi.Name = "btnGecikmeOdendi";
            this.btnGecikmeOdendi.Size = new System.Drawing.Size(153, 22);
            this.btnGecikmeOdendi.Text = "Odendi Yap";
            this.btnGecikmeOdendi.Click += new System.EventHandler(this.btnGecikmeOdendi_Click);
            // 
            // btnGecikmeOdenmedi
            // 
            this.btnGecikmeOdenmedi.Name = "btnGecikmeOdenmedi";
            this.btnGecikmeOdenmedi.Size = new System.Drawing.Size(153, 22);
            this.btnGecikmeOdenmedi.Text = "Odenmedi Yap";
            this.btnGecikmeOdenmedi.Click += new System.EventHandler(this.btnGecikmeOdenmedi_Click);
            // 
            // cmbOgrenciler
            // 
            this.cmbOgrenciler.ContextMenuStrip = this.cmnuOgrenci;
            this.cmbOgrenciler.FormattingEnabled = true;
            this.cmbOgrenciler.ItemHeight = 23;
            this.cmbOgrenciler.Location = new System.Drawing.Point(107, 78);
            this.cmbOgrenciler.Name = "cmbOgrenciler";
            this.cmbOgrenciler.Size = new System.Drawing.Size(256, 29);
            this.cmbOgrenciler.TabIndex = 3;
            this.cmbOgrenciler.UseSelectable = true;
            this.cmbOgrenciler.SelectedIndexChanged += new System.EventHandler(this.cmbOgrenciler_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 83);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(78, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Öğrenciler :";
            // 
            // dgvGecikmeler
            // 
            this.dgvGecikmeler.AllowUserToAddRows = false;
            this.dgvGecikmeler.AllowUserToDeleteRows = false;
            this.dgvGecikmeler.AllowUserToResizeRows = false;
            this.dgvGecikmeler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvGecikmeler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGecikmeler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvGecikmeler.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGecikmeler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGecikmeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGecikmeler.ContextMenuStrip = this.cmnuGecikme;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGecikmeler.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGecikmeler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGecikmeler.EnableHeadersVisualStyles = false;
            this.dgvGecikmeler.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvGecikmeler.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvGecikmeler.Location = new System.Drawing.Point(0, 0);
            this.dgvGecikmeler.Name = "dgvGecikmeler";
            this.dgvGecikmeler.ReadOnly = true;
            this.dgvGecikmeler.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGecikmeler.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGecikmeler.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvGecikmeler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGecikmeler.Size = new System.Drawing.Size(426, 142);
            this.dgvGecikmeler.TabIndex = 0;
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.Location = new System.Drawing.Point(369, 78);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(42, 29);
            this.btnOgrenciEkle.TabIndex = 5;
            this.btnOgrenciEkle.Text = "Ekle";
            this.btnOgrenciEkle.UseSelectable = true;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // btnOgrenciSil
            // 
            this.btnOgrenciSil.Location = new System.Drawing.Point(417, 78);
            this.btnOgrenciSil.Name = "btnOgrenciSil";
            this.btnOgrenciSil.Size = new System.Drawing.Size(42, 29);
            this.btnOgrenciSil.TabIndex = 6;
            this.btnOgrenciSil.Text = "Sil";
            this.btnOgrenciSil.UseSelectable = true;
            this.btnOgrenciSil.Click += new System.EventHandler(this.btnOgrenciSil_Click);
            // 
            // chkOdendiMi
            // 
            this.chkOdendiMi.AutoSize = true;
            this.chkOdendiMi.Location = new System.Drawing.Point(107, 256);
            this.chkOdendiMi.Name = "chkOdendiMi";
            this.chkOdendiMi.Size = new System.Drawing.Size(79, 15);
            this.chkOdendiMi.TabIndex = 8;
            this.chkOdendiMi.Text = "Ödendi Mi";
            this.chkOdendiMi.UseSelectable = true;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(38, 285);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(434, 184);
            this.metroTabControl1.TabIndex = 9;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.dgvGecikmeler);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 8;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(426, 142);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Gecikme Ücretleri";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 9;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.btnBaskanIcinOdemeSil);
            this.metroTabPage2.Controls.Add(this.btnBaskanIcinOdemeEkle);
            this.metroTabPage2.Controls.Add(this.metroLabel2);
            this.metroTabPage2.Controls.Add(this.cmbBaskan);
            this.metroTabPage2.Controls.Add(this.dgvBaskanOdemeleri);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 8;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(426, 142);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Başkan Ücretleri";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 9;
            // 
            // btnBaskanIcinOdemeSil
            // 
            this.btnBaskanIcinOdemeSil.Location = new System.Drawing.Point(375, 4);
            this.btnBaskanIcinOdemeSil.Name = "btnBaskanIcinOdemeSil";
            this.btnBaskanIcinOdemeSil.Size = new System.Drawing.Size(42, 29);
            this.btnBaskanIcinOdemeSil.TabIndex = 6;
            this.btnBaskanIcinOdemeSil.Text = "Sil";
            this.btnBaskanIcinOdemeSil.UseSelectable = true;
            this.btnBaskanIcinOdemeSil.Click += new System.EventHandler(this.btnBaskanIcinOdemeSil_Click);
            // 
            // btnBaskanIcinOdemeEkle
            // 
            this.btnBaskanIcinOdemeEkle.Location = new System.Drawing.Point(327, 3);
            this.btnBaskanIcinOdemeEkle.Name = "btnBaskanIcinOdemeEkle";
            this.btnBaskanIcinOdemeEkle.Size = new System.Drawing.Size(42, 29);
            this.btnBaskanIcinOdemeEkle.TabIndex = 6;
            this.btnBaskanIcinOdemeEkle.Text = "Ekle";
            this.btnBaskanIcinOdemeEkle.UseSelectable = true;
            this.btnBaskanIcinOdemeEkle.Click += new System.EventHandler(this.btnBaskanIcinOdemeEkle_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 8);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(56, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Başkan :";
            // 
            // cmbBaskan
            // 
            this.cmbBaskan.FormattingEnabled = true;
            this.cmbBaskan.ItemHeight = 23;
            this.cmbBaskan.Location = new System.Drawing.Point(65, 4);
            this.cmbBaskan.Name = "cmbBaskan";
            this.cmbBaskan.Size = new System.Drawing.Size(256, 29);
            this.cmbBaskan.TabIndex = 3;
            this.cmbBaskan.UseSelectable = true;
            // 
            // dgvBaskanOdemeleri
            // 
            this.dgvBaskanOdemeleri.AllowUserToAddRows = false;
            this.dgvBaskanOdemeleri.AllowUserToDeleteRows = false;
            this.dgvBaskanOdemeleri.AllowUserToResizeRows = false;
            this.dgvBaskanOdemeleri.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBaskanOdemeleri.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvBaskanOdemeleri.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBaskanOdemeleri.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvBaskanOdemeleri.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBaskanOdemeleri.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBaskanOdemeleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaskanOdemeleri.ContextMenuStrip = this.cmnuBaskanOdeme;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBaskanOdemeleri.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBaskanOdemeleri.EnableHeadersVisualStyles = false;
            this.dgvBaskanOdemeleri.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvBaskanOdemeleri.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvBaskanOdemeleri.Location = new System.Drawing.Point(3, 41);
            this.dgvBaskanOdemeleri.Name = "dgvBaskanOdemeleri";
            this.dgvBaskanOdemeleri.ReadOnly = true;
            this.dgvBaskanOdemeleri.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBaskanOdemeleri.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBaskanOdemeleri.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBaskanOdemeleri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBaskanOdemeleri.Size = new System.Drawing.Size(410, 105);
            this.dgvBaskanOdemeleri.TabIndex = 2;
            // 
            // txtTutar
            // 
            // 
            // 
            // 
            this.txtTutar.CustomButton.Image = null;
            this.txtTutar.CustomButton.Location = new System.Drawing.Point(91, 1);
            this.txtTutar.CustomButton.Name = "";
            this.txtTutar.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtTutar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTutar.CustomButton.TabIndex = 1;
            this.txtTutar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTutar.CustomButton.UseSelectable = true;
            this.txtTutar.CustomButton.Visible = false;
            this.txtTutar.DisplayIcon = true;
            this.txtTutar.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTutar.ForeColor = System.Drawing.Color.Red;
            this.txtTutar.Icon = global::GecTakipHesapOtomasyonu.Properties.Resources.turkish_lira_sign_forex_symbol_currency_16;
            this.txtTutar.Lines = new string[] {
        "0,00"};
            this.txtTutar.Location = new System.Drawing.Point(107, 170);
            this.txtTutar.MaxLength = 32767;
            this.txtTutar.Multiline = true;
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.PasswordChar = '\0';
            this.txtTutar.ReadOnly = true;
            this.txtTutar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTutar.SelectedText = "";
            this.txtTutar.SelectionLength = 0;
            this.txtTutar.SelectionStart = 0;
            this.txtTutar.Size = new System.Drawing.Size(119, 29);
            this.txtTutar.TabIndex = 7;
            this.txtTutar.Text = "0,00";
            this.txtTutar.UseSelectable = true;
            this.txtTutar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTutar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmnuBaskanOdeme
            // 
            this.cmnuBaskanOdeme.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.cmnuBaskanOdeme.Name = "cmnuBaskanOdeme";
            this.cmnuBaskanOdeme.Size = new System.Drawing.Size(114, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBaskanaOdendi,
            this.btnBaskanaOdenmedi});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItem1.Text = "Odeme";
            // 
            // btnBaskanaOdendi
            // 
            this.btnBaskanaOdendi.Name = "btnBaskanaOdendi";
            this.btnBaskanaOdendi.Size = new System.Drawing.Size(153, 22);
            this.btnBaskanaOdendi.Text = "Ödendi Yap";
            this.btnBaskanaOdendi.Click += new System.EventHandler(this.btnBaskanaOdendi_Click);
            // 
            // btnBaskanaOdenmedi
            // 
            this.btnBaskanaOdenmedi.Name = "btnBaskanaOdenmedi";
            this.btnBaskanaOdenmedi.Size = new System.Drawing.Size(153, 22);
            this.btnBaskanaOdenmedi.Text = "Ödenmedi Yap";
            this.btnBaskanaOdenmedi.Click += new System.EventHandler(this.btnBaskanaOdenmedi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 480);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.chkOdendiMi);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.btnOgrenciSil);
            this.Controls.Add(this.btnOgrenciEkle);
            this.Controls.Add(this.btnEkleGecikme);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.cmbOgrenciler);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpGelisSaati);
            this.Controls.Add(this.dtpGirisSaati);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Geç Takip Hesap Otomasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cmnuOgrenci.ResumeLayout(false);
            this.cmnuGecikme.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGecikmeler)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaskanOdemeleri)).EndInit();
            this.cmnuBaskanOdeme.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroDateTime dtpGelisSaati;
        private MetroFramework.Controls.MetroLabel label3;
        private MetroFramework.Controls.MetroDateTime dtpGirisSaati;
        private MetroFramework.Controls.MetroLabel label2;
        private MetroFramework.Controls.MetroDateTime dtpTarih;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroLabel label4;
        private MetroFramework.Controls.MetroTextBox txtAciklama;
        private MetroFramework.Controls.MetroLabel label5;
        private MetroFramework.Controls.MetroButton btnEkleGecikme;
        private System.Windows.Forms.ContextMenuStrip cmnuGecikme;
        private System.Windows.Forms.ToolStripMenuItem btnSilGecikme;
        private System.Windows.Forms.ContextMenuStrip cmnuOgrenci;
        private System.Windows.Forms.ToolStripMenuItem btnEkleOgrenci;
        private System.Windows.Forms.ToolStripMenuItem btnSilOgrenci;
        private MetroFramework.Controls.MetroComboBox cmbOgrenciler;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid dgvGecikmeler;
        private MetroFramework.Controls.MetroButton btnOgrenciEkle;
        private MetroFramework.Controls.MetroButton btnOgrenciSil;
        private MetroFramework.Controls.MetroTextBox txtTutar;
        private MetroFramework.Controls.MetroCheckBox chkOdendiMi;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroGrid dgvBaskanOdemeleri;
        private MetroFramework.Controls.MetroButton btnBaskanIcinOdemeSil;
        private MetroFramework.Controls.MetroButton btnBaskanIcinOdemeEkle;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cmbBaskan;
        private System.Windows.Forms.ToolStripMenuItem ödemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnGecikmeOdendi;
        private System.Windows.Forms.ToolStripMenuItem btnGecikmeOdenmedi;
        private MetroFramework.Controls.MetroContextMenu cmnuBaskanOdeme;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btnBaskanaOdendi;
        private System.Windows.Forms.ToolStripMenuItem btnBaskanaOdenmedi;
    }
}

