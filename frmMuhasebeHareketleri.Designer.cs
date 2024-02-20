namespace StokTakip
{
    partial class frmMuhasebeHareketleri
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMuhasebeHareketleri));
            this.cbDetay = new System.Windows.Forms.CheckBox();
            this.txtFaturaAciklama = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.txtFaturaNo = new System.Windows.Forms.TextBox();
            this.lblFaturaTip = new System.Windows.Forms.Label();
            this.lblFaturaNo = new System.Windows.Forms.Label();
            this.cbFaturaTip = new System.Windows.Forms.ComboBox();
            this.btnFirmaSec = new System.Windows.Forms.Button();
            this.cbFirmaMusteri = new System.Windows.Forms.ComboBox();
            this.lblIslem = new System.Windows.Forms.Label();
            this.cbIslem = new System.Windows.Forms.ComboBox();
            this.dtpTarihBitis = new System.Windows.Forms.DateTimePicker();
            this.dtpTarihBaslangic = new System.Windows.Forms.DateTimePicker();
            this.satis_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgwStoklar = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.su_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satir_tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islem_tipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ad_soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odeme_tipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.belge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatura_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odeme_kalan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islem_kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSeciliFirma = new System.Windows.Forms.Label();
            this.txtFirmalar = new System.Windows.Forms.TextBox();
            this.lblFirmaMusteri = new System.Windows.Forms.Label();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.chkTumIslemler = new System.Windows.Forms.CheckBox();
            this.lnkYenile = new System.Windows.Forms.LinkLabel();
            this.menuSag = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiParaAlVer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSil = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiYazdir = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStoklar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.menuSag.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbDetay
            // 
            this.cbDetay.AutoSize = true;
            this.cbDetay.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbDetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbDetay.Location = new System.Drawing.Point(782, 51);
            this.cbDetay.Name = "cbDetay";
            this.cbDetay.Size = new System.Drawing.Size(65, 17);
            this.cbDetay.TabIndex = 80;
            this.cbDetay.Text = "Detaylı";
            this.cbDetay.UseVisualStyleBackColor = true;
            this.cbDetay.CheckedChanged += new System.EventHandler(this.cbIslem_SelectedIndexChanged);
            // 
            // txtFaturaAciklama
            // 
            this.txtFaturaAciklama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFaturaAciklama.Location = new System.Drawing.Point(833, 20);
            this.txtFaturaAciklama.Name = "txtFaturaAciklama";
            this.txtFaturaAciklama.Size = new System.Drawing.Size(107, 20);
            this.txtFaturaAciklama.TabIndex = 78;
            this.txtFaturaAciklama.TextChanged += new System.EventHandler(this.cbIslem_SelectedIndexChanged);
            // 
            // lblAciklama
            // 
            this.lblAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.ForeColor = System.Drawing.Color.Black;
            this.lblAciklama.Location = new System.Drawing.Point(770, 22);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(58, 13);
            this.lblAciklama.TabIndex = 79;
            this.lblAciklama.Text = "Açıklama";
            this.lblAciklama.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFaturaNo
            // 
            this.txtFaturaNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFaturaNo.Location = new System.Drawing.Point(677, 46);
            this.txtFaturaNo.Name = "txtFaturaNo";
            this.txtFaturaNo.Size = new System.Drawing.Size(76, 20);
            this.txtFaturaNo.TabIndex = 75;
            this.txtFaturaNo.TextChanged += new System.EventHandler(this.cbIslem_SelectedIndexChanged);
            // 
            // lblFaturaTip
            // 
            this.lblFaturaTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFaturaTip.ForeColor = System.Drawing.Color.Black;
            this.lblFaturaTip.Location = new System.Drawing.Point(599, 22);
            this.lblFaturaTip.Name = "lblFaturaTip";
            this.lblFaturaTip.Size = new System.Drawing.Size(71, 13);
            this.lblFaturaTip.TabIndex = 76;
            this.lblFaturaTip.Text = "Belge";
            this.lblFaturaTip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFaturaNo
            // 
            this.lblFaturaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFaturaNo.ForeColor = System.Drawing.Color.Black;
            this.lblFaturaNo.Location = new System.Drawing.Point(599, 48);
            this.lblFaturaNo.Name = "lblFaturaNo";
            this.lblFaturaNo.Size = new System.Drawing.Size(71, 13);
            this.lblFaturaNo.TabIndex = 77;
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
            this.cbFaturaTip.Location = new System.Drawing.Point(676, 19);
            this.cbFaturaTip.Name = "cbFaturaTip";
            this.cbFaturaTip.Size = new System.Drawing.Size(77, 21);
            this.cbFaturaTip.TabIndex = 74;
            this.cbFaturaTip.SelectedIndexChanged += new System.EventHandler(this.cbIslem_SelectedIndexChanged);
            // 
            // btnFirmaSec
            // 
            this.btnFirmaSec.Location = new System.Drawing.Point(537, 46);
            this.btnFirmaSec.Name = "btnFirmaSec";
            this.btnFirmaSec.Size = new System.Drawing.Size(43, 22);
            this.btnFirmaSec.TabIndex = 73;
            this.btnFirmaSec.Text = "SEÇ";
            this.btnFirmaSec.UseVisualStyleBackColor = true;
            this.btnFirmaSec.Click += new System.EventHandler(this.btnFirmaSec_Click);
            // 
            // cbFirmaMusteri
            // 
            this.cbFirmaMusteri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFirmaMusteri.FormattingEnabled = true;
            this.cbFirmaMusteri.Items.AddRange(new object[] {
            "Firma",
            "Müşteri"});
            this.cbFirmaMusteri.Location = new System.Drawing.Point(459, 47);
            this.cbFirmaMusteri.Name = "cbFirmaMusteri";
            this.cbFirmaMusteri.Size = new System.Drawing.Size(72, 21);
            this.cbFirmaMusteri.TabIndex = 72;
            // 
            // lblIslem
            // 
            this.lblIslem.AutoSize = true;
            this.lblIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIslem.Location = new System.Drawing.Point(419, 22);
            this.lblIslem.Name = "lblIslem";
            this.lblIslem.Size = new System.Drawing.Size(36, 13);
            this.lblIslem.TabIndex = 71;
            this.lblIslem.Text = "İşlem";
            // 
            // cbIslem
            // 
            this.cbIslem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIslem.FormattingEnabled = true;
            this.cbIslem.Location = new System.Drawing.Point(459, 19);
            this.cbIslem.Name = "cbIslem";
            this.cbIslem.Size = new System.Drawing.Size(121, 21);
            this.cbIslem.TabIndex = 70;
            this.cbIslem.SelectedIndexChanged += new System.EventHandler(this.cbIslem_SelectedIndexChanged);
            // 
            // dtpTarihBitis
            // 
            this.dtpTarihBitis.Location = new System.Drawing.Point(186, 16);
            this.dtpTarihBitis.Name = "dtpTarihBitis";
            this.dtpTarihBitis.Size = new System.Drawing.Size(165, 20);
            this.dtpTarihBitis.TabIndex = 68;
            this.dtpTarihBitis.Value = new System.DateTime(2020, 1, 28, 0, 0, 0, 0);
            this.dtpTarihBitis.ValueChanged += new System.EventHandler(this.cbIslem_SelectedIndexChanged);
            // 
            // dtpTarihBaslangic
            // 
            this.dtpTarihBaslangic.Location = new System.Drawing.Point(15, 16);
            this.dtpTarihBaslangic.Name = "dtpTarihBaslangic";
            this.dtpTarihBaslangic.Size = new System.Drawing.Size(165, 20);
            this.dtpTarihBaslangic.TabIndex = 69;
            this.dtpTarihBaslangic.Value = new System.DateTime(2020, 1, 28, 0, 0, 0, 0);
            this.dtpTarihBaslangic.ValueChanged += new System.EventHandler(this.cbIslem_SelectedIndexChanged);
            // 
            // satis_id
            // 
            this.satis_id.DataPropertyName = "satis_id";
            this.satis_id.HeaderText = "KAYIT ID";
            this.satis_id.Name = "satis_id";
            this.satis_id.Visible = false;
            // 
            // tarih
            // 
            this.tarih.DataPropertyName = "tarih";
            this.tarih.HeaderText = "TARİH";
            this.tarih.Name = "tarih";
            this.tarih.Width = 104;
            // 
            // saat
            // 
            this.saat.DataPropertyName = "saat";
            this.saat.HeaderText = "SAAT";
            this.saat.Name = "saat";
            this.saat.Width = 103;
            // 
            // yer
            // 
            this.yer.DataPropertyName = "yer";
            this.yer.HeaderText = "MUHATAP";
            this.yer.Name = "yer";
            this.yer.Width = 104;
            // 
            // dgwStoklar
            // 
            this.dgwStoklar.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgwStoklar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgwStoklar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwStoklar.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgwStoklar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwStoklar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStoklar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.su_id,
            this.satir_tip,
            this.dataGridViewTextBoxColumn2,
            this.islem_tipi,
            this.dataGridViewTextBoxColumn4,
            this.ad_soyad,
            this.odeme_tipi,
            this.belge,
            this.fatura_no,
            this.tutar,
            this.odeme_kalan,
            this.aciklama,
            this.islem_kod});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwStoklar.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgwStoklar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwStoklar.Location = new System.Drawing.Point(0, 0);
            this.dgwStoklar.Name = "dgwStoklar";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwStoklar.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgwStoklar.RowHeadersVisible = false;
            this.dgwStoklar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwStoklar.Size = new System.Drawing.Size(1028, 377);
            this.dgwStoklar.TabIndex = 81;
            this.dgwStoklar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwStoklar_CellDoubleClick);
            this.dgwStoklar.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgwStoklar_DataBindingComplete);
            this.dgwStoklar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgwStoklar_MouseUp);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "satis_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "KAYIT ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
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
            // odeme_tipi
            // 
            this.odeme_tipi.DataPropertyName = "odeme_tipi";
            this.odeme_tipi.HeaderText = "ÖDEME";
            this.odeme_tipi.Name = "odeme_tipi";
            // 
            // belge
            // 
            this.belge.DataPropertyName = "belge";
            this.belge.HeaderText = "BELGE";
            this.belge.Name = "belge";
            // 
            // fatura_no
            // 
            this.fatura_no.DataPropertyName = "fatura_no";
            this.fatura_no.HeaderText = "FAT.NO";
            this.fatura_no.Name = "fatura_no";
            // 
            // tutar
            // 
            this.tutar.DataPropertyName = "tutar";
            this.tutar.HeaderText = "TUTAR";
            this.tutar.Name = "tutar";
            // 
            // odeme_kalan
            // 
            this.odeme_kalan.DataPropertyName = "odeme_kalan";
            this.odeme_kalan.HeaderText = "KALAN ÖDEME";
            this.odeme_kalan.Name = "odeme_kalan";
            // 
            // aciklama
            // 
            this.aciklama.DataPropertyName = "aciklama";
            this.aciklama.HeaderText = "AÇIKLAMA";
            this.aciklama.Name = "aciklama";
            // 
            // islem_kod
            // 
            this.islem_kod.DataPropertyName = "islem_kod";
            this.islem_kod.HeaderText = "İŞLEM KODU";
            this.islem_kod.Name = "islem_kod";
            this.islem_kod.Visible = false;
            // 
            // lblSeciliFirma
            // 
            this.lblSeciliFirma.AccessibleDescription = "";
            this.lblSeciliFirma.AutoSize = true;
            this.lblSeciliFirma.Location = new System.Drawing.Point(873, 64);
            this.lblSeciliFirma.Name = "lblSeciliFirma";
            this.lblSeciliFirma.Size = new System.Drawing.Size(67, 13);
            this.lblSeciliFirma.TabIndex = 82;
            this.lblSeciliFirma.Text = "lblSeciliFirma";
            this.lblSeciliFirma.Visible = false;
            // 
            // txtFirmalar
            // 
            this.txtFirmalar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirmalar.Location = new System.Drawing.Point(459, 74);
            this.txtFirmalar.Name = "txtFirmalar";
            this.txtFirmalar.Size = new System.Drawing.Size(121, 20);
            this.txtFirmalar.TabIndex = 83;
            this.txtFirmalar.TextChanged += new System.EventHandler(this.cbIslem_SelectedIndexChanged);
            this.txtFirmalar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFirmalar_KeyDown);
            // 
            // lblFirmaMusteri
            // 
            this.lblFirmaMusteri.AutoSize = true;
            this.lblFirmaMusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFirmaMusteri.Location = new System.Drawing.Point(361, 64);
            this.lblFirmaMusteri.Name = "lblFirmaMusteri";
            this.lblFirmaMusteri.Size = new System.Drawing.Size(92, 13);
            this.lblFirmaMusteri.TabIndex = 71;
            this.lblFirmaMusteri.Text = "Firma / Müşteri";
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
            this.scMain.Panel1.Controls.Add(this.chkTumIslemler);
            this.scMain.Panel1.Controls.Add(this.lnkYenile);
            this.scMain.Panel1.Controls.Add(this.dtpTarihBaslangic);
            this.scMain.Panel1.Controls.Add(this.txtFirmalar);
            this.scMain.Panel1.Controls.Add(this.dtpTarihBitis);
            this.scMain.Panel1.Controls.Add(this.lblSeciliFirma);
            this.scMain.Panel1.Controls.Add(this.cbIslem);
            this.scMain.Panel1.Controls.Add(this.cbDetay);
            this.scMain.Panel1.Controls.Add(this.lblIslem);
            this.scMain.Panel1.Controls.Add(this.txtFaturaAciklama);
            this.scMain.Panel1.Controls.Add(this.lblFirmaMusteri);
            this.scMain.Panel1.Controls.Add(this.lblAciklama);
            this.scMain.Panel1.Controls.Add(this.cbFirmaMusteri);
            this.scMain.Panel1.Controls.Add(this.txtFaturaNo);
            this.scMain.Panel1.Controls.Add(this.btnFirmaSec);
            this.scMain.Panel1.Controls.Add(this.lblFaturaTip);
            this.scMain.Panel1.Controls.Add(this.cbFaturaTip);
            this.scMain.Panel1.Controls.Add(this.lblFaturaNo);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.dgwStoklar);
            this.scMain.Size = new System.Drawing.Size(1028, 480);
            this.scMain.SplitterDistance = 99;
            this.scMain.TabIndex = 84;
            // 
            // chkTumIslemler
            // 
            this.chkTumIslemler.AutoSize = true;
            this.chkTumIslemler.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkTumIslemler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkTumIslemler.Location = new System.Drawing.Point(750, 75);
            this.chkTumIslemler.Name = "chkTumIslemler";
            this.chkTumIslemler.Size = new System.Drawing.Size(97, 17);
            this.chkTumIslemler.TabIndex = 86;
            this.chkTumIslemler.Text = "Tüm İşlemler";
            this.chkTumIslemler.UseVisualStyleBackColor = true;
            this.chkTumIslemler.CheckedChanged += new System.EventHandler(this.chkTumIslemler_CheckedChanged);
            // 
            // lnkYenile
            // 
            this.lnkYenile.ActiveLinkColor = System.Drawing.Color.DarkGreen;
            this.lnkYenile.AutoSize = true;
            this.lnkYenile.Location = new System.Drawing.Point(12, 72);
            this.lnkYenile.Name = "lnkYenile";
            this.lnkYenile.Size = new System.Drawing.Size(36, 13);
            this.lnkYenile.TabIndex = 85;
            this.lnkYenile.TabStop = true;
            this.lnkYenile.Text = "Yenile";
            this.lnkYenile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkYenile_LinkClicked);
            // 
            // menuSag
            // 
            this.menuSag.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiYazdir,
            this.tsmiDuzenle,
            this.tsmiParaAlVer,
            this.tsmiSil});
            this.menuSag.Name = "menuSag";
            this.menuSag.Size = new System.Drawing.Size(194, 92);
            // 
            // tsmiParaAlVer
            // 
            this.tsmiParaAlVer.Name = "tsmiParaAlVer";
            this.tsmiParaAlVer.Size = new System.Drawing.Size(193, 22);
            this.tsmiParaAlVer.Text = "Para al/ver";
            this.tsmiParaAlVer.Click += new System.EventHandler(this.tsmiParaAlVer_Click);
            // 
            // tsmiDuzenle
            // 
            this.tsmiDuzenle.Name = "tsmiDuzenle";
            this.tsmiDuzenle.Size = new System.Drawing.Size(193, 22);
            this.tsmiDuzenle.Text = "Seçileni düzenle";
            this.tsmiDuzenle.Click += new System.EventHandler(this.tsmiDuzenle_Click);
            // 
            // tsmiSil
            // 
            this.tsmiSil.Name = "tsmiSil";
            this.tsmiSil.Size = new System.Drawing.Size(193, 22);
            this.tsmiSil.Text = "Seçileni sil";
            this.tsmiSil.Click += new System.EventHandler(this.tsmiSil_Click);
            // 
            // tsmiYazdir
            // 
            this.tsmiYazdir.Name = "tsmiYazdir";
            this.tsmiYazdir.Size = new System.Drawing.Size(193, 22);
            this.tsmiYazdir.Text = "Seçileni Faturayı Yazdır";
            this.tsmiYazdir.Click += new System.EventHandler(this.tsmiYazdir_Click);
            // 
            // frmMuhasebeHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 480);
            this.Controls.Add(this.scMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMuhasebeHareketleri";
            this.Text = "MUHASEBE HAREKETLERİ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUrunYonetimi_FormClosed);
            this.Load += new System.EventHandler(this.frmMuhasebeHareketleri_Load);
            this.Shown += new System.EventHandler(this.frmMuhasebeHareketleri_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgwStoklar)).EndInit();
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel1.PerformLayout();
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.menuSag.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cbDetay;
        private System.Windows.Forms.TextBox txtFaturaAciklama;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.TextBox txtFaturaNo;
        private System.Windows.Forms.Label lblFaturaTip;
        private System.Windows.Forms.Label lblFaturaNo;
        private System.Windows.Forms.ComboBox cbFaturaTip;
        private System.Windows.Forms.Button btnFirmaSec;
        private System.Windows.Forms.ComboBox cbFirmaMusteri;
        private System.Windows.Forms.Label lblIslem;
        private System.Windows.Forms.ComboBox cbIslem;
        private System.Windows.Forms.DateTimePicker dtpTarihBitis;
        private System.Windows.Forms.DateTimePicker dtpTarihBaslangic;
        private System.Windows.Forms.DataGridViewTextBoxColumn islem;
        private System.Windows.Forms.DataGridViewTextBoxColumn satis_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn saat;
        private System.Windows.Forms.DataGridViewTextBoxColumn yer;
        private System.Windows.Forms.DataGridView dgwStoklar;
        private System.Windows.Forms.Label lblSeciliFirma;
        private System.Windows.Forms.TextBox txtFirmalar;
        private System.Windows.Forms.Label lblFirmaMusteri;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.ContextMenuStrip menuSag;
        private System.Windows.Forms.ToolStripMenuItem tsmiSil;
        private System.Windows.Forms.ToolStripMenuItem tsmiDuzenle;
        private System.Windows.Forms.ToolStripMenuItem tsmiParaAlVer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn su_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn satir_tip;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn islem_tipi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ad_soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn odeme_tipi;
        private System.Windows.Forms.DataGridViewTextBoxColumn belge;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatura_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn odeme_kalan;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn islem_kod;
        private System.Windows.Forms.ToolStripMenuItem tsmiYazdir;
        private System.Windows.Forms.LinkLabel lnkYenile;
        private System.Windows.Forms.CheckBox chkTumIslemler;
    }
}