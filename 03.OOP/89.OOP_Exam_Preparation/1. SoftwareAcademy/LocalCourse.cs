using System;
namespace SoftwareAcademy
{
    public class LocalCourse : Course, ICourse, ILocalCourse
    {
        private string lab;

        public LocalCourse(string name, ITeacher teacher, string lab)
            : base(name, teacher)
        {
            this.Lab = lab;
        }

        public string Lab
        {
            get
            {
                return this.lab;
            }
            set
            {
                this.lab = value;
            }
        }

        public override string ToString()
        {
            string courceType = this.GetType().ToString().Substring(this.GetType().ToString().LastIndexOf('.') + 1);
            return String.Format("{0}: {1} Lab={2}", courceType, base.ToString(), this.Lab).TrimEnd();
        }
    }
}
