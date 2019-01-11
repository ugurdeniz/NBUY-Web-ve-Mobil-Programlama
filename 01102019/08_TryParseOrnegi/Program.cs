using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_TryParseOrnegi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bir sayı giriniz: ");
            string input = Console.ReadLine();
            int girilenSayi = 0;
            bool donustuMu = int.TryParse(input, out girilenSayi);
            if (!donustuMu)
            {
                Console.WriteLine("Hatalı giriş yaptınız.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Girmiş olduğunuz sayı:" + girilenSayi);
            }
        }
    }
}
