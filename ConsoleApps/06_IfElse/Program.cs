using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            //if (true)
            //{

            //}

            //if (true)
            //{

            //}
            //else
            //{

            //}


            //if (true)
            //{

            //}
            //else if (true)
            //{

            //}
            //else if (true)
            //{

            //}
            //else if (true)
            //{

            //}
            //else
            //{

            //}

            //dışarıdan girilen sıfır dışındaki sayı eğer 9 a tam bölünüyor ise ekrana bu sayı 9 tam bölünür yazsın.

            //Console.Write("Lütfen bir sayı giriniz: ");
            //string input = Console.ReadLine();
            //// int girilenSayi = Convert.ToInt32(input);
            //int girilenSayi = 0;
            //bool donustuMu = int.TryParse(input, out girilenSayi);
            //if(donustuMu && girilenSayi!=0 && girilenSayi%9==0)
            //{
            //    Console.WriteLine("Sayı 9 a bölünür");
            //    Console.ReadKey();
            //}

            //Dışarıdan okunan sayının pozitif, negatif yada 0 değeri olduğunu söyleyen uygulamayı yazınız. Eğer sayısal olmayan bir ifade girilmiş ise program hata vermeli.
            Console.Write("Lütfen bir sayı giriniz: ");
            string input = Console.ReadLine();
            int girilenSayi = 0;
            bool donustuMu = int.TryParse(input, out girilenSayi);

            if(!donustuMu)
            {
                Console.WriteLine("Hatalı giriş yaptınız.");
            }
            else if (girilenSayi==0)
            {
                Console.WriteLine("Sayı sıfırdır.");
            }
            else if(girilenSayi>0)
            {
                Console.WriteLine("Pozitif Sayı girdiniz.");
            }
            else
            {
                Console.WriteLine("Negatif Sayı girdiniz.");
            }
            Console.Read();
        }
    }
}
