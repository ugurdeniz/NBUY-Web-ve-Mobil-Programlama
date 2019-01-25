using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Abstraction.Abstract
{
    abstract class Hayvan
    {
        //Abstract Class
        //Kalıtım verir ama kendisinden Instance alınamaz.
        //Constructor yazılabilir. 
        //İçinde kod bulundurur..

        public Hayvan(int yas)
        {
            Kilo = 30;
        }


        public virtual int Yas { get; set; }
        public int Kilo { get; set; }
        public int Boy { get; set; }

        public void Beslen()
        {
            Console.Write("yemek yedim.");
        }


        //Abstract metot
        //Abstract classlar içinde bulunur.
        //babanın ben okumadım ama sen okuyacaksın zorlaması.
        public abstract void SesCikar();

    }
}
