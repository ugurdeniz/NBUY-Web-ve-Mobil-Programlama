using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_UcgenOrnegi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Üç tam sayı değeri ile bir dik üçgen çizilip çizilemeyeceğinin kararını veren programı yazınız. (açı değerleri ile)

            #region Dışarıdan üç tam sayı alınması
            //Birinci sayının kontrollü okunması
            Console.Write("Lütfen birinci açı değerini giriniz: ");
            string input = Console.ReadLine();
            int girilenBirinciAciDegeri = 0;
            bool birinciGirisDonustuMu = int.TryParse(input, out girilenBirinciAciDegeri);

            if (!birinciGirisDonustuMu || girilenBirinciAciDegeri <= 0 || girilenBirinciAciDegeri > 178)
            {
                Console.WriteLine("Hatalı yada açı olamayacak bir değer girdiniz.");
                Console.ReadKey();
                Environment.Exit(0);
            }


            //İkinci sayının kontrollü okunması
            Console.Write("Lütfen ikinci açı değerini giriniz: ");
            input = Console.ReadLine();
            int girilenIkinciAciDegeri = 0;
            bool ikinciGirisDonustuMu = int.TryParse(input, out girilenIkinciAciDegeri);

            if (!ikinciGirisDonustuMu || girilenIkinciAciDegeri <= 0 || girilenIkinciAciDegeri > 178)
            {
                Console.WriteLine("Hatalı yada açı olamayacak bir değer girdiniz.");
                Console.ReadKey();
                Environment.Exit(0);
            }


            //Üçüncü sayının kontrollü okunması
            Console.Write("Lütfen üçüncü açı değerini giriniz: ");
            input = Console.ReadLine();
            int girilenUcuncuAciDegeri = 0;
            bool ucuncuGirisDonustuMu = int.TryParse(input, out girilenUcuncuAciDegeri);

            if (!ucuncuGirisDonustuMu || girilenUcuncuAciDegeri <= 0 || girilenUcuncuAciDegeri > 178)
            {
                Console.WriteLine("Hatalı yada açı olamayacak bir değer girdiniz.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            #endregion

            #region Alınan değerlerle dik üçgenlik kontrolü

            bool ucgenMi = (girilenBirinciAciDegeri + girilenIkinciAciDegeri + girilenUcuncuAciDegeri) == 180;
            bool birAciDikMi = girilenBirinciAciDegeri == 90
                            || girilenIkinciAciDegeri == 90
                            || girilenUcuncuAciDegeri == 90;

            if(ucgenMi && birAciDikMi)
            {
                Console.WriteLine("Girilen açı değerleri bir dik üçgene aittir.");
            }
            else
            {
                Console.WriteLine("Hata...! Girilen açı değerleri bir dik üçgene ait değildir.");
            }

            Console.ReadKey();

            #endregion
        }
    }
}
