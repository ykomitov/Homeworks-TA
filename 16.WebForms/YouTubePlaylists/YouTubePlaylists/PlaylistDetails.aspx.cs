namespace YouTubePlaylists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.ModelBinding;
    using Models;

    public partial class PlaylistDetails : System.Web.UI.Page
    {
        public YoutubePlaylistsDbContext dbContext;

        public PlaylistDetails()
        {
            this.dbContext = new YoutubePlaylistsDbContext();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        // The id parameter should match the DataKeyNames value set on the control
        // or be decorated with a value provider attribute, e.g. [QueryString]int id
        public Playlist FormViewPlaylistDetails_GetItem([QueryString("id")]int? playlistId)
        {
            if (playlistId == null)
            {
                Response.Redirect("~/");
            }

            return this.dbContext.Playlists.FirstOrDefault(b => b.Id == playlistId);
        }

        public IEnumerable<Video> RepeaterVideos_GetData([QueryString("id")]int? playlistId)
        {
            if (playlistId == null)
            {
                Response.Redirect("~/");
            }

            return this.dbContext.Videos.Where(v => v.Playlists.Any(p => p.Id == playlistId));
        }
    }
}