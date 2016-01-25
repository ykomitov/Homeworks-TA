using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01.HelloMyMan
{
    public partial class HelloMyMan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            string name = TextBoxName.Text;
            LabelForResult.Text = String.Format("Hello, {0}!", name);
        }
    }
}