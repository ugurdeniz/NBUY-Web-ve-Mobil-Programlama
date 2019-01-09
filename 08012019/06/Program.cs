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
            string giris;
            int eb=0,ek=999999999,sayi;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}. Sayıyı girin" + (i + 1));
                giris = Console.ReadLine();
                bool kontrol = int.TryParse(giris, out sayi);
                if (kontrol)
                {
                    if (sayi>eb)
                    {
                        eb = sayi;
                    }
                    if (sayi<ek)
                    {
                        ek = sayi;
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz değer");
                }
                
            }
            Console.WriteLine("En büyük sayı= {0} \n En küçük sayı= {1}", eb, ek);
        }
    }
}
