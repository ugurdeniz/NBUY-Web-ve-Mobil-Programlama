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
            int degisken2 = int.Parse(Console.ReadLine());
            //c
            double degisken3 = Convert.ToInt64(Console.ReadLine());
            //d
            DateTime nesne = new DateTime();
            nesne = Convert.ToDateTime(Console.ReadLine());
            //e
            long degisken4 = 8888888888888888;
            int degisken5 = (int)degisken4;
            //f
            int sayi = 5;
            string degisken6 = Convert.ToString(sayi);
        }
    }
}
