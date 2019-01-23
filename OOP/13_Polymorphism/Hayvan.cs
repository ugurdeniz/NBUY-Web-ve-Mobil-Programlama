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
        }
        protected string _icgudu;

        public string Ad { get; protected set; }
        public virtual void SesCikar()
        {
            Console.WriteLine("Hırrrrrrr");
        }
    }
}
