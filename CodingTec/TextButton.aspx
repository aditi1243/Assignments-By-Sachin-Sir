<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TextBox.aspx.cs" Inherits="Controls_____.Text" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

          
            <asp:TextBox ID="TextBox1" runat="server" />
 	    <asp:TextBox ID="TextBox2" runat="server" />
            <asp:TextBox ID="TextBox3" runat="server" />
    
            <asp:Button ID="Button1" runat="server" Text="Update" />   
	     <asp:Button ID="Button2" runat="server" Text="Submit" />
	

         </div>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
             <asp:Button ID="Button1" runat="server" Text="SUBMIT" OnClick="Button1_Click" />
	 </p>
    </form>
  
</body>
</html>