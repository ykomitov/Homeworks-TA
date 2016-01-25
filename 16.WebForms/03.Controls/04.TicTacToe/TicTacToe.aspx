<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TicTacToe.aspx.cs" Inherits="_04.TicTacToe.TicTacToe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My Stupid Tic Tac Toe</title>
    <style>
        table {
            border-collapse: collapse;
            border-spacing: 0;
            padding: 0;
            margin: 0;
        }

        td {
            border: 1px solid black;
            padding: 0;
            margin: 0;
        }

            td input {
                display: block;
            }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel runat="server" ID="GameContainer">
            <asp:Button runat="server" ID="ButtonStartGame" OnClick="ButtonStartGame_Click" Text="Start new game" />
            <h1 runat="server" id="GameResultContainer"></h1>
            <table>
                <tr>
                    <td>
                        <asp:ImageButton TabIndex="0" runat="server" ImageUrl="images/blank.png" OnClick="MarkMove_Click" Enabled="false" /></td>
                    <td>
                        <asp:ImageButton TabIndex="1" runat="server" ImageUrl="images/blank.png" OnClick="MarkMove_Click" Enabled="false" /></td>
                    <td>
                        <asp:ImageButton TabIndex="2" runat="server" ImageUrl="images/blank.png" OnClick="MarkMove_Click" Enabled="false" /></td>
                </tr>
                <tr>
                    <td>
                        <asp:ImageButton TabIndex="3" runat="server" ImageUrl="images/blank.png" OnClick="MarkMove_Click" Enabled="false" /></td>
                    <td>
                        <asp:ImageButton TabIndex="4" runat="server" ImageUrl="images/blank.png" OnClick="MarkMove_Click" Enabled="false" /></td>
                    <td>
                        <asp:ImageButton TabIndex="5" runat="server" ImageUrl="images/blank.png" OnClick="MarkMove_Click" Enabled="false" /></td>
                </tr>
                <tr>
                    <td>
                        <asp:ImageButton TabIndex="6" runat="server" ImageUrl="images/blank.png" OnClick="MarkMove_Click" Enabled="false" /></td>
                    <td>
                        <asp:ImageButton TabIndex="7" runat="server" ImageUrl="images/blank.png" OnClick="MarkMove_Click" Enabled="false" /></td>
                    <td>
                        <asp:ImageButton TabIndex="8" runat="server" ImageUrl="images/blank.png" OnClick="MarkMove_Click" Enabled="false" /></td>
                </tr>
            </table>
        </asp:Panel>
    </form>
</body>
</html>
