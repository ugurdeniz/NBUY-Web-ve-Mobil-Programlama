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

        public string Plaka { get { return _plaka; } }
        public int MevcutHiz { get { return _mevcutHiz; } }

        public Sofor Sofor { get; private set; }

        public void HizDegistir(int gazYuzdesi,object sender)
        {
            if(sender is Sofor)
            {
                Sofor = sender as Sofor;
            }
            _mevcutHiz = _maxHiz * gazYuzdesi / 100;
            Console.WriteLine(_plaka+" plakalı arabanın şu anki hızı: " + _mevcutHiz + " km");
            BenHizlandim(_mevcutHiz,this); //bilgiyi veren tarafta tetiklenir.
        }     
    }
}
