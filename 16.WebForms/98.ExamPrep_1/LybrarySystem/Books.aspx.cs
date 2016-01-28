namespace LibrarySystem
{
    using System;
    using System.Collections.Generic;
    using System.Web.UI;
    using Models;

    public partial class Books : Page
    {
        public LibraryDbContext dbContext;

        public Books()
        {
            this.dbContext = new LibraryDbContext();
        }

        public IEnumerable<Category> ListViewCategories_GetData()
        {
            return this.dbContext.Categories;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void LinkButtonSearch_Click(object sender, EventArgs e)
        {
            string queryParam = string.Format("?q={0}", this.inputSearch.Value);

            Response.Redirect("~/Search" + queryParam);
        }
    }
}