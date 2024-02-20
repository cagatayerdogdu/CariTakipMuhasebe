namespace StokTakip
{
    partial class frmMusteriYonetimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteriYonetimi));
            this.dgwMusteriler = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtTcKimlik_old = new System.Windows.Forms.ComboBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCepTel_old = new System.Windows.Forms.TextBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCepTel = new System.Windows.Forms.Label();
            this.lblTcKimlik = new System.Windows.Forms.Label();
            this.epHataDedektoru = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnMusteriYonetimi_ExceleAktar = new System.Windows.Forms.Button();
            this.menuSag = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuSecilenKaydiSifirlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblArama = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.txtTcKimlik = new System.Windows.Forms.MaskedTextBox();
            this.txtCepTel = new System.Windows.Forms.MaskedTextBox();
            this.clmGiris_DepoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGiris_UrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGiris_UrunMarkasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGiris_UrunModeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGiris_UrunSeriali = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusteriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epHataDedektoru)).BeginInit();
            this.menuSag.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwMusteriler
            // 
            this.dgwMusteriler.AllowUserToAddRows = false;
            this.dgwMusteriler.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgwMusteriler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwMusteriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwMusteriler.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgwMusteriler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMusteriler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmGiris_DepoId,
            this.clmGiris_UrunAdi,
            this.clmGiris_UrunMarkasi,
            this.clmGiris_UrunModeli,
            this.clmGiris_UrunSeriali,
            this.urun_fiyat});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwMusteriler.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwMusteriler.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgwMusteriler.Location = new System.Drawing.Point(284, 0);
            this.dgwMusteriler.Name = "dgwMusteriler";
            this.dgwMusteriler.ReadOnly = true;
            this.dgwMusteriler.RowHeadersVisible = false;
            this.dgwMusteriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwMusteriler.Size = new System.Drawing.Size(601, 460);
            this.dgwMusteriler.TabIndex = 36;
            this.dgwMusteriler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMusteriler_CellDoubleClick);
            this.dgwMusteriler.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgwMusteriler_MouseUp);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSil.Location = new System.Drawing.Point(10, 312);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(242, 38);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Visible = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Location = new System.Drawing.Point(9, 268);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(242, 38);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtTcKimlik_old
            // 
            this.txtTcKimlik_old.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.txtTcKimlik_old.FormattingEnabled = true;
            this.txtTcKimlik_old.Location = new System.Drawing.Point(209, 82);
            this.txtTcKimlik_old.Name = "txtTcKimlik_old";
            this.txtTcKimlik_old.Size = new System.Drawing.Size(160, 21);
            this.txtTcKimlik_old.TabIndex = 222;
            this.txtTcKimlik_old.Visible = false;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(92, 54);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(159, 20);
            this.txtAdSoyad.TabIndex = 2;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(93, 164);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(159, 98);
            this.txtAdres.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(93, 137);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(159, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // txtCepTel_old
            // 
            this.txtCepTel_old.Location = new System.Drawing.Point(204, 111);
            this.txtCepTel_old.Name = "txtCepTel_old";
            this.txtCepTel_old.Size = new System.Drawing.Size(159, 20);
            this.txtCepTel_old.TabIndex = 333;
            this.txtCepTel_old.Visible = false;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.ForeColor = System.Drawing.Color.Black;
            this.lblAdSoyad.Location = new System.Drawing.Point(6, 57);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(61, 13);
            this.lblAdSoyad.TabIndex = 29;
            this.lblAdSoyad.Text = "Ad Soyad";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.ForeColor = System.Drawing.Color.Black;
            this.lblAdres.Location = new System.Drawing.Point(6, 167);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(39, 13);
            this.lblAdres.TabIndex = 30;
            this.lblAdres.Text = "Adres";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(6, 140);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 13);
            this.lblEmail.TabIndex = 31;
            this.lblEmail.Text = "E-mail";
            // 
            // lblCepTel
            // 
            this.lblCepTel.AutoSize = true;
            this.lblCepTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCepTel.ForeColor = System.Drawing.Color.Black;
            this.lblCepTel.Location = new System.Drawing.Point(6, 113);
            this.lblCepTel.Name = "lblCepTel";
            this.lblCepTel.Size = new System.Drawing.Size(34, 13);
            this.lblCepTel.TabIndex = 32;
            this.lblCepTel.Text = "GSM";
            // 
            // lblTcKimlik
            // 
            this.lblTcKimlik.AutoSize = true;
            this.lblTcKimlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTcKimlik.ForeColor = System.Drawing.Color.Black;
            this.lblTcKimlik.Location = new System.Drawing.Point(6, 85);
            this.lblTcKimlik.Name = "lblTcKimlik";
            this.lblTcKimlik.Size = new System.Drawing.Size(80, 13);
            this.lblTcKimlik.TabIndex = 33;
            this.lblTcKimlik.Text = "TC Kimlik No";
            // 
            // epHataDedektoru
            // 
            this.epHataDedektoru.ContainerControl = this;
            // 
            // btnMusteriYonetimi_ExceleAktar
            // 
            this.btnMusteriYonetimi_ExceleAktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriYonetimi_ExceleAktar.ForeColor = System.Drawing.Color.Black;
            this.epHataDedektoru.SetIconAlignment(this.btnMusteriYonetimi_ExceleAktar, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.btnMusteriYonetimi_ExceleAktar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteriYonetimi_ExceleAktar.Location = new System.Drawing.Point(186, 386);
            this.btnMusteriYonetimi_ExceleAktar.Name = "btnMusteriYonetimi_ExceleAktar";
            this.btnMusteriYonetimi_ExceleAktar.Size = new System.Drawing.Size(66, 37);
            this.btnMusteriYonetimi_ExceleAktar.TabIndex = 11;
            this.btnMusteriYonetimi_ExceleAktar.Text = "EXCELE AKTAR";
            this.btnMusteriYonetimi_ExceleAktar.UseVisualStyleBackColor = true;
            this.btnMusteriYonetimi_ExceleAktar.Click += new System.EventHandler(this.btnMusteriYonetimi_ExceleAktar_Click);
            // 
            // menuSag
            // 
            this.menuSag.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSecilenKaydiSifirlaToolStripMenuItem});
            this.menuSag.Name = "menuSag";
            this.menuSag.Size = new System.Drawing.Size(193, 26);
            // 
            // menuSecilenKaydiSifirlaToolStripMenuItem
            // 
            this.menuSecilenKaydiSifirlaToolStripMenuItem.Name = "menuSecilenKaydiSifirlaToolStripMenuItem";
            this.menuSecilenKaydiSifirlaToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.menuSecilenKaydiSifirlaToolStripMenuItem.Text = "Müşteri seçimini sıfırla";
            this.menuSecilenKaydiSifirlaToolStripMenuItem.Click += new System.EventHandler(this.menuSecilenKaydiSifirlaToolStripMenuItem_Click);
            // 
            // lblArama
            // 
            this.lblArama.AutoSize = true;
            this.lblArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblArama.ForeColor = System.Drawing.Color.Black;
            this.lblArama.Location = new System.Drawing.Point(7, 12);
            this.lblArama.Name = "lblArama";
            this.lblArama.Size = new System.Drawing.Size(36, 13);
            this.lblArama.TabIndex = 29;
            this.lblArama.Text = "ARA:";
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(93, 9);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(159, 20);
            this.txtArama.TabIndex = 1;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // txtTcKimlik
            // 
            this.txtTcKimlik.Location = new System.Drawing.Point(92, 82);
            this.txtTcKimlik.Mask = "00000000000";
            this.txtTcKimlik.Name = "txtTcKimlik";
            this.txtTcKimlik.Size = new System.Drawing.Size(159, 20);
            this.txtTcKimlik.TabIndex = 3;
            // 
            // txtCepTel
            // 
            this.txtCepTel.Location = new System.Drawing.Point(92, 110);
            this.txtCepTel.Mask = "000-000-00-00";
            this.txtCepTel.Name = "txtCepTel";
            this.txtCepTel.Size = new System.Drawing.Size(159, 20);
            this.txtCepTel.TabIndex = 4;
            // 
            // clmGiris_DepoId
            // 
            this.clmGiris_DepoId.DataPropertyName = "musteri_id";
            this.clmGiris_DepoId.HeaderText = "KAYIT ID";
            this.clmGiris_DepoId.Name = "clmGiris_DepoId";
            this.clmGiris_DepoId.ReadOnly = true;
            this.clmGiris_DepoId.Visible = false;
            // 
            // clmGiris_UrunAdi
            // 
            this.clmGiris_UrunAdi.DataPropertyName = "ad_soyad";
            this.clmGiris_UrunAdi.HeaderText = "AD SOYAD";
            this.clmGiris_UrunAdi.Name = "clmGiris_UrunAdi";
            this.clmGiris_UrunAdi.ReadOnly = true;
            // 
            // clmGiris_UrunMarkasi
            // 
            this.clmGiris_UrunMarkasi.DataPropertyName = "tc_kimlik";
            this.clmGiris_UrunMarkasi.HeaderText = "TC KİMLİK";
            this.clmGiris_UrunMarkasi.Name = "clmGiris_UrunMarkasi";
            this.clmGiris_UrunMarkasi.ReadOnly = true;
            // 
            // clmGiris_UrunModeli
            // 
            this.clmGiris_UrunModeli.DataPropertyName = "cep_tel";
            this.clmGiris_UrunModeli.HeaderText = "GSM";
            this.clmGiris_UrunModeli.Name = "clmGiris_UrunModeli";
            this.clmGiris_UrunModeli.ReadOnly = true;
            // 
            // clmGiris_UrunSeriali
            // 
            this.clmGiris_UrunSeriali.DataPropertyName = "email";
            this.clmGiris_UrunSeriali.HeaderText = "E-POSTA";
            this.clmGiris_UrunSeriali.Name = "clmGiris_UrunSeriali";
            this.clmGiris_UrunSeriali.ReadOnly = true;
            // 
            // urun_fiyat
            // 
            this.urun_fiyat.DataPropertyName = "adres";
            this.urun_fiyat.HeaderText = "ADRES";
            this.urun_fiyat.Name = "urun_fiyat";
            this.urun_fiyat.ReadOnly = true;
            // 
            // frmMusteriYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 460);
            this.Controls.Add(this.txtCepTel);
            this.Controls.Add(this.txtTcKimlik);
            this.Controls.Add(this.btnMusteriYonetimi_ExceleAktar);
            this.Controls.Add(this.dgwMusteriler);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtTcKimlik_old);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCepTel_old);
            this.Controls.Add(this.lblArama);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCepTel);
            this.Controls.Add(this.lblTcKimlik);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMusteriYonetimi";
            this.Text = "MÜŞTERİ YÖNETİMİ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUrunYonetimi_FormClosed);
            this.Load += new System.EventHandler(this.frmMusteriYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusteriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epHataDedektoru)).EndInit();
            this.menuSag.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwMusteriler;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ComboBox txtTcKimlik_old;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCepTel_old;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCepTel;
        private System.Windows.Forms.Label lblTcKimlik;
        private System.Windows.Forms.ErrorProvider epHataDedektoru;
        private System.Windows.Forms.ContextMenuStrip menuSag;
        private System.Windows.Forms.ToolStripMenuItem menuSecilenKaydiSifirlaToolStripMenuItem;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label lblArama;
        private System.Windows.Forms.Button btnMusteriYonetimi_ExceleAktar;
        private System.Windows.Forms.MaskedTextBox txtTcKimlik;
        private System.Windows.Forms.MaskedTextBox txtCepTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGiris_DepoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGiris_UrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGiris_UrunMarkasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGiris_UrunModeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGiris_UrunSeriali;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_fiyat;
    }
}