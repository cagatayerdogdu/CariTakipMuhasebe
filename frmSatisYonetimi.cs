using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;
using System.Text.RegularExpressions;

namespace StokTakip
{
    public partial class frmSatisYonetimi : Form
    {
        int IntParseBag = 0; double DoubleParseBag = 0;
        DAL budak;
        public int uye_id;
        string yetki_duzeyi;
        public frmSatisYonetimi(int _uye_id, string _yetki_duzeyi)
        {
            InitializeComponent();
            uye_id = _uye_id;
            yetki_duzeyi = _yetki_duzeyi;
        }

        private void frmSatisYonetimi_Load(object sender, EventArgs e)
        {
            try
            {
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

            }
            catch (Exception hata)
            {
                string problem = hata.ToString();
            }

            this.WindowState = FormWindowState.Maximized;

            dtpTarihBaslangic.Value = DateTime.Now;
            txtStokAdet.Text = "1";

            urun_listele();
        }

        private void urun_listele()
        {
            DataTable TabloUrunler = new DataTable();
            string UrunArama = txtUrunler.Text.Trim();
            if (UrunArama.Length < 3) UrunArama = "";
            if (UrunArama == "")
            {
                TabloUrunler = budak.Sorgu_DataTable("SELECT u.urun_id, u.urun_ad, u.urun_marka, u.urun_model, u.urun_serial FROM fd_urunler AS u where Statu = 'A' ORDER BY u.urun_ad");
            }
            else
            {
                TabloUrunler = budak.Sorgu_DataTable("SELECT u.urun_id, u.urun_ad, u.urun_marka, u.urun_model, u.urun_serial FROM fd_urunler AS u WHERE Statu = 'A' and u.urun_serial=@urun_serial OR u.urun_ad LIKE @urun_ad OR u.urun_marka LIKE @urun_marka OR u.urun_model LIKE @urun_model ORDER BY u.urun_ad", UrunArama, "%" + UrunArama + "%", "%" + UrunArama + "%", "%" + UrunArama + "%");
            }

            //cbUrunler.Items.Clear();
            var dataSource = new List<DropdownListe>();
            dataSource.Add(new DropdownListe() { Name = "Ürün seçiniz", Value = "0" });
            string UrunId = ""; string UrunAd = ""; string UrunMarka = ""; string UrunModel = ""; string UrunBarkod = "";
            string SatirUrunBilgi = "";
            for (int u = 0; u < TabloUrunler.Rows.Count; u++)
            {
                UrunId = TabloUrunler.Rows[u]["urun_id"].ToString();
                UrunAd = TabloUrunler.Rows[u]["urun_ad"].ToString();
                UrunMarka = TabloUrunler.Rows[u]["urun_marka"].ToString();
                UrunModel = TabloUrunler.Rows[u]["urun_model"].ToString();
                UrunBarkod = TabloUrunler.Rows[u]["urun_serial"].ToString();
                SatirUrunBilgi = UrunAd + " [" + UrunBarkod + "]";
                dataSource.Add(new DropdownListe() { Name = SatirUrunBilgi, Value = UrunId });
            }

            cbUrunler.DataSource = dataSource;
            cbUrunler.DisplayMember = "Name";
            cbUrunler.ValueMember = "Value";

            if (UrunArama != "" && TabloUrunler.Rows.Count > 0) cbUrunler.DroppedDown = true;
        }

        private void urun_temizle()
        {
            txtUrunAdi.Text = "";
            txtUrunMarkasi.Text = "";
            txtUrunModeli.Text = "";
            txtUrunSerial.Text = "";
            txtSatisFiyati.Text = "";
            txtUrunMiktar.Text = "";
        }

        private void txtUrunler_KeyUp(object sender, KeyEventArgs e)
        {
            urun_listele();
        }

