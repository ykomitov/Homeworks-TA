namespace TeleimotBg.Web.Api.Models.RealEstate
{
    using System.ComponentModel.DataAnnotations;
    using Common.Constants;
    using Data.Models;

    public class CreateRealEstateRequestModel
    {
        [Required]
        [MaxLength(RealEstateConstants.TitleMaxLength)]
        [MinLength(RealEstateConstants.TitleMinLength)]
        public string Title { get; set; }

        [Required]
        [MaxLength(RealEstateConstants.DescriptionMaxLength)]
        [MinLength(RealEstateConstants.DescriptionMinLength)]
        public string Description { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Contact { get; set; }

        [Required]
        public string ConstructionYear { get; set; }

        public double? SellingPrice { get; set; }

        public double? RentingPrice { get; set; }

        [Required]
        public int Type { get; set; }

        public string UserId { get; set; }
    }
}