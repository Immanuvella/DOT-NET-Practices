using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter a Number");
            a = int.Parse(Console.ReadLine());
            int res = Palindrome(a);
            if(res==a)
            {
                Console.WriteLine("5Palindrome");
            }
           
               
            
            else
            {
                Console.WriteLine("Not Palindrome");
            }
            Console.ReadKey();
            
        }
        static int Palindrome(int n)
        {
            int r;
            int sum = 0;
            while(n>0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;

            }
            return sum;

        }
    }
}
