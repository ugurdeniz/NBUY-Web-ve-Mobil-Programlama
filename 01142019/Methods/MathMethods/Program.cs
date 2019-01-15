using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ceilling()
            //Parametre olarak verilen double türündeki ondalıklı sayıdan büyük, en küçük tam sayının değerini veren metottur.
            double sayi = 9.32;
            double sonuc = Math.Ceiling(sayi);

            decimal sayi2 = 9.32M;
            decimal sonuc2 = Math.Ceiling(sayi2);
            #endregion

            #region Abs()
            //Parametre olarak verilen sayının mutlak değerini veren metottur. Parametre olarak farklı sayı türlerinde değerler alabilir ve aldığı değerin türünde bir değer geri döndürür.
            float sonuc3 = Math.Abs(-17.65f);
            #endregion

            #region Round()
            //Parametre olarak verilen sayıyı en yakın tam sayıya yuvarlayan metottur.
            double yuvarlanmis = Math.Round(1.89);

            #endregion

            #region Floor()
            
            //En yakın integer değeri döndürür      //OUTPUTS
            Console.WriteLine(Math.Floor(0.2018));    //0
            Console.WriteLine(Math.Floor(123.123));   //123
            Console.WriteLine(Math.Floor(-0.2));      //-1
            Console.WriteLine(Math.Floor(0.0));       //0
            Console.WriteLine(Math.Floor(34.67M));    //34
            #endregion

            #region Pow()
            
            //Parametre olarak verilen ilk sayının, yine parametre olarak verilen ikinci sayı kadar üssünü hesaplayan metottur.
            Console.WriteLine(Math.Pow(5, 4));
            #endregion

            #region Sign()
            //Parametre olarak verilen sayının işaretini verir. Sayı pozitif ise 1, negatif ise -1, sayı sıfıra eşitse de geriye 0 değerini döndüren metottur.

            Console.WriteLine(Math.Sign(0));   //0
            Console.WriteLine(Math.Sign(5));   //1
            Console.WriteLine(Math.Sign(-5));  //-1
            #endregion

           
        }
    }
}
