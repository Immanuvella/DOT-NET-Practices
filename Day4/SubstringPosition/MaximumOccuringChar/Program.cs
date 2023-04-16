//Write a program in C# Sharp to search the position of a substring within a string.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MaximumOccuringChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a;
           
            Console.WriteLine( "Enter a string");
            a = Console.ReadLine();
            Console.WriteLine("Enter a substring to search");
            string sub = Console.ReadLine();
            int pos = a.IndexOf(sub);
            if (pos < 0)
            {
                Console.WriteLine("substring is not present");
            }
            else
            {
                Console.WriteLine("substring  is present at the position {0}",  pos+1);
            }


            Console.ReadKey();

        }
       
        
    }
}
