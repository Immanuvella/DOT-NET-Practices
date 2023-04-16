using System;

namespace MultipleInheritance
{
    class myClass1 : myAbstractClass
    {

        // Overriding print1() method of myAbstractClass
        public override void print1()
        {
            Console.WriteLine("print1() called");
        }
    }
}