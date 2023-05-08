using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp
{
     class Program
    {
        static void Main(string[] args)
        {
            int ch;
            Account a1 = new Account();
            Console.WriteLine(a1);
            Account a = null;
            do
            {
                Console.WriteLine("1.Create account");
                Console.WriteLine("2.Display Info");
                Console.WriteLine("3.Deposit money");
                Console.WriteLine("4.withdraw money");
                Console.WriteLine("5.Available balance");
                Console.WriteLine("0.Exit");
                Console.WriteLine("Enter your choice:");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter Account Id:");
                        int Id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the Name:");
                        string Name = Console.ReadLine();
                        Console.WriteLine("Enter opening balance:");
                        decimal Balance = decimal.Parse(Console.ReadLine());
                        a= new Account();
                        a.CreateAccount(Id, Name, Balance);
                        break;
                    case 2:
                        if (a != null)
                        {
                            a.DisplayInfo();
                        }
                        else
                        {
                            Console.WriteLine("open account first");
                        }
                        break;
                    case 3:
                        if (a != null)
                        {
                            Console.WriteLine("enter amount to be deposit");
                            decimal amount=decimal.Parse(Console.ReadLine());
                            a.Deposit(amount);
                        }
                        else
                        {
                            Console.WriteLine("open account first");
                        }
                        break;
                    case 4:
                        if (a != null)
                        {
                            Console.WriteLine("enter amount to be withdraw");
                            decimal amount2=decimal.Parse(Console.ReadLine());
                            a.withdraw(amount2 );
                        }
                        else
                        {
                            Console.WriteLine("open account first ");
                        }
                        break;
                    case 5:
                        if (a != null)
                        {
                            Console.WriteLine("Available balance " +a.Balance);
                            
                        }
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("wrong choice");
                        break;
                }

            }
            while (ch != 0);
           
            Console.WriteLine("Thanks for using banking operations");
           Console.ReadKey();

        }
    }
}
