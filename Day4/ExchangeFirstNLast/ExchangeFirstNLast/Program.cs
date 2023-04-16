using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeFirstNLast
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            
            
            Console.WriteLine("Enter a string:");
            //for(int i=0;i<10;i++)
            //{
            //    a[i] = Console.ReadLine();
            //}
            string a=Console.ReadLine();    
            Exchange(a);
            //Console.WriteLine("After Exchanging :");
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(s);

            //}
            Console.ReadKey();
        }
        static void Exchange(string str)
        {
            //int i;
            //string temp;
            int size = str.Length;
            string f= str.Substring(0, 1);
           
            string l=str.Substring(str.Length-1);
            string temp = l;
            l = f;
            f = temp;
            string res=str.Substring(1, size-2);


            Console.WriteLine(temp+res+l );

        }
    }
}
