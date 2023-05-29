
using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace Challenge1

{

    class Program

    {

        static void Main(string[] args)

        {

            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int positive = 0;

            int negative = 0;

            int zero = 0;

            foreach (int number in arr)

            {

                if (number > 0)

                    positive++;

                else if (number < 0)

                    negative++;

                else

                    zero++;

            }

            double positive_ratio = (double)positive / n;

            double negative_ratio = (double)negative / n;

            double zeroRatio = (double)zero / n;

            Console.WriteLine(positive_ratio.ToString("F6"));

            Console.WriteLine(negative_ratio.ToString("F6"));

            Console.WriteLine(zeroRatio.ToString("F6"));

        }

    }

}









