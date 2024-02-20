using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
//using DAL;
using System.Xml;
using System.Text.RegularExpressions;

namespace StokTakip
{
    public partial class frmAnasayfa : Form
    {
        public int uye_id;
        string yetki_duzeyi;
        public frmAnasayfa(int _uye_id, string _yetki_duzeyi)
        {
            InitializeComponent();
            uye_id = _uye_id;
            yetki_duzeyi = _yetki_duzeyi;
        }

        private void btnUrunYonetimi_Click(object sender, EventArgs e)
        {
            frmUrunYonetimi frm_urunYonetimi = new frmUrunYonetimi(uye_id, yetki_duzeyi);
            frm_urunYonetimi.MdiParent = this;

            if (DiziFormTag.Contains(((ToolStripMenuItem)sender).Tag.ToString()))
            {
                TabSec(((ToolStripMenuItem)sender).Tag.ToString());
            }
            else
            {
                EkranSayisi++;
                TabPage tp = new TabPage();
                tp.Parent = tcMain;
                tp.Text = frm_urunYonetimi.Text;
                tp.Tag = ((ToolStripMenuItem)sender).Tag.ToString();
                tp.Show();

                frm_urunYonetimi.Show();
                frm_urunYonetimi.EkranNo = EkranSayisi.ToString();
                frm_urunYonetimi.frmAnasayfa = this;
                tcMain.SelectedTab = tp;
                DiziFormlar.Add(frm_urunYonetimi);
                DiziFormNo.Add(EkranSayisi.ToString());
                DiziFormTag.Add(((ToolStripMenuItem)sender).Tag.ToString());
            }
        }

        private void btnStokYonetimi_Click(object sender, EventArgs e)
        {
            frmStokYonetimi frm_stokYonetimi = new frmStokYonetimi(uye_id, yetki_duzeyi, "alis");
            frm_stokYonetimi.MdiParent = this;

            if (DiziFormTag.Contains(((ToolStripMenuItem)sender).Tag.ToString()))
            {
                TabSec(((ToolStripMenuItem)sender).Tag.ToString());
            }
            else
            {
                EkranSayisi++;
                TabPage tp = new TabPage();
                tp.Parent = tcMain;
                tp.Text = frm_stokYonetimi.Text;
                tp.Tag = ((ToolStripMenuItem)sender).Tag.ToString();
                tp.Show();

                frm_stokYonetimi.Show();
                frm_stokYonetimi.EkranNo = EkranSayisi.ToString();
                frm_stokYonetimi.frmAnasayfa = this;
                tcMain.SelectedTab = tp;
                DiziFormlar.Add(frm_stokYonetimi);
                DiziFormNo.Add(EkranSayisi.ToString());
                DiziFormTag.Add(((ToolStripMenuItem)sender).Tag.ToString());
            }
        }

        private void btnMusteriYonetimi_Click(object sender, EventArgs e)
        {
            frmMusteriYonetimi frm_musteriYonetimi = new frmMusteriYonetimi(uye_id, yetki_duzeyi);
            frm_musteriYonetimi.MdiParent = this;

            if (DiziFormTag.Contains(((ToolStripMenuItem)sender).Tag.ToString()))
            {
                TabSec(((ToolStripMenuItem)sender).Tag.ToString());
            }
            else
            {
                EkranSayisi++;
                TabPage tp = new TabPage();
                tp.Parent = tcMain;
                tp.Text = frm_musteriYonetimi.Text;
                tp.Tag = ((ToolStripMenuItem)sender).Tag.ToString();
                tp.Show();

                frm_musteriYonetimi.Show();
                frm_musteriYonetimi.EkranNo = EkranSayisi.ToString();
                frm_musteriYonetimi.frmAnasayfa = this;
                tcMain.SelectedTab = tp;
                DiziFormlar.Add(frm_musteriYonetimi);
                DiziFormNo.Add(EkranSayisi.ToString());
                DiziFormTag.Add(((ToolStripMenuItem)sender).Tag.ToString());
            }
        }

