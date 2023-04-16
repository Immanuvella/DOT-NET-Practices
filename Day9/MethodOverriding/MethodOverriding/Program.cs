using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // invoke no argument constructor
            DerivedClass d1 = new DerivedClass();

            Console.WriteLine();

            // invoke parameterized constructor
            DerivedClass d2 = new DerivedClass(10, 20);
            Console.ReadKey();

        }
    }
}
