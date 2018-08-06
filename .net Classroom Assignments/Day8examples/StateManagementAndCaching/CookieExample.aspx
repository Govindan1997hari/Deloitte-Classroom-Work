<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CookieExample.aspx.cs" Inherits="StateManagementAndCaching.CookieExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>

    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td>Enter UserName</td>
                <td>
                    <asp:TextBox ID="tbusername" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Enter Password</td>
                <td>
                    <asp:TextBox ID="tbpassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnadd" runat="server" OnClick="btnadd_Click" Text="Add cookie" />
                </td>
                <td>
                    <asp:Button ID="btnreadcookie" runat="server" OnClick="btnreadcookie_Click" Text="read cookie" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
