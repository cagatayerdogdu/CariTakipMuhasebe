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
    public partial class frmMuhasebeHareketleri : Form
    {
        int IntParseBag = 0; long LongParseBag = 0; double DoubleParseBag = 0;
        DAL budak; Fonksiyonlar Tornavida;
        public int uye_id;
        string yetki_duzeyi;
        public frmMuhasebeHareketleri(int _uye_id, string _yetki_duzeyi)
        {
            InitializeComponent();
            uye_id = _uye_id;
            yetki_duzeyi = _yetki_duzeyi;
        }

        private void frmMuhasebeHareketleri_Load(object sender, EventArgs e)
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

            var dataSource = new List<DropdownListe>();
            dataSource.Add(new DropdownListe() { Name = "", Value = "" });
            dataSource.Add(new DropdownListe() { Name = "İrsaliye", Value = "irsaliye" });
            dataSource.Add(new DropdownListe() { Name = "Fatura", Value = "fatura" });
            dataSource.Add(new DropdownListe() { Name = "İrs/Fat", Value = "irsfat" });
            dataSource.Add(new DropdownListe() { Name = "Kesilmedi", Value = "kesilmedi" });
            cbFaturaTip.DataSource = dataSource;
            cbFaturaTip.DisplayMember = "Name";
            cbFaturaTip.ValueMember = "Value";

            var dataSourceFirmaMusteri = new List<DropdownListe>();
            dataSourceFirmaMusteri.Add(new DropdownListe() { Name = "Firma", Value = "firma" });
            dataSourceFirmaMusteri.Add(new DropdownListe() { Name = "Müşteri", Value = "musteri" });
            cbFirmaMusteri.DataSource = dataSourceFirmaMusteri;
            cbFirmaMusteri.DisplayMember = "Name";
            cbFirmaMusteri.ValueMember = "Value";

            var dataSourceIslem = new List<DropdownListe>();
            dataSourceIslem.Add(new DropdownListe() { Name = "", Value = "" });
            dataSourceIslem.Add(new DropdownListe() { Name = "Ürün Alış", Value = "alis" });
            dataSourceIslem.Add(new DropdownListe() { Name = "Ürün Satış", Value = "satis" });
            dataSourceIslem.Add(new DropdownListe() { Name = "Para Alındı", Value = "para_alis" });
            dataSourceIslem.Add(new DropdownListe() { Name = "Para Verildi", Value = "para_veris" });
            cbIslem.DataSource = dataSourceIslem;
            cbIslem.DisplayMember = "Name";
            cbIslem.ValueMember = "Value";

            cbFirmaMusteri.SelectedIndex = 0;
            dtpTarihBaslangic.Value = new DateTime(2020, 1, 1, 0, 0, 0);
            dtpTarihBitis.Value = DateTime.Now;//new DateTime(2020, 1, 1, 0, 0, 0);

            hareket_listele();
            cbIslem_SelectedIndexChanged(sender, e);
        }

        public void hareket_listele()
        {
            string TarihBaslangic = dtpTarihBaslangic.Value.ToString("yyyy-MM-dd ") + "00:00";
            string TarihBitis = dtpTarihBitis.Value.ToString("yyyy-MM-dd ") + "23:59";

            DateTime TarihBaslangic_Date = Tornavida.TarihToDateTime(TarihBaslangic);
            DateTime TarihBitis_Date = Tornavida.TarihToDateTime(TarihBitis);

            string SorguFiltre = "";
            if (cbIslem.SelectedIndex > 0)
            {
                SorguFiltre += " AND s.tip='"+cbIslem.SelectedValue+"'";
            }
            if (chkTumIslemler.Checked)
            {
                SorguFiltre += " AND s.tip in('alis', 'satis', 'para_alis', 'para_veris')";
            }
            else { SorguFiltre += " AND s.tip in('alis', 'satis')"; }

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
            if (cbFaturaTip.SelectedIndex > 0)
            {
                SorguFiltre += " AND s.belge='" + cbFaturaTip.SelectedValue + "'";
            }
            if (txtFaturaNo.Text.Trim() != "")
            {
                SorguFiltre += " AND s.fatura_no='" + txtFaturaNo.Text.Trim() + "'";
            }
            if (txtFaturaAciklama.Text.Trim() != "")
            {
                SorguFiltre += " AND s.fatura_aciklama LIKE '%" + txtFaturaAciklama.Text.Trim() + "%'";
            }

            /*DataTable TabloHareketler = budak.Sorgu_DataTable(@"SELECT s.satis_id, 0 AS su_id, 'main' AS satir_tip, (SUBSTR(s.tarih, 7, 2) || '/' || SUBSTR(s.tarih, 5, 2) || '/' || SUBSTR(s.tarih, 1, 4)) AS tarih, (SUBSTR(s.tarih, 9, 2) || ':' || SUBSTR(s.tarih, 11, 2)) AS saat, CASE s.tip WHEN 'alis' THEN 'Ürün Alış' WHEN 'satis' THEN 'Ürün Satış' WHEN 'para_alis' THEN 'Para Alındı' WHEN 'para_veris' THEN 'Para Verildi' WHEN 'devir' THEN 'Devir' END AS islem, CASE m.tip WHEN 'musteri' THEN 'Müşteri' ELSE 'Firma' END AS yer, m.ad_soyad, s.toplam_fiyat_kdv_dahil AS tutar, CASE s.odeme_tipi WHEN 'nakit' THEN 'Nakit' WHEN 'kredi_karti' THEN 'Kredi Kartı' WHEN 'cek' THEN 'Çek' WHEN 'senet' THEN 'Senet' END AS odeme_tipi, ROUND((s.toplam_fiyat_kdv_dahil-s.odenen_tutar),2) AS odeme_kalan, CASE s.belge WHEN 'irsaliye' THEN 'İrsaliye' WHEN 'fatura' THEN 'Fatura' WHEN 'irsfat' THEN 'İrs/Fat' WHEN 'kesilmedi' THEN 'Kesilmedi' END AS belge, s.fatura_no, s.fatura_aciklama AS aciklama, s.tip AS islem_kod FROM fd_satislar AS s JOIN fd_musteriler AS m ON s.musteri_id=m.musteri_id WHERE s.tarih BETWEEN @tarih_baslangic AND @tarih_bitis " + SorguFiltre + " ORDER BY s.tarih DESC", TarihBaslangic, TarihBitis);*/
            
            DataTable TabloHareketler = budak.Sorgu_DataTable(@"SELECT s.satis_id, 0 AS su_id, 'main' AS satir_tip, s.tarih, CASE s.tip WHEN 'alis' THEN 'Ürün Alış' WHEN 'satis' THEN 'Ürün Satış' WHEN 'para_alis' THEN 'Para Alındı' WHEN 'para_veris' THEN 'Para Verildi' WHEN 'devir' THEN 'Devir' END AS islem, CASE m.tip WHEN 'musteri' THEN 'Müşteri' ELSE 'Firma' END AS yer, m.ad_soyad, CASE s.odeme_tipi WHEN 'nakit' THEN 'Nakit' WHEN 'kredi_karti' THEN 'Kredi Kartı' WHEN 'cek' THEN 'Çek' WHEN 'senet' THEN 'Senet' END AS odeme_tipi, CASE s.belge WHEN 'irsaliye' THEN 'İrsaliye' WHEN 'fatura' THEN 'Fatura' WHEN 'irsfat' THEN 'İrs/Fat' WHEN 'kesilmedi' THEN 'Kesilmedi' END AS belge, s.fatura_no, s.toplam_fiyat_kdv_dahil AS tutar,  ROUND((s.toplam_fiyat_kdv_dahil-s.odenen_tutar),2) AS odeme_kalan, s.fatura_aciklama AS aciklama, s.tip AS islem_kod FROM fd_satislar AS s JOIN fd_musteriler AS m ON s.musteri_id=m.musteri_id WHERE s.tarih BETWEEN @tarih_baslangic AND @tarih_bitis " + SorguFiltre + " and (s.Statu = 'A' and m.Statu = 'A') ORDER BY s.tarih DESC", TarihBaslangic_Date.ToString(), TarihBitis_Date.ToString());
            // bu sorguda cast(s.tarih as date) yaptım çünkü web db ye geçtiğimde convert hatası veriyordu varchar to smalldatetime. [CE_12.05.2020 12:11]
            // Üsttekini kaldırıp Tarih_Date.ToString olarak güncelledim [CE_16.05.2020 23:36]

            if (cbDetay.Checked)
            {
                //TabloHareketler = listeDetaylandir(TabloHareketler);
                TabloHareketler = listeDetaylandir(TabloHareketler).Copy();
            }
            dgwStoklar.DataSource = TabloHareketler;
            listeFormatla();
        }

        private void cbIslem_SelectedIndexChanged(object sender, EventArgs e)
        {
            hareket_listele();
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

        public void ListedenFirmaSec(string firma_id, string firma_adi)
        {
            lblSeciliFirma.Text = firma_id;
            txtFirmalar.Text = firma_adi;
        }

        private void txtFirmalar_KeyDown(object sender, KeyEventArgs e)
        {
            
            lblSeciliFirma.Text = "";
        }

        private void listeFormatla()
        {
            string SatirSatisID = ""; string SatirTip = ""; string SatirIslem = ""; string SatirToplamFiyat = ""; string SatirOdemeKalan = "";
            //for (int i = 0; i < dgwStoklar.Rows.Count; i++)
            foreach (DataGridViewRow row in dgwStoklar.Rows) 
            {               
                SatirSatisID = row.Cells[0].Value.ToString();   //  1
                SatirTip = row.Cells[2].Value.ToString();   //  3
                SatirIslem = row.Cells[4].Value.ToString();   //  5
                SatirToplamFiyat = row.Cells[9].Value.ToString();   //  8
                SatirOdemeKalan = row.Cells[11].Value.ToString();   //  10
                row.DefaultCellStyle.ForeColor = Color.Black;
                if (SatirTip == "main")
                {
                    switch (SatirIslem)
                    {
                        case "Ürün Alış":
                            row.DefaultCellStyle.BackColor = Color.Blue; //DarkSalmon;
                            row.DefaultCellStyle.ForeColor = Color.White;
                            break;
                        case "Ürün Satış":
                            row.DefaultCellStyle.BackColor = Color.Green;    //DarkSeaGreen;
                            row.DefaultCellStyle.ForeColor = Color.White;
                            break;
                        case "Para Alındı":
                            row.DefaultCellStyle.BackColor = Color.Orange; //DarkKhaki;
                            row.DefaultCellStyle.ForeColor = Color.White;
                            break;
                        case "Para Verildi":
                            row.DefaultCellStyle.BackColor = Color.BlueViolet;     //Plum;
                            row.DefaultCellStyle.ForeColor = Color.White;
                            break;
                    }

                    //row.Cells[8].Value = Tornavida.FiyatFormatla(SatirToplamFiyat, "sistem");
                    //row.Cells[10].Value = Tornavida.FiyatFormatla(SatirOdemeKalan, "sistem");
                }
                else if (SatirTip == "baslik")
                {
                    row.DefaultCellStyle.ForeColor = Color.White;
                    for (int detayRenk = 4; detayRenk <= 8; detayRenk++)
                    {
                        row.Cells[detayRenk].Style.ForeColor = Color.Black;
                        row.Cells[detayRenk].Style.BackColor = Color.Silver;
                    }
                }
                else if (SatirTip == "detay")
                {
                    row.DefaultCellStyle.ForeColor = Color.White;
                    for (int detayRenk = 4; detayRenk <= 8; detayRenk++)
                    {
                        row.Cells[detayRenk].Style.ForeColor = Color.Black;
                        row.Cells[detayRenk].Style.BackColor = Color.Gainsboro;
                    }
                }
            }
            dgwStoklar.ClearSelection();
        }

        private DataTable listeDetaylandir(DataTable tablo)
        {
            string SatirSatisID = ""; string SatirTip = ""; string SatirIslem = "";
            DataTable TabloSatirlar;
            DataTable TabloGecici = new DataTable();
            TabloGecici = tablo.Copy();
            TabloGecici.Rows.Clear();
            //DataRow Satir;
            for (int i = 0; i < tablo.Rows.Count; i++)
            {
                DataRow Satir = tablo.Rows[i];
                TabloGecici.Rows.Add(Satir.ItemArray);
                //TabloGecici.ImportRow(Satir);

                SatirSatisID = tablo.Rows[i][0].ToString();
                SatirTip = tablo.Rows[i][2].ToString();
                SatirIslem = tablo.Rows[i][4].ToString();
                if (SatirTip != "main") continue;
                if (SatirIslem != "Ürün Alış" && SatirIslem != "Ürün Satış") continue;

                //Başlık ekleniyor
                Satir = tablo.NewRow();
                Satir[0] = "0";
                Satir[1] = "0";
                Satir[2] = "baslik";
                Satir[4] = "ÜRÜN ADI";
                Satir[5] = "MİKTAR";
                Satir[6] = "BR. FİYAT";
                Satir[7] = "İSK. %";
                Satir[8] = "TOP. TUTAR";
                Satir[9] = DBNull.Value;//"0";
                Satir[10] = DBNull.Value;
                Satir[11] = DBNull.Value; //"0";
                Satir[12] = "";
                Satir[13] = "";              

                ////ORJİNAL HALİ\\\\
                //Satir[0] = "0";
                //Satir[1] = "0";
                //Satir[2] = "baslik";
                //Satir[3] = "ÜRÜN ADI";
                //Satir[4] = "MİKTAR";
                //Satir[5] = "BR. FİYAT";
                //Satir[6] = "İSK. %";
                //Satir[7] = "TOP. TUTAR";
                //Satir[8] = "0";
                //Satir[9] = "";
                //Satir[10] = "0";
                //Satir[11] = "";
                //Satir[12] = "";
                //Satir[13] = "";
                /*************/
                TabloGecici.Rows.Add(Satir.ItemArray);
                //tablo.Rows.Add("0", "0", "baslik", "", "", "", "", "", "0", "", "", "", "");

                TabloSatirlar = budak.Sorgu_DataTable("SELECT su.su_id, u.urun_ad, su.miktar, su.birim_fiyat_kdv_dahil, su.iskonto, su.toplam_fiyat_kdv_dahil FROM fd_satis_urunler AS su JOIN fd_satislar AS s ON su.satis_id=s.satis_id JOIN fd_urunler AS u ON u.urun_id=su.urun_id WHERE su.satis_id=@satis_id and (su.Statu = 'A' and s.Statu = 'A' and u.Statu = 'A') ", SatirSatisID);
                for (int s = 0; s < TabloSatirlar.Rows.Count; s++)
                {
                    Satir = tablo.NewRow();
                    Satir[0] = SatirSatisID;
                    Satir[1] = TabloSatirlar.Rows[s]["su_id"].ToString();
                    Satir[2] = "detay";
                    Satir[4] = TabloSatirlar.Rows[s]["urun_ad"].ToString();
                    Satir[5] = TabloSatirlar.Rows[s]["miktar"].ToString();
                    Satir[6] = TabloSatirlar.Rows[s]["birim_fiyat_kdv_dahil"].ToString();
                    Satir[7] = TabloSatirlar.Rows[s]["iskonto"].ToString();
                    Satir[8] = TabloSatirlar.Rows[s]["toplam_fiyat_kdv_dahil"].ToString();
                    Satir[9] = DBNull.Value; //"0";
                    Satir[10] = DBNull.Value; //"";
                    Satir[11] = DBNull.Value; //"0";
                    Satir[12] = "";
                    Satir[13] = "";
                    //tablo.Rows.Add(Satir);
                    TabloGecici.Rows.Add(Satir.ItemArray);

                    /*ORJİNAL HALİ*/
                    //Satir[0] = SatirSatisID;
                    //Satir[1] = TabloSatirlar.Rows[s]["su_id"].ToString();
                    //Satir[2] = "detay";
                    //Satir[3] = TabloSatirlar.Rows[s]["urun_ad"].ToString();
                    //Satir[4] = TabloSatirlar.Rows[s]["miktar"].ToString();
                    //Satir[5] = TabloSatirlar.Rows[s]["birim_fiyat_kdv_dahil"].ToString();
                    //Satir[6] = TabloSatirlar.Rows[s]["iskonto"].ToString();
                    //Satir[7] = TabloSatirlar.Rows[s]["toplam_fiyat_kdv_dahil"].ToString();
                    //Satir[8] = "0";
                    //Satir[9] = "";
                    //Satir[10] = "0";
                    //Satir[11] = "";
                    //Satir[12] = "";
                    //Satir[13] = "";
                    /**/
                }
            }
            //return tablo;
            return TabloGecici;
        }

        private void dgwStoklar_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            listeFormatla();
        }

        private void frmMuhasebeHareketleri_Shown(object sender, EventArgs e)
        {
            dgwStoklar.ClearSelection();
        }

        public frmAnasayfa frmAnasayfa;
        public string EkranNo = "";
        private void frmUrunYonetimi_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAnasayfa.DiziFormlar.Remove(this);
            frmAnasayfa.DiziFormTag.Remove("muhasebe_hareketleri");
            frmAnasayfa.TabCikar("muhasebe_hareketleri");
        }

        private void dgwStoklar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string SatisId = dgwStoklar.CurrentRow.Cells[0].Value.ToString();
            string SatisIslem = dgwStoklar.CurrentRow.Cells[13].Value.ToString();

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
            else if (SatisIslem == "para_alis" || SatisIslem == "para_veris")
            {
                frmParaAlVer formParaAlVer = new frmParaAlVer(uye_id, yetki_duzeyi, SatisIslem, this, SatisId);
                formParaAlVer.MdiParent = frmAnasayfa;

                frmAnasayfa.EkranSayisi++;
                TabPage tp = new TabPage();
                tp.Parent = frmAnasayfa.tcMain;
                tp.Text = SatisIslem == "para_alis" ? "PARA ALMA KAYDINI DÜZENLE" : "PARA VERME KAYDINI DÜZENLE";
                tp.Tag = SatisIslem + "_duzenle";
                tp.Show();

                formParaAlVer.Show();
                formParaAlVer.EkranNo = frmAnasayfa.EkranSayisi.ToString();
                formParaAlVer.frmAnasayfa = frmAnasayfa;
                frmAnasayfa.tcMain.SelectedTab = tp;
                frmAnasayfa.DiziFormlar.Add(formParaAlVer);
                frmAnasayfa.DiziFormTag.Add(SatisIslem + "_duzenle");
            }
        }

        private void dgwStoklar_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && dgwStoklar.SelectedRows.Count > 0)
            {
                string SatisId = dgwStoklar.CurrentRow.Cells[1].Value.ToString();
                string SatirTip = dgwStoklar.CurrentRow.Cells[2].Value.ToString();
                string SatisIslem = dgwStoklar.CurrentRow.Cells[13].Value.ToString();

                tsmiParaAlVer.Visible = false;
                tsmiDuzenle.Visible = false;
                tsmiSil.Visible = false;
                tsmiYazdir.Visible = false;
                if (SatirTip == "main")
                {
                    if (SatisIslem == "alis" || SatisIslem == "satis")
                    {
                        tsmiParaAlVer.Visible = true;
                        if (SatisIslem == "satis")
                        {
                            tsmiYazdir.Visible = true;
                        }
                    }
                    tsmiDuzenle.Visible = true;
                    tsmiSil.Visible = true;
                }
                menuSag.Show(dgwStoklar.PointToScreen(e.Location));
            }
        }

        private void tsmiDuzenle_Click(object sender, EventArgs e)
        {
            dgwStoklar_CellDoubleClick(null, null);
        }

        private void tsmiSil_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Seçili kaydı silmek istediğinizden emin misiniz?", "KAYIT SİLİNECEK", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                string SatisId = dgwStoklar.CurrentRow.Cells[0].Value.ToString();
                string SatirSuId = dgwStoklar.CurrentRow.Cells[1].Value.ToString();
                string SatirTip = dgwStoklar.CurrentRow.Cells[2].Value.ToString();
                string SatisIslem = dgwStoklar.CurrentRow.Cells[13].Value.ToString();
                string SatirSuUrunId = ""; int EskiUrunMiktari = 0; string GeriAritmetik = "";

                if (SatirTip == "main")
                {
                    if (SatisIslem == "alis" || SatisIslem == "satis")
                    {
                        //Ürün miktarları güncelleniyor
                        DataTable TabloEskiUrunler = budak.Sorgu_DataTable("SELECT su_id, urun_id, miktar FROM fd_satis_urunler WHERE Statu = 'A' and satis_id=" + SatisId);
                        for (int u = 0; u < TabloEskiUrunler.Rows.Count; u++)
                        {
                            string SatirId = TabloEskiUrunler.Rows[u]["su_id"].ToString();
                            SatirSuUrunId = TabloEskiUrunler.Rows[u]["urun_id"].ToString();
                            EskiUrunMiktari = int.Parse(TabloEskiUrunler.Rows[u]["miktar"].ToString());
                            //budak.Sorgu_Calistir("DELETE FROM fd_satis_urunler WHERE su_id=@su_id", SatirId);
                            budak.Sorgu_Calistir("update fd_satis_urunler set Statu = 'X' WHERE su_id=@su_id", SatirId);
                            GeriAritmetik = SatisIslem == "satis" ? "+" : "-";
                            budak.Sorgu_Calistir("UPDATE fd_urunler SET urun_miktar=urun_miktar" + GeriAritmetik + "@urun_miktar WHERE urun_id=@urun_id", EskiUrunMiktari.ToString(), SatirSuUrunId);
                        }
                    }
                    //int Etki = budak.Sorgu_Calistir("DELETE FROM fd_satislar WHERE satis_id=@satis_id", SatisId);
                    int Etki = budak.Sorgu_Calistir("update fd_satislar set Statu = 'X' WHERE satis_id=@satis_id", SatisId);
                    if (Etki <= 0) MessageBox.Show("Kayıt silinirken bir hata meydana geldi.");
                }
                else if (SatirTip == "detay")
                {
                    DataTable TabloSatir = budak.Sorgu_DataTable("SELECT urun_id, miktar, toplam_fiyat_kdv_dahil FROM fd_satis_urunler WHERE Statu = 'A' and su_id=" + SatirSuId);
                    SatirSuUrunId = TabloSatir.Rows[0]["urun_id"].ToString();
                    EskiUrunMiktari = int.Parse(TabloSatir.Rows[0]["miktar"].ToString());
                   // string ToplamFiyatKdvDahil = Tornavida.FiyatFormatla(TabloSatir.Rows[0]["toplam_fiyat_kdv_dahil"].ToString(), "sistem");
                    string ToplamFiyatKdvDahil = TabloSatir.Rows[0]["toplam_fiyat_kdv_dahil"].ToString();
                    budak.Sorgu_Calistir("UPDATE fd_satislar SET toplam_fiyat_kdv_dahil=toplam_fiyat_kdv_dahil-@toplam_fiyat_kdv_dahil WHERE satis_id=@satis_id", SatisId, ToplamFiyatKdvDahil);
                    GeriAritmetik = SatisIslem == "satis" ? "+" : "-";
                    budak.Sorgu_Calistir("UPDATE fd_urunler SET urun_miktar=urun_miktar" + GeriAritmetik + "@urun_miktar WHERE urun_id=@urun_id", EskiUrunMiktari.ToString(), SatirSuUrunId);
                    
                }

                hareket_listele();
            }
        }

        private void tsmiParaAlVer_Click(object sender, EventArgs e)
        {
            string SatisId = dgwStoklar.CurrentRow.Cells[0].Value.ToString();
            string SatirSuId = dgwStoklar.CurrentRow.Cells[1].Value.ToString();
            string SatirTip = dgwStoklar.CurrentRow.Cells[2].Value.ToString();
            string SatisIslem = dgwStoklar.CurrentRow.Cells[13].Value.ToString();
            string SatisIslemAd = SatisIslem == "alis" ? "alış" : "satış";

            //string ParaAlVerId = budak.Sorgu_Scalar("SELECT satis_id FROM fd_satislar WHERE odeme_satis_id=" + SatisId + " LIMIT 1");
            string ParaAlVerId = budak.Sorgu_Scalar("SELECT top 1 satis_id FROM fd_satislar WHERE Statu = 'A' and  odeme_satis_id=" + SatisId);
            if (ParaAlVerId == "")
            {
                MessageBox.Show("Seçtiğiniz " + SatisIslemAd + " kaydına bağlı bir para alış/veriş işlemi tespit edilemedi. Lütfen üst menüden yeni bir para alış/veriş kaydı açınız.");
            }
            else
            {
                //SatisIslem = budak.Sorgu_Scalar("SELECT tip FROM fd_satislar WHERE satis_id=" + ParaAlVerId + " LIMIT 1");
                SatisIslem = budak.Sorgu_Scalar("SELECT top 1 tip FROM fd_satislar WHERE Statu = 'A' and satis_id=" + ParaAlVerId);
                frmParaAlVer formParaAlVer = new frmParaAlVer(uye_id, yetki_duzeyi, SatisIslem, this, ParaAlVerId);
                formParaAlVer.MdiParent = frmAnasayfa;

                frmAnasayfa.EkranSayisi++;
                TabPage tp = new TabPage();
                tp.Parent = frmAnasayfa.tcMain;
                tp.Text = SatisIslem == "para_alis" ? "PARA ALMA KAYDINI DÜZENLE" : "PARA VERME KAYDINI DÜZENLE";
                tp.Tag = SatisIslem + "_duzenle";
                tp.Show();

                formParaAlVer.Show();
                formParaAlVer.EkranNo = frmAnasayfa.EkranSayisi.ToString();
                formParaAlVer.frmAnasayfa = frmAnasayfa;
                frmAnasayfa.tcMain.SelectedTab = tp;
                frmAnasayfa.DiziFormlar.Add(formParaAlVer);
                frmAnasayfa.DiziFormTag.Add(SatisIslem + "_duzenle");
            }
        }

        private void tsmiYazdir_Click(object sender, EventArgs e)
        {
            // Buraya geldiğinde yani her faturaya tıklandığında yazdır işlemini sıfırlamak lazım

            frmFaturaYazdirma frmFaturaYazdirmaKontrol = new frmFaturaYazdirma(-1, "", "", "");
            //frmAnasayfa.DiziFormTag.Remove("fatura_yazdir");
            //frmAnasayfa.TabCikar("fatura_yazdir");
            frmFaturaYazdirmaKontrol.Close();

            string SatisId = dgwStoklar.CurrentRow.Cells[0].Value.ToString();
            string SatirSuId = dgwStoklar.CurrentRow.Cells[1].Value.ToString();
            string SatirTip = dgwStoklar.CurrentRow.Cells[2].Value.ToString();
            string SatisIslem = dgwStoklar.CurrentRow.Cells[13].Value.ToString();
            string SatisIslemAd = SatisIslem == "alis" ? "alış" : "satış";
            string FaturaNo = dgwStoklar.CurrentRow.Cells[9].Value.ToString();

            //string ParaAlVerId = budak.Sorgu_Scalar("SELECT satis_id FROM fd_satislar WHERE odeme_satis_id=" + SatisId + " LIMIT 1");
            string FaturaId = budak.Sorgu_Scalar("SELECT top 1 satis_id FROM Fatura_View WHERE satis_id=" + SatisId);
            if (FaturaId == "")
            {
                MessageBox.Show("Seçtiğiniz " + SatisIslemAd + " kaydına bağlı bir fatura işlemi tespit edilemedi. Lütfen üst menüden yeni bir fatura kaydı açınız.");
            }
            else
            {
                //frmAnasayfa.DiziFormTag.Remove("fatura_yazdir");
                //frmAnasayfa.TabCikar("fatura_yazdir");
                //SatisIslem = budak.Sorgu_Scalar("SELECT tip FROM fd_satislar WHERE satis_id=" + ParaAlVerId + " LIMIT 1");
                SatisIslem = budak.Sorgu_Scalar("SELECT top 1 tip FROM fd_satislar WHERE Statu = 'A' and satis_id=" + FaturaId);
                frmFaturaYazdirma formFaturaYazdirma = new frmFaturaYazdirma(uye_id, yetki_duzeyi, FaturaNo, FaturaId);
                formFaturaYazdirma.MdiParent = frmAnasayfa;

                frmAnasayfa.EkranSayisi++;
                TabPage tp = new TabPage();
                tp.Parent = frmAnasayfa.tcMain;
                //tp.Text = SatisIslem == "para_alis" ? "PARA ALMA KAYDINI DÜZENLE" : "PARA VERME KAYDINI DÜZENLE";
                tp.Text = "SEÇİLİ SATIŞ FATURASINI YAZDIR";
                tp.Tag = "fatura_yazdir";
                tp.Show();

                formFaturaYazdirma.Show();
                formFaturaYazdirma.EkranNo = frmAnasayfa.EkranSayisi.ToString();
                formFaturaYazdirma.frmAnasayfa = frmAnasayfa;
                frmAnasayfa.tcMain.SelectedTab = tp;
                frmAnasayfa.DiziFormlar.Add(formFaturaYazdirma);
                frmAnasayfa.DiziFormTag.Add("fatura_yazdir");
            }
        }

        private void lnkYenile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cbIslem.Refresh();
            txtFirmalar.Text = "";
            txtFaturaNo.Text = "";
            txtFaturaAciklama.Text = "";
            cbDetay.Checked = false;
            cbFaturaTip.Refresh();
            cbFirmaMusteri.Refresh();
            this.Refresh();
            frmMuhasebeHareketleri_Load(sender, e);
            hareket_listele();
        }

        private void chkTumIslemler_CheckedChanged(object sender, EventArgs e)
        {
            hareket_listele();
        }
    }
}
