using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Inheritance
{
    class Program
    {
        //MultiInheritance => diamond problem
        //Firma ve Firmadaki çalışanları çalışma şeklini basitçe modelleyelim. 2 Yazılımcı, 1 muhasebeci , bir ik ve bir pazarlama personeli olacak.

        //Yazılımcı
        //İnsan Kaynakları
        //Muhasebe
        //Pazarlama
        //Danisman


        static void Main(string[] args)
        {
            Personel personel = new ErkekYazılımcı(); //base classın child class yerine kullanımı.
            ParanizYattiParaniCek(personel);            

            KadınYazılımcı yazilimciKadin = new KadınYazılımcı();
            ParanizYattiParaniCek(yazilimciKadin);

            KadınIk ik = new KadınIk();
            ErkekMuhasebeci muhasebeci = new ErkekMuhasebeci();

            KadınPazarlamaci pazarlamaci = new KadınPazarlamaci();
            ParanizYattiParaniCek(pazarlamaci);

            ErkekYazılımcı yazilimci = (ErkekYazılımcı)personel;
            yazilimci.KodYaz();

            //personel.KodYaz();
            //personel.MaasAl();


            //yazilimciErkek.OdemeleriYap();
            //yazilimciErkek._dogumIzni = 365;
            //yazilimciKadin._askerlikIzni = 21;
            //muhasebeci.KodYaz();
            //ik.Sat();
            //pazarlamaci.IseAl();
        }

        //public static void ParanizYattiParaniCek(ErkekYazılımcı erkekYazilimci)
        //{
        //    erkekYazilimci.MaasAl();
        //}

        //public static void ParanizYattiParaniCek(KadınYazılımcı kadınYazılımcı)
        //{
        //    kadınYazılımcı.MaasAl();
        //}

        public static void ParanizYattiParaniCek(Personel personel)
        {
            //bla bla
            personel.MaasAl();
        }
    }


    class Goruntu
    {
        //bla bla
    }
    class Canlı { }
    class Goz
    {
        public string renk;
        public Goruntu Gor() { return new Goruntu(); }
    }
    class Insan
    {
        public Insan()
        {
            _sagGoz = new Goz();
            _solGoz = new Goz();
        }
        public Goz _sagGoz;
        public Goz _solGoz;
        public string _adSoyad;
        public byte _cinsiyet;
        public string _adres;
        public void YemekYe() { }
        public void ÇayIc() { }
        public void Dinlen() { }
    }
    class Personel : Insan
    {
        public decimal _maas;
        public string _pozisyon;
        public string _deneyim;
        public int _yillikIzin;
        public decimal MaasAl() { return _maas; }
    }
    class KadınPersonel : Personel
    {
        public int _dogumIzni;
    }
    class ErkekPersonel : Personel
    {
        public int _askerlikIzni;
        public int _babalikIzni;
    }
    class KadınYazılımcı : KadınPersonel
    {
        public void KodYaz() { }
    }
    class ErkekYazılımcı : ErkekPersonel
    {
        public void KodYaz() { }
    }
    class KadınIk : KadınPersonel
    {
        public void IseAl() { }
        public void IstenCikar() { }
        public void YalandanOyala() { }
    }
    class ErkekIk : ErkekPersonel
    {
        public void IseAl() { }
        public void IstenCikar() { }
        public void YalandanOyala() { }
    }
    class ErkekMuhasebeci : ErkekPersonel
    {
        public void MaaslariYatir() { }
        public void OdemeleriYap() { }
    }
    class KadınMuhasebeci : KadınPersonel
    {
        public void MaaslariYatir() { }
        public void OdemeleriYap() { }
    }
    class ErkekPazarlamaci : ErkekPersonel
    {
        public void YalanSoyle() { }
        public void Sat() { }
        public void SatisOncesiDestekVer() { }
    }
    class KadınPazarlamaci : KadınPersonel
    {
        public void YalanSoyle() { }
        public void Sat() { }
        public void SatisOncesiDestekVer() { }
    }
    class KadınDanisman : KadınPersonel
    {
        public void DanismanlikHizmetiVer() { }
    }
}
