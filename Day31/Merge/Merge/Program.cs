using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("size 1");
            int s1=int.Parse(Console.ReadLine());
            //Console.WriteLine("size2");
            //int s2=int.Parse(Console.ReadLine());   
             int[] a = new int[s1];
            //int[] b = new int[s2];
           
            //int s3 = s1 + s2;
            int i = 0;
            //int[] c = new int[s3];
            Console.WriteLine("Enter elements");
            for (i = 0; i < s1; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            //Console.WriteLine("Enter elements");
            //for ( i=0;i<s2 ;i++)
            //{
            //    b[i]=int.Parse(Console.ReadLine()); 
            //}
            //for (i = 0; i < s1; i++)
            //{
            //    c[i] = a[i];
            //}
            //for (int j= 0; j < s2; j++)
            //{
            //    c[i] = b[j];
            //    i++;
            //}
            //for ( i=0;i< s3 ;i++)
            //{
            //    for(int j=0;j<s3-1 ;j++)
            //    {
            //        if (c[j] >= c[j+1])
            //        {
            //            int temp = c[j+1];
            //            c[j+1]= c[j];
            //            c[j]= temp;
            //        }

            //    }
            //}

            //for(i=0;i<s3 ;i++)
            //{
            //    Console.WriteLine(c[i]);
            //}
            int count = 0;
            int[] res=new int[a.Length];
            for(i=0;i<s1;i++)
            {
                count = 1;
                for(int j=i+1;j<s1;j++)
                {
                    if (a[i] == a[j])
                    {
                        count++;
                        res[j] = 0;

                    }
                }
                if (res[i]!=0)
                {
                    res[i] = count;
                }
            }
            Console.WriteLine("Result:");
            for(i=0;i<s1;i++)
            {
                if (res[i]!=0)
                {
                    Console.WriteLine("{0} elements occures {1} times", a[i], res[i]);

                }
            }
        }
    }
}
