<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validation example.aspx.cs" Inherits="controlsexamples.WebForm2" %>

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
            width: 466px;
        }
        .auto-style3 {
            width: 260px;
        }
        .auto-style4 {
            width: 437px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table cellpadding="3" class="auto-style1">
            <tr>
                <td class="auto-style2" style="font-family: Cambria">Enter Name :</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox1" runat="server" BorderStyle="Solid" Width="215px"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" Display="None" ErrorMessage="Name Cannot Be Blank"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" style="font-family: Cambria">Enter Age :</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox2" runat="server" BorderStyle="Solid" Width="215px"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" Display="None" ErrorMessage="Age cannot be blank"></asp:RequiredFieldValidator>
&nbsp;&nbsp;
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox2" Display="None" ErrorMessage="Age Should be between 18 And 58" MaximumValue="59" MinimumValue="18" Type="Integer"></asp:RangeValidator>
&nbsp;&nbsp;
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox2" Display="None" ErrorMessage="Enter Only Numbers" ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" style="font-family: Cambria">Select Department :</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>Select</asp:ListItem>
                        <asp:ListItem>IT</asp:ListItem>
                        <asp:ListItem>Physics</asp:ListItem>
                        <asp:ListItem>Mathematics</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="DropDownList1" Display="None" ErrorMessage="Please Opt for a Department" InitialValue="Select"></asp:RequiredFieldValidator>
&nbsp;&nbsp; </td>
            </tr>
            <tr>
                <td class="auto-style2" style="font-family: Cambria">Enter Email :</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox3" runat="server" BorderStyle="Solid" Width="215px"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox3" Display="None" ErrorMessage="Please Enter the Email"></asp:RequiredFieldValidator>
&nbsp;&nbsp;
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox3" Display="None" ErrorMessage="Email Format Not Correct" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" style="font-family: Cambria">Enter Password :</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox4" runat="server" BorderStyle="Solid" Width="215px"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox4" Display="None" ErrorMessage="Please Enter the Password"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" style="font-family: Cambria">Retype Password to Confirm</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox5" runat="server" BorderStyle="Solid" Width="215px"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox5" Display="None" ErrorMessage="Please Enter the password"></asp:RequiredFieldValidator>
&nbsp;&nbsp;
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox4" ControlToValidate="TextBox5" Display="None" ErrorMessage="Password Dosent Match"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" style="font-family: Cambria">
                    <asp:Button ID="Button1" runat="server" Text="Submit" />
                </td>
                <td class="auto-style3">
                    <asp:Button ID="Button2" runat="server" CausesValidation="False" Text="Cancel" />
                </td>
                <td class="auto-style4">
                    <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </form>
</body>
</html>
