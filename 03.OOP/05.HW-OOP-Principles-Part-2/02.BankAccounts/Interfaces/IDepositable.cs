namespace BankAccounts.Interfaces
{
    using System;
    using System.Linq;

    interface IDepositable
    {
        void DepositAmount(decimal ammount);
    }
}
