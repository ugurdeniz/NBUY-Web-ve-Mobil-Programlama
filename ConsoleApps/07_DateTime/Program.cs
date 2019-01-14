using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen doğum tarihini giriniz: ");
            string input = Console.ReadLine();
            DateTime tarih = Convert.ToDateTime(input);
            DateTime suAn = DateTime.Now;
            int yas = ((int)(suAn - tarih).TotalDays) / 0;
            Console.WriteLine("Yaşınız: " + yas +(3>5));
            Console.WriteLine("Yaşınız: \"{{ {0} }}\" \t | Hesaplanan Tarih:{1} \n | Doğum Tarihi:{2}", yas, suAn,tarih);
            Console.ReadKey();            
        }
    }
}
