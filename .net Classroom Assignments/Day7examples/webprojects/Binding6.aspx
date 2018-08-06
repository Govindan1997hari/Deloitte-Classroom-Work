<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Binding6.aspx.cs" Inherits="webprojects.Binding6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
            <HeaderTemplate>
                <table border="1">
                    <tr>
                        <td style="background-color:aqua;font-size:large">Register Shopping Data</td>
                    </tr>
                </table>
            </HeaderTemplate>
            <ItemTemplate>
                <table border="1" style="background-color:cornflowerblue;font-size:large">
                    <tr>
                        <th>ID</th>
                        <th>Name</th>
                        <th>Gender</th>
                        <th>Membership</th>
                        <th>Shopping Preference</th>
                        <th>COD</th>
                        <th>Password</th>
                    </tr>
                    <tr>
                        <td><%#Eval("id") %></td>
                        <td><%# Eval("name") %></td>
                        <td><%# Eval("gender") %></td>
                        <td><%# Eval("membership") %></td>
                        <td><%# Eval("shoppingpreference") %></td>
                        <td><%# Eval("COD") %></td>
                        <td><%# Eval("passw") %></td>
                        
                    </tr>
                </table>
            </ItemTemplate>
            <FooterTemplate>
                <h1> End Of Date :) </h1>
            </FooterTemplate>
        </asp:Repeater>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:TrainingDBConnectionString %>" DeleteCommand="DELETE FROM [RegisterShopping] WHERE [Id] = @original_Id AND [name] = @original_name AND [gender] = @original_gender AND [membership] = @original_membership AND [shoppingpreference] = @original_shoppingpreference AND [COD] = @original_COD AND [passw] = @original_passw" InsertCommand="INSERT INTO [RegisterShopping] ([name], [gender], [membership], [shoppingpreference], [COD], [passw]) VALUES (@name, @gender, @membership, @shoppingpreference, @COD, @passw)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [RegisterShopping]" UpdateCommand="UPDATE [RegisterShopping] SET [name] = @name, [gender] = @gender, [membership] = @membership, [shoppingpreference] = @shoppingpreference, [COD] = @COD, [passw] = @passw WHERE [Id] = @original_Id AND [name] = @original_name AND [gender] = @original_gender AND [membership] = @original_membership AND [shoppingpreference] = @original_shoppingpreference AND [COD] = @original_COD AND [passw] = @original_passw">
            <DeleteParameters>
                <asp:Parameter Name="original_Id" Type="Int32" />
                <asp:Parameter Name="original_name" Type="String" />
                <asp:Parameter Name="original_gender" Type="String" />
                <asp:Parameter Name="original_membership" Type="String" />
                <asp:Parameter Name="original_shoppingpreference" Type="String" />
                <asp:Parameter Name="original_COD" Type="String" />
                <asp:Parameter Name="original_passw" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="name" Type="String" />
                <asp:Parameter Name="gender" Type="String" />
                <asp:Parameter Name="membership" Type="String" />
                <asp:Parameter Name="shoppingpreference" Type="String" />
                <asp:Parameter Name="COD" Type="String" />
                <asp:Parameter Name="passw" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="name" Type="String" />
                <asp:Parameter Name="gender" Type="String" />
                <asp:Parameter Name="membership" Type="String" />
                <asp:Parameter Name="shoppingpreference" Type="String" />
                <asp:Parameter Name="COD" Type="String" />
                <asp:Parameter Name="passw" Type="String" />
                <asp:Parameter Name="original_Id" Type="Int32" />
                <asp:Parameter Name="original_name" Type="String" />
                <asp:Parameter Name="original_gender" Type="String" />
                <asp:Parameter Name="original_membership" Type="String" />
                <asp:Parameter Name="original_shoppingpreference" Type="String" />
                <asp:Parameter Name="original_COD" Type="String" />
                <asp:Parameter Name="original_passw" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
