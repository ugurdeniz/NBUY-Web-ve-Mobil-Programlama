using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFonksiyonlari
{
    class Program
    {
        static void Main(string[] args)
        {
            float sayi = 3.9f;
            int sayi3 = 0;
            int sayi2;

            sayi2 = (int)Math.Ceiling(sayi);

            Console.WriteLine("Cellin Uste Yuvarlama "+sayi2);
            sayi2 = Math.Abs(sayi3);

            Console.WriteLine("Abs Mutlak Deger " + sayi2);

            sayi2 = (int)Math.Round(sayi);

            Console.WriteLine("Round Yuvarlama " + sayi2);

            sayi2 = (int)Math.Floor(sayi);

            Console.WriteLine("Floor Yuvarlama " + sayi2);

            sayi2 = (int)Math.Pow(4,0.5);

            Console.WriteLine("Pow Kuvvet Alma " + sayi2);

            sayi2= Math.Sign(sayi3);

            Console.WriteLine("Sign işaret " + sayi2);
            Console.ReadLine();
            

        }
    }
}
