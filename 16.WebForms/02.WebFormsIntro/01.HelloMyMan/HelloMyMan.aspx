<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HelloMyMan.aspx.cs" Inherits="_01.HelloMyMan.HelloMyMan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hello My Man</title>
</head>
<body>
    <form id="HelloForm" runat="server">
        <div>
            <asp:Label ID="LabelForName" runat="server" Text="Input your name: "></asp:Label>
            <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
            <asp:Button ID="SubmitButton" runat="server" Text="Print greeting" OnClick="SubmitButton_Click" />
            <asp:Label ID="LabelForResult" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
