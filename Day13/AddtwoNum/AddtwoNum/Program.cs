using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddtwoNum
{
    internal class Program
    { 
        
        public delegate int Sum(int x, int y);
        static void Main(string[] args)
        {
            int result;
            Sum s = delegate (int n, int m)
            {
                return n + m;
            };
            result = s(10, 20);
            Console.WriteLine(result);
        }
    }
}
