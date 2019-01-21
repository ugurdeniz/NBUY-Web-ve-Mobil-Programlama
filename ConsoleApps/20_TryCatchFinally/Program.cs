using System;

namespace _20_TryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            //AnlatimSadeKullanim();
            //BirdenCokCatchKullanimi();
            Kaydet();
            Console.ReadKey();
        }

        static void AnlatimSadeKullanim()
        {
            //12 yi girilen değere böl 
            do
            {
                try
                {
                    //denenecek kod buraya yazılır.
                    int girilenDeger = KontrolluSayiAl("Lütfen bir sayı giriniz: ", "Sayıya dönüştürülemeyecek bir değer girdiniz!");
                    int sonuc = 12 / girilenDeger;
                    Console.Write("Kod başarı ile çalıştı.");
                    break;
                }
                catch (Exception ex)
                {
                    //hata olduğunda işletilecek kod
                    Console.Write("Hatalı bir sayı girildi.");
                    continue;
                }
                //bla bla
            } while (true);
        }

        static void OnemsizExceptionDurumu()
        {
            bool calistiMi = false;
            string isim = null; //herhangi bir süreç işletildi ve ekrandan değer gelmediği için isim null oldu.
            try
            {
                int uzunluk = isim.Length;
                calistiMi = true;
                //bu alanda exception fırlatabilecek bir durum var ama uygulama için önemsiz. 
            }
            catch (Exception)
            {

            }

            if (!calistiMi)
            {
                isim = EkrandanOku();
            }
        }

        static void BirdenCokCatchKullanimi()
        {
            //birden çok scope çalışmaz. exception ı ilk yakalayan scope çalışır.
            string isim = null;
            try
            {
                int uzunluk = isim.Length;
            }
            catch (NullReferenceException exc)
            {

            }
            catch (IndexOutOfRangeException exc)
            {

            }
            catch (FormatException exc)
            {

            }
            catch (Exception exc)
            {
                throw;
            }
        }

        static void Finally()
        {
            try
            {
                //sql bağlatısını aç
                //bir satırlık öge çek (öge yok ise null gelecek)
                //ilgili ögenin özelliklerine eriş.

            }
            catch (Exception)
            {
                //bla 
                //bla
            }
            finally
            {
                //bağlantıyı kapat.
            }
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

        private static void Kaydet()
        {
            string veri = "alafortanfoni";
            DBConnection("alafor");
            //db kaydet süreçlerini işlet..

        }
        private static void DBConnection(string token)
        {
            if (token != "alaf")
            {
                throw new Exception("Token hatalı");
              //  throw new NullReferenceException();
            }
        }

        static string EkrandanOku()
        {
            return Console.ReadLine();
        }

        private static void EkranaYaz(string metin)
        {
            Console.Write(metin);
        }
    }
}
