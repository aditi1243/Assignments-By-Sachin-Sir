<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="DataBoundContrl.Employee" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 746px;
            height: 167px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style1">
        <div>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EmployeeTableConnectionString %>" SelectCommand="SELECT * FROM [EmployeeTable]"></asp:SqlDataSource>
        <asp:DataList ID="DataList1" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataSourceID="SqlDataSource1" GridLines="Vertical" Width="594px">
            <AlternatingItemStyle BackColor="#DCDCDC" />
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <ItemStyle BackColor="#EEEEEE" ForeColor="Black" />
            <ItemTemplate>
                EmpID:
                <asp:Label ID="EmpID" runat="server" Text='<%# Eval("EmpID") %>' />
                <br />
                EmpName:
                <asp:Label ID="EmpName" runat="server" Text='<%# Eval("EmpName") %>' />
                <br />
                EmpEmailID:
                <asp:Label ID="EmpEmailID" runat="server" Text='<%# Eval("EmpEmailID") %>' />
                <br />
                EmpMobileNo:
                <asp:Label ID="EmpMobileNo" runat="server" Text='<%# Eval("EmpMobileNo") %>' />
                <br />
                EmpImage:
                <asp:Label ID="EmpImage" runat="server" Text='<%# Eval("EmpImage") %>' />
                <br />
                EmpGender:
                <asp:Label ID="EmpGender" runat="server" Text='<%# Eval("EmpGender") %>' />
                <br />
                <br />
            </ItemTemplate>
            <SelectedItemStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        </asp:DataList>
    </form>
</body>
</html>
