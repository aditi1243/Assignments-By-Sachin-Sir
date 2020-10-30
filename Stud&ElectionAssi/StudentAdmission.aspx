<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentAdmission.aspx.cs" Inherits="RangeValidation.StudentAdmission" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 95%;
            height: 86px;
        }
        .auto-style2 {
            width: 235px;
        }
        .auto-style3 {
            width: 533px;
        }
        .auto-style4 {
            width: 814px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Firstname</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox1" runat="server" Width="386px"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Firstname required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Lastname</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox2" runat="server" Width="383px"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Lastname required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Father&#39;s Name</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox3" runat="server" Width="382px"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Father's name required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Mother&#39;s Name</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox4" runat="server" Width="377px"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="Mother's name required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Gender</td>
                <td class="auto-style3">&nbsp;
                    <asp:RadioButton ID="RadioButton1" runat="server" GroupName="Gender" Text="Male" />
&nbsp;&nbsp;
                    <asp:RadioButton ID="RadioButton2" runat="server" GroupName="Gender" Text="Female" />
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Aggregate</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                  <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="textbox5" ErrorMessage="Aggregate should be greater than 60%" MaximumValue="100" MinimumValue="60" Type="Integer"></asp:RangeValidator>
		   </td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Courses</td>
                <td class="auto-style3">
                    <asp:RadioButton ID="RadioButton3" runat="server" GroupName="Course" Text="CSE" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RadioButton ID="RadioButton4" runat="server" GroupName="Courses" Text="ECE" />
                </td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:CheckBox ID="CheckBox1" runat="server" Text="Computer Architecture Organisation" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:CheckBox ID="CheckBox4" runat="server" Text="Microcontroller" />
                    <br />
                    <br />
                    <asp:CheckBox ID="CheckBox2" runat="server" Text="Data Structures" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:CheckBox ID="CheckBox5" runat="server" Text="Logic Design" />
                    <br />
                    <br />
                    <asp:CheckBox ID="CheckBox3" runat="server" Text="Computer Network" />
&nbsp;&nbsp;&nbsp;
                    <asp:CheckBox ID="CheckBox6" runat="server" Text="Analog Communications" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                </td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
        </table>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" Width="156px" />
   
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </form>
</body>
</html>
