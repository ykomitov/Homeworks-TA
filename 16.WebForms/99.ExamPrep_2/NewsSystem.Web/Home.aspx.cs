namespace NewsSystem.Web
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.UI;
    using Data;
    using Data.Models;

    public partial class Home : Page
    {
        private NewsSystemDbContext dbContext;

        public Home()
        {
            this.dbContext = new NewsSystemDbContext();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable<Article> RepeaterArticles_GetData()
        {
            return this.dbContext.Articles
                .OrderBy(a => a.Likes.Count())
                .Take(3);
        }
    }
}