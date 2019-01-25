using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _14_Abstraction.Abstract;
using _14_Abstraction.Interface;

namespace _14_Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hayvan hayvan = new Hayvan(); hata verir
            //Kedi kedi = new Kedi(10);
            //kedi.SesCikar("cik cik");
            //Islem(kedi);


            //CigkofteciDukkani dukkan = new CigkofteciDukkani();
            //MehmetAbi mehmetAbi = new MehmetAbi();
            //AhmetAbi ahmetAbi = new AhmetAbi();
            //CigkofteMakinasi makina = new CigkofteMakinasi();
            //dukkan.CigkofteUret(makina);

            TurkuBar bar = new TurkuBar();
            AhmetAbi turkucu = new AhmetAbi();
            bar.Eğlendir(turkucu);
            Console.ReadKey();

            
        }
        static void Islem(Hayvan hayvan)
        {
            hayvan.Beslen();
            Console.WriteLine(hayvan.Kilo);
            hayvan.SesCikar();
            Console.ReadKey();
        }
    }
}
