using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Writer w = new Writer();
            Console.WriteLine("Enter Name");
            w.name=Console.ReadLine();
            Console.WriteLine("Enter Mark1");
            w.m1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Mark2");
            w.m2 = int.Parse(Console.ReadLine());
            w.Readers(w.name, w.m1, w.m2);
            w.Writers();
            Console.ReadKey();
        }
    }
}
