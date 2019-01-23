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
        public override void SesCikar()
        {
            Console.WriteLine("miyavvv");
        }
    }
}
