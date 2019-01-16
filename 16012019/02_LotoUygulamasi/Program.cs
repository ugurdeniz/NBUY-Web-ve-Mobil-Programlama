using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_LotoUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lotoDizisi = new int[6];
            Random rnd = new Random();


            for (int i = 0; i < lotoDizisi.Length; i++)
            {
               
                while (true)
                {
                    int uretilenSayi = rnd.Next(50);
                    bool varMi = DizideVarMi(uretilenSayi, lotoDizisi);

                    if (varMi)
                    {
                        continue;
                    }
                    else
                    {
                        lotoDizisi[i] = uretilenSayi;
                        break;
                    }
                }
            }

            for (int i = 0; i < lotoDizisi.Length; i++)
            {
                Console.WriteLine(lotoDizisi[i]);
            }

            Console.Read();
        }

        private static bool DizideVarMi(int rasgeleSayi, int[] lotoDizisi)
        {
            bool varMi = false;
            for (int i = 0; i < lotoDizisi.Length; i++)
            {
                if (lotoDizisi[i] == rasgeleSayi)
                {
                    varMi = true;
                }
            }
            return varMi;
        }


    }
}
