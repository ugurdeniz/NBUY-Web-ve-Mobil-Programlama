using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Polymorphism
{
    class Kus:Hayvan
    {
        public Kus()
        {
            Ad = "Kuş";
        }
        public override void SesCikar()
        {
            Console.WriteLine("cik cik");         
        }
    }
}
