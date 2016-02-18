namespace YouTubePlaylists
{
    using System;
    using System.Linq;
    using System.Web.UI;
    using YouTubePlaylists.Models;

    public partial class Home : Page
    {
        public YoutubePlaylistsDbContext dbContext;

        public Home()
        {
            this.dbContext = new YoutubePlaylistsDbContext();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<Playlist> ListViewTopPlaylists_GetData()
        {
            return this.dbContext.Playlists
                .OrderByDescending(p => p.Ratings.Average(r => r.Value))
                .Take(10);
        }
    }
}