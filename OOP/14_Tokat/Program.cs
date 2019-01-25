using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Tokat
{
    public delegate void EventTipi(Insan yapan);
    public delegate void EventTipi2(Insan birinciInsan, Insan ikinciInsan);
    
    class Program
    {
        static void Main(string[] args)
        {
            TokatAtan tokatci = new TokatAtan("Osman");
            TokatYiyen kurban = new TokatYiyen("Emre");
            Kizan[] kizanlar = new Kizan[100];

            tokatci.TokatAttim += kurban.TokatYe;

            for (int i = 0; i < 100; i++)
            {
                kizanlar[i] = new Kizan("Caner Hoca"+(i+1));
                kurban.TokatYedim += kizanlar[i].TepkiVer;               
            }

            tokatci.Vur();

            Console.ReadKey();
        
        }
    }
}
