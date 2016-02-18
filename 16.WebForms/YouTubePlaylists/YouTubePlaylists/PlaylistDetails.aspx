<%@ Page Title="Playlist details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PlaylistDetails.aspx.cs" Inherits="YouTubePlaylists.PlaylistDetails" %>

<asp:Content ID="PlaylistDetailsContainer" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView runat="server" ID="FormViewPlaylistDetails"
        ItemType="YouTubePlaylists.Models.Playlist"
        SelectMethod="FormViewPlaylistDetails_GetItem">
        <ItemTemplate>
            <header>
                <h1>Playlist title: <%#: Item.Title %></h1>
                <h2>Rating: <i><%#: string.Format("{0:0.#}", Item.Ratings.Average(r => r.Value)) %></i></h2>
                <p><b>Playlist description: </b><%#: Item.Description %></p>
                <p>
                    Category: 
                     <asp:HyperLink runat="server"
                         NavigateUrl='<%# string.Format("~/Authorized/CategoryDetails.aspx?id={0}", Item.CategoryId) %>'
                         Text='<%# Item.Category.Name %>'>
                     </asp:HyperLink>
                </p>

                <p>Created by <%#: Item.Creator.FirstName + " " + Item.Creator.LastName %> on <%#: Item.DateCreated %></p>
                <asp:Repeater ID="RepeaterVideos" runat="server"
                    ItemType="YouTubePlaylists.Models.Video"
                    SelectMethod="RepeaterVideos_GetData">
                    <ItemTemplate>
                        <iframe width="420" height="315"
                            src="<%# Item.Url %>"></iframe>
                    </ItemTemplate>
                </asp:Repeater>
            </header>
        </ItemTemplate>
    </asp:FormView>
    <div class="back-link">
        <a href="/">Back to home</a>
    </div>
</asp:Content>
