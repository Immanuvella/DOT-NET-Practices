// C# program to demonstrate the function
// overloading by changing the Number
// of parameters
using System;
class Program
{

    // adding two integer values.
    public int Add(int a, int b)
    {
        int sum = a + b;
        return sum;
    }

    
    public int Add(int a, int b, int c)
    {
        int sum = a + b + c;
        return sum;
    }

    // Main Method
    public static void Main(String[] args)
    {

        // Creating Object
        Program ob = new Program();

        int sum1 = ob.Add(1, 2);
        Console.WriteLine("sum of the two "
                        + "integer value : " + sum1);

        int sum2 = ob.Add(1, 2, 3);
        Console.WriteLine("sum of the three "
                        + "integer value : " + sum2);
        Console.ReadKey();
    }
}

