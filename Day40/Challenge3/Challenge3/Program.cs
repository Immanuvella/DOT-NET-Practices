using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size");
            int n=int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            int leap = arr1[0] + arr1[arr1.Length - 1]/2;
            for(int i=0; i < n;i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            for(int i=0;i<n;i++)
            {
                if (arr1[i-1]==0)
                {
                    Console.WriteLine(arr1[i-1]);
                }
                if (arr1[i+1]==0) {
                    Console.WriteLine(arr1[i+1]);
                }
                if (arr1[leap] == 0) {
                    Console.WriteLine(arr1[leap]);
                }
                if ((arr1[n-1]==0) || (arr1[i+leap]>0)){
                    Console.WriteLine("you won");
                }
            }
        }
    }
}
