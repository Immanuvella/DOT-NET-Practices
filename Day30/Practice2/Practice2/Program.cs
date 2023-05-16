using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    public class Program<T>
    {

        private T _value;
        public T Value
        {
            get;set;
        }
        static void Main(string[] args)
        {
            Program<string> list = new Program<string>();
            list.Value = "Hello";
            Program<int> list2 = new Program<int>();
            list2.Value = 5;
            Console.WriteLine(list.Value);
            Console.WriteLine(list2.Value);
        }
    }
}
