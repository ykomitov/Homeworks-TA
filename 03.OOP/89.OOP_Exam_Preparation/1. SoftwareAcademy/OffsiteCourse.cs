using System;
namespace SoftwareAcademy
{
    public class OffsiteCourse : Course, ICourse, IOffsiteCourse
    {
        private string town;

        public OffsiteCourse(string name, ITeacher teacher, string town)
            : base(name, teacher)
        {
            this.Town = town;
        }

        public string Town
        {
            get
            {
                return this.town;
            }
            set
            {
                this.town = value;
            }
        }

        public override string ToString()
        {
            string courceType = this.GetType().ToString().Substring(this.GetType().ToString().LastIndexOf('.') + 1);
            return String.Format("{0}: {1} Town={2}", courceType, base.ToString(), this.Town).TrimEnd();
        }
    }
}
