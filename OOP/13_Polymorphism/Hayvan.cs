using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Polymorphism
{
    class Hayvan
    {
        public Hayvan()
        {
            _icgudu = "avlan,beslen";
            Ad = "hayvan";
            _yas = 0;
        }
        protected string _icgudu;
        protected int _yas;

        public string Ad { get; protected set; }

        public virtual int Yas{
            get
            {
                return _yas;
            }
            set
            {
                if(value>=0 && value<=100)
                {
                    _yas = value;
                }
            }
        }
        public virtual void SesCikar()
        {
            Console.WriteLine("Hırrrrrrr");
        }
    }
}
