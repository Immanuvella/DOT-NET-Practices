using System;

public class Example2
{
    public static void Main()
    {
        //program to extract month,date etc seperately from a given date
        Console.WriteLine("Enter a  date:");
        DateTime moment = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("year = " + moment.Year);

        Console.WriteLine("month = " + moment.Month);

        Console.WriteLine("day = " + moment.Day);

        Console.WriteLine("hour = " + moment.Hour);

        Console.WriteLine("minute = " + moment.Minute);

        Console.WriteLine("second = " + moment.Second);

        Console.WriteLine("millisecond = " + moment.Millisecond);
        Console.ReadKey();

    }
}

