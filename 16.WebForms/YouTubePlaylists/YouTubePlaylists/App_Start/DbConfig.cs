namespace YouTubePlaylists.App_Start
{
    using System.Data.Entity;
    using Migrations;
    using Models;

    public class DbConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<YoutubePlaylistsDbContext, Configuration>());
            YoutubePlaylistsDbContext.Create().Database.Initialize(true);
        }
    }
}