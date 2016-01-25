<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RandomWithWebServerControls.aspx.cs" Inherits="_01.Random.RandomWithWebServerControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" Text="Min:"></asp:Label>
            <asp:TextBox ID="MinInput" runat="server"></asp:TextBox>
            <asp:Label runat="server" Text="Min:"></asp:Label>
            <asp:TextBox ID="MaxInput" runat="server"></asp:TextBox>
            <asp:Button ID="GenerateRandom" runat="server" OnClick="GenerateRandom_Click" Text="Generate" />
            <br />
            <asp:Label ID="Output" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