        private void btnSatisYonetimi_Click(object sender, EventArgs e)
        {
            frmStokYonetimi frm_stokYonetimi = new frmStokYonetimi(uye_id, yetki_duzeyi, "satis");
            frm_stokYonetimi.MdiParent = this;

            if (DiziFormTag.Contains(((ToolStripMenuItem)sender).Tag.ToString()))
            {
                TabSec(((ToolStripMenuItem)sender).Tag.ToString());
            }
            else
            {
                EkranSayisi++;
                TabPage tp = new TabPage();
                tp.Parent = tcMain;
                tp.Text = "SATIŞ";
                tp.Tag = ((ToolStripMenuItem)sender).Tag.ToString();
                tp.Show();

                frm_stokYonetimi.Show();
                frm_stokYonetimi.EkranNo = EkranSayisi.ToString();
                frm_stokYonetimi.frmAnasayfa = this;
                tcMain.SelectedTab = tp;
                DiziFormlar.Add(frm_stokYonetimi);
                DiziFormNo.Add(EkranSayisi.ToString());
                DiziFormTag.Add(((ToolStripMenuItem)sender).Tag.ToString());
            }
        }

        private void btnFirmaYonetimi_Click(object sender, EventArgs e)
        {
            frmFirmaYonetimi frm_firmaYonetimi = new frmFirmaYonetimi(uye_id, yetki_duzeyi);
            frm_firmaYonetimi.MdiParent = this;

            if (DiziFormTag.Contains(((ToolStripMenuItem)sender).Tag.ToString()))
            {
                TabSec(((ToolStripMenuItem)sender).Tag.ToString());
            }
            else
            {
                EkranSayisi++;
                TabPage tp = new TabPage();
                tp.Parent = tcMain;
                tp.Text = frm_firmaYonetimi.Text;
                tp.Tag = ((ToolStripMenuItem)sender).Tag.ToString();
                tp.Show();

                frm_firmaYonetimi.Show();
                frm_firmaYonetimi.EkranNo = EkranSayisi.ToString();
                frm_firmaYonetimi.frmAnasayfa = this;
                tcMain.SelectedTab = tp;
                DiziFormlar.Add(frm_firmaYonetimi);
                DiziFormNo.Add(EkranSayisi.ToString());
                DiziFormTag.Add(((ToolStripMenuItem)sender).Tag.ToString());
            }
        }

        DAL budak; Fonksiyonlar Tornavida;
        private void frmAnasayfa_Load(object sender, EventArgs e)
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

            tssDovizDolar.Text = "";
            tssDovizEuro.Text = "";
            tssDovizPound.Text = "";
            try
            {
                //DataTable TabloDovizKurlari = budak.Sorgu_DataTable("SELECT (SUBSTR(tarih, 7, 2) || '/' || SUBSTR(tarih, 5, 2) || '/' || SUBSTR(tarih, 1, 4) || ' ' || SUBSTR(tarih, 9, 2) || ':' || SUBSTR(tarih, 11, 2)) AS tarih, usd, eur, gbp FROM fd_doviz_kurlari ORDER BY tarih desc LIMIT 1");

                DataTable TabloDovizKurlari = budak.Sorgu_DataTable("SELECT top 1 tarih, usd, eur, gbp FROM fd_doviz_kurlari where islemTipi= 'Satış' and Statu = 'A' ORDER BY tarih desc");

                if (TabloDovizKurlari.Rows.Count > 0)
                {
                    tssDovizDolar.Text = string.Format("$ : {0}", TabloDovizKurlari.Rows[0]["usd"].ToString());
                    tssDovizEuro.Text = string.Format("€ : {0}", TabloDovizKurlari.Rows[0]["eur"].ToString());
                    tssDovizPound.Text = string.Format("£ : {0}", TabloDovizKurlari.Rows[0]["gbp"].ToString());
                }
                else
                {
                    string today = "http://www.tcmb.gov.tr/kurlar/today.xml";
                    var xmlDoc = new XmlDocument();
                    xmlDoc.Load(today);
                    string USD = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
                    string EURO = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
                    string POUND = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteBuying").InnerXml;
                    tssDovizDolar.Text = string.Format("$ : {0}", USD);
                    tssDovizEuro.Text = string.Format("€ : {0}", EURO);
                    tssDovizPound.Text = string.Format("£ : {0}", POUND);
                    USD = Tornavida.FiyatFormatla(USD, "veritabanı", "0000");
                    EURO = Tornavida.FiyatFormatla(EURO, "veritabanı", "0000");
                    POUND = Tornavida.FiyatFormatla(POUND, "veritabanı", "0000");
                    string SatisTarih = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                    DateTime SatisTarih_Date = Tornavida.TarihToDateTime(SatisTarih); // [CE_16.05.2020 23:41] Web DB sebebiyle
                    string IslemTipi = "Otomatik";
                    budak.Sorgu_Calistir("INSERT INTO fd_doviz_kurlari(tarih, usd, eur, gbp, islemTipi) VALUES(@tarih, @usd, @eur, @gbp, @islemTipi)", SatisTarih_Date.ToString(), USD, EURO, POUND, IslemTipi);
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
            }
        }

