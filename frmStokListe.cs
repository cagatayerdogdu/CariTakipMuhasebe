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
    public partial class frmStokListe : Form
    {
        double DoubleParseBag = 0; int IntParseBag = 0;
        DAL budak; Fonksiyonlar Tornavida;
        public int uye_id;
        string yetki_duzeyi;
        public frmStokListe(int _uye_id, string _yetki_duzeyi)
        {
            InitializeComponent();
            uye_id = _uye_id;
            yetki_duzeyi = _yetki_duzeyi;
        }

        private void frmStokListe_Load(object sender, EventArgs e)
        {
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

            ddlArtiEksi.SelectedIndex = 0;

            urun_listele();
        }


        public frmAnasayfa frmAnasayfa;
        public string EkranNo = "";
        private void frmUrunYonetimi_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAnasayfa.DiziFormlar.Remove(this);
            frmAnasayfa.DiziFormTag.Remove("stok_listesi");
            frmAnasayfa.TabCikar("stok_listesi");
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            urun_listele();
        }

        public void urun_listele()
        {
            string SorguFiltre = "";

            dgwUrunler.Columns[9].Visible = false;
            dgwUrunler.Columns[10].Visible = false;
            dgwUrunler.Columns[11].Visible = false;
            dgwUrunler.Columns[12].Visible = false;

            if(cbMevcutStokDeger.Checked){
                SorguFiltre += " AND u.urun_miktar>0";
                dgwUrunler.Columns[9].Visible = true;
                dgwUrunler.Columns[10].Visible = true;
                dgwUrunler.Columns[11].Visible = true;
                dgwUrunler.Columns[12].Visible = true;
            }
            else if(ddlArtiEksi.SelectedIndex > 0){
                SorguFiltre += ddlArtiEksi.SelectedIndex == 1 ? " AND u.urun_miktar>0" : " AND u.urun_miktar<=0";
            }

            string Arama = txtArama.Text;
            if (Arama != "")
            {
                dgwUrunler.DataSource = budak.Sorgu_DataTable("SELECT u.urun_id, u.urun_serial, u.urun_ad, u.urun_marka, u.urun_model, u.urun_miktar, u.urun_birim, u.urun_fiyat AS satis_birim, u.urun_kdv, ROUND((u.urun_miktar * u.urun_fiyat), 2) AS urun_fiyat, ROUND((u.urun_miktar * u.urun_fiyat_kdv_dahil), 2) AS urun_fiyat_kdv_dahil, ROUND((u.urun_miktar * u.urun_alis_fiyat), 2) AS urun_alis_fiyat, ROUND((u.urun_miktar * u.urun_alis_fiyat_kdv_dahil), 2) AS urun_alis_fiyat_kdv_dahil, u.urun_alis_kdv, u.urun_kdv_dahil, u.urun_alis_kdv_dahil FROM fd_urunler AS u WHERE 1=1 and Statu = 'A' " + SorguFiltre + " AND (u.urun_serial=@urun_serial OR u.urun_ad LIKE @urun_ad OR u.urun_marka LIKE @urun_marka OR u.urun_model LIKE @urun_model) ORDER BY u.urun_ad", Arama, "%" + Arama + "%", "%" + Arama + "%", "%" + Arama + "%");
            }
            else
            {
                dgwUrunler.DataSource = budak.Sorgu_DataTable("SELECT u.urun_id, u.urun_serial, u.urun_ad, u.urun_marka, u.urun_model, u.urun_miktar, u.urun_birim, u.urun_fiyat AS satis_birim, u.urun_kdv, ROUND((u.urun_miktar * u.urun_fiyat), 2) AS urun_fiyat, ROUND((u.urun_miktar * u.urun_fiyat_kdv_dahil), 2) AS urun_fiyat_kdv_dahil, ROUND((u.urun_miktar * u.urun_alis_fiyat), 2) AS urun_alis_fiyat, ROUND((u.urun_miktar * u.urun_alis_fiyat_kdv_dahil), 2) AS urun_alis_fiyat_kdv_dahil, u.urun_alis_kdv, u.urun_kdv_dahil, u.urun_alis_kdv_dahil FROM fd_urunler AS u WHERE 1=1 and Statu = 'A' " + SorguFiltre + " ORDER BY u.urun_ad");
            }


        }

        private void cbMevcutStokDeger_CheckedChanged(object sender, EventArgs e)
        {
            urun_listele();
        }

        private void btnTumUrunHareketleri_Click(object sender, EventArgs e)
        {
            UrunHareketleriGoster();
        }

        private void UrunHareketleriGoster(string seciliUrun = "")
        {
            if (frmAnasayfa.DiziFormTag.Contains("urun_hareketleri"))
            {
                frmAnasayfa.TabSec("urun_hareketleri");
                frmAnasayfa.DiziFormlar.RemoveAt(frmAnasayfa.DiziFormTag.IndexOf("urun_hareketleri"));
                frmAnasayfa.DiziFormTag.Remove("urun_hareketleri");
                frmAnasayfa.TabCikar("urun_hareketleri");
            }

            frmUrunHareketleri formUrunHareketleri = new frmUrunHareketleri(uye_id, yetki_duzeyi, seciliUrun, this);
            formUrunHareketleri.MdiParent = frmAnasayfa;
            frmAnasayfa.EkranSayisi++;
            TabPage tp = new TabPage();
            tp.Parent = frmAnasayfa.tcMain;
            tp.Text = formUrunHareketleri.Text;
            tp.Tag = "urun_hareketleri";
            tp.Show();

            formUrunHareketleri.Show();
            formUrunHareketleri.EkranNo = frmAnasayfa.EkranSayisi.ToString();
            formUrunHareketleri.frmAnasayfa = frmAnasayfa;
            frmAnasayfa.tcMain.SelectedTab = tp;
            frmAnasayfa.DiziFormlar.Add(formUrunHareketleri);
            frmAnasayfa.DiziFormTag.Add("urun_hareketleri");
        }

        private void dgwUrunler_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && dgwUrunler.SelectedRows.Count > 0)
            {
                tsmiUrunHareketleri.Visible = true;
                tsmiDuzenle.Visible = true;
                menuSag.Show(dgwUrunler.PointToScreen(e.Location));
            }
        }

        private void tsmiUrunHareketleri_Click(object sender, EventArgs e)
        {
            string UrunId = dgwUrunler.CurrentRow.Cells[0].Value.ToString();
            UrunHareketleriGoster(UrunId);
        }

        private void dgwUrunler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string UrunId = dgwUrunler.CurrentRow.Cells[0].Value.ToString();
            UrunHareketleriGoster(UrunId);
        }

        private void tsmiDuzenle_Click(object sender, EventArgs e)
        {
            string UrunId = dgwUrunler.CurrentRow.Cells[0].Value.ToString();
            urunSec(UrunId);
        }

        private void urunSec(string seciliUrun = "")
        {
            if (frmAnasayfa.DiziFormTag.Contains("urun_yonetimi"))
            {
                frmAnasayfa.TabSec("urun_yonetimi");
                frmAnasayfa.DiziFormlar.RemoveAt(frmAnasayfa.DiziFormTag.IndexOf("urun_yonetimi"));
                frmAnasayfa.DiziFormTag.Remove("urun_yonetimi");
                frmAnasayfa.TabCikar("urun_yonetimi");
            }

            frmUrunYonetimi formUrunYonetimi = new frmUrunYonetimi(uye_id, yetki_duzeyi, seciliUrun, this);
            formUrunYonetimi.MdiParent = frmAnasayfa;
            frmAnasayfa.EkranSayisi++;
            TabPage tp = new TabPage();
            tp.Parent = frmAnasayfa.tcMain;
            tp.Text = formUrunYonetimi.Text;
            tp.Tag = "urun_yonetimi";
            tp.Show();

            formUrunYonetimi.Show();
            formUrunYonetimi.EkranNo = frmAnasayfa.EkranSayisi.ToString();
            formUrunYonetimi.frmAnasayfa = frmAnasayfa;
            frmAnasayfa.tcMain.SelectedTab = tp;
            frmAnasayfa.DiziFormlar.Add(formUrunYonetimi);
            frmAnasayfa.DiziFormTag.Add("urun_yonetimi");
        }

    }
}