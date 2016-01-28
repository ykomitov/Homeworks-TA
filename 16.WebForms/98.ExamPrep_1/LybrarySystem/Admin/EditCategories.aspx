<%@ Page Title="Edit Categories" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditCategories.aspx.cs" Inherits="LybrarySystem.Admin.EditCategories" %>

<asp:Content ID="ContentBody" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ListView runat="server" ID="ListViewCategories" ItemType="LibrarySystem.Models.Category"
        SelectMethod="ListViewCategories_GetData"
        UpdateMethod="ListViewCategories_UpdateItem"
        DeleteMethod="ListViewCategories_DeleteItem"
        InsertMethod="ListViewCategories_InsertItem"
        InsertItemPosition="LastItem"
        DataKeyNames="ID">
        <LayoutTemplate>
            <table>
                <thead>
                    <tr>
                        <th scope="col">
                            <asp:LinkButton Text="Category Name" runat="server" ID="LinkButtonSortByCategory"
                                CommandName="Sort" CommandArgument="Name" />
                        </th>
                        <th scope="col">Action</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:PlaceHolder runat="server" ID="ItemPlaceholder" />
                </tbody>
                <tfoot>
                    <tr>
                        <td colspan="2">
                            <asp:DataPager runat="server" ID="DataPagerCategories" PagedControlID="ListViewCategories" PageSize="3">
                                <Fields>
                                    <asp:NumericPagerField />
                                </Fields>
                            </asp:DataPager>
                        </td>
                    </tr>
                    <tr>
                    </tr>
                </tfoot>
            </table>
        </LayoutTemplate>
        <ItemTemplate>
            <tr>
                <td><%#: Item.Name %></td>
                <td>
                    <asp:LinkButton Text="Edit" ID="ButtonEdit" CommandName="Edit" runat="server" />
                    <asp:LinkButton Text="Delete" ID="ButtonDelete" CommandName="Delete" runat="server" />
                </td>
            </tr>
        </ItemTemplate>
        <EditItemTemplate>
            <tr>
                <td>
                    <asp:TextBox runat="server" ID="TextBoxName" Text="<%#: BindItem.Name %>" /></td>
                <td>
                    <asp:LinkButton Text="Save" ID="ButtonSave" CommandName="Update" runat="server" />
                    <asp:LinkButton Text="Cancel" ID="ButtonCancel" CommandName="Cancel" runat="server" />
                </td>
            </tr>
        </EditItemTemplate>
        <InsertItemTemplate>
            <tr>
                <td>
                    <asp:TextBox runat="server" ID="TextBoxName" Text="<%#: BindItem.Name %>" /></td>
                <td>
                    <asp:LinkButton Text="Insert" ID="ButtonSave" CommandName="Insert" runat="server" />
                    <asp:LinkButton Text="Cancel" ID="ButtonCancel" CommandName="Cancel" runat="server" />
                </td>
            </tr>
        </InsertItemTemplate>
    </asp:ListView>
</asp:Content>
