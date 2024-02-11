using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Virtual_Overriding_andNew_JuanHernandez
{
    public class RetirementAccount : SavingsAccount
    {
        // Constructor
        public RetirementAccount(string name, double balance, double interest) : base(name, balance, interest)
        {

        }
        // Method
        public virtual bool Withdraw()
        {
            Console.WriteLine("Cannot withdraw from a retirement account");
            return false;
        }
    }
}
