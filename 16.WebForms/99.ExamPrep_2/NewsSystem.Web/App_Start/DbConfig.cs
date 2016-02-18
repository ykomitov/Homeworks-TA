namespace NewsSystem.Web.App_Start
{
    using System.Data.Entity;
    using Data;
    using Data.Migrations;

    public class DbConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<NewsSystemDbContext, Configuration>());
            NewsSystemDbContext.Create().Database.Initialize(true);
        }
    }
}