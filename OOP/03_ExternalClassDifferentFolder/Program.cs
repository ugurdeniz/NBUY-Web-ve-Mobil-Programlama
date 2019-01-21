using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03_ExternalClassDifferentFolder.Tasarimlar;
using Tasarimlar;
using Sandalye;

namespace _03_ExternalClassDifferentFolder
{
    class Program
    {
        static void Main(string[] args)
        {
            Dolap dolap = new Dolap();
            Masa masa = new Masa();
            Sandalye.Sandalye sandalye = new Sandalye.Sandalye();
            Oda oda = new Oda();          
        }
    }
}
