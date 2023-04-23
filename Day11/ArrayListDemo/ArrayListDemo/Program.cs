using System;
using System.Collections;
namespace ArrayListDemo
{
    public class ArrayListDemo
    {
        public static void Main()
        {
            //Adding elements to ArrayList using Add() method
            ArrayList arrayList1 = new ArrayList();
            arrayList1.Add(101); //Adding Integer Value
            arrayList1.Add("Immanuvella"); //Adding String Value
            arrayList1.Add("Paul"); //Adding Duplicate Value
            arrayList1.Add(" "); //Adding Empty
            arrayList1.Add(true); //Adding Boolean
            arrayList1.Add(4.5); //Adding double
            arrayList1.Add(null); //Adding null

            foreach (var item in arrayList1)
            {
                Console.WriteLine(item);
            }

            //Adding Elements to ArrayList using object initializer syntax
            var arrayList2 = new ArrayList()
            {
                102, "Immauvella", "Paul", true, 15.6
            };

            foreach (var item in arrayList2)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}