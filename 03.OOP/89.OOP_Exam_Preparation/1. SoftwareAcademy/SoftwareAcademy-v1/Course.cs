namespace SoftwareAcademy
{
    using System;
    using System.Collections.Generic;

    public abstract class Course : ICourse
    {
        private string name;
        private List<string> topics;
        private ITeacher teacher;

        public Course(string name, ITeacher teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.topics = new List<string>();
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

        public ITeacher Teacher
        {
            get
            {
                return this.teacher;
            }
            set
            {
                this.teacher = value;
            }
        }

        public void AddTopic(string topic)
        {
            this.topics.Add(topic);
        }

        public override string ToString()
        {
            string courseTopics = String.Format("; Topics=[{0}];", String.Join(", ", this.topics));

            string teacherString = "";
            if (this.teacher != null)
            {
                teacherString = String.Format(" Teacher={0}", this.Teacher.Name);
            }

            return string.Format("Name={0};{1}{2}", this.Name
                                                 , this.Teacher != null ? teacherString : ""
                                                 , this.topics.Count > 0 ? courseTopics : "").TrimEnd();
        }
    }
}
