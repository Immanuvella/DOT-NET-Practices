using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input="1001,arya,25000";
            string[] entries = input.Split(',');
            foreach (string entry in entries) 
            {
                Console.WriteLine(entry);
            }
        }
    }
}
