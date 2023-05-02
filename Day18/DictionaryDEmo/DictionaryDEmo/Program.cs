using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDEmo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList s = new SortedList();
            s.Add("Mumbai", "Mumbai");
            s.Add("Maharashtra", "Bangalore");
            s.Add("Tamilnadu", "Chennai");
            foreach (var item in s.Keys)
            {
                Console.WriteLine(item);
            }
            foreach (var item in s.Values)
            {
                Console.WriteLine(item);
            }
            s.Remove("Tamilnadu");
           
            Console.WriteLine("After deletion");
            foreach (var item in s.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Key at 2nd position  :"+s.GetByIndex(1));


        }
    }
}
