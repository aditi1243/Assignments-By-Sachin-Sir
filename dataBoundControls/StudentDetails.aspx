<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="DataBoundContrl.Employee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 63%;
            height: 241px;
        }
        .auto-style2 {
            width: 143px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%--<table style="border:2px solid red;text-align:left;border-radius:2px;
              width:300px; padding-top:2px; background-Color:lime; border-radius:8px; Font-Size="20px" ></table>--%>

            <asp:Repeater ID="RP1" runat="server" DataSourceID="SqlDataSource2" >
            <HeaderTemplate>
               <table style="width:200px; padding-top:0px; background-color:gold" >
                   <tr>
                       <td style="font-size:20px; text-align:center;height:48px"; />
                   <asp:Label ID="Lbl1" runat="server" Text=" Employee Profile" />
                   
                   </tr>

               </table>
            </HeaderTemplate>
                <ItemTemplate>
                    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Text="studentID"></asp:Label>
                </td>
                <td>&nbsp;
                 <asp:Label ID="Label7" runat="server"  Text='<%#Eval("StudentID") %>'></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label2" runat="server" Text="StudentName"></asp:Label>
                </td>
                <td>&nbsp;
             <asp:Label ID="Label8" runat="server"  Text='<%#Eval("StudentName") %>'> </asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label3" runat="server" Text="StudentEmailID"></asp:Label>
                </td>
                <td>&nbsp;
            <asp:Label ID="Label9" runat="server"  Text='<%#Eval("StudentEmailID") %>'> </asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label4" runat="server" Text="StudentMobileNo"></asp:Label>
                </td>
                <td>&nbsp;
           <asp:Label ID="Label10" runat="server"  Text='<%#Eval("StudentMobileNo") %>'> </asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label11" runat="server" Text="StudentImage"></asp:Label>
                </td>
                <td rowspan="5">&nbsp;
                    <asp:Image ID="img1" runat="server" Width="100px" ImageUrl='<%#"~/Pictures/" + Eval("StudentImage") %>' />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label6" runat="server" Text="StudentGender"></asp:Label>
                </td>
                <td>&nbsp;
                             <asp:Label ID="Label5" runat="server"  Text='<%#Eval("StudentGender") %>'> </asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
	 <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label12" runat="server" Text="StudentRollNo"></asp:Label>
                </td>
                <td>&nbsp;
                             <asp:Label ID="Label13" runat="server"  Text='<%#Eval("StudentRollNo") %>'> </asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
	 <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label14" runat="server" Text="StudentCity"></asp:Label>
                </td>
                <td>&nbsp;
                             <asp:Label ID="Label15" runat="server"  Text='<%#Eval("StudentCity") %>'> </asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
	 <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label16" runat="server" Text="StudentAddress"></asp:Label>
                </td>
                <td>&nbsp;
                             <asp:Label ID="Label17" runat="server"  Text='<%#Eval("StudentAddress") %>'> </asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
   
                </ItemTemplate>
                <FooterTemplate>
                    <table>
                        <tr>
                            <td>
                                @Developed by Aditi<br></br>

                                @2020 All the CopyRights are Reserved
                            </td>
                        </tr>



                    </table>
                </FooterTemplate>
            </asp:Repeater>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:EmployeeTableConnectionString %>" SelectCommand="SELECT * FROM [EmployeeTable]"></asp:SqlDataSource>
            </div>
        </form>
            
           
</body>
</html>
