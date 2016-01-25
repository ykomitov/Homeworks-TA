<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterStudents.aspx.cs" Inherits="_03.StudentsAndCourses.RegisterStudents" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="registrationForm" runat="server">

        <asp:Panel runat="server">
            <asp:Label runat="server" Text="First Name"></asp:Label>
            <asp:TextBox runat="server" ID="TextBotFirstName"></asp:TextBox>
            <br />
            <asp:Label runat="server" Text="Last Name"></asp:Label>
            <asp:TextBox runat="server" ID="TextBotLastName"></asp:TextBox>
            <br />
            <asp:Label runat="server" Text="Faculty Number"></asp:Label>
            <asp:TextBox runat="server" ID="TextBotFacutyNumber"></asp:TextBox>
            <br />
            <asp:Label runat="server" Text="University"></asp:Label>
            <asp:DropDownList runat="server" ID="DropDownUniversity">
                <asp:ListItem Value="1">University 1</asp:ListItem>
                <asp:ListItem Value="2">University 2</asp:ListItem>
                <asp:ListItem Value="3">University 3</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label runat="server" Text="Specualty"></asp:Label>
            <asp:DropDownList runat="server" ID="DropDownSpecialty">
                <asp:ListItem Value="1">Specialty 1</asp:ListItem>
                <asp:ListItem Value="2">Specialty 2</asp:ListItem>
                <asp:ListItem Value="3">Specialty 3</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label runat="server" Text="Courses"></asp:Label>
            <asp:ListBox ID="ListBoxCourses" SelectionMode="Multiple" runat="server" Width="98px">
                <asp:ListItem Value="1">Course 1</asp:ListItem>
                <asp:ListItem Value="2">Course 2</asp:ListItem>
                <asp:ListItem Value="3">Course 3</asp:ListItem>
            </asp:ListBox>
            <br />
            <asp:Button runat="server" ID="ButtonSubmit" Text="Submit" OnClick="ButtonSubmit_Click" />
        </asp:Panel>
        <div runat="server" id="OutputContainer"></div>
    </form>
</body>
</html>
