using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Locker l = null;
            int option=0;
            do
            {
                Console.WriteLine("1.Add Locker");
                Console.WriteLine("2.Delete Locker");
                Console.WriteLine("3.Display Lockers");
                Console.WriteLine("4.Exit");
                switch(option)
                {
                    case 1:
                        string detail;
                        detail = Console.ReadLine();
                        Locker locker = Locker.CreateLocker(detail);                      
                        Console.WriteLine("Locker successfully added");
                        break;
                    case 2:
                        Console.WriteLine("Enter the Locker number to be deleted:");
                        int num=int.Parse(Console.ReadLine());
                        if(num)
                        {
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Locker number not found in bank");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Lockers in SBI");
                        Console.WriteLine("Number \t Lock Type \t Password Amount \t LastOpened ");
                        Console.WriteLine();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
            while (option != 0);
        }
    }
}
