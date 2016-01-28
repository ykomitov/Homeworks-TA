<%@ Page Title="Edit Books" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditBooks.aspx.cs" Inherits="LybrarySystem.Admin.EditBooks" %>

<asp:Content ID="ContentBody" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView runat="server" ID="GridViewBooks" ItemType="LibrarySystem.Models.Book"
        SelectMethod="GridViewBooks_GetData"
        UpdateMethod="GridViewBooks_UpdateItem"
        DeleteMethod="GridViewBooks_DeleteItem"
        AllowPaging="true"
        PageSize="5"
        AllowSorting="true"
        AutoGenerateColumns="false"
        DataKeyNames="Id">
        <Columns>
            <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
            <asp:BoundField DataField="Author" HeaderText="Author" SortExpression="Author" />
            <asp:BoundField DataField="ISBN" HeaderText="ISBN" SortExpression="ISBN" />
            <asp:BoundField DataField="WebSite" HeaderText="Web Site" SortExpression="WebSite" />
            <asp:BoundField DataField="Category.Name" HeaderText="Category Name" SortExpression="Category.Name" />
            <asp:CommandField ShowEditButton="true" ShowDeleteButton="true" />
        </Columns>
    </asp:GridView>
    <asp:LinkButton Text="Insert" ID="LinkButtonInsert" runat="server" OnClick="LinkButtonInsert_Click" />
    <asp:UpdatePanel runat="server" ID="UpdatePanelInsertBook">
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="LinkButtonInsert" EventName="Click" />
        </Triggers>
        <ContentTemplate>
            <asp:FormView ID="FormViewInsertBook" DefaultMode="Insert" runat="server"
                ItemType="LibrarySystem.Models.Book"
                InsertMethod="FormViewInsertBook_InsertItem"
                Visible="false">
                <InsertItemTemplate>
                    <h2>Create new book</h2>
                    <div>
                        <span>Title</span>
                        <asp:TextBox runat="server" ID="TextBoxBookTitleCreate"
                            placeholder="Enter book title..." Text="<%#: BindItem.Title %>" />
                    </div>
                    <div>
                        <span>Author(s)</span>
                        <asp:TextBox runat="server" ID="TextBoxBookAuthorCreate"
                            placeholder="Enter book author/authors..." Text="<%#: BindItem.Author %>" />
                    </div>
                    <div>
                        <span>ISBN:</span>
                        <asp:TextBox runat="server" ID="TextBoxBookISBNCreate"
                            placeholder="Enter book ISBN..." Text="<%#: BindItem.ISBN %>" />
                    </div>
                    <div>
                        <span>Web site:</span>
                        <asp:TextBox runat="server" ID="TextBoxBookWebSiteCreate"
                            placeholder="Enter book web site..." Text="<%#: BindItem.WebSite %>" />
                    </div>
                    <div>
                        <span>Description:</span>
                        <asp:TextBox runat="server" ID="TextBoxBookDescriptionCreate" TextMode="MultiLine" Height="160"
                            placeholder="Enter book description..." Text="<%#: BindItem.Description %>" />
                    </div>
                    <div>
                        <span>Category:</span>
                        <asp:DropDownList runat="server" ID="DropDownListCategoriesCreate"
                            ItemType="LibrarySystem.Models.Category"
                            DataTextField="Name"
                            DataValueField="Id"
                            SelectedValue="<%#: BindItem.CategoryId %>"
                            SelectMethod="DropDownListCategoriesCreate_GetData">
                        </asp:DropDownList>
                    </div>
                    <asp:LinkButton Text="Create" runat="server" CommandName="Insert" CssClass="btn btn-danger" />
                    <asp:LinkButton ID="LinkButtonCancel" Text="Cancel" runat="server" CommandName="Cancel" OnClick="LinkButtonCancel_Click" CssClass="btn btn-primary" />
                </InsertItemTemplate>
            </asp:FormView>
        </ContentTemplate>
    </asp:UpdatePanel>
    <div class="back-link">
        <a href="/">Back to books</a>
    </div>
</asp:Content>
