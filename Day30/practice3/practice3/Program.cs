//{ Driver Code Starts
//Initial Template for C#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverCode
{

    class GFG
    {
        static void Main(string[] args)
        {
            Console.WriteLine("size");
            int n = Convert.ToInt32(Console.ReadLine());// Input for size of array
                int[] arr = new int[n];
               
                for (int i = 0; i < n; i++)
                {
                arr[i] = int.Parse(Console.ReadLine());
                }
                Solution obj = new Solution();
                long res = obj.trappingWater(arr, n);
                Console.WriteLine(res);
            

        }
    }


    // } Driver Code Ends
    //User function Template for C#

    class Solution
    {
        public long trappingWater(int[] arr, int n)
        {
            //code here
            int low = arr[0];
            int sum = 0;
            int res1 = 0;
            int high = arr[arr.Length - 1];
            if (low < high)
            {
                for (int i = 0; i < arr.Length - 2; i++)
                {

                    res1 = low - arr[i + 1];

                    sum += res1;



                }
            }
            return sum;
        }
    }

}

//{ Driver Code Starts.
// } Driver Code Ends