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
    public partial class frmUrunYonetimi : Form
    {
        double DoubleParseBag = 0; int IntParseBag = 0;
        DAL budak; Fonksiyonlar Tornavida;
        public int uye_id;
        string yetki_duzeyi;
        frmStokListe formStokListe = null;
        string secili_urun;
        public frmUrunYonetimi(int _uye_id, string _yetki_duzeyi)
        {
            InitializeComponent();
            uye_id = _uye_id;
            yetki_duzeyi = _yetki_duzeyi;
        }
        public frmUrunYonetimi(int _uye_id, string _yetki_duzeyi, string _secili_urun, frmStokListe _formStokListe)
        {
            InitializeComponent();
            uye_id = _uye_id;
            yetki_duzeyi = _yetki_duzeyi;
            formStokListe = _formStokListe;
            secili_urun = _secili_urun;
        }

        int secilen_urun_id = 0;
        int secilen_urun = 0;
        private void dgwUrunler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen_urun_id = Convert.ToInt32(dgwUrunler.CurrentRow.Cells[0].Value);
            secilen_urun = secilen_urun_id;
            ////Barkod numarası tespit edilen ürünün id numarası öğreniliyor.
            //string sorgu_secilen_urun_id = "SELECT urun_id FROM urunler WHERE urun_serial=@serial";
            //DataTable dt_urun_id = budak.Sorgu_DataTable(sorgu_secilen_urun_id, secilen_urun_serial);
            //secilen_urun = Convert.ToInt32(dt_urun_id.Rows[0][0]);

            //Seçilen ürün ve ürün giriş kaydına ait bilgiler, ilgili textBox'lara yükleniyor.
            txtUrunAdi.Text = dgwUrunler.CurrentRow.Cells[1].Value.ToString();
            txtUrunMarkasi.Text = dgwUrunler.CurrentRow.Cells[2].Value.ToString();
            txtUrunModeli.Text = dgwUrunler.CurrentRow.Cells[3].Value.ToString();
            txtUrunSerial.Text = dgwUrunler.CurrentRow.Cells[4].Value.ToString();
            txtSatisFiyati.Text = dgwUrunler.CurrentRow.Cells[5].Value.ToString();
            cbUrunBirim.Text = dgwUrunler.CurrentRow.Cells[6].Value.ToString();
            //txtKdv.Text = dgwUrunler.CurrentRow.Cells[7].Value.ToString();
            cmbKdv.Text = dgwUrunler.CurrentRow.Cells[7].Value.ToString();
            cbSatisKdvDahil.SelectedIndex = int.Parse(dgwUrunler.CurrentRow.Cells[8].Value.ToString());
            txtAlisFiyati.Text = dgwUrunler.CurrentRow.Cells[10].Value.ToString();
            cbAlisKdvDahil.SelectedIndex = int.Parse(dgwUrunler.CurrentRow.Cells[12].Value.ToString());

            if (cbSatisKdvDahil.SelectedIndex == 1) txtSatisFiyati.Text = dgwUrunler.CurrentRow.Cells[9].Value.ToString();
            if (cbAlisKdvDahil.SelectedIndex == 1) txtAlisFiyati.Text = dgwUrunler.CurrentRow.Cells[13].Value.ToString();

            btnUrunSil.Visible = true;
            btnUrunKaydet.Text = "GÜNCELLE";
        }

        private void UrunSec(string urunId)
        {
            for (int i = 0; i < dgwUrunler.Rows.Count; i++)
            {
                if (dgwUrunler.Rows[i].Cells[0].Value.ToString() == urunId)
                {
                    //dgwUrunler.Rows[i].Selected = true;
                    dgwUrunler.CurrentCell = dgwUrunler.Rows[i].Cells[1];
                    dgwUrunler_CellDoubleClick(null, null);
                    break;
                }
            }
        }

        private void frmUrunYonetimi_Load(object sender, EventArgs e)
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

            menuSecilenUrunuSifirlaToolStripMenuItem_Click(null, null);

            if (secili_urun != "")
            {
                UrunSec(secili_urun);
            }
        }

        private void urun_cinsi_listele()
        {
            txtUrunModeli.Items.Clear();
            DataTable TabloUrunCinsi = budak.Sorgu_DataTable("SELECT DISTINCT u.urun_model FROM fd_urunler AS u where Statu = 'A' ORDER BY u.urun_model");
            string SatirUrunCinsi = "";
            for (int i = 0; i < TabloUrunCinsi.Rows.Count; i++)
            {
                SatirUrunCinsi = TabloUrunCinsi.Rows[i]["urun_model"].ToString();
                txtUrunModeli.Items.Add(SatirUrunCinsi);
            }
        }

        private void dgwUrunler_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                menuSecilenUrunuSifirlaToolStripMenuItem.Visible = true;
                menuSecilenCikisiSifirlaToolStripMenuItem.Visible = false;
                menuSecilenArizaServistenDonduToolStripMenuItem.Visible = false;
                menuSecilenUrunuHurdayaAyirToolStripMenuItem.Visible = false;
                menuSecilenIstekKaydiSifirlaToolStripMenuItem.Visible = false;
                menuSecilenUrununCikisiniYapToolStripMenuItem.Visible = false;
                menuSag.Show(dgwUrunler.PointToScreen(e.Location));
            }
        }

        private void btnUrunKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                #region EKLE BUTONU
                //Hata dedektörünün (ErrorProvider) bulduğu hatalar temizleniyor.
                epHataDedektoru.Clear();
                //Girilen değerin sayı olup olmadığını kontrol edecek olan ifade oluşturuluyor.
                Regex sayi_kontrolu = new Regex("0*[1-9][0-9]*");

                //buyukharf_giris_ekle();

                //Yeni ürün girişi için gerekli alanların doldurulup doldurulmadığı kontrol ediliyor.
                if (txtUrunAdi.Text.Trim().Length == 0) //Ürün adı girilmemişse işlem yapılmıyor.
                {
                    epHataDedektoru.SetError(txtUrunAdi, "Ürünün adını girmediniz.");
                }
                //else if (txtUrunMarkasi.Text.Trim().Length == 0) //Ürün markası girilmemişse işlem yapılmıyor.
                //{
                //    epHataDedektoru.SetError(txtUrunMarkasi, "Ürünün markasını girmediniz.");
                //}
                else if (txtUrunModeli.Text.Trim().Length == 0) //Ürün modeli girilmemişse işlem yapılmıyor.
                {
                    epHataDedektoru.SetError(txtUrunModeli, "Ürünün cinsini girmediniz.");
                }
                //else if (txtUrunSerial.Text.Trim().Length == 0) //Ürün barkod numarası girilmemişse işlem yapılmıyor.
                //{
                //    epHataDedektoru.SetError(txtUrunSerial, "Ürünün barkod numarasını girmediniz.");
                //}
                //else if (!sayi_kontrolu.IsMatch(txtUrunSerial.Text.Trim()) && txtUrunSerial.Text.ToUpper() != "YOK") //Ürün barkod numarası doğru formatta girilmemişse işlem yapılmıyor.
                //{
                //    epHataDedektoru.SetError(txtUrunSerial, "Ürünün barkod numarasını doğru formatta girmediniz. Sadece sayı girişi yapabilirsiniz.");
                //}
                else //Tüm bilgiler doğru bir şekilde girilmişse yeni kayıt girişi yapılıyor.
                {
                    string UrunBirim = cbUrunBirim.Text;
                    string SatisFiyati = txtSatisFiyati.Text.Replace(',','.').Trim();
                    if (!double.TryParse(SatisFiyati, out DoubleParseBag)) SatisFiyati = "0";
                    string AlisFiyati = txtAlisFiyati.Text.Replace(',', '.').Trim();
                    if (!double.TryParse(AlisFiyati, out DoubleParseBag)) AlisFiyati = "0";
                    string UrunSatisKdvDahil = cbSatisKdvDahil.SelectedIndex == 1 ? "1" : "0";
                    string UrunAlisKdvDahil = cbAlisKdvDahil.SelectedIndex == 1 ? "1" : "0";
                    //string SatisKdvOrani = int.TryParse(txtKdv.Text, out IntParseBag) ? IntParseBag.ToString() : "0";
                    string SatisKdvOrani = int.TryParse(cmbKdv.Text, out IntParseBag) ? IntParseBag.ToString() : "0";
                    string AlisKdvOrani = SatisKdvOrani;
                    SatisFiyati = Tornavida.FiyatHesapla(SatisFiyati, SatisKdvOrani, UrunSatisKdvDahil == "1", false).ToString();
                    string SatisFiyatiKdvDahil = Tornavida.FiyatHesapla(SatisFiyati, SatisKdvOrani, false, true).ToString();
                    AlisFiyati = Tornavida.FiyatHesapla(AlisFiyati, AlisKdvOrani, UrunAlisKdvDahil == "1", false).ToString();
                    string AlisFiyatiKdvDahil = Tornavida.FiyatHesapla(AlisFiyati, AlisKdvOrani, false, true).ToString();

                    SatisFiyati = Tornavida.FiyatFormatla(SatisFiyati);
                    //UrunSatisKdvDahil = Tornavida.FiyatFormatla(UrunSatisKdvDahil); //[CE_SQL sonrası double fiyat 1 yerine 1.00 olduğu için db kaydı hata veriyor bu formatlamayı kapatıyorum.]
                    SatisFiyatiKdvDahil = Tornavida.FiyatFormatla(SatisFiyatiKdvDahil);
                    AlisFiyati = Tornavida.FiyatFormatla(AlisFiyati);
                    //UrunAlisKdvDahil = Tornavida.FiyatFormatla(UrunAlisKdvDahil); //[CE_SQL sonrası double fiyat 1 yerine 1.00 olduğu için db kaydı hata veriyor bu formatlamayı kapatıyorum.]
                    AlisFiyatiKdvDahil = Tornavida.FiyatFormatla(AlisFiyatiKdvDahil);
                    //Girilen ürün barkod numarasına veritabanında rastlanmamışsa (depoya girişi yapılacak
                    //ürün, daha önceden kaydedilmemişse) yeni ürün kaydı yapılıyor.
                    int eklenen_urun = 0;
                    if (secilen_urun == 0)
                    {
                        eklenen_urun = budak.Sorgu_Calistir_Eklenen_Id_Dondur("INSERT INTO fd_urunler(urun_ad, urun_marka, urun_model, urun_serial, urun_birim, urun_fiyat, urun_kdv, urun_kdv_dahil, urun_fiyat_kdv_dahil, urun_alis_fiyat, urun_alis_kdv, urun_alis_kdv_dahil, urun_alis_fiyat_kdv_dahil) VALUES(@ad, @marka, @model, @serial, @urun_birim, @urun_fiyat, @urun_kdv, @urun_kdv_dahil, @urun_fiyat_kdv_dahil, @urun_alis_fiyat, @urun_alis_kdv, @urun_alis_kdv_dahil, @urun_alis_fiyat_kdv_dahil)", txtUrunAdi.Text.Trim(), txtUrunMarkasi.Text.Trim(), txtUrunModeli.Text.Trim(), txtUrunSerial.Text.Trim(), UrunBirim, SatisFiyati, SatisKdvOrani, UrunSatisKdvDahil, SatisFiyatiKdvDahil, AlisFiyati, AlisKdvOrani, UrunAlisKdvDahil, AlisFiyatiKdvDahil);

                        ////Ürün kaydı işlemi günlüğe kaydediliyor.
                        //string sorgu_log_urun_insert = "INSERT INTO loglar(islem_ad,islem_tip,islem_kayit_id,islem_yapan_kisi,islem_tarih) VALUES(@islem_ad,@islem_tip,@kayit_satir_id,@kisi,@tarih)";
                        //string log_urun_tarih = tarih_formatla(DateTime.Now.ToString());
                        //int sorgu_log_urun_insert_id = budak.Sorgu_Calistir(sorgu_log_urun_insert, "urun", "insert", eklenen_urun.ToString(), uye_id.ToString(), log_urun_tarih);
                    }
                    else //Ürünün barkod numarası veritabanında kayıtlıysa, o ürün seçiliyor.
                    {
                        eklenen_urun = secilen_urun;
                        int Etki = budak.Sorgu_Calistir("UPDATE fd_urunler SET urun_ad=@urun_ad, urun_marka=@urun_marka, urun_model=@urun_model, urun_serial=@urun_serial, urun_birim=@urun_birim, urun_fiyat=@urun_fiyat, urun_kdv=@urun_kdv, urun_kdv_dahil=@urun_kdv_dahil, urun_fiyat_kdv_dahil=@urun_fiyat_kdv_dahil, urun_alis_fiyat=@urun_alis_fiyat, urun_alis_kdv=@urun_alis_kdv, urun_alis_kdv_dahil=@urun_alis_kdv_dahil, urun_alis_fiyat_kdv_dahil=@urun_alis_fiyat_kdv_dahil WHERE urun_id=@urun_id", txtUrunAdi.Text.Trim(), txtUrunMarkasi.Text.Trim(), txtUrunModeli.Text.Trim(), txtUrunSerial.Text.Trim(), UrunBirim, SatisFiyati, SatisKdvOrani, UrunSatisKdvDahil, SatisFiyatiKdvDahil, AlisFiyati, AlisKdvOrani, UrunAlisKdvDahil, AlisFiyatiKdvDahil, eklenen_urun.ToString());
                        if (Etki <= 0) eklenen_urun = 0;
                    }
                    ////Eklediğimiz ürünün depo kaydını gerçekleştirecek olan sorguyu yazıyoruz.
                    //string sorgu_insert_depo = "INSERT INTO depo(urun_id,urun_sayisi,giris_tarihi,garanti_bilgisi) VALUES(@urun_id,@urun_sayisi,@giris_tarihi,@garanti_bilgisi)";
                    ////Seçilen tarihi, uygun formata sokuyoruz.
                    //string formatli_tarih = tarih_formatla(dtUrunGirisTarihi.Value.ToString());
                    ////Ürünün depoya girişini kaydediyoruz.
                    //int eklenen_depo_kaydi = budak.Sorgu_Calistir_Eklenen_Id_Dondur(sorgu_insert_depo, eklenen_urun.ToString(), txtUrunGirisAdet.Text.Trim(), formatli_tarih, txtGiris_Garanti.Text.Trim());

                    string bildirim = "";
                    if (eklenen_urun > 0)
                    {
                        //bildirim = "Ürün başarıyla eklenmiştir.";
                        MessageBox.Show("Ürün başarıyla eklenmiştir.");
                        urun_listele();

                        if (formStokListe != null)
                        {
                            this.Close();
                            frmAnasayfa.FormSec(formStokListe.EkranNo);
                            formStokListe.urun_listele();
                        }
                    }
                    else
                    {
                        bildirim = "Ürün eklenirken bir sorun oluştu.";
                    }
                    if (bildirim != "") MessageBox.Show(bildirim);
                }
                // ürünler giriş yapıldıktan sonra sayfa yenilenmiş gibi textboxları temizliyoruz.
                menuSecilenUrunuSifirlaToolStripMenuItem_Click(null, null);
                #endregion
            }
            catch (Exception hata) { 
                //MessageBox.Show(hata.ToString()); 
            }
        }

        private void menuSecilenUrunuSifirlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            secilen_urun_id = 0;
            secilen_urun = 0;
            txtUrunAdi.Text = "";
            txtUrunMarkasi.Text = "";
            txtUrunModeli.Text = "";
            txtUrunSerial.Text = "";
            txtSatisFiyati.Text = "";
            //txtKdv.Text = "";
            cmbKdv.Text = "";
            txtAlisFiyati.Text = "";
            txtSatisFiyati.Text = "";
            cbUrunBirim.SelectedIndex = 0;
            cbAlisKdvDahil.SelectedIndex = 0;
            cbSatisKdvDahil.SelectedIndex = 1;
            btnUrunSil.Visible = false;
            btnUrunKaydet.Text = "KAYDET";

            urun_cinsi_listele();
            urun_listele();
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili ürünü silmek istediğinizden emin misiniz?", "ÜRÜN SİLİNECEK", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                string HareketVar = budak.Sorgu_Scalar(@"select top 1 satis_id from fd_satis_urunler where Statu = 'A' and urun_id ="+secilen_urun_id);
                if (HareketVar == "")
                {
                    //int Etki = budak.Sorgu_Calistir("DELETE FROM urunler WHERE urun_id=@urun_id", secilen_urun.ToString());
                    int Etki = budak.Sorgu_Calistir("update fd_urunler set Statu = 'X' WHERE urun_id=@urun_id", secilen_urun.ToString());
                    if (Etki > 0)
                    {
                        MessageBox.Show("Ürün silinmiştir.");
                        menuSecilenUrunuSifirlaToolStripMenuItem_Click(null, null);
                        urun_listele();
                    }
                    else
                    {
                        MessageBox.Show("Ürün silinemedi. Lütfen tekrar deneyin.");
                    }
                }
                else
                {
                    MessageBox.Show("Seçilen ürünün satış hareketi olduğu için silme işlemi yapılamadı.\n\rÜrün silme işlemi yapmak için hareket olan evrak/fatura silinmelidir.");
                }
                
            }
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            string Arama = txtArama.Text.Trim();
            if (Arama == "")
            {
                urun_listele();
            }
            else
            {
                epHataDedektoru.Clear();
                dgwUrunler.DataSource = budak.Sorgu_DataTable("SELECT u.urun_id, u.urun_ad, u.urun_marka, u.urun_model, u.urun_serial, u.urun_fiyat, u.urun_birim, u.urun_kdv, u.urun_kdv_dahil, u.urun_fiyat_kdv_dahil, u.urun_alis_fiyat, u.urun_alis_kdv, u.urun_alis_kdv_dahil, u.urun_alis_fiyat_kdv_dahil, u.urun_miktar FROM fd_urunler AS u WHERE Statu = 'A' and  (u.urun_serial=@urun_serial OR u.urun_ad LIKE @urun_ad OR u.urun_marka LIKE @urun_marka OR u.urun_model LIKE @urun_model) ORDER BY u.urun_ad", Arama, "%" + Arama + "%", "%" + Arama + "%", "%" + Arama + "%");
            }
        }

        private void urun_listele()
        {
            epHataDedektoru.Clear();
            dgwUrunler.DataSource = budak.Sorgu_DataTable("SELECT u.urun_id, u.urun_ad, u.urun_marka, u.urun_model, u.urun_serial, u.urun_fiyat, u.urun_birim, u.urun_kdv, u.urun_kdv_dahil, u.urun_fiyat_kdv_dahil, u.urun_alis_fiyat, u.urun_alis_kdv, u.urun_alis_kdv_dahil, u.urun_alis_fiyat_kdv_dahil, u.urun_miktar FROM fd_urunler AS u where Statu = 'A' ORDER BY u.urun_ad");
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            btnArama_Click(sender, e);
        }

        public frmAnasayfa frmAnasayfa;
        public string EkranNo = "";
        private void frmUrunYonetimi_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAnasayfa.DiziFormlar.Remove(this);
            frmAnasayfa.DiziFormTag.Remove("urun_yonetimi");
            frmAnasayfa.TabCikar("urun_yonetimi");
        }

        private void btnUrunYonetimi_ExceleAktar_Click(object sender, EventArgs e)
        {
            #region EXCELE AKTAR

            Excel_Aktar(dgwUrunler);

            #endregion
        }
        private void Excel_Aktar(DataGridView VeriTablosu)
        {
            #region EXCEL AKTARIM
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;

            Microsoft.Office.Interop.Excel.Workbook kitap = excel.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet sheet = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];

            for (int i = 0; i < VeriTablosu.Columns.Count; i++)
            {
                Microsoft.Office.Interop.Excel.Range myrange = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[1, i + 1];
                myrange.Value2 = VeriTablosu.Columns[i].HeaderText;
            }

            for (int i = 0; i < VeriTablosu.Columns.Count; i++)
            {
                for (int j = 0; j < VeriTablosu.Rows.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myrange = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[j + 2, i + 1];
                    myrange.Value2 = VeriTablosu[i, j].Value;
                }
            }
            #endregion
        }

    }
}
