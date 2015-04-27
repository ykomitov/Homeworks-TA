namespace BankAccounts.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Bank
    {
        private List<Account> bankAccounts = new List<Account>();

        public Bank()
        {
        }

        public List<Account> BankAccounts
        {
            get
            {
                return this.bankAccounts;
            }
            set
            {
                this.bankAccounts = value;
            }
        }
    }
}
