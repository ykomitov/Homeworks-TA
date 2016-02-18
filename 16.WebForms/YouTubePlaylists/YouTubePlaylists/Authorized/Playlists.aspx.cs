namespace YouTubePlaylists.Authorized
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using YouTubePlaylists.Models;

    public partial class Playlists : System.Web.UI.Page
    {
        public YoutubePlaylistsDbContext dbContext;

        public Playlists()
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
        public IQueryable<PlaylistDetailsRequestModel> GridViewPlaylists_GetData()
        {
            return this.dbContext.Playlists
                .Select(p => new PlaylistDetailsRequestModel()
                {
                    Id = p.Id,
                    Name = p.Title,
                    Category = p.Category.Name,
                    Creator = p.Creator.FirstName + " " + p.Creator.LastName,
                    DateCreated = p.DateCreated,
                    Description = p.Description,
                    NumberOfVideos = p.Videos.Count(),
                    Rating = Math.Round(p.Ratings.Average(r => r.Value), 1),
                    LinkToDetailsPage = "~/Authorized/CategoryDetails?id=" + p.Id
                })
                .OrderByDescending(p => p.DateCreated);
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void GridViewPlaylists_UpdateItem(int id)
        {
            YouTubePlaylists.Models.Playlist item = null;
            // Load the item here, e.g. item = MyDataLayer.Find(id);
            if (item == null)
            {
                // The item wasn't found
                ModelState.AddModelError("", String.Format("Item with id {0} was not found", id));
                return;
            }
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                // Save changes here, e.g. MyDataLayer.SaveChanges();

            }
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void GridViewPlaylists_DeleteItem(int id)
        {

        }
    }
}