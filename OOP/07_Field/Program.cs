using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Field
{
    class Program
    {
        static void Main(string[] args)
        {
            int kapakSayisi; //değişken.
            Dolap dolap = new Dolap();
            dolap._kapakSayisi = 4;
            Ucgen ucgen = new Ucgen(3, 4, 5);
           Console.WriteLine(Insan._globalIfade);
            Insan insan = new Insan();
            
        }
    }

    class Dolap
    {
        public int _kapakSayisi;
    }

    class Ucgen
    {
        public Ucgen(int birinciKenarUzunlugu, int ikinciKenarUzunlugu, int ucuncuKenarUzunlugu)
        {
            _birinciKenarUzunlugu = birinciKenarUzunlugu;
            _ikinciKenarUzunlugu = ikinciKenarUzunlugu;
            _ucuncuKenarUzunlugu = ucuncuKenarUzunlugu;
        }
        public int _birinciKenarUzunlugu;
        public int _ikinciKenarUzunlugu;
        public int _ucuncuKenarUzunlugu;
    }


    class Insan
    {
      public static string _globalIfade = "Alafortanfoni"; //global ifade
        public string _ad;
        public int _yas;

        void Uyu()
        {
            string ruya = "bla bla";
            string ninni = "dan dini dan dini";
            int koyunSayisi = 0;
            for (int i = 0; i < 10; i++)
            {
                koyunSayisi++;
                bool UyudunMu = false;
            }
        }

        void Uyan()
        {

        }
    }


}
