using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Event
{


    class Polis : Insan
    {
        public Polis(string adSoyad) : base(adSoyad)
        {

        }

        public void HiziKontrolEt(int hiz, object sender)
        {

            if (sender is Araba)
            {
                Araba araba = sender as Araba; //cast in öbür hali.
                                               // Araba araba = (Araba)sender;
                if (hiz >= 120)
                {
                    CezaKes(hiz,araba.Plaka,araba.Sofor.AdSoyad);
                }
            }

        }

        public void CezaKes(int hiz,string plaka,string cezaYiyen)
        {
            Console.WriteLine(plaka+" plakalı arac ile "+hiz + " km hız yaptığından, "+cezaYiyen+" isimli şahsa "+AdSoyad+" isimli memur tarafından ceza kesildi.");
        }
    }
}
