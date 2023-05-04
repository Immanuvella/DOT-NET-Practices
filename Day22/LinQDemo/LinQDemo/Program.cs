using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQDemo
{
    internal class Program
    {


        static void Main(string[] args)
        {
            int[] ar = { 1, 5, 2, 15, 19, 30, 21, 6, 4 };
            var num = from n in ar
                      where n % 2 == 0
                      select n;
            foreach (int x in num)
            {
                Console.WriteLine(x);

            }
        }
    }
}
