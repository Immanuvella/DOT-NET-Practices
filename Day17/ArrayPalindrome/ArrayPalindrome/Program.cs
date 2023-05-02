using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter size");
        int n = Convert.ToInt32(Console.ReadLine()); // read the number of elements
        Console.WriteLine("Enter elements");
        int[] arr = new int[n]; // initialize an array of size n

        // read the elements of the array
        string[] input = Console.ReadLine().Split();
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(input[i]);
        }

        int result = PalinArray(arr, n); // call the PalinArray function

        Console.WriteLine(result);
        // output the result
        Console.ReadKey();
    }

    public static int PalinArray(int[] arr, int n)
    {
        for (int i = 0; i < n; i++)
        {
            int num = arr[i];
            int reversed = 0;
            int temp = num;

            while (temp > 0)
            {
                int remainder = temp % 10;
                reversed = reversed * 10 + remainder;
                temp /= 10;
            }

            if (num != reversed)
            {
                return 0;
            }
        }

        return 1;
    }
}
