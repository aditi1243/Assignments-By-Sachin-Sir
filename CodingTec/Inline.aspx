<%@ Page Language="C#" %>

<!DOCTYPE html>

<script runat="server">

    protected void Button1_Click(object sender, EventArgs e)
    {
   
        Response.Write("Button clicked action performed");

    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           
             <asp:Button ID="Button1" runat="server" Text="Click me" ForeColor="GreenYellow" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Click Click Me" ForeColor="Red" OnClick="Button1_Click" />
            
        </div>
    </form>
</body>
</html>
