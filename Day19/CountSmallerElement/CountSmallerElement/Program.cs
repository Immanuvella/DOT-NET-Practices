using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSmallerElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Enter size of array");
            N=int.Parse(Console.ReadLine());
            int[] A = new int[N];
            Console.WriteLine("Enter array elements");
            for(int i=0;i<N;i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }
            int res = Count(A, N);
            Console.WriteLine(res);

            Console.ReadKey();        }
        static int Count(int[] A,int N)
        {
            int X;
            Console.WriteLine("Enter a Number :");
            X = int.Parse(Console.ReadLine());
            int Count = 0;
            for (int i=0;i<N;i++)
            {
                if (A[i]<=X)
                {
                    Count++;
                }
            }
            return Count;
        }
    }
}
