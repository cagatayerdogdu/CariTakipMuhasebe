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
    public partial class frmParaAlVer : Form
    {
        int IntParseBag = 0; long LongParseBag = 0; double DoubleParseBag = 0;
        DAL budak; Fonksiyonlar Tornavida;
        public int uye_id;
        string yetki_duzeyi;
        string islem = "";
        string secili_kayit_id = "";
        frmMuhasebeHareketleri formMuhasebeHareketleri = null;
        public frmParaAlVer(int _uye_id, string _yetki_duzeyi, string _islem, string _secili_kayit_id = "")
        {
            InitializeComponent();
            uye_id = _uye_id;
            yetki_duzeyi = _yetki_duzeyi;
            islem = _islem;
            secili_kayit_id = _secili_kayit_id;
        }
        public frmParaAlVer(int _uye_id, string _yetki_duzeyi, string _islem, frmMuhasebeHareketleri _formMuhasebeHareketleri, string _secili_kayit_id = "")
        {
            InitializeComponent();
            uye_id = _uye_id;
            yetki_duzeyi = _yetki_duzeyi;
            islem = _islem;
            secili_kayit_id = _secili_kayit_id;
            formMuhasebeHareketleri = _formMuhasebeHareketleri;
            if (secili_kayit_id != "")
            {
                btnUrunKaydet.Text = "GÜNCELLE";
            }
        }

        private void frmParaAlVer_Load(object sender, EventArgs e)
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

            var dataSourceFirmaMusteri = new List<DropdownListe>();
            dataSourceFirmaMusteri.Add(new DropdownListe() { Name = "Firma", Value = "firma" });
            dataSourceFirmaMusteri.Add(new DropdownListe() { Name = "Müşteri", Value = "musteri" });
            cbFirmaMusteri.DataSource = dataSourceFirmaMusteri;
            cbFirmaMusteri.DisplayMember = "Name";
            cbFirmaMusteri.ValueMember = "Value";

            var dataSourceOdemeTipi = new List<DropdownListe>();
            dataSourceOdemeTipi.Add(new DropdownListe() { Name = "Nakit", Value = "nakit" });
            dataSourceOdemeTipi.Add(new DropdownListe() { Name = "Kredi Kartı", Value = "kredi_karti" });
            dataSourceOdemeTipi.Add(new DropdownListe() { Name = "Çek", Value = "cek" });
            dataSourceOdemeTipi.Add(new DropdownListe() { Name = "Senet", Value = "senet" });
            cbOdemeTipi.DataSource = dataSourceOdemeTipi;
            cbOdemeTipi.DisplayMember = "Name";
            cbOdemeTipi.ValueMember = "Value";

            lblSeciliFirma.Text = "";
            cbFirmaMusteri.SelectedIndex = 0;
            if (islem == "para_veris")
            {
                this.Text = "PARA VER";
                //cbFirmaMusteri.SelectedIndex = 1;
            }

            dtpTarihBaslangic.Value = DateTime.Now;

            if (secili_kayit_id != "") kayit_yukle();
        }

        private void kayit_yukle()
        {
            string SatirSatisId = ""; string SatirSeciliUrun = ""; string SatirMiktar = ""; string SatirIskonto = ""; string SatirKdv = ""; string SatirKdvDahil = ""; string SatirBirimFiyat = ""; string SatirBirimFiyatKdvDahil = ""; string SatirToplamFiyat = ""; string SatirToplamFiyatKdvDahil = ""; string SatirUrunSerial = ""; string SatirUrunAd = ""; string SatirUrunModel = ""; long SatirTarihLong = 0; string SatirTarih = "";

            //DataTable TabloSatis = budak.Sorgu_DataTable("SELECT s.tip, s.uye_id, s.musteri_id, (s.tarih*1) AS tarih, s.toplam_fiyat, s.toplam_fiyat_kdv_dahil, s.belge, s.fatura_no, s.fatura_aciklama, s.odenen_tutar, s.odeme_tipi, m.tip AS musteri_tip, m.ad_soyad AS musteri_ad FROM satislar AS s JOIN musteriler AS m ON s.musteri_id=m.musteri_id WHERE s.satis_id=@satis_id", secili_kayit_id);
            DataTable TabloSatis = budak.Sorgu_DataTable("SELECT s.tip, s.uye_id, s.musteri_id, (s.tarih) AS tarih, s.toplam_fiyat, s.toplam_fiyat_kdv_dahil, s.belge, s.fatura_no, s.fatura_aciklama, s.odenen_tutar, s.odeme_tipi, m.tip AS musteri_tip, m.ad_soyad AS musteri_ad FROM fd_satislar AS s JOIN fd_musteriler AS m ON s.musteri_id=m.musteri_id WHERE (s.Statu = 'A' and m.Statu = 'A') and s.satis_id=@satis_id", secili_kayit_id);

            string MusteriTip = "";
            if (TabloSatis.Rows.Count > 0)
            {
                lblSeciliKayit.Text = secili_kayit_id;
                islem = TabloSatis.Rows[0]["tip"].ToString();
                if (islem == "para_veris")
                {
                    this.Text = "PARA VER";
                }
                this.Text += " - DÜZENLE";
                MusteriTip = TabloSatis.Rows[0]["musteri_tip"].ToString();
                if (MusteriTip == "musteri") cbFirmaMusteri.SelectedIndex = 1;
                else cbFirmaMusteri.SelectedIndex = 0;
                lblSeciliFirma.Text = TabloSatis.Rows[0]["musteri_id"].ToString();
                txtFirmalar.Text = TabloSatis.Rows[0]["musteri_ad"].ToString();
                //SatirTarihLong = long.Parse(TabloSatis.Rows[0]["tarih"].ToString());
                dtpTarihBaslangic.Value = Tornavida.TarihToDateTime(TabloSatis.Rows[0]["tarih"].ToString()); 
                //Tornavida.TarihToDateTime(SatirTarihLong.ToString()); // [CE_01.02.2020 01:13] // Eski string formatta olduğu için fonksiyondan çevirip alınıyormuş datetime tipinde fonk.a gerek olmadığı için fonk.da bu alanı atlatacak kod yazdım burayı da bu haliyle revize ettim.
                                
                //cbFaturaTip.SelectedValue = TabloSatis.Rows[0]["belge"].ToString();
                //txtFaturaNo.Text = TabloSatis.Rows[0]["fatura_no"].ToString();
                txtFaturaAciklama.Text = TabloSatis.Rows[0]["fatura_aciklama"].ToString();
                txtOdenenTutar.Text = TabloSatis.Rows[0]["odenen_tutar"].ToString();
                cbOdemeTipi.SelectedValue = TabloSatis.Rows[0]["odeme_tipi"].ToString();

                MusteriFirmaBorcAlacakGetir(islem);

            }
        }

        private void btnFirmaSec_Click(object sender, EventArgs e)
        {

            if (frmAnasayfa.DiziFormTag.Contains("firma_sec"))
            {
                frmAnasayfa.TabSec("firma_sec");
            }
            else
            {
                string musteri_firma = cbFirmaMusteri.SelectedValue.ToString();
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

        public void ListedenFirmaSec(string firma_id, string firma_adi)
        {
            lblSeciliFirma.Text = firma_id; //Müşteri/Firma id alınıyor
            txtFirmalar.Text = firma_adi;
            MusteriFirmaBorcAlacakGetir(islem);
        }

        private void btnUrunKaydet_Click(object sender, EventArgs e)
        {
            string SatisTip = islem;
            string SatisTarih = dtpTarihBaslangic.Value.ToString("yyyy-MM-dd HH:mm");
            DateTime SatisTarih_Date = Tornavida.TarihToDateTime(SatisTarih);
            string OdenenTutar = Tornavida.FiyatFormatla(txtOdenenTutar.Text);
            double OdenenTutarDouble = double.Parse(Tornavida.FiyatFormatla(OdenenTutar, "sistem"));
            string SeciliOdemeTipi = cbOdemeTipi.SelectedValue.ToString();
            if (lblSeciliFirma.Text == "" || lblSeciliFirma.Text == "0")
            {
                MessageBox.Show("Lütfen firma/müşteri seçiniz.");
            }
            else if (OdenenTutarDouble <= 0)
            {
                MessageBox.Show("Lütfen ödenen tutarı giriniz.");
            }
            else
            {
                //int SatisId = budak.Sorgu_Calistir_Eklenen_Id_Dondur("INSERT INTO satislar(tip, uye_id, musteri_id, tarih, toplam_fiyat, toplam_fiyat_kdv_dahil, belge, fatura_no, fatura_aciklama, odenen_tutar, odeme_tipi) VALUES(@tip, @uye_id, @musteri_id, @tarih, @toplam_fiyat, @toplam_fiyat_kdv_dahil, @belge, @fatura_no, @fatura_aciklama, @odenen_tutar, @odeme_tipi)", SatisTip, uye_id.ToString(), lblSeciliFirma.Text, SatisTarih, OdenenTutar, OdenenTutar, "", "", txtFaturaAciklama.Text, OdenenTutar, SeciliOdemeTipi);

                int SatisId = 0;
                if (lblSeciliKayit.Text != "lblSeciliKayit")
                {
                    int Etki = budak.Sorgu_Calistir("UPDATE fd_satislar SET musteri_id=@musteri_id, tarih=@tarih, toplam_fiyat=@toplam_fiyat, toplam_fiyat_kdv_dahil=@toplam_fiyat_kdv_dahil, belge=@belge, fatura_no=@fatura_no, fatura_aciklama=@fatura_aciklama, odenen_tutar=@odenen_tutar, odeme_tipi=@odeme_tipi WHERE satis_id=@satis_id", lblSeciliFirma.Text, SatisTarih_Date.ToString(), OdenenTutar, OdenenTutar, "", "", txtFaturaAciklama.Text, OdenenTutar, SeciliOdemeTipi, lblSeciliKayit.Text);
                    SatisId = Etki > 0 ? int.Parse(lblSeciliKayit.Text) : 0;

                    //İlişkili alış/satış kaydı varsa, güncelleniyor.
                    //string IliskiliSatisId = budak.Sorgu_Scalar("SELECT odeme_satis_id FROM satislar WHERE satis_id=" + lblSeciliKayit.Text + " LIMIT 1");
                    string IliskiliSatisId = budak.Sorgu_Scalar("SELECT top 1 odeme_satis_id FROM fd_satislar WHERE Statu = 'A' and satis_id=" + lblSeciliKayit.Text);
                    if (IliskiliSatisId != "" && IliskiliSatisId != "0")
                    {
                        budak.Sorgu_Calistir("UPDATE fd_satislar SET odenen_tutar=@odenen_tutar WHERE satis_id=@satis_id", OdenenTutar, IliskiliSatisId);
                    }

                }
                else
                {
                    SatisId = budak.Sorgu_Calistir_Eklenen_Id_Dondur("INSERT INTO fd_satislar(tip, uye_id, musteri_id, tarih, toplam_fiyat, toplam_fiyat_kdv_dahil, belge, fatura_no, fatura_aciklama, odenen_tutar, odeme_tipi) VALUES(@tip, @uye_id, @musteri_id, @tarih, @toplam_fiyat, @toplam_fiyat_kdv_dahil, @belge, @fatura_no, @fatura_aciklama, @odenen_tutar, @odeme_tipi)", SatisTip, uye_id.ToString(), lblSeciliFirma.Text, SatisTarih_Date.ToString(), OdenenTutar, OdenenTutar, "", "", txtFaturaAciklama.Text, OdenenTutar, SeciliOdemeTipi);
                }

                if (SatisId <= 0)
                {
                    MessageBox.Show("Kayıt eklenemedi. Lütfen bilgilerinizi kontrol edip tekrar deneyin.");
                }
                else
                {
                    this.Close();
                }
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
            }
            else
            {
                frmAnasayfa.DiziFormTag.Remove(islem);
                frmAnasayfa.TabCikar(islem);
            }
        }

        private void MusteriFirmaBorcAlacakGetir(string _islem)
        {
            string islem = _islem;
            DataTable TabloSatisKalanAlacak;
            if (islem == "para_alis")
            {
                if (lblSeciliFirma.Text != "")
                {
                    TabloSatisKalanAlacak = budak.Sorgu_DataTable("select musteri_id, isnull((select sum(toplam_fiyat_kdv_dahil) from fd_satislar where Statu = 'A' and tip = 'satis' and musteri_id = s.musteri_id),0) toplam_satis_tutari_kdv_dahil, isnull((select sum(odenen_tutar) from fd_satislar  where Statu = 'A' and tip = 'para_alis' and musteri_id = s.musteri_id),0) toplam_alinan_tutar, isnull((select sum(toplam_fiyat_kdv_dahil) from fd_satislar where Statu = 'A' and tip = 'satis' and musteri_id = s.musteri_id) - (select sum(odenen_tutar) from fd_satislar where Statu = 'A' and tip = 'para_alis' and musteri_id = s.musteri_id),0) Kalan_Alacak_Tutari from fd_satislar s where musteri_id = @musteri_id /*satis_id = 25*/ group by musteri_id", lblSeciliFirma.Text);
                }
                else
                {
                    TabloSatisKalanAlacak = budak.Sorgu_DataTable("select musteri_id, isnull((select sum(toplam_fiyat_kdv_dahil) from fd_satislar  where Statu = 'A' and tip = 'satis' and musteri_id = s.musteri_id),0) toplam_satis_tutari_kdv_dahil, isnull((select sum(odenen_tutar) from fd_satislar  where Statu = 'A' and tip = 'para_alis' and musteri_id = s.musteri_id),0) toplam_alinan_tutar, isnull((select sum(toplam_fiyat_kdv_dahil) from fd_satislar  where Statu = 'A' and tip = 'satis' and musteri_id = s.musteri_id) - (select sum(odenen_tutar) from fd_satislar  where Statu = 'A' and tip = 'para_alis' and musteri_id = s.musteri_id),0) Kalan_Alacak_Tutari from fd_satislar s where satis_id = @satis_id /*musteri_id = 25*/ group by musteri_id", secili_kayit_id);
                }

                //for (int i = 0; i < TabloSatisKalanAlacak.Rows.Count; i++)
                //{
                //    // tablodaki kolonların hepsi null ise veri getirmemesi için yapmıştım. Vazgeçtim null olanları 0 yazıp geçiyorum. [CE_12.02.2020 20:42]
                //    if (!TabloSatisKalanAlacak.Rows[i].IsNull("toplam_satis_tutari_kdv_dahil") && !TabloSatisKalanAlacak.Rows[i].IsNull("toplam_alinan_tutar") && !TabloSatisKalanAlacak.Rows[i].IsNull("Kalan_Alacak_Tutari"))
                //    {
                //        ToplamSonucGetir_VisibleTrue();

                //        lblToplamSatisTutariSonuc.Text = TabloSatisKalanAlacak.Rows[0]["toplam_satis_tutari_kdv_dahil"].ToString() + " ₺";
                //        lblToplamAlinanTutarSonuc.Text = TabloSatisKalanAlacak.Rows[0]["toplam_alinan_tutar"].ToString() + " ₺";
                //        lblToplamKalanAlacakSonuc.Text = TabloSatisKalanAlacak.Rows[0]["Kalan_Alacak_Tutari"].ToString() + " ₺";
                //    }
                //}

                if (TabloSatisKalanAlacak.Rows.Count > 0)
                {
                    ToplamSonucGetir_VisibleTrue();

                    lblToplamSatisTutariSonuc.Text = Tornavida.FiyatFormatla(TabloSatisKalanAlacak.Rows[0]["toplam_satis_tutari_kdv_dahil"].ToString()) + " ₺";
                    lblToplamAlinanTutarSonuc.Text = Tornavida.FiyatFormatla(TabloSatisKalanAlacak.Rows[0]["toplam_alinan_tutar"].ToString()) + " ₺";
                    lblToplamKalanAlacakSonuc.Text = Tornavida.FiyatFormatla(TabloSatisKalanAlacak.Rows[0]["Kalan_Alacak_Tutari"].ToString()) + " ₺";
                }
            }
            if (islem == "para_veris")
            {
                if (lblSeciliFirma.Text != "")
                {
                    TabloSatisKalanAlacak = budak.Sorgu_DataTable("select musteri_id, isnull((select sum(toplam_fiyat_kdv_dahil) from fd_satislar  where Statu = 'A' and tip = 'alis' and musteri_id = s.musteri_id),0) toplam_alis_tutari_kdv_dahil, isnull((select sum(odenen_tutar) from fd_satislar  where Statu = 'A' and tip = 'para_veris' and musteri_id = s.musteri_id),0) toplam_verilen_tutar, isnull((select sum(toplam_fiyat_kdv_dahil) from fd_satislar  where Statu = 'A' and tip = 'alis' and musteri_id = s.musteri_id) - (select sum(odenen_tutar) from fd_satislar  where Statu = 'A' and tip = 'para_veris' and musteri_id = s.musteri_id),0) Kalan_Borc_Tutari from fd_satislar s where musteri_id = @musteri_id /*satis_id = 25*/ group by musteri_id", lblSeciliFirma.Text);
                }
                else
                {
                    TabloSatisKalanAlacak = budak.Sorgu_DataTable("select musteri_id, isnull((select sum(toplam_fiyat_kdv_dahil) from fd_satislar  where Statu = 'A' and tip = 'alis' and musteri_id = s.musteri_id),0) toplam_alis_tutari_kdv_dahil, isnull((select sum(odenen_tutar) from fd_satislar  where Statu = 'A' and tip = 'para_veris' and musteri_id = s.musteri_id),0) toplam_verilen_tutar, isnull((select sum(toplam_fiyat_kdv_dahil) from fd_satislar  where Statu = 'A' and tip = 'alis' and musteri_id = s.musteri_id) - (select sum(odenen_tutar) from fd_satislar  where Statu = 'A' and tip = 'para_veris' and musteri_id = s.musteri_id),0) Kalan_Borc_Tutari from fd_satislar s where satis_id = @satis_id /*musteri_id = 25*/ group by musteri_id", secili_kayit_id);
                }


                //for (int i = 0; i < TabloSatisKalanAlacak.Rows.Count; i++)
                //{
                //    // tablodaki kolonların hepsi null ise veri getirmemesi için yapmıştım. Vazgeçtim null olanları 0 yazıp geçiyorum. [CE_12.02.2020 20:42]
                //    if (!TabloSatisKalanAlacak.Rows[i].IsNull("toplam_alis_tutari_kdv_dahil") && !TabloSatisKalanAlacak.Rows[i].IsNull("toplam_verilen_tutar") && !TabloSatisKalanAlacak.Rows[i].IsNull("Kalan_Borc_Tutari"))
                //    {
                //        ToplamSonucGetir_VisibleTrue();

                //        lblToplamSatisTutariSonuc.Text = TabloSatisKalanAlacak.Rows[0]["toplam_alis_tutari_kdv_dahil"].ToString() + " ₺";
                //        lblToplamAlinanTutarSonuc.Text = TabloSatisKalanAlacak.Rows[0]["toplam_verilen_tutar"].ToString() + " ₺";
                //        lblToplamKalanAlacakSonuc.Text = TabloSatisKalanAlacak.Rows[0]["Kalan_Borc_Tutari"].ToString() + " ₺";
                //    }
                //}

                if (TabloSatisKalanAlacak.Rows.Count > 0)
                {
                    ToplamSonucGetir_VisibleTrue();

                    lblToplamSatisTutariSonuc.Text = Tornavida.FiyatFormatla(TabloSatisKalanAlacak.Rows[0]["toplam_alis_tutari_kdv_dahil"].ToString()) + " ₺";
                    lblToplamAlinanTutarSonuc.Text = Tornavida.FiyatFormatla(TabloSatisKalanAlacak.Rows[0]["toplam_verilen_tutar"].ToString()) + " ₺";
                    lblToplamKalanAlacakSonuc.Text = Tornavida.FiyatFormatla(TabloSatisKalanAlacak.Rows[0]["Kalan_Borc_Tutari"].ToString()) + " ₺";
                    ToplamSonucGetir_TextDegistir();
                }
            }
        }
        private void ToplamSonucGetir_VisibleTrue()
        {
            lblToplamSatisTutari.Visible = true;
            lblToplamSatisTutariSonuc.Visible = true;
            lblToplamAlinanTutar.Visible = true;
            lblToplamAlinanTutarSonuc.Visible = true;
            lblToplamKalanAlacak.Visible = true;
            lblToplamKalanAlacakSonuc.Visible = true;
            lblNokta1.Visible = true;
            lblNokta2.Visible = true;
            lblNokta3.Visible = true;
        }
        private void ToplamSonucGetir_VisibleFalse()
        {
            lblToplamSatisTutari.Visible = false;
            lblToplamSatisTutariSonuc.Visible = false;
            lblToplamAlinanTutar.Visible = false;
            lblToplamAlinanTutarSonuc.Visible = false;
            lblToplamKalanAlacak.Visible = false;
            lblToplamKalanAlacakSonuc.Visible = false;
            lblNokta1.Visible = false;
            lblNokta2.Visible = false;
            lblNokta3.Visible = false;
        }
        private void ToplamSonucGetir_TextDegistir()
        {
            lblToplamSatisTutari.Text = "Toplam Satış Tutarı";
            lblToplamAlinanTutar.Text = "Toplam Verilen Tutar";
            lblToplamKalanAlacak.Text = "Toplam Kalan Borç";
        }
    }
}
