using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //IEnumerator
            //IEnumerable
            //ICollection
            //IList
            //IDictionary           

            //IQueryable

            #region ArrayList
            //// içine istediğimiz herşeyi atabildiğimiz collection tipi.
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(5);
            //arrayList.Add("osman");
            //int[] dizi = { 1,2,3,4,5};  
            //arrayList.Add(dizi);
            //CustomArrayList arrayList2 = new CustomArrayList();
            //arrayList2.Add("alafortanfoni");
            //arrayList2.Add("alafortanfoni");
            //arrayList2.Add("alafortanfoni");
            //arrayList2.Add("alafortanfoni");
            //arrayList2.Add("alafortanfoni");
            //arrayList2.Add("alafortanfoni");
            //arrayList.Add(arrayList2);
            //arrayList.Add(3);
            ////arrayList.Add(arrayList);

            //foreach (var item in dizi)
            //{
            //    // item = 4;//IEnumarable => sadece okumayı sağlar.
            //    Console.WriteLine(item);
            //}

            //foreach (var item in arrayList) //IEnumarable => sadece okumayı sağlar.
            //{
            //    Console.WriteLine(item);            
            //}
            //Console.Write("\n\n\n\n");
            //Console.Write(arrayList[3]);
            //Console.Write("\n\n\n\n");
            //((int[])(arrayList[2]))[4] = 6;
            //arrayList[1] = "Alafortanfoni";
            #endregion
            //Generic Collections
            #region Dictionary
            //Dictionary<int,string> stringDizimsi = new Dictionary<int, string>();
            //stringDizimsi.Add(0, "Osman");
            //stringDizimsi.Add(1000, "Abidin");
            //stringDizimsi.Add(5, "Ömer");
            //stringDizimsi[5] = "Süphan";
            //Console.Write(stringDizimsi[5]);
            //Console.WriteLine();
            //foreach (var item in stringDizimsi)
            //{
            //    Console.WriteLine(item.Value);
            //}
            //Console.WriteLine();
            //Dictionary<string, string> sozluk = new Dictionary<string, string>();

            //sozluk.Add("pencil", "kalem");
            //sozluk.Add("name", "isim");
            //sozluk.Add("yoghurt", "yoğurt");
            ////sozluk.Add("yoghurt", "Alafortanfoni"); Exception fırlatır
            //sozluk.Add("pen", "kalem");
            //foreach (var item in sozluk)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            //Console.WriteLine(sozluk["name"]);
            #endregion

            #region List          
            //List<Ogrenci> ogrenciler = new List<Ogrenci>();
            //Ogrenci ogrenci = new Ogrenci();
            //ogrenci.Ad = "Osman";
            //ogrenci.Soyad = "Yazıcı";
            //ogrenci.OkulNumarasi = 1867;
            //ogrenciler.Add(ogrenci);

            //ogrenci = new Ogrenci();
            //ogrenci.Ad = "Abidin";
            //ogrenci.Soyad = "Yarata";
            //ogrenci.OkulNumarasi = 101;
            //ogrenciler.Add(ogrenci);

            //ogrenci = new Ogrenci();
            //ogrenci.Ad = "Zeynep";
            //ogrenci.Soyad = "Bilgili";
            //ogrenci.OkulNumarasi = 0;
            //ogrenciler.Add(ogrenci);     


            //foreach (var item in ogrenciler)
            //{
            //    Console.WriteLine(item.Ad);
            //}
            #endregion

            #region Hashset
            //bir nesne adresi yada değer ancak bir kere yazılabilir.
            //HashSet<Ogrenci> ogrenciler = new HashSet<Ogrenci>();
            //Ogrenci ogrenci = new Ogrenci();
            //ogrenci.Ad = "Osman";
            //ogrenci.Soyad = "Yazıcı";
            //ogrenci.OkulNumarasi = 1867;
            //ogrenciler.Add(ogrenci);

            //ogrenci = new Ogrenci();
            //ogrenci.Ad = "Abidin";
            //ogrenci.Soyad = "Yarata";
            //ogrenci.OkulNumarasi = 101;
            //ogrenciler.Add(ogrenci);

            //ogrenci = new Ogrenci();
            //ogrenci.Ad = "Zeynep";
            //ogrenci.Soyad = "Bilgili";
            //ogrenci.OkulNumarasi = 0;
            //ogrenciler.Add(ogrenci);
            //ogrenciler.Add(ogrenci);

            //foreach (var item in ogrenciler)
            //{
            //    Console.WriteLine(item.Ad);
            //}

            //HashSet<int> sayilar = new HashSet<int>();
            //sayilar.Add(1);
            //sayilar.Add(1);
            //sayilar.Add(1);
            //sayilar.Add(1);
            //sayilar.Add(1);
            //sayilar.Add(1);
            //sayilar.Add(1);
            //sayilar.Add(1);
            //sayilar.Add(1);
            //sayilar.Add(1);
            //sayilar.Add(1);
            //sayilar.Add(1);
            //sayilar.Add(1);
            //sayilar.Add(1);
            //sayilar.Add(1);
            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            //Queue
            //Stack
            //Hashtable
            #region IEnumarable
            //List<string> isimler = new List<string>();
            //isimler.Add("osman");
            //isimler.Add("Ayse");
            //isimler.Add("Tutku");
            //isimler.Add("Hilal");

            //IEnumerator enumarator = isimler.GetEnumerator();
            ////enumarator.MoveNext();
            ////enumarator.MoveNext();
            ////enumarator.MoveNext();           
            ////string isim=(string)enumarator.Current;
            ////Console.WriteLine(isim);

            //while (enumarator.MoveNext())
            //{
            //    string isim = (string)enumarator.Current;
            //    Console.WriteLine(isim);
            //}
            ////Foreach 

            #endregion

            #region ICollection
            //List<string> isimler = new List<string>();
            //isimler.Add("osman");
            //isimler.Add("Ayse");
            //isimler.Add("Tutku");
            //isimler.Add("Hilal");
            //for (int i = 0; i < isimler.Count; i++)
            //{
            //    Console.WriteLine(isimler[i]); //indisleme IListten gelir. ICollection ile alakası yoktur. burada Count kullanıldı..
            //}
            ////Add,Remove,Clear gibi önceden bilinen metotlar da buradan gelir.
            #endregion

            #region IList
            //List<string> isimler = new List<string>();
            //isimler.Add("osman");
            //isimler.Add("Ayse");
            //isimler.Add("Tutku");
            //isimler.Add("Hilal");
            //isimler.Insert(2, "Mehmet");
            //isimler.RemoveAt(2);

            //foreach (var item in isimler)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region IDictionary
            IDictionary<string, string> ogrenciler = new Dictionary<string, string>();
            ogrenciler.Add("sınıfBaşkanı", "Oktay");
            ogrenciler.Add("sınıfBaskanYardımcısı", "Emre");
            ogrenciler.Add("kidemlisi", "osman");
            ogrenciler.Add("usuyeni", "Suphan");
          // ICollection<string> keyler= ogrenciler.Keys;
            foreach (var key in ogrenciler.Keys)
            {
                Console.WriteLine(key);
            }
            foreach (var value in ogrenciler.Values)
            {
                Console.WriteLine(value);
            }
            string caliskanOgrenci;
           bool caliskanOgrenciVarMi= ogrenciler.TryGetValue("caliskani", out caliskanOgrenci);
            if(!caliskanOgrenciVarMi)
            {
                Console.WriteLine("Yarın struct ve enum sizin tarafınızdan anlatılacak.");
            }
            bool sinifBaskaniVarMi=ogrenciler.ContainsKey("sınıfBaşkanı");
            if(sinifBaskaniVarMi)
            {
                Console.WriteLine("napıyon Başkan");
            }
            #endregion





            Console.ReadLine();


                
        }

    }
    class Ogrenci
    {
        public string Ad { get; set; }
        public string  Soyad { get; set; }
        public int OkulNumarasi { get; set; }
    }
}
