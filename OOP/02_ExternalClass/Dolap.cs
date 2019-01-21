using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ExternalClass
{
   class Dolap
    {
        public int kapakSayisi;
        public string rengi;
        public string cinsi;
        public int yuksekligi;
        public int genisligi;
        public int derinligi;
        bool dolapAcikMi = false;

        public void KapakAc()
        {
            if (dolapAcikMi)
            {
                Console.WriteLine("Dolap zaten açık");
            }
            else
            {
                Console.WriteLine("kapak acildi");
                dolapAcikMi = true;
            }
        }

        public void KapakKapat()
        {
            if (dolapAcikMi)
            {
                Console.WriteLine("kapak kapandi");
                dolapAcikMi = false;
            }
            else
            {
                Console.WriteLine("Dolap zaten kapalı");
            }

        }
    }
}
