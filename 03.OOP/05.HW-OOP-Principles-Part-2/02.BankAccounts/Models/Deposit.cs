namespace BankAccounts.Models
{
    using System;
    using System.Linq;
    using BankAccounts.Interfaces;

    class Deposit : Account, IDepositable, IWithdrawable
    {
        public Deposit(Customer customer, decimal initialAmount, decimal interestRate)
            : base(customer, initialAmount, interestRate)
        {
        }

        public void DepositAmount(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("Amount should be > 0!");
            }

            decimal oldBallance = this.AccountBalance;
            this.AccountBalance += amount;
            Console.WriteLine("Deposit account - {0}{1} {2}\r\n===================================", this.Customer.CompanyName, this.Customer.FirstName, this.Customer.LastName);
            Console.WriteLine("Old balance: {0,10:#.00}\r\nDeposited:   {1,10:#.00}\r\nNew balance: {2,10:#.00}\r\n", oldBallance, amount, this.AccountBalance);
        }

        public void WithdrawAmount(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("Amount should be > 0!");
            }

            decimal oldBallance = this.AccountBalance;
            if (this.AccountBalance - amount < 0)
            {
                throw new Exception("The requested amount is bigger that the money in the deposit account. Operation not permitted!");
            }
            this.AccountBalance -= amount;
            Console.WriteLine("Deposit account - {0}{1} {2}\r\n===================================", this.Customer.CompanyName, this.Customer.FirstName, this.Customer.LastName);
            Console.WriteLine("Old balance: {0,10:#.00}\r\nWithdrawn:   {1,10:#.00}\r\nNew balance: {2,10:#.00}\r\n", oldBallance, amount, this.AccountBalance);
        }

        public override decimal CalculateInterest(decimal numberOfMonths)
        {
            if (this.AccountBalance > 0 && this.AccountBalance < 1000)
            {
                return 0;
            }
            else
            {
                return this.AccountBalance * numberOfMonths * this.InterestRate;
            }
        }

        public override string ToString()
        {
            if (this.Customer.CompanyName == null)
            {
                return String.Format("Deposit account of {0} {1}\r\nCurrent balance: {2:0.00}\r\n", this.Customer.FirstName, this.Customer.LastName, this.AccountBalance);
            }
            else
            {
                return String.Format("Deposit account of {0} \r\nCurrent balance: {1:0.00}\r\n", this.Customer.CompanyName, this.AccountBalance);
            }
        }
    }
}
