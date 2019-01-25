using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Abstraction.Interface
{
    class AhmetAbi:ICigkofteYapabilen,ITurkuSoyleyebilen
    {
        public void CigkofteYogur()
        {
            Console.WriteLine("Ciğköfte yoğurtttdum");
        }

        public void TurkuSoyle()
        {
            Console.WriteLine("Urfanın etrafı dumanlı dağlar aman aman.");
        }
    }
}
