using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiSiralamaOrnegi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan belirsiz sayıda sayı alınacak
            //end yazıldığında sayı alma bitecek
            //ilgili sayılar büyükten küçüğe ve küçükten büyüğe olmak üzere 2 satır halinde ekrana yazılacaktır.

            //karşılama ekranını yaz
            KarsilamaEkraniYaz();
            //bir satır besle
            BirSatirBesle();
            //kullanıcıdan end yazılana kadar sayı al
            int[] sayilar = KullanicidanSayilarAl();
            //ekranı temizle
            EkraniTemizle();
            //sayıları büyükten küçüğe sırala
            int[] buyuktenKucugeSiraliSayilar= BuyuktenKucugeSayiSirala(sayilar);
            //ekrana yaz
            DiziyiEkranaYaz(buyuktenKucugeSiraliSayilar);
            //bir satır besle
            BirSatirBesle();
            //sayıları küçükten büyüğe sırala
            int[] kucuktenBuyugeSiraliSayilar = KucuktenBuyugeSayiSirala(sayilar);
            //Ekrana Yaz
            DiziyiEkranaYaz(kucuktenBuyugeSiraliSayilar);
            //Ekranda Kal
            Beklet();

        }

        private static void Beklet()
        {
            throw new NotImplementedException();
        }

        private static int[] KucuktenBuyugeSayiSirala(int[] sayilar)
        {
            Array.Sort(sayilar);
            return sayilar;
        }

        private static void DiziyiEkranaYaz(int[] dizi)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                EkranaYaz(dizi[i].ToString() + " ");
            }
        }

        private static void EkranaYaz(string metin)
        {
            Console.Write(metin);
        }

        private static int[] BuyuktenKucugeSayiSirala(int[] sayilar)
        {
            KucuktenBuyugeSayiSirala(sayilar);
            Array.Reverse(sayilar);
            return sayilar;

        }

        private static void EkraniTemizle()
        {
            Console.Clear();
        }

        private static int[] KullanicidanSayilarAl()
        {
            //End yazılana kadar sayı alınacak
            //EkranaYaz(lütfen bir sayı giriniz
            do
            {
                EkranaYaz("Lütfen Bir Sayı giriniz");
                string input = EkrandanOku();
                //Eğer end yazılmış ise donguyu bitir
            } while (true);
            EkranaYaz("Ekrana Yaz");
        }

        private static string EkrandanOku()
        {
            throw new NotImplementedException();
        }

        private static void BirSatirBesle()
        {
            Console.Write("\n");
        }

        private static void KarsilamaEkraniYaz()
        {
            EkranaYaz("Hoşgeldiniz");
        }
    }
}
