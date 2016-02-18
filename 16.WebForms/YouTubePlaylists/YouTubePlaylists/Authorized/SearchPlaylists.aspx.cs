namespace YouTubePlaylists.Authorized
{
    using System;

    public partial class SearchPlaylists : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void LinkButtonSearch_Click(object sender, EventArgs e)
        {
            string queryParam = string.Format("?q={0}", this.inputSearch.Value);

            Response.Redirect("~/Authorized/Search" + queryParam);
        }
    }
}