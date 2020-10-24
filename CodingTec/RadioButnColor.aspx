<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RadioButnColor.aspx.cs" Inherits="Controls_____.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:RadioButton ID="Radiobutton1" runat="server" Text="CS-batch"  ForeColor="Red" OnCheckedChanged="Radiobutton1_CheckedChanged" GroupName="batch"/><br /> <br />
            <asp:RadioButton ID="Radiobutton2" runat="server" Text="ME-batch" ForeColor="Blue" OnCheckedChanged="Radiobutton2_CheckedChanged" GroupName="batch" /><br /> <br />
            <asp:RadioButton ID="Radiobutton3" runat="server" Text="EE-batch" ForeColor="Green" OnCheckedChanged="Radiobutton3_CheckedChanged" /><br /> <br />
            <asp:RadioButton ID="Radiobutton4" runat="server" Text="EC-batch" ForeColor="Yellow" OnCheckedChanged="Radiobutton4_CheckedChanged" /><br /> <br />
            <asp:RadioButton ID="Radiobutton5" runat="server" Text="CE-batch" ForeColor="ForestGreen" OnCheckedChanged="Radiobutton5_CheckedChanged" /><br /> <br />
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" style="width: 61px" />  
            
           </div>
    
        </form>
     <asp:Label runat="server" ID="colorid" /> 
</body>
</html>
