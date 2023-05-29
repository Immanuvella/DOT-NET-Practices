using System;
using System.Collections.Generic;

class Result
{
    public static long Solve(List<int> arr)
    {
        Dictionary<int, int> freq = new Dictionary<int, int>();
        long count = 0;

        foreach (int num in arr)
        {
            if (freq.ContainsKey(num))
                freq[num]++;
            else
                freq[num] = 1;
        }

        foreach (var kvp in freq)
        {
            int frequency = kvp.Value;
            count += (long)frequency * (frequency - 1) / 2; // Count all possible pairs
        }

        return count;
    }
}

class Solution
{
    static void Main(string[] args)
    {

        int arrCount = int.Parse(Console.ReadLine());
        List<int> arr = new List<int>(Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse));
        long result = Result.Solve(arr);
        Console.WriteLine(result);
    }
}
