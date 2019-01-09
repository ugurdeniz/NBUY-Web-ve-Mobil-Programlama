using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            //a
            string degisken = Console.ReadLine();
            //b
            int sayi;
            string input = Console.ReadLine();
            bool kontrol = int.TryParse(input, out sayi);
            //c
            double c;
            input = Console.ReadLine();
            kontrol = double.TryParse(input, out c);
            //d
            input = Console.ReadLine();
            DateTime nesne = new DateTime();
            kontrol = DateTime.TryParse(input, out nesne);
            //e
            long degisken4 = 8888888888888888;
            int degisken5 = (int)degisken4;
            //f
            int f = 5;
            string degisken6 = Convert.ToString(f);
        }
    }
}
