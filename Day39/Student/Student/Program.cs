using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Program
    {
        static void Main(string[] args)
        {
           
              
            float tf;
            float bf;
            float hf;
            double tot;
            Console.WriteLine("Enter the student type");
            string Type = Console.ReadLine();
            Console.WriteLine("Enter tuition fee");
            tf = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter bus fee");
            bf = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter Hostel fee");
            hf = Convert.ToSingle(Console.ReadLine());

            if (Type== "MSDS")
            {
               
                tot = tf + bf;
                Console.WriteLine("The fees to be paid by the student is Rs."+ string.Format("{0:0.00}", tot));

            }
            else if (Type == "MSH")
                {
                    
                    tot = tf + hf;
                    Console.WriteLine("The fees to be paid by the student is Rs." + string.Format("{0:0.00}", tot));

                }
            else if (Type == "MGSDS")
            {
                tot = (1.5 * tf) + bf;
                
                Console.WriteLine("The fees to be paid by the student is Rs." + string.Format("{0:0.00}", tot));

            }
            else if (Type == "MGSH")
            {
                tot = (1.5 * tf) + hf;

                Console.WriteLine("The fees to be paid by the student is Rs." + string.Format("{0:0.00}", tot));

            }







        }
    }
}
