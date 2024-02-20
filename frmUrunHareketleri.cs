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
    public partial class frmUrunHareketleri : Form
    {
        double DoubleParseBag = 0; int IntParseBag = 0;
        DAL budak; Fonksiyonlar Tornavida;
        public int uye_id;
        string yetki_duzeyi;
        frmStokListe formStokListe = null;
        string secili_urun;
        public frmUrunHareketleri(int _uye_id, string _yetki_duzeyi, string _secili_urun, frmStokListe _formStokListe)
        {
            InitializeComponent();
            uye_id = _uye_id;
            yetki_duzeyi = _yetki_duzeyi;
            formStokListe = _formStokListe;
            secili_urun = _secili_urun;
        }

        private void frmUrunHareketleri_Load(object sender, EventArgs e)
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

            lblSeciliIUrunAd.Text = "Tüm Ürünler";
            lblSeciliUrun.Text = secili_urun;
            if (secili_urun != "")
            {
                lblSeciliIUrunAd.Text = budak.Sorgu_Scalar("SELECT urun_ad FROM fd_urunler WHERE Statu = 'A' and  urun_id=" + secili_urun);
            }

            var dataSourceFirmaMusteri = new List<DropdownListe>();
            dataSourceFirmaMusteri.Add(new DropdownListe() { Name = "Firma", Value = "firma" });
            dataSourceFirmaMusteri.Add(new DropdownListe() { Name = "Müşteri", Value = "musteri" });
            cbFirmaMusteri.DataSource = dataSourceFirmaMusteri;
            cbFirmaMusteri.DisplayMember = "Name";
            cbFirmaMusteri.ValueMember = "Value";

            var dataSourceIslem = new List<DropdownListe>();
            dataSourceIslem.Add(new DropdownListe() { Name = "", Value = "" });
            dataSourceIslem.Add(new DropdownListe() { Name = "Alış", Value = "alis" });
            dataSourceIslem.Add(new DropdownListe() { Name = "Satış", Value = "satis" });
            dataSourceIslem.Add(new DropdownListe() { Name = "Devir", Value = "devir" });
            cbIslem.DataSource = dataSourceIslem;
            cbIslem.DisplayMember = "Name";
            cbIslem.ValueMember = "Value";

            cbFirmaMusteri.SelectedIndex = 0;
            dtpTarihBaslangic.Value = new DateTime(2020, 1, 1, 0, 0, 0);
            dtpTarihBitis.Value = DateTime.Now; //[CE_01.02.2020 01:40] //new DateTime(2020, 1, 1, 0, 0, 0);

            hareket_listele();
            listeFormatla();
        }

        public frmAnasayfa frmAnasayfa;
        public string EkranNo = "";
        private void frmUrunHareketleri_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAnasayfa.DiziFormlar.Remove(this);
            frmAnasayfa.DiziFormTag.Remove("urun_hareketleri");
            frmAnasayfa.TabCikar("urun_hareketleri");
        }

        public void ListedenFirmaSec(string firma_id, string firma_adi)
        {
            lblSeciliFirma.Text = firma_id;
            txtFirmalar.Text = firma_adi;
            chkFirmaMusteri.Checked = true;
        }

        public void hareket_listele()
        {
            string TarihBaslangic = dtpTarihBaslangic.Value.ToString("yyyy-MM-dd ") + "00:00";
            string TarihBitis = dtpTarihBitis.Value.ToString("yyyy-MM-dd ") + "23:59";

            DateTime TarihBaslangic_Date = Tornavida.TarihToDateTime(TarihBaslangic); // [CE_16.05.2020 23:41] Web DB sebebiyle
            DateTime TarihBitis_Date = Tornavida.TarihToDateTime(TarihBitis); // [CE_16.05.2020 23:41] Web DB sebebiyle

        
            string SorguFiltre = "";
            if (cbIslem.SelectedIndex > 0)
            {
                SorguFiltre += " AND s.tip='" + cbIslem.SelectedValue + "'";
            }
            if (txtFirmalar.Text.Trim() != "")
            {
                if (lblSeciliFirma.Text == "")
                {
                    SorguFiltre += " AND m.ad_soyad LIKE '%" + txtFirmalar.Text.Trim() + "%'";
                }
                else
                {
                    SorguFiltre += " AND m.musteri_id=" + lblSeciliFirma.Text;
                }
            }
            if (secili_urun != "")
            {
                SorguFiltre += " AND su.urun_id=" + secili_urun;
            }

            //DataTable TabloHareketler = budak.Sorgu_DataTable(@"SELECT s.satis_id, su.su_id, (SUBSTR(s.tarih, 7, 2) || '/' || SUBSTR(s.tarih, 5, 2) || '/' || SUBSTR(s.tarih, 1, 4)) AS tarih, (SUBSTR(s.tarih, 9, 2) || ':' || SUBSTR(s.tarih, 11, 2)) AS saat, s.tip AS islem_kod, CASE s.tip WHEN 'alis' THEN 'Ürün Alış' WHEN 'satis' THEN 'Ürün Satış' WHEN 'para_alis' THEN 'Para Alındı' WHEN 'para_veris' THEN 'Para Verildi' WHEN 'devir' THEN 'Devir' END AS islem, CASE m.tip WHEN 'musteri' THEN 'Müşteri' ELSE 'Firma' END AS yer, m.ad_soyad, u.urun_ad, u.urun_serial, su.miktar, su.birim_fiyat_kdv_dahil, su.iskonto, su.toplam_fiyat_kdv_dahil FROM satislar AS s JOIN satis_urunler AS su ON s.satis_id=su.satis_id JOIN musteriler AS m ON s.musteri_id=m.musteri_id JOIN urunler AS u ON su.urun_id=u.urun_id WHERE s.tarih BETWEEN @tarih_baslangic AND @tarih_bitis " + SorguFiltre + " ORDER BY s.tarih DESC", TarihBaslangic, TarihBitis);
            DataTable TabloHareketler = budak.Sorgu_DataTable(@"SELECT s.satis_id, su.su_id, s.tarih, s.tip AS islem_kod, CASE s.tip WHEN 'alis' THEN 'Ürün Alış' WHEN 'satis' THEN 'Ürün Satış' WHEN 'para_alis' THEN 'Para Alındı' WHEN 'para_veris' THEN 'Para Verildi' WHEN 'devir' THEN 'Devir' END AS islem, CASE m.tip WHEN 'musteri' THEN 'Müşteri' ELSE 'Firma' END AS yer, m.ad_soyad, u.urun_ad, u.urun_serial, su.miktar, su.birim_fiyat_kdv_dahil, su.iskonto, su.toplam_fiyat_kdv_dahil FROM fd_satislar AS s JOIN fd_satis_urunler AS su ON s.satis_id=su.satis_id JOIN fd_musteriler AS m ON s.musteri_id=m.musteri_id JOIN fd_urunler AS u ON su.urun_id=u.urun_id WHERE (s.Statu = 'A' and m.Statu = 'A' and su.Statu = 'A' and u.Statu = 'A') and s.tarih BETWEEN @tarih_baslangic AND @tarih_bitis " + SorguFiltre + " ORDER BY s.tarih DESC", TarihBaslangic_Date.ToString(), TarihBitis_Date.ToString());
            dgwStoklar.DataSource = TabloHareketler;
            listeFormatla();
        }

        int ToplamMiktarAlis = 0; int ToplamMiktarSatis = 0;
        private void listeFormatla()
        {
            string SatirSatisID = ""; string SatirSuID = ""; string SatirIslem = ""; string SatirToplamFiyat = ""; int SatirMiktar = 0;
            //foreach (DataGridViewRow row in dgwStoklar.Rows)
            //{
                //if (row.Cells[0].Value == null) continue;
            ToplamMiktarAlis = 0; ToplamMiktarSatis = 0;
            for (int i = 0; i < dgwStoklar.Rows.Count; i++)
            {
                SatirSatisID = dgwStoklar.Rows[i].Cells[2].Value.ToString();    // 1
                SatirSuID = dgwStoklar.Rows[i].Cells[3].Value.ToString();    // 2
                SatirIslem = dgwStoklar.Rows[i].Cells[6].Value.ToString();    // 6
                SatirMiktar = int.Parse(dgwStoklar.Rows[i].Cells[11].Value.ToString());    // 11
                SatirToplamFiyat = dgwStoklar.Rows[i].Cells[12].Value.ToString();    // 14
                //dgwStoklar.Rows[i].DefaultCellStyle.ForeColor = Color.Black;

                switch (SatirIslem)
                {
                    case "Ürün Alış":
                        dgwStoklar.Rows[i].DefaultCellStyle.BackColor = Color.DarkSalmon;
                        ToplamMiktarAlis += SatirMiktar;
                        break;
                    case "Ürün Satış":
                        dgwStoklar.Rows[i].DefaultCellStyle.BackColor = Color.DarkSeaGreen;
                        ToplamMiktarSatis += SatirMiktar;
                        break;
                    case "Devir":
                        dgwStoklar.Rows[i].DefaultCellStyle.BackColor = Color.Silver;
                        break;
                }
                dgwStoklar.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
            }
            dgwStoklar.ClearSelection();

            lblToplamAlis.Text = ToplamMiktarAlis.ToString();
            lblToplamSatis.Text = ToplamMiktarSatis.ToString();
        }

        private void txtFirmalar_KeyDown(object sender, KeyEventArgs e)
        {
            lblSeciliFirma.Text = "";
        }

        private void cbIslem_SelectedIndexChanged(object sender, EventArgs e)
        {
            hareket_listele();
        }

        private void chkFirmaMusteri_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkFirmaMusteri.Checked)
            {
                txtFirmalar.Text = "";
                lblSeciliFirma.Text = "";
            }
            cbIslem_SelectedIndexChanged(sender, e);
        }

        private void dgwStoklar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string SatisId = dgwStoklar.CurrentRow.Cells[2].Value.ToString();
            string SatisIslem = dgwStoklar.CurrentRow.Cells[5].Value.ToString();

            if (SatisIslem == "alis" || SatisIslem == "satis")
            {
                frmStokYonetimi formStokYonetimi = new frmStokYonetimi(uye_id, yetki_duzeyi, SatisIslem, this, SatisId);
                formStokYonetimi.MdiParent = frmAnasayfa;

                frmAnasayfa.EkranSayisi++;
                TabPage tp = new TabPage();
                tp.Parent = frmAnasayfa.tcMain;
                tp.Text = SatisIslem == "alis" ? "ALIŞ KAYDINI DÜZENLE" : "SATIŞ KAYDINI DÜZENLE";
                tp.Tag = SatisIslem + "_duzenle";
                tp.Show();

                formStokYonetimi.Show();
                formStokYonetimi.EkranNo = frmAnasayfa.EkranSayisi.ToString();
                formStokYonetimi.frmAnasayfa = frmAnasayfa;
                frmAnasayfa.tcMain.SelectedTab = tp;
                frmAnasayfa.DiziFormlar.Add(formStokYonetimi);
                frmAnasayfa.DiziFormTag.Add(SatisIslem + "_duzenle");
            }
        }

        private void dgwStoklar_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && dgwStoklar.SelectedRows.Count > 0)
            {
                menuSag.Show(dgwStoklar.PointToScreen(e.Location));
            }
        }

        private void tsmiSatisEkrani_Click(object sender, EventArgs e)
        {
            dgwStoklar_CellDoubleClick(null, null);
        }

        private void btnFirmaSec_Click(object sender, EventArgs e)
        {
            string musteri_firma = cbFirmaMusteri.SelectedValue.ToString();

            if (frmAnasayfa.DiziFormTag.Contains("firma_sec"))
            {
                frmAnasayfa.TabSec("firma_sec");
            }
            else
            {
                frmFirmaSec formFirmaSec = new frmFirmaSec(uye_id, yetki_duzeyi, musteri_firma, this);
                formFirmaSec.MdiParent = frmAnasayfa;
                frmAnasayfa.EkranSayisi++;
                TabPage tp = new TabPage();
                tp.Parent = frmAnasayfa.tcMain;
                tp.Text = formFirmaSec.Text;
                tp.Tag = "firma_sec";
                tp.Show();

                formFirmaSec.Show();
                formFirmaSec.EkranNo = frmAnasayfa.EkranSayisi.ToString();
                formFirmaSec.frmAnasayfa = frmAnasayfa;
                frmAnasayfa.tcMain.SelectedTab = tp;
                frmAnasayfa.DiziFormlar.Add(formFirmaSec);
                frmAnasayfa.DiziFormTag.Add("firma_sec");
            }
        }
    }
}
