using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double distance,time;
           
            Console.WriteLine("Enter Distance in km/h:");
            distance= Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Time :");
            time = Double.Parse(Console.ReadLine());
            double res=GetSpeedKm(distance,time);
            Console.WriteLine( "Speed in km/h is :"+res+"km/h");
            double res2 = GetSpeedMiles(distance, time);
            Console.WriteLine("Speed in Miles is "+res2+ "miles/hour");
            Console.ReadKey();


        }
        static double  GetSpeedKm(double d,double t)
        {
            double s = 0;
            s = d / t;
            return s;
        }
        static double GetSpeedMiles(double d,double t) {
            double s = 0;
            s = (d / t) * 0.62;
            return s;
        }
    }
}
