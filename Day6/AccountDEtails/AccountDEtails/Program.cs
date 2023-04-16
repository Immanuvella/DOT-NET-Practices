using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDEtails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ch;
            
            Account a = null;
            do
            {
                Console.WriteLine();
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Display Account");
                Console.WriteLine("3. Deposit Money");
                Console.WriteLine("4. Withdraw Money");
                Console.WriteLine("5. View Balance");
                Console.WriteLine("0. Exit");
                Console.WriteLine();
                Console.WriteLine("Enter your Choice :");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter Account Id :");
                        int Id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Account Name :");
                        string name=Console.ReadLine();
                        Console.WriteLine("Enter Amount :");
                        decimal balance=decimal.Parse(Console.ReadLine());
                        a = new Account();
                        a.CreateAccount(Id, name, balance);
                        Console.WriteLine();
                        Console.WriteLine("Account created......");
                        break;

                     case 2:
                        if (a != null)
                        {
                            Console.WriteLine();
                            Console.WriteLine("---Account Details-----");
                            Console.WriteLine();
                            a.DisplayDetails();
                            Console.WriteLine();
                            Console.WriteLine("------------------------");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("You have to create an Account....");
                        }
                        break;
                    case 3:
                        if (a != null)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Enter amount to deposit :");
                            decimal amount = decimal.Parse(Console.ReadLine());

                            a.Deposit(amount);
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("You dont have enough balance");
                        }
                        Console.WriteLine();
                        Console.WriteLine("-----Money Added successfully-----");
                        Console.WriteLine();
                        break;
                        
                        
                    case 4:
                        if(a!=null)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Enter Amount to withdraw");
                            decimal amount1 = decimal.Parse(Console.ReadLine());

                            a.Withdraw(amount1);
                            Console.WriteLine();
                           
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("You have to create an Account first...");
                            Console.WriteLine();
                        }
                      
                        break;
                    case 5:
                        if(a!=null)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Available Balance is :"+a.Balance);
                        }
                        else
                        {
                            Console.WriteLine("You have to create an account");
                        }
                        break;

                    case 0: 
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;



                }
            }
            
           
            while (ch != 0) ;
        }
       
    }
    
}
