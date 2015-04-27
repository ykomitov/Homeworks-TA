/* Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
    Use LINQ query operators.*/

namespace Students
{
    using System;
    using System.Linq;
    using System.Text;

    public class Student
    {
        private string firstName;
        private string lastName;
        int age;

        public Student(string fName, string lName, int age)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.age = age;
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }
    }

    public static class Extensions
    {
        public static string PrintStudentsArray(this Student[] stArray)
        {
            int counter = 1;
            StringBuilder sb = new StringBuilder();
            foreach (var student in stArray)
            {
                sb.Append(String.Format("{0}: ", counter));
                sb.Append(student.FirstName);
                sb.Append(" ");
                sb.Append(student.LastName);
                sb.Append(String.Format(", age {0}\r\n", student.Age));

                counter++;
            }
            return sb.ToString();
        }
    }

    class FirstBeforeLast
    {
        static void Main()
        {
            //create a new Student array & fill it with students
            var studentsArr = new Student[10];
            studentsArr[0] = new Student("Peter", "Petrov", 19);
            studentsArr[1] = new Student("Asen", "Ivanov", 20);
            studentsArr[2] = new Student("Vladislav", "Ivanov", 30);
            studentsArr[3] = new Student("Apostol", "Bakalov", 21);
            studentsArr[4] = new Student("Ilina", "Konsulova", 16);
            studentsArr[5] = new Student("Valentina", "Zheliazkova", 21);
            studentsArr[6] = new Student("Stoyan", "Ganchev", 25);
            studentsArr[7] = new Student("Stoyan", "Stoyanov", 26);
            studentsArr[8] = new Student("Dimitrina", "Gospodinova", 27);
            studentsArr[9] = new Student("Antonia", "Atanasova", 21);
            Console.WriteLine("Initial Array:\r\n");
            Console.WriteLine(studentsArr.PrintStudentsArray());

            //select all students whose first name is before their last name
            var studentsFirstBeforeLast = studentsArr
                .Where(x => x.FirstName.CompareTo(x.LastName) < 0).ToArray();

            Console.WriteLine("All students whose first name is before their last name\r\n");
            Console.WriteLine(studentsFirstBeforeLast.PrintStudentsArray());
        }
    }
}
