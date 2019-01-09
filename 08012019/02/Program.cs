using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İki Sayı girin");
            int s1, s2;
            s1 = int.Parse(Console.ReadLine());
            s2= int.Parse(Console.ReadLine());
           
            //a
            Console.WriteLine("Toplamı= " + (s1+s2));
            //b
            Console.WriteLine("Farkı= " + (s1 - s2));
            //c
            Console.WriteLine("Çarpımı= " + (s1 * s2));
            //d
            Console.WriteLine("Bölümü= " + (s1 / s2));
            //e
            Console.WriteLine("İki ondalıklı Sayı girin");
            double s3, s4;
            s3 = Convert.ToDouble(Console.ReadLine());
            s4 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Toplamı= " + (s3 + s4));
         
            Console.WriteLine("Farkı= " + (s3 - s4));
         
            Console.WriteLine("Çarpımı= " + (s3 * s4));
            
            Console.WriteLine("Bölümü= " + (s3 / s4));
            //f
            Console.WriteLine("İlk Sayıyı ondalıklı ikinci sayıyı tam sayı girin");
            double s5;
            int s6;
            s5 = Convert.ToDouble(Console.ReadLine());
            s6 = int.Parse(Console.ReadLine());
            Console.WriteLine("Toplamı= " + (s5 + s6));

            Console.WriteLine("Farkı= " + (s5 - s6));

            Console.WriteLine("Çarpımı= " + (s5 * s6));

            Console.WriteLine("Bölümü= " + (s5 / s6));
        }
    }
}
