using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        //Verilen değerin mutlak değerini alan metot
        static int MutlakDegeriniAl(int mutlakDegeriAlinacakSayi)
        {
            if (mutlakDegeriAlinacakSayi < 0)
            {
                return mutlakDegeriAlinacakSayi * -1;
            }
            return mutlakDegeriAlinacakSayi;
        }

        //iki int sayinin çarpımını veren metod
        static long Carpim(int ilkSayi, int ikinciSayi)
        {
            return (long)ilkSayi * ikinciSayi;
        }
        //verilen ondalıklı sayıyı yuvarlayan metod
        static long Yuvarla(decimal yuvarlanacakSayi)
        {
            //int ondalikliAlan = (int)((yuvarlanacakSayi * 10) % 10);
            //if (ondalikliAlan>=5)
            //{
            //    return (long)yuvarlanacakSayi + 1;
            //}
            //else
            //{
            //    return (long)yuvarlanacakSayi;
            //}

            yuvarlanacakSayi += 0.5M;
            return (long)yuvarlanacakSayi;
        }

        //girilen sayıyı yukarı yuvarlayan metot
        static long YukariYuvarla(decimal yuvarlanacakSayi)
        {
            if (yuvarlanacakSayi>(long)yuvarlanacakSayi)
            {
                return (long)yuvarlanacakSayi + 1;
            }
            else
            {
                return (long)yuvarlanacakSayi;
            }
        }

        //verilen taban ve üst değerine göre üslü sayının sonucunu veren metot
        static int UsluSayiHesapla(int tabanDegeri, int usDegeri)
        {
            int sonuc = 1;
            for (int i = 0; i < usDegeri; i++)
            {
                sonuc *= tabanDegeri;
            }
            return sonuc;
        }

        //Verilen sayının işaretini veren metot(pozitif için 1, negatif için -1, 0 için 0)

        static int IsaretiniGoster(int isaretiGosterilecekSayi)
        {
            if (isaretiGosterilecekSayi == 0)
            {
                return 0;
            }
            else if (isaretiGosterilecekSayi < 0)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }

        //Verilen Sayının(0-100000 arasında bir sayı) tam sayı kökü var ise karekökünü yok ise -1 dönen metot

        //Verilen iki aynı tip diziyi tek dizide birlestiren metot
        static int[] DiziBirlestir(int[] birinciDizi,int[] ikinciDizi)
        {
            int[] birlesmisDizi = new int[birinciDizi.Length + ikinciDizi.Length];
            birinciDizi.CopyTo(birlesmisDizi, 0);
            Array.Copy(ikinciDizi, 0, birlesmisDizi, birinciDizi.Length, ikinciDizi.Length);
            return birlesmisDizi;
        }
        static int KarekokunuHesapla(int karekokuHesaplanacakSayi)
        {
            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MutlakDegeriniAl(-10));

            Console.WriteLine(Carpim(5, 2));

            Console.WriteLine(Yuvarla(4.2M));

            Console.WriteLine(UsluSayiHesapla(2, 3));

            Console.WriteLine(IsaretiniGoster(0));

            Console.Read();
        }
    }
}
