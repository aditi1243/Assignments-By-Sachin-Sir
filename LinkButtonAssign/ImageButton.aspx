<%@ Page Language="C#" AutoEventWireup="true" CodeFile="buttons.aspx.cs" Inherits="buttons" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click"
        style="z-index: 1; left: 23px; top: 56px; position: absolute" Text="click!" />
    <asp:LinkButton ID="LinkButton1" runat="server" EnableTheming="True"
        onclick="LinkButton1_Click"
        style="z-index: 1; left: 24px; top: 194px; position: absolute"
        ToolTip="Link to another page">LinkButton</asp:LinkButton>
    <p style="height: 669px">
        <asp:ImageButton ID="ImageButton1" runat="server"
            ImageUrl="~/images/smiley-guy.jpg" onclick="ImageButton1_Click"
            style="z-index: 1; left: 16px; top: 294px; position: absolute; height: 80px;
width: 88px; right: 1177px; bottom: 421px" />
        <asp:TextBox ID="TextBox1" runat="server"
            style="z-index: 1; left: 20px; top: 383px; position: absolute"></asp:TextBox>
    </p>
    <p>&nbsp;</p>
    </form>
</body>
</html>