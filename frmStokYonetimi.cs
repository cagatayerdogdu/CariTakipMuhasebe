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
    public partial class frmStokYonetimi : Form
    {
        int IntParseBag = 0; long LongParseBag = 0; double DoubleParseBag = 0;
        DAL budak; Fonksiyonlar Tornavida;
        public int uye_id;
        string yetki_duzeyi;
        string islem = "";
        string secili_kayit_id = "";
        frmMuhasebeHareketleri formMuhasebeHareketleri = null;
        frmUrunHareketleri formUrunHareketleri = null;
        public frmStokYonetimi(int _uye_id, string _yetki_duzeyi, string _islem, string _secili_kayit_id = "")
        {
            InitializeComponent();
            uye_id = _uye_id;
            yetki_duzeyi = _yetki_duzeyi;
            islem = _islem;
            secili_kayit_id = _secili_kayit_id;
        }
        public frmStokYonetimi(int _uye_id, string _yetki_duzeyi, string _islem, frmMuhasebeHareketleri _formMuhasebeHareketleri, string _secili_kayit_id = "")
        {
            InitializeComponent();
            uye_id = _uye_id;
            yetki_duzeyi = _yetki_duzeyi;
            islem = _islem;
            secili_kayit_id = _secili_kayit_id;
            formMuhasebeHareketleri = _formMuhasebeHareketleri;
            if (secili_kayit_id != "")
            {
                btnSatisTamamla.Text = "GÜNCELLE";
            }
        }
        public frmStokYonetimi(int _uye_id, string _yetki_duzeyi, string _islem, frmUrunHareketleri _formUrunHareketleri, string _secili_kayit_id = "")
        {
            InitializeComponent();
            uye_id = _uye_id;
            yetki_duzeyi = _yetki_duzeyi;
            islem = _islem;
            secili_kayit_id = _secili_kayit_id;
            formUrunHareketleri = _formUrunHareketleri;
        }

        string SeciliUrunAlisFiyat = "";
        string SeciliUrunSatisFiyat = "";
        string SeciliUrunAlisFiyatKdvDahil = "";
        string SeciliUrunSatisFiyatKdvDahil = "";

        private void frmStokYonetimi_Load(object sender, EventArgs e)
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

            dtpTarihBaslangic.Value = DateTime.Now;
            txtStokAdet.Text = "1";

            var dataSource = new List<DropdownListe>();
            dataSource.Add(new DropdownListe() { Name = "", Value = "" });
            dataSource.Add(new DropdownListe() { Name = "İrsaliye", Value = "irsaliye" });
            dataSource.Add(new DropdownListe() { Name = "Fatura", Value = "fatura" });
            dataSource.Add(new DropdownListe() { Name = "İrs/Fat", Value = "irsfat" });
            dataSource.Add(new DropdownListe() { Name = "Kesilmedi", Value = "kesilmedi" });
            cbFaturaTip.DataSource = dataSource;
            cbFaturaTip.DisplayMember = "Name";
            cbFaturaTip.ValueMember = "Value";

            var dataSourceOdemeTipi = new List<DropdownListe>();
            dataSourceOdemeTipi.Add(new DropdownListe() { Name = "Nakit", Value = "nakit" });
            dataSourceOdemeTipi.Add(new DropdownListe() { Name = "Kredi Kartı", Value = "kredi_karti" });
            dataSourceOdemeTipi.Add(new DropdownListe() { Name = "Çek", Value = "cek" });
            dataSourceOdemeTipi.Add(new DropdownListe() { Name = "Senet", Value = "senet" });
            cbOdemeTipi.DataSource = dataSourceOdemeTipi;
            cbOdemeTipi.DisplayMember = "Name";
            cbOdemeTipi.ValueMember = "Value";

            if (islem == "alis")
            {
                cbFirmaMusteri.SelectedIndex = 0;
                chkCariKayit.Checked = false;                
                musteri_bilgileri_durum_false();
            }
            else
            {
                cbFirmaMusteri.SelectedIndex = 1;
            }

            if (islem == "satis")
            {
                this.Text = "SATIŞ";
                //cbFirmaMusteri.SelectedIndex = 1; // [CE_06.02.2020 23:18] Cari kaydı için değiştirdim.Yukarda yaptım.
                cmbMecra.SelectedIndex = 0;
                if (chkCariKayit.Checked)
                {
                    btnFirmaSec.Enabled = false;
                }
                cbFaturaTip.SelectedIndex = 3;

                KullanilacakFaturaNo();
            }

            lblSeciliUrun.Text = "";
            lblSeciliFirma.Text = "";
            lblSeciliKayit.Text = "";
            urun_listele();
            urun_temizle();
            lblKalemSayisi.Text = "";
            cbOdemeTipi.SelectedIndex = 0;


            if (secili_kayit_id != "") kayit_yukle();
        }
        
        private void KullanilacakFaturaNo()
        {
            string SonFaturaNo = budak.Sorgu_Scalar(@"select top 1 fatura_no from fd_satislar where Statu = 'A' and len(fatura_no)>0 and tip = 'satis' order by Kayit_Tarihi desc");
            if (SonFaturaNo == "")
            {
                txtFaturaNo.Text = SonFaturaNo;
            }
            else
            {
                string FatNo = Tornavida.FaturaNo(SonFaturaNo);

                int FaturaNoUzunluk = SonFaturaNo.Length;
                FaturaNoUzunluk = FaturaNoUzunluk - 1;
                int SonFatura_No = Convert.ToInt32(SonFaturaNo.Substring(1, FaturaNoUzunluk)) + 1;
                string FaturaNo_Son = SonFaturaNo.Substring(0, 1) + FatNo + SonFatura_No.ToString();
                txtFaturaNo.Text = FaturaNo_Son;
            }

        }
        private void kayit_yukle()
        {
            string SatirSatisId = ""; string SatirSeciliUrun = ""; string SatirMiktar = ""; string SatirIskonto = ""; string SatirKdv = ""; string SatirKdvDahil = ""; string SatirBirimFiyat = ""; string SatirBirimFiyatKdvDahil = ""; string SatirToplamFiyat = ""; string SatirToplamFiyatKdvDahil = ""; string SatirUrunSerial = ""; string SatirUrunAd = ""; string SatirUrunModel = ""; long SatirTarihLong = 0; string SatirTarih = ""; string SatirStokMiktar = "";
            //string AdSoyad = ""; string TcKimlik = ""; string CepTel = ""; string Adres = ""; string VDairesi = ""; string VNo = "";
            //string GeldigiMecra = ""; string MecraNo = "";

            //DataTable TabloSatis = budak.Sorgu_DataTable("SELECT s.tip, s.uye_id, s.musteri_id, (s.tarih*1) AS tarih, s.toplam_fiyat, s.toplam_fiyat_kdv_dahil, s.belge, s.fatura_no, s.fatura_aciklama, s.odenen_tutar, s.odeme_tipi, m.tip AS musteri_tip, m.ad_soyad AS musteri_ad FROM fd_satislar AS s JOIN fd_musteriler AS m ON s.musteri_id=m.musteri_id WHERE s.satis_id=@satis_id", secili_kayit_id);
            DataTable TabloSatis = budak.Sorgu_DataTable("SELECT s.tip, s.uye_id, s.musteri_id, tarih, s.toplam_fiyat, s.toplam_fiyat_kdv_dahil, s.belge, s.fatura_no, s.fatura_aciklama, s.odenen_tutar, s.odeme_tipi, m.tip AS musteri_tip, m.ad_soyad AS musteri_ad, tc_kimlik, cep_tel, adres, vergi_dairesi, vergi_no, geldigi_mecra, mecra_no FROM fd_satislar AS s JOIN fd_musteriler AS m ON s.musteri_id=m.musteri_id WHERE (s.Statu = 'A' and m.Statu = 'A') and s.satis_id=@satis_id", secili_kayit_id);
            string MusteriTip = "";
            if (TabloSatis.Rows.Count > 0)
            {
                lblSeciliKayit.Text = secili_kayit_id;
                islem = TabloSatis.Rows[0]["tip"].ToString();
                if (islem == "satis")
                {
                    this.Text = "SATIŞ";
                }
                MusteriTip = TabloSatis.Rows[0]["musteri_tip"].ToString();
                if (MusteriTip == "musteri") cbFirmaMusteri.SelectedIndex = 1;
                else cbFirmaMusteri.SelectedIndex = 0;
                lblSeciliFirma.Text = TabloSatis.Rows[0]["musteri_id"].ToString();
                txtFirmalar.Text = TabloSatis.Rows[0]["musteri_ad"].ToString();
                //SatirTarihLong = long.Parse(TabloSatis.Rows[0]["tarih"].ToString()); //[CE_29.01.2020 12:44]
                dtpTarihBaslangic.Value = Tornavida.TarihToDateTime(TabloSatis.Rows[0]["tarih"].ToString());  //Tornavida.TarihToDateTime(SatirTarihLong.ToString()); // [CE_01.02.2020 01:13] // Eski string formatta olduğu için fonksiyondan çevirip alınıyormuş datetime tipinde fonk.a gerek olmadığı için fonk.da bu alanı atlatacak kod yazdım burayı da bu haliyle revize ettim.                  

                cbFaturaTip.SelectedValue = TabloSatis.Rows[0]["belge"].ToString();
                txtFaturaNo.Text = TabloSatis.Rows[0]["fatura_no"].ToString();
                txtFaturaAciklama.Text = TabloSatis.Rows[0]["fatura_aciklama"].ToString();
                txtOdenenTutar.Text = TabloSatis.Rows[0]["odenen_tutar"].ToString();
                cbOdemeTipi.SelectedValue = TabloSatis.Rows[0]["odeme_tipi"].ToString();
                cmbMecra.SelectedValue = TabloSatis.Rows[0]["geldigi_mecra"].ToString();
                txtMecraNo.Text = TabloSatis.Rows[0]["mecra_no"].ToString();
                txtAdSoyad.Text = TabloSatis.Rows[0]["musteri_ad"].ToString();
                txtTcKimlik.Text = TabloSatis.Rows[0]["tc_kimlik"].ToString();
                txtCepTel.Text = TabloSatis.Rows[0]["cep_Tel"].ToString();
                txtAdres.Text = TabloSatis.Rows[0]["adres"].ToString();
                txtVergiDairesi.Text = TabloSatis.Rows[0]["vergi_dairesi"].ToString();
                txtVergiNo.Text = TabloSatis.Rows[0]["vergi_no"].ToString();

                DataTable TabloSatirlar = budak.Sorgu_DataTable("SELECT su.satis_id, su.urun_id, su.miktar, su.iskonto, su.kdv, su.kdv_dahil, su.birim_fiyat, su.birim_fiyat_kdv_dahil, su.toplam_fiyat, su.toplam_fiyat_kdv_dahil, u.urun_serial, u.urun_ad, u.urun_model, u.urun_miktar FROM fd_satis_urunler AS su JOIN fd_urunler AS u ON su.urun_id=u.urun_id WHERE (su.Statu = 'A' and u.Statu = 'A') and su.satis_id=@satis_id", secili_kayit_id);
                for (int i = 0; i < TabloSatirlar.Rows.Count; i++)
                {
                    SatirSatisId = TabloSatirlar.Rows[i]["satis_id"].ToString();
                    SatirSeciliUrun = TabloSatirlar.Rows[i]["urun_id"].ToString();
                    SatirMiktar = TabloSatirlar.Rows[i]["miktar"].ToString();
                    SatirStokMiktar = TabloSatirlar.Rows[i]["urun_miktar"].ToString();
                    SatirIskonto = TabloSatirlar.Rows[i]["iskonto"].ToString();
                    SatirKdv = TabloSatirlar.Rows[i]["kdv"].ToString();
                    SatirKdvDahil = TabloSatirlar.Rows[i]["kdv_dahil"].ToString();
                    SatirBirimFiyat = TabloSatirlar.Rows[i]["birim_fiyat"].ToString();
                    SatirBirimFiyatKdvDahil = TabloSatirlar.Rows[i]["birim_fiyat_kdv_dahil"].ToString();
                    SatirToplamFiyat = TabloSatirlar.Rows[i]["toplam_fiyat"].ToString();
                    SatirToplamFiyatKdvDahil = TabloSatirlar.Rows[i]["toplam_fiyat_kdv_dahil"].ToString();
                    SatirUrunSerial = TabloSatirlar.Rows[i]["urun_serial"].ToString();
                    SatirUrunAd = TabloSatirlar.Rows[i]["urun_ad"].ToString();
                    SatirUrunModel = TabloSatirlar.Rows[i]["urun_model"].ToString();

                    //Satır toplamları hesaplanıyor
                    double ToplamFiyatDouble = double.Parse(Tornavida.FiyatFormatla(SatirToplamFiyat, "sistem"));
                    double IskontoDouble = double.Parse(Tornavida.FiyatFormatla(SatirIskonto, "sistem"));

                    double ToplamIskontoDouble = Tornavida.Bol(ToplamFiyatDouble * IskontoDouble, 100);
                    ToplamIskontoDouble = Math.Round(ToplamIskontoDouble, 2, MidpointRounding.AwayFromZero);
                    double AraToplamDouble = ToplamFiyatDouble - ToplamIskontoDouble;
                    AraToplamDouble = Math.Round(AraToplamDouble, 2, MidpointRounding.AwayFromZero);
                    double ToplamKdvDouble = Tornavida.Bol(AraToplamDouble * int.Parse(SatirKdv), 100);
                    ToplamKdvDouble = Math.Round(ToplamKdvDouble, 2, MidpointRounding.AwayFromZero);
                    double GenelToplamDouble = AraToplamDouble + ToplamKdvDouble;
                    GenelToplamDouble = Math.Round(GenelToplamDouble, 2, MidpointRounding.AwayFromZero);

                    string ToplamIskonto = Tornavida.FiyatFormatla(ToplamIskontoDouble.ToString());
                    string AraToplam = Tornavida.FiyatFormatla(AraToplamDouble.ToString());
                    string ToplamKdv = Tornavida.FiyatFormatla(ToplamKdvDouble.ToString());
                    string GenelToplam = Tornavida.FiyatFormatla(GenelToplamDouble.ToString());

                    dgwUrunler.Rows.Add(SatirSeciliUrun, SatirMiktar, SatirStokMiktar, SatirKdv, SatirIskonto, SatirBirimFiyat, SatirBirimFiyatKdvDahil, SatirToplamFiyat, SatirToplamFiyatKdvDahil, SatirUrunSerial, SatirUrunAd, SatirUrunModel, ToplamIskonto, AraToplam, ToplamKdv, GenelToplam, SatirKdvDahil);
                }
                GenelToplamHesapla();

            }
        }

        private void urun_listele()
        {
            
            DataTable TabloUrunler = new DataTable();
            string UrunArama = txtUrunler.Text.Trim();
            //if (UrunArama.Length < 3) UrunArama = "";
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
            dataSource.Add(new DropdownListe() { Name = "", Value = "0" });
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

            //if (UrunArama != "" && TabloUrunler.Rows.Count > 0) cbUrunler.DroppedDown = true;
            
        }

        private void txtUrunler_KeyUp(object sender, KeyEventArgs e)
        {
            //urun_listele();
            if (txtUrunler.Text != "" && long.TryParse(txtUrunler.Text, out LongParseBag))
            {
                string BarkodUrunID = budak.Sorgu_Scalar("SELECT u.urun_id FROM fd_urunler AS u WHERE Statu = 'A' and  u.urun_serial=" + txtUrunler.Text);
                lblSeciliUrun.Text = BarkodUrunID;
            }
        }

        private void btnStokListesi_Click(object sender, EventArgs e)
        {
            //int SeciliUrun = int.TryParse(lblSeciliUrun.Text, out IntParseBag) ? IntParseBag : 0;
            //frmStokListe frm_stokListe = new frmStokListe(SeciliUrun, DateTime.Today.AddMonths(-3), DateTime.Today.AddMonths(3));
            //frm_stokListe.Show();
        }

        private void cbUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int SeciliUrun = cbUrunler.SelectedIndex > 0 ? int.Parse(cbUrunler.SelectedValue.ToString()) : 0;
            int SeciliUrun = int.TryParse(lblSeciliUrun.Text, out IntParseBag) ? IntParseBag : 0;
            if (SeciliUrun > 0)
            {
                DataTable TabloUrunler = budak.Sorgu_DataTable("SELECT u.urun_id, u.urun_ad, u.urun_marka, u.urun_model, u.urun_serial, u.urun_miktar, u.urun_fiyat, urun_kdv, urun_kdv_dahil, urun_fiyat_kdv_dahil, urun_alis_fiyat, urun_alis_kdv, urun_alis_kdv_dahil, urun_alis_fiyat_kdv_dahil FROM fd_urunler AS u WHERE Statu = 'A' and u.urun_id=@urun_id", SeciliUrun.ToString());
                if (TabloUrunler.Rows.Count > 0)
                {
                    txtUrunAdi.Text = TabloUrunler.Rows[0]["urun_ad"].ToString();
                    txtUrunModeli.Text = TabloUrunler.Rows[0]["urun_model"].ToString();
                    txtUrunSerial.Text = TabloUrunler.Rows[0]["urun_serial"].ToString();
                    txtUrunMiktar.Text = TabloUrunler.Rows[0]["urun_miktar"].ToString();
                    txtUrunKdv.Text = TabloUrunler.Rows[0]["urun_kdv"].ToString();

                    //cbAlisKdvDahil.SelectedIndex = int.Parse(TabloUrunler.Rows[0]["urun_alis_kdv_dahil"].ToString());
                    cbAlisKdvDahil.SelectedIndex = 1;

                    SeciliUrunAlisFiyat = TabloUrunler.Rows[0]["urun_alis_fiyat"].ToString();
                    SeciliUrunAlisFiyatKdvDahil = TabloUrunler.Rows[0]["urun_alis_fiyat_kdv_dahil"].ToString();
                    SeciliUrunSatisFiyat = TabloUrunler.Rows[0]["urun_fiyat"].ToString();
                    SeciliUrunSatisFiyatKdvDahil = TabloUrunler.Rows[0]["urun_fiyat_kdv_dahil"].ToString();

                    cbAlisKdvDahil_SelectedIndexChanged(sender, e);

                    txtUrunler.Text = txtUrunSerial.Text;
                }
            }
            else
            {
                urun_temizle();
            }
        }

        private void urun_temizle()
        {
            txtUrunler.Text = "";
            lblSeciliUrun.Text = "";
            txtStokAdet.Text = "1";
            txtUrunAdi.Text = "";
            txtUrunModeli.Text = "";
            txtUrunSerial.Text = "";
            txtSatisFiyati.Text = "";
            txtUrunMiktar.Text = "";
            txtIskonto.Text = "";
            txtUrunKdv.Text = "";
            txtAlisFiyati.Text = "";
            cbAlisKdvDahil.SelectedIndex = 0;
            cbOdemeTipi.SelectedIndex = 0;

            SeciliUrunAlisFiyat = "";
            SeciliUrunSatisFiyat = "";
            SeciliUrunAlisFiyatKdvDahil = "";
            SeciliUrunSatisFiyatKdvDahil = "";
        }

        private void KompleTemizle()
        {
            urun_temizle();
            lblKalemSayisi.Text = "";
            cbFirmaMusteri.SelectedIndex = 1;
            cbFaturaTip.Text = "";
            txtFaturaNo.Text = "";
            txtFaturaAciklama.Text = "";

            txtUrunler.Text = "";
            txtFirmalar.Text = "";
            lblSeciliFirma.Text = "";
            lblSeciliUrun.Text = "";
            dgwUrunler.Rows.Clear();
            GenelToplamHesapla();

            txtAdSoyad.Text = "";
            txtTcKimlik.Text = "";
            txtCepTel.Text = "";
            txtAdres.Text = "";
            txtVergiDairesi.Text = "";
            txtVergiNo.Text = "";
            txtMecraNo.Text = "";
            chkCariKayit.Checked = islem == "satis" ? chkCariKayit.Checked = true : chkCariKayit.Checked = false;
            cmbMecra.SelectedIndex = islem == "satis" ? 0 : -1;
            cbFaturaTip.SelectedIndex = islem == "satis" ? 3 : 0;

            if (islem == "satis")
            {
                KullanilacakFaturaNo();
            }            
            //lblAdSoyad.Text = "";
            //lblTcKimlik.Text = "";
            //lblCepTel.Text = "";
            //lblAdres.Text = "";
            //lblVD.Text = "";
            //lblVN.Text = "";
        }

        private void btnStokEkle_Click(object sender, EventArgs e)
        {
            //int SeciliUrun = cbUrunler.SelectedIndex > 0 ? int.Parse(cbUrunler.SelectedValue.ToString()) : 0;
            int SeciliUrun = int.TryParse(lblSeciliUrun.Text, out IntParseBag) ? IntParseBag : 0;
            int Miktar = int.TryParse(txtStokAdet.Text, out IntParseBag) ? IntParseBag : 0;
            int MevcutMiktar = int.TryParse(txtUrunMiktar.Text, out IntParseBag) ? IntParseBag : 0;
            string BirimFiyat = txtAlisFiyati.Text.Replace(',', '.').Trim();
            if (!double.TryParse(BirimFiyat, out DoubleParseBag)) BirimFiyat = "0";
            if (SeciliUrun == 0)
            {
                MessageBox.Show("Ürün seçiniz.");
            }
            else if (Miktar == 0)
            {
                MessageBox.Show("Miktar giriniz.");
            }
            else if (BirimFiyat == "0")
            {
                MessageBox.Show("Birim fiyat giriniz.");
            }
            else
            {
                int Iskonto = int.TryParse(txtIskonto.Text, out IntParseBag) ? IntParseBag : 0;
                string KdvOrani = int.TryParse(txtUrunKdv.Text, out IntParseBag) ? IntParseBag.ToString() : "0";

                string BirimFiyatHam = Tornavida.FiyatHesapla(BirimFiyat, KdvOrani, cbAlisKdvDahil.SelectedIndex == 1, false).ToString("R");
                string BirimFiyatKdvDahil = Tornavida.FiyatHesapla(BirimFiyatHam, KdvOrani, false, true).ToString("R");


                double ToplamFiyatDouble;

                if (chkToplamFiyat.Checked && Miktar > 1) // [CE_18.05.2020 23:00] Toplam Fiyat yeni konuldu.
                {
                    ToplamFiyatDouble = double.Parse(BirimFiyatHam.Replace('.', ',')) / Miktar;
                }
                else
                {
                    ToplamFiyatDouble = double.Parse(BirimFiyatHam.Replace('.', ',')) * Miktar;
                }

                ToplamFiyatDouble = Math.Round(ToplamFiyatDouble, 4, MidpointRounding.AwayFromZero);
                string ToplamFiyatHam = ToplamFiyatDouble.ToString("R");

                double ToplamFiyatKdvDahilDouble;
                if (chkToplamFiyat.Checked && Miktar > 1)
                {
                    ToplamFiyatKdvDahilDouble = double.Parse(BirimFiyatKdvDahil.Replace('.', ',')) / Miktar;
                }
                else
                {
                    ToplamFiyatKdvDahilDouble = double.Parse(BirimFiyatKdvDahil.Replace('.', ',')) * Miktar;
                }

                string ToplamFiyatKdvDahil = Math.Round(ToplamFiyatKdvDahilDouble, 4, MidpointRounding.AwayFromZero).ToString();
                //string ToplamFiyatKdvDahil = Tornavida.FiyatHesapla(ToplamFiyatHam, txtUrunKdv.Text, false, true).ToString("R");

                //Satır toplamları hesaplanıyor
                double ToplamIskontoDouble = Tornavida.Bol(ToplamFiyatDouble * Iskonto, 100);
                ToplamIskontoDouble = Math.Round(ToplamIskontoDouble, 4, MidpointRounding.AwayFromZero);
                double AraToplamDouble = ToplamFiyatDouble - ToplamIskontoDouble;
                AraToplamDouble = Math.Round(AraToplamDouble, 4, MidpointRounding.AwayFromZero);
                double ToplamKdvDouble = Tornavida.Bol(AraToplamDouble * int.Parse(KdvOrani), 100);
                ToplamKdvDouble = Math.Round(ToplamKdvDouble, 4, MidpointRounding.AwayFromZero);
                double GenelToplamDouble = AraToplamDouble + ToplamKdvDouble;
                GenelToplamDouble = Math.Round(GenelToplamDouble, 4, MidpointRounding.AwayFromZero);

                BirimFiyatHam = Tornavida.FiyatFormatla(BirimFiyatHam);
                BirimFiyatKdvDahil = Tornavida.FiyatFormatla(BirimFiyatKdvDahil);
                ToplamFiyatHam = Tornavida.FiyatFormatla(ToplamFiyatHam);
                ToplamFiyatKdvDahil = Tornavida.FiyatFormatla(ToplamFiyatKdvDahil);
                string ToplamIskonto = Tornavida.FiyatFormatla(ToplamIskontoDouble.ToString());
                string AraToplam = Tornavida.FiyatFormatla(AraToplamDouble.ToString());
                string ToplamKdv = Tornavida.FiyatFormatla(ToplamKdvDouble.ToString());
                string GenelToplam = Tornavida.FiyatFormatla(GenelToplamDouble.ToString());

                string KdvDahil = cbAlisKdvDahil.SelectedIndex.ToString();
                if (chkToplamFiyat.Checked && Miktar > 1)
                {
                    var Toplam_FiyatHam = BirimFiyatHam;
                    var Toplam_FiyatKdvDahil = BirimFiyatKdvDahil;
                    var Birim_FiyatHam = ToplamFiyatHam;
                    var Birim_FiyatKdvDahil = ToplamFiyatKdvDahil;

                    var Ara_Toplam = BirimFiyatHam;
                    var Genel_Toplam = BirimFiyatKdvDahil;

                    dgwUrunler.Rows.Add(SeciliUrun.ToString(), Miktar.ToString(), MevcutMiktar, txtUrunKdv.Text, Iskonto.ToString(), Birim_FiyatHam, Birim_FiyatKdvDahil, Toplam_FiyatHam, Toplam_FiyatKdvDahil, txtUrunSerial.Text, txtUrunAdi.Text, txtUrunModeli.Text, ToplamIskonto, Ara_Toplam, ToplamKdv, Genel_Toplam, KdvDahil);
                }
                else
                {
                    dgwUrunler.Rows.Add(SeciliUrun.ToString(), Miktar.ToString(), MevcutMiktar, txtUrunKdv.Text, Iskonto.ToString(), BirimFiyatHam, BirimFiyatKdvDahil, ToplamFiyatHam, ToplamFiyatKdvDahil, txtUrunSerial.Text, txtUrunAdi.Text, txtUrunModeli.Text, ToplamIskonto, AraToplam, ToplamKdv, GenelToplam, KdvDahil);
                }

                cbUrunler.SelectedIndex = 0;
                lblSeciliUrun.Text = "";
                cbUrunler_SelectedIndexChanged(null, null);
                GenelToplamHesapla();
            }




            //int Miktar = int.TryParse(txtStokAdet.Text, out IntParseBag) ? IntParseBag : 0;
            //string Islem = ((Button)sender).Tag.ToString();
            //int SeciliUrun = cbUrunler.SelectedIndex > 0 ? int.Parse(cbUrunler.SelectedValue.ToString()) : 0;
            //if (SeciliUrun <= 0)
            //{
            //    MessageBox.Show("Ürün seçiniz.");
            //}
            //else if (Miktar > 0)
            //{
            //    string OnayMesaji = "Seçili üründen stoğa " + Miktar + " adet eklemek istediğinizden emin misiniz?";
            //    if (Islem == "cikar") OnayMesaji = "Seçili üründen stoktan " + Miktar + " adet çıkarmak istediğinizden emin misiniz?";
            //    if (MessageBox.Show(OnayMesaji, "Onay", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            //    {
            //        StokEkleCikar(Miktar, Islem);
            //    }
            //}
            //else{
            //    MessageBox.Show("Sıfırdan büyük bir sayı giriniz.");
            //    txtStokAdet.Focus();
            //}
        }

        private void GenelToplamHesapla()
        {
            double ToplamTutar = 0; double Iskonto = 0; double AraToplam = 0; double ToplamKdv = 0; double GenelToplam = 0;
            double SatirToplamTutar = 0; double SatirIskonto = 0; double SatirAraToplam = 0; double SatirToplamKdv = 0; double SatirGenelToplam = 0;
            int KalemSayisi = 0;
            for (int i = 0; i < dgwUrunler.Rows.Count; i++)
            {
                KalemSayisi++;
                SatirToplamTutar = double.Parse(dgwUrunler.Rows[i].Cells["toplam_fiyat"].Value.ToString().Replace('.', ','));
                SatirIskonto = double.Parse(dgwUrunler.Rows[i].Cells["toplam_iskonto"].Value.ToString().Replace('.', ','));
                SatirAraToplam = double.Parse(dgwUrunler.Rows[i].Cells["ara_toplam"].Value.ToString().Replace('.', ','));
                SatirToplamKdv = double.Parse(dgwUrunler.Rows[i].Cells["toplam_kdv"].Value.ToString().Replace('.', ','));
                SatirGenelToplam = double.Parse(dgwUrunler.Rows[i].Cells["genel_toplam"].Value.ToString().Replace('.', ','));

                ToplamTutar += SatirToplamTutar;
                Iskonto += SatirIskonto;
                AraToplam += SatirAraToplam;
                ToplamKdv += SatirToplamKdv;
                GenelToplam += SatirGenelToplam;
            }
            txtToplamTutar.Text = String.Format("{0:0.00}", ToplamTutar);
            txtToplamIskonto.Text = String.Format("{0:0.00}", Iskonto);
            txtAraToplam.Text = String.Format("{0:0.00}", AraToplam);
            txtToplamKdv.Text = String.Format("{0:0.00}", ToplamKdv);
            txtGenelToplam.Text = String.Format("{0:0.00}", GenelToplam);
            txtOdenenTutar.Text = txtGenelToplam.Text;

            lblKalemSayisi.Text = KalemSayisi > 0 ? KalemSayisi + " kalem" : "";
        }

        private void StokEkleCikar(int miktar, string Islem)
        {
            //int SeciliUrun = cbUrunler.SelectedIndex > 0 ? int.Parse(cbUrunler.SelectedValue.ToString()) : 0;
            int SeciliUrun = int.TryParse(lblSeciliUrun.Text, out IntParseBag) ? IntParseBag : 0;
            int MevcutMiktar = int.Parse(txtStokAdet.Text);
            if (SeciliUrun <= 0)
            {
                MessageBox.Show("Ürün seçiniz.");
            }
            else if (Islem == "cikar" && miktar > MevcutMiktar)
            {
                MessageBox.Show("Seçtiğiniz üründen stokta " + MevcutMiktar + " adet bulunuyor. Dolayısıyla stoktan " + miktar + "  adet çıkarmanız gayet mantıksız.");
            }
            else
            {
                string GirisTarihi = "0"; string CikisTarihi = "0";
                if (Islem == "ekle") GirisTarihi = dtpTarihBaslangic.Value.ToString("yyyy-MM-dd");
                else if (Islem == "cikar") CikisTarihi = dtpTarihBaslangic.Value.ToString("yyyy-MM-dd");
                budak.Sorgu_Calistir("INSERT INTO depo(urun_id, urun_sayisi, giris_tarihi, cikis_tarihi) VALUES(@urun_id, @urun_sayisi, @giris_tarihi, @cikis_tarihi)", SeciliUrun.ToString(), miktar.ToString(), GirisTarihi, CikisTarihi);
                string Aritmetik = Islem == "cikar" ? "-" : "+";
                budak.Sorgu_Calistir("UPDATE urunler SET urun_miktar=urun_miktar" + Aritmetik + "@urun_miktar WHERE urun_id=@urun_id", miktar.ToString(), SeciliUrun.ToString()); 
                cbUrunler_SelectedIndexChanged(null, null);
            }
        }

        private void cbAlisKdvDahil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAlisKdvDahil.SelectedIndex == 1) //Kdv dahil
            {
                txtSatisFiyati.Text = SeciliUrunSatisFiyatKdvDahil;
                txtAlisFiyati.Text = islem == "alis" ? SeciliUrunAlisFiyatKdvDahil : SeciliUrunSatisFiyatKdvDahil;
            }
            else
            {
                txtSatisFiyati.Text = SeciliUrunSatisFiyat;
                txtAlisFiyati.Text = islem == "alis" ? SeciliUrunAlisFiyat : SeciliUrunSatisFiyat;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenelToplamHesapla();
        }

        private void cbUrunler_KeyUp(object sender, KeyEventArgs e)
        {
            txtUrunler.Text = cbUrunler.Text;
            urun_listele();
        }

        public void ListedenUrunSec(string urun_id)
        {
            lblSeciliUrun.Text = urun_id;
        }

        public void ListedenFirmaSec(string firma_id, string firma_adi)
        {
            lblSeciliFirma.Text = firma_id;
            txtFirmalar.Text = firma_adi;
        }

        private void btnUrunSec_Click(object sender, EventArgs e)
        {
            if (frmAnasayfa.DiziFormTag.Contains("urun_sec"))
            {
                frmAnasayfa.TabSec("urun_sec");
            }
            else
            {
                frmUrunSec formUrunSec = new frmUrunSec(uye_id, yetki_duzeyi, this);
                formUrunSec.MdiParent = frmAnasayfa;

                frmAnasayfa.EkranSayisi++;
                TabPage tp = new TabPage();
                tp.Parent = frmAnasayfa.tcMain;
                tp.Text = formUrunSec.Text;
                tp.Tag = "urun_sec";
                tp.Show();

                formUrunSec.Show();
                formUrunSec.EkranNo = frmAnasayfa.EkranSayisi.ToString();
                formUrunSec.frmAnasayfa = frmAnasayfa;
                frmAnasayfa.tcMain.SelectedTab = tp;
                frmAnasayfa.DiziFormlar.Add(formUrunSec);
                frmAnasayfa.DiziFormTag.Add("urun_sec");
            }
        }

        private void lblSeciliUrun_TextChanged(object sender, EventArgs e)
        {
            //txtUrunler.Text = cbUrunler.Text;
            cbUrunler_SelectedIndexChanged(null, null);
        }

        private void btnFirmaSec_Click(object sender, EventArgs e)
        {
            if (frmAnasayfa.DiziFormTag.Contains("firma_sec"))
            {
                frmAnasayfa.TabSec("firma_sec");
            }
            else
            {
                string musteri_firma = cbFirmaMusteri.SelectedIndex > 0 ? "musteri" : "firma";
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

        private int CariAlanKontrol()
        {
            int CariAlan_Kontrol = 0;
            if (chkCariKayit.Checked)
            {
                if (txtAdSoyad.Text == "")
                {
                    MessageBox.Show("Ad Soyad alanı boş bırakılamaz.");
                }
                else if (txtCepTel.Text == "   -   -  -" || txtCepTel.Text == "")
                {
                    MessageBox.Show("Geçerli bir numara giriniz.");
                }
                else if (txtAdres.Text == "")
                {
                    MessageBox.Show("Adres alanı boş bırakılamaz.");
                }
                else if (cmbMecra.Text == "" && islem =="satis")
                {
                    MessageBox.Show("Mecra seçiniz.");
                }
                //else if (txtMecraNo.Text == "" && cmbMecra.SelectedIndex < 7 && islem == "satis") //(cmbMecra.Text != "Hiçbiri")
                //{
                //    MessageBox.Show("Mecra No giriniz.");
                //}
                else if (cbFirmaMusteri.SelectedIndex == 0 && txtVergiDairesi.Text == "")
                {
                    MessageBox.Show("Vergi Dairesi giriniz.");    
                }
                else if (cbFirmaMusteri.SelectedIndex == 0 && txtVergiNo.Text == "")
                {
                    MessageBox.Show("Vergi No giriniz.");
                }
                else
                {
                    CariAlan_Kontrol = 1;
                }
            }
            return CariAlan_Kontrol;
        }
        private void btnSatisTamamla_Click(object sender, EventArgs e)
        {
            if (dgwUrunler.Rows.Count == 0)
            {
                MessageBox.Show("Lütfen listeye ürün ekleyiniz.");
            }
            else if (!chkCariKayit.Checked && txtFirmalar.Text == "" && lblSeciliFirma.Text == "")
            {
                //if (lblSeciliFirma.Text == "" || lblSeciliFirma.Text == "0")
                //{
                    MessageBox.Show("Lütfen firma/müşteri seçiniz.");
                //}         
            }
            else if (txtOdenenTutar.Text == "")
            {
                MessageBox.Show("Lütfen ödenen tutarı giriniz. Ödeme yapılmamışsa 0 girin.");
            }
            else if (txtFaturaNo.Text == "")
            {
                MessageBox.Show("Fatura No giriniz.");
            }
            else
            {
                int CariAlan_kontrol = 0;
                CariAlan_kontrol = chkCariKayit.Checked ? CariAlanKontrol() : 2;
                if (CariAlan_kontrol == 0)
                {
                    MessageBox.Show("Müşteri/Firma bilgilerini gözden geçiriniz.");
                }
                else
                {
                    string SatisTip = islem;
                    string SatisTarih = dtpTarihBaslangic.Value.ToString("yyyy-MM-dd HH:mm");
                    DateTime SatisTarih_Date = Tornavida.TarihToDateTime(SatisTarih);
                    string ToplamFiyat = Tornavida.FiyatFormatla(txtToplamTutar.Text);
                    string ToplamFiyatKdvDahil = Tornavida.FiyatFormatla(txtGenelToplam.Text);
                    string OdenenTutar = Tornavida.FiyatFormatla(txtOdenenTutar.Text);
                    string SeciliBelgeTipi = cbFaturaTip.SelectedValue.ToString();
                    string SeciliOdemeTipi = cbOdemeTipi.SelectedValue.ToString();
                    string FM_Tip = cbFirmaMusteri.SelectedIndex > 0 ? "musteri" : "firma";

                    int SatisId = 0;
                    if (lblSeciliKayit.Text != "")
                    {
                        int Etki = budak.Sorgu_Calistir("UPDATE fd_satislar SET musteri_id=@musteri_id, tarih=@tarih, toplam_fiyat=@toplam_fiyat, toplam_fiyat_kdv_dahil=@toplam_fiyat_kdv_dahil, belge=@belge, fatura_no=@fatura_no, fatura_aciklama=@fatura_aciklama, odenen_tutar=@odenen_tutar, odeme_tipi=@odeme_tipi, mecra_no = @mecra_no WHERE satis_id=@satis_id", lblSeciliFirma.Text, SatisTarih_Date.ToString(), ToplamFiyat, ToplamFiyatKdvDahil, SeciliBelgeTipi, txtFaturaNo.Text, txtFaturaAciklama.Text, OdenenTutar, SeciliOdemeTipi, txtMecraNo.Text, lblSeciliKayit.Text);
                        int EtkiCari = budak.Sorgu_Calistir("update fd_musteriler set ad_soyad = @ad_soyad, tip = @tip, tc_kimlik = @tc_kimlik, cep_Tel = @cep_tel, adres = @adres, vergi_dairesi = @vergi_dairesi, vergi_no = @vergi_no, geldigi_mecra = @geldigi_mecra where musteri_id = @musteri_id", txtAdSoyad.Text, FM_Tip, txtTcKimlik.Text, txtCepTel.Text, txtAdres.Text, txtVergiDairesi.Text, txtVergiNo.Text, cmbMecra.Text, lblSeciliFirma.Text);
                        SatisId = Etki > 0 ? int.Parse(lblSeciliKayit.Text) : 0;

                        if (EtkiCari < 1)
                        {
                            MessageBox.Show("Cari kaydı güncellenemedi. Tekrar deneyiniz.");
                        }
                    }
                    else
                    {
                        string KayitliFatura = "";
                        if (SatisTip == "satis")
                        {
                            KayitliFatura = budak.Sorgu_Scalar(@"select top 1 fatura_no from fd_satislar where Statu = 'A' and fatura_no ='" + txtFaturaNo.Text + "'");
                        }

                        if (KayitliFatura == txtFaturaNo.Text)
                        {
                            MessageBox.Show("Aynı Fatura No birden fazla kez eklenemez.\n\rFatura No 'yu değiştirerek yeniden deneyiniz.");
                        }                      

                        int EklenenCari_ID = 0;
                        EklenenCari_ID = budak.Sorgu_Calistir_Eklenen_Id_Dondur("insert into fd_musteriler (ad_soyad, tc_kimlik, cep_tel, adres, tip, vergi_no, vergi_dairesi, geldigi_mecra) values ('" + txtAdSoyad.Text + "','" + txtTcKimlik.Text + "','" + txtCepTel.Text + "','" + txtAdres.Text + "','" + FM_Tip + "','" + txtVergiNo.Text + "','" + txtVergiDairesi.Text + "','" + cmbMecra.Text + "')");
                        lblSeciliFirma.Text = EklenenCari_ID.ToString();

                        if (EklenenCari_ID == 0)
                        {
                            MessageBox.Show("Cari kaydı eklenemedi. Kayıt verileri veya sorgu hatalı olabilir.");
                        }

                        // Cari kaydı eklenemezse sorup o şekilde fatura kaydını tamamlasın yada dbaşka bi yöntem bulunabilir.
                        SatisId = budak.Sorgu_Calistir_Eklenen_Id_Dondur("INSERT INTO fd_satislar(tip, uye_id, musteri_id, tarih, toplam_fiyat, toplam_fiyat_kdv_dahil, belge, fatura_no, fatura_aciklama, odenen_tutar, odeme_tipi, mecra_no) VALUES(@tip, @uye_id, @musteri_id, @tarih, @toplam_fiyat, @toplam_fiyat_kdv_dahil, @belge, @fatura_no, @fatura_aciklama, @odenen_tutar, @odeme_tipi, @mecra_no)", SatisTip, uye_id.ToString(), lblSeciliFirma.Text, SatisTarih_Date.ToString(), ToplamFiyat, ToplamFiyatKdvDahil, SeciliBelgeTipi, txtFaturaNo.Text, txtFaturaAciklama.Text, OdenenTutar, SeciliOdemeTipi, txtMecraNo.Text);
                        //}
                    }

                    //}
                    if (SatisId <= 0)
                    {
                        MessageBox.Show("Kayıt eklenemedi. Lütfen bilgilerinizi kontrol edip tekrar deneyin.");
                    }
                    else
                    {
                        //Para alış-veriş kaydı ekleniyor.
                        double OdenenTutarDouble = double.Parse(Tornavida.FiyatFormatla(OdenenTutar, "sistem"));

                        string OdemeTip = SatisTip == "satis" ? "para_alis" : "para_veris";
                        if (lblSeciliKayit.Text != "")
                        {
                            //budak.Sorgu_Calistir("DELETE FROM satislar WHERE tip=@tip AND odeme_satis_id=@odeme_satis_id", OdemeTip, SatisId.ToString());
                            budak.Sorgu_Calistir("update fd_satislar set Statu = 'X' WHERE tip=@tip AND odeme_satis_id=@odeme_satis_id", OdemeTip, SatisId.ToString());
                        }

                        if (OdenenTutarDouble > 0)
                        {
                            if (lblSeciliKayit.Text != "")
                            {
                                //budak.Sorgu_Calistir("DELETE FROM satislar WHERE tip=@tip AND odeme_satis_id=@odeme_satis_id", OdemeTip, SatisId.ToString());
                                budak.Sorgu_Calistir("update fd_satislar set Statu = 'X' WHERE tip=@tip AND odeme_satis_id=@odeme_satis_id", OdemeTip, SatisId.ToString());
                            }
                            budak.Sorgu_Calistir("INSERT INTO fd_satislar(tip, uye_id, musteri_id, tarih, toplam_fiyat, toplam_fiyat_kdv_dahil, belge, fatura_no, fatura_aciklama, odenen_tutar, odeme_tipi, odeme_satis_id) VALUES(@tip, @uye_id, @musteri_id, @tarih, @toplam_fiyat, @toplam_fiyat_kdv_dahil, @belge, @fatura_no, @fatura_aciklama, @odenen_tutar, @odeme_tipi, @odeme_satis_id)", OdemeTip, uye_id.ToString(), lblSeciliFirma.Text, SatisTarih_Date.ToString(), OdenenTutar, OdenenTutar, "", "", "", OdenenTutar, SeciliOdemeTipi, SatisId.ToString());
                        }

                        //Güncelleme için eski satış ürün kayıtları siliniyor
                        if (lblSeciliKayit.Text != "")
                        {
                            DataTable TabloEskiUrunler = budak.Sorgu_DataTable("SELECT su_id, urun_id, miktar FROM fd_satis_urunler WHERE Statu = 'A' and satis_id=" + SatisId.ToString());
                            for (int u = 0; u < TabloEskiUrunler.Rows.Count; u++)
                            {
                                string SatirId = TabloEskiUrunler.Rows[u]["su_id"].ToString();
                                string SatirSuUrunId = TabloEskiUrunler.Rows[u]["urun_id"].ToString();
                                int EskiUrunMiktari = int.Parse(TabloEskiUrunler.Rows[u]["miktar"].ToString());
                                //budak.Sorgu_Calistir("DELETE FROM satis_urunler WHERE su_id=@su_id", SatirId);
                                budak.Sorgu_Calistir("update fd_satis_urunler set Statu = 'X' WHERE su_id=@su_id", SatirId);
                                string GeriAritmetik = SatisTip == "satis" ? "+" : "-";
                                budak.Sorgu_Calistir("UPDATE fd_urunler SET urun_miktar=urun_miktar" + GeriAritmetik + "@urun_miktar WHERE urun_id=@urun_id", EskiUrunMiktari.ToString(), SatirSuUrunId);
                            }
                        }
                        string SatirUrunId = ""; string SatirMiktar = ""; string SatirIskonto = ""; string SatirKdv = ""; string SatirKdvDahil = ""; string SatirBirimFiyat = ""; string SatirBirimFiyatKdvDahil = ""; string SatirToplamFiyat = ""; string SatirToplamFiyatKdvDahil = "";
                        for (int i = 0; i < dgwUrunler.Rows.Count; i++)
                        {
                            SatirUrunId = dgwUrunler.Rows[i].Cells["urun_id"].Value.ToString();
                            SatirMiktar = dgwUrunler.Rows[i].Cells["miktar"].Value.ToString();
                            SatirIskonto = dgwUrunler.Rows[i].Cells["iskonto"].Value.ToString();
                            SatirKdv = dgwUrunler.Rows[i].Cells["kdv"].Value.ToString();
                            SatirKdvDahil = dgwUrunler.Rows[i].Cells["kdv_dahil"].Value.ToString();
                            SatirBirimFiyat = Tornavida.FiyatFormatla(dgwUrunler.Rows[i].Cells["birim_fiyat"].Value.ToString());
                            SatirBirimFiyatKdvDahil = Tornavida.FiyatFormatla(dgwUrunler.Rows[i].Cells["birim_fiyat_kdv_dahil"].Value.ToString());
                            SatirToplamFiyat = Tornavida.FiyatFormatla(dgwUrunler.Rows[i].Cells["toplam_fiyat"].Value.ToString());
                            SatirToplamFiyatKdvDahil = Tornavida.FiyatFormatla(dgwUrunler.Rows[i].Cells["toplam_fiyat_kdv_dahil"].Value.ToString());

                            budak.Sorgu_Calistir("INSERT INTO fd_satis_urunler(satis_id, urun_id, miktar, iskonto, kdv, kdv_dahil, birim_fiyat, birim_fiyat_kdv_dahil, toplam_fiyat, toplam_fiyat_kdv_dahil) VALUES(@satis_id, @urun_id, @miktar, @iskonto, @kdv, @kdv_dahil, @birim_fiyat, @birim_fiyat_kdv_dahil, @toplam_fiyat, @toplam_fiyat_kdv_dahil)", SatisId.ToString(), SatirUrunId, SatirMiktar, SatirIskonto, SatirKdv, SatirKdvDahil, SatirBirimFiyat, SatirBirimFiyatKdvDahil, SatirToplamFiyat, SatirToplamFiyatKdvDahil);
                            string Aritmetik = SatisTip == "satis" ? "-" : "+";
                            budak.Sorgu_Calistir("UPDATE fd_urunler SET urun_miktar=urun_miktar" + Aritmetik + "@urun_miktar WHERE urun_id=@urun_id", SatirMiktar, SatirUrunId);
                        }
                        string IslemAdi = islem == "satis" ? "Satış" : "Alım";
                        if (lblSeciliKayit.Text != "")
                        {
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(IslemAdi + " işlemi başarıyla kaydedilmiştir.");
                            KompleTemizle();
                        }
                    }
                }
            }
        }

        private void dgwUrunler_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                menuSag.Show(dgwUrunler.PointToScreen(e.Location));
            }
        }

        private void tsmiListeyiTemizle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Listeyi temizlemek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                KompleTemizle();
                GenelToplamHesapla();
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
                GenelToplamHesapla();
                //cbUrunler_SelectedIndexChanged(null, null);
            }
        }

        public frmAnasayfa frmAnasayfa;
        public string EkranNo = "";
        private void frmUrunYonetimi_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAnasayfa.DiziFormlar.Remove(this);
            if (secili_kayit_id != "")
            {
                frmAnasayfa.DiziFormTag.Remove(islem + "_duzenle");
                frmAnasayfa.TabCikar(islem + "_duzenle");
                if (formMuhasebeHareketleri != null)
                {
                    formMuhasebeHareketleri.hareket_listele();
                }
                else if (formUrunHareketleri != null)
                {
                    formUrunHareketleri.hareket_listele();
                }
            }
            else
            {
                frmAnasayfa.DiziFormTag.Remove(islem);
                frmAnasayfa.TabCikar(islem);
            }
        }

        private void chkCariKayit_CheckedChanged(object sender, EventArgs e)
        {
            if (islem == "satis")
            {
                if (btnFirmaSec.Enabled)
                {
                    btnFirmaSec.Enabled = false;
                    musteri_bilgileri_durum_true();
                }
                else
                {
                    btnFirmaSec.Enabled = true;
                    musteri_bilgileri_durum_false();
                }
            }
            else
            {

                if (chkCariKayit.Checked == false)
                {
                    btnFirmaSec.Enabled = true;
                    musteri_bilgileri_durum_false();
                }
                else
                {
                    btnFirmaSec.Enabled = false;
                    musteri_bilgileri_durum_true();

                }
            }

        }

        private void cbFirmaMusteri_TextChanged(object sender, EventArgs e)
        {
            string FmTip = cbFirmaMusteri.Text;

            //if (islem == "satis")
            //{
                if (FmTip == "Firma")
                {
                    lblVD.Visible = true;
                    lblVN.Visible = true;
                    txtVergiDairesi.Visible = true;
                    txtVergiNo.Visible = true;
                }
                else
                {
                    lblVD.Visible = false;
                    lblVN.Visible = false;
                    txtVergiDairesi.Visible = false;
                    txtVergiNo.Visible = false;
                }
            //}
        }

        private void musteri_bilgileri()
        {
            txtAdSoyad.Visible = false;
            txtTcKimlik.Visible = false;
            txtCepTel.Visible = false;
            txtAdres.Visible = false;
            txtVergiDairesi.Visible = false;
            txtVergiNo.Visible = false;
            chkCariKayit.Visible = false;

            lblAdSoyad.Visible = false;
            lblTcKimlik.Visible = false;
            lblCepTel.Visible = false;
            lblAdres.Visible = false;
            lblVD.Visible = false;
            lblVN.Visible = false;
        }

        private void musteri_bilgileri_durum_false()
        {
            txtAdSoyad.Enabled = false;
            txtTcKimlik.Enabled = false;
            txtCepTel.Enabled = false;
            txtAdres.Enabled = false;
            txtVergiDairesi.Enabled = false;
            txtVergiNo.Enabled = false;

            lblAdSoyad.Enabled = false;
            lblTcKimlik.Enabled = false;
            lblCepTel.Enabled = false;
            lblAdres.Enabled = false;
            lblVD.Enabled = false;
            lblVN.Enabled = false;
        }
        private void musteri_bilgileri_durum_true()
        {
            txtAdSoyad.Enabled = true;
            txtTcKimlik.Enabled = true;
            txtCepTel.Enabled = true;
            txtAdres.Enabled = true;
            txtVergiDairesi.Enabled = true;
            txtVergiNo.Enabled = true;

            lblAdSoyad.Enabled = true;
            lblTcKimlik.Enabled = true;
            lblCepTel.Enabled = true;
            lblAdres.Enabled = true;
            lblVD.Enabled = true;
            lblVN.Enabled = true;
        }
    }
}
