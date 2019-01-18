using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            // satır bazlı yorum satırı

            /* paragraf bazlı
             * 
             * 
             * alafortanfoni
             */
            //Öğrenci İşleri
            //Nergiz Hocazade
            //nergiz.hocazade@wissenakademie.com
            //0533 407 51 68

            ///////Değişkenler////
            //Primitive Tipler

            //Sayısal Tipler
            //Tam Sayılar
            //int 4Byte 2^32 Tamsayıları alır. İlk bit işaret biti dir.
            int tamSayiInt = 2000000000;
            //uint 4Byte işaretsiz
            uint tamSayiUint = 4000000000;
            //short 2Byte 
            short tamSayiShort = 32767;
            //long 8Byte
            long tamSayiLong = 40000000000;
            //byte 1Byte
            byte tamSayiByte = 255;
            sbyte tamSayiSByte= -127;

            //Ondalıklı Sayılar
            //float 4Byte virgulden sonra 4 basamak
            float ondalikliSayiFloat = 34.34F;
            //double 8Byte virgulden sonra 9 basamak
            double ondalikliSayiDouble = 34.34D;
            double ondalikliSayiDouble2 = 34.34F;
            //decimal 16Byte virgulden sonra 15 basamak
            decimal ondalikliSayiDecimal = 34.34M;

            //Karakter Değişkeni
            //char 2Byte
            char karakter = 'a';

            //Mantıksal Tip
            //bool 1Byte
            bool mantiksalIfade = true;

            //Diğer Tipler

            //Değersizlik değeri null
            //string char[]
            string alafortanfoni = "alafortanfoni";
            //object 
            object sey = 45;            
            sey = "Alafortanfoni";

            //var 
            var deger = 45;
            deger = deger + tamSayiInt;
            ///deger = "Alafortanfoni"; böyle bir atama yapılamaz.
            //dynamic
            //DateTime 
            DateTime tarih = new DateTime(2019,1,8);
           DateTime suAn= DateTime.Now;

            int @int;

            //Const
            const int alafor = 5;
            int toplam = alafor + 4; //=>int toplam=5+4;
            const string bakanlikYetkisiGuid = "39dbe7b1-fb58-42be-bbd9-dc6d26e137ae";
        }

        /// <summary>
        /// Alafortan uygulaması ekrana Metot Çalıştı yazar
        /// </summary>
        static void Alafortan()
        {
            Console.Write("Metot Çalıştı");
        }
    }
}

