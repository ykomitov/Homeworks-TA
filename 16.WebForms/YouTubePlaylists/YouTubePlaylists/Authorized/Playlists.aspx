<%@ Page Title="All Playlists" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Playlists.aspx.cs" Inherits="YouTubePlaylists.Authorized.Playlists" %>

<asp:Content ID="PlaylistsRegistered" ContentPlaceHolderID="MainContent" runat="server">
    <h1>All playlists:</h1>
    <asp:GridView runat="server" ID="GridViewPlaylists" ItemType="YouTubePlaylists.Models.PlaylistDetailsRequestModel"
        SelectMethod="GridViewPlaylists_GetData"
        UpdateMethod="GridViewPlaylists_UpdateItem"
        DeleteMethod="GridViewPlaylists_DeleteItem"
        AllowPaging="true"
        PageSize="10"
        AllowSorting="true"
        AutoGenerateColumns="false"
        DataKeyNames="Id">
        <Columns>
            <asp:BoundField DataField="Name" HeaderText="Playlist Name" SortExpression="Name" />
            <asp:HyperLinkField  DataNavigateUrlFields="LinkToDetailsPage"
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
