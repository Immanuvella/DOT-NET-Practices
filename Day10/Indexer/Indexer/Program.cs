using indexer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayDemo a = new ArrayDemo();
            a[3] = 43.2f;
            Console.WriteLine("The array element is :"+a[3]);
            Console.ReadKey();
        }

    }
}


