namespace Practice_Virtual_Overriding_andNew_JuanHernandez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            SavingsAccount newSavingsAcc = new SavingsAccount("Juan", 500.90, 22.98);
            Console.WriteLine(newSavingsAcc);
            CheckingAccount newCheckingAcc = new CheckingAccount("Carlos", 200.77, 33.00);
            Console.WriteLine(newCheckingAcc);
            newSavingsAcc.Deposit(500);
            Console.WriteLine(newSavingsAcc);
            newCheckingAcc.Deposit(500);
            Console.WriteLine(newCheckingAcc);
            newSavingsAcc.Withdraw(200);
            Console.WriteLine(newSavingsAcc);
            newCheckingAcc.Withdraw(200);
            Console.WriteLine(newCheckingAcc);
            newSavingsAcc.Withdraw(200000);
            Console.WriteLine(newSavingsAcc);
            newCheckingAcc.Withdraw(200000);
            Console.WriteLine(newCheckingAcc);
        }
    }
}// Done