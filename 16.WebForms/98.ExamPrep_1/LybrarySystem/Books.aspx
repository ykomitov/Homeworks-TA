<%@ Page Title="Books" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Books.aspx.cs" Inherits="LibrarySystem.Books" %>

<asp:Content ID="ContentBody" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <h1><%: this.Title %></h1>
        <div class="search-button">
            <div class="form-search">
                <div class="input-append">
                    <input runat="server" id="inputSearch" type="text" name="q" class="col-md-3 search-query" placeholder="Search book by title / author" />
                    <asp:LinkButton ID="LinkButtonSearch" Text="Search" runat="server" CssClass="btn btn-danger" OnClick="LinkButtonSearch_Click" />
                </div>
            </div>
        </div>
    </div>

    <asp:ListView ID="ListViewCategories" runat="server"
        ItemType="LibrarySystem.Models.Category"
        SelectMethod="ListViewCategories_GetData"
        GroupItemCount="3">
        <GroupTemplate>
            <div class="row">
                <asp:PlaceHolder runat="server" ID="itemPlaceholder"></asp:PlaceHolder>
            </div>
        </GroupTemplate>
        <ItemTemplate>
            <div class="col-md-4">
                <h2><%#: Item.Name %></h2>
                <asp:ListView runat="server" ID="RepeaterBooks"
                    ItemType="LibrarySystem.Models.Book"
                    DataSource="<%# Item.Books %>">
                    <LayoutTemplate>
                        <ul>
                            <asp:PlaceHolder ID="itemPlaceholder" runat="server" />
                        </ul>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <li>
                            <asp:HyperLink runat="server"
                                NavigateUrl='<%# string.Format("~/BookDetails.aspx?id={0}", Item.Id) %>'
                                Text='<%# string.Format(@"""{0}"" by <i>{1}</i>", Item.Title, Item.Author) %>'>
                            </asp:HyperLink>
                        </li>
                    </ItemTemplate>
                    <EmptyDataTemplate>
                        No books in this category
                    </EmptyDataTemplate>
                </asp:ListView>
            </div>
        </ItemTemplate>
    </asp:ListView>
</asp:Content>
