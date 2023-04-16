using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CalcArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r=0;
            Console.WriteLine("Enter radius");
            r = double.Parse(Console.ReadLine());
            double res1 = CalcArea(r);
            Console.WriteLine("Area=" + res1);
            Console.ReadKey();
        }
        static double CalcArea(double r1)
        {
            double res = 3.14 * r1 * r1;
            return res;
        }
    }
}
