namespace StokTakip
{
    partial class frmUrunHareketleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunHareketleri));
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.chkFirmaMusteri = new System.Windows.Forms.CheckBox();
            this.dtpTarihBaslangic = new System.Windows.Forms.DateTimePicker();
            this.txtFirmalar = new System.Windows.Forms.TextBox();
            this.dtpTarihBitis = new System.Windows.Forms.DateTimePicker();
            this.lblSeciliIUrunAd = new System.Windows.Forms.Label();
            this.lblSeciliUrun = new System.Windows.Forms.Label();
            this.lblSeciliFirma = new System.Windows.Forms.Label();
            this.cbIslem = new System.Windows.Forms.ComboBox();
            this.lblIslem = new System.Windows.Forms.Label();
            this.lblUrunBaslik = new System.Windows.Forms.Label();
            this.cbFirmaMusteri = new System.Windows.Forms.ComboBox();
            this.btnFirmaSec = new System.Windows.Forms.Button();
            this.scBottom = new System.Windows.Forms.SplitContainer();
            this.dgwStoklar = new System.Windows.Forms.DataGridView();
            this.satis_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.su_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satir_tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islem_kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islem_tipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ad_soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birim_fiyat_kdv_dahil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iskonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplam_fiyat_kdv_dahil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblToplamSatis = new System.Windows.Forms.Label();
            this.lblToplamAlis = new System.Windows.Forms.Label();
            this.menuSag = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSatisEkrani = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scBottom)).BeginInit();
            this.scBottom.Panel1.SuspendLayout();
            this.scBottom.Panel2.SuspendLayout();
            this.scBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStoklar)).BeginInit();
            this.menuSag.SuspendLayout();
            this.SuspendLayout();
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
            this.scMain.Panel1.Controls.Add(this.chkFirmaMusteri);
            this.scMain.Panel1.Controls.Add(this.dtpTarihBaslangic);
            this.scMain.Panel1.Controls.Add(this.txtFirmalar);
            this.scMain.Panel1.Controls.Add(this.dtpTarihBitis);
            this.scMain.Panel1.Controls.Add(this.lblSeciliIUrunAd);
            this.scMain.Panel1.Controls.Add(this.lblSeciliUrun);
            this.scMain.Panel1.Controls.Add(this.lblSeciliFirma);
            this.scMain.Panel1.Controls.Add(this.cbIslem);
            this.scMain.Panel1.Controls.Add(this.lblIslem);
            this.scMain.Panel1.Controls.Add(this.lblUrunBaslik);
            this.scMain.Panel1.Controls.Add(this.cbFirmaMusteri);
            this.scMain.Panel1.Controls.Add(this.btnFirmaSec);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.scBottom);
            this.scMain.Size = new System.Drawing.Size(996, 356);
            this.scMain.SplitterDistance = 91;
            this.scMain.TabIndex = 0;
            // 
            // chkFirmaMusteri
            // 
            this.chkFirmaMusteri.AutoSize = true;
            this.chkFirmaMusteri.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFirmaMusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkFirmaMusteri.Location = new System.Drawing.Point(539, 31);
            this.chkFirmaMusteri.Name = "chkFirmaMusteri";
            this.chkFirmaMusteri.Size = new System.Drawing.Size(111, 17);
            this.chkFirmaMusteri.TabIndex = 100;
            this.chkFirmaMusteri.Text = "Firma / Müşteri";
            this.chkFirmaMusteri.UseVisualStyleBackColor = true;
            this.chkFirmaMusteri.CheckedChanged += new System.EventHandler(this.chkFirmaMusteri_CheckedChanged);
            // 
            // dtpTarihBaslangic
            // 
            this.dtpTarihBaslangic.Location = new System.Drawing.Point(12, 3);
            this.dtpTarihBaslangic.Name = "dtpTarihBaslangic";
            this.dtpTarihBaslangic.Size = new System.Drawing.Size(165, 20);
            this.dtpTarihBaslangic.TabIndex = 85;
            this.dtpTarihBaslangic.Value = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            // 
            // txtFirmalar
            // 
            this.txtFirmalar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirmalar.Location = new System.Drawing.Point(656, 41);
            this.txtFirmalar.Name = "txtFirmalar";
            this.txtFirmalar.Size = new System.Drawing.Size(121, 20);
            this.txtFirmalar.TabIndex = 99;
            this.txtFirmalar.TextChanged += new System.EventHandler(this.cbIslem_SelectedIndexChanged);
            this.txtFirmalar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFirmalar_KeyDown);
            // 
            // dtpTarihBitis
            // 
            this.dtpTarihBitis.Location = new System.Drawing.Point(183, 3);
            this.dtpTarihBitis.Name = "dtpTarihBitis";
            this.dtpTarihBitis.Size = new System.Drawing.Size(165, 20);
            this.dtpTarihBitis.TabIndex = 84;
            this.dtpTarihBitis.Value = new System.DateTime(2020, 1, 27, 0, 0, 0, 0);
            // 
            // lblSeciliIUrunAd
            // 
            this.lblSeciliIUrunAd.AccessibleDescription = "";
            this.lblSeciliIUrunAd.AutoSize = true;
            this.lblSeciliIUrunAd.Location = new System.Drawing.Point(88, 35);
            this.lblSeciliIUrunAd.Name = "lblSeciliIUrunAd";
            this.lblSeciliIUrunAd.Size = new System.Drawing.Size(81, 13);
            this.lblSeciliIUrunAd.TabIndex = 98;
            this.lblSeciliIUrunAd.Text = "lblSeciliIUrunAd";
            // 
            // lblSeciliUrun
            // 
            this.lblSeciliUrun.AccessibleDescription = "";
            this.lblSeciliUrun.AutoSize = true;
            this.lblSeciliUrun.Location = new System.Drawing.Point(870, 37);
            this.lblSeciliUrun.Name = "lblSeciliUrun";
            this.lblSeciliUrun.Size = new System.Drawing.Size(65, 13);
            this.lblSeciliUrun.TabIndex = 98;
            this.lblSeciliUrun.Text = "lblSeciliUrun";
            this.lblSeciliUrun.Visible = false;
            // 
            // lblSeciliFirma
            // 
            this.lblSeciliFirma.AccessibleDescription = "";
            this.lblSeciliFirma.AutoSize = true;
            this.lblSeciliFirma.Location = new System.Drawing.Point(870, 51);
            this.lblSeciliFirma.Name = "lblSeciliFirma";
            this.lblSeciliFirma.Size = new System.Drawing.Size(67, 13);
            this.lblSeciliFirma.TabIndex = 98;
            this.lblSeciliFirma.Text = "lblSeciliFirma";
            this.lblSeciliFirma.Visible = false;
            // 
            // cbIslem
            // 
            this.cbIslem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIslem.FormattingEnabled = true;
            this.cbIslem.Location = new System.Drawing.Point(391, 32);
            this.cbIslem.Name = "cbIslem";
            this.cbIslem.Size = new System.Drawing.Size(121, 21);
            this.cbIslem.TabIndex = 86;
            this.cbIslem.SelectedIndexChanged += new System.EventHandler(this.cbIslem_SelectedIndexChanged);
            // 
            // lblIslem
            // 
            this.lblIslem.AutoSize = true;
            this.lblIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIslem.Location = new System.Drawing.Point(351, 35);
            this.lblIslem.Name = "lblIslem";
            this.lblIslem.Size = new System.Drawing.Size(36, 13);
            this.lblIslem.TabIndex = 87;
            this.lblIslem.Text = "İşlem";
            // 
            // lblUrunBaslik
            // 
            this.lblUrunBaslik.AutoSize = true;
            this.lblUrunBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunBaslik.ForeColor = System.Drawing.Color.Black;
            this.lblUrunBaslik.Location = new System.Drawing.Point(9, 35);
            this.lblUrunBaslik.Name = "lblUrunBaslik";
            this.lblUrunBaslik.Size = new System.Drawing.Size(73, 13);
            this.lblUrunBaslik.TabIndex = 96;
            this.lblUrunBaslik.Text = "Seçili Ürün:";
            this.lblUrunBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbFirmaMusteri
            // 
            this.cbFirmaMusteri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFirmaMusteri.FormattingEnabled = true;
            this.cbFirmaMusteri.Items.AddRange(new object[] {
            "Firma",
            "Müşteri"});
            this.cbFirmaMusteri.Location = new System.Drawing.Point(656, 14);
            this.cbFirmaMusteri.Name = "cbFirmaMusteri";
            this.cbFirmaMusteri.Size = new System.Drawing.Size(72, 21);
            this.cbFirmaMusteri.TabIndex = 89;
            // 
            // btnFirmaSec
            // 
            this.btnFirmaSec.Location = new System.Drawing.Point(734, 13);
            this.btnFirmaSec.Name = "btnFirmaSec";
            this.btnFirmaSec.Size = new System.Drawing.Size(43, 22);
            this.btnFirmaSec.TabIndex = 90;
            this.btnFirmaSec.Text = "SEÇ";
            this.btnFirmaSec.UseVisualStyleBackColor = true;
            this.btnFirmaSec.Click += new System.EventHandler(this.btnFirmaSec_Click);
            // 
            // scBottom
            // 
            this.scBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scBottom.Location = new System.Drawing.Point(0, 0);
            this.scBottom.Name = "scBottom";
            // 
            // scBottom.Panel1
            // 
            this.scBottom.Panel1.Controls.Add(this.dgwStoklar);
            // 
            // scBottom.Panel2
            // 
            this.scBottom.Panel2.Controls.Add(this.label2);
            this.scBottom.Panel2.Controls.Add(this.label1);
            this.scBottom.Panel2.Controls.Add(this.lblToplamSatis);
            this.scBottom.Panel2.Controls.Add(this.lblToplamAlis);
            this.scBottom.Size = new System.Drawing.Size(996, 261);
            this.scBottom.SplitterDistance = 799;
            this.scBottom.TabIndex = 0;
            // 
            // dgwStoklar
            // 
            this.dgwStoklar.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgwStoklar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwStoklar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwStoklar.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgwStoklar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwStoklar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStoklar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.satis_id,
            this.su_id,
            this.satir_tip,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.islem_kod,
            this.islem_tipi,
            this.dataGridViewTextBoxColumn4,
            this.ad_soyad,
            this.urun_serial,
            this.urun_ad,
            this.miktar,
            this.birim_fiyat_kdv_dahil,
            this.iskonto,
            this.toplam_fiyat_kdv_dahil});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwStoklar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwStoklar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwStoklar.Location = new System.Drawing.Point(0, 0);
            this.dgwStoklar.Name = "dgwStoklar";
            this.dgwStoklar.RowHeadersVisible = false;
            this.dgwStoklar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwStoklar.Size = new System.Drawing.Size(799, 261);
            this.dgwStoklar.TabIndex = 82;
            this.dgwStoklar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwStoklar_CellDoubleClick);
            this.dgwStoklar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgwStoklar_MouseUp);
            // 
            // satis_id
            // 
            this.satis_id.DataPropertyName = "satis_id";
            this.satis_id.HeaderText = "KAYIT ID";
            this.satis_id.Name = "satis_id";
            this.satis_id.Visible = false;
            // 
            // su_id
            // 
            this.su_id.DataPropertyName = "su_id";
            this.su_id.HeaderText = "KAYIT SATIR ID";
            this.su_id.Name = "su_id";
            this.su_id.Visible = false;
            // 
            // satir_tip
            // 
            this.satir_tip.DataPropertyName = "satir_tip";
            this.satir_tip.HeaderText = "SATIR TİP";
            this.satir_tip.Name = "satir_tip";
            this.satir_tip.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "tarih";
            this.dataGridViewTextBoxColumn2.HeaderText = "TARİH";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "saat";
            this.dataGridViewTextBoxColumn3.HeaderText = "SAAT";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // islem_kod
            // 
            this.islem_kod.DataPropertyName = "islem_kod";
            this.islem_kod.HeaderText = "İŞLEM KODU";
            this.islem_kod.Name = "islem_kod";
            this.islem_kod.Visible = false;
            // 
            // islem_tipi
            // 
            this.islem_tipi.DataPropertyName = "islem";
            this.islem_tipi.HeaderText = "İŞLEM";
            this.islem_tipi.Name = "islem_tipi";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "yer";
            this.dataGridViewTextBoxColumn4.HeaderText = "MUHATAP";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // ad_soyad
            // 
            this.ad_soyad.DataPropertyName = "ad_soyad";
            this.ad_soyad.HeaderText = "FİRMA/MÜŞTERİ ADI";
            this.ad_soyad.Name = "ad_soyad";
            // 
            // urun_serial
            // 
            this.urun_serial.DataPropertyName = "urun_serial";
            this.urun_serial.HeaderText = "ÜRÜN BARKODU";
            this.urun_serial.Name = "urun_serial";
            // 
            // urun_ad
            // 
            this.urun_ad.DataPropertyName = "urun_ad";
            this.urun_ad.HeaderText = "ÜRÜN ADI";
            this.urun_ad.Name = "urun_ad";
            // 
            // miktar
            // 
            this.miktar.DataPropertyName = "miktar";
            this.miktar.HeaderText = "MİKTAR";
            this.miktar.Name = "miktar";
            // 
            // birim_fiyat_kdv_dahil
            // 
            this.birim_fiyat_kdv_dahil.DataPropertyName = "birim_fiyat_kdv_dahil";
            this.birim_fiyat_kdv_dahil.HeaderText = "BR. FİYAT + KDV";
            this.birim_fiyat_kdv_dahil.Name = "birim_fiyat_kdv_dahil";
            // 
            // iskonto
            // 
            this.iskonto.DataPropertyName = "iskonto";
            this.iskonto.HeaderText = "İSK. %";
            this.iskonto.Name = "iskonto";
            // 
            // toplam_fiyat_kdv_dahil
            // 
            this.toplam_fiyat_kdv_dahil.DataPropertyName = "toplam_fiyat_kdv_dahil";
            this.toplam_fiyat_kdv_dahil.HeaderText = "TOPLAM + KDV";
            this.toplam_fiyat_kdv_dahil.Name = "toplam_fiyat_kdv_dahil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 87;
            this.label2.Text = "Satılan Miktar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 87;
            this.label1.Text = "Alınan Miktar:";
            // 
            // lblToplamSatis
            // 
            this.lblToplamSatis.AccessibleDescription = "";
            this.lblToplamSatis.AutoSize = true;
            this.lblToplamSatis.Location = new System.Drawing.Point(94, 35);
            this.lblToplamSatis.Name = "lblToplamSatis";
            this.lblToplamSatis.Size = new System.Drawing.Size(75, 13);
            this.lblToplamSatis.TabIndex = 98;
            this.lblToplamSatis.Text = "lblToplamSatis";
            // 
            // lblToplamAlis
            // 
            this.lblToplamAlis.AccessibleDescription = "";
            this.lblToplamAlis.AutoSize = true;
            this.lblToplamAlis.Location = new System.Drawing.Point(94, 13);
            this.lblToplamAlis.Name = "lblToplamAlis";
            this.lblToplamAlis.Size = new System.Drawing.Size(68, 13);
            this.lblToplamAlis.TabIndex = 98;
            this.lblToplamAlis.Text = "lblToplamAlis";
            // 
            // menuSag
            // 
            this.menuSag.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSatisEkrani});
            this.menuSag.Name = "menuSag";
            this.menuSag.Size = new System.Drawing.Size(160, 26);
            // 
            // tsmiSatisEkrani
            // 
            this.tsmiSatisEkrani.Name = "tsmiSatisEkrani";
            this.tsmiSatisEkrani.Size = new System.Drawing.Size(159, 22);
            this.tsmiSatisEkrani.Text = "Satış kaydına git";
            this.tsmiSatisEkrani.Click += new System.EventHandler(this.tsmiSatisEkrani_Click);
            // 
            // frmUrunHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 356);
            this.Controls.Add(this.scMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUrunHareketleri";
            this.Text = "ÜRÜN HAREKETLERİ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUrunHareketleri_FormClosed);
            this.Load += new System.EventHandler(this.frmUrunHareketleri_Load);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel1.PerformLayout();
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.scBottom.Panel1.ResumeLayout(false);
            this.scBottom.Panel2.ResumeLayout(false);
            this.scBottom.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scBottom)).EndInit();
            this.scBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwStoklar)).EndInit();
            this.menuSag.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.SplitContainer scBottom;
        private System.Windows.Forms.DateTimePicker dtpTarihBaslangic;
        private System.Windows.Forms.TextBox txtFirmalar;
        private System.Windows.Forms.DateTimePicker dtpTarihBitis;
        private System.Windows.Forms.Label lblSeciliIUrunAd;
        private System.Windows.Forms.Label lblSeciliUrun;
        private System.Windows.Forms.Label lblSeciliFirma;
        private System.Windows.Forms.ComboBox cbIslem;
        private System.Windows.Forms.Label lblIslem;
        private System.Windows.Forms.Label lblUrunBaslik;
        private System.Windows.Forms.ComboBox cbFirmaMusteri;
        private System.Windows.Forms.Button btnFirmaSec;
        private System.Windows.Forms.CheckBox chkFirmaMusteri;
        private System.Windows.Forms.DataGridView dgwStoklar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblToplamSatis;
        private System.Windows.Forms.Label lblToplamAlis;
        private System.Windows.Forms.ContextMenuStrip menuSag;
        private System.Windows.Forms.ToolStripMenuItem tsmiSatisEkrani;
        private System.Windows.Forms.DataGridViewTextBoxColumn satis_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn su_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn satir_tip;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn islem_kod;
        private System.Windows.Forms.DataGridViewTextBoxColumn islem_tipi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ad_soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn birim_fiyat_kdv_dahil;
        private System.Windows.Forms.DataGridViewTextBoxColumn iskonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplam_fiyat_kdv_dahil;
    }
}