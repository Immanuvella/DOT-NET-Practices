using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
           
            
                num = int.Parse(Console.ReadLine());
            
           
            Console.WriteLine(Replace0s(num));

    }
    static string Replace0s(int N)
        {
           
                String temp = N + "";
            return temp.Replace('0', '5');
            

        }
    }
}
