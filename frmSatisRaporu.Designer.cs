namespace StokTakip
{
    partial class frmSatisRaporu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatisRaporu));
            this.dtSatisRaporu_1 = new System.Windows.Forms.DateTimePicker();
            this.dtSatisRaporu_2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRaporCalistir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgwSatisRaporu = new System.Windows.Forms.DataGridView();
            this.ad_soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satis_tutari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSatisRaporu)).BeginInit();
            this.SuspendLayout();
            // 
            // dtSatisRaporu_1
            // 
            this.dtSatisRaporu_1.Location = new System.Drawing.Point(12, 67);
            this.dtSatisRaporu_1.Name = "dtSatisRaporu_1";
            this.dtSatisRaporu_1.Size = new System.Drawing.Size(200, 20);
            this.dtSatisRaporu_1.TabIndex = 0;
            // 
            // dtSatisRaporu_2
            // 
            this.dtSatisRaporu_2.Location = new System.Drawing.Point(218, 67);
            this.dtSatisRaporu_2.Name = "dtSatisRaporu_2";
            this.dtSatisRaporu_2.Size = new System.Drawing.Size(200, 20);
            this.dtSatisRaporu_2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "TARİH BAZLI SATIŞ RAPORU";
            // 
            // btnRaporCalistir
            // 
            this.btnRaporCalistir.BackColor = System.Drawing.Color.Transparent;
            this.btnRaporCalistir.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaporCalistir.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnRaporCalistir.Location = new System.Drawing.Point(424, 67);
            this.btnRaporCalistir.Name = "btnRaporCalistir";
            this.btnRaporCalistir.Size = new System.Drawing.Size(174, 49);
            this.btnRaporCalistir.TabIndex = 25;
            this.btnRaporCalistir.Tag = "";
            this.btnRaporCalistir.Text = "ÇALIŞTIR";
            this.btnRaporCalistir.UseVisualStyleBackColor = false;
            this.btnRaporCalistir.Click += new System.EventHandler(this.btnRaporCalistir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgwSatisRaporu);
            this.panel1.Location = new System.Drawing.Point(12, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 354);
            this.panel1.TabIndex = 26;
            // 
            // dgwSatisRaporu
            // 
            this.dgwSatisRaporu.AllowUserToAddRows = false;
            this.dgwSatisRaporu.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgwSatisRaporu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwSatisRaporu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwSatisRaporu.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgwSatisRaporu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwSatisRaporu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ad_soyad,
            this.satis_tutari});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwSatisRaporu.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwSatisRaporu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwSatisRaporu.Location = new System.Drawing.Point(0, 0);
            this.dgwSatisRaporu.Name = "dgwSatisRaporu";
            this.dgwSatisRaporu.ReadOnly = true;
            this.dgwSatisRaporu.RowHeadersVisible = false;
            this.dgwSatisRaporu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwSatisRaporu.Size = new System.Drawing.Size(805, 354);
            this.dgwSatisRaporu.TabIndex = 1;
            // 
            // ad_soyad
            // 
            this.ad_soyad.DataPropertyName = "ad_soyad";
            this.ad_soyad.FillWeight = 74.31199F;
            this.ad_soyad.HeaderText = "AD SOYAD";
            this.ad_soyad.Name = "ad_soyad";
            this.ad_soyad.ReadOnly = true;
            // 
            // satis_tutari
            // 
            this.satis_tutari.DataPropertyName = "satis_tutari";
            this.satis_tutari.FillWeight = 69.64802F;
            this.satis_tutari.HeaderText = "SATIS TUTARI";
            this.satis_tutari.Name = "satis_tutari";
            this.satis_tutari.ReadOnly = true;
            // 
            // frmSatisRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 624);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRaporCalistir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtSatisRaporu_2);
            this.Controls.Add(this.dtSatisRaporu_1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSatisRaporu";
            this.Text = "Satış Raporu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSatisRaporu_FormClosed);
            this.Load += new System.EventHandler(this.frmSatisRaporu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSatisRaporu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtSatisRaporu_1;
        private System.Windows.Forms.DateTimePicker dtSatisRaporu_2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRaporCalistir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgwSatisRaporu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ad_soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn satis_tutari;
    }
}