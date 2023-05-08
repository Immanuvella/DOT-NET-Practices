using System;
using System.Xml.Linq;

namespace AccountApp
{
    public class Account
    {
        public int _id;
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length > 15)
                {
                    throw new ApplicationException("Name is too big");
                    _name = value;
                }
                
            }
        }
        private decimal _balance;
        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
        public void CreateAccount(int id, string name, decimal balance)
        {
            _id = id;
            _name = name;
            _balance = balance;
        }
        public override string ToString()
        {
            return $"id:{_id} \t name:{_name} \t balance:{_balance}";
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Account Id :" + _id);
            Console.WriteLine("Name :" + _name);
            Console.WriteLine("Balance :" + _balance);
        }
        public void Deposit(decimal amount)
        {
            _balance += amount;
        }
        public void withdraw(decimal amount) 
        { 
            if(_balance<amount)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                _balance -= amount;
               
            }
        }
        

    }
}