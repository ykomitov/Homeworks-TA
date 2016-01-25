namespace _02.Escaping
{
    using System;

    public partial class EscapingDangerousText : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            string inputTxt = this.TextInput.Text;

            this.OutputLabel.Text = inputTxt;
            this.OutputTextBot.Text = inputTxt;
        }
    }
}