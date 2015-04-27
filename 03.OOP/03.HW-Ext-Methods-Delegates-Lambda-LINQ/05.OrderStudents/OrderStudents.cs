/*  Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
    Rewrite the same with LINQ.*/

namespace Students
{
    using System;
    using System.Linq;

    class OrderStudents
    {
        static void Main()
        {
            //create a new Student array & fill it with students
            var studentsArr = new Student[10];
            studentsArr[0] = new Student("Peter", "Petrov", 19);
            studentsArr[1] = new Student("Asen", "Ivanov", 18);
            studentsArr[2] = new Student("Vladislav", "Ivanov", 30);
            studentsArr[3] = new Student("Apostol", "Bakalov", 21);
            studentsArr[4] = new Student("Ilina", "Konsulova", 16);
            studentsArr[5] = new Student("Valentina", "Zheliazkova", 24);
            studentsArr[6] = new Student("Stoyan", "Ganchev", 25);
            studentsArr[7] = new Student("Stoyan", "Stoyanov", 26);
            studentsArr[8] = new Student("Dimitrina", "Gospodinova", 27);
            studentsArr[9] = new Student("Antonia", "Atanasova", 21);
            Console.WriteLine("Initial Array:\r\n");
            Console.WriteLine(studentsArr.PrintStudentsArray());

            //with lambda expressions
            var sortStudentsLambda = studentsArr
                                    .OrderBy(x => x.FirstName)
                                    .ThenBy(x => x.LastName)
                                    .Reverse()
                                    .ToArray();

            //with LINQ
            var sortStudentsLinq =  (from student in studentsArr
                                    orderby student.FirstName, student.LastName
                                    select student)
                                    .Reverse()
                                    .ToArray();

            Console.WriteLine("All students sorted by first name & last name in descending order\r\n");
            Console.WriteLine(sortStudentsLambda.PrintStudentsArray());
            Console.WriteLine(sortStudentsLinq.PrintStudentsArray());
        }
    }
}
