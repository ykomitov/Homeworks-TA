<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_02.NorthwindEmployees.Employees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>NorthwindEmployees</title>
</head>
<body>
    <form id="NorthwindEmployeesForm" runat="server">
        <div>
            <asp:GridView ID="GridViewEmployees" runat="server"
                SelectMethod="GridViewEmployees_GetData"
                AllowSorting="True"
                AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="EmployeeId" HeaderText="ID" ReadOnly="True" SortExpression="EmployeeId" />
                    <asp:HyperLinkField DataTextField="FullName" DataNavigateUrlFields="EmployeeId" DataNavigateUrlFormatString="EmpDetails.aspx?id={0}" HeaderText="Employee Name" SortExpression="FullName" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
