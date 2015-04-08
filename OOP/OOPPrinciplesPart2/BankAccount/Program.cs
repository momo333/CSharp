namespace BankAccount
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            DepositAccount deposit = new DepositAccount(Customer.Individual, 0, 1);
            deposit.Deposit(5000);
            Console.WriteLine("Balance: {0}", deposit.Balance);
            Console.WriteLine("Interest: {0}", deposit.CalculateInterest(10));

            Console.WriteLine("Withdraw");
            deposit.WithDraw(-1000);

           Console.WriteLine("Balance: {0}", deposit.Balance);
           Console.WriteLine("Interest: {0}", deposit.CalculateInterest(10));
        }
    }
}
