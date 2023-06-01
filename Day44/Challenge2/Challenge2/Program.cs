using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<string> numbers = new List<string>();

        for (int i = 0; i < n; i++)
        {
            string number = Console.ReadLine();
            numbers.Add(number);
        }

        // Reorder the array
        numbers.Sort();

        // Output the reordered array
        foreach (string number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
