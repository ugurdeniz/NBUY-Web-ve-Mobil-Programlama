using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DamaTahtası
{
    class Program
    {
        static void Main(string[] args)
        {
            //* ve # karakterlerini kullanarak 8*8 dama tahtasını ekrana yazan program
            int kacinciSatir = 0;
            int satirSayisi = 8;
            int sutunSayisi = 8;

            for (int i = 0; i < satirSayisi; i++)
            {
                for (int j = 0; j < sutunSayisi/2; j++)
                {
                    if (kacinciSatir % 2 == 0)
                    {
                        Console.Write("*" + " " + "#" + " ");
                    }
                    else
                    {
                        Console.Write("#" + " " + "*" + " ");
                    }

                }
                kacinciSatir++;
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
