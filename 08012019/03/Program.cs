using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            //a
            int s1, s2;
            s1 = int.Parse(Console.ReadLine());
            s2 = int.Parse(Console.ReadLine());
            if (s1==s2)
            {
                Console.WriteLine("Eşit");
            }
            else
            {
                Console.WriteLine("Eşit Değil");
            }
            //b
            string c1, c2;
            c1 = Console.ReadLine();
            c2 = Console.ReadLine();
            if (c1==c2)
            {
                Console.WriteLine("Eşit");
            }
            //c
            char c3, c4;
            c3 = Convert.ToChar(Console.ReadLine());
            c4 = Convert.ToChar(Console.ReadLine());
            if (c3==c4)
            {
                Console.WriteLine("Eşit");
            }
        }
    }
}
