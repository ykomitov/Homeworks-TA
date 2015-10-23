namespace EfCodeFirst.SeedDatabaseConsoleApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using EfCodeFirst.SampleDataGenerator;

    public class SeedDatabase
    {
        public static void Main()
        {
            // Database must be present in order for the seeding to work. If you haven't done it, go and start the EfCodeFirst.Client Startup.cs
            var random = RandomDataGenerator.Instance;
            var database = new StudentSystemCFEntities();

            var listOfGenerators = new List<IDataGenerator>
                {
                    new StudentDataGenerator(random,database, 100),
                    new CourseDataGenerator(random, database, 10),
                    new HomeworkDataGenerator(random, database, 300)
                };

            foreach (var generator in listOfGenerators)
            {
                generator.Generate();
                database.SaveChanges();
            }
        }
    }
}
