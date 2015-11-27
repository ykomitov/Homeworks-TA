namespace TeleimotBg.Web.Api.Models.Comments
{
    public class CreateCommentRequestModel
    {
        public int RealEstateId { get; set; }

        public string Content { get; set; }
    }
}