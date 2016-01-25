<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RandomWithHtmlControls.aspx.cs" Inherits="_01.Random.RandomWithHtmlControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label for="InputMin">Min</label>
            <input id="InputMin" type="number" runat="server" />
            <label for="InputMax">Max</label>
            <input id="InputMax" type="number" runat="server" />
            <button id="ButtonGenerate" runat="server" onserverclick="ButtonGenerate_Click">Generate</button>
            <h2 id="RandomNumber" runat="server"></h2>
        </div>
    </form>
</body>
</html>
