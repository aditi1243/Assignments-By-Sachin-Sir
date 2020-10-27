<%@ Page Language="C#" AutoEventWireup="true" CodeBehind= "LinkButton.aspx.cs" Inherits="WebAppCal.LinkButton" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   
     <!---Syntax of LinkButton-->
     <asp:LinkButton  
    AccessKey="string"  
    ID="string"  
    OnClick="Click event handler"  
    OnClientClick="string"  
    OnCommand="Command event handler"  
    OnDataBinding="DataBinding event handler"  
    OnDisposed="Disposed event handler"  
    OnInit="Init event handler"  
    OnLoad="Load event handler"  
    OnPreRender="PreRender event handler"  
    OnUnload="Unload event handler"  
    PostBackUrl="uri"  
    runat="server"  
/>  

    <form id="form1" runat="server">
        <h3>It is a HyperLink Style Button</h3>
        <div>
           <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Facebook</asp:LinkButton>  
            <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton1_Click">IASBaba</asp:LinkButton> 
            <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton1_Click">Courseera</asp:LinkButton> 
            <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton1_Click">Udemy</asp:LinkButton> 
            <asp:LinkButton ID="LinkButton5" runat="server" OnClick="LinkButton1_Click">Insights</asp:LinkButton> 

        </div>
        <p>
            
            <asp:Label ID="Label1" runat="server"></asp:Label>  
        </p>
    </form>
</body>
</html>
