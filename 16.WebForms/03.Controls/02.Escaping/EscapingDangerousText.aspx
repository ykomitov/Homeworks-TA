<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EscapingDangerousText.aspx.cs" Inherits="_02.Escaping.EscapingDangerousText" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextInput" runat="server"></asp:TextBox>
            <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
            <br />
            <asp:Literal ID="OutputLabel" Mode="Encode" runat="server"></asp:Literal>
            <asp:TextBox ID="OutputTextBot" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
