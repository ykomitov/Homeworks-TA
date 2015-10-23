namespace EntityFrameworkIntro
{
    using System;

    public class CustomerInfoDTO
    {
        public DateTime? DateOfOrder { get; set; }

        public string CompanyName { get; set; }

        public string ShipToCountry { get; set; }
    }
}