        private void tsmiMuhasebeHareketleri_Click(object sender, EventArgs e)
        {
            frmMuhasebeHareketleri frm_muhasebeHareketleri = new frmMuhasebeHareketleri(uye_id, yetki_duzeyi);
            frm_muhasebeHareketleri.MdiParent = this;

            if (DiziFormTag.Contains(((ToolStripMenuItem)sender).Tag.ToString()))
            {
                TabSec(((ToolStripMenuItem)sender).Tag.ToString());
            }
            else
            {
                EkranSayisi++;
                TabPage tp = new TabPage();
                tp.Parent = tcMain;
                tp.Text = frm_muhasebeHareketleri.Text;
                tp.Tag = ((ToolStripMenuItem)sender).Tag.ToString();
                tp.Show();

                frm_muhasebeHareketleri.Show();
                frm_muhasebeHareketleri.EkranNo = EkranSayisi.ToString();
                frm_muhasebeHareketleri.frmAnasayfa = this;
                tcMain.SelectedTab = tp;
                DiziFormlar.Add(frm_muhasebeHareketleri);
                DiziFormNo.Add(EkranSayisi.ToString());
                DiziFormTag.Add(((ToolStripMenuItem)sender).Tag.ToString());
            }
        }

        private void frmAnasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            var Cevap = MessageBox.Show("Programı kapatmak istediğinizden emin misiniz?", "Program kapatılacak", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            e.Cancel = (Cevap == DialogResult.No);
        }

