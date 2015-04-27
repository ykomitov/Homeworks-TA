namespace BankAccounts.Models
{
    using System;
    using System.Linq;
    using BankAccounts.Interfaces;

    class Mortgage : Account, IDepositable
    {
        public Mortgage(Customer customer, decimal initialAmount, decimal interestRate)
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
            if (this.AccountBalance - amount < 0)
            {
                throw new Exception(String.Format("You are trying to deposit more money ({0:0.00}) than the size of your mortgage ({1:0.00}).", amount, this.AccountBalance));
            }
            this.AccountBalance -= amount;
            Console.WriteLine("Mortgage account - {0}{1} {2}\r\n===================================", this.Customer.CompanyName, this.Customer.FirstName, this.Customer.LastName);
            Console.WriteLine("Old balance: {0,10:#.00}\r\nDeposited:   {1,10:#.00}\r\nNew balance: {2,10:#.00}\r\n", oldBallance, amount, this.AccountBalance);
        }

        public override decimal CalculateInterest(decimal numberOfMonths)
        {
            if (this.Customer.CompanyName != null)
            {
                if (numberOfMonths <= 12)
                {
                    return this.AccountBalance * numberOfMonths * (this.InterestRate / 2);
                }
                else
                {
                    return (this.AccountBalance * 12 * (this.InterestRate / 2)) + (this.AccountBalance * (numberOfMonths - 12) * this.InterestRate);
                }
            }
            else
            {
                if (numberOfMonths <= 6)
                {
                    return 0;
                }
                else
                {
                    return this.AccountBalance * (numberOfMonths - 6) * this.InterestRate;
                }
            }
        }

        public override string ToString()
        {
            if (this.Customer.CompanyName == null)
            {
                return String.Format("Mortgage account of {0} {1}\r\nCurrent balance: {2:0.00}\r\n", this.Customer.FirstName, this.Customer.LastName, this.AccountBalance);
            }
            else
            {
                return String.Format("Mortgage account of {0} \r\nCurrent balance: {1:0.00}\r\n", this.Customer.CompanyName, this.AccountBalance);
            }
        }
    }
}
