using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AbstractORNot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // IsAbstract property
            if (typeof(AbsClass).IsAbstract == true)
            {
                Console.WriteLine("This is abstract");
            }
            else
            {
                Console.WriteLine("This is not abstract");
            }
            Console.ReadKey();
        }
    }
}
