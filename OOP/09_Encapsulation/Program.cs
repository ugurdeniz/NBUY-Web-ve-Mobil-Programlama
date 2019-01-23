using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Encapsulation
{
    class Program
    {//Access Modifiers
        //public : proje içinden ve proje dışından olmak üzere her yerden erişim yapılabilir.
        //internal: proje içinde olmak kaidesi ile her yerden erişilebilir. (class ların default durumu internal dır)
        //internal protected: internal or protected
        //protected: classın kendi içindeki ögelerden ve bu classtan kalıtım almış classlardan erişilebilir.
        //private: sadece classın içindeki ögelerden erişim sağlanabilir. (field ve metotların default hali)
        static void Main(string[] args)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.BiriktirdigiPara = 10;
            decimal para = ogr.BiriktirdigiPara;
            ogr.Yas = -1;
            Insan insan = new Insan("Osman Yazıcı", new DateTime(1983, 1, 1), "kahverengi", 183);
            
        }
    }

    class Ogrenci
    {
        public Ogrenci()
        {
            _biriktirdigiPara = 0;
            _soylemekIstiyorMusun = true;
            _yas = 0;
        }
        private decimal _biriktirdigiPara;
        private bool _soylemekIstiyorMusun;
        public void Ode(decimal tutar)
        {
            if (_biriktirdigiPara > tutar)
            {
                _biriktirdigiPara = _biriktirdigiPara - tutar;
            }
            else
            {
                throw new Exception("Abi param yok");
            }
        }
        public void Biriktir(decimal para)
        {
            _biriktirdigiPara += para;
        }

        public decimal Get(string kimsinSen) //accessor
        {
            if (kimsinSen != "baban")
            {
                return _biriktirdigiPara;
            }
            else
            {
                return _biriktirdigiPara / 10;
            }
        }

        public void Set(decimal para)
        {
            if (para > 0)
            {
                _biriktirdigiPara = para;
            }
        }


        //get ve set accessors
        public decimal BiriktirdigiPara
        {
            get
            {
                if (_soylemekIstiyorMusun)
                {
                    return _biriktirdigiPara;
                }
                return _biriktirdigiPara / 10;
            }
            set
            {                
                _biriktirdigiPara = value;                
            }
        } //Property

        //_adSoyad
        //public string AdSoyad { get; set; } //direk şartsız okuma ve yazma yapılıyor. Hiç birşey değişmedi.

        public string OgrenciNumarasi { get; set; } //get ve set var ise eğer buna full property.
        public string AdSoyad { get; } //sadece okunabilir.
        public string AdSoyad2 { get; private set; } //sadece okunabilir. class içinden atanır.
        public decimal Maas { set { } } //sadece yazılabilir.
        public decimal Maas2 { private get; set; } //sadece yazılabilir. class içinden okunur.

        private int _yas;
        public int Yas {
           
            set
            {
                if(value>=0 && value<200)
                {
                    _yas = value;
                }
            }
        }

   
    }

    class Insan
    {
        public Insan(string adSoyad,DateTime dogumTarihi,string gozRengi,int boy)
        {
            _adSoyad = adSoyad;
            _dogumTarihi = dogumTarihi;
            _gozRengi = gozRengi;
            _boy = boy;
        }

        string _adSoyad;
        DateTime _dogumTarihi;
        string _gozRengi;
        int _boy;

        public string AdSoyad
        {
            get
            {
                return _adSoyad;
            }
        }
        public DateTime DogumTarihi {
            get
            {
                return _dogumTarihi;
            }
        }
        public string GozRengi
        {
            get
            {
                return _gozRengi;
            }
        }
        public int Boy {
            get
            {
                return _boy;
            }
            set
            {
                if(value>0 && value<4000)
                {
                    _boy = value;
                }
            }
        }
    }
}
