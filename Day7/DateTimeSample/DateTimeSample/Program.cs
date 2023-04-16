using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime datetime = new DateTime(2023, 5, 6, 4, 30, 0);
            Console.WriteLine("Complete date :" + datetime.ToString());
            //Display only date without time
            DateTime date = datetime.Date;
            Console.WriteLine("Date " + datetime.ToString("d"));
            //Display date with 24hr format
            Console.WriteLine(datetime.ToString("g"));

            //display date in dd/mm/yyyy format
            Console.WriteLine(datetime.ToString("dd/MM/yyyy hh:ss"));

            Console.ReadKey();
        }
    }
}
