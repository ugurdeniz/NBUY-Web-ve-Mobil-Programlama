using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Tokat
{
    public class Insan
    {
        public Insan(string adSoyad)
        {
            AdSoyad = adSoyad;
        }
        public string AdSoyad { get; private set; }
    }
}
