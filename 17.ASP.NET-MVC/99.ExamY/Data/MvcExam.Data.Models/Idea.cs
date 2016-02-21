namespace MvcExam.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Common.Models;

    public class Idea : BaseModel<int>
    {
        [Required]
        [MaxLength(400)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Idea description cannot be empty")]
        public string Description { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<Vote> Votes { get; set; }
    }
}
