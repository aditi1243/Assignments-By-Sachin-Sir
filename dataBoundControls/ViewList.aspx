<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListViewaspx.aspx.cs" Inherits="DataBoundContrl.ListViewaspx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1">
            <AlternatingItemTemplate>
                <td runat="server" style="background-color:#FFF8DC;">EmpID:
                    <asp:Label ID="EmpIDLabel" runat="server" Text='<%# Eval("EmpID") %>' />
                    <br />
                    EmpName:
                    <asp:Label ID="EmpNameLabel" runat="server" Text='<%# Eval("EmpName") %>' />
                    <br />
                    EmpEmailID:
                    <asp:Label ID="EmpEmailIDLabel" runat="server" Text='<%# Eval("EmpEmailID") %>' />
                    <br />
                    EmpMobileNo:
                    <asp:Label ID="EmpMobileNoLabel" runat="server" Text='<%# Eval("EmpMobileNo") %>' />
                    <br />
                    EmpImage:
                    <asp:Label ID="EmpImageLabel" runat="server" Text='<%# Eval("EmpImage") %>' />
                    <br />
                    EmpGender:
                    <asp:Label ID="EmpGenderLabel" runat="server" Text='<%# Eval("EmpGender") %>' />
                    <br />
                </td>
            </AlternatingItemTemplate>
            <EditItemTemplate>
                <td runat="server" style="background-color:#008A8C;color: #FFFFFF;">EmpID:
                    <asp:TextBox ID="EmpIDTextBox" runat="server" Text='<%# Bind("EmpID") %>' />
                    <br />
                    EmpName:
                    <asp:TextBox ID="EmpNameTextBox" runat="server" Text='<%# Bind("EmpName") %>' />
                    <br />
                    EmpEmailID:
                    <asp:TextBox ID="EmpEmailIDTextBox" runat="server" Text='<%# Bind("EmpEmailID") %>' />
                    <br />
                    EmpMobileNo:
                    <asp:TextBox ID="EmpMobileNoTextBox" runat="server" Text='<%# Bind("EmpMobileNo") %>' />
                    <br />
                    EmpImage:
                    <asp:TextBox ID="EmpImageTextBox" runat="server" Text='<%# Bind("EmpImage") %>' />
                    <br />
                    EmpGender:
                    <asp:TextBox ID="EmpGenderTextBox" runat="server" Text='<%# Bind("EmpGender") %>' />
                    <br />
                    <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                </td>
            </EditItemTemplate>
            <EmptyDataTemplate>
                <table style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                    <tr>
                        <td>No data was returned.</td>
                    </tr>
                </table>
            </EmptyDataTemplate>
            <InsertItemTemplate>
                <td runat="server" style="">EmpID:
                    <asp:TextBox ID="EmpIDTextBox" runat="server" Text='<%# Bind("EmpID") %>' />
                    <br />EmpName:
                    <asp:TextBox ID="EmpNameTextBox" runat="server" Text='<%# Bind("EmpName") %>' />
                    <br />EmpEmailID:
                    <asp:TextBox ID="EmpEmailIDTextBox" runat="server" Text='<%# Bind("EmpEmailID") %>' />
                    <br />EmpMobileNo:
                    <asp:TextBox ID="EmpMobileNoTextBox" runat="server" Text='<%# Bind("EmpMobileNo") %>' />
                    <br />EmpImage:
                    <asp:TextBox ID="EmpImageTextBox" runat="server" Text='<%# Bind("EmpImage") %>' />
                    <br />EmpGender:
                    <asp:TextBox ID="EmpGenderTextBox" runat="server" Text='<%# Bind("EmpGender") %>' />
                    <br />
                    <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                </td>
            </InsertItemTemplate>
            <ItemTemplate>
                <td runat="server" style="background-color:#DCDCDC;color: #000000;">EmpID:
                    <asp:Label ID="EmpIDlabel" runat="server" Text='<%# Eval("EmpID") %>' />
                    <br />
                    EmpName:
                    <asp:Label ID="EmpNameLabel" runat="server" Text='<%# Eval("EmpName") %>' />
                    <br />
                    EmpEmailID:
                    <asp:Label ID="EmpEmailIDLabel" runat="server" Text='<%# Eval("EmpEmailID") %>' />
                    <br />
                    EmpMobileNo:
                    <asp:Label ID="EmpMobileNoLabel" runat="server" Text='<%# Eval("EmpMobileNo") %>' />
                    <br />
                    EmpImage:
                    <asp:Label ID="EmpImageLabel" runat="server" Text='<%# Eval("EmpImage") %>' />
                    <br />
                    EmpGender:
                    <asp:Label ID="EmpGenderLabel" runat="server" Text='<%# Eval("EmpGender") %>' />
                    <br />
                </td>
            </ItemTemplate>
            <LayoutTemplate>
                <table runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                    <tr id="itemPlaceholderContainer" runat="server">
                        <td id="itemPlaceholder" runat="server"></td>
                    </tr>
                </table>
                <div style="text-align: center;background-color: #CCCCCC;font-family: Verdana, Arial, Helvetica, sans-serif;color: #000000;">
                </div>
            </LayoutTemplate>
            <SelectedItemTemplate>
                <td runat="server" style="background-color:#008A8C;font-weight: bold;color: #FFFFFF;">EmpID:
                    <asp:Label ID="EmpIDLabel" runat="server" Text='<%# Eval("EmpID") %>' />
                    <br />
                    EmpName:
                    <asp:Label ID="EmpNameLabel" runat="server" Text='<%# Eval("EmpName") %>' />
                    <br />
                    EmpEmailID:
                    <asp:Label ID="EmpEmailIDLabel" runat="server" Text='<%# Eval("EmpEmailID") %>' />
                    <br />
                    EmpMobileNo:
                    <asp:Label ID="EmpMobileNoLabel" runat="server" Text='<%# Eval("EmpMobileNo") %>' />
                    <br />
                    EmpImage:
                    <asp:Label ID="EmpImageLabel" runat="server" Text='<%# Eval("EmpImage") %>' />
                    <br />
                    EmpGender:
                    <asp:Label ID="EmpGenderLabel" runat="server" Text='<%# Eval("EmpGender") %>' />
                    <br />
                </td>
            </SelectedItemTemplate>
        </asp:ListView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EmployeeTableConnectionString %>" SelectCommand="SELECT * FROM [EmployeeTable]"></asp:SqlDataSource>
    </form>
</body>
</html>
