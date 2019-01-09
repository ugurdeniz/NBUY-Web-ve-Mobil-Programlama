using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            //a
            int s1, s2, s3;
            Console.WriteLine("3 Sayı giriniz");
            s1 = int.Parse(Console.ReadLine());
            s2 = int.Parse(Console.ReadLine());
            s3 = int.Parse(Console.ReadLine());
            //01
            Console.WriteLine("\n {0},{1} ve {2} sayıları birbirine eşittir : {3}", s1, s2, s3, s1 == s2 && s2 == s3 ? true : false);
            //02
            Console.WriteLine("\n {0},{1} ve {2} sayıları birbirine eşit değildir : {3}", s1, s2, s3, s1 != s2 && s2 != s3 ? true : false);
            //03
            Console.WriteLine("\n {0} sayısı {1} ve {2} sayılarından büyüktür : {3}", s1, s2, s3, s1>s2 && s1>s3 ? true : false);
            //04
            Console.WriteLine("\n {0} sayısı {1} ve {2} sayılarından büyüktür veya sayılara eşittir : {3}", s1, s2, s3, s1 >= s2 && s1 >= s3 ? true : false);
            //05
            Console.WriteLine("\n {0} sayısı {1} ve {2} sayılarından küçüktür : {3}", s1, s2, s3, s1 < s2 && s1 < s3 ? true : false);
            //06
            Console.WriteLine("\n {0} sayısı {1} ve {2} sayılarından küçüktür veya sayılara eşittir : {3}", s1, s2, s3, s1 <= s2 && s1 <= s3 ? true : false);
            //07
            Console.WriteLine("\n {1} sayısı {0} ve {2} sayılarından büyüktür : {3}", s1, s2, s3, s2 > s1 && s2 > s3 ? true : false);
            //08
            Console.WriteLine("\n {1} sayısı {0} ve {2} sayılarından büyüktür veya sayılara eşittir : {3}", s1, s2, s3, s1 >= s2 && s1 >= s3 ? true : false);
            //09
            Console.WriteLine("\n {1} sayısı {0} ve {2} sayılarından küçüktür : {3}", s1, s2, s3, s2 < s1 && s2 < s3 ? true : false);
            //10
            Console.WriteLine("\n {1} sayısı {0} ve {2} sayılarından küçüktür veya sayılara eşittir : {3}", s1, s2, s3, s2 <= s1 && s2 <= s3 ? true : false);
            //11
            Console.WriteLine("\n {2} sayısı {1} ve {0} sayılarından büyüktür : {3}", s1, s2, s3, s3 > s2 && s3 > s1 ? true : false);
            //12
            Console.WriteLine("\n {2} sayısı {0} ve {1} sayılarından büyüktür veya sayılara eşittir : {3}", s1, s2, s3, s3 >= s2 && s3 >= s1 ? true : false);
            //13
            Console.WriteLine("\n {2} sayısı {0} ve {1} sayılarından küçüktür : {3}", s1, s2, s3, s3 < s1 && s3 < s1 ? true : false);
            //14
            Console.WriteLine("\n {2} sayısı {0} ve {1} sayılarından küçüktür veya sayılara eşittir : {3}", s1, s2, s3, s3 <= s1 && s3 <= s2 ? true : false);



            //b

            string i0, i1, i2;
            int y0, y1, y2;
            Console.WriteLine("1. İsim ? ");
            i0 = Console.ReadLine();
            Console.WriteLine("1. İsmin Yaşı ?");
            y0 = int.Parse(Console.ReadLine());
            Console.WriteLine("2. İsim ? ");
            i1 = Console.ReadLine();
            Console.WriteLine("2. İsmin Yaşı ?");
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("3. İsim ? ");
            i2 = Console.ReadLine();
            Console.WriteLine("3. İsmin Yaşı ?");
            y2 = int.Parse(Console.ReadLine());
            //01
            Console.WriteLine("{0},{1} ve {2} isimli kişilerin yaşları birbirine eşittir: {3}",i0,i1,i2,y0==y1 && y1==y2 ? true:false);
            //02
            Console.WriteLine("{0},{1} ve {2} isimli kişilerin yaşları birbirine eşit değildir: {3}", i0, i1, i2, y0 != y1 && y1 != y2 ? true : false);
            //03
            Console.WriteLine("{0} isimli kişinin yaşı {1} ve {2} isimli kişilerin yaşından büyüktür: {3}", i0, i1, i2, y0 > y1 && y1 > y2 ? true : false);
            //04
            Console.WriteLine("{0} isimli kişinin yaşı {1} ve {2} isimli kişilerin yaşından büyüktür veya eşittir: {3}", i0, i1, i2, y0 >= y1 && y1 >= y2 ? true : false);

            Console.ReadLine();
        }
    }
}
