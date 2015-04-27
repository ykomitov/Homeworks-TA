//Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

namespace Students
{
    using System;
    using System.Linq;

    class AgeRange
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

            var selectByAge = studentsArr
                .Where(x => (x.Age > 17) && (x.Age < 25)).ToArray();

            Console.WriteLine("All students with age between 18 and 24\r\n");
            Console.WriteLine(selectByAge.PrintStudentsArray());
            
        }
    }
}
