using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_SifreOrnegi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcıdan kullanıcı adı ve şifre değerleri istenecek. ilgili değerler sizin önceden belirlediğiniz değerler ile tutuyor ise "hoşgeldiniz" mesahı verilecek. Her iki değer alındıktan sonra değerler kontrol edilecek. Eğer kullanıcı adı tutmuyor ise "hatalı kullanıcı adı ve şifresi" şeklinde mesaj verecek. kullanıcıdan yeniden kullanıcı adı ve şifresi istenecek. Eğer kullanıcı adı tutarlı ama şifre tutmuyor ise "hatalı şifre" mesajı verilecek. Bu durumda kullanıcı adı istenmeyecek. Doğru giriş yapılana kadar sadece şifre istemeye devam edeceğiz.*/
            string kullaniciAdi = "osman";
            string sifre = "alafor";

            string alinanKullaniciAdi = null;
            string alinanSifre = null;

            do
            {
                Console.Write("Lütfen Kullanıcı Adını Giriniz:");
                alinanKullaniciAdi = Console.ReadLine();

                Console.Write("Lütfen şifreyi giriniz:");
                alinanSifre = Console.ReadLine();

                if (alinanKullaniciAdi == kullaniciAdi)
                {
                    break;
                }
                Console.WriteLine("Hatalı kullanıcı adı ve şifre");

            } while (true);

            #region goto kullanımı
            //etiket:
            //Console.Write("Lütfen Kullanıcı Adını Giriniz:");
            //alinanKullaniciAdi = Console.ReadLine();

            //Console.Write("Lütfen şifreyi giriniz:");
            //alinanSifre = Console.ReadLine();

            //if (alinanKullaniciAdi == kullaniciAdi)
            //{
            //    goto son;
            //}
            //Console.WriteLine("Hatalı kullanıcı adı ve şifre");
            //if (true)
            //{ goto etiket; }           
            //son:
            #endregion

            while (alinanSifre != sifre)
            {
                Console.WriteLine("Hatalı şifre");
                Console.Write("Lütfen şifreyi giriniz:");
                alinanSifre = Console.ReadLine();
            }

            Console.WriteLine("Hoşgeldiniz.");
            Console.ReadKey();
        }
    }
}
