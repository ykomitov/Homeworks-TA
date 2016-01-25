namespace _01.Random
{
    using System;

    public partial class RandomWithWebServerControls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void GenerateRandom_Click(object sender, EventArgs e)
        {
            int min, max;

            try
            {
                min = int.Parse(this.MinInput.Text);
                max = int.Parse(this.MaxInput.Text);
            }
            catch (Exception)
            {
                min = 0;
                max = 100;
            }

            if (min > max)
            {
                int temp = min;
                min = max;
                max = temp;
            }

            Random rnd = new Random();
            int number = rnd.Next(min, max + 1);
            this.Output.Text = string.Format("Randomly generated number: {0}", number);
        }
    }
}