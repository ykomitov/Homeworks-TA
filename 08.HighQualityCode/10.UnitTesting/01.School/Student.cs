namespace _01.Students_and_courses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student
    {
        private string studentName;
        private int studentID;

        public Student(string studentName)
        {
            this.StudentName = studentName;
            this.studentID = School.GetUniqueStudentID();
        }

        public string StudentName
        {
            get
            {
                return this.studentName;
            }

            set
            {
                if (value == string.Empty || value == null)
                {
                    throw new ArgumentNullException("Student name cannot be null or empty!");
                }

                this.studentName = value;
            }
        }

        public int StudentID
        {
            get
            {
                return this.studentID;
            }
        }
    }
}
