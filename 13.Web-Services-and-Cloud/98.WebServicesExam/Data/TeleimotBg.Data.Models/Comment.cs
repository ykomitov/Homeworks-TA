namespace TeleimotBg.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Common.Constants;

    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int RealEstateId { get; set; }

        public virtual RealEstate RealEstate { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }

        [Required]
        [MaxLength(CommentConstants.CommentMaxLength)]
        [MinLength(CommentConstants.CommentMinLength)]
        public string Content { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }
    }
}
