using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Event
{
    class Toz
    {
        public event ParametresizEventTipi TozUcustu;

        public void Ucus(int ruzgarHizi, object sender)
        {
            if (sender is Araba)
            {
                if (ruzgarHizi > 50)
                {
                    Console.WriteLine("toz ucuştu");
                    TozUcustu();
                }
            }

        }
    }
}
