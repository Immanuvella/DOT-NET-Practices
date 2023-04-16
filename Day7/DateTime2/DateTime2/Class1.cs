using System;

public class Example2
{
    public static void Main()
    {
        //System.DateTime moment = new System.DateTime(2023, 8, 16, 3, 57, 32, 11);
        Console.WriteLine("Enter a  date:");
        DateTime moment=DateTime.Parse(Console.ReadLine());  

        Console.WriteLine("year = " + moment.Year);

        Console.WriteLine("month = " + moment.Month);

        Console.WriteLine("day = " + moment.Day);

        Console.WriteLine("hour = " + moment.Hour);

        Console.WriteLine("minute = " + moment.Minute);

        Console.WriteLine("second = " + moment.Second);

        Console.WriteLine("millisecond = " + moment.Millisecond);

    }
}

