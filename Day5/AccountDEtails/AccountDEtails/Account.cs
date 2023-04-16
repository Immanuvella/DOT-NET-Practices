using System;

namespace AccountDEtails
{
    public class Account
    {
        public int Id;
        public string name;
        public decimal balance=0;
        public void CreateAccount(int id, string name, decimal amt)
        {
            Id = id;
            this.name = name;
            this.balance = amt;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Account Id :" + Id);
            Console.WriteLine("Account Name :" + name);
            Console.WriteLine("Account Balance :" + balance);
        }

        public void Deposit(decimal amt)
        {
          
       
               balance += amt;
            Console.WriteLine();
            Console.WriteLine("Available Balance :"+balance);
            Console.WriteLine();



        }
    public void Withdraw(decimal amt)
    {
        if (balance > amt)
        {
            balance -= amt;
                Console.WriteLine("Available Balance :"+balance);
                Console.WriteLine();

            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
    }
}
    }