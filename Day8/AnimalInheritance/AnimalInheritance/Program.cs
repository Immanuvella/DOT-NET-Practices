using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheritance
{
    internal class Program
    {
        static void Main(string[] args) {
            Dog d = new Dog();
            d.Eat();
            d.Bark();
            //Multi level Inheritance
            Horse h=new Horse();
            h.Eat();
            h.Run();
            h.Gallop();
            //Hierarchical Inheritance
            Eagle e = new Eagle();
            Penguin penguin = new Penguin();
            e.Fly();
            e.Hunt();
            penguin.Fly();
            penguin.Swim();
            Console.ReadKey();
        }
    }
}
