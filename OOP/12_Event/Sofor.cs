using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Event
{
    class Sofor:Insan
    {
        public event TekIntParametreAlanEventTipi GazaBastim;
        public Sofor(string adSoyad):base(adSoyad)
        {

        }

        public void GazaBas(int gazaBasmaYuzdesi)
        {
            Console.WriteLine("Ben " + AdSoyad + ", %" + gazaBasmaYuzdesi + " kadar gaza bastım.");
            GazaBastim(gazaBasmaYuzdesi,this);
        }
    }
}
