using System;
using System.Linq;
using BankAccounts.Interfaces;

namespace BankAccounts.Models
{
    class Loan : Account, IDepositable
    {
        public Loan(Customer customer, decimal initialAmount, decimal interestRate)
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
                throw new Exception(String.Format("You are trying to deposit more money ({0:0.00}) than the size of your loan ({1:0.00}).", amount, this.AccountBalance));
            }
            this.AccountBalance -= amount;
            Console.WriteLine("Loan account - {0}{1} {2}\r\n===================================", this.Customer.CompanyName, this.Customer.FirstName, this.Customer.LastName);
            Console.WriteLine("Old balance: {0,10:#.00}\r\nDeposited:   {1,10:#.00}\r\nNew balance: {2,10:#.00}\r\n", oldBallance, amount, this.AccountBalance);
        }

        public override decimal CalculateInterest(decimal numberOfMonths)
        {
            if (this.Customer.CompanyName != null)
            {
                if (numberOfMonths <= 2)
                {
                    return 0;
                }
                else
                {
                    return this.AccountBalance * (numberOfMonths - 2) * this.InterestRate;
                }
            }
            else
            {
                if (numberOfMonths <= 3)
                {
                    return 0;
                }
                else
                {
                    return this.AccountBalance * (numberOfMonths - 3) * this.InterestRate;
                }
            }
        }

        public override string ToString()
        {
            if (this.Customer.CompanyName == null)
            {
                return String.Format("Loan account of {0} {1}\r\nCurrent balance: {2:0.00}\r\n", this.Customer.FirstName, this.Customer.LastName, this.AccountBalance);
            }
            else
            {
                return String.Format("Loan account of {0} \r\nCurrent balance: {1:0.00}\r\n", this.Customer.CompanyName, this.AccountBalance);
            }
        }
    }
}
