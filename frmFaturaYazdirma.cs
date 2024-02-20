using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace StokTakip
{
    public partial class frmFaturaYazdirma : Form
    {
        DAL budak; Fonksiyonlar Tornavida;
        public int uye_id;
        string yetki_duzeyi;
        string faturano = "";
        string secili_kayit_id = "";
        //frmMuhasebeHareketleri formMuhasebeHareketleri = null;

        public frmFaturaYazdirma(int _uye_id, string _yetki_duzeyi, string _faturano, string _secili_kayit_id = "")
        {
            InitializeComponent();
            uye_id = _uye_id;
            yetki_duzeyi = _yetki_duzeyi;
            faturano = _faturano;
            secili_kayit_id = _secili_kayit_id;
        }

        private void frmFaturaYazdirma_Load(object sender, EventArgs e)
        {
            Tornavida = new Fonksiyonlar();
            try
            {
                //string baglanti_bilgisi = "Data Source=" + Application.StartupPath + "\\StokTakip.s3db";

                //Xml dosyamızı okumak için bir XmlDocument nesnesi oluşturuyoruz.
                XmlDocument xml_belgesi = new XmlDocument();
                //Xml nesnemize, bağlantı ayarlarını içeren xml dosyamızı yüklüyoruz.
                xml_belgesi.Load(@"ayarlar\baglanti.xml");
                //Bağlantı parametrelerimizi tanımlıyoruz.
                string baglanti_bilgisayar = "";
                string baglanti_veritabani = "";
                string baglanti_ek_bilgiler = "";
                //Bağlantı tag'ımızı seçiyoruz.
                XmlNodeList baglanti_taglari = xml_belgesi.SelectNodes("/Baglanti");
                //Xml dosyamızı okuyarak gerekli bilgileri değişkenlere atıyoruz.
                foreach (XmlNode baglanti_tag in baglanti_taglari)
                {
                    baglanti_bilgisayar = baglanti_tag["Kaynak_Bilgisayar"].InnerText;
                    baglanti_veritabani = baglanti_tag["Veritabani"].InnerText;
                    baglanti_ek_bilgiler = baglanti_tag["Ek_Bilgiler"].InnerText;
                }
                //Dosyadan okuduğumuz bilgiler ile veritabanı bağlantı dizemizi oluşturuyoruz.
                string baglanti_bilgisi = "Data Source=" + baglanti_bilgisayar + ";Initial Catalog=" + baglanti_veritabani + ";" + baglanti_ek_bilgiler;

                budak = new DAL(baglanti_bilgisi);
            }
            catch (Exception hata)
            {
                string problem = hata.ToString();
            }

            this.WindowState = FormWindowState.Maximized;
            // Crystal raporun sol taraftaki gereksiz grup ağacı görüntüsünü kapatıyorum.
            //crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            //Properties ten kapattım.    //ToolPanelView = none

            if (secili_kayit_id != "")
            {
                FaturaGetir();
            }

        }

        public frmAnasayfa frmAnasayfa;
        public string EkranNo = "";
        private void frmFaturaYazdirma_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmFaturaYazdirma frmFaturaYazdirma = new frmFaturaYazdirma(-1,"","","");
            frmAnasayfa.DiziFormlar.Remove(this);
            frmAnasayfa.DiziFormTag.Remove("fatura_yazdir");
            frmAnasayfa.TabCikar("fatura_yazdir");
            frmFaturaYazdirma.Close();
        }

        private void btnFaturaGetir_Click(object sender, EventArgs e)
        {
            if (txtFaturaNo.Text == "")
            {
                MessageBox.Show("Fatura No giriniz..!");
            }
            string FaturaId = budak.Sorgu_Scalar
                ("SELECT top 1 satis_id FROM Fatura_View WHERE fatura_no = '" + txtFaturaNo.Text + "'");
            if (FaturaId == "")
            {
                MessageBox.Show("Girdiğiniz Fatura No 'ya ait bir satış kaydı bulunamamıştır.");
            }
            else
            {

                DataTable DtFatura = budak.Sorgu_DataTable(@"select * from Fatura_View where fatura_no = '" + txtFaturaNo.Text + "' order by Kayit_Tarihi desc");
                CrystalReport cr_rapor = new CrystalReport();
                cr_rapor.SetDataSource(DtFatura);
                crystalReportViewer1.ReportSource = cr_rapor;
            }
        }
        public void FaturaGetir()
        {

            DataTable DtFatura = budak.Sorgu_DataTable(@"select * from Fatura_View where satis_id = '" + secili_kayit_id + "' and fatura_no = '" + faturano + "' order by Kayit_Tarihi desc");
            CrystalReport cr_rapor = new CrystalReport();
            cr_rapor.SetDataSource(DtFatura);
            crystalReportViewer1.ReportSource = cr_rapor;
        }


        #region ENTER tuşu ile giriş yapma
        private void txtFaturaNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ENTER butonuna basınca, GİRİŞ butonunun tetiklenmesi sağlanıyor.
            if (e.KeyChar == (13)) //ENTER butonunun karakter kodu 13.
            {
                btnFaturaGetir_Click(sender, e);
            }
        }

        #endregion
        
    }
}
