namespace MvcExam.Web.InputModels
{
    using System.ComponentModel.DataAnnotations;

    public class IdeaInputModel
    {
        [Required(ErrorMessage = "You have to enter your idea")]
        [StringLength(400)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Idea description cannot be empty")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
    }
}
