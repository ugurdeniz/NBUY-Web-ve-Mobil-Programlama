using System;

namespace _21_Params
{
    class Program
    {
        static void Main(string[] args)
        {
            Topla(1, 2, 3, 4, 5, 6, 4);
            Topla("mesaj",1, 2, 3, 4, 5, 6, 4);
            int[] sayidizisi = { 1, 2, 3, 4 };
            Topla("mesaj", sayidizisi);
        }

        //static int Topla(int a,int b)
        //{
        //    return a + b;
        //}
        //static int Topla(int a, int b,int c)
        //{
        //    return a + b+c;
        //}
        //static int Topla(int a, int b, int c,int d)
        //{
        //    return a + b + c+d;
        //}
        //static int Topla(int a, int b, int c, int d, int e)
        //{
        //    return a + b + c + d+e;
        //}

        static int Topla(params int[] sayilar)
        {
            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
            return toplam;
        }
        static int Topla(string mesaj,params int[] sayilar)
        {
            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
            return toplam;
        }

        //static int Topla(string mesaj, params int[] sayilar,params string[] isimler)
        //{
        //    int toplam = 0;
        //    for (int i = 0; i < sayilar.Length; i++)
        //    {
        //        toplam += sayilar[i];
        //    }
        //    return toplam;
        //}
    }
}