        private void frmAnasayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                System.Environment.Exit(1);
            }
        }

        private void tsmiParaAl_Click(object sender, EventArgs e)
        {
            frmParaAlVer frm_paraAlVer = new frmParaAlVer(uye_id, yetki_duzeyi, "para_alis");
            frm_paraAlVer.MdiParent = this;

            if (DiziFormTag.Contains(((ToolStripMenuItem)sender).Tag.ToString()))
            {
                TabSec(((ToolStripMenuItem)sender).Tag.ToString());
            }
            else
            {
                EkranSayisi++;
                TabPage tp = new TabPage();
                tp.Parent = tcMain;
                tp.Text = "PARA AL";
                tp.Tag = ((ToolStripMenuItem)sender).Tag.ToString();
                tp.Show();

                frm_paraAlVer.Show();
                frm_paraAlVer.EkranNo = EkranSayisi.ToString();
                frm_paraAlVer.frmAnasayfa = this;
                tcMain.SelectedTab = tp;
                DiziFormlar.Add(frm_paraAlVer);
                DiziFormNo.Add(EkranSayisi.ToString());
                DiziFormTag.Add(((ToolStripMenuItem)sender).Tag.ToString());
            }
        }

        private void tsmiParaVer_Click(object sender, EventArgs e)
        {
            frmParaAlVer frm_paraAlVer = new frmParaAlVer(uye_id, yetki_duzeyi, "para_veris");
            frm_paraAlVer.MdiParent = this;

            if (DiziFormTag.Contains(((ToolStripMenuItem)sender).Tag.ToString()))
            {
                TabSec(((ToolStripMenuItem)sender).Tag.ToString());
            }
            else
            {
                EkranSayisi++;
                TabPage tp = new TabPage();
                tp.Parent = tcMain;
                tp.Text = "PARA VER";
                tp.Tag = ((ToolStripMenuItem)sender).Tag.ToString();
                tp.Show();

                frm_paraAlVer.Show();
                frm_paraAlVer.EkranNo = EkranSayisi.ToString();
                frm_paraAlVer.frmAnasayfa = this;
                tcMain.SelectedTab = tp;
                DiziFormlar.Add(frm_paraAlVer);
                DiziFormNo.Add(EkranSayisi.ToString());
                DiziFormTag.Add(((ToolStripMenuItem)sender).Tag.ToString());
            }
        }

        public int EkranSayisi = -1;
        public List<Form> DiziFormlar = new List<Form>();
        public List<string> DiziFormNo = new List<string>();
        public List<string> DiziFormTag = new List<string>();
        private void tcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Sayac = -1;
            if (tcMain.TabPages.Count == 0) return;

            string seciliNo = tcMain.SelectedTab.Tag.ToString();
            foreach (Form frm in DiziFormlar)
            {
                Sayac++;
                if (seciliNo == DiziFormTag[Sayac])
                {
                    frm.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    frm.WindowState = FormWindowState.Minimized;
                }
            }
        }

        public void TabCikar(string TabTag)
        {
            foreach (TabPage tabPag in tcMain.TabPages)
            {
                if (tabPag.Tag.ToString() == TabTag)
                {
                    tcMain.TabPages.Remove(tabPag);
                }
            }
            SonTabSec();
        }

        public void TabSec(string TabTag)
        {
            foreach (TabPage tabPag in tcMain.TabPages)
            {
                if (tabPag.Tag.ToString() == TabTag)
                {
                    tcMain.SelectedTab = tabPag;
                    break;
                }
            }
        }

        public void SonTabSec()
        {
            int TabSayisi = tcMain.TabCount;
            int Sayac = 0;
            foreach (TabPage tabPag in tcMain.TabPages)
            {
                Sayac++;
                if (Sayac == TabSayisi)
                {
                    tcMain.SelectedTab = tabPag;
                    break;
                }
            }
        }

        public void FormSec(string formNo)
        {
            foreach (TabPage tabPag in tcMain.TabPages)
            {
                if (tabPag.Tag.ToString() == formNo)
                {
                    tcMain.SelectedTab = tabPag;
                }
            }
        }

        private void tsmiDovizKurlari_Click(object sender, EventArgs e)
        {
            if (DiziFormTag.Contains(((ToolStripMenuItem)sender).Tag.ToString()))
            {
                TabSec(((ToolStripMenuItem)sender).Tag.ToString());
            }
            else
            {
                frmDovizKurlari frm_dovizKurlari = new frmDovizKurlari(uye_id, yetki_duzeyi);
                frm_dovizKurlari.MdiParent = this;

                EkranSayisi++;
                TabPage tp = new TabPage();
                tp.Parent = tcMain;
                tp.Text = frm_dovizKurlari.Text;
                tp.Tag = ((ToolStripMenuItem)sender).Tag.ToString();
                tp.Show();

                frm_dovizKurlari.Show();
                frm_dovizKurlari.EkranNo = EkranSayisi.ToString();
                frm_dovizKurlari.frmAnasayfa = this;
                tcMain.SelectedTab = tp;
                DiziFormlar.Add(frm_dovizKurlari);
                DiziFormNo.Add(EkranSayisi.ToString());
                DiziFormTag.Add(((ToolStripMenuItem)sender).Tag.ToString());
            }
        }

        private void tsmiTestUrunImport_Click(object sender, EventArgs e)
        {
            frmUrunImport formUrunImport = new frmUrunImport();
            formUrunImport.Show();
        }

        private void tsmiSifreDegistir_Click(object sender, EventArgs e)
        {
            frmSifreDegistir frm_sifreDegistir = new frmSifreDegistir(uye_id, yetki_duzeyi);
            frm_sifreDegistir.MdiParent = this;

            if(DiziFormTag.Contains(((ToolStripMenuItem)sender).Tag.ToString())){
                TabSec(((ToolStripMenuItem)sender).Tag.ToString());
            }
            else{
                EkranSayisi++;
                TabPage tp = new TabPage();
                tp.Parent = tcMain;
                tp.Text = frm_sifreDegistir.Text;
                tp.Tag = ((ToolStripMenuItem)sender).Tag.ToString();
                tp.Show();

                frm_sifreDegistir.Show();
                frm_sifreDegistir.EkranNo = EkranSayisi.ToString();
                frm_sifreDegistir.frmAnasayfa = this;
                tcMain.SelectedTab = tp;
                DiziFormlar.Add(frm_sifreDegistir);
                DiziFormNo.Add(EkranSayisi.ToString());
                DiziFormTag.Add(((ToolStripMenuItem)sender).Tag.ToString());
            }
        }

        private void tsmiStokListe_Click(object sender, EventArgs e)
        {
            frmStokListe frm_StokListe = new frmStokListe(uye_id, yetki_duzeyi);
            frm_StokListe.MdiParent = this;

            if (DiziFormTag.Contains(((ToolStripMenuItem)sender).Tag.ToString()))
            {
                TabSec(((ToolStripMenuItem)sender).Tag.ToString());
            }
            else
            {
                EkranSayisi++;
                TabPage tp = new TabPage();
                tp.Parent = tcMain;
                tp.Text = frm_StokListe.Text;
                tp.Tag = ((ToolStripMenuItem)sender).Tag.ToString();
                tp.Show();

                frm_StokListe.Show();
                frm_StokListe.EkranNo = EkranSayisi.ToString();
                frm_StokListe.frmAnasayfa = this;
                tcMain.SelectedTab = tp;
                DiziFormlar.Add(frm_StokListe);
                DiziFormNo.Add(EkranSayisi.ToString());
                DiziFormTag.Add(((ToolStripMenuItem)sender).Tag.ToString());
            }
        }

        private void tsmiFaturaYazdir_Click(object sender, EventArgs e)
        {
            if (DiziFormTag.Contains(((ToolStripMenuItem)sender).Tag.ToString()))
            {
                TabSec(((ToolStripMenuItem)sender).Tag.ToString());
            }
            else
            {
                frmFaturaYazdirma frm_FaturaYazdirma = new frmFaturaYazdirma(uye_id, yetki_duzeyi, "", "");
                frm_FaturaYazdirma.MdiParent = this;

                EkranSayisi++;
                TabPage tp = new TabPage();
                tp.Parent = tcMain;
                tp.Text = frm_FaturaYazdirma.Text;
                tp.Tag = ((ToolStripMenuItem)sender).Tag.ToString();
                tp.Show();

                frm_FaturaYazdirma.Show();
                frm_FaturaYazdirma.EkranNo = EkranSayisi.ToString();
                frm_FaturaYazdirma.frmAnasayfa = this;
                tcMain.SelectedTab = tp;
                DiziFormlar.Add(frm_FaturaYazdirma);
                DiziFormNo.Add(EkranSayisi.ToString());
                DiziFormTag.Add(((ToolStripMenuItem)sender).Tag.ToString());
            }

        }

        private void tsmiSatisRaporu_Click(object sender, EventArgs e)
        {
            if (DiziFormTag.Contains(((ToolStripMenuItem)sender).Tag.ToString()))
            {
                TabSec(((ToolStripMenuItem)sender).Tag.ToString());
            }
            else
            {
                frmSatisRaporu frm_SatisRaporu = new frmSatisRaporu(uye_id, yetki_duzeyi);
                frm_SatisRaporu.MdiParent = this;

                EkranSayisi++;
                TabPage tp = new TabPage();
                tp.Parent = tcMain;
                tp.Text = frm_SatisRaporu.Text;
                tp.Tag = ((ToolStripMenuItem)sender).Tag.ToString();
                tp.Show();

                frm_SatisRaporu.Show();
                frm_SatisRaporu.EkranNo = EkranSayisi.ToString();
                frm_SatisRaporu.frmAnasayfa = this;
                tcMain.SelectedTab = tp;
                DiziFormlar.Add(frm_SatisRaporu);
                DiziFormNo.Add(EkranSayisi.ToString());
                DiziFormTag.Add(((ToolStripMenuItem)sender).Tag.ToString());
            }

        }
    }
}
