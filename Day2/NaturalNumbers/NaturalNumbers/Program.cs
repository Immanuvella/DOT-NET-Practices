using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First 10 natural numbers are :");
            for (int i=1;i<=10;i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
