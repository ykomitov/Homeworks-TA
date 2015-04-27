namespace SoftwareAcademy
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Teacher : ITeacher
    {
        private string name;
        private List<ICourse> courseList;

        public Teacher(string name)
        {
            this.Name = name;
            this.courseList = new List<ICourse>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public void AddCourse(ICourse course)
        {
            this.courseList.Add(course);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("; Courses=[");

            int counter = this.courseList.Count;

            for (int i = 0; i < counter; i++)
            {
                sb.Append(this.courseList[i].Name);
                if (i < counter - 1)
                {
                    sb.Append(", ");
                }
            }
            sb.Append("]");
            string coursesStr = sb.ToString().TrimEnd();
            string teacherName = String.Format("Name={0}", this.Name);
            return String.Format("Teacher: {0}{1}", this.Name != null ? teacherName : ""
                                                  , this.courseList.Count > 0 ? coursesStr : "").TrimEnd();
        }
    }
}
