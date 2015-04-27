using System;
using System.Linq;

namespace BankAccounts.Models
{
    class Individual : Customer
    {
        public Individual(string firstName, string lastName)
            : base(firstName, lastName)
        {
        }

        public void RenameIndividual(string newFirstName, string newLastName)
        {
            this.LastName = newLastName;
            this.FirstName = newFirstName;
        }
    }
}
