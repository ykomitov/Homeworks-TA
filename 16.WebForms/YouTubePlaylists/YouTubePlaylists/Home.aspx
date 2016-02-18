<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="YouTubePlaylists.Home" %>

<asp:Content ID="ContentHome" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Top 10 Playlists by Rating:</h1>
    <div class="col-md-12">
        <table class="table table-striped table-hover">
            <thead>
                <tr>
                    <th>Playlist Name</th>
                    <th>Author</th>
                    <th>Rating</th>
                </tr>
            </thead>
            <asp:ListView runat="server" ID="ListViewTopPlaylists"
                ItemType="YouTubePlaylists.Models.Playlist"
                SelectMethod="ListViewTopPlaylists_GetData">
                <ItemTemplate>
                    <tr>
                        <td>
                            <asp:HyperLink runat="server"
                                NavigateUrl='<%# string.Format("~/PlaylistDetails.aspx?id={0}", Item.Id) %>'
                                Text='<%# string.Format(@"""{0}""", Item.Title) %>'>
                            </asp:HyperLink>
                        </td>
                        <td>
                            <asp:Label runat="server"
                                Text='<%# string.Format("by <i>{0} {1}</i>", Item.Creator.FirstName, Item.Creator.LastName) %>'>
                            </asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server"
                                Text='<%# string.Format("<b>Rating: {0:0.#}</b>", Item.Ratings.Average(r => r.Value)) %>'>
                            </asp:Label>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:ListView>
        </table>
    </div>
</asp:Content>
