namespace YouTubePlaylists.Authorized
{
    using System;
    using System.Linq;
    using System.Web.ModelBinding;
    using YouTubePlaylists.Models;

    public partial class CategoryDetails : System.Web.UI.Page
    {
        public YoutubePlaylistsDbContext dbContext;

        public CategoryDetails()
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
        public IQueryable<PlaylistDetailsRequestModel> GridViewCategoryDetails_GetData([QueryString("id")]int? categoryId)
        {
            if (categoryId == null)
            {
                Response.Redirect("~/");
            }

            return this.dbContext.Playlists
                .Where(p => p.CategoryId == categoryId)
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
    }
}