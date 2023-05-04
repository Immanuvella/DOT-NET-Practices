using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQMethod1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            var Query=list.Where(obj => obj >5).ToList();   
            foreach(var item in Query)
            {
                Console.WriteLine(item+ "");
            }
        }
    }
}
