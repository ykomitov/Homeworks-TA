<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_02.WebFormsSampleApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>
            <asp:Label runat="server" Text="Hello, ASP.NET from .aspx"></asp:Label>
        </h1>
    </div>

    <div class="jumbotron">
        <h1>
            <asp:Label ID="LabelForCSharp" runat="server"></asp:Label>
        </h1>
        <h2>Current assembly location:</h2>
        <h3>
            <asp:Label ID="LabelForAssembly" runat="server"></asp:Label>
        </h3>
    </div>

</asp:Content>
