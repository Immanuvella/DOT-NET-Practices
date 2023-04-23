using System;
using System.Collections;
namespace ArrayListClone
{
    public class Program
    {
        public static void Main()
        {
            ArrayList arrayList = new ArrayList()
            {
                    "India",
                    "USA",
                    "UK",
                    "Denmark",
                    "HongKong",
            };

            Console.WriteLine("Array List Elements:");
            foreach (var item in arrayList)
            {
                Console.WriteLine($"{item} ");
            }

            //Creating a clone of the arrayList using Clone method
            ArrayList cloneArrayList = (ArrayList)arrayList.Clone();
            Console.WriteLine("\nCloned ArrayList Elements:");
            foreach (var item in cloneArrayList)
            {
                Console.WriteLine($"{item} ");
            }

            Console.ReadKey();
        }
    }
}