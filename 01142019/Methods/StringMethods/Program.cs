using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Replace()

            //Bir string içerisinde belli bir ifadenin başka bir ifade ile değiştirilmesini sağlar.

            string text = "ugur";
            string degistirilenText = text.Replace("r", "d");
            Console.WriteLine(degistirilenText);
            #endregion

            #region Remove

            //String bir ifadenin belirtilen kısmını silerek atmaya yarar. Dışarıdan bir veya iki parametre alabilir.
            string soyad = "deniz";
            degistirilenText = soyad.Remove(1); //OUTPUT
            Console.WriteLine(degistirilenText); // d

            degistirilenText = soyad.Remove(2, 2);
            Console.WriteLine(degistirilenText); //dez
            #endregion

            #region Substring()

            //Bir string ifadenin sadece istenilen kısmını almaya yarar.
            string ad = "ugur";
            degistirilenText = ad.Substring(2); //ur
            string soyAd = "deniz";
            degistirilenText = soyAd.Substring(0, 3); //den

            #endregion

            #region Trim(),TrimEnd() ve TrimStart()

            //String bir İfadenin önündeki ve sonundaki boşlukları silmek için kullanılır. 

            string trimText = "        ugur          ";
            Console.WriteLine(trimText.Trim()); //baştaki ve sondaki boşlukları sildi
            Console.WriteLine(trimText.TrimStart()); //baştaki boşlukları siler
            Console.WriteLine(trimText.TrimEnd()); //sondaki boşlukları siler

            #endregion

            #region Split()

            //Bir dizgeyi (karakter dizisi) belirli bir ayraç ile parçalayıp, parçalardan bir dizi döndürür.
            string yazi = "Bugün hava çok güzel değil gibi görünüyor.";

            string[] kelimeler = yazi.Split(' ');
            Console.WriteLine(" Yazı toplam {0} kelimedir. ", kelimeler.Length);


            #endregion

            #region ToLower() ve ToUpper()

            //string ifadeninin Tümünü Büyük veya Küçük harf yapmak için kullanılır.

            string ifade = "ugur";

            Console.WriteLine(ifade.ToUpper()); //Hepsini büyük yaptı
            Console.WriteLine(ifade.ToLower()); //Hepsini küçük yaptı
            #endregion

            #region toCharArray()

            //String içeriğini karakterlere ayırır

            string kelime = "ugur";
            char[] karakterler = kelime.ToCharArray(1, 2); //SubStringteki mantık ile çalışır, 3.index numarasından başlar ve daha sonraki 2 karakteri alır
            #endregion

            #region Contains()

            //Bir string içerisinde karakter veya ifade aramaya yarar. Aranan ifade string içerisinde geçiyorsa True, geçmiyorsa False değeri döndürür.

            string ilkText = "araba";
            string ikinciText = "ba";

            bool varMı = ilkText.Contains(ikinciText); //true döner 
            #endregion

            #region EndsWith() ve StartWith()

            //Bir string ifadenin başka bir ifade ile bitip bitmediğini kontrol eder. Metin belirtilen ifade ile bitiyorsa true, bitmiyorsa false değeri döndürür.

            string a = "deniz";
            string b = "niz";

            bool sonundaVarMi = a.EndsWith(b); //true döner

            a = "ugur";
            b = "gu";

            bool basindaVarMi = a.StartsWith(b); //false döner
            #endregion

            #region Format()

            //Metin, sayı veya tarih türündeki ifadeleri, belli bir düzene göre yazdırmayı sağlar. küme parantezleri ( { } ) içerisindeki ilk değer, degisken isimli değişken içerisindeki değeri referans göstermektedir. İkinci değer ise değişkenin içeriğinin, ekranda kaç karakterlik alan kaplayacağını  belirtir.
            //Bu değerin pozitif olması, değişken değerinin ayrılan alanının sağına hizalı olacağını, negatif olması ise soluna hizalı olacağını belirler.

            int formatSayi = 55;
            string formatSonuc = string.Format("{ 0, 5:00000 }", formatSayi); //Sonuç "00055" 

            int formatSayi2 = 55;
            string formatSonuc2 = string.Format("{ 0, 8:00000 }", formatSayi2);  //Sonuç "   00055" olacaktır.Sol tarafa 3 tane boşluk konarak karakter sayısı 8'e tamamlanmıştır.



            #endregion
        }
    }
}
