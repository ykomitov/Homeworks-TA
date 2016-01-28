<%@ Page Title="Search Results for Query" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="LybrarySystem.Search" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-md-12">
        <h1><%: this.Title %>
            <asp:Literal ID="LiteralSearchQuery" Mode="Encode" runat="server" /></h1>
    </div>

    <asp:Repeater runat="server" ID="RepeaterSearchResults"
        ItemType="LibrarySystem.Models.Book"
        SelectMethod="RepeaterSearchResults_GetData">
        <HeaderTemplate>
            <ul>
        </HeaderTemplate>
        <ItemTemplate>
            <li>
                <asp:HyperLink runat="server"
                    NavigateUrl='<%# string.Format("~/BookDetails.aspx?id={0}", Item.Id)  %>'
                    Text='<%# string.Format(@"""{0}"" by <i>{1}</i>", Item.Title, Item.Author) %>'>
                </asp:HyperLink>
                (Category: <%#: Item.Category.Name %>)
            </li>
        </ItemTemplate>
        <FooterTemplate></ul></FooterTemplate>
    </asp:Repeater>

    <div class="back-link">
        <a href="/">Back to books</a>
    </div>
</asp:Content>
