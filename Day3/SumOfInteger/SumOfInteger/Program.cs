using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine(  "Enter First Number :");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number :");
            b = int.Parse(Console.ReadLine());
            int res = SumofInt(a, b);
            Console.WriteLine("Sum = "+res);
            Console.ReadKey();
        }
        static int SumofInt(int a,int b)
        {
            int sum = 0;
            if(a==b)
            {
             sum=(a+b)*3;
                return sum;
            }
            else
            {
                sum = (a + b);
                return sum;
            }
        }
    }
}
