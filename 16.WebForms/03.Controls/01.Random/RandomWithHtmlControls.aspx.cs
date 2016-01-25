namespace _01.Random
{
    using System;

    public partial class RandomWithHtmlControls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void ButtonGenerate_Click(object sender, EventArgs e)
        {
            int min = int.Parse(this.InputMin.Value);
            int max = int.Parse(this.InputMax.Value);

            if (min > max)
            {
                int temp = min;
                min = max;
                max = temp;
            }

            Random rnd = new Random();
            int number = rnd.Next(min, max + 1);
            this.RandomNumber.InnerText = string.Format("Randomly generated number: {0}", number);
        }
    }
}