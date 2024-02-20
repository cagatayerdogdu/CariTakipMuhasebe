namespace StokTakip
{
    partial class frmSatisHareketleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatisHareketleri));
            this.dtpTarihBitis = new System.Windows.Forms.DateTimePicker();
            this.dtpTarihBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dgwStoklar = new System.Windows.Forms.DataGridView();
            this.satis_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odeme_tipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.belge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatura_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbIslem = new System.Windows.Forms.ComboBox();
            this.lblIslem = new System.Windows.Forms.Label();
            this.btnFirmaSec = new System.Windows.Forms.Button();
            this.cbFirmaMusteri = new System.Windows.Forms.ComboBox();
            this.txtFaturaNo = new System.Windows.Forms.TextBox();
            this.lblFaturaTip = new System.Windows.Forms.Label();
            this.lblFaturaNo = new System.Windows.Forms.Label();
            this.cbFaturaTip = new System.Windows.Forms.ComboBox();
            this.txtFaturaAciklama = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.cbDetay = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStoklar)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpTarihBitis
            // 
            this.dtpTarihBitis.Location = new System.Drawing.Point(184, 12);
            this.dtpTarihBitis.Name = "dtpTarihBitis";
            this.dtpTarihBitis.Size = new System.Drawing.Size(165, 20);
            this.dtpTarihBitis.TabIndex = 30;
            // 
            // dtpTarihBaslangic
            // 
            this.dtpTarihBaslangic.Location = new System.Drawing.Point(13, 12);
            this.dtpTarihBaslangic.Name = "dtpTarihBaslangic";
            this.dtpTarihBaslangic.Size = new System.Drawing.Size(165, 20);
            this.dtpTarihBaslangic.TabIndex = 31;
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
            this.tarih,
            this.saat,
            this.yer,
            this.islemz,
            this.tutar,
            this.odeme_tipi,
            this.belge,
            this.fatura_no,
            this.aciklama});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwStoklar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwStoklar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwStoklar.Location = new System.Drawing.Point(0, 79);
            this.dgwStoklar.Name = "dgwStoklar";
            this.dgwStoklar.RowHeadersVisible = false;
            this.dgwStoklar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwStoklar.Size = new System.Drawing.Size(950, 348);
            this.dgwStoklar.TabIndex = 28;
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
            // 
            // saat
            // 
            this.saat.DataPropertyName = "saat";
            this.saat.HeaderText = "SAAT";
            this.saat.Name = "saat";
            // 
            // yer
            // 
            this.yer.DataPropertyName = "yer";
            this.yer.HeaderText = "MUHATAP";
            this.yer.Name = "yer";
            // 
            // islemz
            // 
            this.islemz.HeaderText = "islem";
            this.islemz.Name = "islemz";
            // 
            // tutar
            // 
            this.tutar.DataPropertyName = "tutar";
            this.tutar.HeaderText = "TUTAR";
            this.tutar.Name = "tutar";
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
            // aciklama
            // 
            this.aciklama.DataPropertyName = "aciklama";
            this.aciklama.HeaderText = "AÇIKLAMA";
            this.aciklama.Name = "aciklama";
            // 
            // cbIslem
            // 
            this.cbIslem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIslem.FormattingEnabled = true;
            this.cbIslem.Location = new System.Drawing.Point(457, 15);
            this.cbIslem.Name = "cbIslem";
            this.cbIslem.Size = new System.Drawing.Size(121, 21);
            this.cbIslem.TabIndex = 32;
            // 
            // lblIslem
            // 
            this.lblIslem.AutoSize = true;
            this.lblIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIslem.Location = new System.Drawing.Point(417, 18);
            this.lblIslem.Name = "lblIslem";
            this.lblIslem.Size = new System.Drawing.Size(36, 13);
            this.lblIslem.TabIndex = 33;
            this.lblIslem.Text = "İşlem";
            // 
            // btnFirmaSec
            // 
            this.btnFirmaSec.Location = new System.Drawing.Point(535, 42);
            this.btnFirmaSec.Name = "btnFirmaSec";
            this.btnFirmaSec.Size = new System.Drawing.Size(43, 21);
            this.btnFirmaSec.TabIndex = 35;
            this.btnFirmaSec.Text = "SEÇ";
            this.btnFirmaSec.UseVisualStyleBackColor = true;
            // 
            // cbFirmaMusteri
            // 
            this.cbFirmaMusteri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFirmaMusteri.FormattingEnabled = true;
            this.cbFirmaMusteri.Items.AddRange(new object[] {
            "Firma",
            "Müşteri"});
            this.cbFirmaMusteri.Location = new System.Drawing.Point(457, 43);
            this.cbFirmaMusteri.Name = "cbFirmaMusteri";
            this.cbFirmaMusteri.Size = new System.Drawing.Size(72, 21);
            this.cbFirmaMusteri.TabIndex = 34;
            // 
            // txtFaturaNo
            // 
            this.txtFaturaNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFaturaNo.Location = new System.Drawing.Point(675, 42);
            this.txtFaturaNo.Name = "txtFaturaNo";
            this.txtFaturaNo.Size = new System.Drawing.Size(76, 20);
            this.txtFaturaNo.TabIndex = 61;
            // 
            // lblFaturaTip
            // 
            this.lblFaturaTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFaturaTip.ForeColor = System.Drawing.Color.Black;
            this.lblFaturaTip.Location = new System.Drawing.Point(597, 18);
            this.lblFaturaTip.Name = "lblFaturaTip";
            this.lblFaturaTip.Size = new System.Drawing.Size(71, 13);
            this.lblFaturaTip.TabIndex = 62;
            this.lblFaturaTip.Text = "Belge";
            this.lblFaturaTip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFaturaNo
            // 
            this.lblFaturaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFaturaNo.ForeColor = System.Drawing.Color.Black;
            this.lblFaturaNo.Location = new System.Drawing.Point(597, 44);
            this.lblFaturaNo.Name = "lblFaturaNo";
            this.lblFaturaNo.Size = new System.Drawing.Size(71, 13);
            this.lblFaturaNo.TabIndex = 63;
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
            this.cbFaturaTip.Location = new System.Drawing.Point(674, 15);
            this.cbFaturaTip.Name = "cbFaturaTip";
            this.cbFaturaTip.Size = new System.Drawing.Size(77, 21);
            this.cbFaturaTip.TabIndex = 60;
            // 
            // txtFaturaAciklama
            // 
            this.txtFaturaAciklama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFaturaAciklama.Location = new System.Drawing.Point(831, 16);
            this.txtFaturaAciklama.Name = "txtFaturaAciklama";
            this.txtFaturaAciklama.Size = new System.Drawing.Size(107, 20);
            this.txtFaturaAciklama.TabIndex = 64;
            // 
            // lblAciklama
            // 
            this.lblAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.ForeColor = System.Drawing.Color.Black;
            this.lblAciklama.Location = new System.Drawing.Point(768, 18);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(58, 13);
            this.lblAciklama.TabIndex = 65;
            this.lblAciklama.Text = "Açıklama";
            this.lblAciklama.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbDetay
            // 
            this.cbDetay.AutoSize = true;
            this.cbDetay.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbDetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbDetay.Location = new System.Drawing.Point(780, 47);
            this.cbDetay.Name = "cbDetay";
            this.cbDetay.Size = new System.Drawing.Size(65, 17);
            this.cbDetay.TabIndex = 66;
            this.cbDetay.Text = "Detaylı";
            this.cbDetay.UseVisualStyleBackColor = true;
            // 
            // frmSatisHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 427);
            this.Controls.Add(this.cbDetay);
            this.Controls.Add(this.txtFaturaAciklama);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.txtFaturaNo);
            this.Controls.Add(this.lblFaturaTip);
            this.Controls.Add(this.lblFaturaNo);
            this.Controls.Add(this.cbFaturaTip);
            this.Controls.Add(this.btnFirmaSec);
            this.Controls.Add(this.cbFirmaMusteri);
            this.Controls.Add(this.lblIslem);
            this.Controls.Add(this.cbIslem);
            this.Controls.Add(this.dtpTarihBitis);
            this.Controls.Add(this.dtpTarihBaslangic);
            this.Controls.Add(this.dgwStoklar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSatisHareketleri";
            this.Text = "MUHASEBE HAREKETLERİ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgwStoklar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpTarihBitis;
        private System.Windows.Forms.DateTimePicker dtpTarihBaslangic;
        private System.Windows.Forms.DataGridView dgwStoklar;
        private System.Windows.Forms.ComboBox cbIslem;
        private System.Windows.Forms.Label lblIslem;
        private System.Windows.Forms.Button btnFirmaSec;
        private System.Windows.Forms.ComboBox cbFirmaMusteri;
        private System.Windows.Forms.TextBox txtFaturaNo;
        private System.Windows.Forms.Label lblFaturaTip;
        private System.Windows.Forms.Label lblFaturaNo;
        private System.Windows.Forms.ComboBox cbFaturaTip;
        private System.Windows.Forms.TextBox txtFaturaAciklama;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn islem;
        private System.Windows.Forms.CheckBox cbDetay;
        private System.Windows.Forms.DataGridViewTextBoxColumn satis_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn saat;
        private System.Windows.Forms.DataGridViewTextBoxColumn yer;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemz;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn odeme_tipi;
        private System.Windows.Forms.DataGridViewTextBoxColumn belge;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatura_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklama;
    }
}