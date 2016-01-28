namespace LybrarySystem.Admin
{
    using System;
    using System.Linq;
    using System.Web.UI;
    using LibrarySystem.Models;

    public partial class EditBooks : Page
    {
        public LibraryDbContext dbContext;

        public EditBooks()
        {
            this.dbContext = new LibraryDbContext();
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
        public IQueryable<Book> GridViewBooks_GetData()
        {
            return this.dbContext.Books.OrderBy(b => b.Id);
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void GridViewBooks_UpdateItem(int id)
        {
            Book item = this.dbContext.Books.Find(id);
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

        // The id parameter name should match the DataKeyNames value set on the control
        public void GridViewBooks_DeleteItem(int id)
        {
            Book item = this.dbContext.Books.Find(id);

            if (item == null)
            {
                // The item wasn't found
                ModelState.AddModelError("", String.Format("Item with id {0} was not found", id));
                return;
            }

            this.dbContext.Books.Remove(item);
            this.dbContext.SaveChanges();
        }

        public void FormViewInsertBook_InsertItem()
        {
            var item = new Book();
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                this.dbContext.Books.Add(item);
                this.dbContext.SaveChanges();
                Response.Redirect(Request.RawUrl);
            }
        }

        public IQueryable<Category> DropDownListCategoriesCreate_GetData()
        {
            return this.dbContext.Categories.OrderBy(c => c.Name);
        }

        protected void LinkButtonInsert_Click(object sender, EventArgs e)
        {
            this.FormViewInsertBook.Visible = true;
        }

        protected void LinkButtonCancel_Click(object sender, EventArgs e)
        {
            this.FormViewInsertBook.Visible = false;
        }
    }
}