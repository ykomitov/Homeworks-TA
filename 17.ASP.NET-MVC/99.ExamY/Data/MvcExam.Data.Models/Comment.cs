namespace MvcExam.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using Common.Models;

    public class Comment : BaseModel<int>
    {
        [Required(ErrorMessage = "The content cannot be empty")]
        public string Content { get; set; }

        // [Display(Name = "Email address")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        public int IdeaId { get; set; }

        public virtual Idea Idea { get; set; }
    }
}
