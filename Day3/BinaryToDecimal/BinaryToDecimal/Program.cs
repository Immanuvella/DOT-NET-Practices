using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter a decimal Number :");
            a=int.Parse(Console.ReadLine());
           
            Console.WriteLine( "Equivalent Binary Number is "+DecimalConversion(a));
            Console.ReadKey();

        }
        static string DecimalConversion(int a)
        {
            int r=0;
           if( a < 2)
            
                return a.ToString();
                 int n = a / 2;
                r=a% 2;
                return DecimalConversion(n) + r;

            

           
            
        }
    }
}
