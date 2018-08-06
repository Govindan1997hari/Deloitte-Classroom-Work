<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="proj1.aspx.cs" Inherits="webprojects.proj1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border-style: solid;
            border-width: 2px;
        }
        .auto-style2 {
            width: 149px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table cellpadding="2" class="auto-style1" style="font-family: 'Berlin Sans FB'; font-size: large">
            <tr>
                <td class="auto-style2">Enter Name</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" BorderStyle="Solid" BorderWidth="2px" Width="249px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Enter Gender</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" BorderStyle="Solid" BorderWidth="2px" Width="249px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" BackColor="White" BorderStyle="Solid" OnClick="Button1_Click1" style="height: 26px" Text="Select" Width="159px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:GridView ID="GridView1" runat="server">
                    </asp:GridView>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
