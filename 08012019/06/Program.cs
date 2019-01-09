using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            string eb=10,ek=5,giris;
            int sayi;
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("{0}. Sayıyı girin" + (i + 1));
                giris = Console.ReadLine();
                bool kontrol = int.TryParse(giris, out sayi);
                if (kontrol)
                {
                    if (sayi>eb)
                    {

                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz değer");
                }
                
            }
        }
    }
}
