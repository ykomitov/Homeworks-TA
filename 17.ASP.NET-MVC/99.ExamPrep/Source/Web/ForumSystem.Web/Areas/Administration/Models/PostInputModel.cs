namespace ForumSystem.Web.Areas.Administration.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public class PostInputModel
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Title { get; set; }

        [AllowHtml]
        public string Content { get; set; }
    }
}