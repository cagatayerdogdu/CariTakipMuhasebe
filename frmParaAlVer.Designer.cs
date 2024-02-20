namespace StokTakip
{
    partial class frmParaAlVer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParaAlVer));
            this.cbFirmaMusteri = new System.Windows.Forms.ComboBox();
            this.btnFirmaSec = new System.Windows.Forms.Button();
            this.txtFirmalar = new System.Windows.Forms.TextBox();
            this.dtpTarihBaslangic = new System.Windows.Forms.DateTimePicker();
            this.txtOdenenTutar = new System.Windows.Forms.TextBox();
            this.cbOdemeTipi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFaturaAciklama = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.btnUrunKaydet = new System.Windows.Forms.Button();
            this.lblSeciliFirma = new System.Windows.Forms.Label();
            this.lblSeciliKayit = new System.Windows.Forms.Label();
            this.lblToplamSatisTutari = new System.Windows.Forms.Label();
            this.lblToplamSatisTutariSonuc = new System.Windows.Forms.Label();
            this.lblToplamAlinanTutar = new System.Windows.Forms.Label();
            this.lblToplamAlinanTutarSonuc = new System.Windows.Forms.Label();
            this.lblToplamKalanAlacak = new System.Windows.Forms.Label();
            this.lblToplamKalanAlacakSonuc = new System.Windows.Forms.Label();
            this.lblNokta1 = new System.Windows.Forms.Label();
            this.lblNokta2 = new System.Windows.Forms.Label();
            this.lblNokta3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbFirmaMusteri
            // 
            this.cbFirmaMusteri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFirmaMusteri.FormattingEnabled = true;
            this.cbFirmaMusteri.Items.AddRange(new object[] {
            "Firma",
            "Müşteri"});
            this.cbFirmaMusteri.Location = new System.Drawing.Point(28, 35);
            this.cbFirmaMusteri.Name = "cbFirmaMusteri";
            this.cbFirmaMusteri.Size = new System.Drawing.Size(72, 21);
            this.cbFirmaMusteri.TabIndex = 74;
            // 
            // btnFirmaSec
            // 
            this.btnFirmaSec.Location = new System.Drawing.Point(106, 34);
            this.btnFirmaSec.Name = "btnFirmaSec";
            this.btnFirmaSec.Size = new System.Drawing.Size(43, 22);
            this.btnFirmaSec.TabIndex = 75;
            this.btnFirmaSec.Text = "SEÇ";
            this.btnFirmaSec.UseVisualStyleBackColor = true;
            this.btnFirmaSec.Click += new System.EventHandler(this.btnFirmaSec_Click);
            // 
            // txtFirmalar
            // 
            this.txtFirmalar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirmalar.Location = new System.Drawing.Point(155, 35);
            this.txtFirmalar.Name = "txtFirmalar";
            this.txtFirmalar.ReadOnly = true;
            this.txtFirmalar.Size = new System.Drawing.Size(196, 20);
            this.txtFirmalar.TabIndex = 84;
            // 
            // dtpTarihBaslangic
            // 
            this.dtpTarihBaslangic.Location = new System.Drawing.Point(28, 8);
            this.dtpTarihBaslangic.Name = "dtpTarihBaslangic";
            this.dtpTarihBaslangic.Size = new System.Drawing.Size(165, 20);
            this.dtpTarihBaslangic.TabIndex = 85;
            // 
            // txtOdenenTutar
            // 
            this.txtOdenenTutar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOdenenTutar.Location = new System.Drawing.Point(106, 62);
            this.txtOdenenTutar.Name = "txtOdenenTutar";
            this.txtOdenenTutar.Size = new System.Drawing.Size(76, 20);
            this.txtOdenenTutar.TabIndex = 87;
            // 
            // cbOdemeTipi
            // 
            this.cbOdemeTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOdemeTipi.FormattingEnabled = true;
            this.cbOdemeTipi.Items.AddRange(new object[] {
            "KDV Hariç",
            "KDV Dahil"});
            this.cbOdemeTipi.Location = new System.Drawing.Point(188, 62);
            this.cbOdemeTipi.Name = "cbOdemeTipi";
            this.cbOdemeTipi.Size = new System.Drawing.Size(77, 21);
            this.cbOdemeTipi.TabIndex = 86;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(11, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 88;
            this.label6.Text = "Ödenen Tutar";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFaturaAciklama
            // 
            this.txtFaturaAciklama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFaturaAciklama.Location = new System.Drawing.Point(106, 90);
            this.txtFaturaAciklama.Multiline = true;
            this.txtFaturaAciklama.Name = "txtFaturaAciklama";
            this.txtFaturaAciklama.Size = new System.Drawing.Size(247, 47);
            this.txtFaturaAciklama.TabIndex = 89;
            // 
            // lblAciklama
            // 
            this.lblAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.ForeColor = System.Drawing.Color.Black;
            this.lblAciklama.Location = new System.Drawing.Point(31, 107);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(71, 13);
            this.lblAciklama.TabIndex = 90;
            this.lblAciklama.Text = "Açıklama";
            this.lblAciklama.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnUrunKaydet
            // 
            this.btnUrunKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrunKaydet.Location = new System.Drawing.Point(106, 153);
            this.btnUrunKaydet.Name = "btnUrunKaydet";
            this.btnUrunKaydet.Size = new System.Drawing.Size(247, 38);
            this.btnUrunKaydet.TabIndex = 91;
            this.btnUrunKaydet.Text = "KAYDET";
            this.btnUrunKaydet.UseVisualStyleBackColor = true;
            this.btnUrunKaydet.Click += new System.EventHandler(this.btnUrunKaydet_Click);
            // 
            // lblSeciliFirma
            // 
            this.lblSeciliFirma.AccessibleDescription = "";
            this.lblSeciliFirma.AutoSize = true;
            this.lblSeciliFirma.Location = new System.Drawing.Point(286, 14);
            this.lblSeciliFirma.Name = "lblSeciliFirma";
            this.lblSeciliFirma.Size = new System.Drawing.Size(67, 13);
            this.lblSeciliFirma.TabIndex = 92;
            this.lblSeciliFirma.Text = "lblSeciliFirma";
            this.lblSeciliFirma.Visible = false;
            // 
            // lblSeciliKayit
            // 
            this.lblSeciliKayit.AccessibleDescription = "";
            this.lblSeciliKayit.AutoSize = true;
            this.lblSeciliKayit.Location = new System.Drawing.Point(359, 15);
            this.lblSeciliKayit.Name = "lblSeciliKayit";
            this.lblSeciliKayit.Size = new System.Drawing.Size(65, 13);
            this.lblSeciliKayit.TabIndex = 93;
            this.lblSeciliKayit.Text = "lblSeciliKayit";
            this.lblSeciliKayit.Visible = false;
            // 
            // lblToplamSatisTutari
            // 
            this.lblToplamSatisTutari.AutoSize = true;
            this.lblToplamSatisTutari.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamSatisTutari.Location = new System.Drawing.Point(430, 38);
            this.lblToplamSatisTutari.Name = "lblToplamSatisTutari";
            this.lblToplamSatisTutari.Size = new System.Drawing.Size(117, 13);
            this.lblToplamSatisTutari.TabIndex = 94;
            this.lblToplamSatisTutari.Text = "Toplam Satış Tutarı";
            this.lblToplamSatisTutari.Visible = false;
            // 
            // lblToplamSatisTutariSonuc
            // 
            this.lblToplamSatisTutariSonuc.AutoSize = true;
            this.lblToplamSatisTutariSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamSatisTutariSonuc.ForeColor = System.Drawing.Color.Blue;
            this.lblToplamSatisTutariSonuc.Location = new System.Drawing.Point(571, 38);
            this.lblToplamSatisTutariSonuc.Name = "lblToplamSatisTutariSonuc";
            this.lblToplamSatisTutariSonuc.Size = new System.Drawing.Size(117, 13);
            this.lblToplamSatisTutariSonuc.TabIndex = 95;
            this.lblToplamSatisTutariSonuc.Text = "Toplam Satış Tutarı";
            this.lblToplamSatisTutariSonuc.Visible = false;
            // 
            // lblToplamAlinanTutar
            // 
            this.lblToplamAlinanTutar.AutoSize = true;
            this.lblToplamAlinanTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamAlinanTutar.Location = new System.Drawing.Point(430, 65);
            this.lblToplamAlinanTutar.Name = "lblToplamAlinanTutar";
            this.lblToplamAlinanTutar.Size = new System.Drawing.Size(121, 13);
            this.lblToplamAlinanTutar.TabIndex = 94;
            this.lblToplamAlinanTutar.Text = "Toplam Alınan Tutar";
            this.lblToplamAlinanTutar.Visible = false;
            // 
            // lblToplamAlinanTutarSonuc
            // 
            this.lblToplamAlinanTutarSonuc.AutoSize = true;
            this.lblToplamAlinanTutarSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamAlinanTutarSonuc.ForeColor = System.Drawing.Color.Green;
            this.lblToplamAlinanTutarSonuc.Location = new System.Drawing.Point(571, 65);
            this.lblToplamAlinanTutarSonuc.Name = "lblToplamAlinanTutarSonuc";
            this.lblToplamAlinanTutarSonuc.Size = new System.Drawing.Size(121, 13);
            this.lblToplamAlinanTutarSonuc.TabIndex = 95;
            this.lblToplamAlinanTutarSonuc.Text = "Toplam Alınan Tutar";
            this.lblToplamAlinanTutarSonuc.Visible = false;
            // 
            // lblToplamKalanAlacak
            // 
            this.lblToplamKalanAlacak.AutoSize = true;
            this.lblToplamKalanAlacak.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamKalanAlacak.Location = new System.Drawing.Point(430, 90);
            this.lblToplamKalanAlacak.Name = "lblToplamKalanAlacak";
            this.lblToplamKalanAlacak.Size = new System.Drawing.Size(127, 13);
            this.lblToplamKalanAlacak.TabIndex = 94;
            this.lblToplamKalanAlacak.Text = "Toplam Kalan Alacak";
            this.lblToplamKalanAlacak.Visible = false;
            // 
            // lblToplamKalanAlacakSonuc
            // 
            this.lblToplamKalanAlacakSonuc.AutoSize = true;
            this.lblToplamKalanAlacakSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamKalanAlacakSonuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblToplamKalanAlacakSonuc.Location = new System.Drawing.Point(571, 90);
            this.lblToplamKalanAlacakSonuc.Name = "lblToplamKalanAlacakSonuc";
            this.lblToplamKalanAlacakSonuc.Size = new System.Drawing.Size(127, 13);
            this.lblToplamKalanAlacakSonuc.TabIndex = 95;
            this.lblToplamKalanAlacakSonuc.Text = "Toplam Kalan Alacak";
            this.lblToplamKalanAlacakSonuc.Visible = false;
            // 
            // lblNokta1
            // 
            this.lblNokta1.AutoSize = true;
            this.lblNokta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNokta1.Location = new System.Drawing.Point(555, 38);
            this.lblNokta1.Name = "lblNokta1";
            this.lblNokta1.Size = new System.Drawing.Size(11, 13);
            this.lblNokta1.TabIndex = 96;
            this.lblNokta1.Text = ":";
            this.lblNokta1.Visible = false;
            // 
            // lblNokta2
            // 
            this.lblNokta2.AutoSize = true;
            this.lblNokta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNokta2.Location = new System.Drawing.Point(555, 65);
            this.lblNokta2.Name = "lblNokta2";
            this.lblNokta2.Size = new System.Drawing.Size(11, 13);
            this.lblNokta2.TabIndex = 96;
            this.lblNokta2.Text = ":";
            this.lblNokta2.Visible = false;
            // 
            // lblNokta3
            // 
            this.lblNokta3.AutoSize = true;
            this.lblNokta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNokta3.Location = new System.Drawing.Point(555, 90);
            this.lblNokta3.Name = "lblNokta3";
            this.lblNokta3.Size = new System.Drawing.Size(11, 13);
            this.lblNokta3.TabIndex = 96;
            this.lblNokta3.Text = ":";
            this.lblNokta3.Visible = false;
            // 
            // frmParaAlVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 474);
            this.Controls.Add(this.lblNokta3);
            this.Controls.Add(this.lblNokta2);
            this.Controls.Add(this.lblNokta1);
            this.Controls.Add(this.lblToplamKalanAlacakSonuc);
            this.Controls.Add(this.lblToplamAlinanTutarSonuc);
            this.Controls.Add(this.lblToplamSatisTutariSonuc);
            this.Controls.Add(this.lblToplamKalanAlacak);
            this.Controls.Add(this.lblToplamAlinanTutar);
            this.Controls.Add(this.lblToplamSatisTutari);
            this.Controls.Add(this.lblSeciliKayit);
            this.Controls.Add(this.lblSeciliFirma);
            this.Controls.Add(this.btnUrunKaydet);
            this.Controls.Add(this.txtFaturaAciklama);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.txtOdenenTutar);
            this.Controls.Add(this.cbOdemeTipi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpTarihBaslangic);
            this.Controls.Add(this.txtFirmalar);
            this.Controls.Add(this.cbFirmaMusteri);
            this.Controls.Add(this.btnFirmaSec);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmParaAlVer";
            this.Text = "PARA AL";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUrunYonetimi_FormClosed);
            this.Load += new System.EventHandler(this.frmParaAlVer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFirmaMusteri;
        private System.Windows.Forms.Button btnFirmaSec;
        private System.Windows.Forms.TextBox txtFirmalar;
        private System.Windows.Forms.DateTimePicker dtpTarihBaslangic;
        private System.Windows.Forms.TextBox txtOdenenTutar;
        private System.Windows.Forms.ComboBox cbOdemeTipi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFaturaAciklama;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Button btnUrunKaydet;
        private System.Windows.Forms.Label lblSeciliFirma;
        private System.Windows.Forms.Label lblSeciliKayit;
        private System.Windows.Forms.Label lblToplamSatisTutari;
        private System.Windows.Forms.Label lblToplamSatisTutariSonuc;
        private System.Windows.Forms.Label lblToplamAlinanTutar;
        private System.Windows.Forms.Label lblToplamAlinanTutarSonuc;
        private System.Windows.Forms.Label lblToplamKalanAlacak;
        private System.Windows.Forms.Label lblToplamKalanAlacakSonuc;
        private System.Windows.Forms.Label lblNokta1;
        private System.Windows.Forms.Label lblNokta2;
        private System.Windows.Forms.Label lblNokta3;
    }
}