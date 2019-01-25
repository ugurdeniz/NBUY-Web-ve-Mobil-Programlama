using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Birsey<KucukEniste> nesne = new Birsey<KucukEniste>();
        }        
    }
    #region Generic Interface
    interface AddableInt
    {
        int Add(int a);
    }
    interface AddableDouble
    {
        double Add(double a);
    }
    interface AddableFloat
    {
        float Add(float a);
    }
    interface AddableObject //iş görür ama cast gerekir.
    {
        object Add(object a);
    }
    interface Addable<T,Alaf>
    {
        T Add(Alaf a);
    }

    class IslemYapan : Addable<object, int>
    {
        public object Add(int a)
        {
            throw new NotImplementedException();
        }
    }
    class IslemYapan2 : Addable<int, float>
    {
        public int Add(float a)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region Generic Class
    class Telliogullari
    {

    }
    class Seferogullari
    {

    }
    class KucukEniste:Telliogullari
    {

    }
    class Birsey<T> where T:Telliogullari,new()
    {
        public T MyProperty { get; set; }
        public T Metot()
        {
            T result = new T();
            return result;
        }
    }
    #endregion

    #region Generic Metot
    class Alafortanfoni
    {
        public T Hesapla<T,V>(T parametre,V parametre2) where V:class
        {           
            return parametre;
        }

        public void HesaplayiKullanan()
        {
            string ad = "Alafortanfoni";
            int donus = Hesapla<int, string>(5, ad);
        }
    }
    #endregion
}
