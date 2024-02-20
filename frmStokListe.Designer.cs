namespace StokTakip
{
    partial class frmStokListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStokListe));
            this.dgwUrunler = new System.Windows.Forms.DataGridView();
            this.clmGiris_DepoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGiris_UrunSeriali = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGiris_UrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGiris_UrunMarkasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGiris_UrunModeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_birim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satis_birim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_kdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_fiyat_kdv_dahil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_alis_fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_alis_fiyat_kdv_dahil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_alis_kdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_kdv_dahil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_alis_kdv_dahil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnTumUrunHareketleri = new System.Windows.Forms.Button();
            this.cbMevcutStokDeger = new System.Windows.Forms.CheckBox();
            this.ddlArtiEksi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.menuSag = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiUrunHareketleri = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSil = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.clmGiris_DepoId,
            this.clmGiris_UrunSeriali,
            this.clmGiris_UrunAdi,
            this.clmGiris_UrunMarkasi,
            this.clmGiris_UrunModeli,
            this.urun_miktar,
            this.urun_birim,
            this.satis_birim,
            this.urun_kdv,
            this.urun_fiyat,
            this.urun_fiyat_kdv_dahil,
            this.urun_alis_fiyat,
            this.urun_alis_fiyat_kdv_dahil,
            this.urun_alis_kdv,
            this.urun_kdv_dahil,
            this.urun_alis_kdv_dahil});
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
            this.dgwUrunler.Size = new System.Drawing.Size(935, 367);
            this.dgwUrunler.TabIndex = 28;
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
            // clmGiris_UrunSeriali
            // 
            this.clmGiris_UrunSeriali.DataPropertyName = "urun_serial";
            this.clmGiris_UrunSeriali.FillWeight = 87.02757F;
            this.clmGiris_UrunSeriali.HeaderText = "BARKODU";
            this.clmGiris_UrunSeriali.Name = "clmGiris_UrunSeriali";
            this.clmGiris_UrunSeriali.ReadOnly = true;
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
            // urun_miktar
            // 
            this.urun_miktar.DataPropertyName = "urun_miktar";
            this.urun_miktar.FillWeight = 73.3308F;
            this.urun_miktar.HeaderText = "MEVCUT";
            this.urun_miktar.Name = "urun_miktar";
            this.urun_miktar.ReadOnly = true;
            // 
            // urun_birim
            // 
            this.urun_birim.DataPropertyName = "urun_birim";
            this.urun_birim.FillWeight = 51.80371F;
            this.urun_birim.HeaderText = "BİRİM";
            this.urun_birim.Name = "urun_birim";
            this.urun_birim.ReadOnly = true;
            // 
            // satis_birim
            // 
            this.satis_birim.DataPropertyName = "satis_birim";
            this.satis_birim.HeaderText = "BİRİM FİYAT";
            this.satis_birim.Name = "satis_birim";
            this.satis_birim.ReadOnly = true;
            // 
            // urun_kdv
            // 
            this.urun_kdv.DataPropertyName = "urun_kdv";
            this.urun_kdv.HeaderText = "KDV (%)";
            this.urun_kdv.Name = "urun_kdv";
            this.urun_kdv.ReadOnly = true;
            // 
            // urun_fiyat
            // 
            this.urun_fiyat.DataPropertyName = "urun_fiyat";
            this.urun_fiyat.FillWeight = 55.64633F;
            this.urun_fiyat.HeaderText = "SATIŞ";
            this.urun_fiyat.Name = "urun_fiyat";
            this.urun_fiyat.ReadOnly = true;
            this.urun_fiyat.Visible = false;
            // 
            // urun_fiyat_kdv_dahil
            // 
            this.urun_fiyat_kdv_dahil.DataPropertyName = "urun_fiyat_kdv_dahil";
            this.urun_fiyat_kdv_dahil.FillWeight = 93.55482F;
            this.urun_fiyat_kdv_dahil.HeaderText = "SATIŞ + KDV";
            this.urun_fiyat_kdv_dahil.Name = "urun_fiyat_kdv_dahil";
            this.urun_fiyat_kdv_dahil.ReadOnly = true;
            this.urun_fiyat_kdv_dahil.Visible = false;
            // 
            // urun_alis_fiyat
            // 
            this.urun_alis_fiyat.DataPropertyName = "urun_alis_fiyat";
            this.urun_alis_fiyat.FillWeight = 67.72081F;
            this.urun_alis_fiyat.HeaderText = "ALIŞ";
            this.urun_alis_fiyat.Name = "urun_alis_fiyat";
            this.urun_alis_fiyat.ReadOnly = true;
            this.urun_alis_fiyat.Visible = false;
            // 
            // urun_alis_fiyat_kdv_dahil
            // 
            this.urun_alis_fiyat_kdv_dahil.DataPropertyName = "urun_alis_fiyat_kdv_dahil";
            this.urun_alis_fiyat_kdv_dahil.FillWeight = 102.4244F;
            this.urun_alis_fiyat_kdv_dahil.HeaderText = "ALIŞ + KDV";
            this.urun_alis_fiyat_kdv_dahil.Name = "urun_alis_fiyat_kdv_dahil";
            this.urun_alis_fiyat_kdv_dahil.ReadOnly = true;
            this.urun_alis_fiyat_kdv_dahil.Visible = false;
            // 
            // urun_alis_kdv
            // 
            this.urun_alis_kdv.DataPropertyName = "urun_alis_kdv";
            this.urun_alis_kdv.HeaderText = "ALIŞ KDV";
            this.urun_alis_kdv.Name = "urun_alis_kdv";
            this.urun_alis_kdv.ReadOnly = true;
            this.urun_alis_kdv.Visible = false;
            // 
            // urun_kdv_dahil
            // 
            this.urun_kdv_dahil.DataPropertyName = "urun_kdv_dahil";
            this.urun_kdv_dahil.HeaderText = "SATIŞ KDV DAHİL";
            this.urun_kdv_dahil.Name = "urun_kdv_dahil";
            this.urun_kdv_dahil.ReadOnly = true;
            this.urun_kdv_dahil.Visible = false;
            // 
            // urun_alis_kdv_dahil
            // 
            this.urun_alis_kdv_dahil.DataPropertyName = "urun_alis_kdv_dahil";
            this.urun_alis_kdv_dahil.HeaderText = "ALIŞ KDV DAHİL";
            this.urun_alis_kdv_dahil.Name = "urun_alis_kdv_dahil";
            this.urun_alis_kdv_dahil.ReadOnly = true;
            this.urun_alis_kdv_dahil.Visible = false;
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
            this.splitContainer1.Panel1.Controls.Add(this.btnTumUrunHareketleri);
            this.splitContainer1.Panel1.Controls.Add(this.cbMevcutStokDeger);
            this.splitContainer1.Panel1.Controls.Add(this.ddlArtiEksi);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtArama);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgwUrunler);
            this.splitContainer1.Size = new System.Drawing.Size(935, 453);
            this.splitContainer1.SplitterDistance = 82;
            this.splitContainer1.TabIndex = 29;
            // 
            // btnTumUrunHareketleri
            // 
            this.btnTumUrunHareketleri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTumUrunHareketleri.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTumUrunHareketleri.ForeColor = System.Drawing.Color.Teal;
            this.btnTumUrunHareketleri.Location = new System.Drawing.Point(657, 12);
            this.btnTumUrunHareketleri.Name = "btnTumUrunHareketleri";
            this.btnTumUrunHareketleri.Size = new System.Drawing.Size(266, 38);
            this.btnTumUrunHareketleri.TabIndex = 33;
            this.btnTumUrunHareketleri.Text = "Tüm Ürün Hareketleri";
            this.btnTumUrunHareketleri.UseVisualStyleBackColor = true;
            this.btnTumUrunHareketleri.Click += new System.EventHandler(this.btnTumUrunHareketleri_Click);
            // 
            // cbMevcutStokDeger
            // 
            this.cbMevcutStokDeger.AutoSize = true;
            this.cbMevcutStokDeger.Location = new System.Drawing.Point(14, 46);
            this.cbMevcutStokDeger.Name = "cbMevcutStokDeger";
            this.cbMevcutStokDeger.Size = new System.Drawing.Size(133, 17);
            this.cbMevcutStokDeger.TabIndex = 32;
            this.cbMevcutStokDeger.Text = "Mevcut Stoğun Değeri";
            this.cbMevcutStokDeger.UseVisualStyleBackColor = true;
            this.cbMevcutStokDeger.CheckedChanged += new System.EventHandler(this.cbMevcutStokDeger_CheckedChanged);
            // 
            // ddlArtiEksi
            // 
            this.ddlArtiEksi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlArtiEksi.FormattingEnabled = true;
            this.ddlArtiEksi.Items.AddRange(new object[] {
            "Tümü",
            "Artıda Olanlar",
            "Sıfır ve Ekside Olanlar"});
            this.ddlArtiEksi.Location = new System.Drawing.Point(311, 12);
            this.ddlArtiEksi.Name = "ddlArtiEksi";
            this.ddlArtiEksi.Size = new System.Drawing.Size(144, 21);
            this.ddlArtiEksi.TabIndex = 31;
            this.ddlArtiEksi.SelectedIndexChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "ÜRÜN ARA:";
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(93, 12);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(198, 20);
            this.txtArama.TabIndex = 29;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // menuSag
            // 
            this.menuSag.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUrunHareketleri,
            this.tsmiDuzenle,
            this.tsmiSil});
            this.menuSag.Name = "menuSag";
            this.menuSag.Size = new System.Drawing.Size(204, 70);
            // 
            // tsmiUrunHareketleri
            // 
            this.tsmiUrunHareketleri.Name = "tsmiUrunHareketleri";
            this.tsmiUrunHareketleri.Size = new System.Drawing.Size(203, 22);
            this.tsmiUrunHareketleri.Text = "Ürünün hareketlerini gör";
            this.tsmiUrunHareketleri.Click += new System.EventHandler(this.tsmiUrunHareketleri_Click);
            // 
            // tsmiDuzenle
            // 
            this.tsmiDuzenle.Name = "tsmiDuzenle";
            this.tsmiDuzenle.Size = new System.Drawing.Size(203, 22);
            this.tsmiDuzenle.Text = "Seçilen ürünü düzenle";
            this.tsmiDuzenle.Click += new System.EventHandler(this.tsmiDuzenle_Click);
            // 
            // tsmiSil
            // 
            this.tsmiSil.Name = "tsmiSil";
            this.tsmiSil.Size = new System.Drawing.Size(203, 22);
            this.tsmiSil.Text = "Seçileni sil";
            this.tsmiSil.Visible = false;
            // 
            // frmStokListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 453);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStokListe";
            this.Text = "STOK LİSTESİ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUrunYonetimi_FormClosed);
            this.Load += new System.EventHandler(this.frmStokListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrunler)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuSag.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwUrunler;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.ComboBox ddlArtiEksi;
        private System.Windows.Forms.CheckBox cbMevcutStokDeger;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGiris_DepoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGiris_UrunSeriali;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGiris_UrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGiris_UrunMarkasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGiris_UrunModeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_birim;
        private System.Windows.Forms.DataGridViewTextBoxColumn satis_birim;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_kdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_fiyat_kdv_dahil;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_alis_fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_alis_fiyat_kdv_dahil;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_alis_kdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_kdv_dahil;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_alis_kdv_dahil;
        private System.Windows.Forms.ContextMenuStrip menuSag;
        private System.Windows.Forms.ToolStripMenuItem tsmiUrunHareketleri;
        private System.Windows.Forms.ToolStripMenuItem tsmiDuzenle;
        private System.Windows.Forms.ToolStripMenuItem tsmiSil;
        private System.Windows.Forms.Button btnTumUrunHareketleri;

    }
}