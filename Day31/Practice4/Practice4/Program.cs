using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.WriteLine("Enter string");
            s=Console.ReadLine();
            int start = 0;
            int maxlen = 0;
            int[] arr=new int[128];
            for(int end=0;end<s.Length;end++)
            {
                start = Math.Max(start, arr[s[end]]);
                maxlen = Math.Max(maxlen, end - start + 1);
                arr[s[end]] = end + 1;
            }
            Console.WriteLine(maxlen);
        }
    }
}
