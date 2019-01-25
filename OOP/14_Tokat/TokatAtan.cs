using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Tokat
{
    class TokatAtan:Insan
    {
        public event EventTipi TokatAttim;
        public TokatAtan(string adSoyad):base (adSoyad)
        {

        }
        public void Vur()
        {
            Console.WriteLine(AdSoyad+" tokat attı.");
           TokatAttim(this);           
        }
    }
}
