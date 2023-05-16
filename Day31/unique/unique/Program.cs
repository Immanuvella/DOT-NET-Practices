using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("enter elements");
            for(int i=0;i<5;i++)
            {
                a[i]=int.Parse(Console.ReadLine());
            }
            //int count = 0;
            int j = 0;
            
            int[] c = new int[5];
            for(int i = 0; i < 5; i++)
            {
                if (a[j] != a[i+1])
                {
                    c[j] = a[i];
                   
                }
            }
            
            for(int i=0;i<5;i++)
            {

                Console.WriteLine(c[i]);
            }

        }
    }
}
