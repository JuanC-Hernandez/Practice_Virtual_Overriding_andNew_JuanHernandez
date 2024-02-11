using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Virtual_Overriding_andNew_JuanHernandez
{
    public class BankAccount
    {
        // Fields
        string _name;
        int _accountNumber;
        double _balance;

        // Properties
        public string Name { get => _name; set => _name = value; }
        public int AccountNumber { get => _accountNumber; set => _accountNumber = value; }
        public double Balance { get => _balance; set => _balance = value; }

        // Constructor
        public BankAccount(string name, double balance) 
        { 
            Name = name;
            Balance = balance;
            // grenerate random account number
            Random rnd = new Random();
            AccountNumber = rnd.Next(0,9999);
        }

        // Methods
        public virtual bool Deposit(double amount)
        {
            bool completed = false;
            if (amount > 0) 
            { 
                Balance += amount; 
                completed = true;
            }
            else 
            { 
                completed = false; 
            }
            return completed;
        }

        public virtual bool Withdraw(double amount) 
        {
            bool completed = false;
            if (amount > 0 || Balance > amount) 
            { 
                Balance -= amount;
                completed = true;
            }
            else
            {
                completed=false;
            }
            return completed;
        }

        // Override to string
        public override string ToString()
        {
            return $"{this.GetType()} - {Name} - {AccountNumber} - {Balance}";
        }
    }
}
