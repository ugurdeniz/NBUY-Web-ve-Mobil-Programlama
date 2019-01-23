using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Event
{

    class Araba
    {
        public event HizlanmaDurumunuBelirtenTip BenHizlandim;
        //event bilgiyi veren tarafta declare edilir.
        public Araba(int maxHiz,string plaka)
        {
            _maxHiz = maxHiz;
            _mevcutHiz = 0;
            _plaka = plaka;
        }

        private string _plaka;
        private int _maxHiz;
        private int _mevcutHiz;
        public int MevcutHiz { get { return _mevcutHiz; } }

        public void HizDegistir(int gazYuzdesi)
        {
            _mevcutHiz = _maxHiz * gazYuzdesi / 100;
            Console.WriteLine(_plaka+" plakalı arabanın şu anki hızı: " + _mevcutHiz + " km");
            BenHizlandim(_mevcutHiz); //bilgiyi veren tarafta tetiklenir.
        }     
    }
}
