<%@ Page Title="Search Playlists" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SearchPlaylists.aspx.cs" Inherits="YouTubePlaylists.Authorized.SearchPlaylists" %>

<asp:Content ID="PlaylistSearch" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <h1><%: this.Title %></h1>
        <div class="col-md-12 col-centered">
            <div class="form-search">
                <input runat="server" id="inputSearch" type="text" name="q" class="col-md-3 search-query" placeholder="Search by name / description" />
                <asp:LinkButton ID="LinkButtonSearch" Text="Search" runat="server" CssClass="btn btn-danger" OnClick="LinkButtonSearch_Click" />
            </div>
        </div>
    </div>
</asp:Content>
