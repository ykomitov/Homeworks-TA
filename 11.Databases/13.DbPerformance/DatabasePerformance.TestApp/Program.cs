namespace DatabasePerformance.TestApp
{
    using System;
    using System.Linq;
    using DatabasePerformance.Data;
    using DatabasePerformance.Data.Importer;

    class Program
    {
        static void Main()
        {
            var db = new DatabasePerformanceEntities();

            var random = new RandomDataGenerator();

            Console.WriteLine("Seeding data. Be patient!");
            for (int i = 0; i < 10000000; i++)
            {
                var log = new Log
                {
                    text = random.GetRandomStringWithRandomLength(10, 50),
                    date = new DateTime(
                        random.GetRandomNumber(2010, 2015),
                        random.GetRandomNumber(1, 12),
                        random.GetRandomNumber(1, 28),
                        random.GetRandomNumber(1, 12),
                        random.GetRandomNumber(1, 59),
                        random.GetRandomNumber(1, 59)
                        )
                };

                db.Logs.Add(log);

                if (i % 100 == 0)
                {
                    Console.Write("=");
                    db.SaveChanges();
                    db.Dispose();
                    db = new DatabasePerformanceEntities();
                }
            }

            db.SaveChanges();

            Console.WriteLine("Man, you are patient... Congratulations!");
        }
    }
}
