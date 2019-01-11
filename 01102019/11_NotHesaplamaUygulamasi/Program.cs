using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_NotHesaplamaUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Kullanıcı adı ve şifre al. Girilen değerler önceden belirlenen değerler ile uyuşuyorsa hoşgeldiniz yaz.Eğer kullanıcı adı tutmuyorsa hata mesajı ver. Eğer kullanıcı adı tutuyor şifre tutmuyorsa, doğru şifre girilene kadar şifre iste

            string defaultKullaniciAdi = "ugur", defaultSifre = "123";
            string girilenKullaniciAdi, girilenSifre;

            while (true)
            {
                Console.WriteLine("Kullanıcı Adını Giriniz");
                girilenKullaniciAdi = Console.ReadLine();
                Console.WriteLine("Sifreyi Giriniz");
                girilenSifre = Console.ReadLine();

                if (defaultKullaniciAdi != girilenKullaniciAdi)
                {
                    Console.WriteLine("Kullanıcı adı ve/veya şifre hatalı");
                    continue;
                }

                else if (defaultKullaniciAdi == girilenKullaniciAdi && defaultSifre != girilenSifre)
                {
                    Console.WriteLine("Hatalı Şifre");

                    while (true)
                    {
                        Console.WriteLine("Sifreyi Giriniz");
                        girilenSifre = Console.ReadLine();
                        if (girilenSifre == defaultSifre)
                        {
                            break;
                        }
                    }

                    Console.WriteLine("HOŞGELDİNİZ \n");
                    break;
                }
            } 
            #endregion

            #region Ders menüsünü yaz         
            Console.Write(@"**************************************** 
Lütfen not hesaplanacak dersi seçiniz...
1 - Fizik
2 - Kimya
3 - Matematik
4 - Yapay Zeka
5 - Görüntü İşleme
6 - Örüntü İşleme
7 - İşlemsel Matematik
8 - Programlamaya Giriş
*****************************************
Seçiminiz: ");
            #endregion

            #region Ders seçimini oku ve kontrol et
            //1-8 dışında değer girildiğinde hata verip uygulamayı kapat
            string input = Console.ReadLine();
            int dersSecimi = 0;
            bool secimSayisalIfadeMi = int.TryParse(input, out dersSecimi);

            if (!secimSayisalIfadeMi || dersSecimi < 1 || dersSecimi > 8)
            {
                Console.WriteLine("Hatalı bir not seçimi yaptınız.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            #endregion

            #region Seçilen Dersi Değişkene Ata
            string dersAdi = "";
            switch (dersSecimi)
            {
                case 1:
                    dersAdi = "Fizik";
                    break;
                case 2:
                    dersAdi = "Kimya";
                    break;
                case 3:
                    dersAdi = "Matematik";
                    break;
                case 4:
                    dersAdi = "Yapay Zeka";
                    break;
                case 5:
                    dersAdi = "Görüntü İşleme";
                    break;
                case 6:
                    dersAdi = "Örüntü İşleme";
                    break;
                case 7:
                    dersAdi = "İşlemsel Matematik";
                    break;
                case 8:
                    dersAdi = "Programlamaya Giriş";
                    break;
                default:
                    {
                        Console.WriteLine("Hatalı Giriş Yaptız");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                    break;
            }
            #endregion

            #region Ekranı Temizle
            //İlgili seçim sonrasında console ekranı temizlenecek ilgili kod = Console.Clear();
            Console.Clear();
            #endregion

            #region öğrenci menüsü yaz
            //Lütfen notu hesaplanacak öğrenciyi seçiniz...
            //1 - Osman Yazıcı
            //2 - Ayşe Defne Kaldırım
            //3 - Mehmet Şensoy
            //4 - Kürşad Bostan
            //5 - Uğur Deniz
            //6 - Süphan Savaş
            //7 - Engin Ayvaz
            //8 - Zeynep Bilgili
            //Seçiminiz:
            Console.Write(@"Lütfen notu hesaplanacak öğrenciyi seçiniz...
1 - Osman Yazıcı
2 - Ayşe Defne Kaldırım
3 - Mehmet Şensoy
4 - Kürşad Bostan
5 - Uğur Deniz
6 - Süphan Savaş
7 - Engin Ayvaz
8 - Zeynep Bilgili
Seçiminiz: ");
            #endregion

            #region Değer oku ve kontrol et
            //1-8 dışında değer girildiğinde hata verip uygulamayı kapat
            input = Console.ReadLine();
            int ogrenciSecimi = 0;
            secimSayisalIfadeMi = int.TryParse(input, out ogrenciSecimi);

            if (!secimSayisalIfadeMi || ogrenciSecimi < 1 || ogrenciSecimi > 8)
            {
                Console.WriteLine("Hatalı bir seçim yaptınız.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            #endregion

            #region Seçilen Öğrenciyi Değişkene Ata
            string adSoyad = "";

            switch (ogrenciSecimi)
            {
                case 1:
                    adSoyad = "Osman Yazıcı";
                    break;
                case 2:
                    adSoyad = "Ayşe Defne Kaldırım";
                    break;
                case 3:
                    adSoyad = "Mehmet Şensoy";
                    break;
                case 4:
                    adSoyad = "Kürşad Bostan";
                    break;
                case 5:
                    adSoyad = "Uğur Deniz";
                    break;
                case 6:
                    adSoyad = "Süphan Savaş";
                    break;
                case 7:
                    adSoyad = "Engin Ayvaz";
                    break;
                case 8:
                    adSoyad = "Zeynep Bilgili";
                    break;
                default:
                    {
                        Console.WriteLine("Hatalı Giriş Yaptız");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                    break;
            }
            #endregion

            #region Ekranı Temizle
            //İlgili seçim sonrasında console ekranı temizlenecek ilgili kod = Console.Clear();
            Console.Clear();
            #endregion
            #region Yanlış sayısal girişlerde hata gösterip ilgili değer tekrar istenecek
            #region 1. vizenin alımı


            int birinciVizeNotu = 0;
            while (true)
            {
                Console.Write("Lütfen 1. vize notunu giriniz: ");
                input = Console.ReadLine();

                bool birinciVizeNotuSayisalGirildiMi = int.TryParse(input, out birinciVizeNotu);

                if (!birinciVizeNotuSayisalGirildiMi || birinciVizeNotu < 0 || birinciVizeNotu > 100)
                {
                    Console.WriteLine("Hatalı bir giriş yaptınız.");
                    continue;

                }
                break;
            }


            #endregion

            #region 2. vizenin alımı
            int ikinciVizeNotu = 0;
            while (true)
            {
                Console.Write("Lütfen 2. vize notunu giriniz: ");
                input = Console.ReadLine();

                bool ikinciVizeNotuSayisalGirildiMi = int.TryParse(input, out ikinciVizeNotu);
                if (!ikinciVizeNotuSayisalGirildiMi || ikinciVizeNotu < 0 || ikinciVizeNotu > 100)
                {
                    Console.WriteLine("Hatalı bir giriş yaptınız.");
                    continue;
                }
                break;
            }
            #endregion

            #region Final notunun alımı
            int finalNotu = 0;
            while (true)
            {
                Console.Write("Lütfen final notunu giriniz: ");
                input = Console.ReadLine();

                bool finalNotuSayisalGirildiMi = int.TryParse(input, out finalNotu);
                if (!finalNotuSayisalGirildiMi || finalNotu < 0 || finalNotu > 100)
                {
                    Console.WriteLine("Hatalı bir giriş yaptınız.");
                    continue;
                }
                break;
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
            //Sonrasında ilk yazdığınız kodları bu uygulamaya uyarlayacaksınız.
        }
    }
}
