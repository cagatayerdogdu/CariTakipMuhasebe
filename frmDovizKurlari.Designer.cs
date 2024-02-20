namespace StokTakip
{
    partial class frmDovizKurlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDovizKurlari));
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTarihGuncelleme = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPound = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnInternettenAl = new System.Windows.Forms.Button();
            this.lblDolarAlis = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEuroAlis = new System.Windows.Forms.Label();
            this.lblPoundAlis = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDolarSatis = new System.Windows.Forms.Label();
            this.lblEuroSatis = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblPoundSatis = new System.Windows.Forms.Label();
            this.btnAlisKaydet = new System.Windows.Forms.Button();
            this.btnSatis = new System.Windows.Forms.Button();
            this.gbInternet = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgwDovizler = new System.Windows.Forms.DataGridView();
            this.tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmislemTipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbInternet.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDovizler)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDolar
            // 
            this.txtDolar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDolar.Location = new System.Drawing.Point(118, 38);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(76, 20);
            this.txtDolar.TabIndex = 89;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(23, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 90;
            this.label6.Text = "DOLAR ( $ )";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 90;
            this.label1.Text = "Son Güncelleme:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTarihGuncelleme
            // 
            this.lblTarihGuncelleme.AutoSize = true;
            this.lblTarihGuncelleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarihGuncelleme.ForeColor = System.Drawing.Color.Black;
            this.lblTarihGuncelleme.Location = new System.Drawing.Point(121, 9);
            this.lblTarihGuncelleme.Name = "lblTarihGuncelleme";
            this.lblTarihGuncelleme.Size = new System.Drawing.Size(97, 13);
            this.lblTarihGuncelleme.TabIndex = 90;
            this.lblTarihGuncelleme.Text = "lblTarihGuncelleme";
            this.lblTarihGuncelleme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 90;
            this.label2.Text = "EURO ( € )";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEuro
            // 
            this.txtEuro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEuro.Location = new System.Drawing.Point(118, 64);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(76, 20);
            this.txtEuro.TabIndex = 89;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 90;
            this.label3.Text = "POUND ( £ )";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Visible = false;
            // 
            // txtPound
            // 
            this.txtPound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPound.Location = new System.Drawing.Point(118, 90);
            this.txtPound.Name = "txtPound";
            this.txtPound.Size = new System.Drawing.Size(76, 20);
            this.txtPound.TabIndex = 89;
            this.txtPound.Visible = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Location = new System.Drawing.Point(26, 116);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(168, 38);
            this.btnKaydet.TabIndex = 92;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnInternettenAl
            // 
            this.btnInternettenAl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInternettenAl.Location = new System.Drawing.Point(246, 9);
            this.btnInternettenAl.Name = "btnInternettenAl";
            this.btnInternettenAl.Size = new System.Drawing.Size(197, 25);
            this.btnInternettenAl.TabIndex = 92;
            this.btnInternettenAl.Text = "İNTERNETTEN ÇEK";
            this.btnInternettenAl.UseVisualStyleBackColor = true;
            this.btnInternettenAl.Click += new System.EventHandler(this.btnInternettenAl_Click);
            // 
            // lblDolarAlis
            // 
            this.lblDolarAlis.AutoSize = true;
            this.lblDolarAlis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDolarAlis.ForeColor = System.Drawing.Color.Black;
            this.lblDolarAlis.Location = new System.Drawing.Point(108, 26);
            this.lblDolarAlis.Name = "lblDolarAlis";
            this.lblDolarAlis.Size = new System.Drawing.Size(58, 13);
            this.lblDolarAlis.TabIndex = 93;
            this.lblDolarAlis.Text = "lblDolarAlis";
            this.lblDolarAlis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(22, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 90;
            this.label5.Text = "DOLAR ALIŞ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(29, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 90;
            this.label4.Text = "EURO ALIŞ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEuroAlis
            // 
            this.lblEuroAlis.AutoSize = true;
            this.lblEuroAlis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEuroAlis.ForeColor = System.Drawing.Color.Black;
            this.lblEuroAlis.Location = new System.Drawing.Point(108, 44);
            this.lblEuroAlis.Name = "lblEuroAlis";
            this.lblEuroAlis.Size = new System.Drawing.Size(55, 13);
            this.lblEuroAlis.TabIndex = 93;
            this.lblEuroAlis.Text = "lblEuroAlis";
            this.lblEuroAlis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPoundAlis
            // 
            this.lblPoundAlis.AutoSize = true;
            this.lblPoundAlis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPoundAlis.ForeColor = System.Drawing.Color.Black;
            this.lblPoundAlis.Location = new System.Drawing.Point(108, 62);
            this.lblPoundAlis.Name = "lblPoundAlis";
            this.lblPoundAlis.Size = new System.Drawing.Size(64, 13);
            this.lblPoundAlis.TabIndex = 95;
            this.lblPoundAlis.Text = "lblPoundAlis";
            this.lblPoundAlis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPoundAlis.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(22, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 94;
            this.label8.Text = "POUND ALIŞ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(13, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 90;
            this.label7.Text = "DOLAR SATIŞ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(20, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 90;
            this.label9.Text = "EURO SATIŞ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDolarSatis
            // 
            this.lblDolarSatis.AutoSize = true;
            this.lblDolarSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDolarSatis.ForeColor = System.Drawing.Color.Black;
            this.lblDolarSatis.Location = new System.Drawing.Point(108, 87);
            this.lblDolarSatis.Name = "lblDolarSatis";
            this.lblDolarSatis.Size = new System.Drawing.Size(58, 13);
            this.lblDolarSatis.TabIndex = 93;
            this.lblDolarSatis.Text = "lblDolarAlis";
            this.lblDolarSatis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEuroSatis
            // 
            this.lblEuroSatis.AutoSize = true;
            this.lblEuroSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEuroSatis.ForeColor = System.Drawing.Color.Black;
            this.lblEuroSatis.Location = new System.Drawing.Point(108, 105);
            this.lblEuroSatis.Name = "lblEuroSatis";
            this.lblEuroSatis.Size = new System.Drawing.Size(55, 13);
            this.lblEuroSatis.TabIndex = 93;
            this.lblEuroSatis.Text = "lblEuroAlis";
            this.lblEuroSatis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(11, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 94;
            this.label12.Text = "POUND SATIŞ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label12.Visible = false;
            // 
            // lblPoundSatis
            // 
            this.lblPoundSatis.AutoSize = true;
            this.lblPoundSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPoundSatis.ForeColor = System.Drawing.Color.Black;
            this.lblPoundSatis.Location = new System.Drawing.Point(108, 123);
            this.lblPoundSatis.Name = "lblPoundSatis";
            this.lblPoundSatis.Size = new System.Drawing.Size(64, 13);
            this.lblPoundSatis.TabIndex = 95;
            this.lblPoundSatis.Text = "lblPoundAlis";
            this.lblPoundSatis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPoundSatis.Visible = false;
            // 
            // btnAlisKaydet
            // 
            this.btnAlisKaydet.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlisKaydet.Location = new System.Drawing.Point(12, 150);
            this.btnAlisKaydet.Name = "btnAlisKaydet";
            this.btnAlisKaydet.Size = new System.Drawing.Size(81, 25);
            this.btnAlisKaydet.TabIndex = 92;
            this.btnAlisKaydet.Text = "ALIŞ";
            this.btnAlisKaydet.UseVisualStyleBackColor = true;
            this.btnAlisKaydet.Click += new System.EventHandler(this.btnAlisKaydet_Click);
            // 
            // btnSatis
            // 
            this.btnSatis.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSatis.Location = new System.Drawing.Point(111, 150);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(78, 25);
            this.btnSatis.TabIndex = 92;
            this.btnSatis.Text = "SATIŞ";
            this.btnSatis.UseVisualStyleBackColor = true;
            this.btnSatis.Click += new System.EventHandler(this.btnSatis_Click);
            // 
            // gbInternet
            // 
            this.gbInternet.Controls.Add(this.label5);
            this.gbInternet.Controls.Add(this.lblPoundSatis);
            this.gbInternet.Controls.Add(this.label7);
            this.gbInternet.Controls.Add(this.label12);
            this.gbInternet.Controls.Add(this.label4);
            this.gbInternet.Controls.Add(this.lblPoundAlis);
            this.gbInternet.Controls.Add(this.label9);
            this.gbInternet.Controls.Add(this.lblEuroSatis);
            this.gbInternet.Controls.Add(this.btnAlisKaydet);
            this.gbInternet.Controls.Add(this.label8);
            this.gbInternet.Controls.Add(this.btnSatis);
            this.gbInternet.Controls.Add(this.lblDolarSatis);
            this.gbInternet.Controls.Add(this.lblDolarAlis);
            this.gbInternet.Controls.Add(this.lblEuroAlis);
            this.gbInternet.Location = new System.Drawing.Point(246, 43);
            this.gbInternet.Name = "gbInternet";
            this.gbInternet.Size = new System.Drawing.Size(197, 191);
            this.gbInternet.TabIndex = 96;
            this.gbInternet.TabStop = false;
            this.gbInternet.Text = "Merkez Bankası Verileri";
            this.gbInternet.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgwDovizler);
            this.panel1.Location = new System.Drawing.Point(454, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 382);
            this.panel1.TabIndex = 97;
            // 
            // dgwDovizler
            // 
            this.dgwDovizler.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgwDovizler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwDovizler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwDovizler.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgwDovizler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwDovizler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDovizler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tarih,
            this.usd,
            this.eur,
            this.clmislemTipi});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwDovizler.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwDovizler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwDovizler.Location = new System.Drawing.Point(0, 3);
            this.dgwDovizler.Name = "dgwDovizler";
            this.dgwDovizler.RowHeadersVisible = false;
            this.dgwDovizler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwDovizler.Size = new System.Drawing.Size(345, 379);
            this.dgwDovizler.TabIndex = 98;
            // 
            // tarih
            // 
            this.tarih.DataPropertyName = "tarih";
            this.tarih.FillWeight = 177.665F;
            this.tarih.HeaderText = "TARİH";
            this.tarih.Name = "tarih";
            // 
            // usd
            // 
            this.usd.DataPropertyName = "usd";
            this.usd.FillWeight = 68.03565F;
            this.usd.HeaderText = "USD";
            this.usd.Name = "usd";
            // 
            // eur
            // 
            this.eur.DataPropertyName = "eur";
            this.eur.FillWeight = 72.52531F;
            this.eur.HeaderText = "EUR";
            this.eur.Name = "eur";
            // 
            // clmislemTipi
            // 
            this.clmislemTipi.DataPropertyName = "islemTipi";
            this.clmislemTipi.FillWeight = 119.1865F;
            this.clmislemTipi.HeaderText = "İŞLEM TİPİ";
            this.clmislemTipi.Name = "clmislemTipi";
            // 
            // frmDovizKurlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 392);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbInternet);
            this.Controls.Add(this.btnInternettenAl);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtPound);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTarihGuncelleme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDovizKurlari";
            this.Text = "DÖVİZ KURLARI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUrunYonetimi_FormClosed);
            this.Load += new System.EventHandler(this.frmDovizKurlari_Load);
            this.gbInternet.ResumeLayout(false);
            this.gbInternet.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDovizler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTarihGuncelleme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEuro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPound;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnInternettenAl;
        private System.Windows.Forms.Label lblDolarAlis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEuroAlis;
        private System.Windows.Forms.Label lblPoundAlis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDolarSatis;
        private System.Windows.Forms.Label lblEuroSatis;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblPoundSatis;
        private System.Windows.Forms.Button btnAlisKaydet;
        private System.Windows.Forms.Button btnSatis;
        private System.Windows.Forms.GroupBox gbInternet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgwDovizler;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn usd;
        private System.Windows.Forms.DataGridViewTextBoxColumn eur;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmislemTipi;
    }
}