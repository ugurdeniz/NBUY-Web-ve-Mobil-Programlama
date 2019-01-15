using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime zaman = DateTime.Now; //şu anki tarih ve saat bilgisi zaman nesnesine atanmıştır.

            DateTime tarih = DateTime.Today; //bugune ait sadece tarih bilgisi atanmıştır

            

            //İki tarihideki fark Subtract() metoduyla bulunur ve TimeSpan tipinden değer döndürür.
            DateTime dt = DateTime.Now;
            DateTime dt2 = new DateTime(2011, 1, 1);

            int tarihGun = dt.Day;
            int tarihYil = dt.Year;
            int tarihAy = dt.Month;

            TimeSpan tSpan = dt.Subtract(dt2);

            int gun = tSpan.Days; //TimeSPan içerisindeki gün, saat, dakika ve saniye bilgisi alınıyor
            int saat = tSpan.Hours;
            int dakika = tSpan.Minutes;
            int saniye = tSpan.Seconds;

            dt.AddDays(1); // Güne 1 ekledi
            dt.AddDays(-1); //Gün degerini 1 eksiltti
            dt.AddHours(1); //Saate 1 ekledi
            dt.AddHours(-1); //Saati 1 eksiltti

            bool artikYilMi = DateTime.IsLeapYear(2019); //Yıl artık yıl ise true döner;

            int kacGunVar=DateTime.DaysInMonth(2019, 2); //2019 şubat ayındaki gün sayısını döner

           

        }
    }
}
