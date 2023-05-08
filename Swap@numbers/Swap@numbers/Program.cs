using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter First Number:");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            b=int.Parse(Console.ReadLine());
            Swap(a, b);
            Console.WriteLine("After swapping :  ");
            Swap(a,b);
        }
        static void Swap(int a, int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("a="+a+" b="+b);

        }
    }
}
