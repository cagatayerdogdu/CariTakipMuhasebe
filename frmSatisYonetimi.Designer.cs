namespace StokTakip
{
    partial class frmSatisYonetimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatisYonetimi));
            this.dgwUrunler = new System.Windows.Forms.DataGridView();
            this.urun_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birim_fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplam_fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGiris_UrunSeriali = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGiris_UrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGiris_UrunMarkasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGiris_UrunModeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtUrunler = new System.Windows.Forms.TextBox();
            this.lblUrun = new System.Windows.Forms.Label();
            this.cbUrunler = new System.Windows.Forms.ComboBox();
            this.dtpTarihBaslangic = new System.Windows.Forms.DateTimePicker();
            this.txtStokAdet = new System.Windows.Forms.NumericUpDown();
            this.txtUrunModeli = new System.Windows.Forms.Label();
            this.txtUrunMarkasi = new System.Windows.Forms.Label();
            this.btnSatisTamamla = new System.Windows.Forms.Button();
            this.btnStokEkle = new System.Windows.Forms.Button();
            this.txtUrunAdi = new System.Windows.Forms.Label();
            this.txtUrunSerial = new System.Windows.Forms.Label();
            this.lblUrunSeriali = new System.Windows.Forms.Label();
            this.lblUrunMiktar = new System.Windows.Forms.Label();
            this.lblSatisFiyati = new System.Windows.Forms.Label();
            this.lblUrunModel = new System.Windows.Forms.Label();
            this.lblUrunMarkasi = new System.Windows.Forms.Label();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.txtUrunMiktar = new System.Windows.Forms.Label();
            this.txtSatisFiyati = new System.Windows.Forms.TextBox();
            this.menuSag = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSatirSil = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdet)).BeginInit();
            this.menuSag.SuspendLayout();
            this.SuspendLayout();
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
            this.urun_id,
            this.miktar,
            this.birim_fiyat,
            this.toplam_fiyat,
            this.clmGiris_UrunSeriali,
            this.clmGiris_UrunAdi,
            this.clmGiris_UrunMarkasi,
            this.clmGiris_UrunModeli});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwUrunler.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwUrunler.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgwUrunler.Location = new System.Drawing.Point(410, 0);
            this.dgwUrunler.Name = "dgwUrunler";
            this.dgwUrunler.ReadOnly = true;
            this.dgwUrunler.RowHeadersVisible = false;
            this.dgwUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwUrunler.Size = new System.Drawing.Size(516, 414);
            this.dgwUrunler.TabIndex = 24;
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
            this.miktar.HeaderText = "MİKTAR";
            this.miktar.Name = "miktar";
            this.miktar.ReadOnly = true;
            // 
            // birim_fiyat
            // 
            this.birim_fiyat.DataPropertyName = "birim_fiyat";
            this.birim_fiyat.HeaderText = "BİRİM FİYAT";
            this.birim_fiyat.Name = "birim_fiyat";
            this.birim_fiyat.ReadOnly = true;
            // 
            // toplam_fiyat
            // 
            this.toplam_fiyat.DataPropertyName = "toplam_fiyat";
            this.toplam_fiyat.HeaderText = "TOPLAM FİYAT";
            this.toplam_fiyat.Name = "toplam_fiyat";
            this.toplam_fiyat.ReadOnly = true;
            // 
            // clmGiris_UrunSeriali
            // 
            this.clmGiris_UrunSeriali.DataPropertyName = "urun_serial";
            this.clmGiris_UrunSeriali.HeaderText = "ÜRÜN BARKODU";
            this.clmGiris_UrunSeriali.Name = "clmGiris_UrunSeriali";
            this.clmGiris_UrunSeriali.ReadOnly = true;
            // 
            // clmGiris_UrunAdi
            // 
            this.clmGiris_UrunAdi.DataPropertyName = "urun_ad";
            this.clmGiris_UrunAdi.HeaderText = "ÜRÜN ADI";
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
            this.clmGiris_UrunModeli.HeaderText = "ÜRÜN MODELİ";
            this.clmGiris_UrunModeli.Name = "clmGiris_UrunModeli";
            this.clmGiris_UrunModeli.ReadOnly = true;
            this.clmGiris_UrunModeli.Visible = false;
            // 
            // txtUrunler
            // 
            this.txtUrunler.Location = new System.Drawing.Point(60, 54);
            this.txtUrunler.Name = "txtUrunler";
            this.txtUrunler.Size = new System.Drawing.Size(257, 20);
            this.txtUrunler.TabIndex = 27;
            this.txtUrunler.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUrunler_KeyUp);
            // 
            // lblUrun
            // 
            this.lblUrun.AutoSize = true;
            this.lblUrun.Location = new System.Drawing.Point(12, 57);
            this.lblUrun.Name = "lblUrun";
            this.lblUrun.Size = new System.Drawing.Size(42, 13);
            this.lblUrun.TabIndex = 26;
            this.lblUrun.Text = "ÜRÜN:";
            // 
            // cbUrunler
            // 
            this.cbUrunler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUrunler.FormattingEnabled = true;
            this.cbUrunler.Location = new System.Drawing.Point(60, 81);
            this.cbUrunler.Name = "cbUrunler";
            this.cbUrunler.Size = new System.Drawing.Size(257, 21);
            this.cbUrunler.TabIndex = 25;
            this.cbUrunler.SelectedIndexChanged += new System.EventHandler(this.cbUrunler_SelectedIndexChanged);
            // 
            // dtpTarihBaslangic
            // 
            this.dtpTarihBaslangic.Location = new System.Drawing.Point(15, 12);
            this.dtpTarihBaslangic.Name = "dtpTarihBaslangic";
            this.dtpTarihBaslangic.Size = new System.Drawing.Size(154, 20);
            this.dtpTarihBaslangic.TabIndex = 28;
            // 
            // txtStokAdet
            // 
            this.txtStokAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStokAdet.Location = new System.Drawing.Point(240, 156);
            this.txtStokAdet.Name = "txtStokAdet";
            this.txtStokAdet.Size = new System.Drawing.Size(77, 53);
            this.txtStokAdet.TabIndex = 57;
            this.txtStokAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUrunModeli
            // 
            this.txtUrunModeli.AutoSize = true;
            this.txtUrunModeli.Location = new System.Drawing.Point(135, 240);
            this.txtUrunModeli.Name = "txtUrunModeli";
            this.txtUrunModeli.Size = new System.Drawing.Size(35, 13);
            this.txtUrunModeli.TabIndex = 55;
            this.txtUrunModeli.Text = "model";
            // 
            // txtUrunMarkasi
            // 
            this.txtUrunMarkasi.AutoSize = true;
            this.txtUrunMarkasi.Location = new System.Drawing.Point(135, 213);
            this.txtUrunMarkasi.Name = "txtUrunMarkasi";
            this.txtUrunMarkasi.Size = new System.Drawing.Size(36, 13);
            this.txtUrunMarkasi.TabIndex = 56;
            this.txtUrunMarkasi.Text = "marka";
            // 
            // btnSatisTamamla
            // 
            this.btnSatisTamamla.BackColor = System.Drawing.Color.Transparent;
            this.btnSatisTamamla.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSatisTamamla.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnSatisTamamla.Location = new System.Drawing.Point(240, 342);
            this.btnSatisTamamla.Name = "btnSatisTamamla";
            this.btnSatisTamamla.Size = new System.Drawing.Size(122, 60);
            this.btnSatisTamamla.TabIndex = 51;
            this.btnSatisTamamla.Tag = "";
            this.btnSatisTamamla.Text = "TAMAMLA";
            this.btnSatisTamamla.UseVisualStyleBackColor = false;
            // 
            // btnStokEkle
            // 
            this.btnStokEkle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStokEkle.Location = new System.Drawing.Point(240, 220);
            this.btnStokEkle.Name = "btnStokEkle";
            this.btnStokEkle.Size = new System.Drawing.Size(75, 60);
            this.btnStokEkle.TabIndex = 52;
            this.btnStokEkle.Tag = "ekle";
            this.btnStokEkle.Text = "EKLE";
            this.btnStokEkle.UseVisualStyleBackColor = true;
            this.btnStokEkle.Click += new System.EventHandler(this.btnStokEkle_Click);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.AutoSize = true;
            this.txtUrunAdi.Location = new System.Drawing.Point(135, 185);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(19, 13);
            this.txtUrunAdi.TabIndex = 49;
            this.txtUrunAdi.Text = "ad";
            // 
            // txtUrunSerial
            // 
            this.txtUrunSerial.AutoSize = true;
            this.txtUrunSerial.Location = new System.Drawing.Point(135, 156);
            this.txtUrunSerial.Name = "txtUrunSerial";
            this.txtUrunSerial.Size = new System.Drawing.Size(40, 13);
            this.txtUrunSerial.TabIndex = 50;
            this.txtUrunSerial.Text = "barkod";
            // 
            // lblUrunSeriali
            // 
            this.lblUrunSeriali.AutoSize = true;
            this.lblUrunSeriali.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunSeriali.ForeColor = System.Drawing.Color.Black;
            this.lblUrunSeriali.Location = new System.Drawing.Point(12, 157);
            this.lblUrunSeriali.Name = "lblUrunSeriali";
            this.lblUrunSeriali.Size = new System.Drawing.Size(103, 13);
            this.lblUrunSeriali.TabIndex = 43;
            this.lblUrunSeriali.Text = "Barkod Numarası";
            // 
            // lblUrunMiktar
            // 
            this.lblUrunMiktar.AutoSize = true;
            this.lblUrunMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunMiktar.ForeColor = System.Drawing.Color.Black;
            this.lblUrunMiktar.Location = new System.Drawing.Point(12, 267);
            this.lblUrunMiktar.Name = "lblUrunMiktar";
            this.lblUrunMiktar.Size = new System.Drawing.Size(93, 13);
            this.lblUrunMiktar.TabIndex = 44;
            this.lblUrunMiktar.Text = "Stoktaki Miktar";
            // 
            // lblSatisFiyati
            // 
            this.lblSatisFiyati.AutoSize = true;
            this.lblSatisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatisFiyati.ForeColor = System.Drawing.Color.Black;
            this.lblSatisFiyati.Location = new System.Drawing.Point(12, 293);
            this.lblSatisFiyati.Name = "lblSatisFiyati";
            this.lblSatisFiyati.Size = new System.Drawing.Size(69, 13);
            this.lblSatisFiyati.TabIndex = 45;
            this.lblSatisFiyati.Text = "Satış Fiyatı";
            // 
            // lblUrunModel
            // 
            this.lblUrunModel.AutoSize = true;
            this.lblUrunModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunModel.ForeColor = System.Drawing.Color.Black;
            this.lblUrunModel.Location = new System.Drawing.Point(12, 240);
            this.lblUrunModel.Name = "lblUrunModel";
            this.lblUrunModel.Size = new System.Drawing.Size(75, 13);
            this.lblUrunModel.TabIndex = 46;
            this.lblUrunModel.Text = "Ürün Modeli";
            // 
            // lblUrunMarkasi
            // 
            this.lblUrunMarkasi.AutoSize = true;
            this.lblUrunMarkasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunMarkasi.ForeColor = System.Drawing.Color.Black;
            this.lblUrunMarkasi.Location = new System.Drawing.Point(12, 213);
            this.lblUrunMarkasi.Name = "lblUrunMarkasi";
            this.lblUrunMarkasi.Size = new System.Drawing.Size(82, 13);
            this.lblUrunMarkasi.TabIndex = 47;
            this.lblUrunMarkasi.Text = "Ürün Markası";
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAdi.ForeColor = System.Drawing.Color.Black;
            this.lblUrunAdi.Location = new System.Drawing.Point(12, 185);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(56, 13);
            this.lblUrunAdi.TabIndex = 48;
            this.lblUrunAdi.Text = "Ürün Adı";
            // 
            // txtUrunMiktar
            // 
            this.txtUrunMiktar.AutoSize = true;
            this.txtUrunMiktar.Location = new System.Drawing.Point(135, 267);
            this.txtUrunMiktar.Name = "txtUrunMiktar";
            this.txtUrunMiktar.Size = new System.Drawing.Size(35, 13);
            this.txtUrunMiktar.TabIndex = 54;
            this.txtUrunMiktar.Text = "miktar";
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.Location = new System.Drawing.Point(138, 290);
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Size = new System.Drawing.Size(75, 20);
            this.txtSatisFiyati.TabIndex = 58;
            // 
            // menuSag
            // 
            this.menuSag.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSatirSil});
            this.menuSag.Name = "menuSag";
            this.menuSag.Size = new System.Drawing.Size(87, 26);
            // 
            // tsmiSatirSil
            // 
            this.tsmiSatirSil.Name = "tsmiSatirSil";
            this.tsmiSatirSil.Size = new System.Drawing.Size(86, 22);
            this.tsmiSatirSil.Text = "Sil";
            this.tsmiSatirSil.Click += new System.EventHandler(this.tsmiSatirSil_Click);
            // 
            // frmSatisYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 414);
            this.Controls.Add(this.txtSatisFiyati);
            this.Controls.Add(this.txtStokAdet);
            this.Controls.Add(this.txtUrunMiktar);
            this.Controls.Add(this.txtUrunModeli);
            this.Controls.Add(this.txtUrunMarkasi);
            this.Controls.Add(this.btnSatisTamamla);
            this.Controls.Add(this.btnStokEkle);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.txtUrunSerial);
            this.Controls.Add(this.lblUrunSeriali);
            this.Controls.Add(this.lblUrunMiktar);
            this.Controls.Add(this.lblSatisFiyati);
            this.Controls.Add(this.lblUrunModel);
            this.Controls.Add(this.lblUrunMarkasi);
            this.Controls.Add(this.lblUrunAdi);
            this.Controls.Add(this.dtpTarihBaslangic);
            this.Controls.Add(this.txtUrunler);
            this.Controls.Add(this.lblUrun);
            this.Controls.Add(this.cbUrunler);
            this.Controls.Add(this.dgwUrunler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSatisYonetimi";
            this.Text = "SATIŞ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSatisYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdet)).EndInit();
            this.menuSag.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwUrunler;
        private System.Windows.Forms.TextBox txtUrunler;
        private System.Windows.Forms.Label lblUrun;
        private System.Windows.Forms.ComboBox cbUrunler;
        private System.Windows.Forms.DateTimePicker dtpTarihBaslangic;
        private System.Windows.Forms.NumericUpDown txtStokAdet;
        private System.Windows.Forms.Label txtUrunModeli;
        private System.Windows.Forms.Label txtUrunMarkasi;
        private System.Windows.Forms.Button btnSatisTamamla;
        private System.Windows.Forms.Button btnStokEkle;
        private System.Windows.Forms.Label txtUrunAdi;
        private System.Windows.Forms.Label txtUrunSerial;
        private System.Windows.Forms.Label lblUrunSeriali;
        private System.Windows.Forms.Label lblUrunMiktar;
        private System.Windows.Forms.Label lblSatisFiyati;
        private System.Windows.Forms.Label lblUrunModel;
        private System.Windows.Forms.Label lblUrunMarkasi;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.Label txtUrunMiktar;
        private System.Windows.Forms.TextBox txtSatisFiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn birim_fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplam_fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGiris_UrunSeriali;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGiris_UrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGiris_UrunMarkasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGiris_UrunModeli;
        private System.Windows.Forms.ContextMenuStrip menuSag;
        private System.Windows.Forms.ToolStripMenuItem tsmiSatirSil;
    }
}