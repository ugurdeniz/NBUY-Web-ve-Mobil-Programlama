using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Tokat
{
    class TokatYiyen:Insan
    {
        public event EventTipi2 TokatYedim;
        public TokatYiyen(string adSoyad) : base(adSoyad)
        {

        }
        public void TokatYe(Insan tokatAtan)
        {
            Console.WriteLine("Ben "+AdSoyad+","+ tokatAtan.AdSoyad+" 'dan tokat yedim.");
            TokatYedim(this,tokatAtan);
        }
    }
}
