using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Collections
{
    class CustomArrayList:ArrayList
    {
        public override string ToString()
        {
            string result = "";
            foreach (var item in this)
            {
                result += item.ToString() + "\n";
            }
            return result;
        }
    }
}
