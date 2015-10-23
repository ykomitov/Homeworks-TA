namespace EfCodeFirst.SampleDataGenerator
{
    using System;
    using System.Linq;

    public class CourseDataGenerator : DataGenerator
    {
        public CourseDataGenerator(IRandomDataGenerator randomGenerator, StudentSystemCFEntities database, int numberToGenerate)
            : base(randomGenerator, database, numberToGenerate)
        {
        }

        public override void Generate()
        {
            Console.WriteLine("Adding courses: ");
            for (int i = 0; i < this.Count; i++)
            {
                var course = new Cours
                {
                    Name = this.Random.GetRandomStringWithRandomLength(5, 30),
                    Description = this.Random.GetRandomStringWithRandomLength(5, 30),
                    Materials = this.Random.GetRandomString(20)
                };

                this.Db.Courses.Add(course);

                if (i % 100 == 0)
                {
                    Console.Write("=");
                    this.Db.SaveChanges();
                }
            }
            Console.WriteLine("\r\nCourses added!");
        }
    }
}
