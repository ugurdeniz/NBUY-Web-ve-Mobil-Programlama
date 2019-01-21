using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Destructor
{
    class Program
    {
        static void Main(string[] args)
        {
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
        public Dolap(int kapakSayisi, string alinanRenk)
        {
            this.kapakSayisi = kapakSayisi;
            rengi = alinanRenk;
        }
        public Dolap(int kapakSayisi, string alinanRenk, string cinsi)
        {
            this.kapakSayisi = kapakSayisi;
            rengi = alinanRenk;
            this.cinsi = cinsi;
        }

        public Dolap()
        {
            //Sql e bağlan.
            //Token al ve bir servise bağlan.
        }
        ~Dolap()
        {
            //yıkıcı metot. Nesnenin ömrü bittiğinde ne yapılacağının kodlarını içerir.
            //sql bağlantısı kapat
            //token timeout.
        }
        public Dolap(int kapakSayisi, string alinanRenk, string cinsi, bool dolapAcikMi)
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
