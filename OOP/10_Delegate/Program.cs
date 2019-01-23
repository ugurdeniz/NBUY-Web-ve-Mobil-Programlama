using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Event
{   

    // Tip > Handler(metot degiskeni)> Scope Atama(metotların atanması) > Call(handler call) > atanan Metotlar çalışacak.
    /****************Delegate****************/
    public delegate int IslemTipi(int sayi1, int sayi2);
    public delegate void BirseyYapmaTipi();
    //
    class Program
    {
        public static IslemTipi Islem;
        public static BirseyYapmaTipi BirSeyYap;
        public static int Toplama(int a, int b)
        {
            return a + b;
        }

        public static int Cikarma(int a, int b)
        {
            return a - b;
        }

        public static void EkranaMerhabaYaz()
        {
            Console.WriteLine("Merhaba");
        }

        public static void EkranaGuleguleYaz()
        {
            Console.WriteLine("Gulegule");
        }

        public static void EkranaAlafortanfoniYaz()
        {
            Console.WriteLine("Alafortanfoni");
        }

        static void Main(string[] args)
        {
            //bool degilMi = false;
            //if (degilMi)
            //{
            //    Islem = Toplama;
            //}
            //else
            //{
            //    Islem = Cikarma;
            //}

            //int sonuc = Islem(4, 5);
            
            BirSeyYap += EkranaMerhabaYaz;        
            BirSeyYap += EkranaGuleguleYaz;
            BirSeyYap += EkranaAlafortanfoniYaz;
            BirSeyYap -= EkranaMerhabaYaz;
           // BirSeyYap = EkranaMerhabaYaz;
            BirSeyYap();
            Console.Read();
        }
    }
}
