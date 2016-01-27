namespace _04.NorthwindEmployeesPaging
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Web.Script.Services;
    using System.Web.Services;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using AjaxControlToolkit;

    public partial class Default : Page
    {
        [WebMethod, ScriptMethod]
        public static string GetDynamicContent(string contextKey)
        {
            NorthwindEntities context = new NorthwindEntities();
            int id = int.Parse(contextKey);

            var employeeDetails = context.Employees
                    .Where(e => e.EmployeeID == id)
                    .Select(e => new EmployeeDetailsRequestModel()
                    {
                        Address = e.Address,
                        Phone = e.HomePhone,
                        Notes = e.Notes,
                        Image = e.Photo
                    })
                    .FirstOrDefault();

            StringBuilder sb = new StringBuilder();

            sb.Append("<table style='background-color:#f3f3f3; border: #336699 3px solid; ");
            sb.Append("width:750px; font-size:10pt; font-family:Verdana;' cellspacing='0' cellpadding='3'>");

            sb.Append("<tr><td colspan='2' style='background-color:#336699; color:white;'>");
            sb.Append("<b>Employee Details</b>");
            sb.Append("</td></tr>");

            sb.Append("<tr><td><b>Address</b></td>");
            sb.Append("<td>" + employeeDetails.Address + "</td></tr>");

            sb.Append("<tr><td><b>Phone</b></td>");
            sb.Append("<td>" + employeeDetails.Phone + "</td></tr>");

            sb.Append("<tr><td><b>Notes</b></td>");
            sb.Append("<td>" + employeeDetails.Notes + "</td></tr>");

            sb.Append("</table>");

            return sb.ToString();
        }

        public IQueryable<EmployeeRequestModel> GridViewEmployees_GetData()
        {
            NorthwindEntities context = new NorthwindEntities();
            return context.Employees
                .OrderBy(e => e.EmployeeID)
                .Select(e => new EmployeeRequestModel
                {
                    Id = e.EmployeeID,
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    City = e.City,
                    Country = e.Country
                });
        }

        protected void EmployeeDetails_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                GridViewRow row = e.Row;
                var id = e.Row.Cells[0].Text;
                row.Attributes["id"] = id.ToString();
            }
        }

        protected void GridView_RowCreated(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                PopupControlExtender pce = e.Row.FindControl("PopupControlExtender1") as PopupControlExtender;

                string behaviorID = "pce_" + e.Row.RowIndex;
                pce.BehaviorID = behaviorID;

                Image img = (Image)e.Row.FindControl("ImageMagnifier");

                string onMouseOverScript = string.Format("$find('{0}').showPopup();", behaviorID);
                string onMouseOutScript = string.Format("$find('{0}').hidePopup();", behaviorID);

                img.Attributes.Add("onmouseover", onMouseOverScript);
                img.Attributes.Add("onmouseout", onMouseOutScript);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }
    }
}