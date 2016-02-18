namespace YouTubePlaylists.Admin
{
    using System;
    using System.Linq;
    using Models;

    public partial class EditCategories : System.Web.UI.Page
    {
        public YoutubePlaylistsDbContext dbContext;

        public EditCategories()
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
        public IQueryable<CategoryEditRequestModel> GridViewEditCategories_GetData()
        {
            return this.dbContext.Categories
                .Select(c => new CategoryEditRequestModel()
                {
                    Id = c.Id,
                    CountOfPlaylists = c.Playlists.Count(),
                    Name = c.Name
                });
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void GridViewEditCategories_UpdateItem(int id)
        {
            Category item = this.dbContext.Categories.Find(id);
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
                this.dbContext.SaveChanges();
            }
        }
    }
}