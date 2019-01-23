using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Polymorphism
{
    class Zurafa:Hayvan
    {
        public Zurafa()
        {
            Ad = "Zurafa";
        }
        public override void SesCikar()
        {
            Console.WriteLine();
        }
    }
}
