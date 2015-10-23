namespace EfCodeFirst.SampleDataGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentDataGenerator : DataGenerator
    {
        public StudentDataGenerator(IRandomDataGenerator randomGenerator, StudentSystemCFEntities database, int numberToGenerate)
            : base(randomGenerator, database, numberToGenerate)
        {
        }

        public override void Generate()
        {
            var studentsToBeAdded = new Dictionary<int, string>();

            while (studentsToBeAdded.Count != this.Count)
            {
                studentsToBeAdded.Add(this.Random.GetRandomNumber(1000, 9999), this.Random.GetRandomStringWithRandomLength(3, 30));
            }

            Console.WriteLine("Adding students: ");

            int counter = 0;

            foreach (var st in studentsToBeAdded)
            {
                var student = new Student
                    {
                        Name = st.Value,
                        Number = st.Key
                    };

                if (counter % 100 == 0)
                {
                    Console.Write("=");
                    this.Db.SaveChanges();
                }

                this.Db.Students.Add(student);
                counter++;
            }
            Console.WriteLine("\r\nStudents added!");
        }
    }
}
