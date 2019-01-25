using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            int günSayisal = (int)HaftanınGünleri.Salı;
            HaftanınGünleri günMetinsel = (HaftanınGünleri)5;

            HaftanınGünleri gün = HaftanınGünleri.Cuma;
            if(gün==HaftanınGünleri.Cuma)
            {
                Console.WriteLine("Bugün Cuma");
            }  
            Console.Read();
        }
    }

    public enum HaftanınGünleri
    {
        Pazartesi =1,
        Salı=2,
        Çarşamba=3,
        Perşembe=4,
        Cuma=5,
        Cumartesi=6,
        Pazar=7
    }

}
