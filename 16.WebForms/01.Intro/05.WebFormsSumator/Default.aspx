<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_05.WebFormsSumator._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label ID="FirstNumberLabel" runat="server" Text="First Number"></asp:Label>
    <asp:TextBox ID="FirstNumberText" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="SecondNumberLabel" runat="server" Text="Second Number"></asp:Label>
    <asp:TextBox ID="SecondNumberText" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Sum" runat="server" Text="Sum" OnClick="Submit_Click" />
    <asp:TextBox ID="Result" runat="server"></asp:TextBox>

</asp:Content>
