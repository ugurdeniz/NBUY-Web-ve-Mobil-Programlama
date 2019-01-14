using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tanım Anlatım
            //int[] intDizi = new int[3];
            //int[] intDizi2 = new int[] { 2, 4, 5, 3 };
            //int[] intDizi3 = { 2, 4, 5, 3 };
            //int[] intDizi4 = new int[] { };
            //int[] intDizi5 = { 2, 4,0, 3 };

            //int[] intBosDizi;
            //int[] intDigerDizi = new int[] { 2, 4, 5, 3, 5, 6, 4, 5 };
            //intBosDizi = intDigerDizi;

            //string[] ogrenciListesi = { "osman", "mehmet", "ömer" };
            //string birinciOgrenci = ogrenciListesi[0];
            //ogrenciListesi[2] = "tutku";
            //ogrenciListesi[1] = null;
            ////ogrenciListesi[3] = "tutku"; //outofrange exception fırlatır.
            ////ogrenciListesi.Length dizinin uzunluğunu içinde kaç eleman var 
            //for (int i = 0; i < ogrenciListesi.Length; i++)
            //{
            //    Console.WriteLine(ogrenciListesi[i]);
            //}

            //char[] isim = {'o','s','m','a','n' };
            //string isim1 = "osman";
            //char ilkKarakter=isim1[0];
            //isim1.ToCharArray();
            //Console.WriteLine(isim.ToString());

            //Console.ReadKey();            
            #endregion

            #region Dizi Metotları
            //length 
            #region Clear
            //char[] isim = { 'o', 's', 'm', 'a', 'n' };

            //Array.Clear(isim, 2, 2);
            //for (int i = 0; i < isim.Length; i++)
            //{
            //    Console.WriteLine(isim[i]);
            //}


            //int[] sayilar = { 1, 2, 3, 4, 5 };

            //Array.Clear(sayilar, 2, 2);
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}
            //Console.ReadKey();
            #endregion
            string[] mevsimler = { "Kış", "İlkbahar", "Yaz", "Sonbahar","Yaz" };
            string[] mevsimler2 = new string[8];
            #region Clone
            //string[] mevsimler2 = mevsimler;
            //mevsimler2 = (string[])mevsimler.Clone();            
            #endregion

            #region Copy

            ////Array.Copy(mevsimler, mevsimler2, 3);
            //Array.Copy(mevsimler, 2, mevsimler2, 4, 2);
            //for (int i = 0; i < mevsimler2.Length; i++)
            //{
            //    Console.WriteLine(mevsimler2[i]);
            //}
            //Console.ReadKey();
            #endregion

            #region CopyTo
            //mevsimler.CopyTo(mevsimler2, 4);
            //for (int i = 0; i < mevsimler2.Length; i++)
            //{
            //    Console.WriteLine(mevsimler2[i]);
            //}
            //Console.ReadKey();
            #endregion

            #region Sort
            //Array.Sort(mevsimler); //a-z ye yada kücükten buyuye
            //for (int i = 0; i < mevsimler.Length; i++)
            //{
            //    Console.WriteLine(mevsimler[i]);
            //}
            //Console.ReadLine();
            #endregion
            Console.WriteLine();

            #region Reverse
            //Array.Reverse(mevsimler);
            //for (int i = 0; i < mevsimler.Length; i++)
            //{
            //    Console.WriteLine(mevsimler[i]);
            //}
            //Console.ReadLine();
            #endregion

            #region IndexOf LastIndexOf
            //int bastanIndis=Array.IndexOf(mevsimler, "Yaz");
            //int sondanIndis = Array.LastIndexOf(mevsimler, "Yaz");
            //Console.WriteLine("Baştan Ararsan:" + bastanIndis + "  Sondan Ararsan:" + sondanIndis);
            //Console.ReadKey();
            #endregion

            #region Resize
            Array.Resize(ref mevsimler, mevsimler.Length + 3);
            mevsimler[5] = "Alafortanfoni";
            for (int i = 0; i < mevsimler.Length; i++)
            {
                Console.WriteLine(mevsimler[i]);
            }
            Console.ReadKey();
            #endregion
            #endregion
        }
    }
}
