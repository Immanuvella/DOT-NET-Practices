//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace InheritanceSample
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//        }
//    }
//}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample
{
    class Program
    {

        static void Main(string[] args)
        {
            Orange o1 = new Orange(1, "ORANGE", "MAHARASHTRA");
            o1.display();
            Console.ReadKey();



        }





    }
    public class Fruit
    {
        int number;
        string name;
        public int Number
        {
            get { return number; }
            set
            {
                if (number != 0) number = value;
                else
                    Console.WriteLine("Invalid");
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (name != null) name = value;
                else
                    Console.WriteLine("Invalid");
            }
        }

        public Fruit()
        {

        }
        public Fruit(int Number, string Name)
        {
            number = Number;
            name = Name;


        }
        public void display()
        {
            Console.WriteLine(number + "\n" + name);
        }

    }
    public class Orange : Fruit
    {

        string[] place = { "MAHARASHTRA", "TELUNGANA", "KARNATAKA" };
        string _origin;
        public string origin
        {
            get { return _origin; }
            set
            {
                if (place.Contains(value))
                { _origin = value; }
            }
        }
        public Orange(int num, string name, string abc) : base(num, name)
        {

            this._origin = abc;
        }
        public new void display()
        {
            Console.WriteLine(_origin);
            base.display();
        }
    }

}