namespace EfCodeFirst.SampleDataGenerator
{
    using System;
    using System.Linq;

    public class HomeworkDataGenerator : DataGenerator
    {
        public HomeworkDataGenerator(IRandomDataGenerator randomGenerator, StudentSystemCFEntities database, int numberToGenerate)
            : base(randomGenerator, database, numberToGenerate)
        {
        }

        public override void Generate()
        {
            var studentIds = this.Db.Students.Select(s => s.StudentId).ToList();
            var coursesIds = this.Db.Courses.Select(c => c.CourseId).ToList();

            Console.WriteLine("Adding homeworks: ");
            int counter = 0;
            foreach (var stId in studentIds)
            {
                for (int i = 0; i < 3; i++)
                {
                    var homework = new Homework
                    {
                        Content = this.Random.GetRandomStringWithRandomLength(20, 40),
                        StudentId = stId,
                        TimeSent = new DateTime(2015, 01, 01, 04, 04, 04),
                        CourseId = coursesIds[i]
                    };

                    this.Db.Homework.Add(homework);
                    counter++;

                    if (counter % 100 == 0)
                    {
                        Console.Write("=");
                        this.Db.SaveChanges();
                    }
                }
            }
            Console.WriteLine("\r\nHomeworks added!");
        }
    }
}
