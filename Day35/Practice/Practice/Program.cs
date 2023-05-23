using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string str=Console.ReadLine();
            //char[] ch=str.ToCharArray();
            
            int low = 0;
            int high = str.Length;
            int mid = low + high / 2;
            if(high%2!=0)
            {
                Console.WriteLine(Char.str[mid]);
            }
            else
            {
                Console.WriteLine(str[mid]+ " " + str[mid+1]);
            }


            // Console.WriteLine(count+1);


            //string[] str2 = new string[l];



            //Console.WriteLine("The second string is :{0}",string.Join("",str2));

        }
    }
}
