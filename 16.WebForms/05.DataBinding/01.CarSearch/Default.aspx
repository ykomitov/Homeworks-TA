<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_01.CarSearch.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Car Search</title>
</head>
<body>
    <form id="CarSearchForm" runat="server">
        <div>
            <asp:DropDownList ID="DropDownListProducer" AutoPostBack="true" runat="server">
                <asp:ListItem Text="--Select Producer--" Value=""></asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="DropDownListModel" runat="server"></asp:DropDownList>
            <asp:RadioButtonList ID="RadioButtonListEngines" RepeatDirection="Horizontal" runat="server"></asp:RadioButtonList>
        </div>
    </form>
    <h2 id="ResultContainer" runat="server"></h2>
</body>
</html>
