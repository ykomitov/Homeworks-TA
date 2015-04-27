namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MainProgram
    {
        static void Main()
        {
            var listOfStudents = new List<Student>{
                new Student("apostol", "bakalov", 5.99),
                new Student("Ilina", "Konsulova", 4),
                new Student("Vladislav", "Ivanov", 5),
                new Student("Penio", "Michev", 6),
                new Student("Valentina", "Zhelyazkova", 6),
                new Student("Stoyan", "Stoyanov", 3),
                new Student("Stoyan", "Ganchev", 4),
                new Student("Anton", "Antonov", 6),
                new Student("Aleksandra", "Todorova", 4),
                new Student("Stanislava", "Kostadinova", 6)};

            var listOfWorkers = new List<Worker> { 
                new Worker("Angel", "Stoyanov", 400.25M, 8),
                new Worker("Liliya", "Stoycheva", 600.95M, 7),
                new Worker("yavor", "komitov", 500.15M, 7),
                new Worker("Liliya", "Rasheva", 300.25M, 7),
                new Worker("Alexander", "Goranov", 200.25M, 4),
                new Worker("Alena", "Glushkova", 380, 8),
                new Worker("Alexandra", "Limanska", 250.25M, 6),
                new Worker("Vladislav", "Kolev", 800.25M, 8),
                new Worker("Aneliya", "Barenska", 555.55M, 8),
                new Worker("Vesela", "Georgieva", 344.44M, 6)};

            var listOfStudentsSorted = listOfStudents.OrderBy(x => x.Grade);
            var listOfWorkersSorted = listOfWorkers.OrderByDescending(x => x.MoneyPerHour());

            List < Human > humans = new List<Human>();
            humans.AddRange(listOfStudents);
            humans.AddRange(listOfWorkers);

            var humansSorted = humans.OrderBy(x => x.FirstName).ThenBy(y => y.LastName);

            Console.WriteLine("List of students sorted by grade:\r\n");
            foreach (var student in listOfStudentsSorted)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\r\n\r\nList of workers:\r\n");
            foreach (var worker in listOfWorkersSorted)
            {
                Console.WriteLine(worker);
            }

            Console.WriteLine("\r\n\r\nMerged List of workers & students:\r\n");
            foreach (var human in humansSorted)
            {
                Console.WriteLine("{0} {1}", human.FirstName, human.LastName);
            }
        }
    }
}
