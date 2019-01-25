using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {

        static void Main(string[] args)
        {
            Dikdortgen d;
            Kare k;

            Console.WriteLine("Dikdörtgen Alanı:" + d.AlanHesapla(5, 10));
            Console.WriteLine("Kare Alanı:" + k.AlanHesapla(6));

            Console.WriteLine(Dikdortgen.minAlan);
            Console.Read();
        }
    }
    struct Dikdortgen
    {
        public const int minAlan = 0;
        public int AlanHesapla(int KisaKenar, int UzunKenar)
        {
            int alan = KisaKenar * UzunKenar;
           
            return alan;
        }
    }
    struct Kare
    {
        public int AlanHesapla(int Kenar)
        {
            int alan = Kenar * Kenar;
            return alan;
        }
    }
}
