using System;

public class Program
{
    public static void Main(string[] args)
    {
        string str = Console.ReadLine(); // read the input string

        bool result = IsBinary(str); // call the IsBinary function

        Console.WriteLine(result); // output the result
        Console.ReadKey();
    }

    public static bool IsBinary(string str)
    {
        foreach (char c in str)
        {
            if (c != '0' && c != '1')
            {
                return false;
            }
        }

        return true;
    }
}
