<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmpDetails.aspx.cs" Inherits="_02.NorthwindEmployees.EmpDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employee Details</title>
</head>
<body>
    <form id="EmployeeDetailsForm" runat="server">
        <div>
            <asp:DetailsView ID="DetailsViewEmployee" runat="server"
                SelectMethod="DetailsViewEmployee_GetData"
                AutoGenerateColumns="True"
                AutoGenerateRows="True">
            </asp:DetailsView>
            <asp:HyperLink runat="server" NavigateUrl="~/">Back</asp:HyperLink>
        </div>
    </form>
</body>
</html>
