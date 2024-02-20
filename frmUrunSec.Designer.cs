namespace StokTakip
{
    partial class frmUrunSec
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunSec));
            this.dgwUrunler = new System.Windows.Forms.DataGridView();
            this.clmGiris_DepoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGiris_UrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGiris_UrunMarkasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGiris_UrunModeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGiris_UrunSeriali = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_birim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_kdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_kdv_dahil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_fiyat_kdv_dahil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_alis_fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_alis_kdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_alis_kdv_dahil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_alis_fiyat_kdv_dahil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.lblUrun = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.clmGiris_UrunAdi,
            this.clmGiris_UrunMarkasi,
            this.clmGiris_UrunModeli,
            this.clmGiris_UrunSeriali,
            this.urun_birim,
            this.urun_kdv,
            this.urun_fiyat,
            this.urun_kdv_dahil,
            this.urun_fiyat_kdv_dahil,
            this.urun_alis_fiyat,
            this.urun_alis_kdv,
            this.urun_alis_kdv_dahil,
            this.urun_alis_fiyat_kdv_dahil});
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
            this.dgwUrunler.Size = new System.Drawing.Size(979, 416);
            this.dgwUrunler.TabIndex = 24;
            this.dgwUrunler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwUrunler_CellDoubleClick);
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
            this.clmGiris_UrunAdi.FillWeight = 298.8689F;
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
            this.clmGiris_UrunModeli.FillWeight = 151.4403F;
            this.clmGiris_UrunModeli.HeaderText = "CİNSİ";
            this.clmGiris_UrunModeli.Name = "clmGiris_UrunModeli";
            this.clmGiris_UrunModeli.ReadOnly = true;
            // 
            // clmGiris_UrunSeriali
            // 
            this.clmGiris_UrunSeriali.DataPropertyName = "urun_serial";
            this.clmGiris_UrunSeriali.FillWeight = 54.63697F;
            this.clmGiris_UrunSeriali.HeaderText = "BARKODU";
            this.clmGiris_UrunSeriali.Name = "clmGiris_UrunSeriali";
            this.clmGiris_UrunSeriali.ReadOnly = true;
            // 
            // urun_birim
            // 
            this.urun_birim.DataPropertyName = "urun_birim";
            this.urun_birim.FillWeight = 54.63697F;
            this.urun_birim.HeaderText = "BİRİM";
            this.urun_birim.Name = "urun_birim";
            this.urun_birim.ReadOnly = true;
            // 
            // urun_kdv
            // 
            this.urun_kdv.DataPropertyName = "urun_kdv";
            this.urun_kdv.FillWeight = 54.63697F;
            this.urun_kdv.HeaderText = "KDV %";
            this.urun_kdv.Name = "urun_kdv";
            this.urun_kdv.ReadOnly = true;
            // 
            // urun_fiyat
            // 
            this.urun_fiyat.DataPropertyName = "urun_fiyat";
            this.urun_fiyat.FillWeight = 54.63697F;
            this.urun_fiyat.HeaderText = "SATIŞ";
            this.urun_fiyat.Name = "urun_fiyat";
            this.urun_fiyat.ReadOnly = true;
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
            this.urun_fiyat_kdv_dahil.FillWeight = 76.98618F;
            this.urun_fiyat_kdv_dahil.HeaderText = "SATIŞ + KDV";
            this.urun_fiyat_kdv_dahil.Name = "urun_fiyat_kdv_dahil";
            this.urun_fiyat_kdv_dahil.ReadOnly = true;
            // 
            // urun_alis_fiyat
            // 
            this.urun_alis_fiyat.DataPropertyName = "urun_alis_fiyat";
            this.urun_alis_fiyat.FillWeight = 62.78599F;
            this.urun_alis_fiyat.HeaderText = "ALIŞ";
            this.urun_alis_fiyat.Name = "urun_alis_fiyat";
            this.urun_alis_fiyat.ReadOnly = true;
            this.urun_alis_fiyat.Visible = false;
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
            this.urun_alis_fiyat_kdv_dahil.FillWeight = 91.37053F;
            this.urun_alis_fiyat_kdv_dahil.HeaderText = "ALIŞ + KDV";
            this.urun_alis_fiyat_kdv_dahil.Name = "urun_alis_fiyat_kdv_dahil";
            this.urun_alis_fiyat_kdv_dahil.ReadOnly = true;
            this.urun_alis_fiyat_kdv_dahil.Visible = false;
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(84, 11);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(226, 20);
            this.txtArama.TabIndex = 1;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // lblUrun
            // 
            this.lblUrun.AutoSize = true;
            this.lblUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrun.Location = new System.Drawing.Point(3, 14);
            this.lblUrun.Name = "lblUrun";
            this.lblUrun.Size = new System.Drawing.Size(76, 13);
            this.lblUrun.TabIndex = 26;
            this.lblUrun.Text = "ÜRÜN ARA:";
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
            this.splitContainer1.Panel1.Controls.Add(this.lblUrun);
            this.splitContainer1.Panel1.Controls.Add(this.txtArama);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgwUrunler);
            this.splitContainer1.Size = new System.Drawing.Size(979, 467);
            this.splitContainer1.SplitterDistance = 47;
            this.splitContainer1.TabIndex = 27;
            // 
            // frmUrunSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 467);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUrunSec";
            this.Text = "ÜRÜN SEÇ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUrunYonetimi_FormClosed);
            this.Load += new System.EventHandler(this.frmUrunSec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrunler)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwUrunler;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label lblUrun;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGiris_DepoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGiris_UrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGiris_UrunMarkasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGiris_UrunModeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGiris_UrunSeriali;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_birim;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_kdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_kdv_dahil;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_fiyat_kdv_dahil;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_alis_fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_alis_kdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_alis_kdv_dahil;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_alis_fiyat_kdv_dahil;
    }
}