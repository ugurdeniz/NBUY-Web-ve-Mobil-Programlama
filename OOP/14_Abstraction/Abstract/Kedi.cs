using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Abstraction.Abstract
{
    class Kedi:Hayvan
    {
        public Kedi(int yas):base(yas)
        {

        }
        public override void SesCikar()
        {
            Console.WriteLine("miyavvv");
        }

        public  void SesCikar(string ses)
        {
            Console.WriteLine(ses);
        }
    }
}
