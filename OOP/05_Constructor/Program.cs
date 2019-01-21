using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Dolap dolap = new Dolap(2,"kahverengi");
            Console.WriteLine(dolap.rengi);

            Dolap dolap2 = new Dolap(2, "kahverengi","Sunta");
            Console.WriteLine(dolap2.cinsi);

            Dolap dolap3 = new Dolap();
            Console.WriteLine(dolap3.cinsi);

            Dolap dolap4 = new Dolap(2, "kahverengi", "Sunta",true);
            dolap4.KapakAc();

            Console.ReadLine();

        }
    }

    class Dolap
    {
        //default constructor 
        //yazmasakta olur.
        //nesne oluşma anında atanacak değerlerin atanması veya yapılacak işlemlerin yapılması
        //public Dolap()
        //{

        //}

         static Dolap()
        {
//İlk çalışacak constructor.
        }
        public Dolap(int kapakSayisi,string alinanRenk)
        {
            this.kapakSayisi = kapakSayisi;
            rengi = alinanRenk;
        }
        public Dolap(int kapakSayisi, string alinanRenk,string cinsi)
        {
            this.kapakSayisi = kapakSayisi;
            rengi = alinanRenk;
            this.cinsi = cinsi;
        }

        public Dolap()
        {

        }

        public Dolap(int kapakSayisi, string alinanRenk, string cinsi,bool dolapAcikMi)
        {
            this.kapakSayisi = kapakSayisi;
            rengi = alinanRenk;
            this.cinsi = cinsi;
            this.dolapAcikMi = dolapAcikMi;
        }


        public int kapakSayisi;
        public string rengi;
        public string cinsi;
        public int yuksekligi;
        public int genisligi;
        public int derinligi;
        bool dolapAcikMi = false;

        public void KapakAc()
        {
            if (dolapAcikMi)
            {
                Console.WriteLine("Dolap zaten açık");
            }
            else
            {
                Console.WriteLine("kapak acildi");
                dolapAcikMi = true;
            }
        }

        public void KapakKapat()
        {
            if (dolapAcikMi)
            {
                Console.WriteLine("kapak kapandi");
                dolapAcikMi = false;
            }
            else
            {
                Console.WriteLine("Dolap zaten kapalı");
            }

        }

    }



}
