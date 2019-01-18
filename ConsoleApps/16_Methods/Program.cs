using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Methods
{
    class Program
    {
        #region Konu Anlatım
        //1. Geridönüşsüz Parametresiz Metotlar
        //void
        static void EkranaMerhabaYaz()
        {
            Console.WriteLine("Merhaba");
        }
        static void EkraniBirTusaBasilanaKadarBeklet()
        {
            Console.ReadKey();
        }
        static void Bitir()
        {

        }
        static void Baslat()
        {

        }

        //Geridonuşsüz Parametreli Metotlar
        static void EkranaVerilenSayiKadarYaz(string mesaj, int yazimSayisi)
        {
            for (int i = 0; i < yazimSayisi; i++)
            {
                Console.WriteLine(mesaj);
            }
        }

        //Geridönüşlu Parametresiz Metotlar
        static string MesajVer()
        {
            return "Merhaba" + "Mars";
            //return (4 + 5).ToString();
        }

        //Geridönüşlü Parametreli Metotlar
        /// <summary>
        /// İki sayiyi toplar
        /// </summary>
        /// <param name="toplanacakBirinciSayi"> toplanacak birinci sayi</param>
        /// <param name="toplanacakIkinciSayi"> toplanacak ikinci sayi</param>
        /// <returns>iki sayi toplamı</returns>
        static int Topla(int toplanacakBirinciSayi, int toplanacakIkinciSayi)
        {
            return toplanacakBirinciSayi + toplanacakIkinciSayi;
        }


        //Default değerli parametreler
        static int ToplaDefaultDegerli(int sayi1,int sayi2, int sayi3=0,int sayi4=0)
        {
            return sayi1 + sayi2 + sayi3+sayi4;
        }

        #endregion
        static void Main(string[] args)
        {
            //Baslat();
            // EkranaMerhabaYaz(); //bilinçli olarak çağırmak. Call
            //string merhabaMesaji = MesajVer();
            //EkranaVerilenSayiKadarYaz(merhabaMesaji, 4);
            //EkraniBirTusaBasilanaKadarBeklet();
            //int toplam = Topla(4, 6);
            //Bitir();            


            //EkranaVerilenSayiKadarYaz(MutlakDegerAl(-45).ToString(),1);
            //EkraniBirTusaBasilanaKadarBeklet();


            //EkranaVerilenSayiKadarYaz(UstAl(4,3).ToString(), 1);
            //EkraniBirTusaBasilanaKadarBeklet();



            //int[] dizi1 = { 1, 2, 3, 4, 5 };
            //int[] dizi2 = { 2, 4, 5, 6 };
            //DiziYazdir(DiziBirlestir(dizi1,dizi2));
            //EkraniBirTusaBasilanaKadarBeklet();


            EkranaVerilenSayiKadarYaz(KareKokunuVer(145).ToString(), 1);
            EkraniBirTusaBasilanaKadarBeklet();

            ToplaDefaultDegerli(1, 2);
            ToplaDefaultDegerli(1, 2, 3);
            ToplaDefaultDegerli(1, 2, sayi4: 5);
            ToplaDefaultDegerli(sayi1: 3, sayi4: 7, sayi2: 1);
            ToplaDefaultDegerli(1, 2, 3, 4);
        }

        #region Örnekler
        //verilen değerin mutlak değerini alan metot (int)
        static int MutlakDegerAl(int mutlakDegeriAlinacakSayi)
        {
            if (mutlakDegeriAlinacakSayi > 0)
            {
                return mutlakDegeriAlinacakSayi;
            }
            else
            {
                return -mutlakDegeriAlinacakSayi;
            }
        }
        //iki int sayinin çarpımını veren metot
        static long Carp(int carpilacakBirinciSayi, int carpilacakIkinciSayi)
        {
            return (long)carpilacakBirinciSayi * carpilacakIkinciSayi;
        }
        //verilen ondalıklı sayıyı yuvarlayan metot (3,2=>3, 3,5=>4)
        static long Yuvarla(decimal yuvarlanacakSayi)
        {
            //int ondalikliAlan = (int)((yuvarlanacakSayi * 10) % 10);
            //if (ondalikliAlan >= 5)
            //{
            //    return (long)yuvarlanacakSayi + 1;
            //}
            //else
            //{
            //    return (long)yuvarlanacakSayi;
            //}

            yuvarlanacakSayi+=0.5M;
            return (long)yuvarlanacakSayi;
        }
        //verilen ondalıklı sayıyı yukarı yuvarlayan metot (3,2=>4, 3,5=>4)
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
        //verilen taban ve üst değerlerine göre üslü sayının sonucunu veren metot
        static long UstAl(int tabanSayisi,int ustSayisi)
        {
            long sonuc = 1;
            for (int i = 0; i < ustSayisi; i++)
            {
                sonuc *= tabanSayisi;
            }
            return sonuc;
        }
        //verilen sayinin işaretini veren metot( pozitif için 1, negatif için -1, 0 için 0 dönecek)
        static int SayiIsaretiniVer(long isaretiAlinacakSayi)
        {
            if(isaretiAlinacakSayi>0)
            {
                return 1;
            }
            else if (isaretiAlinacakSayi<0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        //verilen sayinin (0-100000 arasıda bir sayı) tam sayı kökü var ise karekökünü yok ise -1 dönen metot
        static int KareKokunuVer(int sayi)
        {
            int kareKok = 1;

            while(true)
            {
                int kareKokunKaresi = kareKok * kareKok;
                if (kareKokunKaresi==sayi)
                {
                    return kareKok;
                }
                else if(kareKokunKaresi>sayi)
                {
                    break;
                }
                kareKok++;
            }
            return -1;
        }
        //verilen iki aynı tip diziyi tek dizide birleştiren metot
        static int[] DiziBirlestir(int[] birinciDizi,int[] ikinciDizi)
        {
            int[] birlesmisDizi = new int[birinciDizi.Length + ikinciDizi.Length];
            birinciDizi.CopyTo(birlesmisDizi, 0);
            //ikinciDizi.CopyTo(birlesmisDizi, birinciDizi.Length);
            Array.Copy(ikinciDizi, 0, birlesmisDizi, birinciDizi.Length, ikinciDizi.Length);
            return birlesmisDizi;
        }
        static void DiziYazdir(int[] dizi)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                EkranaVerilenSayiKadarYaz(dizi[i].ToString(), 1);
            }
        }
        #endregion
    }
}
