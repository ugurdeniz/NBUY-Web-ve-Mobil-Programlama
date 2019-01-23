using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Polymorphism
{
    class Kopek:Hayvan
    {
        public Kopek()
        {
            Ad = "Kopek";
        }
        public override void SesCikar()
        {
            base.SesCikar();
            Console.WriteLine("hav hav");
        }
    }
}
