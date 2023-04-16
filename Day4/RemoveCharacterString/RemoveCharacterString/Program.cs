using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveCharacterString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a;
            Console.WriteLine("Enter a string :");
            a= Console.ReadLine();
            Console.WriteLine("Enter the position :");
            int pos=int.Parse(Console.ReadLine());
            Remove(a, pos);
            Console.ReadKey();
        }
        static void Remove(string a,int pos)
        {
            for(int i=0;i<a.Length;i++)
            {
                if (a[pos] == a[i])
                {
                    Console.WriteLine("The new string is :" + a.Remove(pos));
                }
            }
           

        }
    }
}
