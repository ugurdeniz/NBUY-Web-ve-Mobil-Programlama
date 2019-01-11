using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            //işlemsel oparatörler
            //=
            //+,-,*,/
            //%,^  4%2=>0 2^3=8


            //++,-- b=5 b++ =>b=6
            //+=,-=,*=,/=  b=5, b+=4; 


            //mantıksal oparatörler (bool)
            //>,<,>=,<=,==,!= (<>),! !true=false

            //&& ve ilk false gördüğünde diğer ifadelere bakmaz false döner
            //|| veya ilk true gördüğünde diğer ifadelere bakmaz true döner
            //& ve ilk false dönse bile tüm ifadeleri kıyaslar (çalıştırır)
            //| veya ilk true dönse bile tüm ifadeleri kıyaslar (çalıştırır)
            //string metin = "osman" + "yazici"; //oparatör overloading

            //bool sonuc = 5 > 4;
            //bool sonuc2 = Console.ReadLine() == "osman" | Console.ReadLine() == "yazici" | Console.ReadLine() == "hasan";
            //bool sonuc3 = sonuc2 && EkranaYaz();
            //sonuc3 = sonuc2 != true && EkranaYaz2();

            //string isim = 5 > 4 ? "osman" : "hasan";


            Console.Write("Lütfen şifrenizi giriniz: ");
            string input = Console.ReadLine();
            bool sonuc = input == "osman" && input == "yazici" && input == "hasan" ? EkranaYaz() : EkranaYaz2();
        }

        static bool EkranaYaz()
        {
            Console.WriteLine("Hoşgeldiniz.");
            Console.ReadLine();
            return true;
        }

        static bool EkranaYaz2()
        {
            Console.WriteLine("Yanlış Giriş.");
            Console.ReadLine();
            return true;
        }
    }
}
