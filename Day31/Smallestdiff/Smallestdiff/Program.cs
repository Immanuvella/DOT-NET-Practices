using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Smallestdiff
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            int[] nums = { 10, 18, 39, 75, 100  };
           
            Array.Sort(nums);
            int prod;
            Console.WriteLine("Number :");
            int n=int.Parse(Console.ReadLine());    
            for (int i=1;i<nums.Length; i++)
            {
                prod = nums[i] *nums[i-1];
                if(prod==n)
                {
                    Console.WriteLine(+nums[i]+" "+ nums[i-1]);
                    break;
                }
            }
           




        }
       
       

    }
}
