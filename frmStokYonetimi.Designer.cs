namespace StokTakip
{
    partial class frmStokYonetimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStokYonetimi));
            this.cbUrunler = new System.Windows.Forms.ComboBox();
            this.txtUrunler = new System.Windows.Forms.TextBox();
            this.btnStokListesi = new System.Windows.Forms.Button();
            this.dtpTarihBaslangic = new System.Windows.Forms.DateTimePicker();
            this.lblUrunSeriali = new System.Windows.Forms.Label();
            this.lblSatisFiyati = new System.Windows.Forms.Label();
            this.lblUrunModel = new System.Windows.Forms.Label();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.lblUrunMiktar = new System.Windows.Forms.Label();
            this.txtUrunSerial = new System.Windows.Forms.Label();
            this.btnStokEkle = new System.Windows.Forms.Button();
            this.txtUrunAdi = new System.Windows.Forms.Label();
            this.txtUrunModeli = new System.Windows.Forms.Label();
            this.txtSatisFiyati = new System.Windows.Forms.Label();
            this.txtStokAdet = new System.Windows.Forms.NumericUpDown();
            this.dgwUrunler = new System.Windows.Forms.DataGridView();
            this.urun_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stok_miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iskonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birim_fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birim_fiyat_kdv_dahil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplam_fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplam_fiyat_kdv_dahil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplam_iskonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ara_toplam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplam_kdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genel_toplam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdv_dahil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrunMiktar = new System.Windows.Forms.Label();
            this.cbAlisKdvDahil = new System.Windows.Forms.ComboBox();
            this.txtAlisFiyati = new System.Windows.Forms.TextBox();
            this.lblIskonto = new System.Windows.Forms.Label();
            this.txtIskonto = new System.Windows.Forms.TextBox();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.lblToplamIskonto = new System.Windows.Forms.Label();
            this.lblAraToplam = new System.Windows.Forms.Label();
            this.lblToplamKdv = new System.Windows.Forms.Label();
            this.lblGenelToplam = new System.Windows.Forms.Label();
            this.lblTL1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtToplamTutar = new System.Windows.Forms.Label();
            this.txtToplamIskonto = new System.Windows.Forms.Label();
            this.txtAraToplam = new System.Windows.Forms.Label();
            this.txtToplamKdv = new System.Windows.Forms.Label();
            this.txtGenelToplam = new System.Windows.Forms.Label();
            this.lblUrunKdv = new System.Windows.Forms.Label();
            this.txtUrunKdv = new System.Windows.Forms.Label();
            this.btnUrunSec = new System.Windows.Forms.Button();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.lblSeciliUrun = new System.Windows.Forms.Label();
            this.cbFirmaMusteri = new System.Windows.Forms.ComboBox();
            this.btnFirmaSec = new System.Windows.Forms.Button();
            this.txtFirmalar = new System.Windows.Forms.TextBox();
            this.lblSeciliFirma = new System.Windows.Forms.Label();
            this.gbFaturaBilgileri = new System.Windows.Forms.GroupBox();
            this.txtFaturaAciklama = new System.Windows.Forms.TextBox();
            this.txtFaturaNo = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.lblFaturaTip = new System.Windows.Forms.Label();
            this.lblFaturaNo = new System.Windows.Forms.Label();
            this.cbFaturaTip = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOdenenTutar = new System.Windows.Forms.TextBox();
            this.btnSatisTamamla = new System.Windows.Forms.Button();
            this.menuSag = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSatirSil = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiListeyiTemizle = new System.Windows.Forms.ToolStripMenuItem();
            this.lblKalemSayisi = new System.Windows.Forms.Label();
            this.cbOdemeTipi = new System.Windows.Forms.ComboBox();
            this.lblSeciliKayit = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtVergiNo = new System.Windows.Forms.TextBox();
            this.txtVergiDairesi = new System.Windows.Forms.TextBox();
            this.lblVN = new System.Windows.Forms.Label();
            this.lblVD = new System.Windows.Forms.Label();
            this.txtCepTel = new System.Windows.Forms.MaskedTextBox();
            this.txtTcKimlik = new System.Windows.Forms.MaskedTextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblCepTel = new System.Windows.Forms.Label();
            this.lblTcKimlik = new System.Windows.Forms.Label();
            this.chkCariKayit = new System.Windows.Forms.CheckBox();
            this.txtMecraNo = new System.Windows.Forms.TextBox();
            this.lblMecraNo = new System.Windows.Forms.Label();
            this.lblMecra = new System.Windows.Forms.Label();
            this.cmbMecra = new System.Windows.Forms.ComboBox();
            this.chkToplamFiyat = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrunler)).BeginInit();
            this.gbFaturaBilgileri.SuspendLayout();
            this.menuSag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbUrunler
            // 
            this.cbUrunler.FormattingEnabled = true;
            this.cbUrunler.Location = new System.Drawing.Point(252, 174);
            this.cbUrunler.Name = "cbUrunler";
            this.cbUrunler.Size = new System.Drawing.Size(30, 21);
            this.cbUrunler.TabIndex = 0;
            this.cbUrunler.Visible = false;
            this.cbUrunler.SelectedIndexChanged += new System.EventHandler(this.cbUrunler_SelectedIndexChanged);
            this.cbUrunler.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbUrunler_KeyUp);
            // 
            // txtUrunler
            // 
            this.txtUrunler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUrunler.Location = new System.Drawing.Point(136, 15);
            this.txtUrunler.Name = "txtUrunler";
            this.txtUrunler.ReadOnly = true;
            this.txtUrunler.Size = new System.Drawing.Size(203, 20);
            this.txtUrunler.TabIndex = 59;
            this.txtUrunler.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUrunler_KeyUp);
            // 
            // btnStokListesi
            // 
            this.btnStokListesi.Location = new System.Drawing.Point(910, 12);
            this.btnStokListesi.Name = "btnStokListesi";
            this.btnStokListesi.Size = new System.Drawing.Size(50, 46);
            this.btnStokListesi.TabIndex = 3;
            this.btnStokListesi.Text = "STOK LİSTESİ";
            this.btnStokListesi.UseVisualStyleBackColor = true;
            this.btnStokListesi.Visible = false;
            this.btnStokListesi.Click += new System.EventHandler(this.btnStokListesi_Click);
            // 
            // dtpTarihBaslangic
            // 
            this.dtpTarihBaslangic.Location = new System.Drawing.Point(136, 90);
            this.dtpTarihBaslangic.Name = "dtpTarihBaslangic";
            this.dtpTarihBaslangic.Size = new System.Drawing.Size(165, 20);
            this.dtpTarihBaslangic.TabIndex = 5;
            // 
            // lblUrunSeriali
            // 
            this.lblUrunSeriali.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunSeriali.ForeColor = System.Drawing.Color.Black;
            this.lblUrunSeriali.Location = new System.Drawing.Point(12, 114);
            this.lblUrunSeriali.Name = "lblUrunSeriali";
            this.lblUrunSeriali.Size = new System.Drawing.Size(116, 13);
            this.lblUrunSeriali.TabIndex = 33;
            this.lblUrunSeriali.Text = "Barkod Numarası";
            this.lblUrunSeriali.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSatisFiyati
            // 
            this.lblSatisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatisFiyati.ForeColor = System.Drawing.Color.Black;
            this.lblSatisFiyati.Location = new System.Drawing.Point(11, 164);
            this.lblSatisFiyati.Name = "lblSatisFiyati";
            this.lblSatisFiyati.Size = new System.Drawing.Size(116, 13);
            this.lblSatisFiyati.TabIndex = 34;
            this.lblSatisFiyati.Text = "Satış Fiyatı";
            this.lblSatisFiyati.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUrunModel
            // 
            this.lblUrunModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunModel.ForeColor = System.Drawing.Color.Black;
            this.lblUrunModel.Location = new System.Drawing.Point(10, 147);
            this.lblUrunModel.Name = "lblUrunModel";
            this.lblUrunModel.Size = new System.Drawing.Size(116, 13);
            this.lblUrunModel.TabIndex = 35;
            this.lblUrunModel.Text = "Ürün Cinsi";
            this.lblUrunModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAdi.ForeColor = System.Drawing.Color.Black;
            this.lblUrunAdi.Location = new System.Drawing.Point(11, 131);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(116, 13);
            this.lblUrunAdi.TabIndex = 37;
            this.lblUrunAdi.Text = "Ürün Adı";
            this.lblUrunAdi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUrunMiktar
            // 
            this.lblUrunMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunMiktar.ForeColor = System.Drawing.Color.Black;
            this.lblUrunMiktar.Location = new System.Drawing.Point(10, 196);
            this.lblUrunMiktar.Name = "lblUrunMiktar";
            this.lblUrunMiktar.Size = new System.Drawing.Size(116, 13);
            this.lblUrunMiktar.TabIndex = 34;
            this.lblUrunMiktar.Text = "Stoktaki Miktar";
            this.lblUrunMiktar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUrunSerial
            // 
            this.txtUrunSerial.AutoSize = true;
            this.txtUrunSerial.Location = new System.Drawing.Point(135, 113);
            this.txtUrunSerial.Name = "txtUrunSerial";
            this.txtUrunSerial.Size = new System.Drawing.Size(40, 13);
            this.txtUrunSerial.TabIndex = 38;
            this.txtUrunSerial.Text = "barkod";
            // 
            // btnStokEkle
            // 
            this.btnStokEkle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStokEkle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnStokEkle.Location = new System.Drawing.Point(499, 144);
            this.btnStokEkle.Name = "btnStokEkle";
            this.btnStokEkle.Size = new System.Drawing.Size(75, 60);
            this.btnStokEkle.TabIndex = 10;
            this.btnStokEkle.Tag = "ekle";
            this.btnStokEkle.Text = "EKLE";
            this.btnStokEkle.UseVisualStyleBackColor = true;
            this.btnStokEkle.Click += new System.EventHandler(this.btnStokEkle_Click);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.AutoSize = true;
            this.txtUrunAdi.Location = new System.Drawing.Point(135, 131);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(19, 13);
            this.txtUrunAdi.TabIndex = 38;
            this.txtUrunAdi.Text = "ad";
            // 
            // txtUrunModeli
            // 
            this.txtUrunModeli.AutoSize = true;
            this.txtUrunModeli.Location = new System.Drawing.Point(135, 147);
            this.txtUrunModeli.Name = "txtUrunModeli";
            this.txtUrunModeli.Size = new System.Drawing.Size(35, 13);
            this.txtUrunModeli.TabIndex = 41;
            this.txtUrunModeli.Text = "model";
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.AutoSize = true;
            this.txtSatisFiyati.Location = new System.Drawing.Point(136, 164);
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Size = new System.Drawing.Size(26, 13);
            this.txtSatisFiyati.TabIndex = 41;
            this.txtSatisFiyati.Text = "fiyat";
            // 
            // txtStokAdet
            // 
            this.txtStokAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStokAdet.Location = new System.Drawing.Point(409, 144);
            this.txtStokAdet.Name = "txtStokAdet";
            this.txtStokAdet.Size = new System.Drawing.Size(77, 53);
            this.txtStokAdet.TabIndex = 9;
            this.txtStokAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgwUrunler
            // 
            this.dgwUrunler.AllowUserToAddRows = false;
            this.dgwUrunler.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgwUrunler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwUrunler.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgwUrunler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwUrunler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urun_id,
            this.miktar,
            this.stok_miktar,
            this.kdv,
            this.iskonto,
            this.birim_fiyat,
            this.birim_fiyat_kdv_dahil,
            this.toplam_fiyat,
            this.toplam_fiyat_kdv_dahil,
            this.urun_serial,
            this.urun_ad,
            this.urun_model,
            this.toplam_iskonto,
            this.ara_toplam,
            this.toplam_kdv,
            this.genel_toplam,
            this.kdv_dahil});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwUrunler.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwUrunler.Location = new System.Drawing.Point(0, 0);
            this.dgwUrunler.Name = "dgwUrunler";
            this.dgwUrunler.ReadOnly = true;
            this.dgwUrunler.RowHeadersVisible = false;
            this.dgwUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwUrunler.Size = new System.Drawing.Size(1028, 291);
            this.dgwUrunler.TabIndex = 0;
            this.dgwUrunler.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgwUrunler_MouseUp);
            // 
            // urun_id
            // 
            this.urun_id.HeaderText = "ÜRÜN ID";
            this.urun_id.Name = "urun_id";
            this.urun_id.ReadOnly = true;
            this.urun_id.Visible = false;
            // 
            // miktar
            // 
            this.miktar.DataPropertyName = "miktar";
            this.miktar.FillWeight = 74.31199F;
            this.miktar.HeaderText = "MİKTAR";
            this.miktar.Name = "miktar";
            this.miktar.ReadOnly = true;
            // 
            // stok_miktar
            // 
            this.stok_miktar.DataPropertyName = "stok_miktar";
            this.stok_miktar.FillWeight = 69.64802F;
            this.stok_miktar.HeaderText = "STOK";
            this.stok_miktar.Name = "stok_miktar";
            this.stok_miktar.ReadOnly = true;
            // 
            // kdv
            // 
            this.kdv.DataPropertyName = "kdv";
            this.kdv.FillWeight = 66.56017F;
            this.kdv.HeaderText = "KDV %";
            this.kdv.Name = "kdv";
            this.kdv.ReadOnly = true;
            // 
            // iskonto
            // 
            this.iskonto.DataPropertyName = "iskonto";
            this.iskonto.FillWeight = 65.84295F;
            this.iskonto.HeaderText = "İSK %";
            this.iskonto.Name = "iskonto";
            this.iskonto.ReadOnly = true;
            // 
            // birim_fiyat
            // 
            this.birim_fiyat.DataPropertyName = "birim_fiyat";
            this.birim_fiyat.FillWeight = 92.88316F;
            this.birim_fiyat.HeaderText = "BİRİM FİYAT";
            this.birim_fiyat.Name = "birim_fiyat";
            this.birim_fiyat.ReadOnly = true;
            // 
            // birim_fiyat_kdv_dahil
            // 
            this.birim_fiyat_kdv_dahil.DataPropertyName = "birim_fiyat_kdv_dahil";
            this.birim_fiyat_kdv_dahil.FillWeight = 86.51717F;
            this.birim_fiyat_kdv_dahil.HeaderText = "BİRİM FİYAT + KDV";
            this.birim_fiyat_kdv_dahil.Name = "birim_fiyat_kdv_dahil";
            this.birim_fiyat_kdv_dahil.ReadOnly = true;
            // 
            // toplam_fiyat
            // 
            this.toplam_fiyat.DataPropertyName = "toplam_fiyat";
            this.toplam_fiyat.FillWeight = 79.6265F;
            this.toplam_fiyat.HeaderText = "TOPLAM FİYAT";
            this.toplam_fiyat.Name = "toplam_fiyat";
            this.toplam_fiyat.ReadOnly = true;
            // 
            // toplam_fiyat_kdv_dahil
            // 
            this.toplam_fiyat_kdv_dahil.DataPropertyName = "toplam_fiyat_kdv_dahil";
            this.toplam_fiyat_kdv_dahil.FillWeight = 105.168F;
            this.toplam_fiyat_kdv_dahil.HeaderText = "TOPLAM FİYAT + KDV";
            this.toplam_fiyat_kdv_dahil.Name = "toplam_fiyat_kdv_dahil";
            this.toplam_fiyat_kdv_dahil.ReadOnly = true;
            // 
            // urun_serial
            // 
            this.urun_serial.DataPropertyName = "urun_serial";
            this.urun_serial.FillWeight = 87.87363F;
            this.urun_serial.HeaderText = "ÜRÜN BARKODU";
            this.urun_serial.Name = "urun_serial";
            this.urun_serial.ReadOnly = true;
            // 
            // urun_ad
            // 
            this.urun_ad.DataPropertyName = "urun_ad";
            this.urun_ad.FillWeight = 275.5686F;
            this.urun_ad.HeaderText = "ÜRÜN ADI";
            this.urun_ad.Name = "urun_ad";
            this.urun_ad.ReadOnly = true;
            // 
            // urun_model
            // 
            this.urun_model.DataPropertyName = "urun_model";
            this.urun_model.HeaderText = "ÜRÜN CİNSİ";
            this.urun_model.Name = "urun_model";
            this.urun_model.ReadOnly = true;
            this.urun_model.Visible = false;
            // 
            // toplam_iskonto
            // 
            this.toplam_iskonto.DataPropertyName = "toplam_iskonto";
            this.toplam_iskonto.HeaderText = "İSK";
            this.toplam_iskonto.Name = "toplam_iskonto";
            this.toplam_iskonto.ReadOnly = true;
            this.toplam_iskonto.Visible = false;
            // 
            // ara_toplam
            // 
            this.ara_toplam.DataPropertyName = "ara_toplam";
            this.ara_toplam.HeaderText = "ARATOP";
            this.ara_toplam.Name = "ara_toplam";
            this.ara_toplam.ReadOnly = true;
            this.ara_toplam.Visible = false;
            // 
            // toplam_kdv
            // 
            this.toplam_kdv.DataPropertyName = "toplam_kdv";
            this.toplam_kdv.HeaderText = "TOPKDV";
            this.toplam_kdv.Name = "toplam_kdv";
            this.toplam_kdv.ReadOnly = true;
            this.toplam_kdv.Visible = false;
            // 
            // genel_toplam
            // 
            this.genel_toplam.DataPropertyName = "genel_toplam";
            this.genel_toplam.HeaderText = "GENTOP";
            this.genel_toplam.Name = "genel_toplam";
            this.genel_toplam.ReadOnly = true;
            this.genel_toplam.Visible = false;
            // 
            // kdv_dahil
            // 
            this.kdv_dahil.DataPropertyName = "kdv_dahil";
            this.kdv_dahil.HeaderText = "KDV DAHİL";
            this.kdv_dahil.Name = "kdv_dahil";
            this.kdv_dahil.ReadOnly = true;
            this.kdv_dahil.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(323, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Birim Fiyat";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUrunMiktar
            // 
            this.txtUrunMiktar.AutoSize = true;
            this.txtUrunMiktar.Location = new System.Drawing.Point(135, 196);
            this.txtUrunMiktar.Name = "txtUrunMiktar";
            this.txtUrunMiktar.Size = new System.Drawing.Size(35, 13);
            this.txtUrunMiktar.TabIndex = 41;
            this.txtUrunMiktar.Text = "miktar";
            // 
            // cbAlisKdvDahil
            // 
            this.cbAlisKdvDahil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlisKdvDahil.FormattingEnabled = true;
            this.cbAlisKdvDahil.Items.AddRange(new object[] {
            "KDV Hariç",
            "KDV Dahil"});
            this.cbAlisKdvDahil.Location = new System.Drawing.Point(478, 91);
            this.cbAlisKdvDahil.Name = "cbAlisKdvDahil";
            this.cbAlisKdvDahil.Size = new System.Drawing.Size(94, 21);
            this.cbAlisKdvDahil.TabIndex = 7;
            this.cbAlisKdvDahil.SelectedIndexChanged += new System.EventHandler(this.cbAlisKdvDahil_SelectedIndexChanged);
            // 
            // txtAlisFiyati
            // 
            this.txtAlisFiyati.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlisFiyati.Location = new System.Drawing.Point(409, 91);
            this.txtAlisFiyati.Name = "txtAlisFiyati";
            this.txtAlisFiyati.Size = new System.Drawing.Size(63, 20);
            this.txtAlisFiyati.TabIndex = 6;
            // 
            // lblIskonto
            // 
            this.lblIskonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIskonto.ForeColor = System.Drawing.Color.Black;
            this.lblIskonto.Location = new System.Drawing.Point(322, 121);
            this.lblIskonto.Name = "lblIskonto";
            this.lblIskonto.Size = new System.Drawing.Size(76, 13);
            this.lblIskonto.TabIndex = 59;
            this.lblIskonto.Text = "İskonto (%)";
            this.lblIskonto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtIskonto
            // 
            this.txtIskonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIskonto.Location = new System.Drawing.Point(409, 118);
            this.txtIskonto.Name = "txtIskonto";
            this.txtIskonto.Size = new System.Drawing.Size(63, 20);
            this.txtIskonto.TabIndex = 8;
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.ForeColor = System.Drawing.Color.Black;
            this.lblToplamTutar.Location = new System.Drawing.Point(1048, 142);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(86, 13);
            this.lblToplamTutar.TabIndex = 59;
            this.lblToplamTutar.Text = "Toplam Tutar:";
            // 
            // lblToplamIskonto
            // 
            this.lblToplamIskonto.AutoSize = true;
            this.lblToplamIskonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamIskonto.ForeColor = System.Drawing.Color.Black;
            this.lblToplamIskonto.Location = new System.Drawing.Point(1081, 156);
            this.lblToplamIskonto.Name = "lblToplamIskonto";
            this.lblToplamIskonto.Size = new System.Drawing.Size(53, 13);
            this.lblToplamIskonto.TabIndex = 59;
            this.lblToplamIskonto.Text = "İskonto:";
            // 
            // lblAraToplam
            // 
            this.lblAraToplam.AutoSize = true;
            this.lblAraToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAraToplam.ForeColor = System.Drawing.Color.Black;
            this.lblAraToplam.Location = new System.Drawing.Point(1059, 170);
            this.lblAraToplam.Name = "lblAraToplam";
            this.lblAraToplam.Size = new System.Drawing.Size(75, 13);
            this.lblAraToplam.TabIndex = 59;
            this.lblAraToplam.Text = "Ara Toplam:";
            // 
            // lblToplamKdv
            // 
            this.lblToplamKdv.AutoSize = true;
            this.lblToplamKdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamKdv.ForeColor = System.Drawing.Color.Black;
            this.lblToplamKdv.Location = new System.Drawing.Point(1053, 184);
            this.lblToplamKdv.Name = "lblToplamKdv";
            this.lblToplamKdv.Size = new System.Drawing.Size(81, 13);
            this.lblToplamKdv.TabIndex = 59;
            this.lblToplamKdv.Text = "Toplam KDV:";
            // 
            // lblGenelToplam
            // 
            this.lblGenelToplam.AutoSize = true;
            this.lblGenelToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGenelToplam.ForeColor = System.Drawing.Color.Black;
            this.lblGenelToplam.Location = new System.Drawing.Point(1045, 197);
            this.lblGenelToplam.Name = "lblGenelToplam";
            this.lblGenelToplam.Size = new System.Drawing.Size(89, 13);
            this.lblGenelToplam.TabIndex = 59;
            this.lblGenelToplam.Text = "Genel Toplam:";
            // 
            // lblTL1
            // 
            this.lblTL1.AutoSize = true;
            this.lblTL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTL1.ForeColor = System.Drawing.Color.Black;
            this.lblTL1.Location = new System.Drawing.Point(1202, 142);
            this.lblTL1.Name = "lblTL1";
            this.lblTL1.Size = new System.Drawing.Size(22, 13);
            this.lblTL1.TabIndex = 59;
            this.lblTL1.Text = "TL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1202, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "TL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1202, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "TL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1202, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "TL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1202, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "TL";
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplamTutar.ForeColor = System.Drawing.Color.Teal;
            this.txtToplamTutar.Location = new System.Drawing.Point(1140, 142);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.Size = new System.Drawing.Size(56, 13);
            this.txtToplamTutar.TabIndex = 59;
            this.txtToplamTutar.Text = "0,00";
            this.txtToplamTutar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtToplamIskonto
            // 
            this.txtToplamIskonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplamIskonto.ForeColor = System.Drawing.Color.Teal;
            this.txtToplamIskonto.Location = new System.Drawing.Point(1140, 156);
            this.txtToplamIskonto.Name = "txtToplamIskonto";
            this.txtToplamIskonto.Size = new System.Drawing.Size(56, 13);
            this.txtToplamIskonto.TabIndex = 59;
            this.txtToplamIskonto.Text = "0,00";
            this.txtToplamIskonto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAraToplam
            // 
            this.txtAraToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAraToplam.ForeColor = System.Drawing.Color.Teal;
            this.txtAraToplam.Location = new System.Drawing.Point(1140, 169);
            this.txtAraToplam.Name = "txtAraToplam";
            this.txtAraToplam.Size = new System.Drawing.Size(56, 13);
            this.txtAraToplam.TabIndex = 59;
            this.txtAraToplam.Text = "0,00";
            this.txtAraToplam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtToplamKdv
            // 
            this.txtToplamKdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplamKdv.ForeColor = System.Drawing.Color.Teal;
            this.txtToplamKdv.Location = new System.Drawing.Point(1140, 184);
            this.txtToplamKdv.Name = "txtToplamKdv";
            this.txtToplamKdv.Size = new System.Drawing.Size(56, 13);
            this.txtToplamKdv.TabIndex = 59;
            this.txtToplamKdv.Text = "0,00";
            this.txtToplamKdv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGenelToplam
            // 
            this.txtGenelToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGenelToplam.ForeColor = System.Drawing.Color.Teal;
            this.txtGenelToplam.Location = new System.Drawing.Point(1140, 197);
            this.txtGenelToplam.Name = "txtGenelToplam";
            this.txtGenelToplam.Size = new System.Drawing.Size(56, 13);
            this.txtGenelToplam.TabIndex = 59;
            this.txtGenelToplam.Text = "0,00";
            this.txtGenelToplam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUrunKdv
            // 
            this.lblUrunKdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunKdv.ForeColor = System.Drawing.Color.Black;
            this.lblUrunKdv.Location = new System.Drawing.Point(10, 180);
            this.lblUrunKdv.Name = "lblUrunKdv";
            this.lblUrunKdv.Size = new System.Drawing.Size(116, 13);
            this.lblUrunKdv.TabIndex = 34;
            this.lblUrunKdv.Text = "KDV %";
            this.lblUrunKdv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUrunKdv
            // 
            this.txtUrunKdv.AutoSize = true;
            this.txtUrunKdv.Location = new System.Drawing.Point(136, 180);
            this.txtUrunKdv.Name = "txtUrunKdv";
            this.txtUrunKdv.Size = new System.Drawing.Size(25, 13);
            this.txtUrunKdv.TabIndex = 41;
            this.txtUrunKdv.Text = "kdv";
            // 
            // btnUrunSec
            // 
            this.btnUrunSec.Location = new System.Drawing.Point(13, 15);
            this.btnUrunSec.Name = "btnUrunSec";
            this.btnUrunSec.Size = new System.Drawing.Size(117, 20);
            this.btnUrunSec.TabIndex = 1;
            this.btnUrunSec.Text = "ÜRÜN SEÇ";
            this.btnUrunSec.UseVisualStyleBackColor = true;
            this.btnUrunSec.Click += new System.EventHandler(this.btnUrunSec_Click);
            // 
            // lblMiktar
            // 
            this.lblMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMiktar.ForeColor = System.Drawing.Color.Black;
            this.lblMiktar.Location = new System.Drawing.Point(350, 170);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(47, 13);
            this.lblMiktar.TabIndex = 34;
            this.lblMiktar.Text = "Miktar";
            this.lblMiktar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSeciliUrun
            // 
            this.lblSeciliUrun.AccessibleDescription = "";
            this.lblSeciliUrun.AutoSize = true;
            this.lblSeciliUrun.Location = new System.Drawing.Point(288, 177);
            this.lblSeciliUrun.Name = "lblSeciliUrun";
            this.lblSeciliUrun.Size = new System.Drawing.Size(65, 13);
            this.lblSeciliUrun.TabIndex = 63;
            this.lblSeciliUrun.Text = "lblSeciliUrun";
            this.lblSeciliUrun.Visible = false;
            this.lblSeciliUrun.TextChanged += new System.EventHandler(this.lblSeciliUrun_TextChanged);
            // 
            // cbFirmaMusteri
            // 
            this.cbFirmaMusteri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFirmaMusteri.FormattingEnabled = true;
            this.cbFirmaMusteri.Items.AddRange(new object[] {
            "Firma",
            "Müşteri"});
            this.cbFirmaMusteri.Location = new System.Drawing.Point(15, 41);
            this.cbFirmaMusteri.Name = "cbFirmaMusteri";
            this.cbFirmaMusteri.Size = new System.Drawing.Size(64, 21);
            this.cbFirmaMusteri.TabIndex = 2;
            this.cbFirmaMusteri.TextChanged += new System.EventHandler(this.cbFirmaMusteri_TextChanged);
            // 
            // btnFirmaSec
            // 
            this.btnFirmaSec.Location = new System.Drawing.Point(85, 41);
            this.btnFirmaSec.Name = "btnFirmaSec";
            this.btnFirmaSec.Size = new System.Drawing.Size(43, 21);
            this.btnFirmaSec.TabIndex = 3;
            this.btnFirmaSec.Text = "SEÇ";
            this.btnFirmaSec.UseVisualStyleBackColor = true;
            this.btnFirmaSec.Click += new System.EventHandler(this.btnFirmaSec_Click);
            // 
            // txtFirmalar
            // 
            this.txtFirmalar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirmalar.Location = new System.Drawing.Point(136, 41);
            this.txtFirmalar.Name = "txtFirmalar";
            this.txtFirmalar.ReadOnly = true;
            this.txtFirmalar.Size = new System.Drawing.Size(203, 20);
            this.txtFirmalar.TabIndex = 60;
            this.txtFirmalar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUrunler_KeyUp);
            // 
            // lblSeciliFirma
            // 
            this.lblSeciliFirma.AccessibleDescription = "";
            this.lblSeciliFirma.AutoSize = true;
            this.lblSeciliFirma.Location = new System.Drawing.Point(288, 191);
            this.lblSeciliFirma.Name = "lblSeciliFirma";
            this.lblSeciliFirma.Size = new System.Drawing.Size(67, 13);
            this.lblSeciliFirma.TabIndex = 63;
            this.lblSeciliFirma.Text = "lblSeciliFirma";
            this.lblSeciliFirma.Visible = false;
            this.lblSeciliFirma.TextChanged += new System.EventHandler(this.lblSeciliUrun_TextChanged);
            // 
            // gbFaturaBilgileri
            // 
            this.gbFaturaBilgileri.Controls.Add(this.txtFaturaAciklama);
            this.gbFaturaBilgileri.Controls.Add(this.txtFaturaNo);
            this.gbFaturaBilgileri.Controls.Add(this.lblAciklama);
            this.gbFaturaBilgileri.Controls.Add(this.lblFaturaTip);
            this.gbFaturaBilgileri.Controls.Add(this.lblFaturaNo);
            this.gbFaturaBilgileri.Controls.Add(this.cbFaturaTip);
            this.gbFaturaBilgileri.Location = new System.Drawing.Point(770, 48);
            this.gbFaturaBilgileri.Name = "gbFaturaBilgileri";
            this.gbFaturaBilgileri.Size = new System.Drawing.Size(454, 75);
            this.gbFaturaBilgileri.TabIndex = 64;
            this.gbFaturaBilgileri.TabStop = false;
            this.gbFaturaBilgileri.Text = "Fatura Bilgileri";
            // 
            // txtFaturaAciklama
            // 
            this.txtFaturaAciklama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFaturaAciklama.Location = new System.Drawing.Point(248, 18);
            this.txtFaturaAciklama.Multiline = true;
            this.txtFaturaAciklama.Name = "txtFaturaAciklama";
            this.txtFaturaAciklama.Size = new System.Drawing.Size(193, 47);
            this.txtFaturaAciklama.TabIndex = 23;
            // 
            // txtFaturaNo
            // 
            this.txtFaturaNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFaturaNo.Location = new System.Drawing.Point(84, 45);
            this.txtFaturaNo.Name = "txtFaturaNo";
            this.txtFaturaNo.Size = new System.Drawing.Size(76, 20);
            this.txtFaturaNo.TabIndex = 20;
            // 
            // lblAciklama
            // 
            this.lblAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.ForeColor = System.Drawing.Color.Black;
            this.lblAciklama.Location = new System.Drawing.Point(173, 35);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(71, 13);
            this.lblAciklama.TabIndex = 59;
            this.lblAciklama.Text = "Açıklama";
            this.lblAciklama.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFaturaTip
            // 
            this.lblFaturaTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFaturaTip.ForeColor = System.Drawing.Color.Black;
            this.lblFaturaTip.Location = new System.Drawing.Point(6, 21);
            this.lblFaturaTip.Name = "lblFaturaTip";
            this.lblFaturaTip.Size = new System.Drawing.Size(71, 13);
            this.lblFaturaTip.TabIndex = 59;
            this.lblFaturaTip.Text = "Belge";
            this.lblFaturaTip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFaturaNo
            // 
            this.lblFaturaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFaturaNo.ForeColor = System.Drawing.Color.Black;
            this.lblFaturaNo.Location = new System.Drawing.Point(6, 47);
            this.lblFaturaNo.Name = "lblFaturaNo";
            this.lblFaturaNo.Size = new System.Drawing.Size(71, 13);
            this.lblFaturaNo.TabIndex = 59;
            this.lblFaturaNo.Text = "Fatura No";
            this.lblFaturaNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbFaturaTip
            // 
            this.cbFaturaTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFaturaTip.FormattingEnabled = true;
            this.cbFaturaTip.Items.AddRange(new object[] {
            "KDV Hariç",
            "KDV Dahil"});
            this.cbFaturaTip.Location = new System.Drawing.Point(83, 18);
            this.cbFaturaTip.Name = "cbFaturaTip";
            this.cbFaturaTip.Size = new System.Drawing.Size(77, 21);
            this.cbFaturaTip.TabIndex = 19;
            this.cbFaturaTip.SelectedIndexChanged += new System.EventHandler(this.cbAlisKdvDahil_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(957, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Ödenen Tutar";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOdenenTutar
            // 
            this.txtOdenenTutar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOdenenTutar.Location = new System.Drawing.Point(1052, 29);
            this.txtOdenenTutar.Name = "txtOdenenTutar";
            this.txtOdenenTutar.Size = new System.Drawing.Size(76, 20);
            this.txtOdenenTutar.TabIndex = 21;
            // 
            // btnSatisTamamla
            // 
            this.btnSatisTamamla.BackColor = System.Drawing.Color.Transparent;
            this.btnSatisTamamla.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSatisTamamla.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnSatisTamamla.Location = new System.Drawing.Point(856, 150);
            this.btnSatisTamamla.Name = "btnSatisTamamla";
            this.btnSatisTamamla.Size = new System.Drawing.Size(174, 60);
            this.btnSatisTamamla.TabIndex = 24;
            this.btnSatisTamamla.Tag = "";
            this.btnSatisTamamla.Text = "TAMAMLA";
            this.btnSatisTamamla.UseVisualStyleBackColor = false;
            this.btnSatisTamamla.Click += new System.EventHandler(this.btnSatisTamamla_Click);
            // 
            // menuSag
            // 
            this.menuSag.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSatirSil,
            this.tsmiListeyiTemizle});
            this.menuSag.Name = "menuSag";
            this.menuSag.Size = new System.Drawing.Size(149, 48);
            // 
            // tsmiSatirSil
            // 
            this.tsmiSatirSil.Name = "tsmiSatirSil";
            this.tsmiSatirSil.Size = new System.Drawing.Size(148, 22);
            this.tsmiSatirSil.Text = "Seçiliyi kaldır";
            this.tsmiSatirSil.Click += new System.EventHandler(this.tsmiSatirSil_Click);
            // 
            // tsmiListeyiTemizle
            // 
            this.tsmiListeyiTemizle.Name = "tsmiListeyiTemizle";
            this.tsmiListeyiTemizle.Size = new System.Drawing.Size(148, 22);
            this.tsmiListeyiTemizle.Text = "Listeyi temizle";
            this.tsmiListeyiTemizle.Click += new System.EventHandler(this.tsmiListeyiTemizle_Click);
            // 
            // lblKalemSayisi
            // 
            this.lblKalemSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalemSayisi.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblKalemSayisi.Location = new System.Drawing.Point(1084, 126);
            this.lblKalemSayisi.Name = "lblKalemSayisi";
            this.lblKalemSayisi.Size = new System.Drawing.Size(140, 13);
            this.lblKalemSayisi.TabIndex = 59;
            this.lblKalemSayisi.Text = "lblKalemSayisi";
            this.lblKalemSayisi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbOdemeTipi
            // 
            this.cbOdemeTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOdemeTipi.FormattingEnabled = true;
            this.cbOdemeTipi.Items.AddRange(new object[] {
            "KDV Hariç",
            "KDV Dahil"});
            this.cbOdemeTipi.Location = new System.Drawing.Point(1134, 29);
            this.cbOdemeTipi.Name = "cbOdemeTipi";
            this.cbOdemeTipi.Size = new System.Drawing.Size(77, 21);
            this.cbOdemeTipi.TabIndex = 22;
            // 
            // lblSeciliKayit
            // 
            this.lblSeciliKayit.AccessibleDescription = "";
            this.lblSeciliKayit.AutoSize = true;
            this.lblSeciliKayit.Location = new System.Drawing.Point(290, 204);
            this.lblSeciliKayit.Name = "lblSeciliKayit";
            this.lblSeciliKayit.Size = new System.Drawing.Size(65, 13);
            this.lblSeciliKayit.TabIndex = 63;
            this.lblSeciliKayit.Text = "lblSeciliKayit";
            this.lblSeciliKayit.Visible = false;
            this.lblSeciliKayit.TextChanged += new System.EventHandler(this.lblSeciliUrun_TextChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chkToplamFiyat);
            this.splitContainer1.Panel1.Controls.Add(this.txtVergiNo);
            this.splitContainer1.Panel1.Controls.Add(this.txtVergiDairesi);
            this.splitContainer1.Panel1.Controls.Add(this.lblVN);
            this.splitContainer1.Panel1.Controls.Add(this.lblVD);
            this.splitContainer1.Panel1.Controls.Add(this.txtCepTel);
            this.splitContainer1.Panel1.Controls.Add(this.txtTcKimlik);
            this.splitContainer1.Panel1.Controls.Add(this.txtAdSoyad);
            this.splitContainer1.Panel1.Controls.Add(this.txtAdres);
            this.splitContainer1.Panel1.Controls.Add(this.lblAdSoyad);
            this.splitContainer1.Panel1.Controls.Add(this.lblAdres);
            this.splitContainer1.Panel1.Controls.Add(this.lblCepTel);
            this.splitContainer1.Panel1.Controls.Add(this.lblTcKimlik);
            this.splitContainer1.Panel1.Controls.Add(this.chkCariKayit);
            this.splitContainer1.Panel1.Controls.Add(this.txtMecraNo);
            this.splitContainer1.Panel1.Controls.Add(this.lblMecraNo);
            this.splitContainer1.Panel1.Controls.Add(this.lblMecra);
            this.splitContainer1.Panel1.Controls.Add(this.cmbMecra);
            this.splitContainer1.Panel1.Controls.Add(this.btnUrunSec);
            this.splitContainer1.Panel1.Controls.Add(this.cbUrunler);
            this.splitContainer1.Panel1.Controls.Add(this.txtOdenenTutar);
            this.splitContainer1.Panel1.Controls.Add(this.btnSatisTamamla);
            this.splitContainer1.Panel1.Controls.Add(this.cbOdemeTipi);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.txtUrunler);
            this.splitContainer1.Panel1.Controls.Add(this.gbFaturaBilgileri);
            this.splitContainer1.Panel1.Controls.Add(this.cbAlisKdvDahil);
            this.splitContainer1.Panel1.Controls.Add(this.txtIskonto);
            this.splitContainer1.Panel1.Controls.Add(this.txtFirmalar);
            this.splitContainer1.Panel1.Controls.Add(this.txtAlisFiyati);
            this.splitContainer1.Panel1.Controls.Add(this.btnStokListesi);
            this.splitContainer1.Panel1.Controls.Add(this.lblIskonto);
            this.splitContainer1.Panel1.Controls.Add(this.lblSeciliFirma);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.dtpTarihBaslangic);
            this.splitContainer1.Panel1.Controls.Add(this.lblUrunSeriali);
            this.splitContainer1.Panel1.Controls.Add(this.lblSeciliKayit);
            this.splitContainer1.Panel1.Controls.Add(this.lblToplamIskonto);
            this.splitContainer1.Panel1.Controls.Add(this.txtUrunSerial);
            this.splitContainer1.Panel1.Controls.Add(this.lblGenelToplam);
            this.splitContainer1.Panel1.Controls.Add(this.lblSeciliUrun);
            this.splitContainer1.Panel1.Controls.Add(this.lblAraToplam);
            this.splitContainer1.Panel1.Controls.Add(this.cbFirmaMusteri);
            this.splitContainer1.Panel1.Controls.Add(this.lblToplamKdv);
            this.splitContainer1.Panel1.Controls.Add(this.btnFirmaSec);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.lblUrunAdi);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.lblUrunModel);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.lblSatisFiyati);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.lblUrunKdv);
            this.splitContainer1.Panel1.Controls.Add(this.lblTL1);
            this.splitContainer1.Panel1.Controls.Add(this.lblUrunMiktar);
            this.splitContainer1.Panel1.Controls.Add(this.txtGenelToplam);
            this.splitContainer1.Panel1.Controls.Add(this.txtUrunAdi);
            this.splitContainer1.Panel1.Controls.Add(this.txtToplamKdv);
            this.splitContainer1.Panel1.Controls.Add(this.txtUrunModeli);
            this.splitContainer1.Panel1.Controls.Add(this.txtAraToplam);
            this.splitContainer1.Panel1.Controls.Add(this.txtSatisFiyati);
            this.splitContainer1.Panel1.Controls.Add(this.txtToplamIskonto);
            this.splitContainer1.Panel1.Controls.Add(this.txtUrunKdv);
            this.splitContainer1.Panel1.Controls.Add(this.txtToplamTutar);
            this.splitContainer1.Panel1.Controls.Add(this.txtUrunMiktar);
            this.splitContainer1.Panel1.Controls.Add(this.lblKalemSayisi);
            this.splitContainer1.Panel1.Controls.Add(this.lblToplamTutar);
            this.splitContainer1.Panel1.Controls.Add(this.btnStokEkle);
            this.splitContainer1.Panel1.Controls.Add(this.lblMiktar);
            this.splitContainer1.Panel1.Controls.Add(this.txtStokAdet);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgwUrunler);
            this.splitContainer1.Size = new System.Drawing.Size(1028, 519);
            this.splitContainer1.SplitterDistance = 224;
            this.splitContainer1.TabIndex = 65;
            // 
            // txtVergiNo
            // 
            this.txtVergiNo.Location = new System.Drawing.Point(670, 199);
            this.txtVergiNo.Name = "txtVergiNo";
            this.txtVergiNo.Size = new System.Drawing.Size(101, 20);
            this.txtVergiNo.TabIndex = 18;
            this.txtVergiNo.Visible = false;
            // 
            // txtVergiDairesi
            // 
            this.txtVergiDairesi.Location = new System.Drawing.Point(670, 177);
            this.txtVergiDairesi.Name = "txtVergiDairesi";
            this.txtVergiDairesi.Size = new System.Drawing.Size(101, 20);
            this.txtVergiDairesi.TabIndex = 17;
            this.txtVergiDairesi.Visible = false;
            // 
            // lblVN
            // 
            this.lblVN.AutoSize = true;
            this.lblVN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVN.ForeColor = System.Drawing.Color.Black;
            this.lblVN.Location = new System.Drawing.Point(586, 202);
            this.lblVN.Name = "lblVN";
            this.lblVN.Size = new System.Drawing.Size(56, 13);
            this.lblVN.TabIndex = 82;
            this.lblVN.Text = "Vergi No";
            this.lblVN.Visible = false;
            // 
            // lblVD
            // 
            this.lblVD.AutoSize = true;
            this.lblVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVD.ForeColor = System.Drawing.Color.Black;
            this.lblVD.Location = new System.Drawing.Point(586, 180);
            this.lblVD.Name = "lblVD";
            this.lblVD.Size = new System.Drawing.Size(79, 13);
            this.lblVD.TabIndex = 83;
            this.lblVD.Text = "Vergi Dairesi";
            this.lblVD.Visible = false;
            // 
            // txtCepTel
            // 
            this.txtCepTel.Location = new System.Drawing.Point(633, 72);
            this.txtCepTel.Mask = "000-000-00-00";
            this.txtCepTel.Name = "txtCepTel";
            this.txtCepTel.Size = new System.Drawing.Size(131, 20);
            this.txtCepTel.TabIndex = 15;
            // 
            // txtTcKimlik
            // 
            this.txtTcKimlik.Location = new System.Drawing.Point(633, 44);
            this.txtTcKimlik.Mask = "00000000000";
            this.txtTcKimlik.Name = "txtTcKimlik";
            this.txtTcKimlik.Size = new System.Drawing.Size(131, 20);
            this.txtTcKimlik.TabIndex = 14;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(633, 16);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(131, 20);
            this.txtAdSoyad.TabIndex = 13;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(633, 98);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(131, 71);
            this.txtAdres.TabIndex = 16;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.ForeColor = System.Drawing.Color.Black;
            this.lblAdSoyad.Location = new System.Drawing.Point(566, 19);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(61, 13);
            this.lblAdSoyad.TabIndex = 73;
            this.lblAdSoyad.Text = "Ad Soyad";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.ForeColor = System.Drawing.Color.Black;
            this.lblAdres.Location = new System.Drawing.Point(588, 100);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(39, 13);
            this.lblAdres.TabIndex = 74;
            this.lblAdres.Text = "Adres";
            // 
            // lblCepTel
            // 
            this.lblCepTel.AutoSize = true;
            this.lblCepTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCepTel.ForeColor = System.Drawing.Color.Black;
            this.lblCepTel.Location = new System.Drawing.Point(593, 79);
            this.lblCepTel.Name = "lblCepTel";
            this.lblCepTel.Size = new System.Drawing.Size(34, 13);
            this.lblCepTel.TabIndex = 76;
            this.lblCepTel.Text = "GSM";
            // 
            // lblTcKimlik
            // 
            this.lblTcKimlik.AutoSize = true;
            this.lblTcKimlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTcKimlik.ForeColor = System.Drawing.Color.Black;
            this.lblTcKimlik.Location = new System.Drawing.Point(547, 48);
            this.lblTcKimlik.Name = "lblTcKimlik";
            this.lblTcKimlik.Size = new System.Drawing.Size(80, 13);
            this.lblTcKimlik.TabIndex = 77;
            this.lblTcKimlik.Text = "TC Kimlik No";
            // 
            // chkCariKayit
            // 
            this.chkCariKayit.AutoSize = true;
            this.chkCariKayit.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkCariKayit.Checked = true;
            this.chkCariKayit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCariKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkCariKayit.Location = new System.Drawing.Point(208, 64);
            this.chkCariKayit.Name = "chkCariKayit";
            this.chkCariKayit.Size = new System.Drawing.Size(131, 17);
            this.chkCariKayit.TabIndex = 4;
            this.chkCariKayit.Text = "Cari Kaydı Yapılsın";
            this.chkCariKayit.UseVisualStyleBackColor = true;
            this.chkCariKayit.CheckedChanged += new System.EventHandler(this.chkCariKayit_CheckedChanged);
            // 
            // txtMecraNo
            // 
            this.txtMecraNo.Location = new System.Drawing.Point(417, 42);
            this.txtMecraNo.Name = "txtMecraNo";
            this.txtMecraNo.Size = new System.Drawing.Size(121, 20);
            this.txtMecraNo.TabIndex = 12;
            // 
            // lblMecraNo
            // 
            this.lblMecraNo.AutoSize = true;
            this.lblMecraNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMecraNo.Location = new System.Drawing.Point(343, 45);
            this.lblMecraNo.Name = "lblMecraNo";
            this.lblMecraNo.Size = new System.Drawing.Size(62, 13);
            this.lblMecraNo.TabIndex = 67;
            this.lblMecraNo.Text = "Mecra No";
            // 
            // lblMecra
            // 
            this.lblMecra.AutoSize = true;
            this.lblMecra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMecra.Location = new System.Drawing.Point(363, 17);
            this.lblMecra.Name = "lblMecra";
            this.lblMecra.Size = new System.Drawing.Size(42, 13);
            this.lblMecra.TabIndex = 67;
            this.lblMecra.Text = "Mecra";
            // 
            // cmbMecra
            // 
            this.cmbMecra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMecra.FormattingEnabled = true;
            this.cmbMecra.Items.AddRange(new object[] {
            "N11",
            "Hepsiburada",
            "Gittigidiyor",
            "Sahibinden",
            "Trendyol",
            "Amazon",
            "PttAvm",
            "Hiçbiri"});
            this.cmbMecra.Location = new System.Drawing.Point(417, 12);
            this.cmbMecra.Name = "cmbMecra";
            this.cmbMecra.Size = new System.Drawing.Size(121, 21);
            this.cmbMecra.TabIndex = 11;
            // 
            // chkToplamFiyat
            // 
            this.chkToplamFiyat.AutoSize = true;
            this.chkToplamFiyat.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkToplamFiyat.Checked = true;
            this.chkToplamFiyat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkToplamFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkToplamFiyat.Location = new System.Drawing.Point(388, 203);
            this.chkToplamFiyat.Name = "chkToplamFiyat";
            this.chkToplamFiyat.Size = new System.Drawing.Size(98, 17);
            this.chkToplamFiyat.TabIndex = 85;
            this.chkToplamFiyat.Text = "Toplam Fiyat";
            this.chkToplamFiyat.UseVisualStyleBackColor = true;
            // 
            // frmStokYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 519);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStokYonetimi";
            this.Text = "ALIŞ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUrunYonetimi_FormClosed);
            this.Load += new System.EventHandler(this.frmStokYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrunler)).EndInit();
            this.gbFaturaBilgileri.ResumeLayout(false);
            this.gbFaturaBilgileri.PerformLayout();
            this.menuSag.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbUrunler;
        private System.Windows.Forms.TextBox txtUrunler;
        private System.Windows.Forms.Button btnStokListesi;
        private System.Windows.Forms.DateTimePicker dtpTarihBaslangic;
        private System.Windows.Forms.Label lblUrunSeriali;
        private System.Windows.Forms.Label lblSatisFiyati;
        private System.Windows.Forms.Label lblUrunModel;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.Label lblUrunMiktar;
        private System.Windows.Forms.Label txtUrunSerial;
        private System.Windows.Forms.Button btnStokEkle;
        private System.Windows.Forms.Label txtUrunAdi;
        private System.Windows.Forms.Label txtUrunModeli;
        private System.Windows.Forms.Label txtSatisFiyati;
        private System.Windows.Forms.NumericUpDown txtStokAdet;
        private System.Windows.Forms.DataGridView dgwUrunler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtUrunMiktar;
        private System.Windows.Forms.ComboBox cbAlisKdvDahil;
        private System.Windows.Forms.TextBox txtAlisFiyati;
        private System.Windows.Forms.Label lblIskonto;
        private System.Windows.Forms.TextBox txtIskonto;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label lblToplamIskonto;
        private System.Windows.Forms.Label lblAraToplam;
        private System.Windows.Forms.Label lblToplamKdv;
        private System.Windows.Forms.Label lblGenelToplam;
        private System.Windows.Forms.Label lblTL1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtToplamTutar;
        private System.Windows.Forms.Label txtToplamIskonto;
        private System.Windows.Forms.Label txtAraToplam;
        private System.Windows.Forms.Label txtToplamKdv;
        private System.Windows.Forms.Label txtGenelToplam;
        private System.Windows.Forms.Label lblUrunKdv;
        private System.Windows.Forms.Label txtUrunKdv;
        private System.Windows.Forms.Button btnUrunSec;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.Label lblSeciliUrun;
        private System.Windows.Forms.ComboBox cbFirmaMusteri;
        private System.Windows.Forms.Button btnFirmaSec;
        private System.Windows.Forms.TextBox txtFirmalar;
        private System.Windows.Forms.Label lblSeciliFirma;
        private System.Windows.Forms.GroupBox gbFaturaBilgileri;
        private System.Windows.Forms.TextBox txtFaturaNo;
        private System.Windows.Forms.Label lblFaturaTip;
        private System.Windows.Forms.Label lblFaturaNo;
        private System.Windows.Forms.ComboBox cbFaturaTip;
        private System.Windows.Forms.TextBox txtFaturaAciklama;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOdenenTutar;
        private System.Windows.Forms.Button btnSatisTamamla;
        private System.Windows.Forms.ContextMenuStrip menuSag;
        private System.Windows.Forms.ToolStripMenuItem tsmiSatirSil;
        private System.Windows.Forms.ToolStripMenuItem tsmiListeyiTemizle;
        private System.Windows.Forms.Label lblKalemSayisi;
        private System.Windows.Forms.ComboBox cbOdemeTipi;
        private System.Windows.Forms.Label lblSeciliKayit;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn stok_miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn iskonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn birim_fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn birim_fiyat_kdv_dahil;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplam_fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplam_fiyat_kdv_dahil;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_model;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplam_iskonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ara_toplam;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplam_kdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn genel_toplam;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdv_dahil;
        private System.Windows.Forms.ComboBox cmbMecra;
        private System.Windows.Forms.TextBox txtMecraNo;
        private System.Windows.Forms.Label lblMecraNo;
        private System.Windows.Forms.Label lblMecra;
        private System.Windows.Forms.CheckBox chkCariKayit;
        private System.Windows.Forms.MaskedTextBox txtCepTel;
        private System.Windows.Forms.MaskedTextBox txtTcKimlik;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblCepTel;
        private System.Windows.Forms.Label lblTcKimlik;
        private System.Windows.Forms.TextBox txtVergiNo;
        private System.Windows.Forms.TextBox txtVergiDairesi;
        private System.Windows.Forms.Label lblVN;
        private System.Windows.Forms.Label lblVD;
        private System.Windows.Forms.CheckBox chkToplamFiyat;
    }
}