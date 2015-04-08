namespace BankAccount
{
    using System;
    public class DepositAccount: Account, IDepositable,IWithDrawable
    {

        public DepositAccount(Customer customer, decimal balance, decimal interest)
            :base(customer, balance, interest)
        {

        }

        public override decimal CalculateInterest(int months)
        {
           if(this.Balance<=1000)
           {
               return 0;
           }
           else
           {
               return this.Balance * (this.InterestRate / 100) * months;
           }
        }
        public void Deposit(int deposit)
        {
            this.Balance += deposit;
        }
        public void WithDraw(int withDraw)
        {
            if(this.Balance+withDraw>=0)
            {
                this.Balance += withDraw;
            }
            else
            {
                throw new ApplicationException("Not enough credit in card!");
            }
        }
    }
}
