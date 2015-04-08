﻿namespace BankAccount
{
    using System;
    public abstract class Account
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }
        public Customer Customer
        {
            get { return this.customer; }
            set { this.customer = value; }
        }

        public decimal Balance
        {
            get { return this.balance; }
            set
            {
                if(value<0)
                {
                    throw new ArgumentException("The balance cannot be negative!");
                }
                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            set
            {
                if(value<0)
                {
                    throw new ArgumentException("The interest rate cannot be negative!");
                }
                this.interestRate = value;
            }
        }
        public abstract decimal CalculateInterest(int months);
    }
}
