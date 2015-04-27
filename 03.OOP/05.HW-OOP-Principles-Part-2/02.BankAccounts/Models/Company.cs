namespace BankAccounts.Models
{
    using System;
    using System.Linq;

    class Company : Customer
    {
        public Company(string companyName)
            : base(companyName)
        { }

        public void RenameCompany(string newCompanyName)
        {
            this.CompanyName = newCompanyName;
        }
    }
}
