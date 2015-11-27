namespace TeleimotBg.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Common.Constants;

    public class RealEstate
    {
        private ICollection<Comment> comments;

        public RealEstate()
        {
            this.comments = new HashSet<Comment>();
        }

        public virtual ICollection<Comment> Comments
        {
            get { return this.comments; }
            set { this.comments = value; }
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(RealEstateConstants.TitleMaxLength)]
        [MinLength(RealEstateConstants.TitleMinLength)]
        public string RealEstateTitle { get; set; }

        [Required]
        [MaxLength(RealEstateConstants.DescriptionMaxLength)]
        [MinLength(RealEstateConstants.DescriptionMinLength)]
        public string RealEstateDescription { get; set; }

        [Required]
        [MaxLength(200)]
        public string Address { get; set; }

        [Required]
        [MaxLength(200)]
        public string Contact { get; set; }

        [Required]
        public AddType AddType { get; set; }

        public RealEstateType RealEstateType { get; set; }

        [Range(typeof(DateTime), "1/1/1800", "1/1/4024", ErrorMessage = RealEstateConstants.ConstructionYearMinimumErrorMessage)]
        public DateTime ConstructionYear { get; set; }

        public double? SellingPrice { get; set; }

        public double? RentingPrice { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
