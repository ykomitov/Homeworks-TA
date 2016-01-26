<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_02.NestedMasterPages.Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron text-center" style="margin-top: 20px">
        <h1>Welcome to our site!</h1>
        <h3>Please choose your language from the links below</h3>
        <hr />
        <asp:HyperLink runat="server" NavigateUrl="~/us/UsHome.aspx" Text="English" />
        <asp:HyperLink runat="server" NavigateUrl="~/bg/BgHome.aspx" Text="Bulgarian" />
        <asp:HyperLink runat="server" NavigateUrl="~/es/EsHome.aspx" Text="Spannish" />
        <hr />
    </div>

</asp:Content>
