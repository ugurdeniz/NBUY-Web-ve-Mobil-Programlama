using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Polymorphism
{
    class Kedi:Hayvan
    {
        public Kedi()
        {
            Ad = "Kedi";
        }
        public override int Yas {
            get
            {
                return _yas;
                    }
            set
            {
                if(value>=0 && value<=20)
                {
                    _yas = value;
                }
                else
                {
                    throw new Exception("Kediler 0-20 yaş aralığında yaşayabilirler");
                }
            }
        }
        public override void SesCikar()
        {
            Console.WriteLine("miyavvv");
        }
    }
}
