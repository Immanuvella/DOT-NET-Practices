using GenericsDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    internal class Class1
    {
        public static void Main(string[] args)
        {
            //int
            //MyGenericClass<int> abc = new MyGenericClass<int>(10);
            //int res = abc.GenericMethod(200);
            //string
            MyGenericClass<string> abc = new MyGenericClass<string>("ABC");
            string res = abc.GenericMethod("A");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
