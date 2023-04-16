using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr = new int[10];

            Console.WriteLine("Enter Elements");
            for(int i = 0; i < 10; i++)
            {
                arr[i]=int.Parse(Console.ReadLine() );
            }
           ASum(arr);
            Console.ReadKey();
            


        }
        static void ASum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += arr[i];


            }
            Console.WriteLine("Sum is " + sum);
        }
    }
}
