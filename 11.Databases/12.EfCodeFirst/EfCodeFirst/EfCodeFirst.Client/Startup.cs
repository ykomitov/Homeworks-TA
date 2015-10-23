namespace EfCodeFirst.Client
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using EfCodeFirst.Data;
    using EfCodeFirst.Data.Migrations;
    using EfCodeFirst.Models;

    public class Startup
    {
        public static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemDbContext, Configuration>());

            // Database will be created if not present!
            using (var db = new StudentSystemDbContext())
            {
                var student = new Student
                {
                  Name = "Abdal",
                  Number = 1000
                };

                //db.Students.Add(student);             

                db.SaveChanges();

                Console.WriteLine(db.Students.Count());
            }

            Console.WriteLine("Database successfully created!");
        }
    }
}
