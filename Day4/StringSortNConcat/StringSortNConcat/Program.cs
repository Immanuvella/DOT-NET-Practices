using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSortNConcat
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter number of strings");
            int n = int.Parse(Console.ReadLine());
            string[] array = new string[n];
            Console.WriteLine("Input  strings below");
            for (int i = 0; i < n; i++)
            {
                array[i] = Console.ReadLine();
            }
            
            SortNConcat(array);
            Console.ReadKey();

        }
        static void SortNConcat(string[] array) 
        {
            int i;
            for (i = 0; i <= array.Length - 2; i++)
            {
                for (int j = 0; j <= array.Length - 2; j++)
                {

                    if (array[i].CompareTo(array[i + 1]) > 0)
                    {
                        string temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                }
            }
            Console.WriteLine("After sorting :");
            for (i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("After Concatenation :"+string.Concat(array));
            

        }
    }
}
