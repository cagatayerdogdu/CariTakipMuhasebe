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
    public partial class frmDovizKurlari : Form
    {
        double DoubleParseBag = 0; int IntParseBag = 0;
        DAL budak; Fonksiyonlar Tornavida;
        public int uye_id;
        string yetki_duzeyi;
        string DovizTip;
        public frmDovizKurlari(int _uye_id, string _yetki_duzeyi)
        {
            InitializeComponent();
            uye_id = _uye_id;
            yetki_duzeyi = _yetki_duzeyi;
        }

        private void frmDovizKurlari_Load(object sender, EventArgs e)
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

            //DataTable TabloDovizKurlari = budak.Sorgu_DataTable("SELECT (SUBSTR(tarih, 7, 2) || '/' || SUBSTR(tarih, 5, 2) || '/' || SUBSTR(tarih, 1, 4) || ' ' || SUBSTR(tarih, 9, 2) || ':' || SUBSTR(tarih, 11, 2)) AS tarih, usd, eur, gbp FROM doviz_kurlari ORDER BY tarih desc LIMIT 1");

            DataTable TabloDovizKurlari = budak.Sorgu_DataTable("SELECT top 1 tarih, usd, eur, gbp FROM fd_doviz_kurlari where islemTipi= 'Satış' and Statu = 'A' ORDER BY tarih desc");

            if (TabloDovizKurlari.Rows.Count > 0)
            {
                lblTarihGuncelleme.Text = TabloDovizKurlari.Rows[0]["tarih"].ToString();
                txtDolar.Text = TabloDovizKurlari.Rows[0]["usd"].ToString();
                txtEuro.Text = TabloDovizKurlari.Rows[0]["eur"].ToString();
                txtPound.Text = TabloDovizKurlari.Rows[0]["gbp"].ToString();
            }

            //DataTable DovizHareketler = budak.Sorgu_DataTable(@"select (SUBSTR(tarih, 7, 2) || '/' || SUBSTR(tarih, 5, 2) || '/' || SUBSTR(tarih, 1, 4) || ' ' || SUBSTR(tarih, 9, 2) || ':' || SUBSTR(tarih, 11, 2)) AS tarih, usd, eur, islemTipi from doviz_kurlari ORDER BY tarih desc");

            DataTable DovizHareketler = budak.Sorgu_DataTable("SELECT tarih, usd, eur, islemTipi FROM fd_doviz_kurlari where Statu = 'A' ORDER BY tarih desc");
            dgwDovizler.DataSource = DovizHareketler;
            //listeFormatla();
        }

        private void listeFormatla()
        {
           // string SatirTip = "";
            string SatirIslem = ""; 
            //for (int i = 0; i < dgwStoklar.Rows.Count; i++)
            foreach (DataGridViewRow row in dgwDovizler.Rows)
            {
                //SatirTip = row.Cells[2].Value.ToString();
                SatirIslem = row.Cells[3].Value.ToString();
                //row.DefaultCellStyle.ForeColor = Color.Black;
                //if (SatirTip == "main")
                //{
                    switch (SatirIslem)
                    {
                        case "Alış":
                            row.DefaultCellStyle.BackColor = Color.DarkSalmon;
                            break;
                        case "Satış":
                            row.DefaultCellStyle.BackColor = Color.DarkSeaGreen;
                            break;
                        case "Para Alındı":
                            row.DefaultCellStyle.BackColor = Color.DarkKhaki;
                            break;
                        case "Para Verildi":
                            row.DefaultCellStyle.BackColor = Color.Plum;
                            break;
                    }

                    //row.Cells[8].Value = Tornavida.FiyatFormatla(SatirToplamFiyat, "sistem");
                    //row.Cells[10].Value = Tornavida.FiyatFormatla(SatirOdemeKalan, "sistem");
                //}
                //else if (SatirTip == "baslik")
                //{
                //    row.DefaultCellStyle.ForeColor = Color.White;
                //    for (int efes = 3; efes <= 7; efes++)
                //    {
                //        row.Cells[efes].Style.ForeColor = Color.Black;
                //        row.Cells[efes].Style.BackColor = Color.Silver;
                //    }
                //}
                //else if (SatirTip == "detay")
                //{
                //    row.DefaultCellStyle.ForeColor = Color.White;
                //    for (int efes = 3; efes <= 7; efes++)
                //    {
                //        row.Cells[efes].Style.ForeColor = Color.Black;
                //        row.Cells[efes].Style.BackColor = Color.Gainsboro;
                //    }
                //}
            }
            dgwDovizler.ClearSelection();
        }

        private void btnInternettenAl_Click(object sender, EventArgs e)
        {
            try
            {
                string today = "http://www.tcmb.gov.tr/kurlar/today.xml";
                var xmlDoc = new XmlDocument();
                xmlDoc.Load(today);
                lblDolarAlis.Text = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
                lblEuroAlis.Text = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
                lblPoundAlis.Text = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteBuying").InnerXml;
                lblDolarSatis.Text = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
                lblEuroSatis.Text = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
                lblPoundSatis.Text = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerXml;

                gbInternet.Visible = true;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata meydana geldi: " + hata.ToString());
            }

        }

        private void btnAlisKaydet_Click(object sender, EventArgs e)
        {
            txtDolar.Text = lblDolarAlis.Text;
            txtEuro.Text = lblEuroAlis.Text;
            txtPound.Text = lblPoundAlis.Text;
            DovizTip = "Alış";
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            txtDolar.Text = lblDolarSatis.Text;
            txtEuro.Text = lblEuroSatis.Text;
            txtPound.Text = lblPoundSatis.Text;
            DovizTip = "Satış";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string SatisTarih = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            DateTime SatisTarih_Date = Tornavida.TarihToDateTime(SatisTarih);
            string Dolar = Tornavida.FiyatFormatla(txtDolar.Text, "veritabanı", "0000");
            string Euro = Tornavida.FiyatFormatla(txtEuro.Text, "veritabanı", "0000");
            string Pound = Tornavida.FiyatFormatla(txtPound.Text, "veritabanı", "0000");
            string TarihKontrol = DateTime.Now.ToString("yyyy-MM-dd");
            DateTime TarihKontrol_Date = Tornavida.TarihToDateTime(TarihKontrol);

            string AyniGunDoviz = budak.Sorgu_Scalar(@"select top 1 kur_id from fd_doviz_kurlari where islemTipi = '" + DovizTip+"' and cast(tarih as date) = '" + TarihKontrol_Date.ToShortDateString() + "'");

            if (AyniGunDoviz == "")
            {
                int Etki = budak.Sorgu_Calistir("INSERT INTO fd_doviz_kurlari(tarih, usd, eur, gbp, islemTipi) VALUES(@tarih, @usd, @eur, @gbp, @DovizTip)", SatisTarih_Date.ToString(), Dolar, Euro, Pound, DovizTip);
                if (Etki > 0)
                {
                    frmAnasayfa.tssDovizDolar.Text = string.Format("$ : {0}", Dolar);
                    frmAnasayfa.tssDovizEuro.Text = string.Format("€ : {0}", Euro);
                    frmAnasayfa.tssDovizPound.Text = string.Format("£ : {0}", Pound);

                    //this.Close();
                    Close();
                }
                else
                {
                    MessageBox.Show("Döviz kurları güncellenemedi.");
                }
            }             
            else
            {
                MessageBox.Show("Aynı gün içinde birden fazla ''"+ DovizTip + "'' döviz kaydı yapılamaz.");
            }

        }

        public frmAnasayfa frmAnasayfa;
        public string EkranNo = "";
        private void frmUrunYonetimi_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAnasayfa.DiziFormlar.Remove(this);
            frmAnasayfa.DiziFormTag.Remove("doviz_kurlari");
            frmAnasayfa.TabCikar("doviz_kurlari");
        }
        
    }
}
