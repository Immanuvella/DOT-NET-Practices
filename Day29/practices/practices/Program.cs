//{ Driver Code Starts
//Initial Template for C#

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
            int testcases;// Taking testcase as input
            testcases = Convert.ToInt32(Console.ReadLine());
            while (testcases-- > 0)// Looping through all testcases
            {
                string s = Console.ReadLine().Trim();
                Solution obj = new Solution();
                bool res = obj.ispar(s);
                if (res)
                {
                    Console.Write("balanced");
                }
                else
                {
                    Console.Write("not balanced");
                }
                Console.Write("\n");
            }

        }
    }
}


// } Driver Code Ends


//User function Template for C#




class Solution
{
    //Complete this function
    public bool ispar(string s)
    {
        //Your code here
        if ((s.Contains('(') && s.Contains(')'))||(s.Contains("[") && s.Contains("]")) ||(s.Contains("{") && s.Contains("}")))
        {
            return true;    
        }
        else
        {
            return false;   
        }
       


    }

}