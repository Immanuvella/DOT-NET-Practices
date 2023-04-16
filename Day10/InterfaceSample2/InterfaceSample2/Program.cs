using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creating an instance of Bicycle
         
            Bicycle bicycle = new Bicycle();
            bicycle.changeGear(2);
            bicycle.speedUp(3);
            bicycle.applyBrakes(1);

            Console.WriteLine("Bicycle present state :");
            bicycle.printStates();

            // creating instance of bike.
            Bike bike = new Bike();
            bike.changeGear(1);
            bike.speedUp(4);
            bike.applyBrakes(3);

            Console.WriteLine("Bike present state :");
            bike.printStates();
            Console.ReadKey();
        }
    }
}
