namespace LybrarySystem
{
    using System;
    using System.Linq;
    using System.Web.ModelBinding;
    using LibrarySystem.Models;

    public partial class BookDetails : System.Web.UI.Page
    {
        public LibraryDbContext dbContext;

        public BookDetails()
        {
            this.dbContext = new LibraryDbContext();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // The id parameter should match the DataKeyNames value set on the control
        // or be decorated with a value provider attribute, e.g. [QueryString]int id
        public Book FormViewBookDetails_GetItem([QueryString("id")]int? bookId)
        {
            //string idStr = Request.QueryString["id"];
            //if (idStr == null)

            if (bookId == null)
            {
                Response.Redirect("~/");
            }

            //int bookId = int.Parse(idStr);

            return this.dbContext.Books.FirstOrDefault(b => b.Id == bookId);
        }
    }
}