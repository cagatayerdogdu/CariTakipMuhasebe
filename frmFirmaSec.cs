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
    public partial class frmFirmaSec : Form
    {
        double DoubleParseBag = 0; int IntParseBag = 0;
        DAL budak; Fonksiyonlar Tornavida;
        public int uye_id;
        string yetki_duzeyi;
        frmStokYonetimi formAlis = null;
        frmMuhasebeHareketleri formMuhasebeHareketleri = null;
        frmUrunHareketleri formUrunHareketleri = null;
        frmParaAlVer formParaAlVer = null;
        string musteri_firma;
        public frmFirmaSec(int _uye_id, string _yetki_duzeyi, string _musteri_firma, frmStokYonetimi _formAlis)
        {
            InitializeComponent();
            uye_id = _uye_id;
            yetki_duzeyi = _yetki_duzeyi;
            formAlis = _formAlis;
            musteri_firma = _musteri_firma;
        }
        public frmFirmaSec(int _uye_id, string _yetki_duzeyi, string _musteri_firma, frmMuhasebeHareketleri _formMuhasebeHareketleri)
        {
            InitializeComponent();
            uye_id = _uye_id;
            yetki_duzeyi = _yetki_duzeyi;
            formMuhasebeHareketleri = _formMuhasebeHareketleri;
            musteri_firma = _musteri_firma;
        }
        public frmFirmaSec(int _uye_id, string _yetki_duzeyi, string _musteri_firma, frmUrunHareketleri _formUrunHareketleri)
        {
            InitializeComponent();
            uye_id = _uye_id;
            yetki_duzeyi = _yetki_duzeyi;
            formUrunHareketleri = _formUrunHareketleri;
            musteri_firma = _musteri_firma;
        }
        public frmFirmaSec(int _uye_id, string _yetki_duzeyi, string _musteri_firma, frmParaAlVer _formParaAlVer)
        {
            InitializeComponent();
            uye_id = _uye_id;
            yetki_duzeyi = _yetki_duzeyi;
            formParaAlVer = _formParaAlVer;
            musteri_firma = _musteri_firma;
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            string Arama = txtArama.Text.Trim();
            if (Arama == "")
            {
                firma_listele();
            }
            else
            {
                dgwFirmalar.DataSource = budak.Sorgu_DataTable("SELECT m.musteri_id, m.ad_soyad, m.cep_tel, m.sabit_tel, m.fax, m.email, m.website, m.adres, m.firma_unvani, m.vergi_dairesi, m.vergi_no FROM fd_musteriler AS m WHERE Statu = 'A' and m.tip=@tip AND (m.ad_soyad LIKE @ad_soyad OR m.tc_kimlik LIKE @tc_kimlik OR m.cep_tel LIKE @cep_tel OR m.email LIKE @email) ORDER BY m.ad_soyad", musteri_firma, "%" + Arama + "%", "%" + Arama + "%", "%" + Arama + "%", "%" + Arama + "%");
            }
        }

        private void firma_listele()
        {
            dgwFirmalar.DataSource = budak.Sorgu_DataTable("SELECT m.musteri_id, m.ad_soyad, m.cep_tel, m.sabit_tel, m.fax, m.email, m.website, m.adres, m.firma_unvani, m.vergi_dairesi, m.vergi_no FROM fd_musteriler AS m WHERE m.tip=@tip and Statu = 'A' ORDER BY m.ad_soyad", musteri_firma);
        }

        private void dgwFirmalar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string firma_id = dgwFirmalar.CurrentRow.Cells[0].Value.ToString();
            string firma_adi = dgwFirmalar.CurrentRow.Cells[1].Value.ToString();
            if (formAlis != null)
            {
                this.Close();
                formAlis.ListedenFirmaSec(firma_id, firma_adi);
                frmAnasayfa.FormSec(formAlis.EkranNo);
            }
            else if (formMuhasebeHareketleri != null)
            {
                this.Close();
                formMuhasebeHareketleri.ListedenFirmaSec(firma_id, firma_adi);
                frmAnasayfa.FormSec(formMuhasebeHareketleri.EkranNo);
            }
            else if (formUrunHareketleri != null)
            {
                this.Close();
                formUrunHareketleri.ListedenFirmaSec(firma_id, firma_adi);
                frmAnasayfa.FormSec(formUrunHareketleri.EkranNo);
            }
            else if (formParaAlVer != null)
            {
                this.Close();
                formParaAlVer.ListedenFirmaSec(firma_id, firma_adi);
                frmAnasayfa.FormSec(formParaAlVer.EkranNo);
            }
        }

        private void frmFirmaSec_Load(object sender, EventArgs e)
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

            if (musteri_firma == "musteri")
            {
                this.Text = "MÜŞTERİ SEÇ";
                lblFirma.Text = "MÜŞTERİ ARA:";
            }

            txtArama_TextChanged(null, null);
        }

        public frmAnasayfa frmAnasayfa;
        public string EkranNo = "";
        private void frmUrunYonetimi_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAnasayfa.DiziFormlar.Remove(this);
            frmAnasayfa.DiziFormTag.Remove("firma_sec");
            frmAnasayfa.TabCikar("firma_sec");
        }
    }
}
