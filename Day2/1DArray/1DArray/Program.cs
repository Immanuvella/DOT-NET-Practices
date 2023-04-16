using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[5];
            Console.Write("Enter array Elements:");

            for(int i=0;i<array1.Length;i++)
            {
                
                array1[i]=int.Parse(Console.ReadLine());
            }
            Console.Write("Array Elements:\n");

            for (int i = 0; i < array1.Length; i++)
            {

                Console.WriteLine(array1[i]);
            }
            Console.ReadKey();
        }
    }
}
