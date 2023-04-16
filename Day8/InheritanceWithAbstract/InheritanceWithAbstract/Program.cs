//C# Program to Demonstrate Abstract Class with Multiple-level Inheritance
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceWithAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo3 obj = new Demo3();

            // Call the methods using GFG3 class
            obj.abstract_method();
            obj.Mymethod1();
            obj.Mymethod2();
            Console.ReadKey();
        }
    }
}
