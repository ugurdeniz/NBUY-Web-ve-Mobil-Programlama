using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Abstraction.Interface
{
    class TurkuBar
    {
        public void Eğlendir(ITurkuSoyleyebilen türkücü)
        {
            türkücü.TurkuSoyle();
        }
    }
}
