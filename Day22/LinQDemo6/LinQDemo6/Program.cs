using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQDemo6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var digitOddEvens = from n in numbers
                                select (Digit: strings[n], Even: (n % 2 == 0));

            foreach (var d in digitOddEvens)
            {
                Console.WriteLine($"The digit {d.Digit} is {(d.Even ? "even" : "odd")}.");
            }
        }
    }
}
