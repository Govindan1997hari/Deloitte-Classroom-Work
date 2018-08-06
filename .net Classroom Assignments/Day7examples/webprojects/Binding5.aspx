<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Binding5.aspx.cs" Inherits="webprojects.Binding5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DataList ID="DataList1" runat="server" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyField="Id" DataSourceID="SqlDataSource1" GridLines="Both" RepeatDirection="Horizontal">
            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
            <ItemStyle BackColor="White" ForeColor="#330099" />
            <ItemTemplate>
                Id:
                <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                <br />
                name:
                <asp:Label ID="nameLabel" runat="server" Text='<%# Eval("name") %>' />
                <br />
                gender:
                <asp:Label ID="genderLabel" runat="server" Text='<%# Eval("gender") %>' />
                <br />
                membership:
                <asp:Label ID="membershipLabel" runat="server" Text='<%# Eval("membership") %>' />
                <br />
                shoppingpreference:
                <asp:Label ID="shoppingpreferenceLabel" runat="server" Text='<%# Eval("shoppingpreference") %>' />
                <br />
                COD:
                <asp:Label ID="CODLabel" runat="server" Text='<%# Eval("COD") %>' />
                <br />
                passw:
                <asp:Label ID="passwLabel" runat="server" Text='<%# Eval("passw") %>' />
                <br />
<br />
            </ItemTemplate>
            <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
        </asp:DataList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TrainingDBConnectionString %>" SelectCommand="SELECT * FROM [RegisterShopping]"></asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
