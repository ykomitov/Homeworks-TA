namespace _02.NorthwindEmployees
{
    using System;
    using System.Linq;

    public partial class EmpDetails : System.Web.UI.Page
    {
        public EmployeeDetailsModel DetailsViewEmployee_GetData()
        {
            int id = int.Parse(Request.QueryString["id"]);

            NorthwindEntities context = new NorthwindEntities();
            var result = context.Employees
                .Where(e => e.EmployeeID == id)
                .Select(e => new EmployeeDetailsModel
                {
                    Title = e.Title,
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    BirthDate = e.BirthDate,
                    HireDate = e.HireDate,
                    City = e.City,
                    Address = e.Address
                })
                .FirstOrDefault();

            return result;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }
    }
}