using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Event
{
    public delegate void HizlanmaDurumunuBelirtenTip(int hiz);
    public delegate void TekIntParametreAlanEventTipi(int v);
    public delegate void ParametresizEventTipi();
    //metot void olmak zorunda, handler deklerasyonunda event kelimesi kullanılacak.
    //Ne zaman çalışacağına ben karar vereceğim ama ne yapacağını bilmiyor olacağım. (bilinçsiz)
    //event metotdunun bulunduğu nesne ise ne yapacağını bilir ama ne zaman yapılacağını bilmez..
    //metotda ise ne zaman çalışacağını biz biliyoruz ve ne yapacağını da... (bilinçli)
    class Program
    {
        
        static void Main(string[] args)
        {
            //hızlanan bir araç 120 km hızı geçtikten sonra polis ceza kessin.

            //sofor ,gaza basacak
            //araba gaza basıldığında hızlanacak
            //polis nesnesi araba 120 km geçtiğinde ceza kesecek

            //1.sprint gaz değeri verildiğinde hızlanan araba.
            Araba araba = new Araba(200, "34 hf 1387");
            //araba.HizDegistir(95);
            //Console.ReadKey();

            //2.sprint polis 120 yi geçen arabaya ceza kessin.
            Polis polis = new Polis("Osman Yazıcı");            
            araba.BenHizlandim += polis.HiziKontrolEt;//dinleme

            //Toz
            Toz toz = new Toz();
            araba.BenHizlandim += toz.Ucus;

            //Asfalt
            Asfalt asfalt = new Asfalt();
            toz.TozUcustu += asfalt.Agla;

            //araba.HizDegistir(95);


            //3. sprint söfor gaza bastıkca hızlanacaz.
            Sofor sofor = new Sofor("Alafortan Foni");
            sofor.GazaBastim += araba.HizDegistir;

            sofor.GazaBas(30);
            Console.ReadKey();
        }
    }
}
