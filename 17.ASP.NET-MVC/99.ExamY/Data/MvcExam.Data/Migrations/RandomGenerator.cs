namespace MvcExam.Data.Migrations
{
    using System;

    public static class RandomGenerator
    {
        private static Random random = new Random();

        public static string GetRandomIp()
        {
            return string.Format("{0}.{1}.{2}.{3}", random.Next(1, 255), random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
        }

        public static int GetRandomVotePoints()
        {
            return random.Next(1, 4);
        }
    }
}
