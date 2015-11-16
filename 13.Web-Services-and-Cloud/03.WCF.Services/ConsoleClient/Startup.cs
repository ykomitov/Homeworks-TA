namespace ConsoleClient
{
    using System;
    using ServiceReference;

    public class Startup
    {
        // The GetDayOfWeek service must be started from project 01.DayOfWeek in order for the following code NOT to throw exception
        public static void Main()
        {
            var client = new GetDayOfWeekClient();

            using (client)
            {
                Console.WriteLine(
                    "Изпит по Web услуги и Cloud: денят на истината се пада в {0}!",
                    client.GetDayOfWeekUsingService(new DateTime(2015, 11, 23)));
            }
        }
    }
}
