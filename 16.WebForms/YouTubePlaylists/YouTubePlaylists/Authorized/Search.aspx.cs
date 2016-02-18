namespace YouTubePlaylists.Authorized
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.ModelBinding;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using Models;

    public partial class Search : Page
    {
        public YoutubePlaylistsDbContext dbContext;

        public Search()
        {
            this.dbContext = new YoutubePlaylistsDbContext();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable<Playlist> RepeaterSearchResults_GetData([QueryString("q")] string query)
        {
            this.LiteralSearchQuery.Text = string.Format(@"""{0}""", query);

            return this.dbContext.Playlists
                .Where(p => p.Title.Contains(query) || p.Description.Contains(query))
                .ToList();
        }
    }
}