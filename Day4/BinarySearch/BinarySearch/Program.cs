using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter size of Array :");
            int n=int.Parse(Console.ReadLine());
            int[] array= new int[n];    
            Console.WriteLine("Enter array elements :");
            for(int i=0;i<n; i++)
            {
                array[i]=int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Enter element to be search :");
            int a=int.Parse(Console.ReadLine());
            int res = BinarySearch(array, a);
            for(int i=0;i<n;i++)
            {
                if (res == array[i])
                    Console.WriteLine("Element {0} is present at the position {1}",a,i);
            }
            Console.ReadKey();

        }
        static int BinarySearch(int[] array,int a)
        {
            int mid = 0;
            int low = array[0];
            int high = array.Length - 1;
            mid = low + high / 2;
            if(a==mid)
            {
                return mid; 
            }
            else if(a>mid)
            {
                low = mid + 1;
                return low;
            }
            else
            {
                high = mid - 1;
                return high;
            }

        }

    }
}
