namespace BankAccounts
{
    using System;
    using System.Linq;
    using BankAccounts.Models;

    class BankAccountsMain
    {
        static void Main()
        {
            var sampleBank = new Bank();

            //create customers
            var customer1 = new Individual("Pesho", "Goshov");
            var customer2 = new Company("MicroMek");

            //create accounts
            var deposit1 = new Deposit(customer1, 5.567M, 0.02M);
            var loan1 = new Loan(customer1, 500, 0.008333M);
            var mortgage1 = new Mortgage(customer1, 5000, 0.008333M);
            var deposit2 = new Deposit(customer2, 2000, 0.002M);
            var loan2 = new Loan(customer2, 500, 0.008333M);
            var mortgage2 = new Mortgage(customer2, 5000, 0.008333M);

            //add account to the bank system
            sampleBank.BankAccounts.Add(deposit1);
            sampleBank.BankAccounts.Add(deposit2);
            sampleBank.BankAccounts.Add(loan1);
            sampleBank.BankAccounts.Add(mortgage1);

            //print details for each bank account
            foreach (var account in sampleBank.BankAccounts)
            {
                Console.WriteLine(account);
            }

            //test the Deposit, Withdraw, and CalculateInterest methods
            deposit1.DepositAmount(100.5M);
            deposit2.WithdrawAmount(200);


            Console.WriteLine("Deposit interest for 24 months: {0}", deposit1.CalculateInterest(24));
            Console.WriteLine("Expected: 0 - account balance < 1000");

            Console.WriteLine("\r\nDeposit interest for 24 months: {0}", deposit2.CalculateInterest(24));
            Console.WriteLine("Expected: {0}", deposit2.AccountBalance * 24 * deposit2.InterestRate);

            Console.WriteLine("\r\nLoan interest (individual) for 24 months: {0}", loan1.CalculateInterest(24));
            Console.WriteLine("Expected: {0}", loan1.AccountBalance * 21 * loan1.InterestRate);

            Console.WriteLine("\r\nLoan interest (company) for 24 months: {0}", loan2.CalculateInterest(24));
            Console.WriteLine("Expected: {0}", loan2.AccountBalance * 22 * loan2.InterestRate);

            Console.WriteLine("\r\nMortgage interest (individual) for 36 months: {0}", mortgage1.CalculateInterest(36));
            Console.WriteLine("Expected: {0}", mortgage1.AccountBalance * 30 * mortgage1.InterestRate);

            Console.WriteLine("\r\nMortgage interest (company) for 36 months: {0}", mortgage2.CalculateInterest(36));
            Console.WriteLine("Expected: {0}", (mortgage2.AccountBalance * 12 * (mortgage2.InterestRate / 2)) + (mortgage2.AccountBalance * 24 * mortgage2.InterestRate));
        }
    }
}
