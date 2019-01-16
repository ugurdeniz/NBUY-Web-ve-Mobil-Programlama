using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavaYollariUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                KarsilamaEkrani();
                BirSatirBesle();
                int classSecimi = classSecimiAl();

                string[] economyClassKoltuklar = new string[11];
                string[] businessClassKoltuklar = new string[7];
                bool geriDon = false;

                BosKoltuklariListele(classSecimi, out geriDon, economyClassKoltuklar, businessClassKoltuklar);
                if (geriDon==true)
                {
                    continue;
                }
                int koltukSecimi = koltukSecimiAl(classSecimi, economyClassKoltuklar, businessClassKoltuklar);
                BirSatirBesle();

                KoltukRezerveEt(koltukSecimi, classSecimi, ref economyClassKoltuklar, ref businessClassKoltuklar);
                Console.Read();
            }
        }

        private static void BosKoltuklariListele(int classSecimi,out bool geriDon, string[] economyClassKoltuklar, string[] businessClassKoltuklar)
        {
            while (true)
            {
                bool bosKoltukVarMı = false;
                if (classSecimi == 1)
                {
                    for (int i = 0; i < businessClassKoltuklar.Length; i++)
                    {
                        if (businessClassKoltuklar[i] == null)
                        {
                            EkranaYaz(i.ToString());
                            BirSatirBesle();
                            bosKoltukVarMı = true;
                            if (i==businessClassKoltuklar.Length-1)
                            {
                                break;
                            }
                        }

                    }
                    if (bosKoltukVarMı == false)
                    {
                        EkranaYaz("Seçtiğiniz business class bölümünde boş koltuk kalmamıştır\n Economy class bölümündeki boş koltukları gormez İster misiniz ?(E/H)");
                        string input = Console.ReadLine();
                        if (input == "e")
                        {
                            classSecimi = 2;
                            continue;

                        }
                        if (input == "h")
                        {
                            EkranaYaz("Bir sonraki uçuş 4 saat sonradır.");
                            geriDon = true;
                            break;
                        }
                    }
                }
                if (classSecimi == 2)
                {
                    for (int i = 0; i < economyClassKoltuklar.Length; i++)
                    {
                        if (economyClassKoltuklar[i] == null)
                        {
                            EkranaYaz(economyClassKoltuklar[i].ToString());
                            bosKoltukVarMı = true;
                        }

                    }
                    if (bosKoltukVarMı == false)
                    {
                        EkranaYaz("Seçtiğiniz economy class bölümünde boş koltuk kalmamıştır\n business class bölümündeki boş koltukları gormez İster misiniz ?(E/H)");
                        string input = Console.ReadLine();
                        if (input == "e")
                        {
                            classSecimi = 1;
                            continue;

                        }
                        if (input == "h")
                        {
                            EkranaYaz("Bir sonraki uçuş 4 saat sonradır.");
                            geriDon = true;
                            break;
                        }
                    }
                }
            }
        }

        private static void BirSatirBesle()
        {
            Console.WriteLine();
        }

        private static string KoltukRezerveEt(int koltukSecimi, int classSecimi, ref string[] economyClassKoltuklar, ref string[] businessClassKoltuklar)
        {
            EkranaYaz("Seçilen koltuk numarası= " + koltukSecimi);
            BirSatirBesle();
            EkranaYaz("Lütfen yolcunun adını ve soyadını yazın");
            string adSoyad = Console.ReadLine();

            if (classSecimi == 1)
            {
                economyClassKoltuklar[koltukSecimi] = adSoyad;
                EkranaYaz("Economy class bölümündeki" + koltukSecimi + "numaralı koltuğu" + adSoyad + "adlı kişiye rezerve ettiniz!");
                BirSatirBesle();
                EkranaYaz("Devam etmek için bir tuşa basın...");
                return Console.ReadLine();
            }
            if (classSecimi == 2)
            {
                businessClassKoltuklar[koltukSecimi] = adSoyad;
                EkranaYaz("Business class bölümündeki" + koltukSecimi + "numaralı koltuğu" + adSoyad + "adlı kişiye rezerve ettiniz!");
                BirSatirBesle();
                EkranaYaz("Devam etmek için bir tuşa basın...");
                return Console.ReadLine();
            }
            return Console.ReadLine();

        }

        private static void Temizle()
        {
            Console.Clear();
        }

        private static int koltukSecimiAl(int classSecimi, string[] economyClassKoltuklar, string[] businessClassKoltuklar)
        {
            while (true)
            {
                string input = Console.ReadLine();
                int koltukSecimi = 0;
                bool kontrol = int.TryParse(input, out koltukSecimi);
                if (kontrol)
                {
                    if (classSecimi == 1)
                    {
                        if (economyClassKoltuklar[koltukSecimi] != null)
                        {
                            EkranaYaz(koltukSecimi + "Numaralı Koltuğu " + economyClassKoltuklar[koltukSecimi] + "isimli yolcuya rezerve ettin! \n Lütfen boş koltuklardan birini seçiniz");
                            continue;
                        }
                        else
                        {
                            return koltukSecimi;
                        }
                    }
                    if (classSecimi == 2)
                    {
                        if (businessClassKoltuklar[koltukSecimi] != null)
                        {
                            EkranaYaz(koltukSecimi + "Numaralı Koltuğu " + businessClassKoltuklar[koltukSecimi] + "isimli yolcuya rezerve ettin! \n Lütfen boş koltuklardan birini seçiniz");
                            continue;
                        }
                        else
                        {
                            return koltukSecimi;
                        }
                    }
                }
                else
                {
                    continue;
                }
            }

        }


        private static int classSecimiAl()
        {
            int classSecimi = 0;

            while (true)
            {

                string input = Console.ReadLine();

                bool kontrol = int.TryParse(input, out classSecimi);
                if (kontrol)
                {
                    if (classSecimi == 1 || classSecimi == 2)
                    {
                        return classSecimi;
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    continue;
                }

            };

        }

        private static void SecimYap()
        {
            throw new NotImplementedException();
        }

        private static void KarsilamaEkrani()
        {
            EkranaYaz("1. Business Class bölümü için 1 tuşuna basın");
            BirSatirBesle();
            EkranaYaz("Economy class bölümü için 2 tuşuna basın");
            BirSatirBesle();

        }

        private static void EkranaYaz(params string[] metin)
        {
            for (int i = 0; i < metin.Length; i++)
            {
                Console.Write(metin[i]); 
            }
        }

    }
}
