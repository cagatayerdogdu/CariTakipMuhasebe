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
    public partial class frmSifreDegistir : Form
    {
        double DoubleParseBag = 0; int IntParseBag = 0;
        DAL budak; Fonksiyonlar Tornavida;
        public int uye_id;
        string yetki_duzeyi;
        public frmSifreDegistir(int _uye_id, string _yetki_duzeyi)
        {
            InitializeComponent();
            uye_id = _uye_id;
            yetki_duzeyi = _yetki_duzeyi;
        }

        string EskiKullaniciAdi = "";
        string EskiSifre = "";
        private void frmSifreDegistir_Load(object sender, EventArgs e)
        {
            Tornavida = new Fonksiyonlar();
            try
            {
                //string baglanti_bilgisi = "Data Source=" + Application.StartupPath + "\\StokTakip.s3db";
                //DAL nesnemize, oluşturduğumuz bağlantı dizesini parametre olarak atıyoruz.
                //MessageBox.Show(baglanti_bilgisi);

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

            DataTable TabloKullaniciBilgileri = budak.Sorgu_DataTable("SELECT KullaniciAdi, Parola FROM fd_yetkiler WHERE Statu = 'A' and YetkiID=@yetki_id", uye_id.ToString());
            txtKullaniciAdi.Text = TabloKullaniciBilgileri.Rows[0]["KullaniciAdi"].ToString();
            EskiKullaniciAdi = txtKullaniciAdi.Text;
            EskiSifre = TabloKullaniciBilgileri.Rows[0]["Parola"].ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (EskiKullaniciAdi != txtKullaniciAdi.Text)
            {
                if (txtKullaniciAdi.Text.Trim() == "")
                {
                    MessageBox.Show("Lütfen bir kullanıcı adı giriniz.");
                }
                else if (budak.Kayit_var_mi("SELECT top 1 YetkiID FROM fd_yetkiler WHERE Statu = 'A' and  KullaniciAdi=@kullanici_adi", txtKullaniciAdi.Text))
                {
                    MessageBox.Show("Girdiğiniz kullanıcı adı başka bir kullanıcı tarafından kullanılıyor. Lütfen farklı bir kullanıcı adı seçiniz.");
                }
                else if (txtKullaniciAdi.Text.Length > 50)
                {
                    MessageBox.Show("Kullanıcı adınız en fazla 50 karakter olabilir. Lütfen farklı bir kullanıcı adı seçiniz.");
                }
                else
                {
                    int Etki = budak.Sorgu_Calistir("UPDATE fd_yetkiler SET KullaniciAdi=@kullanici_adi WHERE YetkiID=@yetki_id", txtKullaniciAdi.Text, uye_id.ToString());
                    string Bildirim = Etki > 0 ? "Kullanıcı adınız başarıyla güncellenmiştir." : "Kullanıcı adınız güncellenirken bir sorun oluştu. Lütfen bilgilerinizi kontrol edip tekrar deneyin.";

                    if (Etki > 0) EskiKullaniciAdi = txtKullaniciAdi.Text;

                    MessageBox.Show(Bildirim);
                }
            }

            if (txtYeniSifre.Text != "")
            {
                if (txtEskiSifre.Text == "")
                {
                    MessageBox.Show("Lütfen eski şifrenizi giriniz.");
                }
                else if (txtEskiSifre.Text != EskiSifre)
                {
                    MessageBox.Show("Eski şifrenizi hatalı girdiniz.");
                }
                else if (txtYeniSifre.Text == "")
                {
                    MessageBox.Show("Lütfen yeni şifrenizi giriniz.");
                }
                else if (txtYeniSifreTekrar.Text == "")
                {
                    MessageBox.Show("Lütfen yeni şifrenizi tekrar giriniz.");
                }
                else if (txtYeniSifre.Text != txtYeniSifreTekrar.Text)
                {
                    MessageBox.Show("Yeni şifreniz, tekrarıyla uyuşmuyor.");
                }
                else if (txtYeniSifre.Text.Length > 50)
                {
                    MessageBox.Show("Şifreniz en fazla 50 karakter olabilir. Lütfen farklı bir şifre seçiniz.");
                }
                else
                {
                    int Etki = budak.Sorgu_Calistir("UPDATE fd_yetkiler SET Parola=@parola WHERE YetkiID=@yetki_id", txtYeniSifre.Text, uye_id.ToString());
                    string Bildirim = Etki > 0 ? "Şifreniz başarıyla güncellenmiştir." : "Şifreniz güncellenirken bir sorun oluştu. Lütfen bilgilerinizi kontrol edip tekrar deneyin.";

                    if (Etki > 0) EskiSifre = txtYeniSifre.Text;

                    MessageBox.Show(Bildirim);
                }
            }
        }

        public frmAnasayfa frmAnasayfa;
        public string EkranNo = "";
        private void frmSifreDegistir_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAnasayfa.DiziFormlar.Remove(this);
            frmAnasayfa.DiziFormTag.Remove("sifre_degistir");
            frmAnasayfa.TabCikar("sifre_degistir");
        }

    }
}
