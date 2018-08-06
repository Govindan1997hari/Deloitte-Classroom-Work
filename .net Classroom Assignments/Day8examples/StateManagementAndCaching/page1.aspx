<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page1.aspx.cs" Inherits="StateManagementAndCaching.page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            background-color: #CCCCCC;
        }
        .auto-style2 {
            margin-left: 0px;
        }
        .auto-style3 {
            width: 153px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">Enter Name</td>
                <td>
                    <asp:TextBox ID="tbname" runat="server" CssClass="auto-style2"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Enter Age</td>
                <td>
                    <asp:TextBox ID="tbage" runat="server" CssClass="auto-style2"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Enter Email :</td>
                <td>
                    <asp:TextBox ID="tbemail" runat="server" CssClass="auto-style2"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="query String" Width="264px" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
