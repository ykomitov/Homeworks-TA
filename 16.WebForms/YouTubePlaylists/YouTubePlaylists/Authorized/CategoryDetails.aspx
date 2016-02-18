<%@ Page Title="Category Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CategoryDetails.aspx.cs" Inherits="YouTubePlaylists.Authorized.CategoryDetails" %>

<asp:Content ID="CategoryDetails" ContentPlaceHolderID="MainContent" runat="server">
    <h1>All playlists in category</h1>
    <asp:GridView runat="server" ID="GridViewCategoryDetails" ItemType="YouTubePlaylists.Models.PlaylistDetailsRequestModel"
        SelectMethod="GridViewCategoryDetails_GetData"
        AllowPaging="true"
        PageSize="10"
        AllowSorting="true"
        AutoGenerateColumns="false"
        DataKeyNames="Id"
        EmptyDataText="No playlists in this category!">
        <Columns>
            <asp:BoundField DataField="Name" HeaderText="Playlist Name" SortExpression="Name" />
            <asp:HyperLinkField DataNavigateUrlFields="LinkToDetailsPage"
                DataTextField="Category"
                HeaderText="Category name" SortExpression="Category" />
            <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
            <asp:BoundField DataField="Creator" HeaderText="Created by" SortExpression="Creator" />
            <asp:BoundField DataField="DateCreated" HeaderText="Created on" SortExpression="DateCreated" />
            <asp:BoundField DataField="Rating" HeaderText="Rating" SortExpression="Rating" />
            <asp:BoundField DataField="NumberOfVideos" HeaderText="N of videos" SortExpression="NumberOfVideos" />
        </Columns>
    </asp:GridView>
</asp:Content>
