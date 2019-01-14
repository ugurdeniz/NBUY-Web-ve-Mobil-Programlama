using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Kısa Özet
            //While döngüsü
            ////kosul true olduğu sürece döngü devam eder.
            //while (kosul)
            //{

            //}

            //bool flag = true;
            //while (flag)
            //{
            //    if(sart)
            //    {
            //        flag = false;
            //    }
            //}


            //while (true)
            //{
            //bla
            ////bla
            //if(sart)
            //{
            //  continue;                   
            //}
            //bla
            //bla
            //bla
            //}

            //while for hali
            //int i = 0;
            //while (i < 100)
            //{
            //    //
            //    //
            //    i++;
            //}


            ////en az bir kere çalıştıktan sonra koşulu sorgular.
            //do
            //{

            //} while (kosul);

            //For döngüsü
            //for (int i = 0; i < 100; i++)
            //{

            //}

            //for un while hali;
            //bool flag = true;
            //for (; flag;)
            //{

            //}

            //int i = 4;
            //for (; i < 200;)
            //{
            //    i++;
            //}
            #endregion

            #region 1 den 20 ye kadar olan sayıların toplamı nedir. Her adımda anlık toplamı ekrana yazınız.

            //int toplam = 0;

            //for (int i = 1; i <= 20; i+=1)
            //{
            //    toplam += i;
            //    Console.WriteLine(toplam);
            //}
            //Console.WriteLine("Toplam:" + toplam);

            //Console.ReadKey();

            #endregion

            #region 1 den 20 ye kadar olan çift sayıların toplamı nedir. 

            //int toplam = 0;

            //for (int i = 0; i <= 20; i += 2)
            //{
            //    toplam += i;
            //    Console.WriteLine(toplam);
            //}
            //Console.WriteLine("Toplam:" + toplam);

            //Console.ReadKey();

            #endregion
            #region 1-1000 arasındaki 7 nin katları olan sayıları toplayan ama 21 in katlarını bu toplamaya dahil etmeyen döngüyü yazınız.
            //int toplam = 0;
            //for (int i = 7; i < 1000; i += 7)
            //{
            //    if (i % 21 == 0)
            //    {
            //        continue;
            //    }
            //    toplam += i;
            //}
            //Console.WriteLine("Toplam:" + toplam);
            //Console.ReadKey();
            #endregion
            #region Kullanıcıdan doğru şekilde sayı değeri alana kadar sayı isteme
            Console.Write("Lütfen bir sayı giriniz:");
            int dersSecimi = 0;
            while (true)
            {
                string input = Console.ReadLine();
                bool secimSayisalIfadeMi = int.TryParse(input, out dersSecimi);
                if (!secimSayisalIfadeMi)
                {
                    Console.Write("Hatalı bir not seçimi yaptınız.\n Lütfen yeniden bir sayı giriniz:");
                }
                else
                {
                    break;
                }                
            }
            Console.WriteLine("Seçilen ders:" + dersSecimi);
            Console.ReadKey();
            #endregion
        }
    }
}
