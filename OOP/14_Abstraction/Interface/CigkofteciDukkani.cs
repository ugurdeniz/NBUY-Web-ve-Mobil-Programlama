using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Abstraction.Interface
{
    class CigkofteciDukkani
    {
        public void CigkofteUret(ICigkofteYapabilen calisan)
        {
            calisan.CigkofteYogur();
            Console.WriteLine("Çiğköfte üretildi");
        }
    }
}
