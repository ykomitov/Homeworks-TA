namespace MvcExam.Web.Controllers
{
    using System.Net;
    using System.Web.Mvc;

    [HandleError]
    public class ErrorController : BaseController
    {
        public ActionResult Index()
        {
            this.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            return this.View("Error");
        }
    }
}
