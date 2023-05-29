using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    class Inner
    {

        private class Private
        {

            public  bool Power(int num)
            {

                if (num == 0)
                    return false;

                while (num != 1)
                {
                    if (num % 2 != 0)
                        return false;

                    num = num / 2;
                }
                return true;
            }

        }
        class Solution
        {
            static void Main(string[] args)
            {
                Inner.Private inner = new Inner.Private();
                int num;
                Console.WriteLine("Enter a number");
                num = int.Parse(Console.ReadLine());
                if(inner.Power(num))
                {
                    Console.WriteLine(num+" is power of 2");
                }
                else
                {
                    Console.WriteLine(num+" is not a power of 2");
                }


            }
        }
    }
}
