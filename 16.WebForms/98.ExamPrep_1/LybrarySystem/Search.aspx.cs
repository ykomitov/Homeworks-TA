namespace LybrarySystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.ModelBinding;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using LibrarySystem.Models;

    public partial class Search : Page
    {
        public LibraryDbContext dbContext;

        public Search()
        {
            this.dbContext = new LibraryDbContext();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable<Book> RepeaterSearchResults_GetData([QueryString("q")] string query)
        {
            this.LiteralSearchQuery.Text = string.Format(@"""{0}""", query);

            return this.dbContext.Books
                .Where(b => b.Author.Contains(query) || b.Title.Contains(query))
                .ToList();
        }
    }
}