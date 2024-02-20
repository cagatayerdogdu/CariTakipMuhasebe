using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace StokTakip
{
    public partial class frmSatisRaporu : Form
    {

        DAL budak; Fonksiyonlar Tornavida;
        public int uye_id;
        string yetki_duzeyi;
        string faturano = "";
        string secili_kayit_id = "";
        public frmSatisRaporu(int _uye_id, string _yetki_duzeyi)
        {
            InitializeComponent();
            uye_id = _uye_id;
            yetki_duzeyi = _yetki_duzeyi;
        }

        private void frmSatisRaporu_Load(object sender, EventArgs e)
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
            // Crystal raporun sol taraftaki gereksiz grup ağacı görüntüsünü kapatıyorum.
            //crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            //Properties ten kapattım.    //ToolPanelView = none

            dtSatisRaporu_1.Value = new DateTime(2020, 1, 1, 0, 0, 0);
            dtSatisRaporu_2.Value = DateTime.Now;//new DateTime(2020, 1, 1, 0, 0, 0);
        }

        public frmAnasayfa frmAnasayfa;
        public string EkranNo = "";

        private void frmSatisRaporu_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmSatisRaporu frm_SatisRaporu = new frmSatisRaporu(-1, "");
            frmAnasayfa.DiziFormlar.Remove(this);
            frmAnasayfa.DiziFormTag.Remove("satis_raporu");
            frmAnasayfa.TabCikar("satis_raporu");
            frm_SatisRaporu.Close();
        }

        private void btnRaporCalistir_Click(object sender, EventArgs e)
        {
            dgwSatisRaporu.ClearSelection(); // Son satır seçili getirdiğimizde yeniden çalıştırılınca hata veriyor o yüzden öncesinde dgv yi temizliyorum.

            string TarihBaslangic = dtSatisRaporu_1.Value.ToString("yyyy-MM-dd ") + "00:00";
            string TarihBitis = dtSatisRaporu_2.Value.ToString("yyyy-MM-dd ") + "23:59";

            DateTime TarihBaslangic_Date = Tornavida.TarihToDateTime(TarihBaslangic);
            DateTime TarihBitis_Date = Tornavida.TarihToDateTime(TarihBitis);

            DataTable dtSatisRaporu = budak.Sorgu_DataTable(@" select case when fm.ad_soyad is null then 'TOPLAM SATIŞ' else fm.ad_soyad end ad_soyad
		,sum(fs.toplam_fiyat_kdv_dahil) satis_tutari
		/*,(select sum(toplam_fiyat_kdv_dahil) from fd_satislar where tip = 'satis' and statu = 'A' 
			and cast(tarih as date) between '2020-06-1 00:00' AND '2020-06-30 23:59') Toplam_Satis		*/	
    from fd_satislar fs
    join fd_musteriler fm on fs.musteri_id = fm.musteri_id
    where  fs.tip = 'satis' and fs.statu = 'A' 
		and cast(tarih as date) between '"+ TarihBaslangic_Date.ToString() + "' AND '"+ TarihBitis_Date.ToString() + "' group by rollup(fm.ad_soyad)");
            
            dgwSatisRaporu.DataSource = dtSatisRaporu;
            //Son satır seçili ve scroll bar orada olsun işlemi için.
            if (dgwSatisRaporu.RowCount>0)
            {
                dgwSatisRaporu.Rows.OfType<DataGridViewRow>().Last().Selected = true;
                dgwSatisRaporu.CurrentCell = dgwSatisRaporu.Rows.OfType<DataGridViewRow>().Last().Cells.OfType<DataGridViewCell>().First();
            }
            else
            {
                MessageBox.Show("Seçilen tarihler arasında satış kaydı bulunamamıştır.");
            }

        }
    }
}
