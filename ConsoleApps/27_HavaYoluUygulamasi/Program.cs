using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_HavaYoluUygulamasi
{
    class Program
    {
        const int koltukSayisi = 20;
        const int bussinessClassKoltukSayisi = 8;
        static string[] koltuklar = new string[koltukSayisi];
        const string BussinessClass = "1";
        const string EconomyClass = "2";
        static void Main(string[] args)
        {
            EkranaYaz("1. Bussiness Class bölümü için 1 tuşuna basınız.\n2. Economy Class bölümü için 2 tuşuna basınız.");
            SatirBasiYap();
            string secim = SecimYap("Lütfen seçiminizi giriniz: ", "Hatalı seçim girdiniz..", "1", "2");
            EkraniTemizle();
            if(secim==BussinessClass)
            {
                BussinessClassSatisiBaslat();
            }
            else if(secim==EconomyClass)
            {
                EconomyClassSatisiBaslat();
            } 
        }
        private static void EconomyClassSatisiBaslat()
        {
            int[] bosKoltukNumaralari = BosKoltuklariGetir(EconomyClass);
            if(bosKoltukNumaralari.Length==0)
            {
                bool digerBolumdenSatisiIstiyorMu = BooleanSorusuSor("Seçtiğiniz Economy Class bölümünde boş koltuk kalmamıştır. Bussiness class bölümündeki koltukları görmek istermisiniz?", "E", "H");
                if(digerBolumdenSatisiIstiyorMu)
                {
                    BussinessClassSatisiBaslat();
                    return;
                }
                else
                {
                    EkranaYaz("Bir sonraki uçuş kayıtları 4 saat sonradır.");
                    Beklet();
                    Main(null);
                    return;
                }
            }
            BosKoltuklariEkranaYaz(bosKoltukNumaralari, EconomyClass);

            int koltukSecimi = KontrolluSayiAl("Lütfen koltuk numarasını giriniz: ", "Hatalı bir giriş yaptınız.", bussinessClassKoltukSayisi+1, koltukSayisi);
            EkraniTemizle();
            EkranaYaz("Secilen Koltuk numarası: " + koltukSecimi);
            SatirBasiYap();
            if(koltuklar[koltukSecimi-1]!=null)
            {
                DoluKoltukHataMesajiVer(koltukSecimi);
                EconomyClassSatisiBaslat();
                return;
            }
            KoltukSatisiYap(koltukSecimi,EconomyClass);
        }
        private static void BussinessClassSatisiBaslat()
        {
            int[] bosKoltukNumaralari = BosKoltuklariGetir(BussinessClass);
            if (bosKoltukNumaralari.Length == 0)
            {
                bool digerBolumdenSatisiIstiyorMu = BooleanSorusuSor("Seçtiğiniz Bussiness Class bölümünde boş koltuk kalmamıştır. Economy class bölümündeki koltukları görmek istermisiniz?", "E", "H");
                if (digerBolumdenSatisiIstiyorMu)
                {
                    EconomyClassSatisiBaslat();
                    return;
                }
                else
                {
                    EkranaYaz("Bir sonraki uçuş kayıtları 4 saat sonradır.");
                    Beklet();
                    Main(null);
                    return;
                }
            }
            BosKoltuklariEkranaYaz(bosKoltukNumaralari, BussinessClass);

            int koltukSecimi = KontrolluSayiAl("Lütfen koltuk numarasını giriniz: ", "Hatalı bir giriş yaptınız.", 1, bussinessClassKoltukSayisi);
            EkraniTemizle();
            EkranaYaz("Secilen Koltuk numarası: " + koltukSecimi);
            SatirBasiYap();
            if (koltuklar[koltukSecimi - 1] != null)
            {
                DoluKoltukHataMesajiVer(koltukSecimi);
                BussinessClassSatisiBaslat();
                return;
            }
            KoltukSatisiYap(koltukSecimi, BussinessClass);
        }
        private static void KoltukSatisiYap(int koltukSecimi,string secim)
        {
            string input = KontrolluMetinAl("Lütfen yolcunun adını ve soyadını giriniz: ","Yolcu adı ve soyadı boş geçilemez.");
            koltuklar[koltukSecimi - 1] = input;
            EkraniTemizle();
            if(secim==EconomyClass)
            {
                EkranaYaz("Economy Class bölümündeki " + koltukSecimi + " numaralı koltuğu " + input + " isimli yolcuya rezerve ettiniz.");
            }
            else if (secim==BussinessClass)
            {
                EkranaYaz("Bussiness Class bölümündeki " + koltukSecimi + " numaralı koltuğu " + input + " isimli yolcuya rezerve ettiniz.");
            }
            SatirBasiYap();
            EkranaYaz("Devam Etmek için bir tuşa basınız.");
            Beklet();
            EkraniTemizle();
            Main(null);           
        }
        private static void DoluKoltukHataMesajiVer(int koltukSecimi)
        {
            EkranaYaz(koltukSecimi + " numaralı koltuğu daha önce " + koltuklar[koltukSecimi - 1] + " isimli yolcuya rezerve ettiniz!\nLütfen boş koltuklardan birini seçiniz.");
        }
        private static void BosKoltuklariEkranaYaz(int[] bosKoltukNumaralari,string secim)
        {
            if(secim==EconomyClass)
            {
                EkranaYaz("Economy Class Bölümündeki Boş Koltuklar:");
            }
            else if(secim==BussinessClass)
            {
                EkranaYaz("Bussiness Class Bölümündeki Boş Koltuklar:");
            }
            SatirBasiYap();
            BosKoltuklariEkranaYaz(bosKoltukNumaralari);
        }
        private static void BosKoltuklariEkranaYaz(int[] bosKoltukNumaralari)
        {
            for (int i = 0; i < bosKoltukNumaralari.Length; i++)
            {
                EkranaYaz("- " + bosKoltukNumaralari[i]);
                SatirBasiYap();
            }
        }
        private static int[] BosKoltuklariGetir(string secim)
        {
            if(secim==EconomyClass)
            {
                return BosKoltuklariGetir(bussinessClassKoltukSayisi, koltuklar.Length);
            }
            else
            {
                return BosKoltuklariGetir(0, bussinessClassKoltukSayisi);
            }
        }
        private static int[] BosKoltuklariGetir(int baslangicIndisi, int bitisIndisi)
        {
            int[] bosKoltuklar = new int[0];
            for (int i = baslangicIndisi; i < bitisIndisi; i++)
            {
                if(koltuklar[i]==null)
                {
                    Array.Resize(ref bosKoltuklar, bosKoltuklar.Length + 1);
                    bosKoltuklar[bosKoltuklar.Length - 1] = i + 1;
                }
            }
            return bosKoltuklar;
        }

        #region Framework
        
        static string SecimYap(string istekMesaji,string hataMesaji,params string[] degerHavuzu)
        {
            EkranaYaz(istekMesaji);
            string input = KontrolluMetinAl(istekMesaji, hataMesaji);
            if(degerHavuzu.Contains(input))
            {
                return input;
            }
            EkranaYaz(hataMesaji);
            return SecimYap(istekMesaji, hataMesaji, degerHavuzu);
        }

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
                    karakterDizisi[i] = (char)((int)karakterDizisi[i] - 32);
                }
                else if ((karakterDizisi[i] >= 'A' && karakterDizisi[i] <= 'Z') && !buyukHarfMi)
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
        private static int KontrolluSayiAl(string istekMesaji, string hataMesaji,int altSinir,int ustSinir)
        {
            bool donustuMu = false;
            int sayi = 0;
            do
            {
                EkranaYaz(istekMesaji);
                string input = EkrandanOku();

                donustuMu = int.TryParse(input, out sayi);
                if (!donustuMu|| sayi>ustSinir || sayi<altSinir)
                {
                    EkranaYaz(hataMesaji);
                }
            } while (!donustuMu || sayi > ustSinir || sayi < altSinir);
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
