using System;

namespace AccountDEtails
{
    public class Account
    {
        private int id;
        private string _name;
        private decimal _balance=0;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return _name; }
            set {
               
                if (value.Length >15)
                {
                    throw new ApplicationException("Name is too big");
                    _name = value;
                }
                
            }
        }
        public decimal Balance
        {
            get { return _balance; }
            set { _balance= value; }    
        }

        public void CreateAccount(int id, string name, decimal amt)
        {
            Id = id;
            this._name = name;
            this._balance = amt;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Account Id :" + Id);
            Console.WriteLine("Account Name :" + _name);
            Console.WriteLine("Account Balance :" + _balance);
        }

        public void Deposit(decimal amt)
        {
          
       
               _balance += amt;
            Console.WriteLine();
           
            Console.WriteLine();



        }
    public void Withdraw(decimal amt)
    {
        if (_balance > amt)
        {
            _balance -= amt;
                Console.WriteLine("Amount withdrawn successfully....");
                Console.WriteLine();

            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
    }
       
}
    }