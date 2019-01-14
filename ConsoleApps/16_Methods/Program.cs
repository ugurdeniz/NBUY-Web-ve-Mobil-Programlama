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
        //1. Geri Dönüşsüz Parametresiz Metodlar 
        //void 
        //Geri Dönüşsüz Parametreli Metodlar
        //Geri Dönüşlü Parametreli Metodlar
        
        static void Basla()
        {

        }
        /// <summary>
        /// Mesaj verir
        /// </summary>
        /// <param name="mesaj">Mesaj verilecek değeri girin</param>
        static void EkranaYaz(string mesaj)
        {
            Console.WriteLine(mesaj);
        }
        static void EkranaYaz()
        {
            Console.WriteLine("Merhaba");
            
        }

        static void EkranıDurdur()
        {
            Console.Read();
        }

        static void Bitir()
        {

        }
        #endregion
        static void Main(string[] args)
        {
            Basla();
            EkranaYaz();
         
            EkranıDurdur();
            Bitir();
            
        }
    }
}
