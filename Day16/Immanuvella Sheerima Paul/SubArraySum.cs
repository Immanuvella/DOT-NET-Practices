

using System;
using System.Collections.Generic;

class SubarraySum
{
    static List<int> subarraySum(int[] arr, int n, int s)
    {
        int start = 0, end = 0, sum = 0;
        List<int> result = new List<int>();

        while (end < n)
        {
            sum += arr[end];
            while (sum > s)
            {
                sum -= arr[start];
                start++;
            }

            if (sum == s)
            {
                result.Add(start + 1);
                result.Add(end + 1);
                return result;
            }

            end++;
        }

        result.Add(-1);
        return result;
    }

    static void Main(string[] args)
    {
        int N;
        Console.WriteLine("Enter size");
        N = int.Parse(Console.ReadLine());
        int[] A = new int[N];
        Console.WriteLine("Enter array elements");
        for (int i = 0; i < N; i++)
        {
            A[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter sum :");
        int S = int.Parse(Console.ReadLine());

        List<int> result = subarraySum(A, N, S);

        Console.WriteLine("Subarray indexes: ");
        for (int i = 0; i < result.Count; i++)
        {
            Console.Write(result[i] + " ");
        }
        Console.ReadKey();
    }
}
