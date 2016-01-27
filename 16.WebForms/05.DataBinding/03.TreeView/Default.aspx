<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_03.TreeView.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="float: left">
            <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/students.xml"></asp:XmlDataSource>
            <asp:TreeView ID="TreeViewXml" runat="server"
                DataSourceID="XmlDataSource1"
                OnSelectedNodeChanged="Select_Change">
            </asp:TreeView>
        </div>
        <div style="float: left" runat="server" id="InnerHtmlContainer"></div>
    </form>
</body>
</html>
