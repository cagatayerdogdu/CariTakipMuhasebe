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
    public partial class frmUrunSec : Form
    {
        double DoubleParseBag = 0; int IntParseBag = 0;
        DAL budak; Fonksiyonlar Tornavida;
        public int uye_id;
        string yetki_duzeyi;
        frmStokYonetimi formAlis = null;
        public frmUrunSec(int _uye_id, string _yetki_duzeyi, frmStokYonetimi _formAlis)
        {
            InitializeComponent();
            uye_id = _uye_id;
            yetki_duzeyi = _yetki_duzeyi;
            formAlis = _formAlis;
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            string Arama = txtArama.Text.Trim();
            if (Arama != "")
            {
                dgwUrunler.DataSource = budak.Sorgu_DataTable("SELECT u.urun_id, u.urun_ad, u.urun_marka, u.urun_model, u.urun_serial, u.urun_fiyat, u.urun_birim, u.urun_kdv, u.urun_kdv_dahil, u.urun_fiyat_kdv_dahil, u.urun_alis_fiyat, u.urun_alis_kdv, u.urun_alis_kdv_dahil, u.urun_alis_fiyat_kdv_dahil FROM fd_urunler AS u WHERE Statu = 'A' and (u.urun_serial=@urun_serial OR u.urun_ad LIKE @urun_ad OR u.urun_marka LIKE @urun_marka OR u.urun_model LIKE @urun_model) ORDER BY u.urun_ad", Arama, "%" + Arama + "%", "%" + Arama + "%", "%" + Arama + "%");
            }
            else
            {
                urun_listele();
            }
        }

        private void urun_listele()
        {
            dgwUrunler.DataSource = budak.Sorgu_DataTable("SELECT u.urun_id, u.urun_ad, u.urun_marka, u.urun_model, u.urun_serial, u.urun_fiyat, u.urun_birim, u.urun_kdv, u.urun_kdv_dahil, u.urun_fiyat_kdv_dahil, u.urun_alis_fiyat, u.urun_alis_kdv, u.urun_alis_kdv_dahil, u.urun_alis_fiyat_kdv_dahil FROM fd_urunler AS u where Statu = 'A' ORDER BY u.urun_ad");
        }

        private void dgwUrunler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string urun_id = dgwUrunler.CurrentRow.Cells[0].Value.ToString();
            if (formAlis != null)
            {
                //this.Hide();
                this.Close();
                formAlis.ListedenUrunSec(urun_id);
                frmAnasayfa.FormSec(formAlis.EkranNo);
            }
        }

        private void frmUrunSec_Load(object sender, EventArgs e)
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

            urun_listele();
        }

        public frmAnasayfa frmAnasayfa;
        public string EkranNo = "";
        private void frmUrunYonetimi_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAnasayfa.DiziFormlar.Remove(this);
            frmAnasayfa.DiziFormTag.Remove("urun_sec");
            frmAnasayfa.TabCikar("urun_sec");
        }
    }
}
