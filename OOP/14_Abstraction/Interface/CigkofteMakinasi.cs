using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Abstraction.Interface
{
    class CigkofteMakinasi : ICigkofteYapabilen
    {
        public void CigkofteYogur()
        {
            for (int i = 0; i < 100; i++)
            {
Console.WriteLine("ÇiğKöfte yoĞurDum.");
            }
            
        }
    }
}
