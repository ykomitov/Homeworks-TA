using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _05.WebFormsSumator
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                var a = decimal.Parse(this.FirstNumberText.Text);
                var b = decimal.Parse(this.SecondNumberText.Text);
                var sum = a + b;
                this.Result.Text = sum.ToString();
            }
            catch(FormatException ex)
            {
                this.Result.Text = "Check input format!";
            }
        }
    }
}