using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample //Interfae Sample program
{

    interface IFigure
    {
        int Dimension { get; set; }
        double Area();
        double Perimeter();
    }
    class Circle : IFigure
    {
        private int _Radius;
        public int Dimension
        {
            get { return _Radius; }
            set { _Radius = value; }
        }
        public double Area()
        {
            return Math.PI * _Radius * _Radius;
        }
        public double Perimeter()
        {
            return 2 * Math.PI * _Radius;
        }
    }
    class Square : IFigure
    {
        private int _Radius;
        public int Dimension
        {
            get { return _Radius; }
            set { _Radius = value; }
        }
        public double Area()
        {
            return _Radius * _Radius;
        }
        public double Perimeter()
        {
            return 4 * _Radius;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            IFigure fig = null;
            //Square s = new Square(); ;
            //Circle cir = new Circle(); ;
           
            Console.WriteLine("Enter 'C' for circle and 'S 'for square");
            string ch = Console.ReadLine();
            if (ch == "S")
            {
                fig = new Square();
                fig.Dimension = 10;
                Console.WriteLine("Area of Square :" + fig.Area());
                Console.WriteLine("Perimeter of Square :" + fig.Area());
            }
            else if (ch == "C")
            {
                fig = new Circle();
                fig.Dimension = 5;
                Console.WriteLine("Area of Circle :" + fig.Area());
                Console.WriteLine("Perimeter of Circle :" + fig.Perimeter());
            }
            else
            {
                Console.WriteLine("Invalid entry");
            }
            Console.ReadKey();

        }


    }
}
