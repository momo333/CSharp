namespace BankAccount
{
    using System;

    public class LoanAccount:Account, IDepositable
    {
        public LoanAccount(Customer customer, decimal balance, decimal interest)
            :base(customer, balance, interest)
        {

        }
        public override decimal CalculateInterest(int months)
        {
            if(months<=2 && this.Customer==Customer.Company)
            {
                return 0;
            }
            else if(months<=3 && this.Customer==Customer.Individual)
            {
                return 0;
            }
            else if (this.Customer==Customer.Company)
            {
                return this.Balance * (this.InterestRate / 100) * (months - 2);
            }
            else
            {
                return this.Balance * (this.InterestRate / 100) * (months - 3);
            }
        }

        public void Deposit(int deposit)
        {
            this.Balance += deposit;
        }
    }
}
