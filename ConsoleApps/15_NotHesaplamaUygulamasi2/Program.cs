using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_NotHesaplamaUygulamasi2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Not hesaplama uygulamasına hoşgeldiniz.");
            #region Kaynaklar
            string[] ogrenciListesi = {};
            string[] dersListesi = {};

            #region Ders Listesi Al
            Console.WriteLine("Lütfen işlem yapmak istediğiniz derslerin girişini yapınız.\n\"Tamam\" yazarak giriş işlemini bitirebilirsiniz.");
            do
            {
                Console.Write((dersListesi.Length + 1) + ". Ders adını giriniz:");
                string input1 = Console.ReadLine();
                if(input1.ToLower()=="tamam")
                {
                    break;
                }
                Array.Resize(ref dersListesi, dersListesi.Length + 1);
                dersListesi[dersListesi.Length - 1] = input1;
            } while (true);

            if(dersListesi.Length==0)
            {
                Console.WriteLine("Hiç ders girişi yapmadığınızdan uygulama kapatılacaktır.");
                Console.ReadKey();
                Environment.Exit(0);                
            }
            #endregion
            Console.Clear();

            #region Öğrenci Listesi Alımı
            Console.WriteLine("Lütfen işlem yapmak istediğiniz öğrencilerin ad ve soyad girişini yapınız.\n\"Tamam\" yazarak giriş işlemini bitirebilirsiniz.");
            do
            {
                Console.Write((ogrenciListesi.Length + 1) + ". Öğrenci adını ve soyadını giriniz:");
                string input1 = Console.ReadLine();
                if (input1.ToLower() == "tamam")
                {
                    break;
                }
                Array.Resize(ref ogrenciListesi, ogrenciListesi.Length + 1);
                ogrenciListesi[ogrenciListesi.Length - 1] = input1;
            } while (true);

            if (ogrenciListesi.Length == 0)
            {
                Console.WriteLine("Hiç öğrenci girişi yapmadığınızdan uygulama kapatılacaktır.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            #endregion

            Console.Clear();

            #endregion

            #region not menüsünü yaz
            Console.WriteLine("****************************************\nLütfen not hesaplanacak dersi seçiniz...");

            for (int i = 0; i < dersListesi.Length; i++)
            {
                Console.WriteLine((i + 1) + " - " + dersListesi[i]);
            }

            Console.Write("*****************************************\nSeçiminiz: ");
            #endregion

            #region Değer oku ve kontrol et
            //liste dışında bir seçim yapılır ise hata vermeli
            string input = Console.ReadLine();
            int dersSecimi = 0;
            bool secimSayisalIfadeMi = int.TryParse(input, out dersSecimi);

            if (!secimSayisalIfadeMi || dersSecimi < 1 || dersSecimi > dersListesi.Length)
            {
                Console.WriteLine("Hatalı bir not seçimi yaptınız.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            #endregion

            #region Seçilen Dersi Bul
            string dersAdi = dersListesi[dersSecimi - 1];
            #endregion

            #region Ekranı Temizle
            //İlgili seçim sonrasında console ekranı temizlenecek ilgili kod = Console.Clear();
            Console.Clear();
            #endregion

            #region öğrenci menüsü yaz
            Console.WriteLine("Lütfen notu hesaplanacak öğrenciyi seçiniz...");

            for (int i = 0; i < ogrenciListesi.Length; i++)
            {
                Console.WriteLine((i + 1) + " - " + ogrenciListesi[i]);
            }

            Console.Write("Seçiminiz: ");
            #endregion

            #region Değer oku ve kontrol et
            //1-8 dışında değer girildiğinde hata verip uygulamayı kapat
            input = Console.ReadLine();
            int ogrenciSecimi = 0;
            secimSayisalIfadeMi = int.TryParse(input, out ogrenciSecimi);

            if (!secimSayisalIfadeMi || ogrenciSecimi < 1 || ogrenciSecimi > ogrenciListesi.Length)
            {
                Console.WriteLine("Hatalı bir seçim yaptınız.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            #endregion

            #region Seçilen Öğrenciyi Bul
            string adSoyad = ogrenciListesi[ogrenciSecimi-1];
            #endregion

            #region Ekranı Temizle
            //İlgili seçim sonrasında console ekranı temizlenecek ilgili kod = Console.Clear();
            Console.Clear();
            #endregion
            #region tam sayı olarak 2 vize bir final notu dışarıdan alınacak 0-100 aralığı dışında not girildiğinde hata verip uygulama kapatılacak.
            #region 1. vizenin alımı
            Console.Write("Lütfen 1. vize notunu giriniz: ");
            input = Console.ReadLine();
            int birinciVizeNotu = 0;
            bool birinciVizeNotuSayisalGirildiMi = int.TryParse(input, out birinciVizeNotu);
            if (!birinciVizeNotuSayisalGirildiMi || birinciVizeNotu < 0 || birinciVizeNotu > 100)
            {
                Console.WriteLine("Hatalı bir giriş yaptınız.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            #endregion

            #region 2. vizenin alımı
            Console.Write("Lütfen 2. vize notunu giriniz: ");
            input = Console.ReadLine();
            int ikinciVizeNotu = 0;
            bool ikinciVizeNotuSayisalGirildiMi = int.TryParse(input, out ikinciVizeNotu);
            if (!ikinciVizeNotuSayisalGirildiMi || ikinciVizeNotu < 0 || ikinciVizeNotu > 100)
            {
                Console.WriteLine("Hatalı bir giriş yaptınız.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            #endregion

            #region Final notunun alımı
            Console.Write("Lütfen final notunu giriniz: ");
            input = Console.ReadLine();
            int finalNotu = 0;
            bool finalNotuSayisalGirildiMi = int.TryParse(input, out finalNotu);
            if (!finalNotuSayisalGirildiMi || finalNotu < 0 || finalNotu > 100)
            {
                Console.WriteLine("Hatalı bir giriş yaptınız.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            #endregion
            #endregion            
            #region Not Hesapla
            //1.vizenin %20 si
            //2.vizenin %30 u
            //finalin %50 
            float ortalama = birinciVizeNotu * 0.2F + ikinciVizeNotu * 0.3F + finalNotu * 0.5F;
            #endregion

            #region Sonucu Yaz
            //Geçme notu 70  
            //Son çıktı "Osman Yazıcı Fizik dersinden 70 not alıp Geçti/Kaldı"
            Console.WriteLine(adSoyad + " " + dersAdi + " dersinden " + (int)ortalama + " alıp " + (ortalama >= 70 ? "Geçti" : "Kaldı"));
            #endregion

            #region Bitir
            Console.ReadKey();
            #endregion

        }
    }
}
