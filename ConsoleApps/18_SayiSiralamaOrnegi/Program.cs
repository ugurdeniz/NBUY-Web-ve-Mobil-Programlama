using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_SayiSiralamaOrnegi
{
    class Program
    {
        /*Kullanıcıdan belirlirsiz sayıda sayı alınacak
 * end yazıldığında sayı alama bitirilecek
 * ilgili sayılar büyükten küçüğe ve küçükten büyüğe olmak üzere 2 satır halinde ekrana yazılacaktır.
 */
        static void Main(string[] args)
        {
            //Karşılama ekranını yaz
            KarsilamaEkraniYaz();
            //Bir Satır Besle
            BirSatirBesle();
            //Kullanıcıdan end yazılana kadar sayı al
            int[] sayilar = KullanicidanSayilarAl();
            //Ekranı Temizle
            EkraniTemizle();
            //Sayıları Büyükten Küçüğe sırala
            int[] buyuktenKucugeSiraliSayilar = BuyuktenKucugeSayiSirala(sayilar);
            //Ekrana yaz
            DiziyiEkranaYaz(buyuktenKucugeSiraliSayilar);
            //Bir Satır Besle
            BirSatirBesle();
            //Sayıları Küçükten Büyüğe sırala 
            int[] kucuktenBuyugeSiraliSayilar = KucuktenBuyugeSayiSirala(sayilar);
            //Ekrana yaz
            DiziyiEkranaYaz(kucuktenBuyugeSiraliSayilar);
            //Ekranda Kal
            Beklet();
        }

        private static void Beklet()
        {
            Console.ReadKey();
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
            int[] sayilar = new int[0];
            bool bittiMi = false;
            //End yazılana kadar sayı alınacak
            do
            {
                int sayi = 0;
                bittiMi = KontrolluSayiAl(out sayi);
                if (!bittiMi)
                {
                    DiziyeElemanEkle(ref sayilar, sayi);
                }
            } while (!bittiMi);

            return sayilar;
        }

        private static void DiziyeElemanEkle(ref int[] sayilar, int sayi)
        {
            Array.Resize(ref sayilar, sayilar.Length + 1);
            sayilar[sayilar.Length - 1] = sayi;
        }

        private static bool KontrolluSayiAl(out int sayi)
        {
            sayi = 0;
            do
            {
                EkranaYaz("Lütfen Bir Sayı Giriniz:");
                string input = EkrandanOku();
                if (input.ToLower() == "end")
                {
                    return true;
                }
                else
                {
                    bool donustuMu = int.TryParse(input, out sayi);
                    if (donustuMu)
                    {
                        return false;
                    }
                    else
                    {
                        EkranaYaz("Hatalı bir değer girdiniz.");
                    }
                }
            } while (true);
        }

        private static string EkrandanOku()
        {
            return Console.ReadLine();
        }

        private static void BirSatirBesle()
        {
            Console.WriteLine();
        }

        private static void KarsilamaEkraniYaz()
        {
            EkranaYaz(@"*********************************
Sayı sıralama uygulamasına hoşgeldiniz.
********************************");
        }
    }
}
