<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_04.NorthwindEmployeesPaging.Default" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajax" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Northwind Employee Details</title>
</head>
<body>
    <form id="NorthwindEmployeeDetails" runat="server">
        <asp:ScriptManager ID="ScriptManagerNwEmployees" runat="server"></asp:ScriptManager>
        <div>
            <asp:GridView ID="GridViewEmployeeDetails" runat="server"
                BorderColor="#336699" BorderStyle="Solid" BorderWidth="1px" CellPadding="3"
                Font-Names="Verdana" Font-Size="10pt"
                SelectMethod="GridViewEmployees_GetData"
                AllowSorting="True" AllowPaging="True"
                PagerSettings-Mode="Numeric"
                PageSize="8"
                OnRowCreated="GridView_RowCreated"
                OnRowDataBound="EmployeeDetails_RowDataBound"
                AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="ID" ReadOnly="True" SortExpression="Id" />
                    <asp:BoundField DataField="FirstName" HeaderText="First Name" ReadOnly="True" SortExpression="FirstName" />
                    <asp:BoundField DataField="LastName" HeaderText="Last Name" ReadOnly="True" SortExpression="LastName" />
                    <asp:BoundField DataField="Country" HeaderText="Country" ReadOnly="True" SortExpression="Country" />
                    <asp:BoundField DataField="City" HeaderText="City" ReadOnly="True" SortExpression="City" />

                    <asp:TemplateField ItemStyle-Width="40" ItemStyle-HorizontalAlign="Center" ItemStyle-VerticalAlign="Middle">
                        <ItemTemplate>

                            <asp:Image ID="ImageMagnifier" runat="server" ImageUrl="~/images/magnifier.png" />

                            <ajax:PopupControlExtender ID="PopupControlExtender1" runat="server"
                                PopupControlID="PanelDetails"
                                TargetControlID="ImageMagnifier"
                                DynamicContextKey='<%# Eval("Id") %>'
                                DynamicControlID="PanelDetails"
                                DynamicServiceMethod="GetDynamicContent" Position="Bottom">
                            </ajax:PopupControlExtender>

                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <HeaderStyle BackColor="#336699" ForeColor="White" />
            </asp:GridView>
            <asp:Panel ID="PanelDetails" runat="server"></asp:Panel>
        </div>
    </form>
</body>
</html>
