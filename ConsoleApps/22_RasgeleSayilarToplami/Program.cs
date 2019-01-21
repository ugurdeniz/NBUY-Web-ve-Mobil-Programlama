using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_RasgeleSayilarToplami
{
    class Program
    {
        ///Kullanıcıdan alınan sayı adeti kadar rastgele 0 ile 100 arasında sayı üretip hepsini yan yana ekrana yazdıktan sonra alt satırda ortalamasını yazan uygulamayı yazınız.
        static void Main(string[] args)
        {
            //Karşıla
            EkranaYaz("***************\nHoşgeldiniz\n**************");
            //Satırbaşı yap
            SatirBasiYap();
            //Kontrollü olarak bir sayı al
            int sayiAdeti = KontrolluSayiAl("Lütfen sayi adetini giriniz: ", "Hatalı giriş yaptınız.");
            //Girilen sayı kadar rasgele sayı üret
            int[] sayilar = RasgeleSayilarUret(sayiAdeti);
            //Diziyi Ekrana Yaz
            EkranaYaz(sayilar);
            //satirbasiyap
            SatirBasiYap();
            //Dizi ortalamasını hesapla
            double ortalama = DiziOrtalamasiniAl(sayilar);
            //Ortalamayı Ekrana Yaz
            EkranaYaz(ortalama);
            //Bekle  
            Bekle();
        }

        static void SatirBasiYap()
        {
            Console.WriteLine();
        }

        /// <summary>
        /// istekMesajini ekrana yazıp kullanıcıdan bir sayi ister. eğer kullanıcı sayıya dönüşemeyecek bir giriş yapar ise hataMesajını gösterip yeniden sayı ister. eğer kullanıcı sayıya dönüşebilecek bir değer girer ise sayıya çevirip ilgili değeri döner.
        /// </summary>
        private static int KontrolluSayiAl(string istekMesaji, string hataMesaji)
        {
            bool donustuMu = false;
            int sayi = 0;
            do
            {
                EkranaYaz(istekMesaji);
                string input = EkrandanOku();
                
                donustuMu = int.TryParse(input, out sayi);
                if (!donustuMu)
                {
                    EkranaYaz(hataMesaji);
                }                
            } while (!donustuMu);
            return sayi;
        }


        /// <summary>
        /// Ekrandan metin okur
        /// </summary>
        static string EkrandanOku()
        {
            return Console.ReadLine();
        }


        /// <summary>
        /// aldığı parametreyi ekrana yazar.
        /// </summary>
        private static void EkranaYaz(string metin)
        {
            Console.Write(metin);
        }


        /// <summary>
        /// Bir tuşa basılana kadar ekranı bekletir.
        /// </summary>
        private static void Bekle()
        {
            Console.ReadKey();
        }


        /// <summary>
        /// alınan sayı değerini ekrana yazar.
        /// </summary>
        private static void EkranaYaz(double sayi)
        {
            EkranaYaz(sayi.ToString());
        }


        /// <summary>
        /// Girilen dizi içerisindeki sayıların ortalamasını döner
        /// </summary>
        private static double DiziOrtalamasiniAl(int[] sayilar)
        {
            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
            double ortalama = (double)toplam / sayilar.Length;
            return ortalama;
        }


        /// <summary>
        /// Verilen diziyi aralarında boşluk bırakarak bir satırda yan yana yazar
        /// </summary>
        private static void EkranaYaz(int[] sayilar)
        {
            for (int i = 0; i < sayilar.Length; i++)
            {
                EkranaYaz(sayilar[i].ToString() + " ");
            }
        }


        /// <summary>
        /// Verilen parametredeki adet kadar 0 ile 100 arasında rasgele sayılar üretir.
        /// </summary>
        private static int[] RasgeleSayilarUret(int sayiAdeti)
        {
            Random rd = new Random();
            int[] sayilar = new int[sayiAdeti];
            for (int i = 0; i < sayiAdeti; i++)
            {
                sayilar[i] = rd.Next(0, 100);
            }
            return sayilar;
        }

    }
}
