namespace NewsSystem.Data.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;

    public sealed class Configuration : DbMigrationsConfiguration<NewsSystemDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(NewsSystemDbContext context)
        {
            if (context.Articles.Any())
            {
                return;
            }

            var user = new User()
            {
                UserName = "anonymous"
            };

            var seed = new SeedData(user);

            context.Users.Add(user);
            context.SaveChanges();

            seed.Categories.ForEach(c => context.Categories.Add(c));
            seed.Articles.ForEach(a => context.Articles.Add(a));

        }
    }
}
