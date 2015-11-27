namespace TeleimotBg.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using Common.Constants;

    public class UserRating
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string RatingUserId { get; set; }

        public virtual User RatingUser { get; set; }

        [Required]
        public string RatedUserId { get; set; }

        public virtual User RatedUser { get; set; }

        [Required]
        [Range(RatingConstants.MinRating, RatingConstants.MaxRating)]
        public int Rating { get; set; }
    }
}
