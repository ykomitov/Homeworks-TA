namespace BankAccounts.Models
{
    using System;
    using System.Linq;

    public abstract class Account
    {
        Customer customer;
        decimal accountBalance;
        decimal interestRate;

        public Account(Customer customer, decimal initialAmount, decimal interestRate)
        {
            this.Customer = customer;
            this.AccountBalance = initialAmount;
            this.InterestRate = interestRate;
        }

        public Customer Customer
        {
            get
            {
                return this.customer;
            }
            set
            {
                this.customer = value;
            }
        }

        public decimal AccountBalance
        {
            get
            {
                return this.accountBalance;
            }
            set
            {
                this.accountBalance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            set
            {
                this.interestRate = value;
            }
        }

        public abstract decimal CalculateInterest(decimal numberOfMonths);
    }
}
