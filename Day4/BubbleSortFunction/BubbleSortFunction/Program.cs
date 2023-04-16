//Bubble Sort Program
//Bubble Sort using function
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            int i, j;
            Console.WriteLine("Enter array elements");
            for (i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }          
            Bubble(array);           
            Console.ReadKey();
        }
        static void Bubble(int[] array) 
        {
            int temp = 0;
            int i=0, j;

            for (j = 0; j <= array.Length-2 ; j++)
            {
                for (i = 0; i <= array.Length - 2; i++)
                {

                    if (array[i] > array[i + 1])
                    {
                        temp = array[i + 1];
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

        }

    }
}

