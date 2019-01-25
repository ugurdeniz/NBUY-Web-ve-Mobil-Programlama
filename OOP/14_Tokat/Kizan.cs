using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Tokat
{
    class Kizan:Insan
    {
        public Kizan(string adSoyad) : base(adSoyad)
        {

        }
        public void TepkiVer(Insan tokatYiyen, Insan tokatAtan)
        {
            Console.WriteLine("Ben "+AdSoyad+","+"\""+tokatAtan.AdSoyad+","+tokatYiyen.AdSoyad+"'ye neden vurdun.\"");
        }
    }
}
