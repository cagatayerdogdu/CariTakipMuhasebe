using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip
{
    public class Fonksiyonlar
    {
        int IntParseBag; double DoubleParseBag;
        public double FiyatHesapla(string Fiyat, string KdvOrani, bool KdvDahil, bool SonucKdvDahil)
        {
            double Sonuc = 0;

            Fiyat = Fiyat.Replace('.', ',');

            double FiyatDouble = double.TryParse(Fiyat, out DoubleParseBag) ? DoubleParseBag : 0;
            FiyatDouble = Math.Round(FiyatDouble, 4, MidpointRounding.AwayFromZero);


            //string FiyatFormatli = String.Format("{0:0.00}", FiyatDouble);
            //FiyatDouble = double.Parse(FiyatFormatli);


            int KdvOraniInt = int.TryParse(KdvOrani, out IntParseBag) ? IntParseBag : 0;
            double FiyatHam = 0; double FiyatKdvDahil = 0;
            double Kdv = 0;
            if (KdvDahil)
            {
                Kdv = Bol(FiyatDouble * KdvOraniInt, 100 + KdvOraniInt);
                FiyatHam = FiyatDouble - Kdv;
                FiyatKdvDahil = FiyatDouble;
            }
            else
            {
                Kdv = Bol(FiyatDouble * KdvOraniInt, 100);
                FiyatHam = FiyatDouble;
                FiyatKdvDahil = FiyatDouble + Kdv;
            }

            Sonuc = SonucKdvDahil ? FiyatKdvDahil : FiyatHam;

            return Math.Round(Sonuc, 4, MidpointRounding.AwayFromZero);
            //return Sonuc;  //[CE_26.04.2020 19:55]
    }

        public string FiyatFormatla(string Fiyat, string Hedef = "veritabanı", string Kusurat = "00")
        {
            string Sonuc = Fiyat;
            if (Hedef == "veritabanı")
            {
                Sonuc = Sonuc.Replace('.', ','); //double virgül ister
                double FiyatDouble = double.TryParse(Sonuc, out DoubleParseBag) ? DoubleParseBag : 0;
                Sonuc = String.Format("{0:0." + Kusurat + "}", FiyatDouble);
                Sonuc = Sonuc.Replace(',', '.'); //veritabanı nokta ister
            }
            else if(Hedef == "sistem")
            {
                Sonuc = Sonuc.Replace('.', ',');
                if (!double.TryParse(Sonuc, out DoubleParseBag)) Sonuc = "0";
            }
            return Sonuc;
        }

        public DateTime TarihToDateTime(string Tarih)
        {
            DateTime Sonuc = new DateTime();
            if (Tarih != "") //[CE_01.02.2020 01:08] // Gerek olmayabilir para alış/veriş te açıklamasını yazdım.
            {
                var Tarih2 = Tarih;
                Sonuc = Convert.ToDateTime(Tarih2);
            }
            else
            {
                int yil = int.Parse(Tarih.Substring(0, 4));
                int ay = int.Parse(Tarih.Substring(4, 2));
                int gun = int.Parse(Tarih.Substring(6, 2));
                int saat = int.Parse(Tarih.Substring(8, 2));
                int dakika = int.Parse(Tarih.Substring(10, 2));
                Sonuc = new DateTime(yil, ay, gun, saat, dakika, 0);
            }
            return Sonuc;
        }

        public double Bol(double Bolunen, double Bolen)
        {
            double Sonuc = 0;
            try
            {
                Sonuc = Bolunen / Bolen;
            }
            catch (Exception e)
            {
                Sonuc = 0;
            }
            return Sonuc;
        }
        public string FaturaNo (string faturano)
        {
            string Sonuc = faturano;

            Sonuc = Sonuc.Substring(1, Sonuc.Length-1);
            int Uzunluk = Sonuc.Length;
            string _sonuc = "";
            string sayi1;
            int sayi = 0;

            for (int i = 0; i < Uzunluk; i++)
            {
                sayi1 = Sonuc.Substring(i,1);
                sayi += Convert.ToInt32(sayi1);
                
                if (sayi == 0)
                {
                    _sonuc += sayi.ToString();
                }
            }
          
            Sonuc = _sonuc;
            return Sonuc;
        }
    }
}
