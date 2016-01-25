namespace _03.StudentsAndCourses
{
    using System;
    using System.Web.UI.HtmlControls;
    using System.Web.UI.WebControls;

    public partial class RegisterStudents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            var outputDiv = new HtmlGenericControl("div");

            var h1 = new HtmlGenericControl("h1");
            h1.InnerHtml = "Summary Information:";
            outputDiv.Controls.Add(h1);

            var studentNameParagraph = new HtmlGenericControl("p");
            studentNameParagraph.InnerText = "Name: " + this.TextBotFirstName.Text + " " + this.TextBotLastName.Text;
            outputDiv.Controls.Add(studentNameParagraph);

            var facultyInfoParagraph = new HtmlGenericControl("p");
            facultyInfoParagraph.InnerText = "Faculty Number: " + this.TextBotFacutyNumber.Text;
            outputDiv.Controls.Add(facultyInfoParagraph);

            var universityInfoParagraph = new HtmlGenericControl("p");
            universityInfoParagraph.InnerText = "University: " + this.DropDownUniversity.SelectedItem.Text;
            outputDiv.Controls.Add(universityInfoParagraph);

            var specialtyInfoParagraph = new HtmlGenericControl("p");
            specialtyInfoParagraph.InnerText = "Specialty: " + this.DropDownSpecialty.SelectedItem.Text;
            outputDiv.Controls.Add(specialtyInfoParagraph);

            var coursesInfoParagraph = new HtmlGenericControl("p");
            specialtyInfoParagraph.InnerText = "Participating in courses: ";
            outputDiv.Controls.Add(coursesInfoParagraph);

            var infoCourses = this.ListBoxCourses.Items;
            var coursesUl = new HtmlGenericControl("ul");

            foreach (ListItem li in infoCourses)
            {
                if (li.Selected == true)
                {
                    var courseLi = new HtmlGenericControl("li");
                    courseLi.InnerText = li.Text;
                    coursesUl.Controls.Add(courseLi);
                }
            }

            outputDiv.Controls.Add(coursesUl);
            this.OutputContainer.Controls.Add(outputDiv);
        }
    }
}