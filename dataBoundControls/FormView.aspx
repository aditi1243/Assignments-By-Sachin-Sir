<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormView.aspx.cs" Inherits="DataBoundContrl.FormView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:FormView ID="FormView1" runat="server" AllowPaging="True" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataSourceID="SqlDataSource1" GridLines="Both">
            <EditItemTemplate>
                EmpID:
                <asp:DynamicControl ID="EmpIDDynamicControl" runat="server" DataField="EmpID" Mode="Edit" />
                <br />
                EmpName:
                <asp:DynamicControl ID="EmpNameDynamicControl" runat="server" DataField="EmpName" Mode="Edit" />
                <br />
                EmpEmailID:
                <asp:DynamicControl ID="EmpEmailIDDynamicControl" runat="server" DataField="EmpEmailID" Mode="Edit" />
                <br />
                EmpMobileNo:
                <asp:DynamicControl ID="EmpMobileNoDynamicControl" runat="server" DataField="EmpMobileNo" Mode="Edit" />
                <br />
                EmpImage:
                <asp:DynamicControl ID="EmpImageDynamicControl" runat="server" DataField="EmpImage" Mode="Edit" />
                <br />
                EmpGender:
                <asp:DynamicControl ID="EmpGenderDynamicControl" runat="server" DataField="EmpGender" Mode="Edit" />
                <br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" ValidationGroup="Insert" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </EditItemTemplate>
            <EditRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <InsertItemTemplate>
                EmpID:
                <asp:DynamicControl ID="EmpIDDynamicControl" runat="server" DataField="EmpID" Mode="Insert" ValidationGroup="Insert" />
                <br />
                EmpName:
                <asp:DynamicControl ID="EmpNameDynamicControl" runat="server" DataField="EmpName" Mode="Insert" ValidationGroup="Insert" />
                <br />
                EmpEmailID:
                <asp:DynamicControl ID="EmpEmailIDDynamicControl" runat="server" DataField="EmpEmailID" Mode="Insert" ValidationGroup="Insert" />
                <br />
                EmpMobileNo:
                <asp:DynamicControl ID="EmpMobileNoDynamicControl" runat="server" DataField="EmpMobileNo" Mode="Insert" ValidationGroup="Insert" />
                <br />
                EmpImage:
                <asp:DynamicControl ID="EmpImageDynamicControl" runat="server" DataField="EmpImage" Mode="Insert" ValidationGroup="Insert" />
                <br />
                EmpGender:
                <asp:DynamicControl ID="EmpGenderDynamicControl" runat="server" DataField="EmpGender" Mode="Insert" ValidationGroup="Insert" />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" ValidationGroup="Insert" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </InsertItemTemplate>
            <ItemTemplate>
                EmpID:
                <asp:DynamicControl ID="EmpIDDynamicControl" runat="server" DataField="EmpID" Mode="ReadOnly" />
                <br />
                EmpName:
                <asp:DynamicControl ID="EmpNameDynamicControl" runat="server" DataField="EmpName" Mode="ReadOnly" />
                <br />
                EmpEmailID:
                <asp:DynamicControl ID="EmpEmailIDDynamicControl" runat="server" DataField="EmpEmailID" Mode="ReadOnly" />
                <br />
                EmpMobileNo:
                <asp:DynamicControl ID="EmpMobileNoDynamicControl" runat="server" DataField="EmpMobileNo" Mode="ReadOnly" />
                <br />
                EmpImage:
                <asp:DynamicControl ID="EmpImageDynamicControl" runat="server" DataField="EmpImage" Mode="ReadOnly" />
                <br />
                EmpGender:
                <asp:DynamicControl ID="EmpGenderDynamicControl" runat="server" DataField="EmpGender" Mode="ReadOnly" />
                <br />

            </ItemTemplate>
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
        </asp:FormView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EmployeeTableConnectionString %>" SelectCommand="SELECT * FROM [EmployeeTable]"></asp:SqlDataSource>
    </form>
</body>
</html>
