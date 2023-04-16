//Write a program in C# Sharp to count a total number of alphabets, digits and special characters in a string


using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace StringCountAlphabets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a;
            Console.WriteLine("Enter a string ");
            a = Console.ReadLine();
            int i = 0;

            int count1 = 0, count2 = 0, count3 = 0;

            int l = a.Length;
            while (i < l)
            {
                if ((a[i] >= 'a' && a[i] <= 'z') || (a[i] >= 'A' && a[i] <= 'Z'))
                {
                    count1++;

                }
                else if ((a[i]) >= '0' && a[i] <= '9')
                {
                    count2++;
                }
                else
                {
                    count3++;
                }
                i++;

            }


            Console.WriteLine("Number of Alphabets :" + count1);
            Console.WriteLine("Number of digits :" + count2);
            Console.WriteLine("Number of Special charaters :" + count3);
            Console.ReadKey();
        }

    
        }
    }

