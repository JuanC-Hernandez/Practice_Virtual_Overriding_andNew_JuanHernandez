using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Virtual_Overriding_andNew_JuanHernandez
{
    public class SavingsAccount : BankAccount
    {
        // Fields
        double _interest;

        // Properties
        public double Interest { get => _interest; set => _interest = value; }

        // Constructor
        public SavingsAccount(string name, double balance, double interest) : base(name, balance)
        { 
            Interest = interest;
        }
        // Method
        public override bool Deposit(double amount)
        {
            if (base.Deposit(amount))
            {
                base.Balance += Interest;
            }
            return base.Deposit(amount);
        }

        // Override to string method
        public override string ToString()
        {
            return base.ToString() + $" - Interest: ${Interest}";
        }
    }
}
