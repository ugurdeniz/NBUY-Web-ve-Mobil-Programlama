using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int kucukSayi = 2;
            long buyukSayi = kucukSayi; //implicit atama. 

            long buyukSayi2 = 1;
            int kucukSayi2 = (int)buyukSayi2; //explicit atama

            long buyukSayi3 = 3000000000;
            int kucukSayi3 = (int)buyukSayi3;

            object birSey = 5; //boxing               
            int sayi8 = (int)birSey; //unboxing
            //boxing ve unboxing primitive;

            //byte sayi = 1;
            //int sayi2 = (int)((long)sayi);

            Console.WriteLine(buyukSayi);
            Console.WriteLine(kucukSayi2);
            Console.WriteLine(kucukSayi3);
            Console.ReadLine();

            //Değer kayıpsız dönüşüm yapar. Eğer dönüştüremez ise  ???
            int sayi3=Convert.ToInt32("123");
            long sayi4 = Convert.ToInt64("123");
            short sayi5 = Convert.ToInt16(null);


            int sayi6= int.Parse(null);
            int sayi7 = 0;
            bool donustuMu = int.TryParse("123", out sayi7);
            Console.WriteLine(sayi6);
            Console.ReadLine();
        }
    }
}
