using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            //a
            string kAdiGiris, sifreGiris, kAdi = "uğur", sifre = "123";
            Console.WriteLine("Kullanıcı adını girin");
            kAdiGiris = Console.ReadLine();
            Console.WriteLine("Şifreyi girin");
            sifreGiris = Console.ReadLine();

            if (kAdiGiris==kAdi && sifreGiris==sifre)
            {
                Console.Write("Giriş başarılı");
            }
            else
            {
                Console.WriteLine("Kullanıcı adı veya şifre hatalı");
            }
            //b
            Console.WriteLine("3 adet sayı girin");
            int s1 = int.Parse(Console.ReadLine());
            int s2 = int.Parse(Console.ReadLine());
            int s3 = int.Parse(Console.ReadLine());
            if (s1>s2 && s1> s3)
            {
                Console.WriteLine("En büyük sayı=" + s1);
            }
            else if(s2>s1 && s2>s3)
            {
                Console.WriteLine("En büyük sayı= " + s2);
            }
            else
            {
                Console.WriteLine("En büyük sayı= " + s3);
            }
            //c
            int sayi = int.Parse(Console.ReadLine());
            if (sayi%2==0)
            {
                Console.WriteLine("Sayi çift");
            }
            //d
            Console.WriteLine("İki sayi girin");
            
            string snc;
            s1 = int.Parse(Console.ReadLine());
            s2 = int.Parse(Console.ReadLine());
            if (s1>s2)
            {
                 snc = s1 % s2 == 0 ? "Tam katı" : "Tam katı değil";
            }
            else if(s2>s1)
            {
                snc = s2 % s1 == 0 ? "Tam katı" : "Tam katı değil";
            }
            else
            {
                snc = "Eşit";
            }
            Console.WriteLine(snc);
            //e

            Console.WriteLine("Kenar uzunluklarını giriniz");
            double k1, k2, k3;
            k1 = Convert.ToDouble(Console.ReadLine());
            k2 = Convert.ToDouble(Console.ReadLine());
            k3 = Convert.ToDouble(Console.ReadLine());
            if ((k1+k2>k3 && k3<k1-k2) && (k1+k3>k2 && k2<k1-k3) && (k2+k3>k1 && k1<k2-k3))
            {
                Console.WriteLine("Üçgen oluşturulabilir");
            }
            //f
            Console.WriteLine("Açı değerlerini girin");
           
            int aci1, aci2, aci3;
            aci1 = int.Parse(Console.ReadLine());
            aci2 = int.Parse(Console.ReadLine());
            aci3 = int.Parse(Console.ReadLine());
            if ((aci1+aci2+aci3)==180)
            {
                Console.WriteLine("Üçgen oluşturur");
            }
            //h
            if ((aci1 + aci2 + aci3) == 180 && (aci1==90 | aci2==90 | aci3==90))
            {
                Console.WriteLine("Dik üçgendir");
            }

        }
    }
}
