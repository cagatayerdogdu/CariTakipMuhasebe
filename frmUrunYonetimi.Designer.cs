namespace StokTakip
{
    partial class frmUrunYonetimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunYonetimi));
            this.txtUrunAdi = new System.Windows.Forms.ComboBox();
            this.txtUrunSerial = new System.Windows.Forms.TextBox();
            this.txtUrunMarkasi = new System.Windows.Forms.TextBox();
            this.lblUrunSeriali = new System.Windows.Forms.Label();
            this.lblUrunModel = new System.Windows.Forms.Label();
            this.lblUrunMarkasi = new System.Windows.Forms.Label();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.btnUrunKaydet = new System.Windows.Forms.Button();
            this.dgwUrunler = new System.Windows.Forms.DataGridView();
            this.clmGiris_DepoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGiris_UrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGiris_UrunMarkasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGiris_UrunModeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGiris_UrunSeriali = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_birim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_kdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_kdv_dahil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_fiyat_kdv_dahil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_alis_fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_alis_kdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_alis_kdv_dahil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_alis_fiyat_kdv_dahil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuSag = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuSecilenUrunuSifirlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSecilenCikisiSifirlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSecilenArizaServistenDonduToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSecilenUrunuHurdayaAyirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSecilenIstekKaydiSifirlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSecilenUrununCikisiniYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.epHataDedektoru = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnUrunYonetimi_ExceleAktar = new System.Windows.Forms.Button();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.lblSatisFiyati = new System.Windows.Forms.Label();
            this.txtSatisFiyati = new System.Windows.Forms.TextBox();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.btnArama = new System.Windows.Forms.Button();
            this.txtUrunModeli = new System.Windows.Forms.ComboBox();
            this.lblUrunBirim = new System.Windows.Forms.Label();
            this.cbUrunBirim = new System.Windows.Forms.ComboBox();
            this.txtKdv = new System.Windows.Forms.TextBox();
            this.lblKdv = new System.Windows.Forms.Label();
            this.pnlCopler = new System.Windows.Forms.Panel();
            this.cbSatisKdvDahil = new System.Windows.Forms.ComboBox();
            this.lblAlisFiyati = new System.Windows.Forms.Label();
            this.txtAlisFiyati = new System.Windows.Forms.TextBox();
            this.cbAlisKdvDahil = new System.Windows.Forms.ComboBox();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.cmbKdv = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrunler)).BeginInit();
            this.menuSag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epHataDedektoru)).BeginInit();
            this.pnlCopler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.txtUrunAdi.FormattingEnabled = true;
            this.txtUrunAdi.Location = new System.Drawing.Point(109, 73);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(164, 21);
            this.txtUrunAdi.TabIndex = 11;
            // 
            // txtUrunSerial
            // 
            this.txtUrunSerial.Location = new System.Drawing.Point(109, 45);
            this.txtUrunSerial.Name = "txtUrunSerial";
            this.txtUrunSerial.Size = new System.Drawing.Size(163, 20);
            this.txtUrunSerial.TabIndex = 10;
            // 
            // txtUrunMarkasi
            // 
            this.txtUrunMarkasi.Location = new System.Drawing.Point(50, 45);
            this.txtUrunMarkasi.Name = "txtUrunMarkasi";
            this.txtUrunMarkasi.Size = new System.Drawing.Size(37, 20);
            this.txtUrunMarkasi.TabIndex = 0;
            // 
            // lblUrunSeriali
            // 
            this.lblUrunSeriali.AutoSize = true;
            this.lblUrunSeriali.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunSeriali.ForeColor = System.Drawing.Color.Black;
            this.lblUrunSeriali.Location = new System.Drawing.Point(3, 48);
            this.lblUrunSeriali.Name = "lblUrunSeriali";
            this.lblUrunSeriali.Size = new System.Drawing.Size(103, 13);
            this.lblUrunSeriali.TabIndex = 18;
            this.lblUrunSeriali.Text = "Barkod Numarası";
            // 
            // lblUrunModel
            // 
            this.lblUrunModel.AutoSize = true;
            this.lblUrunModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunModel.ForeColor = System.Drawing.Color.Black;
            this.lblUrunModel.Location = new System.Drawing.Point(3, 103);
            this.lblUrunModel.Name = "lblUrunModel";
            this.lblUrunModel.Size = new System.Drawing.Size(65, 13);
            this.lblUrunModel.TabIndex = 19;
            this.lblUrunModel.Text = "Ürün Cinsi";
            // 
            // lblUrunMarkasi
            // 
            this.lblUrunMarkasi.AutoSize = true;
            this.lblUrunMarkasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunMarkasi.ForeColor = System.Drawing.Color.Black;
            this.lblUrunMarkasi.Location = new System.Drawing.Point(5, 17);
            this.lblUrunMarkasi.Name = "lblUrunMarkasi";
            this.lblUrunMarkasi.Size = new System.Drawing.Size(82, 13);
            this.lblUrunMarkasi.TabIndex = 0;
            this.lblUrunMarkasi.Text = "Ürün Markası";
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAdi.ForeColor = System.Drawing.Color.Black;
            this.lblUrunAdi.Location = new System.Drawing.Point(3, 76);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(56, 13);
            this.lblUrunAdi.TabIndex = 21;
            this.lblUrunAdi.Text = "Ürün Adı";
            // 
            // btnUrunKaydet
            // 
            this.btnUrunKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUrunKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrunKaydet.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnUrunKaydet.Location = new System.Drawing.Point(755, 21);
            this.btnUrunKaydet.Name = "btnUrunKaydet";
            this.btnUrunKaydet.Size = new System.Drawing.Size(244, 38);
            this.btnUrunKaydet.TabIndex = 20;
            this.btnUrunKaydet.Text = "KAYDET";
            this.btnUrunKaydet.UseVisualStyleBackColor = true;
            this.btnUrunKaydet.Click += new System.EventHandler(this.btnUrunKaydet_Click);
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
            this.dgwUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUrunler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmGiris_DepoId,
            this.clmGiris_UrunAdi,
            this.clmGiris_UrunMarkasi,
            this.clmGiris_UrunModeli,
            this.clmGiris_UrunSeriali,
            this.urun_fiyat,
            this.urun_birim,
            this.urun_kdv,
            this.urun_kdv_dahil,
            this.urun_fiyat_kdv_dahil,
            this.urun_alis_fiyat,
            this.urun_alis_kdv,
            this.urun_alis_kdv_dahil,
            this.urun_alis_fiyat_kdv_dahil,
            this.urun_miktar});
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
            this.dgwUrunler.Size = new System.Drawing.Size(1028, 442);
            this.dgwUrunler.TabIndex = 23;
            this.dgwUrunler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwUrunler_CellDoubleClick);
            this.dgwUrunler.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgwUrunler_MouseUp);
            // 
            // clmGiris_DepoId
            // 
            this.clmGiris_DepoId.DataPropertyName = "urun_id";
            this.clmGiris_DepoId.HeaderText = "KAYIT ID";
            this.clmGiris_DepoId.Name = "clmGiris_DepoId";
            this.clmGiris_DepoId.ReadOnly = true;
            this.clmGiris_DepoId.Visible = false;
            // 
            // clmGiris_UrunAdi
            // 
            this.clmGiris_UrunAdi.DataPropertyName = "urun_ad";
            this.clmGiris_UrunAdi.FillWeight = 286.403F;
            this.clmGiris_UrunAdi.HeaderText = "ADI";
            this.clmGiris_UrunAdi.Name = "clmGiris_UrunAdi";
            this.clmGiris_UrunAdi.ReadOnly = true;
            // 
            // clmGiris_UrunMarkasi
            // 
            this.clmGiris_UrunMarkasi.DataPropertyName = "urun_marka";
            this.clmGiris_UrunMarkasi.HeaderText = "ÜRÜN MARKASI";
            this.clmGiris_UrunMarkasi.Name = "clmGiris_UrunMarkasi";
            this.clmGiris_UrunMarkasi.ReadOnly = true;
            this.clmGiris_UrunMarkasi.Visible = false;
            // 
            // clmGiris_UrunModeli
            // 
            this.clmGiris_UrunModeli.DataPropertyName = "urun_model";
            this.clmGiris_UrunModeli.FillWeight = 82.08843F;
            this.clmGiris_UrunModeli.HeaderText = "CİNSİ";
            this.clmGiris_UrunModeli.Name = "clmGiris_UrunModeli";
            this.clmGiris_UrunModeli.ReadOnly = true;
            // 
            // clmGiris_UrunSeriali
            // 
            this.clmGiris_UrunSeriali.DataPropertyName = "urun_serial";
            this.clmGiris_UrunSeriali.FillWeight = 87.02757F;
            this.clmGiris_UrunSeriali.HeaderText = "BARKODU";
            this.clmGiris_UrunSeriali.Name = "clmGiris_UrunSeriali";
            this.clmGiris_UrunSeriali.ReadOnly = true;
            // 
            // urun_fiyat
            // 
            this.urun_fiyat.DataPropertyName = "urun_fiyat";
            this.urun_fiyat.FillWeight = 55.64633F;
            this.urun_fiyat.HeaderText = "SATIŞ";
            this.urun_fiyat.Name = "urun_fiyat";
            this.urun_fiyat.ReadOnly = true;
            // 
            // urun_birim
            // 
            this.urun_birim.DataPropertyName = "urun_birim";
            this.urun_birim.FillWeight = 51.80371F;
            this.urun_birim.HeaderText = "BİRİM";
            this.urun_birim.Name = "urun_birim";
            this.urun_birim.ReadOnly = true;
            // 
            // urun_kdv
            // 
            this.urun_kdv.DataPropertyName = "urun_kdv";
            this.urun_kdv.HeaderText = "SATIŞ KDV";
            this.urun_kdv.Name = "urun_kdv";
            this.urun_kdv.ReadOnly = true;
            this.urun_kdv.Visible = false;
            // 
            // urun_kdv_dahil
            // 
            this.urun_kdv_dahil.DataPropertyName = "urun_kdv_dahil";
            this.urun_kdv_dahil.HeaderText = "SATIŞ KDV DAHİL";
            this.urun_kdv_dahil.Name = "urun_kdv_dahil";
            this.urun_kdv_dahil.ReadOnly = true;
            this.urun_kdv_dahil.Visible = false;
            // 
            // urun_fiyat_kdv_dahil
            // 
            this.urun_fiyat_kdv_dahil.DataPropertyName = "urun_fiyat_kdv_dahil";
            this.urun_fiyat_kdv_dahil.FillWeight = 93.55482F;
            this.urun_fiyat_kdv_dahil.HeaderText = "SATIŞ + KDV";
            this.urun_fiyat_kdv_dahil.Name = "urun_fiyat_kdv_dahil";
            this.urun_fiyat_kdv_dahil.ReadOnly = true;
            // 
            // urun_alis_fiyat
            // 
            this.urun_alis_fiyat.DataPropertyName = "urun_alis_fiyat";
            this.urun_alis_fiyat.FillWeight = 67.72081F;
            this.urun_alis_fiyat.HeaderText = "ALIŞ";
            this.urun_alis_fiyat.Name = "urun_alis_fiyat";
            this.urun_alis_fiyat.ReadOnly = true;
            // 
            // urun_alis_kdv
            // 
            this.urun_alis_kdv.DataPropertyName = "urun_alis_kdv";
            this.urun_alis_kdv.HeaderText = "ALIŞ KDV";
            this.urun_alis_kdv.Name = "urun_alis_kdv";
            this.urun_alis_kdv.ReadOnly = true;
            this.urun_alis_kdv.Visible = false;
            // 
            // urun_alis_kdv_dahil
            // 
            this.urun_alis_kdv_dahil.DataPropertyName = "urun_alis_kdv_dahil";
            this.urun_alis_kdv_dahil.HeaderText = "ALIŞ KDV DAHİL";
            this.urun_alis_kdv_dahil.Name = "urun_alis_kdv_dahil";
            this.urun_alis_kdv_dahil.ReadOnly = true;
            this.urun_alis_kdv_dahil.Visible = false;
            // 
            // urun_alis_fiyat_kdv_dahil
            // 
            this.urun_alis_fiyat_kdv_dahil.DataPropertyName = "urun_alis_fiyat_kdv_dahil";
            this.urun_alis_fiyat_kdv_dahil.FillWeight = 102.4244F;
            this.urun_alis_fiyat_kdv_dahil.HeaderText = "ALIŞ + KDV";
            this.urun_alis_fiyat_kdv_dahil.Name = "urun_alis_fiyat_kdv_dahil";
            this.urun_alis_fiyat_kdv_dahil.ReadOnly = true;
            // 
            // urun_miktar
            // 
            this.urun_miktar.DataPropertyName = "urun_miktar";
            this.urun_miktar.FillWeight = 73.3308F;
            this.urun_miktar.HeaderText = "MİKTAR";
            this.urun_miktar.Name = "urun_miktar";
            this.urun_miktar.ReadOnly = true;
            // 
            // menuSag
            // 
            this.menuSag.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSecilenUrunuSifirlaToolStripMenuItem,
            this.menuSecilenCikisiSifirlaToolStripMenuItem,
            this.menuSecilenArizaServistenDonduToolStripMenuItem,
            this.menuSecilenUrunuHurdayaAyirToolStripMenuItem,
            this.menuSecilenIstekKaydiSifirlaToolStripMenuItem,
            this.menuSecilenUrununCikisiniYapToolStripMenuItem});
            this.menuSag.Name = "menuSag";
            this.menuSag.Size = new System.Drawing.Size(230, 136);
            // 
            // menuSecilenUrunuSifirlaToolStripMenuItem
            // 
            this.menuSecilenUrunuSifirlaToolStripMenuItem.Name = "menuSecilenUrunuSifirlaToolStripMenuItem";
            this.menuSecilenUrunuSifirlaToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.menuSecilenUrunuSifirlaToolStripMenuItem.Text = "Ürün seçimini sıfırla";
            this.menuSecilenUrunuSifirlaToolStripMenuItem.Click += new System.EventHandler(this.menuSecilenUrunuSifirlaToolStripMenuItem_Click);
            // 
            // menuSecilenCikisiSifirlaToolStripMenuItem
            // 
            this.menuSecilenCikisiSifirlaToolStripMenuItem.Name = "menuSecilenCikisiSifirlaToolStripMenuItem";
            this.menuSecilenCikisiSifirlaToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.menuSecilenCikisiSifirlaToolStripMenuItem.Text = "Seçilen Çıkış Kaydını Sıfırla";
            // 
            // menuSecilenArizaServistenDonduToolStripMenuItem
            // 
            this.menuSecilenArizaServistenDonduToolStripMenuItem.Name = "menuSecilenArizaServistenDonduToolStripMenuItem";
            this.menuSecilenArizaServistenDonduToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.menuSecilenArizaServistenDonduToolStripMenuItem.Text = "Seçilen Ürün Servisten Döndü";
            // 
            // menuSecilenUrunuHurdayaAyirToolStripMenuItem
            // 
            this.menuSecilenUrunuHurdayaAyirToolStripMenuItem.Name = "menuSecilenUrunuHurdayaAyirToolStripMenuItem";
            this.menuSecilenUrunuHurdayaAyirToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.menuSecilenUrunuHurdayaAyirToolStripMenuItem.Text = "Seçilen Ürünü Hurdaya Ayır";
            // 
            // menuSecilenIstekKaydiSifirlaToolStripMenuItem
            // 
            this.menuSecilenIstekKaydiSifirlaToolStripMenuItem.Name = "menuSecilenIstekKaydiSifirlaToolStripMenuItem";
            this.menuSecilenIstekKaydiSifirlaToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.menuSecilenIstekKaydiSifirlaToolStripMenuItem.Text = "Seçilen İstek Kaydı Sıfırla";
            // 
            // menuSecilenUrununCikisiniYapToolStripMenuItem
            // 
            this.menuSecilenUrununCikisiniYapToolStripMenuItem.Name = "menuSecilenUrununCikisiniYapToolStripMenuItem";
            this.menuSecilenUrununCikisiniYapToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.menuSecilenUrununCikisiniYapToolStripMenuItem.Text = "Seçilen Ürünün Çıkışını Yap";
            // 
            // epHataDedektoru
            // 
            this.epHataDedektoru.ContainerControl = this;
            // 
            // btnUrunYonetimi_ExceleAktar
            // 
            this.btnUrunYonetimi_ExceleAktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunYonetimi_ExceleAktar.ForeColor = System.Drawing.Color.Black;
            this.epHataDedektoru.SetIconAlignment(this.btnUrunYonetimi_ExceleAktar, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.btnUrunYonetimi_ExceleAktar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunYonetimi_ExceleAktar.Location = new System.Drawing.Point(601, 76);
            this.btnUrunYonetimi_ExceleAktar.Name = "btnUrunYonetimi_ExceleAktar";
            this.btnUrunYonetimi_ExceleAktar.Size = new System.Drawing.Size(66, 37);
            this.btnUrunYonetimi_ExceleAktar.TabIndex = 27;
            this.btnUrunYonetimi_ExceleAktar.Text = "EXCELE AKTAR";
            this.btnUrunYonetimi_ExceleAktar.UseVisualStyleBackColor = true;
            this.btnUrunYonetimi_ExceleAktar.Click += new System.EventHandler(this.btnUrunYonetimi_ExceleAktar_Click);
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUrunSil.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunSil.ForeColor = System.Drawing.Color.DarkRed;
            this.btnUrunSil.Location = new System.Drawing.Point(755, 65);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(245, 38);
            this.btnUrunSil.TabIndex = 21;
            this.btnUrunSil.Text = "SİL";
            this.btnUrunSil.UseVisualStyleBackColor = true;
            this.btnUrunSil.Visible = false;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // lblSatisFiyati
            // 
            this.lblSatisFiyati.AutoSize = true;
            this.lblSatisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatisFiyati.ForeColor = System.Drawing.Color.Black;
            this.lblSatisFiyati.Location = new System.Drawing.Point(329, 96);
            this.lblSatisFiyati.Name = "lblSatisFiyati";
            this.lblSatisFiyati.Size = new System.Drawing.Size(69, 13);
            this.lblSatisFiyati.TabIndex = 19;
            this.lblSatisFiyati.Text = "Satış Fiyatı";
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.Location = new System.Drawing.Point(418, 93);
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Size = new System.Drawing.Size(63, 20);
            this.txtSatisFiyati.TabIndex = 17;
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(74, 18);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(198, 20);
            this.txtArama.TabIndex = 1;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // btnArama
            // 
            this.btnArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArama.Location = new System.Drawing.Point(660, 16);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(65, 38);
            this.btnArama.TabIndex = 2;
            this.btnArama.Text = "ARA";
            this.btnArama.UseVisualStyleBackColor = true;
            this.btnArama.Visible = false;
            this.btnArama.Click += new System.EventHandler(this.btnArama_Click);
            // 
            // txtUrunModeli
            // 
            this.txtUrunModeli.FormattingEnabled = true;
            this.txtUrunModeli.Location = new System.Drawing.Point(110, 100);
            this.txtUrunModeli.Name = "txtUrunModeli";
            this.txtUrunModeli.Size = new System.Drawing.Size(162, 21);
            this.txtUrunModeli.TabIndex = 12;
            // 
            // lblUrunBirim
            // 
            this.lblUrunBirim.AutoSize = true;
            this.lblUrunBirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunBirim.ForeColor = System.Drawing.Color.Black;
            this.lblUrunBirim.Location = new System.Drawing.Point(364, 18);
            this.lblUrunBirim.Name = "lblUrunBirim";
            this.lblUrunBirim.Size = new System.Drawing.Size(34, 13);
            this.lblUrunBirim.TabIndex = 19;
            this.lblUrunBirim.Text = "Birim";
            // 
            // cbUrunBirim
            // 
            this.cbUrunBirim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUrunBirim.FormattingEnabled = true;
            this.cbUrunBirim.Items.AddRange(new object[] {
            "ADET",
            "TOPLU"});
            this.cbUrunBirim.Location = new System.Drawing.Point(418, 13);
            this.cbUrunBirim.Name = "cbUrunBirim";
            this.cbUrunBirim.Size = new System.Drawing.Size(162, 21);
            this.cbUrunBirim.TabIndex = 13;
            // 
            // txtKdv
            // 
            this.txtKdv.Location = new System.Drawing.Point(418, 41);
            this.txtKdv.Name = "txtKdv";
            this.txtKdv.Size = new System.Drawing.Size(163, 20);
            this.txtKdv.TabIndex = 94;
            this.txtKdv.Visible = false;
            // 
            // lblKdv
            // 
            this.lblKdv.AutoSize = true;
            this.lblKdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKdv.ForeColor = System.Drawing.Color.Black;
            this.lblKdv.Location = new System.Drawing.Point(311, 41);
            this.lblKdv.Name = "lblKdv";
            this.lblKdv.Size = new System.Drawing.Size(87, 13);
            this.lblKdv.TabIndex = 20;
            this.lblKdv.Text = "KDV Oranı (%)";
            // 
            // pnlCopler
            // 
            this.pnlCopler.Controls.Add(this.txtUrunMarkasi);
            this.pnlCopler.Controls.Add(this.lblUrunMarkasi);
            this.pnlCopler.Location = new System.Drawing.Point(44, 361);
            this.pnlCopler.Name = "pnlCopler";
            this.pnlCopler.Size = new System.Drawing.Size(90, 77);
            this.pnlCopler.TabIndex = 25;
            this.pnlCopler.Visible = false;
            // 
            // cbSatisKdvDahil
            // 
            this.cbSatisKdvDahil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSatisKdvDahil.FormattingEnabled = true;
            this.cbSatisKdvDahil.Items.AddRange(new object[] {
            "KDV Hariç",
            "KDV Dahil"});
            this.cbSatisKdvDahil.Location = new System.Drawing.Point(486, 93);
            this.cbSatisKdvDahil.Name = "cbSatisKdvDahil";
            this.cbSatisKdvDahil.Size = new System.Drawing.Size(94, 21);
            this.cbSatisKdvDahil.TabIndex = 18;
            // 
            // lblAlisFiyati
            // 
            this.lblAlisFiyati.AutoSize = true;
            this.lblAlisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlisFiyati.ForeColor = System.Drawing.Color.Black;
            this.lblAlisFiyati.Location = new System.Drawing.Point(337, 71);
            this.lblAlisFiyati.Name = "lblAlisFiyati";
            this.lblAlisFiyati.Size = new System.Drawing.Size(61, 13);
            this.lblAlisFiyati.TabIndex = 19;
            this.lblAlisFiyati.Text = "Alış Fiyatı";
            // 
            // txtAlisFiyati
            // 
            this.txtAlisFiyati.Location = new System.Drawing.Point(418, 68);
            this.txtAlisFiyati.Name = "txtAlisFiyati";
            this.txtAlisFiyati.Size = new System.Drawing.Size(63, 20);
            this.txtAlisFiyati.TabIndex = 15;
            // 
            // cbAlisKdvDahil
            // 
            this.cbAlisKdvDahil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlisKdvDahil.FormattingEnabled = true;
            this.cbAlisKdvDahil.Items.AddRange(new object[] {
            "KDV Hariç",
            "KDV Dahil"});
            this.cbAlisKdvDahil.Location = new System.Drawing.Point(486, 68);
            this.cbAlisKdvDahil.Name = "cbAlisKdvDahil";
            this.cbAlisKdvDahil.Size = new System.Drawing.Size(94, 21);
            this.cbAlisKdvDahil.TabIndex = 16;
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.btnUrunYonetimi_ExceleAktar);
            this.scMain.Panel1.Controls.Add(this.cmbKdv);
            this.scMain.Panel1.Controls.Add(this.btnArama);
            this.scMain.Panel1.Controls.Add(this.label1);
            this.scMain.Panel1.Controls.Add(this.lblUrunAdi);
            this.scMain.Panel1.Controls.Add(this.cbAlisKdvDahil);
            this.scMain.Panel1.Controls.Add(this.lblKdv);
            this.scMain.Panel1.Controls.Add(this.cbSatisKdvDahil);
            this.scMain.Panel1.Controls.Add(this.lblUrunModel);
            this.scMain.Panel1.Controls.Add(this.lblUrunBirim);
            this.scMain.Panel1.Controls.Add(this.cbUrunBirim);
            this.scMain.Panel1.Controls.Add(this.lblSatisFiyati);
            this.scMain.Panel1.Controls.Add(this.txtUrunModeli);
            this.scMain.Panel1.Controls.Add(this.lblAlisFiyati);
            this.scMain.Panel1.Controls.Add(this.btnUrunSil);
            this.scMain.Panel1.Controls.Add(this.lblUrunSeriali);
            this.scMain.Panel1.Controls.Add(this.txtKdv);
            this.scMain.Panel1.Controls.Add(this.btnUrunKaydet);
            this.scMain.Panel1.Controls.Add(this.txtSatisFiyati);
            this.scMain.Panel1.Controls.Add(this.txtUrunAdi);
            this.scMain.Panel1.Controls.Add(this.txtAlisFiyati);
            this.scMain.Panel1.Controls.Add(this.txtArama);
            this.scMain.Panel1.Controls.Add(this.txtUrunSerial);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.dgwUrunler);
            this.scMain.Panel2.Controls.Add(this.pnlCopler);
            this.scMain.Size = new System.Drawing.Size(1028, 574);
            this.scMain.SplitterDistance = 128;
            this.scMain.TabIndex = 26;
            // 
            // cmbKdv
            // 
            this.cmbKdv.FormattingEnabled = true;
            this.cmbKdv.Items.AddRange(new object[] {
            "18",
            "8",
            "1",
            "0"});
            this.cmbKdv.Location = new System.Drawing.Point(418, 41);
            this.cmbKdv.Name = "cmbKdv";
            this.cmbKdv.Size = new System.Drawing.Size(63, 21);
            this.cmbKdv.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "ARAMA:";
            // 
            // frmUrunYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 574);
            this.Controls.Add(this.scMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUrunYonetimi";
            this.Text = "ÜRÜN YÖNETİMİ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUrunYonetimi_FormClosed);
            this.Load += new System.EventHandler(this.frmUrunYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrunler)).EndInit();
            this.menuSag.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epHataDedektoru)).EndInit();
            this.pnlCopler.ResumeLayout(false);
            this.pnlCopler.PerformLayout();
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel1.PerformLayout();
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtUrunSerial;
        private System.Windows.Forms.TextBox txtUrunMarkasi;
        private System.Windows.Forms.Label lblUrunSeriali;
        private System.Windows.Forms.Label lblUrunModel;
        private System.Windows.Forms.Label lblUrunMarkasi;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.Button btnUrunKaydet;
        private System.Windows.Forms.DataGridView dgwUrunler;
        private System.Windows.Forms.ContextMenuStrip menuSag;
        private System.Windows.Forms.ToolStripMenuItem menuSecilenUrunuSifirlaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSecilenCikisiSifirlaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSecilenArizaServistenDonduToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSecilenUrunuHurdayaAyirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSecilenIstekKaydiSifirlaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSecilenUrununCikisiniYapToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider epHataDedektoru;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.TextBox txtSatisFiyati;
        private System.Windows.Forms.Label lblSatisFiyati;
        private System.Windows.Forms.Button btnArama;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.ComboBox txtUrunModeli;
        private System.Windows.Forms.ComboBox cbUrunBirim;
        private System.Windows.Forms.TextBox txtKdv;
        private System.Windows.Forms.Label lblUrunBirim;
        private System.Windows.Forms.Label lblKdv;
        private System.Windows.Forms.Panel pnlCopler;
        private System.Windows.Forms.ComboBox cbAlisKdvDahil;
        private System.Windows.Forms.ComboBox cbSatisKdvDahil;
        private System.Windows.Forms.TextBox txtAlisFiyati;
        private System.Windows.Forms.Label lblAlisFiyati;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGiris_DepoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGiris_UrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGiris_UrunMarkasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGiris_UrunModeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGiris_UrunSeriali;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_birim;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_kdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_kdv_dahil;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_fiyat_kdv_dahil;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_alis_fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_alis_kdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_alis_kdv_dahil;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_alis_fiyat_kdv_dahil;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_miktar;
        private System.Windows.Forms.ComboBox cmbKdv;
        private System.Windows.Forms.Button btnUrunYonetimi_ExceleAktar;
    }
}