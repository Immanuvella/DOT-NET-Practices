// C# program to show the workin of abstract class with the get and set accessors
using System;

abstract class absClass
{

    protected int myNumber;

    public abstract int numbers
    {
        get;
        set;
    }
}

class absDerived : absClass
{

    // Implementing abstract properties
    public override int numbers
    {
        get
        {
            return myNumber;
        }
        set
        {
            myNumber = value;
        }
    }
}


class Program
{

    // Main Method
    public static void Main()
    {
        absDerived d = new absDerived();
        d.numbers = 5;
        Console.WriteLine("Number is :"+d.numbers);
        Console.ReadKey();
    }
}
