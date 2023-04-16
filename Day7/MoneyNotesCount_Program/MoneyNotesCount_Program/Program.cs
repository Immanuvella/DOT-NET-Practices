using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyNotesCount_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Amount");
            int amount=int.Parse(Console.ReadLine());
            CountNotes(amount);
            Console.ReadKey();
        }
        static void CountNotes(int amount)
        {
            int[] notes = new int[] { 2000, 500, 200, 100, 50, 20, 10, 5 };
            int[] counter = new int[8];
            for(int i=0;i<8;i++)
            {
                if (amount >= notes[i])
                {
                    counter[i] = amount / notes[i];
                    amount = amount % notes[i];
                }
            }
            //print notes
            Console.WriteLine("Notes :");
            for(int i=0;i<8;i++)
            {
                if (counter[i]!=0)
                {
                    Console.WriteLine("Note Type ="+notes[i]+ "  Number of notes =" + counter[i]);
                }
            }
        }
    }
}
