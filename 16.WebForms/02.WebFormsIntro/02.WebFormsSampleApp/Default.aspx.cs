namespace _02.WebFormsSampleApp
{
    using System;
    using System.Reflection;
    using System.Web.UI;

    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string greeting = "Hello, ASP.NET from C# code...";

            this.LabelForCSharp.Text = greeting;
            this.LabelForAssembly.Text = Assembly.GetExecutingAssembly().Location.ToString();
        }
    }
}