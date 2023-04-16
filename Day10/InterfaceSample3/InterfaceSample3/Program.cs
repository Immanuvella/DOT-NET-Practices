// C# program to illustrate how to inherit an
// abstract class and interface in the same class
using System;

// Abstract class
abstract class Abstract_Class
{

   
    public abstract void abstract_method();
}

// Interface
interface Interface
{

   
    void interface_method();
}


class Demo : Abstract_Class, Interface
{

    // Method definition for abstract method
    public override void abstract_method()
    {
        Console.WriteLine("I am the method of abstract class");
    }

   
    public void interface_method()
    {
        Console.WriteLine("I am the method of interface");
    }
}

class Program
{

    
    public static void Main(String[] args)
    {

        // Creating objects
        Abstract_Class ac = new Demo();
        Interface inf = new Demo();

       
        ac.abstract_method();
        inf.interface_method();
        Console.ReadKey();
    }
}
