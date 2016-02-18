<%@ Page Title="Edit Categories" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditCategories.aspx.cs" Inherits="YouTubePlaylists.Admin.EditCategories" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Edit categories:</h1>
    <asp:GridView runat="server" ID="GridViewEditCategories" ItemType="YouTubePlaylists.Models.CategoryEditRequestModel"
        SelectMethod="GridViewEditCategories_GetData"
        UpdateMethod="GridViewEditCategories_UpdateItem"
        AllowPaging="true"
        PageSize="5"
        AllowSorting="true"
        AutoGenerateColumns="false"
        DataKeyNames="Id">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Category ID" ReadOnly="true" SortExpression="Id" />
            <asp:BoundField DataField="Name" HeaderText="Category Name" SortExpression="Name" />
            <asp:BoundField DataField="CountOfPlaylists" ReadOnly="true" HeaderText="N of Playlists" SortExpression="CountOfPlaylists" />
            <asp:CommandField ShowEditButton="true" />
        </Columns>
    </asp:GridView>
</asp:Content>
