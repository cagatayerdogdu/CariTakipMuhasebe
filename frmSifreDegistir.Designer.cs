namespace StokTakip
{
    partial class frmSifreDegistir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSifreDegistir));
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtEskiSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.lblEskiSifre = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYeniSifreTekrar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Location = new System.Drawing.Point(136, 111);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(153, 38);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtEskiSifre
            // 
            this.txtEskiSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEskiSifre.Location = new System.Drawing.Point(136, 33);
            this.txtEskiSifre.Name = "txtEskiSifre";
            this.txtEskiSifre.Size = new System.Drawing.Size(153, 20);
            this.txtEskiSifre.TabIndex = 2;
            this.txtEskiSifre.UseSystemPasswordChar = true;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(136, 7);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(153, 20);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // lblEskiSifre
            // 
            this.lblEskiSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEskiSifre.ForeColor = System.Drawing.Color.Black;
            this.lblEskiSifre.Location = new System.Drawing.Point(12, 35);
            this.lblEskiSifre.Name = "lblEskiSifre";
            this.lblEskiSifre.Size = new System.Drawing.Size(118, 13);
            this.lblEskiSifre.TabIndex = 97;
            this.lblEskiSifre.Text = "Eski Şifre";
            this.lblEskiSifre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.ForeColor = System.Drawing.Color.Black;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(12, 9);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(118, 13);
            this.lblKullaniciAdi.TabIndex = 98;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı";
            this.lblKullaniciAdi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 97;
            this.label1.Text = "Yeni Şifre";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYeniSifre.Location = new System.Drawing.Point(136, 59);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.Size = new System.Drawing.Size(153, 20);
            this.txtYeniSifre.TabIndex = 3;
            this.txtYeniSifre.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 97;
            this.label2.Text = "Yeni Şifre (Tekrar)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtYeniSifreTekrar
            // 
            this.txtYeniSifreTekrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYeniSifreTekrar.Location = new System.Drawing.Point(136, 85);
            this.txtYeniSifreTekrar.Name = "txtYeniSifreTekrar";
            this.txtYeniSifreTekrar.Size = new System.Drawing.Size(153, 20);
            this.txtYeniSifreTekrar.TabIndex = 4;
            this.txtYeniSifreTekrar.UseSystemPasswordChar = true;
            // 
            // frmSifreDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 262);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtYeniSifreTekrar);
            this.Controls.Add(this.txtYeniSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEskiSifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblEskiSifre);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSifreDegistir";
            this.Text = "ŞİFRE GÜNCELLE";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSifreDegistir_FormClosed);
            this.Load += new System.EventHandler(this.frmSifreDegistir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtEskiSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label lblEskiSifre;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYeniSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYeniSifreTekrar;
    }
}