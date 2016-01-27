namespace _01.CarSearch
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    public partial class Default : Page
    {
        private const string SelectProducerText = "--Select producer--";

        private List<Producer> producers = new List<Producer>()
            {
                new Producer()
                {
                    Name = "BMW",
                    Models = new List<string>() { "114", "116", "118", "750", "850" }
                },
                new Producer()
                {
                    Name = "Nissan",
                    Models = new List<string>() { "Almera", "Primera", "Micra", "Leaf", "Sunny" }
                },
                new Producer()
                {
                    Name = "Tesla",
                    Models = new List<string>() { "Model S", "Roadster", "Roadster Sport" }
                }
            };

        private List<Extra> extras = new List<Extra>()
            {
                new Extra() { Name = "Navigation" },
                new Extra() { Name = "Alloy Wheels" },
                new Extra() { Name = "Metallic Paint" },
                new Extra() { Name = "Sunroof" }
            };

        private string[] typeOfEngine = new string[] { "Gasoline", "Diesel", "Electric", "Hybrid" };

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var producerNames = this.producers.Select(p => p.Name).ToList();
                this.DropDownListProducer.DataSource = producerNames;
                this.DropDownListProducer.DataBind();
                this.DropDownListProducer.Items.Insert(0, new ListItem(SelectProducerText));

                for (int i = 0; i < this.typeOfEngine.Length; i++)
                {
                    var typeOfEngineListItem = new ListItem(this.typeOfEngine[i]);
                    this.RadioButtonListEngines.Items.Add(typeOfEngineListItem);
                }
            }

            if (Page.IsPostBack)
            {
                var selectedProducer = this.DropDownListProducer.Text;

                if (selectedProducer == SelectProducerText)
                {
                    this.DropDownListModel.Items.Clear();
                }

                var models = this.producers
                    .Where(p => p.Name == selectedProducer)
                    .Select(p => p.Models)
                    .FirstOrDefault();

                this.DropDownListModel.DataSource = models;
                this.DropDownListModel.DataBind();
            }

            var listOfExtras = new CheckBoxList();
            listOfExtras.ID = "CheckBoxExtras";
            listOfExtras.DataSource = this.extras.Select(ex => ex.Name).ToList();
            listOfExtras.DataBind();
            listOfExtras.RepeatDirection = RepeatDirection.Horizontal;
            this.CarSearchForm.Controls.Add(listOfExtras);

            var submitButton = new Button();
            submitButton.ID = "ButtonSubmit";
            submitButton.Text = "Submit";
            submitButton.Click += this.SubmitButton_Click;
            this.CarSearchForm.Controls.Add(submitButton);

            var literalResult = new Literal();
            literalResult.ID = "LiteralResult";
            this.ResultContainer.Controls.Add(literalResult);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var result =
                        "Car producer: " + this.DropDownListProducer.Text +
                        "; Model: " + this.DropDownListModel.Text +
                        "; Engine: " + this.RadioButtonListEngines.Text +
                        "; Extras: ";

            var extras = (CheckBoxList)this.CarSearchForm.FindControl("CheckBoxExtras");
            var selectedExtras = extras.Items.OfType<ListItem>().Where(item => item.Selected).ToArray();

            for (int i = 0; i < selectedExtras.Length; i++)
            {
                if (i == 0)
                {
                    result += " " + selectedExtras[i];
                }
                else
                {
                    result += ", " + selectedExtras[i];
                }
            }

            var resultLiteral = (Literal)this.CarSearchForm.FindControl("LiteralResult");
            resultLiteral.Text = result;
        }
    }
}