//prgm to check whether a person is eligible to vote or not
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingEligibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine( "Enter your Age :");
            age=int.Parse(Console.ReadLine());
            int res = Voting(age);
            if(res==1)
            {
                Console.WriteLine( "Person is eligible to vote");
            }
            else
            {
                Console.WriteLine(  "Person is not eligible to vote");
            }
            Console.ReadKey();
        }
        static int  Voting(int a)
        {
            if(a>=18)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
