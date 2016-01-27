namespace _02.NorthwindEmployees
{
    using System;
    using System.Linq;
    using System.Web.UI;

    public partial class Employees : Page
    {
        public IQueryable<Employee> GridViewEmployees_GetData()
        {
            NorthwindEntities context = new NorthwindEntities();
            return context.Employees
                .Select(e => new Employee
                {
                    EmployeeId = e.EmployeeID,
                    FullName = e.FirstName + " " + e.LastName
                });
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }
    }
}