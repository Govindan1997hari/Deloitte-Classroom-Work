<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertUserInfo.aspx.cs" Inherits="webprojects.InsertUserInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            background-color: #C0C0C0;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table cellspacing="1" class="auto-style1" style="font-family: 'Berlin Sans FB'; color: #000000; background-color: #FFFFFF;">
            <tr>
                <td>Enter Name</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" BorderStyle="Solid" BorderWidth="2px" Width="249px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Status</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" BorderStyle="Solid" BorderWidth="2px" Enabled="False" Width="249px">Inactive</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" BackColor="White" BorderStyle="Solid" OnClick="Button1_Click1" style="height: 26px" Text="Insert" Width="159px" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
