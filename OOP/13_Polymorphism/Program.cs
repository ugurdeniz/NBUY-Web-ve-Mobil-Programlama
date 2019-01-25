using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Hayvan hayvan = new Hayvan();
            TanitVeSesVer(hayvan);            

            Hayvan kus = new Kus();
            TanitVeSesVer(kus);

            Hayvan kedi = new Kedi();
            kedi.Yas = 21;
            TanitVeSesVer(kedi);
           

            Hayvan zurafa = new Zurafa();
            TanitVeSesVer(zurafa);

            Hayvan kopek = new Kopek();
            TanitVeSesVer(kopek);

            Kurt kurt = new Kurt();
            TanitVeSesVer(kurt);

            Console.ReadKey();
        }

        public static void TanitVeSesVer(Hayvan hayvan)
        {
            Console.Write("Benim Adım:" + hayvan.Ad + " Çıkardığım ses:");
            hayvan.SesCikar();
            Console.WriteLine("Yaşım:" + hayvan.Yas);
            Console.WriteLine();
        }
    }
}
