using System;
using System.Collections;
namespace ArrayListInsertRange
{
    public class Program
    {
        public static void Main()
        {
            ArrayList arrayList1 = new ArrayList()
            {
                    "India",
                    "USA",
                    "UK",
                    "Nepal"
            };
            Console.WriteLine("Array List Elements");
            foreach (var item in arrayList1)
            {
                Console.Write($"{item} ");
            }

            ArrayList arrayList2 = new ArrayList()
            {
                    "Srilanka",
                    "Japan",
                    "Britem",
                       "UK"
            };
            arrayList1.InsertRange(2, arrayList2);

            Console.WriteLine("\n\nArray List Elements After InsertRange");
            foreach (var item in arrayList1)
            {
                Console.Write($"{item} ");
            }
            //Remove
            arrayList1.Remove("UK"); //Removes first occurance of null
            Console.WriteLine("\n\nArray List Elements After Removing First Occurances of UK");
            foreach (var item in arrayList1)
            {
                Console.Write($"{item} ");
            }

            Console.ReadKey();
        }
    }
}