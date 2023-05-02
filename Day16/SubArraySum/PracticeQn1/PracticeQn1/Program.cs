using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQn1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, sum;
            Console.WriteLine("Enter Array size:");
            N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            Console.WriteLine("Enter Array elements");
            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter Sum :");
            sum = int.Parse(Console.ReadLine());
            Subarray(A, N, sum);
            Console.ReadKey();


        }
        static void Subarray(int[] A, int N, int sum)
        {
            int currentsum, i, j;
            // Start with initial index 0 element  
            for (i = 0; i < N; i++)
            {
                currentsum = A[i];
                // try all subarrays starting with 'i'
                for (j = i + 1; j <= N; j++)
                {
                    if (currentsum == sum)
                    {
                        Console.WriteLine(i+1 + " " + j );                     
                    }
                    if (currentsum > sum || j == N)
                      break;
                   currentsum = currentsum + A[j];
                }
            }

        }

    }
}
