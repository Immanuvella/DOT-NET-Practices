using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass2
{
    class GenericClass2<T>
    {
        public T Message;
        public void GenericMethod( T name,T Location)
        {
            Console.WriteLine($"Name : {name}" );
            Console.WriteLine($" Message : {Message}");
            Console.WriteLine($"Location :{Location}");
        }
        public void GenericMethod2<T1,T2>(T1 value1,T2 value2)
        {
            Console.WriteLine($"Type of parameter1 :{typeof(T1)} Type of parameter2 :{typeof(T2)}");
        }
    }
}
