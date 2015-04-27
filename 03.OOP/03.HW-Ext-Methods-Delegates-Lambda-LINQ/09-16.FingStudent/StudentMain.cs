//File contains problems 9-16, 18 and 19

namespace FindStudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StudentMain
    {
        static void Main()
        {
            var studentsList = new List<Student>();
            studentsList.Add
            (new Student("Apostol", "Bakalov", 19901000, "0888123123", "abakalov@abv.bg",
                new List<uint> { 2, 2, 4, 5 }, 1));
            studentsList.Add
            (new Student("Ilina", "Konsulova", 10000601, "0888321123", "ikonsulova@gmail.com",
                new List<uint> { 6, 6, 6, 6, 6, 6 }, 1));
            studentsList.Add
            (new Student("Valentina", "Zheliazkova", 10000702, "0878123123", "vzheliazkova@yahoo.com",
                new List<uint> { 5, 6, 6, 6, 6, 6 }, 2));
            studentsList.Add
            (new Student("Petar", "Dimitrov", 10001103, "024871616", "p.dimitrov@yahoo.com",
                new List<uint> { 5, 6 }, 2));

            Console.WriteLine("\tAll students:\r\n");
            for (int i = 0; i < studentsList.Count; i++)
            {
                Console.WriteLine("{0}: {1} {2} (group {3})", i + 1, studentsList[i].FirstName, studentsList[i].LastName, studentsList[i].GroupNum);
            }

            //Problem 9. Student groups
            //Select only the students that are from group number 2. Use LINQ query. Order the students by FirstName.
            Console.WriteLine("\r\n\r\n\t>>> Problem  9 <<< - Students in Group 2 (LINQ query):\r\n");

            var studentsFromG2 = (from student in studentsList
                                  where (student.GroupNum == 2)
                                  orderby student.FirstName
                                  select student)
                                  .ToList();

            if (studentsFromG2.Count == 0)
            {
                Console.WriteLine("No students in the list...");
            }

            foreach (var student in studentsFromG2)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }

            //Problem 10. Student groups extensions
            //Select the students from group 2. Order the students by FirstName. USE EXTENSION METHODS
            Console.WriteLine("\r\n\r\n\t>>> Problem 10 <<< - Students in Group 2 (Extension method):\r\n");

            var studentsFromG2Ext = studentsList.SelectStudentsByGroup(2);

            foreach (var student in studentsFromG2Ext)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }

            //Problem 11. Extract students by email
            //Extract all students that have email in abv.bg. Use string methods and LINQ.
            Console.WriteLine("\r\n\r\n\t>>> Problem 11 <<< - Students with email @abv.bg:\r\n");

            var studentsInAbvBg = (from student in studentsList
                                   where student.Email.Contains("@abv.bg")
                                   select student)
                                   .ToList();

            if (studentsInAbvBg.Count == 0)
            {
                Console.WriteLine("No students in the list...");
            }

            foreach (var student in studentsInAbvBg)
            {
                Console.WriteLine("{0} {1}, email: {2}", student.FirstName, student.LastName, student.Email);
            }

            //Problem 12. Extract students by phone
            //Extract all students with phones in Sofia. Use LINQ.
            Console.WriteLine("\r\n\r\n\t>>> Problem 12 <<< - Students with phones in Sofia:\r\n");

            var studentsInSofia = (from student in studentsList
                                   where student.TelNumber.StartsWith("02")
                                   select student)
                                   .ToList();

            if (studentsInSofia.Count == 0)
            {
                Console.WriteLine("No students in the list...");
            }

            foreach (var student in studentsInSofia)
            {
                Console.WriteLine("{0} {1}, phone: {2}", student.FirstName, student.LastName, student.TelNumber);
            }

            //Problem 13. Extract students by marks
            //Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks. Use LINQ.
            Console.WriteLine("\r\n\r\n\t>>> Problem 13 <<< - Students with at least one excellent mark:\r\n");

            var studentsWith6 = from student in studentsList
                                where (student.Marks.Contains(6))
                                select new
                                {
                                    studentName = String.Format("{0} {1}", student.FirstName, student.LastName),
                                    marks = student.Marks
                                };

            if (studentsWith6.Count() == 0)
            {
                Console.WriteLine("No students in the list...");
            }

            foreach (var student in studentsWith6)
            {
                var stMarks = String.Join(", ", student.marks);
                Console.WriteLine("{0}, marks: {1}", student.studentName, stMarks);
            }

            //Problem 14. Extract students with two marks
            //Write down a similar program that extracts the students with exactly two marks "2". Use extension methods.

            Console.WriteLine("\r\n\r\n\t>>> Problem 14 <<< - Students with with exactly two marks \"2\":\r\n");
            var poorStudents = studentsList.SelectPoorStudents();

            foreach (var student in poorStudents)
            {
                var stMarks = String.Join(", ", student.Marks);
                Console.WriteLine("{0} {1}, marks: {2}", student.FirstName, student.LastName, stMarks);
            }
            //Problem 15. Extract marks
            //Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
            Console.WriteLine("\r\n\r\n\t>>> Problem 15 <<< - Students with \"06\" as 5-th & 6-th digit in the FN):\r\n");

            var enrolledIn2006 = studentsList
                                    .Where(x => x.FakNomer.ToString().Substring(4, 2) == "06")
                                    .ToList();

            if (enrolledIn2006.Count == 0)
            {
                Console.WriteLine("No students in the list...");
            }

            foreach (var student in enrolledIn2006)
            {
                Console.WriteLine("{0} {1}, FN: {2}", student.FirstName, student.LastName, student.FakNomer);
            }

            //Problem 18. Grouped by GroupNumber
            //Create a program that extracts all students grouped by GroupNumber and then prints them to the console. Use LINQ.
            Console.WriteLine("\r\n\r\n\t>>> Problem 18 <<< - Students grouped by GroupNumber:\r\n");

            var groupedByGroupNum = from student in studentsList
                                    group student by student.GroupNum into newGroup
                                    select newGroup;

            if (groupedByGroupNum.Count() == 0)
            {
                Console.WriteLine("No students in the list...");
            }

            foreach (var group in groupedByGroupNum)
            {
                Console.WriteLine("Group {0}", group.Key);
                foreach (var student in group)
                {
                    Console.WriteLine("\t{0}, {1}", student.FirstName, student.LastName);
                }
            }

            //Problem 19. Grouped by GroupName extensions - Rewrite the previous using extension methods.
            Console.WriteLine("\r\n\r\n\t>>> Problem 19 <<< - Students grouped by GroupNumber (extension method):\r\n");
            var groupedByGroupNumExt = studentsList.GroupStudentsByGroup();

            if (groupedByGroupNumExt.Count() == 0)
            {
                Console.WriteLine("No students in the list...");
            }

            foreach (var group in groupedByGroupNumExt)
            {
                Console.WriteLine("Group {0}", group.Key);
                foreach (var student in group)
                {
                    Console.WriteLine("\t{0}, {1}", student.FirstName, student.LastName);
                }
            }
        }
    }
}
