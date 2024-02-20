namespace StokTakip
{
    partial class frmFaturaYazdirma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFaturaYazdirma));
            this.label26 = new System.Windows.Forms.Label();
            this.btnFaturaGetir = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.txtFaturaNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label26.Location = new System.Drawing.Point(23, 37);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(102, 13);
            this.label26.TabIndex = 5;
            this.label26.Text = "Fatura No Giriniz";
            // 
            // btnFaturaGetir
            // 
            this.btnFaturaGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFaturaGetir.Location = new System.Drawing.Point(306, 28);
            this.btnFaturaGetir.Name = "btnFaturaGetir";
            this.btnFaturaGetir.Size = new System.Drawing.Size(154, 31);
            this.btnFaturaGetir.TabIndex = 2;
            this.btnFaturaGetir.Text = "FATURA GETİR";
            this.btnFaturaGetir.UseVisualStyleBackColor = true;
            this.btnFaturaGetir.Click += new System.EventHandler(this.btnFaturaGetir_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(26, 80);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowCloseButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(716, 532);
            this.crystalReportViewer1.TabIndex = 7;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // txtFaturaNo
            // 
            this.txtFaturaNo.Location = new System.Drawing.Point(135, 34);
            this.txtFaturaNo.Name = "txtFaturaNo";
            this.txtFaturaNo.Size = new System.Drawing.Size(106, 20);
            this.txtFaturaNo.TabIndex = 1;
            this.txtFaturaNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFaturaNo_KeyPress);
            // 
            // frmFaturaYazdirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 624);
            this.Controls.Add(this.txtFaturaNo);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.btnFaturaGetir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFaturaYazdirma";
            this.Text = "FATURA YAZDIRMA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmFaturaYazdirma_FormClosed);
            this.Load += new System.EventHandler(this.frmFaturaYazdirma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btnFaturaGetir;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.TextBox txtFaturaNo;
    }
}