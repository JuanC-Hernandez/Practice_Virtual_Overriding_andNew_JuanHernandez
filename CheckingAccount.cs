using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Virtual_Overriding_andNew_JuanHernandez
{
    public class CheckingAccount : BankAccount
    {
        // Fields
        double _overdraftfee;
        
        // Properties
        public double Overdraftfee { get => _overdraftfee; set => _overdraftfee = value; }

        // Constructor
        public CheckingAccount(string name, double balance, double overdraftfee) : base(name, balance)
        {
            Overdraftfee = overdraftfee;
        }

        // Override Method
        public override bool Withdraw(double amount)
        {
            if (base.Withdraw(amount))
            {

            }
            else
            {
                base.Balance -= amount;
            }
            return base.Withdraw(amount);
        }

        // Override to string method
        public override string ToString()
        {
            return  base.ToString() + $"Over Draft Fee: {Overdraftfee}";
        }
    }
}
