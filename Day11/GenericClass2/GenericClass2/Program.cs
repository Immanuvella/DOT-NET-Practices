using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericClass2<string> g2 = new GenericClass2<string>();
            g2.Message = "Hello";
            g2.GenericMethod("Immanuvella", "Kochi");

            //method2
            g2.GenericMethod2<int, int>(10, 20);
            g2.GenericMethod2<double, string>(12.30, "ABc");
            g2.GenericMethod2<string, float>("cbf", 20.5f);

            Console.ReadKey();

        }
    }
    
}
