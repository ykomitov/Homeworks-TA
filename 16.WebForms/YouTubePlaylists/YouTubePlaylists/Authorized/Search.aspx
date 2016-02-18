<%@ Page Title="Search results for query: " Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="YouTubePlaylists.Authorized.Search" %>

<asp:Content ID="Results" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-md-12">
        <h1><%: this.Title %>
            <asp:Literal ID="LiteralSearchQuery" Mode="Encode" runat="server" /></h1>
    </div>
    <asp:Repeater runat="server" ID="RepeaterSearchResults"
        ItemType="YouTubePlaylists.Models.Playlist"
        SelectMethod="RepeaterSearchResults_GetData">
        <HeaderTemplate>
            <ul>
        </HeaderTemplate>
        <ItemTemplate>
            <li>
                <asp:HyperLink runat="server"
                    NavigateUrl='<%# string.Format("~/PlaylistDetails.aspx?id={0}", Item.Id)  %>'
                    Text='<%# string.Format(@"""{0}"" by <i>{1} {2}</i>", Item.Title, Item.Creator.FirstName, Item.Creator.LastName) %>'>
                </asp:HyperLink>
            </li>
        </ItemTemplate>
        <FooterTemplate></ul></FooterTemplate>
    </asp:Repeater>

    <div class="back-link">
        <a href="/">Back to books</a>
    </div>
</asp:Content>
