namespace StokTakip
{
    partial class frmFirmaYonetimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFirmaYonetimi));
            this.menuSag = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuSecilenKaydiSifirlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.epHataDedektoru = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnFirmaYonetimi_ExceleAktar = new System.Windows.Forms.Button();
            this.dgwMusteriler = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCepTel_old = new System.Windows.Forms.TextBox();
            this.lblArama = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCepTel = new System.Windows.Forms.Label();
            this.lblSabitTel = new System.Windows.Forms.Label();
            this.txtSabitTel_old = new System.Windows.Forms.TextBox();
            this.lblFax = new System.Windows.Forms.Label();
            this.txtFax_old = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWebSitesi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVergiDairesi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVergiNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFirmaUnvani = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtFax = new System.Windows.Forms.MaskedTextBox();
            this.txtSabitTel = new System.Windows.Forms.MaskedTextBox();
            this.txtCepTel = new System.Windows.Forms.MaskedTextBox();
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
            this.menuSag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epHataDedektoru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusteriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuSag
            // 
            this.menuSag.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSecilenKaydiSifirlaToolStripMenuItem});
            this.menuSag.Name = "menuSag";
            this.menuSag.Size = new System.Drawing.Size(183, 26);
            // 
            // menuSecilenKaydiSifirlaToolStripMenuItem
            // 
            this.menuSecilenKaydiSifirlaToolStripMenuItem.Name = "menuSecilenKaydiSifirlaToolStripMenuItem";
            this.menuSecilenKaydiSifirlaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.menuSecilenKaydiSifirlaToolStripMenuItem.Text = "Firma seçimini sıfırla";
            this.menuSecilenKaydiSifirlaToolStripMenuItem.Click += new System.EventHandler(this.menuSecilenKaydiSifirlaToolStripMenuItem_Click);
            // 
            // epHataDedektoru
            // 
            this.epHataDedektoru.ContainerControl = this;
            // 
            // btnFirmaYonetimi_ExceleAktar
            // 
            this.btnFirmaYonetimi_ExceleAktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFirmaYonetimi_ExceleAktar.ForeColor = System.Drawing.Color.Black;
            this.epHataDedektoru.SetIconAlignment(this.btnFirmaYonetimi_ExceleAktar, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.btnFirmaYonetimi_ExceleAktar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFirmaYonetimi_ExceleAktar.Location = new System.Drawing.Point(52, 96);
            this.btnFirmaYonetimi_ExceleAktar.Name = "btnFirmaYonetimi_ExceleAktar";
            this.btnFirmaYonetimi_ExceleAktar.Size = new System.Drawing.Size(66, 37);
            this.btnFirmaYonetimi_ExceleAktar.TabIndex = 53;
            this.btnFirmaYonetimi_ExceleAktar.Text = "EXCELE AKTAR";
            this.btnFirmaYonetimi_ExceleAktar.UseVisualStyleBackColor = true;
            this.btnFirmaYonetimi_ExceleAktar.Click += new System.EventHandler(this.btnFirmaYonetimi_ExceleAktar_Click);
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
            this.dgwMusteriler.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwMusteriler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwMusteriler.Location = new System.Drawing.Point(0, 0);
            this.dgwMusteriler.Name = "dgwMusteriler";
            this.dgwMusteriler.ReadOnly = true;
            this.dgwMusteriler.RowHeadersVisible = false;
            this.dgwMusteriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwMusteriler.Size = new System.Drawing.Size(980, 261);
            this.dgwMusteriler.TabIndex = 51;
            this.dgwMusteriler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMusteriler_CellDoubleClick);
            this.dgwMusteriler.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgwMusteriler_MouseUp);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSil.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSil.Location = new System.Drawing.Point(809, 52);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(168, 38);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Visible = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Location = new System.Drawing.Point(809, 3);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(168, 38);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(52, 15);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(152, 20);
            this.txtArama.TabIndex = 1;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(390, 6);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(152, 20);
            this.txtAdSoyad.TabIndex = 2;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(636, 72);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(152, 52);
            this.txtAdres.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(390, 92);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(152, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // txtCepTel_old
            // 
            this.txtCepTel_old.Location = new System.Drawing.Point(124, 41);
            this.txtCepTel_old.Name = "txtCepTel_old";
            this.txtCepTel_old.Size = new System.Drawing.Size(152, 20);
            this.txtCepTel_old.TabIndex = 333;
            this.txtCepTel_old.Visible = false;
            // 
            // lblArama
            // 
            this.lblArama.AutoSize = true;
            this.lblArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblArama.ForeColor = System.Drawing.Color.Black;
            this.lblArama.Location = new System.Drawing.Point(10, 18);
            this.lblArama.Name = "lblArama";
            this.lblArama.Size = new System.Drawing.Size(36, 13);
            this.lblArama.TabIndex = 45;
            this.lblArama.Text = "ARA:";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.ForeColor = System.Drawing.Color.Black;
            this.lblAdSoyad.Location = new System.Drawing.Point(306, 9);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(59, 13);
            this.lblAdSoyad.TabIndex = 46;
            this.lblAdSoyad.Text = "Firma Adı";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.ForeColor = System.Drawing.Color.Black;
            this.lblAdres.Location = new System.Drawing.Point(591, 77);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(39, 13);
            this.lblAdres.TabIndex = 47;
            this.lblAdres.Text = "Adres";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(306, 95);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 13);
            this.lblEmail.TabIndex = 48;
            this.lblEmail.Text = "E-mail";
            // 
            // lblCepTel
            // 
            this.lblCepTel.AutoSize = true;
            this.lblCepTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCepTel.ForeColor = System.Drawing.Color.Black;
            this.lblCepTel.Location = new System.Drawing.Point(306, 30);
            this.lblCepTel.Name = "lblCepTel";
            this.lblCepTel.Size = new System.Drawing.Size(51, 13);
            this.lblCepTel.TabIndex = 49;
            this.lblCepTel.Text = "Cep Tel";
            // 
            // lblSabitTel
            // 
            this.lblSabitTel.AutoSize = true;
            this.lblSabitTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSabitTel.ForeColor = System.Drawing.Color.Black;
            this.lblSabitTel.Location = new System.Drawing.Point(305, 51);
            this.lblSabitTel.Name = "lblSabitTel";
            this.lblSabitTel.Size = new System.Drawing.Size(58, 13);
            this.lblSabitTel.TabIndex = 49;
            this.lblSabitTel.Text = "Sabit Tel";
            // 
            // txtSabitTel_old
            // 
            this.txtSabitTel_old.Location = new System.Drawing.Point(124, 59);
            this.txtSabitTel_old.Name = "txtSabitTel_old";
            this.txtSabitTel_old.Size = new System.Drawing.Size(152, 20);
            this.txtSabitTel_old.TabIndex = 444;
            this.txtSabitTel_old.Visible = false;
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFax.ForeColor = System.Drawing.Color.Black;
            this.lblFax.Location = new System.Drawing.Point(306, 72);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(27, 13);
            this.lblFax.TabIndex = 49;
            this.lblFax.Text = "Fax";
            // 
            // txtFax_old
            // 
            this.txtFax_old.Location = new System.Drawing.Point(124, 77);
            this.txtFax_old.Name = "txtFax_old";
            this.txtFax_old.Size = new System.Drawing.Size(152, 20);
            this.txtFax_old.TabIndex = 555;
            this.txtFax_old.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(306, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Web Sitesi";
            // 
            // txtWebSitesi
            // 
            this.txtWebSitesi.Location = new System.Drawing.Point(390, 113);
            this.txtWebSitesi.Name = "txtWebSitesi";
            this.txtWebSitesi.Size = new System.Drawing.Size(152, 20);
            this.txtWebSitesi.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(552, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Vergi Dairesi";
            // 
            // txtVergiDairesi
            // 
            this.txtVergiDairesi.Location = new System.Drawing.Point(636, 6);
            this.txtVergiDairesi.Name = "txtVergiDairesi";
            this.txtVergiDairesi.Size = new System.Drawing.Size(152, 20);
            this.txtVergiDairesi.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(552, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Vergi No";
            // 
            // txtVergiNo
            // 
            this.txtVergiNo.Location = new System.Drawing.Point(636, 28);
            this.txtVergiNo.Name = "txtVergiNo";
            this.txtVergiNo.Size = new System.Drawing.Size(152, 20);
            this.txtVergiNo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(552, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Firma Ünvanı";
            // 
            // txtFirmaUnvani
            // 
            this.txtFirmaUnvani.Location = new System.Drawing.Point(636, 50);
            this.txtFirmaUnvani.Name = "txtFirmaUnvani";
            this.txtFirmaUnvani.Size = new System.Drawing.Size(152, 20);
            this.txtFirmaUnvani.TabIndex = 10;
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
            this.splitContainer1.Panel1.Controls.Add(this.txtFax);
            this.splitContainer1.Panel1.Controls.Add(this.txtSabitTel);
            this.splitContainer1.Panel1.Controls.Add(this.txtCepTel);
            this.splitContainer1.Panel1.Controls.Add(this.btnFirmaYonetimi_ExceleAktar);
            this.splitContainer1.Panel1.Controls.Add(this.btnKaydet);
            this.splitContainer1.Panel1.Controls.Add(this.btnSil);
            this.splitContainer1.Panel1.Controls.Add(this.txtAdres);
            this.splitContainer1.Panel1.Controls.Add(this.txtAdSoyad);
            this.splitContainer1.Panel1.Controls.Add(this.txtFirmaUnvani);
            this.splitContainer1.Panel1.Controls.Add(this.txtArama);
            this.splitContainer1.Panel1.Controls.Add(this.txtVergiNo);
            this.splitContainer1.Panel1.Controls.Add(this.lblArama);
            this.splitContainer1.Panel1.Controls.Add(this.txtVergiDairesi);
            this.splitContainer1.Panel1.Controls.Add(this.lblAdSoyad);
            this.splitContainer1.Panel1.Controls.Add(this.txtWebSitesi);
            this.splitContainer1.Panel1.Controls.Add(this.lblCepTel);
            this.splitContainer1.Panel1.Controls.Add(this.txtEmail);
            this.splitContainer1.Panel1.Controls.Add(this.lblSabitTel);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.lblFax);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtCepTel_old);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtFax_old);
            this.splitContainer1.Panel1.Controls.Add(this.lblAdres);
            this.splitContainer1.Panel1.Controls.Add(this.txtSabitTel_old);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.lblEmail);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgwMusteriler);
            this.splitContainer1.Size = new System.Drawing.Size(980, 410);
            this.splitContainer1.SplitterDistance = 145;
            this.splitContainer1.TabIndex = 52;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(390, 70);
            this.txtFax.Mask = "000-000-00-00";
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(152, 20);
            this.txtFax.TabIndex = 5;
            // 
            // txtSabitTel
            // 
            this.txtSabitTel.Location = new System.Drawing.Point(390, 48);
            this.txtSabitTel.Mask = "000-000-00-00";
            this.txtSabitTel.Name = "txtSabitTel";
            this.txtSabitTel.Size = new System.Drawing.Size(152, 20);
            this.txtSabitTel.TabIndex = 4;
            // 
            // txtCepTel
            // 
            this.txtCepTel.Location = new System.Drawing.Point(390, 27);
            this.txtCepTel.Mask = "000-000-00-00";
            this.txtCepTel.Name = "txtCepTel";
            this.txtCepTel.Size = new System.Drawing.Size(152, 20);
            this.txtCepTel.TabIndex = 3;
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
            this.ad_soyad.FillWeight = 177.665F;
            this.ad_soyad.HeaderText = "FİRMA ADI";
            this.ad_soyad.Name = "ad_soyad";
            this.ad_soyad.ReadOnly = true;
            // 
            // cep_tel
            // 
            this.cep_tel.DataPropertyName = "cep_tel";
            this.cep_tel.FillWeight = 87.05584F;
            this.cep_tel.HeaderText = "CEP TEL";
            this.cep_tel.Name = "cep_tel";
            this.cep_tel.ReadOnly = true;
            // 
            // sabit_tel
            // 
            this.sabit_tel.DataPropertyName = "sabit_tel";
            this.sabit_tel.FillWeight = 87.05584F;
            this.sabit_tel.HeaderText = "SABİT TEL";
            this.sabit_tel.Name = "sabit_tel";
            this.sabit_tel.ReadOnly = true;
            this.sabit_tel.Visible = false;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.FillWeight = 87.05584F;
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
            this.vergi_dairesi.FillWeight = 87.05584F;
            this.vergi_dairesi.HeaderText = "V.D.";
            this.vergi_dairesi.Name = "vergi_dairesi";
            this.vergi_dairesi.ReadOnly = true;
            // 
            // vergi_no
            // 
            this.vergi_no.DataPropertyName = "vergi_no";
            this.vergi_no.FillWeight = 87.05584F;
            this.vergi_no.HeaderText = "VERGİ NO";
            this.vergi_no.Name = "vergi_no";
            this.vergi_no.ReadOnly = true;
            // 
            // firma_unvani
            // 
            this.firma_unvani.DataPropertyName = "firma_unvani";
            this.firma_unvani.FillWeight = 87.05584F;
            this.firma_unvani.HeaderText = "ÜNVAN";
            this.firma_unvani.Name = "firma_unvani";
            this.firma_unvani.ReadOnly = true;
            // 
            // frmFirmaYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 410);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFirmaYonetimi";
            this.Text = "FİRMA YÖNETİMİ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUrunYonetimi_FormClosed);
            this.Load += new System.EventHandler(this.frmFirmaYonetimi_Load);
            this.menuSag.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epHataDedektoru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusteriler)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip menuSag;
        private System.Windows.Forms.ToolStripMenuItem menuSecilenKaydiSifirlaToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider epHataDedektoru;
        private System.Windows.Forms.DataGridView dgwMusteriler;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFax_old;
        private System.Windows.Forms.TextBox txtSabitTel_old;
        private System.Windows.Forms.TextBox txtCepTel_old;
        private System.Windows.Forms.Label lblArama;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblSabitTel;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCepTel;
        private System.Windows.Forms.TextBox txtFirmaUnvani;
        private System.Windows.Forms.TextBox txtVergiNo;
        private System.Windows.Forms.TextBox txtVergiDairesi;
        private System.Windows.Forms.TextBox txtWebSitesi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnFirmaYonetimi_ExceleAktar;
        private System.Windows.Forms.MaskedTextBox txtCepTel;
        private System.Windows.Forms.MaskedTextBox txtSabitTel;
        private System.Windows.Forms.MaskedTextBox txtFax;
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