using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size;

            Console.WriteLine("Enter size of Array :");
            size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("Enter array elements :");
            for (int i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            SelectionSort(array, size);
            Console.ReadKey();

        }
        static void SelectionSort(int[] array, int size)
        {
            int i, j;
            for (i = 0; i < size-1; i++)
            {
                int small = i;
                for (j = i+1; j < size; j++)
                {
                    if (array[j] < array[small])
                    {
                        small = j;
                        

                    }

                }
                int temp = array[small];
                array[small] = array[i];
                array[i] = temp;
            }
            Console.WriteLine("Ater sorting :");
            for (i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

        }
    }
}
