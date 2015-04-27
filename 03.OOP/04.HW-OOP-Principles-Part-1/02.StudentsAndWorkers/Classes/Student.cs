namespace StudentsAndWorkers
{
    using System;
    using System.Linq;
    using System.Text;

    class Student : Human
    {
        double grade;

        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public double Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                if (value < 2 || value > 6)
                {
                    throw new Exception("Grade can only be between 2 and 6!");
                }
                this.grade = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(this.FirstName);
            sb.Append(" ");
            sb.Append(this.LastName);
            sb.Append(String.Format(", grade {0:0.00}", this.Grade));
            return sb.ToString();
        }
    }
}
