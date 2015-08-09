namespace _01.Students_and_courses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Course
    {
        private string courseName;
        private List<Student> enlistedStudents;

        public Course(string courseName)
        {
            this.CourseName = courseName;
            this.enlistedStudents = new List<Student>();
        }

        public string CourseName
        {
            get { return this.courseName; }
            set { this.courseName = value; }
        }

        public int GetNumberOfStudentsInCourse()
        {
            return this.enlistedStudents.Count;
        }

        public void StudentJoin(Student student)
        {
            if (this.enlistedStudents.Count == 30)
            {
                throw new Exception("This course is full. A course cannot contain more than 30 students!");
            }

            this.enlistedStudents.Add(student);
        }

        public void StudentLeave(Student student)
        {
            this.enlistedStudents.Remove(student);
        }
    }
}
