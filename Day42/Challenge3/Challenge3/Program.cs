using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    public static int BirthdayCakeCandles(List<int> candles)
    {
        int max = candles.Max();
        int count = candles.Count(c => c == max);
        return count;
    }
}

class Solution
{
    public static void Main(string[] args)
    
    {
        try
        {
            int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> candles = Console.ReadLine().TrimEnd().Split(' ').Select(int.Parse).ToList();

            if (candles.Count != candlesCount)
            {
                throw new ArgumentException("Invalid input: Number of candles does not match the provided count.");
            }
           
            int result = Result.BirthdayCakeCandles(candles);
            Console.WriteLine(result);
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
        }
    }
}
