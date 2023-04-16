using System;

namespace MethodOverriding
{
    public class clssA
    {

        int n1, n2;

        // default constructor
        public clssA()
        {
            Console.WriteLine("Default Constructor Invoked");
        }

        // parameterized constructor
        public clssA(int i, int j)
        {

            // construct values
            n1 = i;
            n2 = j;
            Console.WriteLine("Parameterized Constructor Invoked");
            Console.WriteLine("Invoked Values are: " + n1 + " and " + n2);
        }
    }
}