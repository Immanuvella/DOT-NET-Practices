using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amstrong_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a Number:");
            n=int.Parse(Console.ReadLine());
            int res = AmstrongNumber(n);
            if(res==n)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
        static int AmstrongNumber(int N)
        {
            int s = 0;
            int rem = 0;
            while(N>0)
            {
                rem = N % 10;
                s = (rem * rem * rem) + s;
                N = N / 10;
                
            }
            return s;
        }
    }
}
