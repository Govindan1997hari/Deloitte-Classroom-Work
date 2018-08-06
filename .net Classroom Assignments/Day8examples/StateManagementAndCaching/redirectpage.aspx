<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="redirectpage.aspx.cs" Inherits="StateManagementAndCaching.redirectpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="showdata" />
                </td>
                <td class="auto-style2">
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="timeout" />
                </td>
                <td class="auto-style2">
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="abandon" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
