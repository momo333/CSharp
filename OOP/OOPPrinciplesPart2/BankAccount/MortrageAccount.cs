namespace BankAccount
{
 using System; 
    public class MortrageAccount:Account,IDepositable
    {
        public MortrageAccount(Customer customer, decimal balance, decimal interest)
            :base(customer,balance,interest)
        {

        }
        public override decimal CalculateInterest(int months)
        {
            if(this.Customer==Customer.Company && months<=12)
            {
                return this.Balance * (this.InterestRate / 100 / 2) * months;
            }
            else if (this.Customer ==Customer.Individual && months<=6)
            {
                return 0;
            }
            else if(this.Customer==Customer.Company)
            {
                return (this.Balance*(this.InterestRate/100/2)*12)+(months*(this.InterestRate/100)*months-12);
            }
            else
            {
                return this.Balance * (this.InterestRate / 100) * (months - 6);
            }
        }
        public void Deposit(int deposit)
        {
            this.Balance += deposit;
        }
    }
}
