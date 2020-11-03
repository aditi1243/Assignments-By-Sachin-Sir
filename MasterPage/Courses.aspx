<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="WebAppForTechCourses.ContactUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 259px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table style="width:100%;">
        <tr>
            <td class="auto-style1">List of Courses&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Course</td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" Width="317px">
                    <asp:ListItem>Python</asp:ListItem>
                    <asp:ListItem>Java</asp:ListItem>
                    <asp:ListItem>ASP.Net</asp:ListItem>
                    <asp:ListItem>CSharp</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>

</asp:Content>