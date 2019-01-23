using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Event
{
 

    class Polis:Insan
    {
        public Polis(string adSoyad):base(adSoyad)
        {

        }
        
        public void HiziKontrolEt(int hiz)
        {
            if(hiz>=120)
            {
                CezaKes(hiz);
            }
        }

        public void CezaKes(int hiz)
        {
            Console.Write(hiz+" km hızla gidildiğinden dolayı ceza Kesildi.");
        }
    }
}
