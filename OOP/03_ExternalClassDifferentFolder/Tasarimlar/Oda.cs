using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasarimlar;

namespace _03_ExternalClassDifferentFolder.Tasarimlar
{
    class Oda
    {
       public Dolap dolap=new Dolap();
        public Sandalye.Sandalye sandalye = new Sandalye.Sandalye();
        public Masa masa = new Masa();
    }
}
