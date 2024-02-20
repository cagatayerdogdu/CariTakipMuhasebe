namespace StokTakip
{
    partial class frmFirmaSec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFirmaSec));
            this.lblFirma = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.dgwFirmalar = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.musteri_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ad_soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cep_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sabit_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.website = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vergi_dairesi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vergi_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firma_unvani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFirmalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirma
            // 
            this.lblFirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFirma.Location = new System.Drawing.Point(12, 19);
            this.lblFirma.Name = "lblFirma";
            this.lblFirma.Size = new System.Drawing.Size(97, 13);
            this.lblFirma.TabIndex = 29;
            this.lblFirma.Text = "FİRMA ARA:";
            this.lblFirma.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(115, 16);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(226, 20);
            this.txtArama.TabIndex = 27;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // dgwFirmalar
            // 
            this.dgwFirmalar.AllowUserToAddRows = false;
            this.dgwFirmalar.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgwFirmalar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwFirmalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwFirmalar.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgwFirmalar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwFirmalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFirmalar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteri_id,
            this.ad_soyad,
            this.cep_tel,
            this.sabit_tel,
            this.email,
            this.adres,
            this.fax,
            this.website,
            this.vergi_dairesi,
            this.vergi_no,
            this.firma_unvani});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwFirmalar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwFirmalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwFirmalar.Location = new System.Drawing.Point(0, 0);
            this.dgwFirmalar.Name = "dgwFirmalar";
            this.dgwFirmalar.ReadOnly = true;
            this.dgwFirmalar.RowHeadersVisible = false;
            this.dgwFirmalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwFirmalar.Size = new System.Drawing.Size(940, 431);
            this.dgwFirmalar.TabIndex = 52;
            this.dgwFirmalar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwFirmalar_CellDoubleClick);
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
            this.splitContainer1.Panel1.Controls.Add(this.lblFirma);
            this.splitContainer1.Panel1.Controls.Add(this.txtArama);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgwFirmalar);
            this.splitContainer1.Size = new System.Drawing.Size(940, 493);
            this.splitContainer1.SplitterDistance = 58;
            this.splitContainer1.TabIndex = 53;
            // 
            // musteri_id
            // 
            this.musteri_id.DataPropertyName = "musteri_id";
            this.musteri_id.HeaderText = "KAYIT ID";
            this.musteri_id.Name = "musteri_id";
            this.musteri_id.ReadOnly = true;
            this.musteri_id.Visible = false;
            // 
            // ad_soyad
            // 
            this.ad_soyad.DataPropertyName = "ad_soyad";
            this.ad_soyad.FillWeight = 177.6651F;
            this.ad_soyad.HeaderText = "AD";
            this.ad_soyad.Name = "ad_soyad";
            this.ad_soyad.ReadOnly = true;
            // 
            // cep_tel
            // 
            this.cep_tel.DataPropertyName = "cep_tel";
            this.cep_tel.FillWeight = 87.05587F;
            this.cep_tel.HeaderText = "CEP TEL";
            this.cep_tel.Name = "cep_tel";
            this.cep_tel.ReadOnly = true;
            // 
            // sabit_tel
            // 
            this.sabit_tel.DataPropertyName = "sabit_tel";
            this.sabit_tel.FillWeight = 87.05587F;
            this.sabit_tel.HeaderText = "SABİT TEL";
            this.sabit_tel.Name = "sabit_tel";
            this.sabit_tel.ReadOnly = true;
            this.sabit_tel.Visible = false;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.FillWeight = 87.05587F;
            this.email.HeaderText = "E-POSTA";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // adres
            // 
            this.adres.DataPropertyName = "adres";
            this.adres.HeaderText = "ADRES";
            this.adres.Name = "adres";
            this.adres.ReadOnly = true;
            // 
            // fax
            // 
            this.fax.DataPropertyName = "fax";
            this.fax.HeaderText = "FAX";
            this.fax.Name = "fax";
            this.fax.ReadOnly = true;
            this.fax.Visible = false;
            // 
            // website
            // 
            this.website.DataPropertyName = "website";
            this.website.HeaderText = "WEB SİTE";
            this.website.Name = "website";
            this.website.ReadOnly = true;
            this.website.Visible = false;
            // 
            // vergi_dairesi
            // 
            this.vergi_dairesi.DataPropertyName = "vergi_dairesi";
            this.vergi_dairesi.FillWeight = 87.05587F;
            this.vergi_dairesi.HeaderText = "V.D.";
            this.vergi_dairesi.Name = "vergi_dairesi";
            this.vergi_dairesi.ReadOnly = true;
            // 
            // vergi_no
            // 
            this.vergi_no.DataPropertyName = "vergi_no";
            this.vergi_no.FillWeight = 87.05587F;
            this.vergi_no.HeaderText = "VERGİ NO";
            this.vergi_no.Name = "vergi_no";
            this.vergi_no.ReadOnly = true;
            // 
            // firma_unvani
            // 
            this.firma_unvani.DataPropertyName = "firma_unvani";
            this.firma_unvani.FillWeight = 87.05587F;
            this.firma_unvani.HeaderText = "ÜNVAN";
            this.firma_unvani.Name = "firma_unvani";
            this.firma_unvani.ReadOnly = true;
            // 
            // frmFirmaSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 493);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFirmaSec";
            this.Text = "FİRMA SEÇ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUrunYonetimi_FormClosed);
            this.Load += new System.EventHandler(this.frmFirmaSec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwFirmalar)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFirma;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.DataGridView dgwFirmalar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteri_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ad_soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cep_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn sabit_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn adres;
        private System.Windows.Forms.DataGridViewTextBoxColumn fax;
        private System.Windows.Forms.DataGridViewTextBoxColumn website;
        private System.Windows.Forms.DataGridViewTextBoxColumn vergi_dairesi;
        private System.Windows.Forms.DataGridViewTextBoxColumn vergi_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn firma_unvani;
    }
}