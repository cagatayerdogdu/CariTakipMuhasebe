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
    public partial class frmMusteriYonetimi : Form
    {
        double DoubleParseBag = 0;
        DAL budak;
        public int uye_id;
        string yetki_duzeyi;
        public frmMusteriYonetimi(int _uye_id, string _yetki_duzeyi)
        {
            InitializeComponent();
            uye_id = _uye_id;
            yetki_duzeyi = _yetki_duzeyi;
        }

        int secilen_kayit_id = 0;
        int secilen_kayit = 0;

        private void frmMusteriYonetimi_Load(object sender, EventArgs e)
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

            musteri_listele();
        }

        private void dgwMusteriler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            #region DGW GİRİŞ ÇİFT TIKLAMA
            //Kaydet butonu pasifleştiriliyor.
            //btnEkle.Enabled = false;
            //Seçilen satırdaki ürünün barkod numarası tespit ediliyor.
            string secilen_urun_serial = dgwMusteriler.CurrentRow.Cells[4].Value.ToString();

            secilen_kayit_id = Convert.ToInt32(dgwMusteriler.CurrentRow.Cells[0].Value);
            secilen_kayit = secilen_kayit_id;

            txtAdSoyad.Text = dgwMusteriler.CurrentRow.Cells[1].Value.ToString();
            txtTcKimlik.Text = dgwMusteriler.CurrentRow.Cells[2].Value.ToString();
            txtCepTel.Text = dgwMusteriler.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgwMusteriler.CurrentRow.Cells[4].Value.ToString();
            txtAdres.Text = dgwMusteriler.CurrentRow.Cells[5].Value.ToString();
            btnSil.Visible = true;
            btnKaydet.Text = "GÜNCELLE";
            #endregion
        }

        private void musteri_listele()
        {
            epHataDedektoru.Clear();

            string Arama = txtArama.Text.Trim();
            if (Arama == "")
            {
                dgwMusteriler.DataSource = budak.Sorgu_DataTable("SELECT m.musteri_id, m.ad_soyad, m.tc_kimlik, m.cep_tel, m.email, m.adres FROM fd_musteriler AS m WHERE m.tip='musteri' and Statu = 'A' ORDER BY m.ad_soyad");
            }
            else
            {
                epHataDedektoru.Clear();
                dgwMusteriler.DataSource = budak.Sorgu_DataTable("SELECT m.musteri_id, m.ad_soyad, m.tc_kimlik, m.cep_tel, m.email, m.adres FROM fd_musteriler AS m WHERE m.tip='musteri' and Statu = 'A' AND (m.ad_soyad LIKE @ad_soyad OR m.tc_kimlik LIKE @tc_kimlik OR m.cep_tel LIKE @cep_tel OR m.email LIKE @email) ORDER BY m.ad_soyad", "%" + Arama + "%", "%" + Arama + "%", "%" + Arama + "%", "%" + Arama + "%");
            }
        }

        private void dgwMusteriler_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                menuSecilenKaydiSifirlaToolStripMenuItem.Visible = true;
                menuSag.Show(dgwMusteriler.PointToScreen(e.Location));
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                #region EKLE BUTONU
                epHataDedektoru.Clear();
                Regex sayi_kontrolu = new Regex("0*[1-9][0-9]*");
                if (txtAdSoyad.Text.Trim().Length == 0)
                {
                    epHataDedektoru.SetError(txtAdSoyad, "Müşteri adını girmediniz.");
                }
                else
                {
                    int eklenen_kayit = 0;
                    if (secilen_kayit == 0)
                    {
                        eklenen_kayit = budak.Sorgu_Calistir_Eklenen_Id_Dondur("INSERT INTO fd_musteriler(tip, ad_soyad, tc_kimlik, cep_tel, email, adres, sabit_tel, fax, website, yetkili_kisi, firma_unvani, vergi_dairesi, vergi_no, notlar) VALUES('musteri', @ad_soyad, @tc_kimlik, @cep_tel, @email, @adres, '', '', '', '', '', '', '', '')", txtAdSoyad.Text.Trim(), txtTcKimlik.Text.Trim(), txtCepTel.Text.Trim(), txtEmail.Text.Trim(), txtAdres.Text.Trim());
                    }
                    else //Ürünün barkod numarası veritabanında kayıtlıysa, o ürün seçiliyor.
                    {
                        eklenen_kayit = secilen_kayit;
                        int Etki = budak.Sorgu_Calistir("UPDATE fd_musteriler SET ad_soyad=@ad_soyad, tc_kimlik=@tc_kimlik, cep_tel=@cep_tel, email=@email, adres=@adres WHERE musteri_id=@musteri_id", txtAdSoyad.Text.Trim(), txtTcKimlik.Text.Trim(), txtCepTel.Text.Trim(), txtEmail.Text.Trim(), txtAdres.Text.Trim(), eklenen_kayit.ToString());
                        if (Etki <= 0) eklenen_kayit = 0;
                    }

                    string bildirim = "";
                    if (eklenen_kayit > 0)
                    {
                        //bildirim = "Müşteri kaydı başarıyla eklenmiştir.";
                        menuSecilenKaydiSifirlaToolStripMenuItem_Click(null, null);
                        musteri_listele();
                    }
                    else
                    {
                        bildirim = "Müşteri eklenirken bir sorun oluştu.";
                    }

                    if(bildirim != "") MessageBox.Show(bildirim);
                }
                // ürünler giriş yapıldıktan sonra sayfa yenilenmiş gibi textboxları temizliyoruz.
                menuSecilenKaydiSifirlaToolStripMenuItem_Click(null, null);
                #endregion
            }
            catch (Exception hata)
            {
                //MessageBox.Show(hata.ToString()); 
            }
        }

        private void menuSecilenKaydiSifirlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            secilen_kayit_id = 0;
            secilen_kayit = 0;
            txtAdSoyad.Text = "";
            txtTcKimlik.Text = "";
            txtCepTel.Text = "";
            txtEmail.Text = "";
            txtAdres.Text = "";
            btnSil.Visible = false;
            btnKaydet.Text = "KAYDET";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili müşteriyi silmek istediğinizden emin misiniz?", "MÜŞTERİ SİLİNECEK", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                //int Etki = budak.Sorgu_Calistir("DELETE FROM musteriler WHERE musteri_id=@musteri_id", secilen_kayit.ToString());
                int Etki = budak.Sorgu_Calistir("update fd_musteriler set Statu = 'X' WHERE musteri_id=@musteri_id", secilen_kayit.ToString());
                if (Etki > 0)
                {
                    MessageBox.Show("Müşteri silinmiştir.");
                    menuSecilenKaydiSifirlaToolStripMenuItem_Click(null, null);
                    musteri_listele();
                }
                else
                {
                    MessageBox.Show("Müşteri silinemedi. Lütfen tekrar deneyin.");
                }
            }
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            musteri_listele();
        }

        public frmAnasayfa frmAnasayfa;
        public string EkranNo = "";
        private void frmUrunYonetimi_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAnasayfa.DiziFormlar.Remove(this);
            frmAnasayfa.DiziFormTag.Remove("musteri_yonetimi");
            frmAnasayfa.TabCikar("musteri_yonetimi");
        }

        private void btnMusteriYonetimi_ExceleAktar_Click(object sender, EventArgs e)
        {
            #region EXCELE AKTAR

            Excel_Aktar(dgwMusteriler);

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
