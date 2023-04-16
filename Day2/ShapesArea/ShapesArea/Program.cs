using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r, l, b;
            Console.WriteLine("Enter your option:\n 1:Triangle \n 2:Circle");
            int ch = int.Parse(Console.ReadLine());
         
                if (ch == 1)
                {
                    Console.WriteLine("Enter Length");
                    l = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Breadth");
                    b = double.Parse(Console.ReadLine());
                    double area1 = TraingleArea(l, b);
                    Console.WriteLine("Area of Triangle is " + area1);

                }
                else if (ch == 2)
                {
                    Console.WriteLine("Enter Radius");
                    r = double.Parse(Console.ReadLine());

                    double area2 = CircleArea(r);
                    Console.WriteLine("Area of Triangle is " + area2);

                }

            

                Console.ReadKey();

            
        }
        static double CircleArea(double r)
        {
            double area = 3.14 * r * r;
            return area;
        }
        static double TraingleArea(double l,double b)
        {

            double area = l * b;
            return area;
        }
    }
}
