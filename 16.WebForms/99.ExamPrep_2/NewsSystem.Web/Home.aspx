<%@ Page Title="News System Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="NewsSystem.Web.Home" %>

<asp:Content ID="ContentMain" ContentPlaceHolderID="MainContent" runat="server">
    <h1>News</h1>
    <h2>Most popular articles</h2>
    <asp:Repeater runat="server" ID="RepeaterArticles"
        ItemType="NewsSystem.Data.Models.Article"
        SelectMethod="RepeaterArticles_GetData">
        <ItemTemplate>
            <h3><a href="~/ViewArticle.aspx?id=<%# Item.Id %>"><%#: Item.Title %></a></h3>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
