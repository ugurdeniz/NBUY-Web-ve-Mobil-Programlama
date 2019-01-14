using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            #region SwitchCase Anlatım.
            //switch (dinlenecekDeger)
            //{
            //    case "birinciDegerhali":
            //        yapılacak 1.işlem;
            //        break;
            //    case "ikinciDeğer":
            //        yapılacak 2.işlem;
            //        break;
            //    case "üçüncüDeğer":
            //        yapılacak 3.işlem;
            //        break;
            //    default:
            //        break;
            //}
            #endregion

            //dışarıdan alınan sayısal ay değerini metinsel olarak ekrana yazan uygulamayı yazınız. 
            //Ayrıca doğum ayı girişi alınsın. Eğer 1. ay doğum ayı olarak girilmiş ise alafortanfoni yazsın..

            Console.Write("Lütfen sayısal olarak ay değeri giriniz: ");
            string input = Console.ReadLine();
            int sayisalAy = 0;
            bool donustuMu = int.TryParse(input, out sayisalAy);

            if (!donustuMu)
            {
                Console.WriteLine("Hatalı bir değer girdiniz.");
                Console.ReadKey();
                Environment.Exit(0);
            }

            Console.Write("Lütfen doğduğunuz ayı sayısal olarak giriniz.: ");
            input = Console.ReadLine();
            int dogumAy = 0;
            donustuMu = int.TryParse(input, out dogumAy);

            if (!donustuMu)
            {
                Console.WriteLine("Hatalı bir değer girdiniz.");
                Console.ReadKey();
                Environment.Exit(0);
            }

            switch (sayisalAy)
            {
                case 1 when dogumAy==1 :
                    Console.WriteLine("Ocak-Alafortanfoni");
                    break;
                case 1:
                    Console.WriteLine("Ocak");
                    break;
                case 2:
                    Console.WriteLine("Şubat");
                    break;
                case 3:
                    Console.WriteLine("Mart");
                    break;
                case 4:
                    Console.WriteLine("Nisan");
                    break;
                case 5:
                    Console.WriteLine("Mayıs");
                    break;
                case 6:
                    Console.WriteLine("Haziran");
                    break;
                case 7:
                    Console.WriteLine("Temmuz");
                    break;
                case 8:
                    Console.WriteLine("Agustos");
                    break;
                case 9:
                    Console.WriteLine("Eylül");
                    break;
                case 10:
                    Console.WriteLine("Ekim");
                    break;
                case 11:
                    Console.WriteLine("Kasım");
                    break;
                case 12:
                    Console.WriteLine("Aralık");
                    break;
                default:
                    Console.WriteLine("Hatalı bir sayı girdiniz.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
