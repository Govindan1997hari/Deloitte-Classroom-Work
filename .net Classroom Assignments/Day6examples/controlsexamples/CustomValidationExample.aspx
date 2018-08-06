<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomValidationExample.aspx.cs" Inherits="controlsexamples.CustomValidationExample" %>

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
    
        <table cellpadding="3" class="auto-style1">
            <tr>
                <td>Enter Name( In BLOCK)</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Name Not In Block" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Button" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
