using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_DateFonksiyonlari
{
    class Program
    {
        static void Main(string[] args)
        {
            //int yil = 3000;
            //int ay = 6;

            //Console.WriteLine(DateTime.DaysInMonth(yil, ay));

            //DateTime suAn  =DateTime.Now;
            //Console.WriteLine(suAn);

            //bool artikYilMi = DateTime.IsLeapYear(yil);
            //Console.WriteLine(artikYilMi);

            //DateTime dt = DateTime.Now;
            //Console.WriteLine(dt.AddMonths(20));
            //yil=dt.Year;

            //Console.ReadKey();

            //DateTime zaman = new DateTime();
            //DateTime zaman1 = DateTime.Now;
            //DateTime zaman2 = DateTime.Today;
            //DateTime dogumtarihi = new DateTime(1980, 8, 30, 8, 10, 12);
            //Console.WriteLine(zaman2);
            //Console.WriteLine(dogumtarihi);
            //int yıl = dogumtarihi.Year;
            //int gun = dogumtarihi.Day;
            //int ay = dogumtarihi.Month;
            //DateTime tarih = dogumtarihi.Date;
            ////Console.WriteLine(yıl);
            ////Console.WriteLine(ay);
            //Console.WriteLine(tarih);
            //Console.ReadKey();

            //DateTime bugun = DateTime.Now;
            //DateTime ucGunSonra = bugun.AddDays(3).AddHours(12);
            ////Console.WriteLine(bugun);
            ////Console.WriteLine(ucGunSonra);
            ////Console.ReadKey();


            //double fark = (ucGunSonra - bugun).TotalDays;
            //Console.WriteLine(fark);
            //Console.ReadKey();

            //DaysInMonth

            //const int temmuz = 7;
            //const int subat = 2;

            //int temmuzdakiGunler = DateTime.DaysInMonth(2001, temmuz);
            //int subattakiGunler = DateTime.DaysInMonth(1996, subat);
            //Console.WriteLine(temmuzdakiGunler);
            //Console.WriteLine(subattakiGunler);
            //Console.ReadKey();


            //IsLeapYear => Artık yıl

            int yıl = 1996;
            int yıl2 = 1997;

            if (DateTime.IsLeapYear(yıl))
            {
                Console.WriteLine(yıl + " artık yıldır");
            }
            else
            {
                Console.WriteLine(yıl + " artık yıl degıldır");
            }

            if (DateTime.IsLeapYear(yıl2))
            {
                Console.WriteLine(yıl2 + " artık yıldır");
            }
            else
            {
                Console.WriteLine(yıl2 + " artık yıl degıldır");
            }
            Console.ReadKey();


        }
    }
}
