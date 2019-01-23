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
            Helper.Topla(3,6);
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

        //değişken ile farkları
        //Ramdeki yeri (heap)
        //Canlılık süresi (nesne canlı olduğu sürece)
        //Kullanım mantığı (nesne canlı olduğu sürece unutulmayan nesnenin bir bilgisi)

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

    class Helper
    {
        public static int Topla(int birinciSayi,int ikinciSayi)
        {
            return birinciSayi + ikinciSayi;
        }
    }


}