        private void cbUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SeciliUrun = cbUrunler.SelectedIndex > 0 ? int.Parse(cbUrunler.SelectedValue.ToString()) : 0;
            if (SeciliUrun > 0)
            {
                DataTable TabloUrunler = budak.Sorgu_DataTable("SELECT u.urun_id, u.urun_ad, u.urun_marka, u.urun_model, u.urun_serial, u.urun_fiyat, u.urun_miktar FROM fd_urunler AS u WHERE Statu = 'A' and  u.urun_id=@urun_id", SeciliUrun.ToString());
                if (TabloUrunler.Rows.Count > 0)
                {
                    txtUrunAdi.Text = TabloUrunler.Rows[0]["urun_ad"].ToString();
                    txtUrunMarkasi.Text = TabloUrunler.Rows[0]["urun_marka"].ToString();
                    txtUrunModeli.Text = TabloUrunler.Rows[0]["urun_model"].ToString();
                    txtUrunSerial.Text = TabloUrunler.Rows[0]["urun_serial"].ToString();
                    txtSatisFiyati.Text = TabloUrunler.Rows[0]["urun_fiyat"].ToString();
                    txtUrunMiktar.Text = stok_hesapla(SeciliUrun.ToString(), TabloUrunler.Rows[0]["urun_miktar"].ToString());
                }
            }
            else
            {
                urun_temizle();
            }
        }

        private string stok_hesapla(string urun_id, string miktar)
        {
            string Sonuc = miktar;
            int miktarInt = int.TryParse(Sonuc, out IntParseBag) ? IntParseBag : 0;
            string SatirUrunId; int SatirStokMiktar;
            for (int i = 0; i < dgwUrunler.Rows.Count; i++)
            {
                SatirUrunId = dgwUrunler.Rows[i].Cells[0].Value.ToString();
                SatirStokMiktar = int.Parse(dgwUrunler.Rows[i].Cells[1].Value.ToString());
                if (urun_id == SatirUrunId)
                {
                    miktarInt -= SatirStokMiktar;
                }
            }
            Sonuc = miktarInt.ToString();
            return Sonuc;
        }

        private void btnStokEkle_Click(object sender, EventArgs e)
        {
            int SeciliUrun = cbUrunler.SelectedIndex > 0 ? int.Parse(cbUrunler.SelectedValue.ToString()) : 0;
            int Miktar = int.TryParse(txtStokAdet.Text, out IntParseBag) ? IntParseBag : 0;
            string SatisFiyati = txtSatisFiyati.Text.Replace(',','.').Trim();
            if (!double.TryParse(SatisFiyati, out DoubleParseBag)) SatisFiyati = "0";
            int MevcutMiktar = int.TryParse(txtUrunMiktar.Text, out IntParseBag) ? IntParseBag : 0;
            if (SeciliUrun == 0)
            {
                MessageBox.Show("Ürün seçiniz.");
            }
            else if (Miktar == 0)
            {
                MessageBox.Show("Miktar giriniz.");
            }
            else if (Miktar > MevcutMiktar)
            {
                MessageBox.Show("Seçtiğiniz üründen stokta " + MevcutMiktar + " adet bulunuyor. " + Miktar + "  adet satış yapılamaz.");
            }
            else if (SatisFiyati == "0")
            {
                MessageBox.Show("Birim fiyat giriniz.");
            }
            else
            {
                double ToplamFiyatDouble = double.Parse(SatisFiyati.Replace('.', ',')) * Miktar;
                string ToplamFiyat = ToplamFiyatDouble.ToString().Replace(',', '.');
                dgwUrunler.Rows.Add(SeciliUrun.ToString(), Miktar.ToString(), SatisFiyati, ToplamFiyat, txtUrunSerial.Text, txtUrunAdi.Text, txtUrunMarkasi.Text, txtUrunModeli.Text);
                cbUrunler_SelectedIndexChanged(null, null);
            }
        }

        private void tsmiSatirSil_Click(object sender, EventArgs e)
        {
            if (dgwUrunler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen satış listesinden kaldırmak istediğiniz satırı seçiniz.");
            }
            else
            {
                int i = dgwUrunler.CurrentRow.Index;
                dgwUrunler.Rows.RemoveAt(i);
                cbUrunler_SelectedIndexChanged(null, null);
            }
        }

        private void dgwUrunler_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tsmiSatirSil.Visible = true;
                menuSag.Show(dgwUrunler.PointToScreen(e.Location));
            }
        }
    }
}
