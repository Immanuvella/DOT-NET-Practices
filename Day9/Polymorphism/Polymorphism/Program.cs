using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Shape s1 = new Shape();
            s1.Drawshape();

            Circle s3 = new Circle();
            s3.Drawshape();

            Shape s2 = new Circle();
            s2.Drawshape();
            // Array of references of base class refeencing
            // Derived class object(upcasting)
            Console.ReadKey();
        }
    }
}


