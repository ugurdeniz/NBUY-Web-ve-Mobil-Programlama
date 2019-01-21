using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_StringMetotları
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Replace            
            //string rpl = "melekler";
            ////Console.WriteLine(rpl);
            ////Console.WriteLine(rpl.Replace("elek", "au"));
            //string mesaj = "merhaba dünya";
            //string sonMesaj = mesaj.Replace("merhaba", "güle güle");
            //string metin = "alafortan;foni";
            //metin = metin.Replace(";", "");

            ////indexof
            //int indis=metin.IndexOf(';');
            ////metin içinde bir tane ; olduğunu biliyor isem;
            //metin.Remove(indis,1);

            //Remove
            //Console.WriteLine(rpl);
            //Console.WriteLine(rpl.Remove(3));
            //Console.WriteLine(rpl.Remove(3,2));


            //substring
            //Console.WriteLine(rpl.Substring(3));
            //Console.WriteLine(rpl.Substring(3,2));


            //Trim
            //string kullaniciAdi = "   alafortan ";
            //Console.WriteLine(kullaniciAdi);
            //Console.WriteLine(kullaniciAdi.Trim());


            //TrimEnd
            //Console.Write(rpl.TrimEnd('a'));

            //TrimStart
            //Console.Write(rpl.TrimStart('a'));
            //Console.WriteLine(rpl.Trim());


            //Split
            #region Contains Kullanımı

            //Console.Write("Metin giriniz: ");
            //string ifade = Console.ReadLine();
            //Console.Write("Aranan metni giriniz: ");
            //string aranan = Console.ReadLine();
            //if (ifade.Contains(aranan))
            //    Console.WriteLine("({0}) ifadesi içerisinde ({1}) kelimesi mevcuttur.", ifade, aranan);
            //else
            //    Console.WriteLine("({0}) ifadesi içerisinde ({1}) kelimesi yoktur.", ifade, aranan);



            #endregion

            //#region Format Kullanımı

            //Console.WriteLine("——————————-");
            //Console.WriteLine("Sıra No | Adınız | Soyad");
            //Console.WriteLine("——————————-");
            //Console.WriteLine(String.Format("{0,-7} | {1,2} | {2}", "1", "Ali", "AYDIN"));

            //////Bu değerin pozitif olması, değişken değerinin ayrılan alanının sağına hizalı olacağını, negatif olması ise soluna hizalı olacağını belirler


            //#endregion

            #region ToUpper-ToLower Kullanımı


            //string stringDegiskeni = "WISSEN";

            ////ToLower
            //String kucukHarfli = stringDegiskeni.ToLower();
            //Console.WriteLine(kucukHarfli);

            ////ToUpper
            //String buyukHarfli = stringDegiskeni.ToUpper();
            //Console.WriteLine(buyukHarfli);


            #endregion

            #region ToCharArray Kullanımı
            ////String i karakterlere ayırma
            //string ifade = "Wissen Akademie";
            //Console.WriteLine(ifade.ToCharArray(3, 1)); //ifade değişkeninden 3. karakterden itibaren 1 karakter aldı.





            #endregion

            #region EndsWith ve StarsWith Kullanımı
            ////EndsWith
            //String UrlUzantisi = "www.WISSEN.com";

            //if (UrlUzantisi.EndsWith(".com"))
            //{
            //    Console.WriteLine("Evet");
            //}
            //else { Console.WriteLine("Hayır"); }


            ////Starts With
            //if (UrlUzantisi.StartsWith("www"))
            //{
            //    Console.WriteLine("Evet");
            //}
            //else { Console.WriteLine("Hayır"); }


            #endregion


            #region Split Kullanımı
            ////string cumle = "Wissen Akademie Sabah Kursu";


            ////string[] kelimeler = cumle.Split(' ');



            //char[] ayrac = { '/', ' ', ':' };
            //string tarih = "2019/01/15 10:50";

            //string[] parcalar = tarih.Split();

            //Console.WriteLine("Yıl:{0}  Ay:{1} Gün:{2}  Saat:{3} Dakika:{4}", parcalar[0], parcalar[1], parcalar[2], parcalar[3], parcalar[4]);

            //Console.ReadLine();

            #endregion

            //#region Contains Kullanımı

            //Console.Write("Metin giriniz: ");
            //string ifade = Console.ReadLine();
            //Console.Write("Aranan metni giriniz: ");
            //string aranan = Console.ReadLine();
            //if (ifade.Contains(aranan))
            //    Console.WriteLine("({0}) ifadesi içerisinde ({1}) kelimesi mevcuttur.", ifade, aranan);
            //else
            //    Console.WriteLine("({0}) ifadesi içerisinde ({1}) kelimesi yoktur.", ifade, aranan);

            //#region Format Kullanımı

            //Console.WriteLine("——————————-");
            //Console.WriteLine("Sıra No | Adınız | Soyad");
            //Console.WriteLine("——————————-");
            //Console.WriteLine(String.Format("{0,3} | {1,-2} | {2}", "1", "Ali", "AYDIN"));

            //////Bu değerin pozitif olması, değişken değerinin ayrılan alanının sağına hizalı olacağını, negatif olması ise soluna hizalı olacağını belirler


            //#endregion

            //#region ToUpper-ToLower Kullanımı


            //string stringDegiskeni = "WISSEN";

            ////ToLower
            ////String kucukHarfli = stringDegiskeni.ToLower();
            ////Console.WriteLine(kucukHarfli);

            ////ToUpper
            //String buyukHarfli = stringDegiskeni.ToUpper();
            //Console.WriteLine(buyukHarfli);



            //#endregion

            //#region ToCharArray Kullanımı
            //String i karakterlere ayırma
            //string ifade = "Wissen Akademie";
            //Console.WriteLine(ifade.ToCharArray(4, )); //ifade değişkeninden 3. karakterden itibaren 1 karakter aldı.





            //#endregion

            #region EndsWith ve StarsWith Kullanımı
            //EndsWith
            string UrlUzantisi = "www.WISSEN.com";

            if (UrlUzantisi.EndsWith(".com"))
            {
                Console.WriteLine("Evet");
            }
            else { Console.WriteLine("Hayır"); }


            //Starts With
            if (UrlUzantisi.StartsWith("www"))
            {
                Console.WriteLine("Evet");
            }
            else { Console.WriteLine("Hayır"); }


            #endregion



            Console.ReadKey();


        }
    }
}
