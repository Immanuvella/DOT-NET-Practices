using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an object of myClass3
            myClass3 myObject = new myClass3();

            myObject.print1();
            myObject.print2();
            Console.ReadKey();
        }
    }
}
