namespace BankAccounts.Interfaces
{
    using System;
    using System.Linq;

    interface IWithdrawable
    {
        void WithdrawAmount(decimal ammount);
    }
}
