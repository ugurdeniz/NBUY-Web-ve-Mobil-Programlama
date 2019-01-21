using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Class
{
    //nesnenin nasıl olacağının tasarısı
    //inşaatın projesi
    //tüm classlar object classından türer..
    class Program
    {
        static void Main(string[] args)
        {
            Dolap dolap = new Dolap(); //instance
            Dolap dolap2;
            Dolap dolap3 = new Dolap();
            Dolap dolap4 = new Dolap();
            dolap.kapakSayisi = 2;
            dolap.rengi = "kirmizi";
            dolap.yuksekligi = 180;
            dolap.genisligi = 100;

            dolap3 = dolap; //değerler dediğimiz alan aslında heap referans adresleridir. 
                            //dolap3=dolap4;
                            //dolap3=new Dolap();

            Console.WriteLine(dolap3.kapakSayisi);
            Console.WriteLine(dolap3.rengi);
            Console.WriteLine(dolap3.yuksekligi);
            Console.WriteLine(dolap3.genisligi);
            Console.WriteLine(dolap3.cinsi);

            dolap3.cinsi = "Sunta";
            Console.WriteLine(dolap.cinsi);
            Console.ReadLine();
            
            dolap3.KapakAc();
            dolap3.KapakAc();
            Console.ReadLine();
        }
    }

   public class Dolap
    {
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
