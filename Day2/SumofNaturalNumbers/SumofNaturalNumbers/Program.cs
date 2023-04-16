using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumofNaturalNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.WriteLine("Enter a range");
            n1 = int.Parse(Console.ReadLine());
            int res = SumofNatural(n1);
            Console.WriteLine("Sum of {0} natural numbers is {1}",n1,res);
            Console.ReadKey();
        }
        static int SumofNatural(int n)
        {
            int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum = sum + i;
                
            }
            return sum;
        }
    }
}
