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
            bool kontrol;
            int s1, s2;
            string g1, g2;
            g1 = Console.ReadLine();
            g2 = Console.ReadLine();
            kontrol = int.TryParse(g1, out s1);
            kontrol= int.TryParse(g2, out s2);

            if (kontrol)
            {
                //a
                Console.WriteLine("Toplamı= " + (s1 + s2));
                //b
                Console.WriteLine("Farkı= " + (s1 - s2));
                //c
                Console.WriteLine("Çarpımı= " + (s1 * s2));
                //d
                Console.WriteLine("Bölümü= " + (s1 / s2));
                //e
                Console.WriteLine("İki ondalıklı sayı girin");
            }

            double s3, s4;
            s3 = Convert.ToDouble(Console.ReadLine());
            s4 = Convert.ToDouble(Console.ReadLine());
            if (s3!=0 && s4!=0 )
            {
                Console.WriteLine("Toplamı= " + (s3 + s4));

                Console.WriteLine("Farkı= " + (s3 - s4));

                Console.WriteLine("Çarpımı= " + (s3 * s4));

                Console.WriteLine("Bölümü= " + (s3 / s4));
            }
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
