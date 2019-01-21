using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Ornekler
{
    class Program
    {
        static void Main(string[] args)
        {/*
             1- * ve # karakterlerini kullanarak 8x8 dama tahtasını ekrana yazan uygulamayı yazınız. 
             /*
              // EkranaDamaYaz(8, 8, "*", "#");
             /*             
            2- 6 haneli loto uygulaması yazınız. Başlama aşamasında 1-49 arasında rastgele 6 adet birbirinden farklı sayı belirlenecek. Kullanıcıdan 6 adet giriş yapması istenecek. Sonuç olarak kaç adet sayıyı tutturduğu kullanıcıya mesaj olarak verilecek. Sonrasında yeninden oynayıp oynamak istemediği kullanıcıya sorulacak ve bu duruma göre uygulama kapatılacak veya devam edecek.
            */
         //LotoUygulamasi();

            /*
            3- Cümle içinde karakter veya metin parçası arama uygulaması. Verilen cümle içinde istenilen karakter yapısının geçip geçmediğini, kaç adet geçtiğini sonuç olarak gösteren uygulamayı yazınız.
            */
            //KelimeAramaUygulamasi();
            /*
            4- String metotları kullanmadan girilen bir cümlenin tüm harflerini isteğe göre büyük harfe yada küçük harfe çeviren uygulamayı yazınız.
             */
            MetinDonusturUygulamasi();

        }

        private static void LotoUygulamasi()
        {
            const int lotoSayiAdeti = 6;
            //Karşılama Yaz
            EkranaYaz("*******************************\nLoto Uygulamasına HoşGeldiniz.\n*******************");
            //SatırBasiYap
            SatirBasiYap();
            //Birbirinden farklı lotoSayiAdeti kadar rastgele sayılar oluştur.
            int[] lotoSayilari = RastgeleFarkliSayilarOlustur(lotoSayiAdeti, 1, 49);
            //Kullanıcıdan lotoSayiAdeti adet sayı al.
            int[] kullanicininTahminSayilari = KullanicidanBirbirindenFarkliSayilarAl(lotoSayiAdeti, "Lütfen bir sayi tahmini giriniz: ", "Hatalı yada sınırlar dışında bir giriş yaptınız.\n", 1, 49);
            //alınan sayılardan kaçtanesi kullanıcının girişi ile tutuyor.
            int tutturulanSayiAdeti = DiziKarsilastir(lotoSayilari, kullanicininTahminSayilari);
            //LotoDizisiniYaz
            EkranaYaz(lotoSayilari);
            //Bir Satır Besle
            SatirBasiYap();
            //tutan sayı adetini ekrana yaz
            EkranaYaz("Tahminlerinizden " + tutturulanSayiAdeti + " tanesi loto sayıları ile tutmuştur.");
            //Yeniden oynamak isteyip istemediğini sor
            bool yenidenOynansinMi = BooleanSorusuSor("Tekrar oynamak istermisiniz?", "E", "H");
            //eğer istiyor ise başa al
            if (yenidenOynansinMi)
            {
                EkraniTemizle();
                LotoUygulamasi();
            }
            else
            {
                Cikis();
            }
        }

        /// <summary>
        /// Uygulama kullanıcıdan bir cümle ve bir kelime alır. Kelimenin cumle içinde kaç defa geçtiğini ekrana yazar.
        /// </summary>
        private static void KelimeAramaUygulamasi()
        {
            EkranaYaz("**********************************\nKelime Arama Uygulamasına Hoş Geldiniz.\n**********************************");
            SatirBasiYap();

            string cumle = KontrolluMetinAl("Lütfen bir cümle giriniz: ", "Herhangi bir giriş yapmadınız...!");

            string kelime = KontrolluMetinAl("Lütfen bir kelime giriniz: ", "Herhangi bir giriş yapmadınız...!");

            int adet = KacTaneVar(kelime, cumle);

            EkranaYaz("Girdiğiniz cümle içinde aradığınız kelime " + adet + " adet geçmektedir.");
            Beklet();
            Cikis();
        }

        private static void MetinDonusturUygulamasi()
        {
            EkranaYaz("**************************\nMetin Dönüştürme Uygulamasına Hoş Geldiniz..\n**************************");
            SatirBasiYap();
            string metin = KontrolluMetinAl("Lütfen dönüştürmek istediğiniz metni giriniz: ", "Hiçbir karakter girişi yapmadınız.");
            bool buyukHarfMi = BooleanSorusuSor("Lütfen küçük yada büyük harfe dönüştürme tercihinizi belirtiniz.", "buyuk", "kucuk");
            string donusmusMetin = MetinDonustur(metin, buyukHarfMi);
            EkranaYaz(donusmusMetin);
            Beklet();
            Cikis();
        }

        #region Framework
        private static string MetinDonustur(string metin, bool buyukHarfMi)
        {
            //karakter dizisine çevir
            char[] karakterDizisi = new char[metin.Length];
            for (int i = 0; i < metin.Length; i++)
            {
                karakterDizisi[i] = metin[i];
            }


            //Buyuğe ve küçüğe çevirme işlemi.
            for (int i = 0; i < karakterDizisi.Length; i++)
            {
                if ((karakterDizisi[i] >= 'a' && karakterDizisi[i] <= 'z') && buyukHarfMi)
                {
                    karakterDizisi[i] = (char)((int)karakterDizisi[i] -32 );
                }
                else if((karakterDizisi[i] >= 'A' && karakterDizisi[i] <= 'Z') && !buyukHarfMi)
                {
                    karakterDizisi[i] = (char)((int)karakterDizisi[i] + 32);
                }
            }

            //karater dizisini string değişkene çevirme.
            metin = "";
            for (int i = 0; i < karakterDizisi.Length; i++)
            {
                metin += karakterDizisi[i];
            }
            return metin;
        }
        static int KacTaneVar(string arananSey, string icindeAranan)
        {
            int kacTaneVar = 0;
            string arananSeyKucukHarfli = arananSey.ToLower();
            string icindeArananKucukHarfli = icindeAranan.ToLower();

            int index = 0 - arananSeyKucukHarfli.Length;
            do
            {
                index = icindeArananKucukHarfli.IndexOf(arananSeyKucukHarfli, (index + arananSeyKucukHarfli.Length));
                if (index >= 0)
                {
                    kacTaneVar++;
                }
            }
            while (index >= 0);
            return kacTaneVar;
        }
        static string KontrolluMetinAl(string istekMesaji, string hataMesaji)
        {
            EkranaYaz(istekMesaji);
            string input = EkrandanOku();
            if (input != null)
            {
                return input;
            }
            EkranaYaz(hataMesaji);
            SatirBasiYap();
            return KontrolluMetinAl(istekMesaji, hataMesaji);
        }

        /// <summary>
        /// Kullanıcıya evet/hayır - var/yok - soruları sormamızı sağlar. trueSecici ilgili soruya olumlu cevap verme metnidir. falseSecici olumsuz cevap verme metnidir.
        /// </summary>
        private static bool BooleanSorusuSor(string mesaj, string trueSecici, string falseSecici)
        {
            EkranaYaz(mesaj + " (" + trueSecici + "/" + falseSecici + ") :");
            string input = EkrandanOku();
            if (input.ToLower() == trueSecici.ToLower())
            {
                return true;
            }
            else if (input.ToLower() == falseSecici.ToLower())
            {
                return false;
            }
            else
            {
                EkranaYaz("İlgili seçim değerleri dışında bir giriş yaptınız...!");
                return BooleanSorusuSor(mesaj, trueSecici, falseSecici);
            }

        }

        /// <summary>
        /// İki diziyinin elemanlarını karşılaştırır. Her iki dizide de bulunan elemanların sayısını döner.
        /// </summary>
        private static int DiziKarsilastir(int[] birinciDizi, int[] ikinciDizi)
        {
            int eslesenSayiAdeti = 0;

            for (int i = 0; i < birinciDizi.Length; i++)
            {
                for (int j = 0; j < ikinciDizi.Length; j++)
                {
                    if (birinciDizi[i] == ikinciDizi[j])
                    {
                        eslesenSayiAdeti++;
                    }
                }
            }
            return eslesenSayiAdeti;
        }
        private static int[] KullanicidanBirbirindenFarkliSayilarAl(int istenecekSayiAdeti, string istekMesaji, string hataMesaji, int altSinir, int ustSinir)
        {
            int[] sayilar = new int[istenecekSayiAdeti];
            for (int i = 0; i < istenecekSayiAdeti; i++)
            {
                //Kontrollü Sayı Al 
                int alinanSayi = KontrolluSayiAl(istekMesaji, hataMesaji);
                //Alinan Sayı Dizide Varsa veya ilgili sınır dışındaysa bir daha yeni sayi al. 
                if (sayilar.Contains(alinanSayi) || alinanSayi < altSinir || alinanSayi > ustSinir)
                {
                    EkranaYaz(hataMesaji);
                    i--;
                    continue;
                }
                //değil ise diziye yaz.
                sayilar[i] = alinanSayi;
            }
            return sayilar;
        }
        private static int[] RastgeleFarkliSayilarOlustur(int olusturulacakSayiAdeti, int altSinir, int ustSinir)
        {
            int[] uretilenSayilar = new int[olusturulacakSayiAdeti];
            Random rd = new Random();
            for (int i = 0; i < olusturulacakSayiAdeti; i++)
            {
                int olusturulanSayi = rd.Next(altSinir, 10000000);
                olusturulanSayi = olusturulanSayi % (ustSinir + 1);
                if (uretilenSayilar.Contains(olusturulanSayi))
                {
                    i--;
                    continue;
                }
                uretilenSayilar[i] = olusturulanSayi;
            }
            return uretilenSayilar;
        }
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
        static string EkrandanOku()
        {
            return Console.ReadLine();
        }
        static void Beklet()
        {
            Console.ReadKey();
        }
        static void EkranaYaz(string metin)
        {
            Console.Write(metin);
        }
        static void SatirBasiYap()
        {
            Console.WriteLine();
        }
        static void EkranaDamaYaz(int satirSayisi, int sutunSayisi, string birinciKarakter, string ikinciKarakter)
        {
            int sekilAdeti = satirSayisi * sutunSayisi;
            for (int i = 0; i < sekilAdeti; i++)
            {
                if (i % sutunSayisi == 0 && i != 0)
                {
                    SatirBasiYap();
                }
                if ((i % sutunSayisi) % 2 == (i / sutunSayisi) % 2)
                {
                    EkranaYaz(birinciKarakter + " ");
                }
                else
                {
                    EkranaYaz(ikinciKarakter + " ");
                }

            }
        }
        static void EkraniTemizle()
        {
            Console.Clear();
        }
        private static void EkranaYaz(int[] sayilar)
        {
            for (int i = 0; i < sayilar.Length; i++)
            {
                EkranaYaz(sayilar[i].ToString() + " ");
            }
        }
        private static void Cikis()
        {
            Environment.Exit(0);
        }

        #endregion
    }
}
