<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="_05.Calculator.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Simple Calculator</title>
    <style>
        input {
            height: 40px;
            width: 50px;
        }
    </style>
</head>
<body>
    <form id="calculator" runat="server">
        <div style="border: 1px solid black; width: 210px; height: 30px; text-align: right; padding-top: 8px;">
            <asp:Literal runat="server" ID="CalculatorDisplay"></asp:Literal>
        </div>
        <div>
            <asp:Button runat="server" ID="Calc_One" Text="1" OnClick="Calc_UpdateDisplay" />
            <asp:Button runat="server" ID="Calc_Two" Text="2" OnClick="Calc_UpdateDisplay" />
            <asp:Button runat="server" ID="Calc_Three" Text="3" OnClick="Calc_UpdateDisplay" />
            <asp:Button runat="server" ID="Calc_Plus" Text="+" OnClick="Calc_Operation" />
            <br />
            <asp:Button runat="server" ID="Calc_Four" Text="4" OnClick="Calc_UpdateDisplay" />
            <asp:Button runat="server" ID="Calc_Five" Text="5" OnClick="Calc_UpdateDisplay" />
            <asp:Button runat="server" ID="Calc_Six" Text="6" OnClick="Calc_UpdateDisplay" />
            <asp:Button runat="server" ID="Calc_Minus" Text="-" OnClick="Calc_Operation" />
            <br />
            <asp:Button runat="server" ID="Calc_Seven" Text="7" OnClick="Calc_UpdateDisplay" />
            <asp:Button runat="server" ID="Calc_Eight" Text="8" OnClick="Calc_UpdateDisplay" />
            <asp:Button runat="server" ID="Calc_Nine" Text="9" OnClick="Calc_UpdateDisplay" />
            <asp:Button runat="server" ID="Calc_Multiply" Text="X" OnClick="Calc_Operation" />
            <br />
            <asp:Button runat="server" ID="Calc_Clear" Text="C" OnClick="Calc_Clear_Click" />
            <asp:Button runat="server" ID="Calc_Zero" Text="0" OnClick="Calc_UpdateDisplay" />
            <asp:Button runat="server" ID="Calc_Divide" Text="/" OnClick="Calc_Operation" />
            <asp:Button runat="server" ID="Calc_Sqrt" Text="√" OnClick="Calc_Sqrt_Click" />
        </div>
        <div>
            <asp:Button runat="server" ID="CalculatorEquals" Text="=" OnClick="CalculatorEquals_Click" Style="width: 212px" />
        </div>
    </form>
</body>
</html>
