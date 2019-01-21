using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_MethodSignature_MethodOverloading
{
    class Program
    {
        //Metot kimliği
        //Metot ismi
        //Parametre sayısı
        //Parametre tipi

        //Method Overloading
        static int Topla(int sayi1, int sayi2, int sayi3=0)
        {
            return sayi1 + sayi2*sayi3;
        }

        static int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        static void Main(string[] args)
        {
            Topla(4, 5);
            Topla(4, 5, 6);
        }
    }
}
