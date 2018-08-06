<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterShopping.aspx.cs" Inherits="controlsexamples.RegisterShopping" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border: 2px solid #000000;
        }
        .auto-style2 {
            width: 331px;
        }
        .auto-style3 {
            width: 331px;
            height: 33px;
        }
        .auto-style4 {
            height: 33px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table align="left" cellpadding="2" class="auto-style1">
            <tr>
                <td class="auto-style2">Enter Name</td>
                <td>
                    <asp:TextBox ID="tbname" runat="server" BorderColor="#999999" BorderStyle="Solid" Font-Names="Berlin Sans FB" Font-Size="Large" Width="210px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Select Gender</td>
                <td>
                    <asp:DropDownList ID="dplgender" runat="server">
                        <asp:ListItem> </asp:ListItem>
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Select Membership</td>
                <td>
                    <asp:RadioButton ID="rbmale" runat="server" GroupName="membership" Text="Free" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RadioButton ID="rbfemale" runat="server" GroupName="membership" Text="Paid" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Select Shopping Preference</td>
                <td class="auto-style4">
                    <asp:CheckBoxList ID="cblshopping" runat="server">
                        <asp:ListItem>cosmetics</asp:ListItem>
                        <asp:ListItem>Shoes</asp:ListItem>
                        <asp:ListItem>Geans</asp:ListItem>
                        <asp:ListItem>Tshirts</asp:ListItem>
                        <asp:ListItem>Shirts</asp:ListItem>
                        <asp:ListItem>Casual Wears</asp:ListItem>
                    </asp:CheckBoxList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Prefer Cod ?</td>
                <td>
                    <asp:CheckBox ID="cbcod" runat="server" Text="COD?" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Enter Password</td>
                <td>
                    <asp:TextBox ID="tbpass" runat="server" BorderColor="#999999" BorderStyle="Solid" Font-Names="Berlin Sans FB" Font-Size="Large" TextMode="Password" Width="210px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" Text="Register" Width="103px" />
                </td>
                <td>
                    <asp:Label ID="lb1" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
