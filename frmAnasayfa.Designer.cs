namespace StokTakip
{
    partial class frmAnasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnasayfa));
            this.ssBilgi = new System.Windows.Forms.StatusStrip();
            this.tssDovizDolar = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssDovizEuro = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssDovizPound = new System.Windows.Forms.ToolStripStatusLabel();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiUrunler = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUrunYonetimi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStokListe = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFirmaMusteri = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFirmaYonetimi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMusteriYonetimi = new System.Windows.Forms.ToolStripMenuItem();
            this.alımSatımİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAlisYonetimi = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSatisYonetimi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMuhasebeHareketleri = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiParaIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiParaAl = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiParaVer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFaturaIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFaturaYazdir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAyarlar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDovizKurlari = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSifreDegistir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTestUrunImport = new System.Windows.Forms.ToolStripMenuItem();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tsmiRaporlar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSatisRaporu = new System.Windows.Forms.ToolStripMenuItem();
            this.ssBilgi.SuspendLayout();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssBilgi
            // 
            this.ssBilgi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssDovizDolar,
            this.tssDovizEuro,
            this.tssDovizPound});
            this.ssBilgi.Location = new System.Drawing.Point(0, 330);
            this.ssBilgi.Name = "ssBilgi";
            this.ssBilgi.Size = new System.Drawing.Size(822, 24);
            this.ssBilgi.TabIndex = 5;
            this.ssBilgi.Text = "statusStrip1";
            // 
            // tssDovizDolar
            // 
            this.tssDovizDolar.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tssDovizDolar.Name = "tssDovizDolar";
            this.tssDovizDolar.Size = new System.Drawing.Size(122, 19);
            this.tssDovizDolar.Text = "toolStripStatusLabel1";
            // 
            // tssDovizEuro
            // 
            this.tssDovizEuro.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tssDovizEuro.Name = "tssDovizEuro";
            this.tssDovizEuro.Size = new System.Drawing.Size(122, 19);
            this.tssDovizEuro.Text = "toolStripStatusLabel1";
            // 
            // tssDovizPound
            // 
            this.tssDovizPound.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tssDovizPound.Name = "tssDovizPound";
            this.tssDovizPound.Size = new System.Drawing.Size(122, 19);
            this.tssDovizPound.Text = "toolStripStatusLabel1";
            this.tssDovizPound.Visible = false;
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUrunler,
            this.tsmiFirmaMusteri,
            this.alımSatımİşlemleriToolStripMenuItem,
            this.tsmiParaIslemleri,
            this.tsmiFaturaIslemleri,
            this.tsmiAyarlar,
            this.tsmiTest,
            this.tsmiRaporlar});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(822, 24);
            this.msMenu.TabIndex = 6;
            this.msMenu.Text = "menuStrip1";
            // 
            // tsmiUrunler
            // 
            this.tsmiUrunler.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUrunYonetimi,
            this.tsmiStokListe});
            this.tsmiUrunler.Image = global::StokTakip.Properties.Resources.package;
            this.tsmiUrunler.Name = "tsmiUrunler";
            this.tsmiUrunler.Size = new System.Drawing.Size(74, 20);
            this.tsmiUrunler.Text = "Ürünler";
            // 
            // tsmiUrunYonetimi
            // 
            this.tsmiUrunYonetimi.Name = "tsmiUrunYonetimi";
            this.tsmiUrunYonetimi.Size = new System.Drawing.Size(235, 22);
            this.tsmiUrunYonetimi.Tag = "urun_yonetimi";
            this.tsmiUrunYonetimi.Text = "Ürün Yönetimi";
            this.tsmiUrunYonetimi.Click += new System.EventHandler(this.btnUrunYonetimi_Click);
            // 
            // tsmiStokListe
            // 
            this.tsmiStokListe.Name = "tsmiStokListe";
            this.tsmiStokListe.Size = new System.Drawing.Size(235, 22);
            this.tsmiStokListe.Tag = "stok_listesi";
            this.tsmiStokListe.Text = "Ürünleri ve Hareketlerini İncele";
            this.tsmiStokListe.Click += new System.EventHandler(this.tsmiStokListe_Click);
            // 
            // tsmiFirmaMusteri
            // 
            this.tsmiFirmaMusteri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFirmaYonetimi,
            this.tsmiMusteriYonetimi});
            this.tsmiFirmaMusteri.Image = global::StokTakip.Properties.Resources.user_icon_512;
            this.tsmiFirmaMusteri.Name = "tsmiFirmaMusteri";
            this.tsmiFirmaMusteri.Size = new System.Drawing.Size(142, 20);
            this.tsmiFirmaMusteri.Text = "Firmalar / Müşteriler";
            // 
            // tsmiFirmaYonetimi
            // 
            this.tsmiFirmaYonetimi.Name = "tsmiFirmaYonetimi";
            this.tsmiFirmaYonetimi.Size = new System.Drawing.Size(164, 22);
            this.tsmiFirmaYonetimi.Tag = "firma_yonetimi";
            this.tsmiFirmaYonetimi.Text = "Firma Yönetimi";
            this.tsmiFirmaYonetimi.Click += new System.EventHandler(this.btnFirmaYonetimi_Click);
            // 
            // tsmiMusteriYonetimi
            // 
            this.tsmiMusteriYonetimi.Name = "tsmiMusteriYonetimi";
            this.tsmiMusteriYonetimi.Size = new System.Drawing.Size(164, 22);
            this.tsmiMusteriYonetimi.Tag = "musteri_yonetimi";
            this.tsmiMusteriYonetimi.Text = "Müşteri Yönetimi";
            this.tsmiMusteriYonetimi.Click += new System.EventHandler(this.btnMusteriYonetimi_Click);
            // 
            // alımSatımİşlemleriToolStripMenuItem
            // 
            this.alımSatımİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAlisYonetimi,
            this.btnSatisYonetimi,
            this.tsmiMuhasebeHareketleri});
            this.alımSatımİşlemleriToolStripMenuItem.Image = global::StokTakip.Properties.Resources.Cashbox;
            this.alımSatımİşlemleriToolStripMenuItem.Name = "alımSatımİşlemleriToolStripMenuItem";
            this.alımSatımİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.alımSatımİşlemleriToolStripMenuItem.Text = "Alım Satım İşlemleri";
            // 
            // btnAlisYonetimi
            // 
            this.btnAlisYonetimi.Name = "btnAlisYonetimi";
            this.btnAlisYonetimi.Size = new System.Drawing.Size(189, 22);
            this.btnAlisYonetimi.Tag = "alis";
            this.btnAlisYonetimi.Text = "Alış Yap";
            this.btnAlisYonetimi.Click += new System.EventHandler(this.btnStokYonetimi_Click);
            // 
            // btnSatisYonetimi
            // 
            this.btnSatisYonetimi.Name = "btnSatisYonetimi";
            this.btnSatisYonetimi.Size = new System.Drawing.Size(189, 22);
            this.btnSatisYonetimi.Tag = "satis";
            this.btnSatisYonetimi.Text = "Satış Yap";
            this.btnSatisYonetimi.Click += new System.EventHandler(this.btnSatisYonetimi_Click);
            // 
            // tsmiMuhasebeHareketleri
            // 
            this.tsmiMuhasebeHareketleri.Name = "tsmiMuhasebeHareketleri";
            this.tsmiMuhasebeHareketleri.Size = new System.Drawing.Size(189, 22);
            this.tsmiMuhasebeHareketleri.Tag = "muhasebe_hareketleri";
            this.tsmiMuhasebeHareketleri.Text = "Muhasebe Hareketleri";
            this.tsmiMuhasebeHareketleri.Click += new System.EventHandler(this.tsmiMuhasebeHareketleri_Click);
            // 
            // tsmiParaIslemleri
            // 
            this.tsmiParaIslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiParaAl,
            this.tsmiParaVer});
            this.tsmiParaIslemleri.Image = global::StokTakip.Properties.Resources.Paper_Money_icon_128;
            this.tsmiParaIslemleri.Name = "tsmiParaIslemleri";
            this.tsmiParaIslemleri.Size = new System.Drawing.Size(105, 20);
            this.tsmiParaIslemleri.Text = "Para İşlemleri";
            // 
            // tsmiParaAl
            // 
            this.tsmiParaAl.Name = "tsmiParaAl";
            this.tsmiParaAl.Size = new System.Drawing.Size(116, 22);
            this.tsmiParaAl.Tag = "para_alis";
            this.tsmiParaAl.Text = "Para Al";
            this.tsmiParaAl.Click += new System.EventHandler(this.tsmiParaAl_Click);
            // 
            // tsmiParaVer
            // 
            this.tsmiParaVer.Name = "tsmiParaVer";
            this.tsmiParaVer.Size = new System.Drawing.Size(116, 22);
            this.tsmiParaVer.Tag = "para_veris";
            this.tsmiParaVer.Text = "Para Ver";
            this.tsmiParaVer.Click += new System.EventHandler(this.tsmiParaVer_Click);
            // 
            // tsmiFaturaIslemleri
            // 
            this.tsmiFaturaIslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFaturaYazdir});
            this.tsmiFaturaIslemleri.Image = ((System.Drawing.Image)(resources.GetObject("tsmiFaturaIslemleri.Image")));
            this.tsmiFaturaIslemleri.Name = "tsmiFaturaIslemleri";
            this.tsmiFaturaIslemleri.Size = new System.Drawing.Size(115, 20);
            this.tsmiFaturaIslemleri.Text = "Fatura İşlemleri";
            // 
            // tsmiFaturaYazdir
            // 
            this.tsmiFaturaYazdir.Name = "tsmiFaturaYazdir";
            this.tsmiFaturaYazdir.Size = new System.Drawing.Size(152, 22);
            this.tsmiFaturaYazdir.Tag = "fatura_yazdir";
            this.tsmiFaturaYazdir.Text = "Fatura Yazdır";
            this.tsmiFaturaYazdir.Click += new System.EventHandler(this.tsmiFaturaYazdir_Click);
            // 
            // tsmiAyarlar
            // 
            this.tsmiAyarlar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDovizKurlari,
            this.tsmiSifreDegistir});
            this.tsmiAyarlar.Image = global::StokTakip.Properties.Resources._9;
            this.tsmiAyarlar.Name = "tsmiAyarlar";
            this.tsmiAyarlar.Size = new System.Drawing.Size(72, 20);
            this.tsmiAyarlar.Text = "Ayarlar";
            // 
            // tsmiDovizKurlari
            // 
            this.tsmiDovizKurlari.Name = "tsmiDovizKurlari";
            this.tsmiDovizKurlari.Size = new System.Drawing.Size(152, 22);
            this.tsmiDovizKurlari.Tag = "doviz_kurlari";
            this.tsmiDovizKurlari.Text = "Döviz Kurları";
            this.tsmiDovizKurlari.Click += new System.EventHandler(this.tsmiDovizKurlari_Click);
            // 
            // tsmiSifreDegistir
            // 
            this.tsmiSifreDegistir.Name = "tsmiSifreDegistir";
            this.tsmiSifreDegistir.Size = new System.Drawing.Size(152, 22);
            this.tsmiSifreDegistir.Tag = "sifre_degistir";
            this.tsmiSifreDegistir.Text = "Şifre Değiştir";
            this.tsmiSifreDegistir.Click += new System.EventHandler(this.tsmiSifreDegistir_Click);
            // 
            // tsmiTest
            // 
            this.tsmiTest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTestUrunImport});
            this.tsmiTest.Name = "tsmiTest";
            this.tsmiTest.Size = new System.Drawing.Size(39, 20);
            this.tsmiTest.Text = "Test";
            this.tsmiTest.Visible = false;
            // 
            // tsmiTestUrunImport
            // 
            this.tsmiTestUrunImport.Name = "tsmiTestUrunImport";
            this.tsmiTestUrunImport.Size = new System.Drawing.Size(152, 22);
            this.tsmiTestUrunImport.Text = "Ürün İmport";
            this.tsmiTestUrunImport.Click += new System.EventHandler(this.tsmiTestUrunImport_Click);
            // 
            // tcMain
            // 
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcMain.Location = new System.Drawing.Point(0, 24);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(822, 25);
            this.tcMain.TabIndex = 7;
            this.tcMain.SelectedIndexChanged += new System.EventHandler(this.tcMain_SelectedIndexChanged);
            // 
            // tsmiRaporlar
            // 
            this.tsmiRaporlar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSatisRaporu});
            this.tsmiRaporlar.Name = "tsmiRaporlar";
            this.tsmiRaporlar.Size = new System.Drawing.Size(63, 20);
            this.tsmiRaporlar.Text = "Raporlar";
            // 
            // tsmiSatisRaporu
            // 
            this.tsmiSatisRaporu.Name = "tsmiSatisRaporu";
            this.tsmiSatisRaporu.Size = new System.Drawing.Size(152, 22);
            this.tsmiSatisRaporu.Tag = "satis_raporu";
            this.tsmiSatisRaporu.Text = "Satış Raporu";
            this.tsmiSatisRaporu.Click += new System.EventHandler(this.tsmiSatisRaporu_Click);
            // 
            // frmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 354);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.ssBilgi);
            this.Controls.Add(this.msMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMenu;
            this.Name = "frmAnasayfa";
            this.Text = "STOK TAKİP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAnasayfa_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAnasayfa_FormClosed);
            this.Load += new System.EventHandler(this.frmAnasayfa_Load);
            this.ssBilgi.ResumeLayout(false);
            this.ssBilgi.PerformLayout();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssBilgi;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiUrunler;
        private System.Windows.Forms.ToolStripMenuItem tsmiUrunYonetimi;
        private System.Windows.Forms.ToolStripMenuItem tsmiFirmaMusteri;
        private System.Windows.Forms.ToolStripMenuItem tsmiFirmaYonetimi;
        private System.Windows.Forms.ToolStripMenuItem tsmiMusteriYonetimi;
        private System.Windows.Forms.ToolStripMenuItem alımSatımİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAlisYonetimi;
        private System.Windows.Forms.ToolStripMenuItem btnSatisYonetimi;
        private System.Windows.Forms.ToolStripMenuItem tsmiMuhasebeHareketleri;
        private System.Windows.Forms.ToolStripMenuItem tsmiParaIslemleri;
        private System.Windows.Forms.ToolStripMenuItem tsmiParaAl;
        private System.Windows.Forms.ToolStripMenuItem tsmiParaVer;
        public System.Windows.Forms.TabControl tcMain;
        public System.Windows.Forms.ToolStripStatusLabel tssDovizDolar;
        public System.Windows.Forms.ToolStripStatusLabel tssDovizEuro;
        public System.Windows.Forms.ToolStripStatusLabel tssDovizPound;
        private System.Windows.Forms.ToolStripMenuItem tsmiAyarlar;
        private System.Windows.Forms.ToolStripMenuItem tsmiDovizKurlari;
        private System.Windows.Forms.ToolStripMenuItem tsmiTest;
        private System.Windows.Forms.ToolStripMenuItem tsmiTestUrunImport;
        private System.Windows.Forms.ToolStripMenuItem tsmiSifreDegistir;
        private System.Windows.Forms.ToolStripMenuItem tsmiStokListe;
        private System.Windows.Forms.ToolStripMenuItem tsmiFaturaIslemleri;
        private System.Windows.Forms.ToolStripMenuItem tsmiFaturaYazdir;
        private System.Windows.Forms.ToolStripMenuItem tsmiRaporlar;
        private System.Windows.Forms.ToolStripMenuItem tsmiSatisRaporu;
    }
}