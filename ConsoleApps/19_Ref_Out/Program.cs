using System;

namespace _19_Ref_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            // string input = "45";
            // int sayim = 1923792342;//x50
            //bool donustuMu= KontrolluSayiCevir(input,out sayim); 

            // Console.WriteLine(sayim);
            // Console.ReadLine();

            //int sayi1 = 45;
            //int sayi2 = 54;
            //int fark = int.MaxValue;
            //int toplam = int.MinValue;
            //bool herIkiSonuctaPozitifMi = FarkVeToplam(sayi1,sayi2, out fark, out toplam);
            //Console.Write(toplam + " " + fark + " " + herIkiSonuctaPozitifMi);
            //Console.ReadLine();



            int[] sayiDizisi = { 1, 2, 3, 4, 5 }; //stack x50 heap x505
            bool diziBuyuduMu = DiziBoyutDegistir(ref sayiDizisi, 3);

            DiziyiEkranaYaz(sayiDizisi);
            EkranaYaz(diziBuyuduMu.ToString());
            Beklet();
        }

        private static bool FarkVeToplam(int sayi1, int sayi2, out int fark, out int toplam)
        {
            toplam = sayi1 + sayi2;
            fark = sayi1 - sayi2;
            if(toplam>=0 && fark>=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static int BirArttirKaresiniAl(int a)
        {
            a++;
            return a * a;
        }

        //out - içeride bir adet değişken tanımlar ve onun referans adresini dışarıya gönderir.
        //tryparse 1- sayı dönüştü mü 2-dönüştüyse sayı nedir.
        static bool KontrolluSayiCevir(string input,out int sayi) //x49
        {
            sayi = 0;
            if(input==null)
            {
                return false;
            }
            try
            {
                sayi = Convert.ToInt32(input);
                //bla blaa hata var ise çalışmayacak..
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        static bool KontrolluSayiCevirParse(string input, out int sayi)
        {
            sayi = 0;
            try
            {
                sayi = int.Parse(input);
                //bla blaa hata var ise çalışmayacak..
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        //ref dışarıdan içeriye bellek adresini gönderir.
        /// <summary>
        /// İlgili metot içerisine aldığı diziyi yeniBoyut parametresiyle verilen uzunluğa getirir.
        /// Bu işlem sırasında eğer boyutu büyüyor yada değişmiyor ise true döner. Küçülüyor ise false döner.
        /// </summary>
        /// <param name="dizi"></param>
        /// <param name="yeniBoyut"></param>
        /// <returns></returns>
        static bool DiziBoyutDegistir(ref int[] dizi, int yeniBoyut) //stack bazlı  dizi=X50
        {
            int[] yeniDizi = new int[yeniBoyut]; //stack x51 heap x504
            if (yeniBoyut>=dizi.Length)
            {                
                dizi.CopyTo(yeniDizi, 0);
                dizi = yeniDizi;    //heap bazlı  x50 ye heap x504 atanıyor.          
                return true;
            }
            else
            {
                Array.Copy(dizi, 0, yeniDizi, 0, yeniBoyut);
                dizi = yeniDizi;
                return false;
            }
        }

        private static void DiziyiEkranaYaz(int[] dizi)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                EkranaYaz(dizi[i].ToString() + " ");
            }
        }

        private static void EkranaYaz(string metin)
        {
            Console.Write(metin);
        }
        private static void Beklet()
        {
            Console.ReadKey();
        }
    }
}
